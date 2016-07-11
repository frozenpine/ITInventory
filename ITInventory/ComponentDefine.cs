using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ITInventory
{
    public partial class ComponentDefine : Form
    {
        public enum FormType
        {
            Device=0,
            Component,
            Socket
        };

        private string compoName;
        public string ComponentName
        {
            set { compoName = value; }
            get { return compoName; }
        }

        private int compoQuant=1;
        public int ComponentQuantity
        {
            set { compoQuant = value; }
            get { return compoQuant; }
        }

        private int index = 0;
        public int Index
        {
            set { index = value; }
            get { return index; }
        }

        private FormType type;

        private Hashtable ht = new Hashtable(6);
        new public Hashtable Tag
        {
            get { return ht; }
        }

        public ComponentDefine(FormType type)
        {
            InitializeComponent();
            this.type = type;
        }

        private void ComponentDefine_Shown(object sender, EventArgs e)
        {
            txtName.Text = compoName;
            txtQuantity.Text = compoQuant.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                compoName = txtName.Text;
                compoQuant = int.Parse(txtQuantity.Text);
                index = int.Parse(txtIndex.Text);
                switch (type)
                {
                    case FormType.Socket:
                        if (cmbConfigSocketPhyType.SelectedIndex >= 0)
                        {
                            ht.Add("socket_phy_type_id_ref", (int)cmbConfigSocketPhyType.SelectedValue);
                        }
                        else
                        {
                            ht.Add("socket_logic_type_id_ref", (int)cmbConfigSocketLogicType.SelectedValue);
                        }
                        ht.Add("socket_speed_type_id_ref", (int)cmbConfigSocketSpeed.SelectedValue);
                        if(txtConfigSocketDescription.Text!="")
                        {
                            ht.Add("socket_description", txtConfigSocketDescription.Text);
                        }
                        break;
                    default:
                        ht.Add("device_type_id_ref", (int)cmbConfigDeviceType.SelectedValue);
                        ht.Add("device_manufactory_id_ref", (int)cmbConfigManufactory.SelectedValue);
                        ht.Add("device_vender_id_ref", (int)cmbConfigVender.SelectedValue);
                        if (txtConfigModule.Text != "")
                        {
                            ht.Add("device_module", txtConfigModule.Text);
                        }
                        if(txtConfigDeviceDescription.Text!="")
                        {
                            ht.Add("device_description", txtConfigDeviceDescription.Text);
                        }
                        break;
                }
                btnOK.DialogResult = DialogResult.OK;
            }
            else
            {
                btnOK.DialogResult = DialogResult.Cancel;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Escape)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void ComponentDefine_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dsVender.VenderInfo”中。您可以根据需要移动或删除它。
            this.venderInfoTableAdapter.Fill(this.dsVender.VenderInfo);
            // TODO: 这行代码将数据加载到表“dsManufactory.Manufactory”中。您可以根据需要移动或删除它。
            this.manufactoryTableAdapter.Fill(this.dsManufactory.Manufactory);
            // TODO: 这行代码将数据加载到表“dsSpeedType.SocketSpeedType”中。您可以根据需要移动或删除它。
            this.socketSpeedTypeTableAdapter.Fill(this.dsSpeedType.SocketSpeedType);
            // TODO: 这行代码将数据加载到表“dsLogicType.SocketLogicType”中。您可以根据需要移动或删除它。
            this.socketLogicTypeTableAdapter.Fill(this.dsLogicType.SocketLogicType);
            // TODO: 这行代码将数据加载到表“dsPhyType.SocketPhyType”中。您可以根据需要移动或删除它。
            this.socketPhyTypeTableAdapter.Fill(this.dsPhyType.SocketPhyType);

            string formName = "";
            switch (type)
            {
                case FormType.Device:
                    panlDevice.Visible = true;
                    this.Height = this.Height - panlSocket.Height;
                    this.deviceTypeTableAdapter.Fill(this.dsDeviceType.DeviceType);
                    cmbConfigDeviceType.DataSource = this.deviceTypeBindingSource;
                    cmbConfigDeviceType.DisplayMember = "device_type_name";
                    cmbConfigDeviceType.ValueMember = "device_type_id";
                    cmbConfigDeviceType.SelectedIndex = cmbConfigManufactory.SelectedIndex = cmbConfigVender.SelectedIndex = -1;
                    formName = "设备";
                    break;
                case FormType.Component:
                    panlDevice.Visible = true;
                    this.Height = this.Height - panlSocket.Height;
                    this.componetTypeTableAdapter.Fill(this.dsDeviceType.ComponetType);
                    cmbConfigDeviceType.DataSource = this.componetTypeBindingSource;
                    cmbConfigDeviceType.DisplayMember = "device_type_name";
                    cmbConfigDeviceType.ValueMember = "device_type_id";
                    cmbConfigDeviceType.SelectedIndex = cmbConfigManufactory.SelectedIndex = cmbConfigVender.SelectedIndex = -1;
                    formName = "组件";
                    break;
                case FormType.Socket:
                    panlSocket.Visible = true;
                    this.Height = this.Height - panlDevice.Height;
                    cmbConfigSocketPhyType.SelectedIndex = cmbConfigSocketLogicType.SelectedIndex = cmbConfigSocketSpeed.SelectedIndex = -1;
                    formName = "接口";
                    break;
                default:
                    break;
            }
            this.Text = formName + "定义";
            lbName.Text = formName + "名：";
            lbNote.Text = lbNote.Text.Replace("#param#", formName);
        }

        private bool CheckInput()
        {
            switch(type)
            {
                case FormType.Socket:
                    if (cmbConfigSocketPhyType.SelectedIndex < 0 && cmbConfigSocketLogicType.SelectedIndex < 0)
                    {
                        MessageBox.Show("物理接口类型/逻辑接口类型至少选择一项！");
                        return false;
                    }
                    else if(cmbConfigSocketSpeed.SelectedIndex<0)
                    {
                        MessageBox.Show("请选择接口速率！");
                        return false;
                    }
                    break;
                default:
                    if(cmbConfigDeviceType.SelectedIndex<0||cmbConfigManufactory.SelectedIndex<0||cmbConfigVender.SelectedIndex<0)
                    {
                        MessageBox.Show("请完整选择设备类型、制造厂商及供应商！");
                        return false;
                    }
                    break;
            }
            if(txtName.Text.Contains("{n}"))
            {
                return true;
            }
            else if(txtName.Text!="")
            {
                if (MessageBox.Show("未设置通配符{n}，将仅添加单个"+type.ToString()+"，是否继续？", "注意！", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    txtName.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                txtName.Focus();
                return false;
            }
        }

        private void cmbConfigSocketPhyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbConfigSocketLogicType.SelectedIndex = -1;
        }

        private void cmbConfigSocketLogicType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbConfigSocketPhyType.SelectedIndex = -1;
        }

        private void ComponentDefine_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(btnOK.DialogResult==DialogResult.Cancel)
            {
                btnOK.DialogResult = DialogResult.OK;
                e.Cancel = true;
            }
        }
    }
}
