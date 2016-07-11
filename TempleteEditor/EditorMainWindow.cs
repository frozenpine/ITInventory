using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using CommonClass;
using System.Configuration;
using System.Data.OleDb;
using System.Collections;
using System.Threading;
using System.Xml;

namespace TempleteEditor
{
    public partial class EditorMainWindow : Form
    {
        protected DB ITInventory = new DB(ConfigurationManager.ConnectionStrings["TempleteEditor.Properties.Settings.ConnStr2ITInventory"].ConnectionString);
        private Templetes templetes = new Templetes();
        private TreeNodeEx clipbrdNode;
        private TreeNodeEx dragDropNode;
        private TreeNodeEx lastDragOverNode;

        public EditorMainWindow()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            if (opfDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = opfDialog.FileName;
                templetes.ParseTempletes(txtFilePath.Text,false);
                trvwXML.Nodes.AddRange(templetes.TempleteRoot);
            }
        }

        private void TempleteEditor_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dsDeviceType1.DeviceTypeAll”中。您可以根据需要移动或删除它。
            this.deviceTypeAllTableAdapter.Fill(this.dsDeviceType1.DeviceTypeAll);
            // TODO: 这行代码将数据加载到表“dsSocketPhyType.SocketPhyType”中。您可以根据需要移动或删除它。
            this.socketPhyTypeTableAdapter.Fill(this.dsSocketPhyType.SocketPhyType);
            // TODO: 这行代码将数据加载到表“dsDeviceType.DeviceType”中。您可以根据需要移动或删除它。
            this.deviceTypeTableAdapter.Fill(this.dsDeviceType.DeviceType);

