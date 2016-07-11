using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using CommonClass;
using System.Configuration;
using System.Data.OleDb;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace ITInventory
{
    public partial class MainWindow : Form
    {
        private DB ITInventory = new DB(ConfigurationManager.ConnectionStrings["ITInventory.Properties.Settings.ConnStr2ITInventory"].ConnectionString);
        private Templetes templetes = new Templetes();
        private TreeNodeEx clipbrdNode;
        private TreeNodeEx dragDropNode;
        private TreeNodeEx lastDragOverNode;
        private string gdvwContent;
        private DataGridView menuStripCaller;

        /***************************************************************/
        /*              定义数据库操作完成后的事件通知                 */
        /***************************************************************/
        private delegate void SaveDeviceCompleteHandler();
        private SaveDeviceCompleteHandler OnSaveDeviceCompleteEvent;
        private event SaveDeviceCompleteHandler SaveDeviceCompleteEvent
        {
            add { OnSaveDeviceCompleteEvent += new SaveDeviceCompleteHandler(value); }
            remove { OnSaveDeviceCompleteEvent -= new SaveDeviceCompleteHandler(value); }
        }

        /***************************************************************/
        /*                定义数据库操作中的事务委托                   */
        /***************************************************************/
        private delegate bool BeginTransaction();
        private BeginTransaction _BeginTransaction;
        private delegate void EndTransaction();
        private EndTransaction _EndTransaction;
        private delegate void RollbackTransaction();
        private RollbackTransaction _RollbackTransaction;

        /***************************************************************/
        /*                定义数据库操作中的函数委托                   */
        /***************************************************************/
        private delegate DBCode HasRecord(string table, string filter);
        private HasRecord _HasRecord;
        private delegate int InsertData(string tablename, Hashtable data);
        private InsertData _InsertData;
        private delegate DBCode UpdateRecord(string tablename, Hashtable data, string filter);
        private UpdateRecord _UpdateRecord;
        private delegate object ExecProcedure(string procName, OleDbParameter[] parameters);
        private ExecProcedure _ExecProcedure;
        private delegate DBCode ExecuteCommand(string sql, OleDbParameter[] parameters);
        private ExecuteCommand _ExecuteCommand;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            TreeNodeEx[] nodelist;
            if (trvwConfigDevice.SelectedNode == null)
            {
                ComponentDefine compo = new ComponentDefine(ComponentDefine.FormType.Device);
                compo.ComponentName = "新设备{n}";
                if (DialogResult.OK == compo.ShowDialog(this))
                {
                    if (compo.ComponentName.Contains("{n}"))
                    {
                        nodelist = new TreeNodeEx[compo.ComponentQuantity];
                        for (int i = 0; i < compo.ComponentQuantity; i++)
                        {
                            TreeNodeEx node = new TreeNodeEx(compo.ComponentName.Replace("{n}", (compo.Index + i).ToString()));
                            node.Name = "device";
                            node.Tag = compo.Tag.Clone();
                            ((Hashtable)node.Tag).Add("device_name", node.Text);
                            nodelist[i] = node;
                        }
                    }
                    else
                    {
                        TreeNodeEx node = new TreeNodeEx(compo.ComponentName);
                        node.Name = "device";
                        node.Tag = compo.Tag.Clone();
                        ((Hashtable)node.Tag).Add("device_name", node.Text);
                        nodelist = new TreeNodeEx[1];
                        nodelist[0] = node;
                    }
                    trvwConfigDevice.Nodes.AddRange(nodelist);
                }
            }
            else
            {
                ComponentDefine compo = new ComponentDefine(ComponentDefine.FormType.Component);
                compo.ComponentName = "新组件{n}";
                if (DialogResult.OK == compo.ShowDialog(this))
                {
                    if (compo.ComponentName.Contains("{n}"))
                    {
                        nodelist = new TreeNodeEx[compo.ComponentQuantity];
                        for (int i = 0; i < compo.ComponentQuantity; i++)
                        {
                            TreeNodeEx node = new TreeNodeEx(compo.ComponentName.Replace("{n}", (compo.Index + i).ToString()));
                            node.Name = "device";
                            node.Tag = compo.Tag.Clone();
                            ((Hashtable)node.Tag).Add("device_name", node.Text);
                            nodelist[i] = node;
                        }
                    }
                    else
                    {
                        TreeNodeEx node = new TreeNodeEx(compo.ComponentName);
                        node.Name = "device";
                        node.Tag = compo.Tag.Clone();
                        ((Hashtable)node.Tag).Add("device_name", node.Text);
                        nodelist = new TreeNodeEx[1];
                        nodelist[0] = node;
                    }
                    trvwConfigDevice.SelectedNode.Nodes.AddRange(nodelist);
                    trvwConfigDevice.SelectedNode = nodelist[0].Parent;
                    trvwConfigDevice.SelectedNode.Expand();
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: 这行代码将数据加载到表“dsDeviceType.DeviceTypeAll”中。您可以根据需要移动或删除它。
                this.deviceTypeAllTableAdapter.Fill(this.dsDeviceType.DeviceTypeAll);
                // TODO: 这行代码将数据加载到表“dsSpeedType.SocketSpeedType”中。您可以根据需要移动或删除它。
                this.socketSpeedTypeTableAdapter.Fill(this.dsSpeedType.SocketSpeedType);
                // TODO: 这行代码将数据加载到表“dsLogicType.SocketLogicType”中。您可以根据需要移动或删除它。
                this.socketLogicTypeTableAdapter.Fill(this.dsLogicType.SocketLogicType);
                // TODO: 这行代码将数据加载到表“dsPhyType.SocketPhyType”中。您可以根据需要移动或删除它。
                this.socketPhyTypeTableAdapter.Fill(this.dsPhyType.SocketPhyType);
                // TODO: 这行代码将数据加载到表“dsVender.VenderInfo”中。您可以根据需要移动或删除它。
                this.venderInfoTableAdapter.Fill(this.dsVender.VenderInfo);

                // TODO: 这行代码将数据加载到表“dsManufactory.Manufactory”中。您可以根据需要移动或删除它。
                this.manufactoryTableAdapter.Fill(this.dsManufactory.Manufactory);

                // TODO: 这行代码将数据加载到表“dsDeviceType.DeviceType”中。您可以根据需要移动或删除它。
                this.deviceTypeTableAdapter.Fill(this.dsDeviceType.DeviceType);
            }
            catch(OleDbException err)
            {
                Debug.WriteLine(err);
                MessageBox.Show("数据库连接失败！请检查连接字符串或联系DBA", "错误！");
                this.Close();
            }

            ClearFindParameter();
            ClearDeviceConfig();
            ClearSocketConfig();
            _BeginTransaction = ITInventory.BeginTransaction;
            _EndTransaction = ITInventory.EndTransaction;
            _RollbackTransaction = ITInventory.RollbackTransaction;
            _HasRecord = ITInventory.HasRecord;
            _InsertData = this.InsRecAndRtID;
            _UpdateRecord = ITInventory.UpdateRecord;
            _ExecProcedure = ITInventory.ExecProcedure;
            _ExecuteCommand = ITInventory.ExecuteCommand;
            SaveDeviceCompleteEvent += new SaveDeviceCompleteHandler(SaveDeviceComplete);

            ipv4Address.Enabled = ipv4Mask.Enabled = chkAddrInfo.Checked;

            string[] connStr = ConfigurationManager.ConnectionStrings["ITInventory.Properties.Settings.ConnStr2ITInventory"].ConnectionString.Split(';');
            tlstrplbDBServer.Text = "当前连接的服务器地址：" + connStr[1].Split('=')[1];
        }

        private void chkEnableDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpkWarrantyDate.Enabled = chkEnableDate.Checked;
            panlWarrantyDate.Enabled = chkEnableDate.Checked;
        }

        private void btnListDevice_Click(object sender, EventArgs e)
        {
            if(!ValidateInput())
            { return; }
            else
            {
                OleDbDataReader result = null;
                if (chkIP.Checked)
                {
                    if (!iPv4Start.IsNull())
                    {
                        OleDbParameter ipv4_start = new OleDbParameter("@ipv4_start", OleDbType.VarBinary, 4);
                        byte[] tmp = System.BitConverter.GetBytes(TCPIP.Str2UintAddr4(iPv4Start.Text));
                        Array.Reverse(tmp);                                                                     //将c#的默认小端字节序反转成大端字节序
                        ipv4_start.Value = tmp;
                        OleDbParameter ipv4_end = new OleDbParameter("@ipv4_end", OleDbType.VarBinary, 4);
                        if (iPv4End.IsNull())
                        {
                            ipv4_end.Value = ipv4_start.Value;
                        }
                        else
                        {
                            tmp = System.BitConverter.GetBytes(TCPIP.Str2UintAddr4(iPv4End.Text));
                            Array.Reverse(tmp);
                            ipv4_end.Value = tmp;
                        }
                        if (TCPIP.IsIPv4FormatValid(iPv4Start.Text))
                        {
                            string tmpfilter = "$filter$ device_parent_id_ref IS NULL AND disabled = 0 ORDER BY device_name";
                            tmpfilter = tmpfilter.Replace("$filter$", GenFilter());
                            OleDbParameter filter = new OleDbParameter("@filter", OleDbType.VarChar);
                            filter.Value = tmpfilter;
                            result = ITInventory.ExecProcedureReader("GetDeviceByIPv4", new OleDbParameter[] { ipv4_start, ipv4_end, filter });
                        }
                        else
                        {
                            result = ITInventory.ExecProcedureReader("GetDeviceByIPv4", new OleDbParameter[] { ipv4_start, ipv4_end });
                        }
                    }
                    else
                    {
                        string sql = "SELECT device_info_id,device_name FROM DeviceInfo WHERE $filter$ device_parent_id_ref IS NULL AND disabled=0 ORDER BY device_name";
                        sql = sql.Replace("$filter$", GenFilter());
                        Debug.WriteLine(sql);
                        result = ITInventory.GetData(sql);
                    }
                }
                else
                {
                    string sql = "SELECT device_info_id,device_name FROM DeviceInfo WHERE $filter$ device_parent_id_ref IS NULL AND disabled=0 ORDER BY device_name";
                    sql = sql.Replace("$filter$", GenFilter());
                    Debug.WriteLine(sql);
                    result = ITInventory.GetData(sql);
                }
                if (result != null && result.HasRows)
                {
                    listDevices.Items.Clear();
                    int count = 0;
                    while (result.Read())
                    {
                        TreeNodeEx node = new TreeNodeEx(result["device_name"].ToString());
                        node.Tag = (int)result["device_info_id"];
                        //node.ID = (int)result["device_info_id"];
                        listDevices.Items.Add(node);
                        count++;
                    }
                    result.Close();
                    listDevices.Focus();
                    tlstrplbDeviceCount.Text = "查询到的设备合计：" + count.ToString() + "台";
                }
                else
                {
                    try
                    {
                        result.Close();
                    }
                    catch(Exception err)
                    {
                        Debug.WriteLine(err);
                    }
                    MessageBox.Show("未查到结果。");
                    txtDeviceName.Focus();
                }
            } 
            ClearFindParameter();
            listDevices_SelectedIndexChanged(null, null);
        }

        private bool ValidateInput()
        {
            if (rdoNamePrecise.Checked && txtDeviceName.Text=="")
            {
                MessageBox.Show("精确模式下请输入查询内容！", "注意！");
                return false;
            }
            if(rdoModulePrecise.Checked && txtDeviceModule.Text=="")
            {
                MessageBox.Show("精确模式下请输入查询内容！", "注意！");
                return false;
            }
            return true;
        }

        private void listDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDevices.SelectedItem != null)
            {
                int device_info_id = (int)((TreeNodeEx)listDevices.SelectedItem).Tag;
                //int device_info_id = ((TreeNodeEx)listDevices.SelectedItem).ID;
                if (trvwDevice.Nodes.Count>0 && (int)trvwDevice.Nodes[0].Tag/*((TreeNodeEx)trvwDevice.Nodes[0]).ID*/ == device_info_id && sender!=null)
                {
                    return;
                }
                else
                {
                    gdvwDeviceInfo.DataSource = this.getModulesBindingSource;
                    this.getModulesTableAdapter.Fill(dsDeviceInfo.GetModules, "", device_info_id);
                    gdvwSocketInfo.DataSource = this.getSocketsBindingSource;
                    this.getSocketsTableAdapter.Fill(dsSocketInfo.GetSockets, device_info_id);
                    gdvwDeviceInfo.ClearSelection();
                    DataRow[] rows = dsDeviceInfo.GetModules.Select("device_info_id=" + device_info_id.ToString());
                    TreeNodeEx root = new TreeNodeEx(rows[0]["device_name"].ToString());
                    if (sender == null)
                    {
                        ((TreeNodeEx)listDevices.SelectedItem).Text = root.Text;
                    }
                    root.Tag = rows[0]["device_info_id"];
                    //root.ID = (int)rows[0]["device_info_id"];
                    root.Name = "device";
                    CreateDeviceTree(root, true);
                    trvwDevice.Nodes.Clear();
                    trvwDevice.Nodes.AddRange(new TreeNodeEx[] { root });
                    trvwDevice.ExpandAll();
                }
            }
            else
            {
                trvwDevice.Nodes.Clear();
                gdvwDeviceInfo.DataSource = null;
                gdvwSocketInfo.DataSource = null;
            }
        }

        private void CreateDeviceTree(TreeNodeEx pNode,bool parentDevice)
        {
            if (parentDevice)
            {
                DataRow[] devicerows = dsDeviceInfo.GetModules.Select("device_parent_id_ref=" + pNode.Tag.ToString()/*pNode.ID*/);
                DataRow[] socketrows = dsSocketInfo.GetSockets.Select("device_info_id_ref=" + pNode.Tag.ToString()/*pNode.ID*/);
                foreach (DataRow row in devicerows)
                {
                    TreeNodeEx child = new TreeNodeEx(row["device_name"].ToString());
                    child.Tag = row["device_info_id"];
                    //child.ID = (int)row["device_info_id"];
                    child.Name = "device";
                    int countdevice = (int)dsDeviceInfo.GetModules.Compute("COUNT(LEVEL)", "device_parent_id_ref=" + child.Tag.ToString()/*child.ID*/);
                    int countsocket = (int)dsSocketInfo.GetSockets.Compute("COUNT(LEVEL)", "device_info_id_ref=" + child.Tag.ToString()/*child.ID*/);
                    if (countdevice >= 1 || countsocket >= 1)
                    {
                        CreateDeviceTree(child,true);
                    }
                    pNode.Nodes.AddRange(new TreeNodeEx[] { child });
                }
                foreach (DataRow row in socketrows)
                {
                    TreeNodeEx child = new TreeNodeEx(row["socket_name"].ToString());
                    child.Tag = row["socket_id"];
                    //child.ID = (int)row["socket_id"];
                    child.Name = "socket";
                    int countsocket = (int)dsSocketInfo.GetSockets.Compute("COUNT(LEVEL)", "socket_owner_id_ref=" + child.Tag.ToString()/*child.ID*/);
                    if (countsocket >= 1)
                    {
                        CreateDeviceTree(child,false);
                    }
                    pNode.Nodes.AddRange(new TreeNodeEx[] { child });
                }
            }
            else
            {
                DataRow[] socketrows = dsSocketInfo.GetSockets.Select("socket_owner_id_ref=" + pNode.Tag.ToString()/*pNode.ID*/);
                foreach (DataRow row in socketrows)
                {
                    TreeNodeEx child = new TreeNodeEx(row["socket_name"].ToString());
                    child.Tag = row["socket_id"];
                    //child.ID = (int)row["socket_id"];
                    child.Name = "socket";
                    int countsocket = (int)dsSocketInfo.GetSockets.Compute("COUNT(LEVEL)", "socket_owner_id_ref=" + child.Tag.ToString()/*child.ID*/);
                    if (countsocket >= 1)
                    {
                        CreateDeviceTree(child, false);
                    }
                    pNode.Nodes.AddRange(new TreeNodeEx[] { child });
                }
            }
        }

        private void trvwDevice_AfterSelect(object sender, TreeViewEventArgs e)
        {
            gdvwDeviceInfo.ClearSelection();
            gdvwSocketInfo.ClearSelection();
            int index = 0;
            switch(e.Node.Name)
            {
                case "device":
                    index = dsDeviceInfo.GetModules.Rows.IndexOf(dsDeviceInfo.GetModules.Select(
                        "device_info_id=" + e.Node.Tag.ToString()/*((TreeNodeEx)e.Node).ID.ToString()*/)[0]);
                    gdvwDeviceInfo.Rows[index].Selected = true;
                    gdvwDeviceInfo.FirstDisplayedScrollingRowIndex = index;
                    break;
                case "socket":
                    index = dsSocketInfo.GetSockets.Rows.IndexOf(dsSocketInfo.GetSockets.Select(
                        "socket_id=" + e.Node.Tag.ToString()/*((TreeNodeEx)e.Node).ID.ToString()*/)[0]);
                    gdvwSocketInfo.Rows[index].Selected = true;
                    gdvwSocketInfo.FirstDisplayedScrollingRowIndex = index;
                    break;
                default:
                    break;
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            ClearFindParameter();
            txtDeviceName.Focus();
        }

        private void ClearFindParameter()
        {
            txtDeviceName.Text = txtDeviceModule.Text = "";
            rdoNameFuzzy.Checked = rdoModuleFuzzy.Checked = rdoWarrantyIn.Checked = true;
            dtpkWarrantyDate.Value = DateTime.Now;
            chkEnableDate.Checked = false;
            cmbDeviceType.SelectedIndex = cmbManufactory.SelectedIndex = cmbVender.SelectedIndex = -1;
            iPv4Start.Clear();
            iPv4End.Clear();
            chkIP.Checked = false;
        }

        private void trvwConfigDevice_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Debug.WriteLine(trvwConfigDevice.SelectedNode.Tag);
            RefreshDeviceConfigTab();
        }

        private void btnDeleteDevice_Click(object sender, EventArgs e)
        {
            if(trvwConfigDevice.SelectedNode==null)
            {
                MessageBox.Show("请选择一个节点！");
            }
            else if(trvwConfigDevice.SelectedNode.Nodes.Count > 0 && DialogResult.Yes==MessageBox.Show("该操作将同时从数据库删除节点信息，是否继续？","注意！",MessageBoxButtons.YesNo,MessageBoxIcon.Warning))
            {
                if (MessageBox.Show("还有子设备未删除，确认删除该设备？", "注意！", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if(trvwConfigDevice.SelectedNode.Parent==null && trvwConfigDevice.SelectedNode.Tag is Hashtable && ((Hashtable)trvwConfigDevice.SelectedNode.Tag).ContainsKey("device_info_id") &&(int)((Hashtable)trvwConfigDevice.SelectedNode.Tag)["device_info_id"]==(int)((TreeNodeEx)listDevices.SelectedItem).Tag)
                    {
                        listDevices.Items.Remove(listDevices.SelectedItem);
                    }
                    if (trvwConfigDevice.SelectedNode.Tag is Hashtable)
                    {
                        switch (trvwConfigDevice.SelectedNode.Name)
                        {
                            case "device":
                                if (((Hashtable)trvwConfigDevice.SelectedNode.Tag).ContainsKey("device_info_id"))
                                {
                                    int id = (int)((Hashtable)trvwConfigDevice.SelectedNode.Tag)["device_info_id"];
                                    if (ITInventory.HasRecord("DeviceInfo", "device_info_id=" + id.ToString())==DBCode.HasRecord)
                                    {
                                        OleDbParameter device_id = new OleDbParameter("@device_id", OleDbType.Integer);
                                        device_id.Value = id;
                                        ITInventory.ExecProcedure("DelModules", new OleDbParameter[] { device_id });
                                    }
                                }
                                break;
                            case "socket":
                                if(((Hashtable)trvwConfigDevice.SelectedNode.Tag).ContainsKey("socket_id"))
                                {
                                    int id = (int)((Hashtable)trvwConfigDevice.SelectedNode.Tag)["socket_id"];
                                    if(ITInventory.HasRecord("SocketInfo","socket_id="+id.ToString())==DBCode.HasRecord)
                                    {
                                        OleDbParameter socket_id = new OleDbParameter("@socket_id", OleDbType.Integer);
                                        socket_id.Value = id;
                                        ITInventory.ExecProcedure("DelSockets", new OleDbParameter[] { socket_id });
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    trvwConfigDevice.Nodes.Remove(trvwConfigDevice.SelectedNode);
                }
            }
            else if (DialogResult.Yes == MessageBox.Show("该操作将同时从数据库删除节点信息，是否继续？", "注意！", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (trvwConfigDevice.SelectedNode.Parent == null && trvwConfigDevice.SelectedNode.Tag is Hashtable && ((Hashtable)trvwConfigDevice.SelectedNode.Tag).ContainsKey("device_info_id") && (int)((Hashtable)trvwConfigDevice.SelectedNode.Tag)["device_info_id"] == (int)((TreeNodeEx)listDevices.SelectedItem).Tag)
                {
                    listDevices.Items.Remove(listDevices.SelectedItem);
                }
                if (trvwConfigDevice.SelectedNode.Tag is Hashtable)
                {
                    switch (trvwConfigDevice.SelectedNode.Name)
                    {
                        case "device":
                            if (((Hashtable)trvwConfigDevice.SelectedNode.Tag).ContainsKey("device_info_id"))
                            {
                                int id = (int)((Hashtable)trvwConfigDevice.SelectedNode.Tag)["device_info_id"];
                                if (ITInventory.HasRecord("DeviceInfo", "device_info_id=" + id.ToString())==DBCode.HasRecord)
                                {
                                    OleDbParameter device_id = new OleDbParameter("@device_id", OleDbType.Integer);
                                    device_id.Value = id;
                                    ITInventory.ExecProcedure("DelModules", new OleDbParameter[] { device_id });
                                }
                            }
                            break;
                        case "socket":
                            if (((Hashtable)trvwConfigDevice.SelectedNode.Tag).ContainsKey("socket_id"))
                            {
                                int id = (int)((Hashtable)trvwConfigDevice.SelectedNode.Tag)["socket_id"];
                                if (ITInventory.HasRecord("SocketInfo", "socket_id=" + id.ToString())==DBCode.HasRecord)
                                {
                                    OleDbParameter socket_id = new OleDbParameter("@socket_id", OleDbType.Integer);
                                    socket_id.Value = id;
                                    ITInventory.ExecProcedure("DelSockets", new OleDbParameter[] { socket_id });
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
                trvwConfigDevice.Nodes.Remove(trvwConfigDevice.SelectedNode);
            }
            RefreshDeviceConfigTab();
            trvwConfigDevice.Focus();
            listDevices_SelectedIndexChanged(null, null);
        }

        private void trvwConfigDevice_MouseDown(object sender, MouseEventArgs e)
        {
            if (trvwConfigDevice.GetNodeAt(e.Location) == null)
            {
                trvwConfigDevice.SelectedNode = null;
                trvwConfigDevice.ContextMenuStrip = null;
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (clipbrdNode == null)
                {
                    粘贴节点ToolStripMenuItem.Enabled = false;
                }
                else
                {
                    粘贴节点ToolStripMenuItem.Enabled = true;
                }
                trvwConfigDevice.SelectedNode = trvwConfigDevice.GetNodeAt(e.Location);
                trvwConfigDevice.ContextMenuStrip = contMenuTrvwConfigDevice; 
            }
            RefreshDeviceConfigTab();
        }

        private void chkConfigPurchaseDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpkConfigPurchaseDate.Enabled = txtConfigWarranty.Enabled = chkConfigPurchaseDate.Checked;
        }

        private void UpdateDevice()
        {
            if(!CheckDeviceConfig())
            {
                txtConfigDeviceName.Focus();
            }
            else
            {
                if(trvwConfigDevice.SelectedNode.Tag is Hashtable)
                {
                    if (((Hashtable)trvwConfigDevice.SelectedNode.Tag).ContainsKey("device_name"))
                    {
                        ((Hashtable)trvwConfigDevice.SelectedNode.Tag)["device_name"] = txtConfigDeviceName.Text;
                    }
                    else
                    {
                        ((Hashtable)trvwConfigDevice.SelectedNode.Tag).Add("device_name", txtConfigDeviceName.Text);
                    }
                    if (((Hashtable)trvwConfigDevice.SelectedNode.Tag).ContainsKey("device_module"))
                    {
                        ((Hashtable)trvwConfigDevice.SelectedNode.Tag)["device_module"] = txtConfigModule.Text;
                    }
                    else
                    {
                        ((Hashtable)trvwConfigDevice.SelectedNode.Tag).Add("device_module", txtConfigModule.Text);
                    }
                    if (((Hashtable)trvwConfigDevice.SelectedNode.Tag).ContainsKey("device_description"))
                    {
                        ((Hashtable)trvwConfigDevice.SelectedNode.Tag)["device_description"] = txtConfigDeviceDescription.Text;
                    }
                    else
                    {
                        ((Hashtable)trvwConfigDevice.SelectedNode.Tag).Add("device_description", txtConfigDeviceDescription.Text);
                    }
                    if (((Hashtable)trvwConfigDevice.SelectedNode.Tag).ContainsKey("device_type_id_ref"))
                    {
                        try
                        {
                            ((Hashtable)trvwConfigDevice.SelectedNode.Tag)["device_type_id_ref"] = (int)cmbConfigDeviceType.SelectedValue;
                        }
                        catch(Exception err)
                        {
                            Debug.WriteLine(err.ToString());
                            ((Hashtable)trvwConfigDevice.SelectedNode.Tag).Remove("device_type_id_ref");
                        }
                    }
                    else
                    {
                        try
                        {
                            ((Hashtable)trvwConfigDevice.SelectedNode.Tag).Add("device_type_id_ref", (int)cmbConfigDeviceType.SelectedValue);
                        }
                        catch(Exception err) { Debug.WriteLine(err.ToString()); }
                    }
                    if (((Hashtable)trvwConfigDevice.SelectedNode.Tag).ContainsKey("device_manufactory_id_ref"))
                    {
                        try
                        {
                            ((Hashtable)trvwConfigDevice.SelectedNode.Tag)["device_manufactory_id_ref"] = (int)cmbConfigManufactory.SelectedValue;
                        }
                        catch(Exception err)
                        {
                            Debug.WriteLine(err.ToString());
                            ((Hashtable)trvwConfigDevice.SelectedNode.Tag).Remove("device_manufactory_id_ref");
                        }
                    }
                    else
                    {
                        try
                        {
                            ((Hashtable)trvwConfigDevice.SelectedNode.Tag).Add("device_manufactory_id_ref", (int)cmbConfigManufactory.SelectedValue);
                        }
                        catch(Exception err) { Debug.WriteLine(err.ToString()); }
                    }
                    if (((Hashtable)trvwConfigDevice.SelectedNode.Tag).ContainsKey("device_vender_id_ref"))
                    {
                        try
                        {
                            ((Hashtable)trvwConfigDevice.SelectedNode.Tag)["device_vender_id_ref"] = (int)cmbConfigVender.SelectedValue;
                        }
                        catch (Exception err)
                        {
                            Debug.WriteLine(err.ToString());
                        }
                    }
                    else
                    {
                        try
                        {
                            ((Hashtable)trvwConfigDevice.SelectedNode.Tag).Add("device_vender_id_ref", (int)cmbConfigVender.SelectedValue);
                        }
                        catch (Exception err) { Debug.WriteLine(err.ToString()); }
                    }
                    if (((Hashtable)trvwConfigDevice.SelectedNode.Tag).ContainsKey("device_sn"))
                    {
                        ((Hashtable)trvwConfigDevice.SelectedNode.Tag)["device_sn"] = txtConfigDeviceSN.Text;
                    }
                    else
                    {
                        ((Hashtable)trvwConfigDevice.SelectedNode.Tag).Add("device_sn", txtConfigDeviceSN.Text);
                    }
                    if (((Hashtable)trvwConfigDevice.SelectedNode.Tag).ContainsKey("device_quick_service"))
                    {
                        ((Hashtable)trvwConfigDevice.SelectedNode.Tag)["device_quick_service"] = txtConfigQuickService.Text;
                    }
                    else
                    {
                        ((Hashtable)trvwConfigDevice.SelectedNode.Tag).Add("device_quick_service", txtConfigQuickService.Text);
                    }
                    if (chkConfigPurchaseDate.Checked)
                    {
                        if (((Hashtable)trvwConfigDevice.SelectedNode.Tag).ContainsKey("device_purchase_date"))
                        {
                            ((Hashtable)trvwConfigDevice.SelectedNode.Tag)["device_purchase_date"] = dtpkConfigPurchaseDate.Value.ToShortDateString();
                        }
                        else
                        {
                            ((Hashtable)trvwConfigDevice.SelectedNode.Tag).Add("device_purchase_date", dtpkConfigPurchaseDate.Value.ToShortDateString());
                        }
                        if (txtConfigWarranty.Text != "")
                        {
                            if (((Hashtable)trvwConfigDevice.SelectedNode.Tag).ContainsKey("device_warranty"))
                            {
                                ((Hashtable)trvwConfigDevice.SelectedNode.Tag)["device_warranty"] = int.Parse(txtConfigWarranty.Text);
                            }
                            else
                            {
                                ((Hashtable)trvwConfigDevice.SelectedNode.Tag).Add("device_warranty", int.Parse(txtConfigWarranty.Text));
                            }
                        }
                    }
                }
                else
                {
                    Hashtable node = new Hashtable(10);
                    node.Add("device_name", txtConfigDeviceName.Text);
                    node.Add("device_module", txtConfigModule.Text);
                    node.Add("device_description", txtConfigDeviceDescription.Text);
                    try
                    {
                        node.Add("device_type_id_ref", (int)cmbConfigDeviceType.SelectedValue);
                    }
                    catch(Exception err) { Debug.WriteLine(err.ToString()); }
                    try
                    {
                        node.Add("device_manufactory_id_ref", (int)cmbConfigManufactory.SelectedValue);
                    }
                    catch(Exception err) { Debug.WriteLine(err.ToString()); }
                    try
                    {
                        node.Add("device_vender_id_ref", (int)cmbConfigVender.SelectedValue);
                    }
                    catch(Exception err) { Debug.WriteLine(err.ToString()); }
                    node.Add("device_sn", txtConfigDeviceSN.Text);
                    node.Add("device_quick_service", txtConfigQuickService.Text);
                    if (chkConfigPurchaseDate.Checked)
                    {
                        node.Add("device_purchase_date", dtpkConfigPurchaseDate.Value.ToShortDateString());
                        if (txtConfigWarranty.Text != "")
                        { node.Add("device_warranty", int.Parse(txtConfigWarranty.Text)); }
                    }
                    trvwConfigDevice.SelectedNode.Tag = node;
                }
                trvwConfigDevice.SelectedNode.Text = txtConfigDeviceName.Text;
                int index = FindRootNodeIndex(trvwConfigDevice.SelectedNode);
                Debug.WriteLine(trvwConfigDevice.SelectedNode.Tag);
                ClearDeviceConfig();
                //trvwConfigDevice.Focus();
            }
        }

        private void btnResetConfig_Click(object sender, EventArgs e)
        {
            ClearDeviceConfig();
            txtConfigDeviceName.Focus();
        }

        private void ClearDeviceConfig()
        {
            txtConfigDeviceName.Text = "";
            cmbConfigCity.SelectedIndex = -1;
            cmbConfigLocation.SelectedIndex = -1;
            cmbConfigArea.SelectedIndex = -1;
            cmbConfigDeviceType.SelectedIndex = -1;
            cmbConfigRole.SelectedIndex = -1;
            txtConfigModule.Text = "";
            cmbConfigModule.SelectedIndex = -1;
            cmbConfigManufactory.SelectedIndex = -1;
            txtConfigDeviceDescription.Text = "";
            txtConfigDeviceSN.Text = "";
            txtConfigQuickService.Text = "";
            cmbConfigVender.SelectedIndex = -1;
            chkConfigPurchaseDate.Checked = false;
            txtConfigWarranty.Text = "1";
        }

        private void trvwDevice_MouseDown(object sender, MouseEventArgs e)
        {
            trvwDevice.SelectedNode = trvwDevice.GetNodeAt(e.Location);
            if (trvwDevice.SelectedNode != null && e.Button == MouseButtons.Right)
            {
                trvwDevice.ContextMenuStrip = contMenuTrvwDevice;
            }
            else
            {
                trvwDevice.ContextMenuStrip = null;
            }
        }

        private void gdvwCellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && ((DataGridView)sender).SelectedRows.Count <= 1 && e.RowIndex >= 0)
            {
                ((DataGridView)sender).ClearSelection();
                ((DataGridView)sender).Rows[e.RowIndex].Selected = true;
                gdvwContent = ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                menuStripCaller = (DataGridView)sender;
            }
        }

        private void btnAddSocket_Click(object sender, EventArgs e)
        {
            if (trvwConfigDevice.SelectedNode == null)
            {
                MessageBox.Show("只能在设备/组件下创建接口！", "注意！");
            }
            else
            {
                TreeNodeEx[] nodelist;
                ComponentDefine socket = new ComponentDefine(ComponentDefine.FormType.Socket);
                if (DialogResult.OK == socket.ShowDialog(this))
                {
                    if (socket.ComponentName.Contains("{n}"))
                    {
                        nodelist = new TreeNodeEx[socket.ComponentQuantity];
                        for (int i = 0; i < socket.ComponentQuantity; i++)
                        {
                            TreeNodeEx node = new TreeNodeEx(socket.ComponentName.Replace("{n}", (socket.Index + i).ToString()));
                            node.Name = "socket";
                            nodelist[i] = node;
                            nodelist[i].Tag = socket.Tag.Clone();
                            ((Hashtable)nodelist[i].Tag).Add("socket_name", node.Text);
                        }
                    }
                    else
                    {
                        TreeNodeEx node = new TreeNodeEx(socket.ComponentName);
                        node.Name = "socket";
                        node.Tag = socket.Tag.Clone();
                        ((Hashtable)node.Tag).Add("socket_name", node.Text);
                        nodelist = new TreeNodeEx[1];
                        nodelist[0] = node;
                    }
                    trvwConfigDevice.SelectedNode.Nodes.AddRange(nodelist);
                    trvwConfigDevice.SelectedNode.Expand();
                }
            }
        }

        private void trvwConfigDevice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                btnDeleteDevice.PerformClick();
                e.Handled = true;
                RefreshDeviceConfigTab();
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                clipbrdNode = CopyNode((TreeNodeEx)trvwConfigDevice.SelectedNode);
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.X)
            {
                CutNode((TreeNodeEx)trvwConfigDevice.SelectedNode);
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                PasteNode();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void UpdateSocket()
        {
            if (!CheckSocketConfig())
            {
                txtConfigSocketName.Focus();
            }
            else
            {
                if (trvwConfigDevice.SelectedNode.Tag is Hashtable)
                {
                    if(((Hashtable)trvwConfigDevice.SelectedNode.Tag).ContainsKey("socket_name"))
                    {
                        ((Hashtable)trvwConfigDevice.SelectedNode.Tag)["socket_name"] = txtConfigSocketName.Text;
                    }
                    else
                    {
                        ((Hashtable)trvwConfigDevice.SelectedNode.Tag).Add("socket_name", txtConfigSocketName.Text);
                    }
                    if(((Hashtable)trvwConfigDevice.SelectedNode.Tag).ContainsKey("socket_description"))
                    {
                        ((Hashtable)trvwConfigDevice.SelectedNode.Tag)["socket_description"] = txtConfigSocketDescription.Text;
                    }
                    else
                    {
                        ((Hashtable)trvwConfigDevice.SelectedNode.Tag).Add("socket_description", txtConfigSocketDescription.Text);
                    }
                    if (((Hashtable)trvwConfigDevice.SelectedNode.Tag).ContainsKey("socket_phy_type_id_ref"))
                    {
                        try
                        {
                            ((Hashtable)trvwConfigDevice.SelectedNode.Tag)["socket_phy_type_id_ref"] = (int)cmbConfigSocketPhyType.SelectedValue;
                        }
                        catch (Exception err)
                        {
                            Debug.WriteLine(err.ToString());
                            ((Hashtable)trvwConfigDevice.SelectedNode.Tag).Remove("socket_phy_type_id_ref");
                        }
                    }
                    else
                    {
                        if (cmbConfigSocketPhyType.SelectedIndex >= 0)
                        { ((Hashtable)trvwConfigDevice.SelectedNode.Tag).Add("socket_phy_type_id_ref", (int)cmbConfigSocketPhyType.SelectedValue); }
                    }
                    if(((Hashtable)trvwConfigDevice.SelectedNode.Tag).ContainsKey("socket_logic_type_id_ref"))
                    {
                        try
                        {
                            ((Hashtable)trvwConfigDevice.SelectedNode.Tag)["socket_logic_type_id_ref"] = (int)cmbConfigSocketLogicType.SelectedValue;
                        }
                        catch(Exception err)
                        {
                            Debug.WriteLine(err.ToString());
                            ((Hashtable)trvwConfigDevice.SelectedNode.Tag).Remove("socket_logic_type_id_ref");
                        }
                    }
                    else
                    {
                        if (cmbConfigSocketLogicType.SelectedIndex >= 0)
                        { ((Hashtable)trvwConfigDevice.SelectedNode.Tag).Add("socket_logic_type_id_ref", (int)cmbConfigSocketLogicType.SelectedValue); }
                    }
                    if(((Hashtable)trvwConfigDevice.SelectedNode.Tag).ContainsKey("socket_speed_type_id_ref"))
                    {
                        try
                        {
                            ((Hashtable)trvwConfigDevice.SelectedNode.Tag)["socket_speed_type_id_ref"] = (int)cmbConfigSocketSpeed.SelectedValue;
                        }
                        catch(Exception err)
                        {
                            Debug.WriteLine(err.ToString());
                            ((Hashtable)trvwConfigDevice.SelectedNode.Tag).Remove("socket_speed_type_id_ref");
                        }
                    }
                    else
                    {
                        if (cmbConfigSocketSpeed.SelectedIndex >= 0)
                        { ((Hashtable)trvwConfigDevice.SelectedNode.Tag).Add("socket_speed_type_id_ref", (int)cmbConfigSocketSpeed.SelectedValue); }
                    }
                    if(chkAddrInfo.Checked)
                    {
                        if(((Hashtable)trvwConfigDevice.SelectedNode.Tag).ContainsKey("SocketAddressInfo"))
                        {
                            Debug.WriteLine(ipv4Address.ToString());
                            ((TCPIP)((Hashtable)trvwConfigDevice.SelectedNode.Tag)["SocketAddressInfo"]).IPv4Address = ipv4Address.Text;
                            ((TCPIP)((Hashtable)trvwConfigDevice.SelectedNode.Tag)["SocketAddressInfo"]).IPv4Mask = ipv4Mask.Text;
                        }
                        else
                        {
                            TCPIP addr = new TCPIP();
                            addr.IPv4Address = ipv4Address.Text;
                            addr.IPv4Mask = ipv4Mask.Text;
                            ((Hashtable)trvwConfigDevice.SelectedNode.Tag).Add("SocketAddressInfo", addr);
                        }
                    }
                }
                else
                {
                    Hashtable node = new Hashtable(5);
                    node.Add("socket_name", txtConfigSocketName.Text);
                    node.Add("socket_description", txtConfigSocketDescription.Text);
                    if (cmbConfigSocketPhyType.SelectedIndex >= 0)
                    {
                        node.Add("socket_phy_type_id_ref", (int)cmbConfigSocketPhyType.SelectedValue);
                    }
                    if (cmbConfigSocketLogicType.SelectedIndex >= 0)
                    {
                        node.Add("socket_logic_type_id_ref", (int)cmbConfigSocketLogicType.SelectedValue);
                    }
                    if (cmbConfigSocketSpeed.SelectedIndex >= 0)
                    {
                        node.Add("socket_speed_type_id_ref", (int)cmbConfigSocketSpeed.SelectedValue);
                    }
                    if (chkAddrInfo.Checked)
                    {
                        TCPIP addr = new TCPIP();
                        addr.IPv4Address = ipv4Address.Text;
                        addr.IPv4Mask = ipv4Mask.Text;
                        node.Add("SocketAddressInfo", addr);
                    }
                    trvwConfigDevice.SelectedNode.Tag = node;
                }
                trvwConfigDevice.SelectedNode.Text = txtConfigSocketName.Text;
                int index = FindRootNodeIndex(trvwConfigDevice.SelectedNode);
                Debug.WriteLine(trvwConfigDevice.SelectedNode.Tag);
                ClearSocketConfig();
                //trvwConfigDevice.Focus();
            }
        }

        private void ClearSocketConfig()
        {
            txtConfigSocketName.Text = "";
            cmbConfigSocketPhyType.SelectedIndex = -1;
            cmbConfigSocketLogicType.SelectedIndex = -1;
            cmbConfigSocketSpeed.SelectedIndex = -1;
            txtConfigSocketDescription.Text = "";
            ipv4Address.Clear();
            ipv4Mask.Reset();
            chkAddrInfo.Checked = false;
        }

        private void btnResetSocketConfig_Click(object sender, EventArgs e)
        {
            ClearSocketConfig();
        }

        private void cmbConfigSocketPhyType_DropDownClosed(object sender, EventArgs e)
        {
            cmbConfigSocketLogicType.SelectedIndex = -1;
        }

        private void cmbConfigSocketLogicType_DropDownClosed(object sender, EventArgs e)
        {
            cmbConfigSocketPhyType.SelectedIndex = -1;
        }

        private void btnSaveAllDevice_Click(object sender, EventArgs e)
        {
            if (trvwConfigDevice.Nodes.Count > 0)
            {
                btnAddDevice.Enabled = btnAddSocket.Enabled = btnDeleteDevice.Enabled = false;
                groupConfigDevice.Enabled = groupConfigSocket.Enabled = false;
                Thread tr = new Thread(new ThreadStart(delegate { SaveConfig(trvwConfigDevice.Nodes); }));
                tr.IsBackground = true;
                tr.Start();
            }
            else
            {
                MessageBox.Show("无设备配置需要保存，请先添加设备配置！");
            }
        }

        private void SaveConfig(TreeNodeCollection deviceTree)
        {
            foreach (TreeNode node in deviceTree)
            {
                Debug.WriteLine(node.Index);
                if (node.Tag is Hashtable)
                {
                    if (_BeginTransaction())
                    {
                        if (InsertDataTree2DB((TreeNodeEx)node, 0))
                        {
                            _EndTransaction();
                            this.BeginInvoke(OnSaveDeviceCompleteEvent);
                        }
                        else
                        {
                            _RollbackTransaction();
                        }
                    }
                    else
                    {
                        MessageBox.Show("数据库事务启动失败，请联系管理员。");
                    }
                }
                else
                {
                    MessageBox.Show("当前节点[" + node.FullPath + "]未配置！");
                }
            }
        }

        private void SaveConfig(TreeNode node)
        {
            if(node.Tag is Hashtable)
            {
                if (_BeginTransaction())
                {
                    if (InsertDataTree2DB((TreeNodeEx)node, 0))
                    {
                        _EndTransaction();
                        this.BeginInvoke(OnSaveDeviceCompleteEvent);
                    }
                    else
                    {
                        _RollbackTransaction();
                    }
                }
                else
                {
                    MessageBox.Show("数据库事务启动失败，请联系管理员。");
                }
            }
            else
            {
                MessageBox.Show("当前节点[ " + node.FullPath + " ]未配置！");
            }
        }

        private bool InsertDataTree2DB(TreeNodeEx root,int parentID)
        {
            int id = 0;
            if (parentID==0)
            {
                switch(root.Name)
                {
                    case "device":
                        if (((Hashtable)root.Tag).ContainsKey("device_info_id"))
                        {
                            id = (int)((Hashtable)root.Tag)["device_info_id"];
                            ((Hashtable)root.Tag).Remove("device_info_id");
                            _UpdateRecord("DeviceInfo", (Hashtable)root.Tag, "device_info_id=" + id.ToString());
                            ((Hashtable)root.Tag).Add("device_info_id", id);
                        }
                        else
                        {
                            id = _InsertData("DeviceInfo", (Hashtable)root.Tag);
                            ((Hashtable)root.Tag).Add("device_info_id", id);
                            if (id <= 0)
                            {
                                MessageBox.Show("插入数据失败！", "错误！");
                                return false;
                            }
                        }
                        break;
                    case "socket":
                        MessageBox.Show("接口不能单独存在，必须依附于设备或组件！", "错误！");
                        return false;
                    default:
                        MessageBox.Show("节点类型存在错误，请联系开发人员！");
                        return false;
                }
            }
            else
            {
                switch (root.Name)
                {
                    case "device":
                        if (((Hashtable)root.Tag).ContainsKey("device_info_id"))
                        {
                            id = (int)((Hashtable)root.Tag)["device_info_id"];
                            ((Hashtable)root.Tag).Remove("device_info_id");                 //防止在数据库内重复更新已有的device_info_id
                            if (((Hashtable)root.Tag).ContainsKey("device_parent_id_ref"))
                            {
                                ((Hashtable)root.Tag)["device_parent_id_ref"] = parentID;
                            }
                            else
                            {
                                ((Hashtable)root.Tag).Add("device_parent_id_ref", parentID);
                            }
                            _UpdateRecord("DeviceInfo", (Hashtable)root.Tag, "device_info_id=" + id.ToString());
                            ((Hashtable)root.Tag).Add("device_info_id", id);
                        }
                        else
                        {
                            if (((Hashtable)root.Tag).ContainsKey("device_parent_id_ref"))
                            {
                                ((Hashtable)root.Tag)["device_parent_id_ref"] = parentID;
                            }
                            else
                            {
                                ((Hashtable)root.Tag).Add("device_parent_id_ref", parentID);
                            }
                            id = _InsertData("DeviceInfo", (Hashtable)root.Tag);
                            ((Hashtable)root.Tag).Add("device_info_id", id);
                            if (id <= 0)
                            {
                                MessageBox.Show("插入数据失败！", "错误！");
                                return false;
                            }
                        }
                        break;
                    case "socket":
                        switch (root.Parent.Name)
                        {
                            case "device":
                                Hashtable socket2device = new Hashtable(2);
                                socket2device.Add("device_info_id_ref", parentID);
                                if (((Hashtable)root.Tag).ContainsKey("socket_id"))
                                {
                                    id = (int)((Hashtable)root.Tag)["socket_id"];
                                    ((Hashtable)root.Tag).Remove("socket_id");                                      //防止在数据库内重复更新已有的socket_id
                                    if (((Hashtable)root.Tag).ContainsKey("SocketAddressInfo"))
                                    {
                                        TCPIP addr = new TCPIP();
                                        addr = (TCPIP)((Hashtable)root.Tag)["SocketAddressInfo"];
                                        ((Hashtable)root.Tag).Remove("SocketAddressInfo");                          //防止将地址信息写入接口表，导致写入失败
                                        _UpdateRecord("SocketInfo", (Hashtable)root.Tag, "socket_id=" + id.ToString());
                                        ((Hashtable)root.Tag).Add("socket_id", id);
                                        OleDbParameter ipv4addr = new OleDbParameter("@P1", OleDbType.VarBinary, 4);
                                        OleDbParameter ipv4mask = new OleDbParameter("@P2", OleDbType.VarBinary, 4);
                                        OleDbParameter sockRef = new OleDbParameter("@P3", OleDbType.Integer);
                                        byte[] tmp = addr.IPv4AddrBytes;
                                        Array.Reverse(tmp);
                                        //ipv4addr.Value = addr.IPv4AddrBytes;
                                        ipv4addr.Value = tmp;
                                        tmp = addr.IPv4MaskBytes;
                                        Array.Reverse(tmp);
                                        //ipv4mask.Value = addr.IPv4MaskBytes;
                                        ipv4mask.Value = tmp;
                                        sockRef.Value = id;
                                        string sql;
                                        if (_HasRecord("SocketAddressInfo", "socket_info_id_ref=" + id.ToString()) == DBCode.HasRecord)
                                        {
                                            sql = "UPDATE SocketAddressInfo SET socket_ipv4_addr=?,socket_ipv4_mask=? WHERE socket_info_id_ref=?";
                                        }
                                        else
                                        {
                                            sql = "INSERT INTO SocketAddressInfo(socket_ipv4_addr,socket_ipv4_mask,socket_info_id_ref) VALUES (?,?,?)";
                                        }
                                        _ExecuteCommand(sql, new OleDbParameter[] { ipv4addr, ipv4mask, sockRef });
                                        ((Hashtable)root.Tag).Add("SocketAddressInfo", addr);
                                    }
                                    else
                                    {
                                        _UpdateRecord("SocketInfo", (Hashtable)root.Tag, "socket_id=" + id.ToString());
                                        ((Hashtable)root.Tag).Add("socket_id", id);
                                    }
                                }
                                else
                                {
                                    if (((Hashtable)root.Tag).ContainsKey("SocketAddressInfo"))
                                    {
                                        TCPIP addr = new TCPIP();
                                        addr = (TCPIP)((Hashtable)root.Tag)["SocketAddressInfo"];
                                        ((Hashtable)root.Tag).Remove("SocketAddressInfo");                          //防止将地址信息写入接口表，导致写入失败
                                        id = _InsertData("SocketInfo", (Hashtable)root.Tag);        //插入接口信息表（SocketInfo），并返回插入记录ID值
                                        if (id <= 0)
                                        {
                                            MessageBox.Show("插入数据失败！", "错误！");
                                            return false;
                                        }
                                        ((Hashtable)root.Tag).Add("socket_id", id);
                                        OleDbParameter ipv4addr = new OleDbParameter("@P1", OleDbType.VarBinary, 4);
                                        OleDbParameter ipv4mask = new OleDbParameter("@P2", OleDbType.VarBinary, 4);
                                        OleDbParameter sockRef = new OleDbParameter("@P3", OleDbType.Integer);
                                        byte[] tmp = addr.IPv4AddrBytes;
                                        Array.Reverse(tmp);
                                        //ipv4addr.Value = addr.IPv4AddrBytes;
                                        ipv4addr.Value = tmp;
                                        tmp = addr.IPv4MaskBytes;
                                        Array.Reverse(tmp);
                                        //ipv4mask.Value = addr.IPv4MaskBytes;
                                        ipv4mask.Value = tmp;
                                        sockRef.Value = id;
                                        string sql;
                                        if (_HasRecord("SocketAddressInfo", "socket_info_id_ref=" + id.ToString()) == DBCode.HasRecord)
                                        {
                                            sql = "UPDATE SocketAddressInfo SET socket_ipv4_addr=?,socket_ipv4_mask=? WHERE socket_info_id_ref=?";
                                        }
                                        else
                                        {
                                            sql = "INSERT INTO SocketAddressInfo(socket_ipv4_addr,socket_ipv4_mask,socket_info_id_ref) VALUES (?,?,?)";
                                        }
                                        _ExecuteCommand(sql, new OleDbParameter[] { ipv4addr, ipv4mask, sockRef });
                                        ((Hashtable)root.Tag).Add("SocketAddressInfo", addr);
                                    }
                                    else
                                    {
                                        id = _InsertData("SocketInfo", (Hashtable)root.Tag);        //插入接口信息表（SocketInfo），并返回插入记录ID值
                                        if (id <= 0)
                                        {
                                            MessageBox.Show("插入数据失败！", "错误！");
                                            return false;
                                        }
                                        ((Hashtable)root.Tag).Add("socket_id", id);
                                    }
                                }
                                if (_HasRecord("DeviceSocketRelation", "socket_info_id_ref=" + id.ToString()) == DBCode.HasRecord)
                                {
                                    _UpdateRecord("DeviceSocketRelation", socket2device, "socket_info_id_ref=" + id.ToString());
                                }
                                else
                                {
                                    socket2device.Add("socket_info_id_ref", id);
                                    if (_InsertData("DeviceSocketRelation", socket2device) <= 0)            //插入设备<->接口对应关系表（DeviceSocketRelation）
                                    {
                                        MessageBox.Show("插入设备<->接口对应失败！", "错误！");
                                        return false;
                                    }
                                }
                                break;
                            case "socket":
                                if (((Hashtable)root.Tag).ContainsKey("socket_id"))
                                {
                                    id = (int)((Hashtable)root.Tag)["socket_id"];
                                    ((Hashtable)root.Tag).Remove("socket_id");                  //防止在数据库内重复更新已有的socket_id
                                    if (((Hashtable)root.Tag).ContainsKey("SocketAddressInfo"))
                                    {
                                        TCPIP addr = new TCPIP();
                                        addr = (TCPIP)((Hashtable)root.Tag)["SocketAddressInfo"];
                                        ((Hashtable)root.Tag).Remove("SocketAddressInfo");                          //防止将地址信息写入接口表，导致写入失败
                                        if (((Hashtable)root.Tag).ContainsKey("socket_owner_id_ref"))
                                        {
                                            ((Hashtable)root.Tag)["socket_owner_id_ref"] = parentID;
                                        }
                                        else
                                        {
                                            ((Hashtable)root.Tag).Add("socket_owner_id_ref", parentID);
                                        }
                                        _UpdateRecord("SocketInfo", (Hashtable)root.Tag, "socket_id=" + id.ToString());
                                        OleDbParameter ipv4addr = new OleDbParameter("@P1", OleDbType.VarBinary, 4);
                                        OleDbParameter ipv4mask = new OleDbParameter("@P2", OleDbType.VarBinary, 4);
                                        OleDbParameter sockRef = new OleDbParameter("@P3", OleDbType.Integer);
                                        byte[] tmp = addr.IPv4AddrBytes;
                                        Array.Reverse(tmp);
                                        //ipv4addr.Value = addr.IPv4AddrBytes;
                                        ipv4addr.Value = tmp;
                                        tmp = addr.IPv4MaskBytes;
                                        Array.Reverse(tmp);
                                        //ipv4mask.Value = addr.IPv4MaskBytes;
                                        ipv4mask.Value = tmp;
                                        sockRef.Value = id;
                                        string sql;
                                        if (_HasRecord("SocketAddressInfo", "socket_info_id_ref=" + id.ToString()) == DBCode.HasRecord)
                                        {
                                            sql = "UPDATE SocketAddressInfo SET socket_ipv4_addr=?,socket_ipv4_mask=? WHERE socket_info_id_ref=?";
                                        }
                                        else
                                        {
                                            sql = "INSERT INTO SocketAddressInfo(socket_ipv4_addr,socket_ipv4_mask,socket_info_id_ref) VALUES (?,?,?)";
                                        }
                                        _ExecuteCommand(sql, new OleDbParameter[] { ipv4addr, ipv4mask, sockRef });
                                        ((Hashtable)root.Tag).Add("SocketAddressInfo", addr);
                                    }
                                    else
                                    {
                                        if (((Hashtable)root.Tag).ContainsKey("socket_owner_id_ref"))
                                        {
                                            ((Hashtable)root.Tag)["socket_owner_id_ref"] = parentID;
                                        }
                                        else
                                        {
                                            ((Hashtable)root.Tag).Add("socket_owner_id_ref", parentID);
                                        }
                                        _UpdateRecord("SocketInfo", (Hashtable)root.Tag, "socket_id=" + id.ToString());
                                    }
                                    ((Hashtable)root.Tag).Add("socket_id", id);
                                }
                                else
                                {
                                    if (((Hashtable)root.Tag).ContainsKey("socket_owner_id_ref"))
                                    {
                                        ((Hashtable)root.Tag)["socket_owner_id_ref"] = parentID;
                                    }
                                    else
                                    {
                                        ((Hashtable)root.Tag).Add("socket_owner_id_ref", parentID);
                                    }
                                    if (((Hashtable)root.Tag).ContainsKey("SocketAddressInfo"))
                                    {
                                        TCPIP addr = new TCPIP();
                                        addr = (TCPIP)((Hashtable)root.Tag)["SocketAddressInfo"];
                                        ((Hashtable)root.Tag).Remove("SocketAddressInfo");                          //防止将地址信息写入接口表，导致写入失败
                                        id = _InsertData("SocketInfo", (Hashtable)root.Tag);
                                        if (id <= 0)
                                        {
                                            MessageBox.Show("插入数据失败！", "错误！");
                                            return false;
                                        }
                                        OleDbParameter ipv4addr = new OleDbParameter("@P1", OleDbType.VarBinary, 4);
                                        OleDbParameter ipv4mask = new OleDbParameter("@P2", OleDbType.VarBinary, 4);
                                        OleDbParameter sockRef = new OleDbParameter("@P3", OleDbType.Integer);
                                        byte[] tmp = addr.IPv4AddrBytes;
                                        Array.Reverse(tmp);
                                        //ipv4addr.Value = addr.IPv4AddrBytes;
                                        ipv4addr.Value = tmp;
                                        tmp = addr.IPv4MaskBytes;
                                        Array.Reverse(tmp);
                                        //ipv4mask.Value = addr.IPv4MaskBytes;
                                        ipv4mask.Value = tmp;
                                        sockRef.Value = id;
                                        string sql;
                                        if (_HasRecord("SocketAddressInfo", "socket_info_id_ref=" + id.ToString()) == DBCode.HasRecord)
                                        {
                                            sql = "UPDATE SocketAddressInfo SET socket_ipv4_addr=?,socket_ipv4_mask=? WHERE socket_info_id_ref=?";
                                        }
                                        else
                                        {
                                            sql = "INSERT INTO SocketAddressInfo(socket_ipv4_addr,socket_ipv4_mask,socket_info_id_ref) VALUES (?,?,?)";
                                        }
                                        _ExecuteCommand(sql, new OleDbParameter[] { ipv4addr, ipv4mask, sockRef });
                                        ((Hashtable)root.Tag).Add("SocketAddressInfo", addr);
                                    }
                                    else
                                    {
                                        id = _InsertData("SocketInfo", (Hashtable)root.Tag);
                                        if (id <= 0)
                                        {
                                            MessageBox.Show("插入数据失败！", "错误！");
                                            return false;
                                        }
                                    }
                                    ((Hashtable)root.Tag).Add("socket_id", id);
                                }
                                break;
                            default:
                                MessageBox.Show("节点类型存在错误，请联系开发人员！");
                                return false;
                        }
                        break;
                    default:
                        MessageBox.Show("节点类型存在错误，请联系开发人员！");
                        return false;
                }
            }
            if (root.Nodes.Count > 0)
            {
                foreach (TreeNodeEx child in root.Nodes)
                {
                    if (child.Tag is Hashtable)
                    {
                        if(!InsertDataTree2DB(child, id))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("当前节点[ " + child.FullPath + " ]未配置！");
                        return false;
                    }
                }
            }
            return true;
        }

        private void SaveDeviceComplete()
        {
            MessageBox.Show("设备信息保存完成。");
            RefreshDeviceConfigTab();
            listDevices_SelectedIndexChanged(null, null);
        }

        private void RefreshDeviceConfigTab()
        {
            if(trvwConfigDevice.SelectedNode==null)
            {
                btnAddDevice.Text = "添加设备";
                添加设备ToolStripMenuItem.Text = "添加设备";
                btnDeleteDevice.Text = "删除设备";
                删除设备ToolStripMenuItem.Text = "删除设备";
                btnAddDevice.Enabled = 添加设备ToolStripMenuItem.Enabled = true;
                btnAddSocket.Enabled = btnDeleteDevice.Enabled = 删除设备ToolStripMenuItem.Enabled = 添加接口ToolStripMenuItem.Enabled = false;
                cmbConfigArea.SelectedIndex = cmbConfigCity.SelectedIndex = cmbConfigLocation.SelectedIndex = cmbConfigRole.SelectedIndex = cmbConfigModule.SelectedIndex = -1;
                cmbDeviceType.SelectedIndex = cmbManufactory.SelectedIndex = cmbVender.SelectedIndex = -1;
                cmbConfigSocketPhyType.SelectedIndex = cmbConfigSocketLogicType.SelectedIndex = cmbConfigSocketSpeed.SelectedIndex = -1;
                groupConfigDevice.Enabled = groupConfigSocket.Enabled = false;
            }
            else if(trvwConfigDevice.SelectedNode.Level==0)
            {
                btnAddDevice.Text = "添加组件";
                添加设备ToolStripMenuItem.Text = "添加组件";
                btnDeleteDevice.Text = "删除设备";
                删除设备ToolStripMenuItem.Text = "删除设备";
                btnAddDevice.Enabled = btnDeleteDevice.Enabled = 添加设备ToolStripMenuItem.Enabled = 删除设备ToolStripMenuItem.Enabled = true;
                btnAddSocket.Enabled = 添加接口ToolStripMenuItem.Enabled = true;
                groupConfigDevice.Enabled = true;
                cmbConfigCity.Enabled = cmbConfigLocation.Enabled = cmbConfigArea.Enabled = cmbConfigDeviceType.Enabled = cmbConfigRole.Enabled = true;
                cmbConfigCity.SelectedIndex = cmbConfigLocation.SelectedIndex = cmbConfigArea.SelectedIndex = cmbConfigDeviceType.SelectedIndex = cmbConfigRole.SelectedIndex = -1;
                groupConfigSocket.Enabled = false;
                CopyDeviceInfo();
            }
            else if(trvwConfigDevice.SelectedNode.Name=="device")
            {
                btnAddDevice.Text = "添加组件";
                添加设备ToolStripMenuItem.Text = "添加组件";
                btnDeleteDevice.Text = "删除组件";
                删除设备ToolStripMenuItem.Text = "删除组件";
                btnAddDevice.Enabled = btnAddSocket.Enabled = btnDeleteDevice.Enabled = true;
                添加设备ToolStripMenuItem.Enabled = 删除设备ToolStripMenuItem.Enabled = 添加接口ToolStripMenuItem.Enabled = true;
                groupConfigDevice.Enabled = true;
                cmbConfigCity.Enabled = cmbConfigLocation.Enabled = cmbConfigArea.Enabled = cmbConfigRole.Enabled = false;
                cmbConfigDeviceType.Enabled = true;
                cmbConfigDeviceType.SelectedIndex = -1;
                groupConfigSocket.Enabled = false;
                CopyDeviceInfo();
            }
            else
            {
                btnAddDevice.Text = "添加组件";
                添加设备ToolStripMenuItem.Text = "添加组件";
                btnDeleteDevice.Text = "删除接口";
                删除设备ToolStripMenuItem.Text = "删除接口";
                btnAddDevice.Enabled = btnAddSocket.Enabled = btnDeleteDevice.Enabled = true;
                添加设备ToolStripMenuItem.Enabled = 删除设备ToolStripMenuItem.Enabled = 添加接口ToolStripMenuItem.Enabled = true;
                groupConfigDevice.Enabled = false;
                groupConfigSocket.Enabled = true;
                cmbConfigSocketPhyType.SelectedIndex = cmbConfigSocketLogicType.SelectedIndex = cmbConfigSocketSpeed.SelectedIndex = -1;
                chkAddrInfo.Checked = false;
                CopySocketInfo();
            }
        }

        private void CopyDeviceInfo()
        {
            ClearDeviceConfig();
            if (trvwConfigDevice.SelectedNode.Tag != null && trvwConfigDevice.SelectedNode.Tag is Hashtable )
            {
                foreach (DictionaryEntry de in (Hashtable)trvwConfigDevice.SelectedNode.Tag)
                {
                    switch (de.Key.ToString())
                    {
                        case "device_name":
                            txtConfigDeviceName.Text = de.Value.ToString();
                            break;
                        case "device_type_id_ref":
                            cmbConfigDeviceType.SelectedIndex = dsDeviceType.DeviceTypeAll.Rows.IndexOf(dsDeviceType.DeviceTypeAll.Select("device_type_id=" + de.Value.ToString())[0]);
                            break;
                        case "device_module":
                            txtConfigModule.Text = de.Value.ToString();
                            break;
                        case "device_manufactory_id_ref":
                            cmbConfigManufactory.SelectedIndex = dsManufactory.Manufactory.Rows.IndexOf(dsManufactory.Manufactory.Select("manufactory_id=" + de.Value.ToString())[0]);
                            break;
                        case "device_description":
                            txtConfigDeviceDescription.Text = de.Value.ToString();
                            break;
                        case "device_sn":
                            txtConfigDeviceSN.Text = de.Value.ToString();
                            break;
                        case "device_quick_service":
                            txtConfigQuickService.Text = de.Value.ToString();
                            break;
                        case "device_vender_id_ref":
                            cmbConfigVender.SelectedIndex = dsVender.VenderInfo.Rows.IndexOf(dsVender.VenderInfo.Select("vender_id=" + de.Value.ToString())[0]);
                            break;
                        case "device_purchase_date":
                            dtpkConfigPurchaseDate.Text = de.Value.ToString();
                            break;
                        case "device_warranty":
                            txtConfigWarranty.Text = de.Value.ToString();
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                txtConfigDeviceName.Text = trvwConfigDevice.SelectedNode.Text;
            }
        }

        private void CopySocketInfo()
        {
            ClearSocketConfig();
            if (trvwConfigDevice.SelectedNode.Tag != null && trvwConfigDevice.SelectedNode.Tag is Hashtable)
            {
                foreach (DictionaryEntry de in (Hashtable)trvwConfigDevice.SelectedNode.Tag)
                {
                    switch(de.Key.ToString())
                    {
                        case "socket_name":
                            txtConfigSocketName.Text = de.Value.ToString();
                            break;
                        case "socket_phy_type_id_ref":
                            /*
                            for(int i=0;i<dsPhyType.SocketPhyType.Rows.Count;i++)
                            {
                                if(dsPhyType.SocketPhyType.Rows[i]["socket_phy_type_id"].ToString()==de.Value.ToString())
                                {
                                    cmbConfigSocketPhyType.SelectedIndex = i;
                                }
                            }*/
                            cmbConfigSocketPhyType.SelectedIndex = dsPhyType.SocketPhyType.Rows.IndexOf(dsPhyType.SocketPhyType.Select("socket_phy_type_id=" + de.Value.ToString())[0]);
                            break;
                        case "socket_logic_type_id_ref":
                            /*
                            for(int i=0;i<dsLogicType.SocketLogicType.Rows.Count;i++)
                            {
                                if(dsLogicType.SocketLogicType.Rows[i]["socket_logic_type_id"].ToString()==de.Value.ToString())
                                {
                                    cmbConfigSocketLogicType.SelectedIndex = i;
                                }
                            }*/
                            cmbConfigSocketLogicType.SelectedIndex = dsLogicType.SocketLogicType.Rows.IndexOf(dsLogicType.SocketLogicType.Select("socket_logic_type_id=" + de.Value.ToString())[0]);
                            break;
                        case "socket_speed_type_id_ref":
                            /*
                            for(int i=0;i<dsSpeedType.SocketSpeedType.Rows.Count;i++)
                            {
                                if (dsSpeedType.SocketSpeedType.Rows[i]["socket_speed_type_id"].ToString()==de.Value.ToString())
                                {
                                    cmbConfigSocketSpeed.SelectedIndex = i;
                                }
                            }*/
                            cmbConfigSocketSpeed.SelectedIndex = dsSpeedType.SocketSpeedType.Rows.IndexOf(dsSpeedType.SocketSpeedType.Select("socket_speed_type_id=" + de.Value.ToString())[0]);
                            break;
                        case "socket_description":
                            txtConfigSocketDescription.Text = de.Value.ToString();
                            break;
                        case "SocketAddressInfo":
                            //chkAddrInfo.CheckState = CheckState.Checked;
                            ipv4Address.Text = ((TCPIP)de.Value).IPv4Address;
                            ipv4Mask.Text = ((TCPIP)de.Value).IPv4Mask;
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                txtConfigSocketName.Text = trvwConfigDevice.SelectedNode.Text;
            }
        }

        private bool CheckDeviceConfig()
        {
            if ("" == txtConfigDeviceName.Text)
            {
                MessageBox.Show("设备名不能为空！");
                return false;
            }
            else if (cmbConfigDeviceType.SelectedIndex < 0)
            {
                MessageBox.Show("请选择设备类型！");
                return false;
            }
            else if (cmbConfigManufactory.SelectedIndex < 0)
            {
                MessageBox.Show("请选择设备厂商！");
                return false;
            }
            else if (cmbConfigVender.SelectedIndex < 0)
            {
                MessageBox.Show("请选择供应商！");
                return false;
            }
            return true;
        }

        private bool CheckSocketConfig()
        {
            if ("" == txtConfigSocketName.Text)
            {
                MessageBox.Show("接口名不能为空！");
                return false;
            }
            else if (cmbConfigSocketPhyType.SelectedIndex < 0 && cmbConfigSocketLogicType.SelectedIndex < 0)
            {
                MessageBox.Show("物理接口类型和逻辑接口类型至少选择一项！");
                return false;
            }
            return true;
        }

        private void 在设备定义中编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNodeEx root = (TreeNodeEx)(trvwDevice.Nodes[0] as TreeNodeEx).Clone();
            //root.ID = (trvwDevice.Nodes[0] as TreeNodeEx).ID;
            BuildNodeInfo(root);
            bool hasNodeRecord = false;
            foreach(TreeNodeEx node in trvwConfigDevice.Nodes)
            {
                if ((int)((Hashtable)root.Tag)["device_info_id"] == (int)((Hashtable)node.Tag)["device_info_id"])
                {
                    hasNodeRecord = true;
                    break;
                }
            }
            if (!hasNodeRecord)
            {
                trvwConfigDevice.Nodes.AddRange(new TreeNodeEx[] { root });
            }
            tabAll.SelectTab(tabDefineDevice);
            trvwConfigDevice.SelectedNode = root;
            trvwConfigDevice.Focus();
            trvwConfigDevice.ExpandAll();
            RefreshDeviceConfigTab();
        }

        private void BuildNodeInfo(TreeNodeEx pNode)
        {
            FindNodeInfo(pNode);
            if (pNode.Nodes.Count > 0)
            {
                foreach (TreeNodeEx child in pNode.Nodes)
                {
                    BuildNodeInfo(child);
                }
            }
        }

        private void FindNodeInfo(TreeNodeEx node)
        {
            switch (node.Name)
            {
                case "device":
                    DataRow[] devicerows = dsDeviceInfo.GetModules.Select("device_info_id=" + node.Tag.ToString()/*node.ID*/);
                    Hashtable deviceht = new Hashtable(10);
                    deviceht.Add("device_name", devicerows[0]["device_name"].ToString());
                    deviceht.Add("device_info_id", (int)devicerows[0]["device_info_id"]/*node.ID*/);
                    if (devicerows[0]["device_module"] != null)
                    {
                        deviceht.Add("device_module", devicerows[0]["device_module"].ToString());
                    }
                    if (devicerows[0]["device_description"] != null)
                    {
                        deviceht.Add("device_description", devicerows[0]["device_description"].ToString());
                    }
                    try
                    {
                        deviceht.Add("device_type_id_ref", (int)devicerows[0]["device_type_id_ref"]);
                    }
                    catch (Exception e) { Debug.WriteLine(e.ToString()); }
                    try
                    {
                        deviceht.Add("device_manufactory_id_ref", (int)devicerows[0]["device_manufactory_id_ref"]);
                    }
                    catch (Exception e) { Debug.WriteLine(e.ToString()); }
                    try
                    {
                        deviceht.Add("device_vender_id_ref", (int)devicerows[0]["device_vender_id_ref"]);
                    }
                    catch (Exception e) { Debug.WriteLine(e.ToString()); }
                    if (devicerows[0]["device_sn"] != null)
                    {
                        deviceht.Add("device_sn", devicerows[0]["device_sn"].ToString());
                    }
                    if (devicerows[0]["device_quick_service"] != null)
                    {
                        deviceht.Add("device_quick_service", devicerows[0]["device_quick_service"].ToString());
                    }
                    node.Tag = deviceht;
                    break;
                case "socket":
                    DataRow[] socketrows = dsSocketInfo.GetSockets.Select("socket_id=" + node.Tag.ToString()/*node.ID*/);
                    Hashtable socketht = new Hashtable(5);
                    socketht.Add("socket_name", socketrows[0]["socket_name"].ToString());
                    socketht.Add("socket_id", (int)socketrows[0]["socket_id"]/*node.ID*/);
                    if(socketrows[0]["socket_description"] != null)
                    {
                        socketht.Add("socket_description", socketrows[0]["socket_description"].ToString());
                    }
                    try
                    {
                        socketht.Add("socket_phy_type_id_ref", (int)socketrows[0]["socket_phy_type_id_ref"]);
                    }
                    catch (Exception e) { Debug.WriteLine(e.ToString()); }
                    try
                    {
                        socketht.Add("socket_logic_type_id_ref", (int)socketrows[0]["socket_logic_type_id_ref"]);
                    }
                    catch (Exception e) { Debug.WriteLine(e.ToString()); }
                    try
                    {
                        socketht.Add("socket_speed_type_id_ref", (int)socketrows[0]["socket_speed_type_id_ref"]);
                    }
                    catch (Exception e) { Debug.WriteLine(e.ToString()); }
                    TCPIP ip = new TCPIP();
                    bool tmp = false;
                    if(!(socketrows[0]["socket_ipv4_addr"] is DBNull))
                    {
                        ip.IPv4AddrBytes = (byte[])socketrows[0]["socket_ipv4_addr"];
                        tmp = tmp | true;
                    }
                    if(!(socketrows[0]["socket_ipv4_mask"] is DBNull))
                    {
                        ip.IPv4MaskBytes = (byte[])socketrows[0]["socket_ipv4_mask"];
                        tmp = tmp | true;
                    }
                    if(!(socketrows[0]["socket_ipv4_gw"] is DBNull))
                    {
                        ip.IPv4GwBytes = (byte[])socketrows[0]["socket_ipv4_gw"];
                        tmp = tmp | true;
                    }
                    ip.IPv4Description = socketrows[0]["socket_ipv4_description"].ToString();
                    if (tmp)
                    {
                        socketht.Add("SocketAddressInfo", ip);
                    }
                    node.Tag = socketht;
                    break;
                default:
                    break;
             }
        }

        private void tabAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabAll.SelectedTab.Text)
            {
                case "设备查询":
                    编辑ToolStripMenuItem.Enabled = false;
                    ClearFindParameter();
                    break;
                case "设备定义":
                    编辑ToolStripMenuItem.Enabled = true;
                    RefreshDeviceConfigTab();
                    break;
                case "设备拓扑":
                    编辑ToolStripMenuItem.Enabled = false;
                    MessageBox.Show("功能开发中，敬请期待。^-^");
                    break;
                default:
                    编辑ToolStripMenuItem.Enabled = false;
                    break;
            }
        }

        private void 刷新设备信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listDevices_SelectedIndexChanged(null, null);
        }

        private int FindRootNodeIndex(TreeNode node)
        {
            if(node.Parent!=null)
            {
                return FindRootNodeIndex(node.Parent);
            }
            else
            {
                return node.Index;
            }
        }

        private void btnSaveCurrentDevice_Click(object sender, EventArgs e)
        {
            if (trvwConfigDevice.SelectedNode != null)
            {
                btnAddDevice.Enabled = btnAddSocket.Enabled = btnDeleteDevice.Enabled = false;
                groupConfigDevice.Enabled = groupConfigSocket.Enabled = false;
                int index = FindRootNodeIndex(trvwConfigDevice.SelectedNode);
                Thread tr = new Thread(new ThreadStart(delegate { SaveConfig(trvwConfigDevice.Nodes[index]); }));
                tr.IsBackground = true;
                tr.Start();
            }
            else
            {
                MessageBox.Show("请选择需要保存的设备节点！");
            }
        }

        private void btnSaveDevice2File_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能开发中，敬请期待^_^");
        }

        private int InsRecAndRtID(string tablename,Hashtable data)
        {
            string cmdText = ITInventory.GenSQL(SQLMethod.INSERT, tablename, data);
            OleDbParameter sql = new OleDbParameter("@sql", OleDbType.VarChar);
            sql.Value = cmdText;
            OleDbParameter id = new OleDbParameter("@id", OleDbType.Integer);
            id.Direction = ParameterDirection.Output;
            ITInventory.ExecProcedure("InsertDataSQL", new OleDbParameter[] { sql, id });
            return (int)id.Value;
        }

        private void 导入模版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(opfDialog.ShowDialog()==DialogResult.OK)
            {
                fsTempleteWatcher.Path = opfDialog.FileName;
                templetes.ParseTempletes(opfDialog.FileName);
                trvwTempletes.Nodes.AddRange(templetes.TempleteRoot);
                tabAll.SelectedTab = tabAll.TabPages["tabDefineDevice"];
                fsTempleteWatcher.EnableRaisingEvents = true;
            }
        }

        private void trvwTempletes_MouseDown(object sender, MouseEventArgs e)
        {
            trvwTempletes.SelectedNode = trvwTempletes.GetNodeAt(e.Location);
            if (trvwTempletes.SelectedNode != null && e.Button == MouseButtons.Right)
            {
                trvwTempletes.ContextMenuStrip = contMenuTrvwTemplete;
            }
            else
            {
                trvwTempletes.ContextMenuStrip = null;
            }
        }

        private void 从该模版导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = trvwTempletes.SelectedNode;
            while(node.Parent!=null)
            {
                node = node.Parent;
            }
            int index = node.Index;
            trvwConfigDevice.Nodes.AddRange(new TreeNodeEx[] { (TreeNodeEx)templetes.TempleteRootDetail[index].Clone() });
        }

        private void 编辑模版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能开发中，敬请期待……");
            //System.Diagnostics.Process.Start(@"D:\Users\Sonny\Documents\Visual Studio 2015\Projects\ITInventory\TempleteEditor\bin\Debug\TempleteEditor.exe");
        }

        private void 清除全部设备ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trvwConfigDevice.Nodes.Clear();
            RefreshDeviceConfigTab();
        }

        private void 清除该设备ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = trvwConfigDevice.SelectedNode;
            while(node.Level!=0)
            {
                node = node.Parent;
            }
            node.Remove();
            RefreshDeviceConfigTab();
        }

        private void fsTempleteWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            //Debug.WriteLine(e.FullPath);
            if(DialogResult.Yes== MessageBox.Show(e.FullPath + "有更改，是否导入更改内容？","注意",MessageBoxButtons.YesNo))
            {
                templetes.ParseTempletes(e.FullPath);
                trvwTempletes.Nodes.Clear();
                trvwTempletes.Nodes.AddRange(templetes.TempleteRoot);
                tabAll.SelectedTab = tabAll.TabPages["tabDefineDevice"];
            }
        }

        private void trvwConfigDevice_DragDrop(object sender, DragEventArgs e)
        {
            Point pt = trvwConfigDevice.PointToClient(MousePosition);
            TreeNodeEx dragOverNode = (TreeNodeEx)trvwConfigDevice.GetNodeAt(pt);
            if (dragOverNode != null && dragOverNode != dragDropNode)
            {
                Debug.WriteLine(e.KeyState);
                if (e.KeyState == 0x08)                        //Ctrl键同时按下
                {
                    e.Effect = DragDropEffects.Copy;
                    clipbrdNode = CopyNode(dragDropNode);
                    dragOverNode.Nodes.AddRange(new TreeNodeEx[] { clipbrdNode });
                }
                else
                {
                    e.Effect = DragDropEffects.Move;
                    CutNode(dragDropNode);
                    dragOverNode.Nodes.AddRange(new TreeNodeEx[] { clipbrdNode });
                }
                trvwConfigDevice.SelectedNode = clipbrdNode;
                clipbrdNode = null;
                dragOverNode.Expand();
                dragOverNode.BackColor = SystemColors.Window;
                dragOverNode.ForeColor = SystemColors.WindowText;
                if (lastDragOverNode != null)
                {
                    lastDragOverNode.BackColor = SystemColors.Window;
                    lastDragOverNode.ForeColor = SystemColors.WindowText;
                }
                lastDragOverNode = null;
            }
        }

        private void trvwConfigDevice_DragOver(object sender, DragEventArgs e)
        {
            Point pt = trvwConfigDevice.PointToClient(Control.MousePosition);
            TreeNodeEx dragOverNode = (TreeNodeEx)trvwConfigDevice.GetNodeAt(pt);
            if (dragOverNode != null && dragOverNode != dragDropNode)
            {
                if (dragDropNode != dragOverNode)
                {
                    if (dragOverNode.Nodes.Count > 0 && dragOverNode.IsExpanded == false)
                    {
                        timeExpandCountDown.Enabled = true;
                    }
                }
                if ((e.AllowedEffect & DragDropEffects.Move) != 0)
                {
                    e.Effect = DragDropEffects.Move;
                }
                if ((e.AllowedEffect & DragDropEffects.Copy) != 0 && (e.KeyState & 0x08) != 0)
                {
                    e.Effect = DragDropEffects.Copy;
                }
                if (dragOverNode != lastDragOverNode)
                {
                    dragOverNode.BackColor = SystemColors.Highlight;
                    dragOverNode.ForeColor = SystemColors.HighlightText;
                    if (lastDragOverNode != null)
                    {
                        lastDragOverNode.BackColor = SystemColors.Window;
                        lastDragOverNode.ForeColor = SystemColors.WindowText;
                    }
                    lastDragOverNode = dragOverNode;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
                if (lastDragOverNode != null)
                {
                    lastDragOverNode.BackColor = SystemColors.Window;
                    lastDragOverNode.ForeColor = SystemColors.WindowText;
                }
                lastDragOverNode = dragOverNode;
            }
        }

        private void timeExpandCountDown_Tick(object sender, EventArgs e)
        {
            timeExpandCountDown.Enabled = false;
            Point pt = trvwConfigDevice.PointToClient(MousePosition);
            TreeNode node = trvwConfigDevice.GetNodeAt(pt);
            if (node != null)
            {
                node.Expand();
            }
        }

        private void trvwConfigDevice_ItemDrag(object sender, ItemDragEventArgs e)
        {
            dragDropNode = e.Item as TreeNodeEx;
            if (e.Button == MouseButtons.Left && dragDropNode != null && dragDropNode.Parent != null)
            {
                trvwConfigDevice.DoDragDrop(dragDropNode, DragDropEffects.Copy | DragDropEffects.Move | DragDropEffects.Scroll);
                trvwConfigDevice.SelectedNode = dragDropNode;
            }
        }

        private void 复制节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clipbrdNode = CopyNode((TreeNodeEx)trvwConfigDevice.SelectedNode);
        }

        private TreeNodeEx CopyNode(TreeNodeEx node)
        {
            if (node != null)
            {
                var tmp = (TreeNodeEx)node.Clone();
                if (node.Tag is Hashtable)
                {
                    tmp.Tag = ((Hashtable)node.Tag).Clone();
                    switch (tmp.Name)
                    {
                        case "device":
                            if (((Hashtable)tmp.Tag).ContainsKey("device_info_id"))
                            {
                                ((Hashtable)tmp.Tag).Remove("device_info_id");
                            }
                            if (((Hashtable)tmp.Tag).ContainsKey("device_parent_id_ref"))
                            {
                                ((Hashtable)tmp.Tag).Remove("device_parent_id_ref");
                            }
                            break;
                        case "socket":
                            if (((Hashtable)tmp.Tag).ContainsKey("socket_id"))
                            {
                                ((Hashtable)tmp.Tag).Remove("socket_id");
                            }
                            if (((Hashtable)tmp.Tag).ContainsKey("socket_owner_id_ref"))
                            {
                                ((Hashtable)tmp.Tag).Remove("socket_owner_id_ref");
                            }
                            if (((Hashtable)tmp.Tag).ContainsKey("SocketAddressInfo"))
                            {
                                ((Hashtable)tmp.Tag).Remove("SocketAddressInfo");
                            }
                            break;
                        default:
                            break;
                    }
                }
                if(tmp.Nodes.Count>0)
                {
                    for(int i=0;i<tmp.Nodes.Count;i++)
                    {
                        tmp.Nodes[i] = CopyNode((TreeNodeEx)tmp.Nodes[i]);
                    }
                }
                return tmp;
            }
            else
            {
                return null;
            }
        }

        private void 剪切节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CutNode((TreeNodeEx)trvwConfigDevice.SelectedNode);
        }

        private void CutNode(TreeNodeEx node)
        {
            if (node != null)
            {
                //clipbrdNode = (TreeNodeEx)trvwConfigDevice.SelectedNode.Clone();
                clipbrdNode = (TreeNodeEx)node.Clone();
                switch (clipbrdNode.Name)
                {
                    case "device":
                        if (((Hashtable)clipbrdNode.Tag).ContainsKey("device_parent_id_ref"))
                        {
                            ((Hashtable)clipbrdNode.Tag).Remove("device_parent_id_ref");
                        }
                        break;
                    case "socket":
                        if (((Hashtable)clipbrdNode.Tag).ContainsKey("socket_id"))
                        {
                            DestroySockDeviceRelation((int)((Hashtable)clipbrdNode.Tag)["socket_id"]);
                        }
                        if (((Hashtable)clipbrdNode.Tag).ContainsKey("socket_owner_id_ref"))
                        {
                            ((Hashtable)clipbrdNode.Tag).Remove("socket_owner_id_ref");
                        }
                        break;
                    default:
                        break;
                }
                //trvwConfigDevice.Nodes.Remove(trvwConfigDevice.SelectedNode);
                node.Remove();
            }
        }

        private void 粘贴节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteNode();
        }

        private void PasteNode()
        {
            if (trvwConfigDevice.SelectedNode != null)
            {
                trvwConfigDevice.SelectedNode.Nodes.AddRange(new TreeNodeEx[] { clipbrdNode });
                clipbrdNode = CopyNode(clipbrdNode);
            }
        }

        private void DestroySockDeviceRelation(int socket_id)
        {
            if (ITInventory.HasRecord("DeviceSocketRelation", "socket_info_id_ref=" + socket_id)==DBCode.HasRecord)
            {
                ITInventory.DelRecord("DeviceSocketRelation", "socket_info_id_ref=" + socket_id);
            }
        }

        private void chkAddrInfo_CheckedChanged(object sender, EventArgs e)
        {
            ipv4Address.Enabled = ipv4Mask.Enabled = chkAddrInfo.Checked;
        }

        private void gdvwSocketInfo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for(int i=0;i<gdvwSocketInfo.Rows.Count;i++)
            {
                TCPIP ip = new TCPIP();
                if(!(dsSocketInfo.GetSockets[i]["socket_ipv4_addr"] is System.DBNull))
                {
                    byte[] tmp = (byte[])dsSocketInfo.GetSockets[i]["socket_ipv4_addr"];
                    Array.Reverse(tmp);
                    ip.IPv4AddrBytes = tmp;
                    gdvwSocketInfo.Rows[i].Cells["socket_ipv4_addr"].Value = ip.IPv4Address;
                }
                if(!(dsSocketInfo.GetSockets[i]["socket_ipv4_mask"] is System.DBNull))
                {
                    byte[] tmp = (byte[])dsSocketInfo.GetSockets[i]["socket_ipv4_mask"];
                    Array.Reverse(tmp);
                    ip.IPv4MaskBytes = tmp;
                    gdvwSocketInfo.Rows[i].Cells["socket_ipv4_mask"].Value = ip.IPv4Mask;
                }
                if(!(dsSocketInfo.GetSockets[i]["socket_ipv4_gw"] is System.DBNull))
                {
                    byte[] tmp = (byte[])dsSocketInfo.GetSockets[i]["socket_ipv4_gw"];
                    Array.Reverse(tmp);
                    ip.IPv4GwBytes = tmp;
                    gdvwSocketInfo.Rows[i].Cells["socket_ipv4_gw"].Value = ip.IPv4Gw;
                }
            }
        }

        private string GenFilter()
        {
            string filter = "";
            List<string> filters = new List<string>();
            if (rdoNamePrecise.Checked)
            {
                filters.Add("device_name='" + txtDeviceName.Text + "'");
                Debug.WriteLine(filters);
            }
            else if (txtDeviceName.Text.Trim() != "")
            {
                filters.Add("device_name LIKE '%" + txtDeviceName.Text + "%'");
                Debug.WriteLine(filters);
            }
            if(txtDeviceDescrip.Text.Trim()!="")
            {
                filters.Add("device_description LIKE '%" + txtDeviceDescrip.Text + "%'");
                Debug.WriteLine(filters);
            }
            if (rdoModulePrecise.Checked)
            {
                filters.Add("device_module='" + txtDeviceModule.Text + "'");
                Debug.WriteLine(filters);
            }
            else if (txtDeviceModule.Text.Trim() != "")
            {
                filters.Add("device_module LIKE '%" + txtDeviceModule.Text + "%'");
                Debug.WriteLine(filters);
            }
            if (chkEnableDate.Checked)
            {
                if (rdoWarrantyIn.Checked)
                {
                    filters.Add("DATEADD(DAY, -1, DATEADD(YEAR,dbo.DeviceInfo.device_warranty, dbo.DeviceInfo.device_purchase_date))>='" + dtpkWarrantyDate.Value.ToShortDateString() + "'");
                }
                else
                {
                    filters.Add("DATEADD(DAY, -1, DATEADD(YEAR,dbo.DeviceInfo.device_warranty, dbo.DeviceInfo.device_purchase_date))<'" + dtpkWarrantyDate.Value.ToShortDateString() + "'");
                }
            }
            if (cmbDeviceType.SelectedIndex >= 0)
            {
                filters.Add("device_type_id_ref=" + cmbDeviceType.SelectedValue.ToString());
                Debug.WriteLine(filters);
            }
            if (cmbManufactory.SelectedIndex >= 0)
            {
                filters.Add("device_manufactory_id_ref=" + cmbManufactory.SelectedValue.ToString());
                Debug.WriteLine(filters);
            }
            if (cmbVender.SelectedIndex >= 0)
            {
                filters.Add("device_vender_id_ref=" + cmbVender.SelectedValue.ToString());
                Debug.WriteLine(filters);
            }
            foreach(var tmp in filters)
            {
                filter = filter + tmp + " AND ";
            }
            return filter;
        }

        private void iPv4End_Enter(object sender, EventArgs e)
        {
            iPv4End.Text = iPv4Start.Text;
        }

        private void chkIP_CheckedChanged(object sender, EventArgs e)
        {
            iPv4Start.Enabled = iPv4End.Enabled = chkIP.Checked;
        }

        private void 复制内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(gdvwContent);
            try
            {
                Clipboard.SetText(gdvwContent);
            }
            catch(Exception err)
            {
                Debug.WriteLine(err);
            }
        }

        private void listDevices_MouseDown(object sender, MouseEventArgs e)
        {
            Debug.WriteLine(e.Location);
            int index = listDevices.IndexFromPoint(e.Location);
            if (index < 0)
            {
                listDevices.SelectedItem = null;
                listDevices.ContextMenuStrip = null;
            }
            else
            {
                listDevices.SelectedIndex = index;
                listDevices.ContextMenuStrip = contMenuTrvwDevice;
            }
        }

        private void 重新获取配置数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = -1;
            int configindex = -1;

            index = cmbDeviceType.SelectedIndex;
            this.deviceTypeTableAdapter.Fill(dsDeviceType.DeviceType);
            cmbDeviceType.SelectedIndex = index;
            index = cmbConfigDeviceType.SelectedIndex;
            this.deviceTypeAllTableAdapter.Fill(dsDeviceType.DeviceTypeAll);
            cmbConfigDeviceType.SelectedIndex = index;

            index = cmbVender.SelectedIndex;
            configindex = cmbConfigVender.SelectedIndex;
            this.venderInfoTableAdapter.Fill(dsVender.VenderInfo);
            cmbVender.SelectedIndex = index;
            cmbConfigVender.SelectedIndex = configindex;

            index = cmbManufactory.SelectedIndex;
            configindex = cmbConfigManufactory.SelectedIndex;
            this.manufactoryTableAdapter.Fill(dsManufactory.Manufactory);
            cmbManufactory.SelectedIndex = index;
            cmbConfigManufactory.SelectedIndex = configindex;
            
            index = cmbConfigSocketPhyType.SelectedIndex;
            this.socketPhyTypeTableAdapter.Fill(dsPhyType.SocketPhyType);
            cmbConfigSocketPhyType.SelectedIndex = index;

            index = cmbConfigSocketLogicType.SelectedIndex;
            this.socketLogicTypeTableAdapter.Fill(dsLogicType.SocketLogicType);
            cmbConfigSocketLogicType.SelectedIndex = index;

            index = cmbConfigSocketSpeed.SelectedIndex;
            this.socketSpeedTypeTableAdapter.Fill(dsSpeedType.SocketSpeedType);
            cmbConfigSocketSpeed.SelectedIndex = index;
        }

        private void groupConfigDevice_Leave(object sender, EventArgs e)
        {
            UpdateDevice();
        }

        private void groupConfigSocket_Leave(object sender, EventArgs e)
        {
            UpdateSocket();
        }
    }
}