            this.cmbDeviceType.SelectedIndex = -1;
            this.cmbSocketPhyType.SelectedIndex = -1;
            RefreshTempleteEditor();
        }

        private void RefreshTempleteEditor()
        {
            if (trvwXML.SelectedNode == null)
            {
                btnAddDevice.Text = "添加设备";
                btnDelDevice.Text = "删除设备";
                btnAddDevice.Enabled = true;
                btnAddSocket.Enabled = btnDelDevice.Enabled = false;
                groupConfigDevice.Enabled = groupConfigSocket.Enabled = false;
            }
            else if (trvwXML.SelectedNode.Level == 0)
            {
                btnAddDevice.Text = "添加组件";
                btnDelDevice.Text = "删除设备";
                btnAddDevice.Enabled = btnDelDevice.Enabled = true;
                btnAddSocket.Enabled = true;
                groupConfigDevice.Enabled = true;
                groupConfigSocket.Enabled = false;
                //CopyDeviceInfo();
            }
            else if (trvwXML.SelectedNode.Name == "device")
            {
                btnAddDevice.Text = "添加组件";
                btnDelDevice.Text = "删除组件";
                btnAddDevice.Enabled = btnAddSocket.Enabled = btnDelDevice.Enabled = true;
                groupConfigDevice.Enabled = true;
                groupConfigSocket.Enabled = false;
                //CopyDeviceInfo();
            }
            else
            {
                btnAddDevice.Text = "添加组件";
                btnDelDevice.Text = "删除接口";
                btnAddDevice.Enabled = btnAddSocket.Enabled = btnDelDevice.Enabled = true;
                groupConfigDevice.Enabled = false;
                groupConfigSocket.Enabled = true;
                //CopySocketInfo();
            }
        }

        private void trvwXML_AfterSelect(object sender, TreeViewEventArgs e)
        {
            RefreshTempleteEditor();
        }

        private void trvwXML_MouseDown(object sender, MouseEventArgs e)
        {
            if(trvwXML.GetNodeAt(e.Location)==null)
            {
                trvwXML.SelectedNode = null;
                trvwXML.ContextMenuStrip = null;
                RefreshTempleteEditor();
            }
            else if(e.Button==MouseButtons.Right)
            {
                trvwXML.SelectedNode = trvwXML.GetNodeAt(e.Location);
                if(clipbrdNode==null)
                {
                    粘贴节点ToolStripMenuItem.Enabled = false;
                }
                else
                {
                    粘贴节点ToolStripMenuItem.Enabled = true;
                }
                trvwXML.ContextMenuStrip = contMenuTemplete;
                RefreshTempleteEditor();
            }
        }

        private void 复制该节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trvwXML.SelectedNode != null)
            {
                clipbrdNode = (TreeNodeEx)trvwXML.SelectedNode.Clone();
            }
        }

        private void 剪切该节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(trvwXML.SelectedNode!=null)
            {
                clipbrdNode = (TreeNodeEx)trvwXML.SelectedNode.Clone();
                trvwXML.Nodes.Remove(trvwXML.SelectedNode);
            }
        }

        private void 粘贴节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(trvwXML.SelectedNode!=null)
            {
                trvwXML.SelectedNode.Nodes.AddRange(new TreeNode[] { clipbrdNode });
                clipbrdNode = null;
            }
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            /*TreeNodeEx node = new TreeNodeEx();
            node.Name = "device";
            if (trvwXML.SelectedNode == null)
            {
                node.Text = "新设备";
                trvwXML.Nodes.AddRange(new TreeNodeEx[] { node });
            }
            else
            {
                node.Text = "新组件";
                trvwXML.SelectedNode.Nodes.AddRange(new TreeNodeEx[] { node });
                trvwXML.SelectedNode.Expand();
            }
            trvwXML.SelectedNode = node.Parent;*/
            TreeNodeEx[] nodelist;
            if (trvwXML.SelectedNode == null)
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
                            nodelist[i] = node;
                            nodelist[i].Tag = compo.Tag.Clone();
                            ((Hashtable)nodelist[i].Tag).Add("device_name", node.Text);
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
                    trvwXML.Nodes.AddRange(nodelist);
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
                            ((Hashtable)node.Tag).Add("device_name", node.Text);
                            nodelist[i] = node;
                            nodelist[i].Tag = compo.Tag.Clone();
                            ((Hashtable)nodelist[i].Tag).Add("device_name", node.Text);
                        }
                    }
                    else
                    {
                        TreeNodeEx node = new TreeNodeEx(compo.ComponentName);
                        node.Name = "device";
                        node.Tag = compo.Tag.Clone();
                        nodelist = new TreeNodeEx[1];
                        nodelist[0] = node;
                    }
                    trvwXML.SelectedNode.Nodes.AddRange(nodelist);
                    trvwXML.SelectedNode = nodelist[0].Parent;
                    trvwXML.SelectedNode.Expand();
                }
            }
        }

        private void btnAddSocket_Click(object sender, EventArgs e)
        {
            /*TreeNodeEx node = new TreeNodeEx("新接口");
            node.Name = "socket";
            if (trvwXML.SelectedNode == null)
            {
                MessageBox.Show("只能在设备/组件下创建接口！", "注意！");
            }
            else
            {
                trvwXML.SelectedNode.Nodes.AddRange(new TreeNodeEx[] { node });
                trvwXML.SelectedNode.Expand();
            }
            trvwXML.Focus();*/
            if (trvwXML.SelectedNode == null)
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
                    trvwXML.SelectedNode.Nodes.AddRange(nodelist);
                    trvwXML.SelectedNode.Expand();
                }
            }
        }

        private void btnDelDevice_Click(object sender, EventArgs e)
        {
            if (trvwXML.SelectedNode == null)
            {
                MessageBox.Show("请选择一个节点！");
            }
            else if (trvwXML.SelectedNode.Nodes.Count > 0)
            {
                if (MessageBox.Show("还有子设备未删除，确认删除该设备？", "注意！", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    trvwXML.Nodes.Remove(trvwXML.SelectedNode);
                }
            }
            else
            {
                trvwXML.Nodes.Remove(trvwXML.SelectedNode);
            }
            RefreshTempleteEditor();
            trvwXML.Focus();
        }

        private void trvwXML_ItemDrag(object sender, ItemDragEventArgs e)
        {
            dragDropNode = e.Item as TreeNodeEx;
            if (e.Button == MouseButtons.Left && dragDropNode != null && dragDropNode.Parent != null)
            {
                trvwXML.DoDragDrop(dragDropNode, DragDropEffects.Copy | DragDropEffects.Move);
                trvwXML.SelectedNode = dragDropNode;
            }
        }

        private void trvwXML_DragOver(object sender, DragEventArgs e)
        {
            Point pt = trvwXML.PointToClient(Control.MousePosition);
            TreeNodeEx dragOverNode = (TreeNodeEx)trvwXML.GetNodeAt(pt);
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
                    lastDragOverNode = (TreeNodeEx)dragOverNode;
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
            Point pt = trvwXML.PointToClient(Control.MousePosition);
            TreeNode node = trvwXML.GetNodeAt(pt);
            if(node!=null)
            {
                node.Expand();
            }
        }

        private void trvwXML_DragDrop(object sender, DragEventArgs e)
        {
            Point pt = trvwXML.PointToClient(MousePosition);
            TreeNodeEx dragOverNode = (TreeNodeEx)trvwXML.GetNodeAt(pt);
            if (dragOverNode != null && dragOverNode != dragDropNode)
            {
                Debug.WriteLine(e.KeyState);
                if(e.KeyState==0x08)                        //Ctrl键同时按下
                {
                    e.Effect = DragDropEffects.Copy;
                    dragOverNode.Nodes.AddRange(new TreeNode[] { (TreeNodeEx)dragDropNode.Clone() });
                }
                else
                {
                    e.Effect = DragDropEffects.Move;
                    dragDropNode.Remove();
                    dragOverNode.Nodes.AddRange(new TreeNode[] { dragDropNode });
                }
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

        private void btnSaveTemplete_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmDevice_Click(object sender, EventArgs e)
        {

        }
    }
}
