namespace ITInventory
{
    partial class ComponentDefine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbNote = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbConfigSocketSpeed = new System.Windows.Forms.ComboBox();
            this.socketSpeedTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSpeedType = new ITInventory.dsSpeedType();
            this.cmbConfigSocketLogicType = new System.Windows.Forms.ComboBox();
            this.socketLogicTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLogicType = new ITInventory.dsLogicType();
            this.cmbConfigSocketPhyType = new System.Windows.Forms.ComboBox();
            this.socketPhyTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPhyType = new ITInventory.dsPhyType();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.socketPhyTypeTableAdapter = new ITInventory.dsPhyTypeTableAdapters.SocketPhyTypeTableAdapter();
            this.socketLogicTypeTableAdapter = new ITInventory.dsLogicTypeTableAdapters.SocketLogicTypeTableAdapter();
            this.socketSpeedTypeTableAdapter = new ITInventory.dsSpeedTypeTableAdapters.SocketSpeedTypeTableAdapter();
            this.panlSocket = new System.Windows.Forms.Panel();
            this.panlDevice = new System.Windows.Forms.Panel();
            this.cmbConfigModule = new System.Windows.Forms.ComboBox();
            this.txtConfigModule = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbConfigVender = new System.Windows.Forms.ComboBox();
            this.venderInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsVender = new ITInventory.dsVender();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbConfigManufactory = new System.Windows.Forms.ComboBox();
            this.manufactoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsManufactory = new ITInventory.dsManufactory();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbConfigDeviceType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.manufactoryTableAdapter = new ITInventory.dsManufactoryTableAdapters.ManufactoryTableAdapter();
            this.venderInfoTableAdapter = new ITInventory.dsVenderTableAdapters.VenderInfoTableAdapter();
            this.dsDeviceType = new ITInventory.dsDeviceType();
            this.deviceTypeTableAdapter = new ITInventory.dsDeviceTypeTableAdapters.DeviceTypeTableAdapter();
            this.deviceTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.componetTypeTableAdapter = new ITInventory.dsDeviceTypeTableAdapters.ComponetTypeTableAdapter();
            this.componetTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label26 = new System.Windows.Forms.Label();
            this.txtConfigSocketDescription = new System.Windows.Forms.TextBox();
            this.txtConfigDeviceDescription = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.socketSpeedTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpeedType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socketLogicTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogicType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socketPhyTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPhyType)).BeginInit();
            this.panlSocket.SuspendLayout();
            this.panlDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venderInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsManufactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeviceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componetTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtName.Location = new System.Drawing.Point(77, 241);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "×";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQuantity.Location = new System.Drawing.Point(199, 241);
            this.txtQuantity.MaxLength = 2;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(25, 21);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.Text = "1";
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(298, 291);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 245);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(41, 12);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "label2";
            // 
            // lbNote
            // 
            this.lbNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbNote.AutoSize = true;
            this.lbNote.Location = new System.Drawing.Point(12, 276);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(149, 12);
            this.lbNote.TabIndex = 4;
            this.lbNote.Text = "#param#名支持\"{n}\"通配符";
            // 
            // txtIndex
            // 
            this.txtIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIndex.Location = new System.Drawing.Point(304, 241);
            this.txtIndex.MaxLength = 1;
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(25, 21);
            this.txtIndex.TabIndex = 2;
            this.txtIndex.Text = "0";
            this.txtIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "标号起始值：";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 129);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(197, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "数量";
            // 
            // cmbConfigSocketSpeed
            // 
            this.cmbConfigSocketSpeed.DataSource = this.socketSpeedTypeBindingSource;
            this.cmbConfigSocketSpeed.DisplayMember = "socket_speed_type_name";
            this.cmbConfigSocketSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfigSocketSpeed.FormattingEnabled = true;
            this.cmbConfigSocketSpeed.Location = new System.Drawing.Point(275, 31);
            this.cmbConfigSocketSpeed.Name = "cmbConfigSocketSpeed";
            this.cmbConfigSocketSpeed.Size = new System.Drawing.Size(97, 20);
            this.cmbConfigSocketSpeed.TabIndex = 23;
            this.cmbConfigSocketSpeed.ValueMember = "socket_speed_type_id";
            // 
            // socketSpeedTypeBindingSource
            // 
            this.socketSpeedTypeBindingSource.DataMember = "SocketSpeedType";
            this.socketSpeedTypeBindingSource.DataSource = this.dsSpeedType;
            // 
            // dsSpeedType
            // 
            this.dsSpeedType.DataSetName = "dsSpeedType";
            this.dsSpeedType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbConfigSocketLogicType
            // 
            this.cmbConfigSocketLogicType.DataSource = this.socketLogicTypeBindingSource;
            this.cmbConfigSocketLogicType.DisplayMember = "socket_logic_type_name";
            this.cmbConfigSocketLogicType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfigSocketLogicType.FormattingEnabled = true;
            this.cmbConfigSocketLogicType.Location = new System.Drawing.Point(142, 31);
            this.cmbConfigSocketLogicType.Name = "cmbConfigSocketLogicType";
            this.cmbConfigSocketLogicType.Size = new System.Drawing.Size(118, 20);
            this.cmbConfigSocketLogicType.TabIndex = 22;
            this.cmbConfigSocketLogicType.ValueMember = "socket_logic_type_id";
            this.cmbConfigSocketLogicType.SelectedIndexChanged += new System.EventHandler(this.cmbConfigSocketLogicType_SelectedIndexChanged);
            // 
            // socketLogicTypeBindingSource
            // 
            this.socketLogicTypeBindingSource.DataMember = "SocketLogicType";
            this.socketLogicTypeBindingSource.DataSource = this.dsLogicType;
            // 
            // dsLogicType
            // 
            this.dsLogicType.DataSetName = "dsLogicType";
            this.dsLogicType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbConfigSocketPhyType
            // 
            this.cmbConfigSocketPhyType.DataSource = this.socketPhyTypeBindingSource;
            this.cmbConfigSocketPhyType.DisplayMember = "socket_phy_type_name";
            this.cmbConfigSocketPhyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfigSocketPhyType.FormattingEnabled = true;
            this.cmbConfigSocketPhyType.Location = new System.Drawing.Point(9, 31);
            this.cmbConfigSocketPhyType.Name = "cmbConfigSocketPhyType";
            this.cmbConfigSocketPhyType.Size = new System.Drawing.Size(118, 20);
            this.cmbConfigSocketPhyType.TabIndex = 21;
            this.cmbConfigSocketPhyType.ValueMember = "socket_phy_type_id";
            this.cmbConfigSocketPhyType.SelectedIndexChanged += new System.EventHandler(this.cmbConfigSocketPhyType_SelectedIndexChanged);
            // 
            // socketPhyTypeBindingSource
            // 
            this.socketPhyTypeBindingSource.DataMember = "SocketPhyType";
            this.socketPhyTypeBindingSource.DataSource = this.dsPhyType;
            // 
            // dsPhyType
            // 
            this.dsPhyType.DataSetName = "dsPhyType";
            this.dsPhyType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(295, 11);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(57, 12);
            this.label25.TabIndex = 24;
            this.label25.Text = "接口速率";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(160, 11);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 12);
            this.label24.TabIndex = 25;
            this.label24.Text = "逻辑接口类型";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(27, 11);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 12);
            this.label23.TabIndex = 26;
            this.label23.Text = "物理接口类型";
            // 
            // socketPhyTypeTableAdapter
            // 
            this.socketPhyTypeTableAdapter.ClearBeforeFill = true;
            // 
            // socketLogicTypeTableAdapter
            // 
            this.socketLogicTypeTableAdapter.ClearBeforeFill = true;
            // 
            // socketSpeedTypeTableAdapter
            // 
            this.socketSpeedTypeTableAdapter.ClearBeforeFill = true;
            // 
            // panlSocket
            // 
            this.panlSocket.AutoSize = true;
            this.panlSocket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panlSocket.Controls.Add(this.label26);
            this.panlSocket.Controls.Add(this.txtConfigSocketDescription);
            this.panlSocket.Controls.Add(this.label23);
            this.panlSocket.Controls.Add(this.cmbConfigSocketSpeed);
            this.panlSocket.Controls.Add(this.cmbConfigSocketPhyType);
            this.panlSocket.Controls.Add(this.label25);
            this.panlSocket.Controls.Add(this.cmbConfigSocketLogicType);
            this.panlSocket.Controls.Add(this.label24);
            this.panlSocket.Dock = System.Windows.Forms.DockStyle.Top;
            this.panlSocket.Location = new System.Drawing.Point(0, 0);
            this.panlSocket.Name = "panlSocket";
            this.panlSocket.Size = new System.Drawing.Size(385, 81);
            this.panlSocket.TabIndex = 27;
            this.panlSocket.Visible = false;
            // 
            // panlDevice
            // 
            this.panlDevice.AutoSize = true;
            this.panlDevice.Controls.Add(this.txtConfigDeviceDescription);
            this.panlDevice.Controls.Add(this.label14);
            this.panlDevice.Controls.Add(this.cmbConfigModule);
            this.panlDevice.Controls.Add(this.txtConfigModule);
            this.panlDevice.Controls.Add(this.label8);
            this.panlDevice.Controls.Add(this.cmbConfigVender);
            this.panlDevice.Controls.Add(this.label17);
            this.panlDevice.Controls.Add(this.cmbConfigManufactory);
            this.panlDevice.Controls.Add(this.label21);
            this.panlDevice.Controls.Add(this.cmbConfigDeviceType);
            this.panlDevice.Controls.Add(this.label12);
            this.panlDevice.Dock = System.Windows.Forms.DockStyle.Top;
            this.panlDevice.Location = new System.Drawing.Point(0, 81);
            this.panlDevice.Name = "panlDevice";
            this.panlDevice.Size = new System.Drawing.Size(385, 142);
            this.panlDevice.TabIndex = 28;
            this.panlDevice.Visible = false;
            // 
            // cmbConfigModule
            // 
            this.cmbConfigModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbConfigModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfigModule.FormattingEnabled = true;
            this.cmbConfigModule.Location = new System.Drawing.Point(269, 91);
            this.cmbConfigModule.Name = "cmbConfigModule";
            this.cmbConfigModule.Size = new System.Drawing.Size(103, 20);
            this.cmbConfigModule.TabIndex = 19;
            // 
            // txtConfigModule
            // 
            this.txtConfigModule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfigModule.Location = new System.Drawing.Point(77, 91);
            this.txtConfigModule.Name = "txtConfigModule";
            this.txtConfigModule.Size = new System.Drawing.Size(186, 21);
            this.txtConfigModule.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(7, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "设备型号：";
            // 
            // cmbConfigVender
            // 
            this.cmbConfigVender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbConfigVender.DataSource = this.venderInfoBindingSource;
            this.cmbConfigVender.DisplayMember = "vender_name";
            this.cmbConfigVender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfigVender.FormattingEnabled = true;
            this.cmbConfigVender.Location = new System.Drawing.Point(77, 61);
            this.cmbConfigVender.Name = "cmbConfigVender";
            this.cmbConfigVender.Size = new System.Drawing.Size(295, 20);
            this.cmbConfigVender.TabIndex = 15;
            this.cmbConfigVender.ValueMember = "vender_id";
            // 
            // venderInfoBindingSource
            // 
            this.venderInfoBindingSource.DataMember = "VenderInfo";
            this.venderInfoBindingSource.DataSource = this.dsVender;
            // 
            // dsVender
            // 
            this.dsVender.DataSetName = "dsVender";
            this.dsVender.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(7, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 12);
            this.label17.TabIndex = 16;
            this.label17.Text = "供 应 商：";
            // 
            // cmbConfigManufactory
            // 
            this.cmbConfigManufactory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbConfigManufactory.DataSource = this.manufactoryBindingSource;
            this.cmbConfigManufactory.DisplayMember = "manufactory_alias";
            this.cmbConfigManufactory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfigManufactory.FormattingEnabled = true;
            this.cmbConfigManufactory.Location = new System.Drawing.Point(183, 32);
            this.cmbConfigManufactory.Name = "cmbConfigManufactory";
            this.cmbConfigManufactory.Size = new System.Drawing.Size(189, 20);
            this.cmbConfigManufactory.TabIndex = 13;
            this.cmbConfigManufactory.ValueMember = "manufactory_id";
            // 
            // manufactoryBindingSource
            // 
            this.manufactoryBindingSource.DataMember = "Manufactory";
            this.manufactoryBindingSource.DataSource = this.dsManufactory;
            // 
            // dsManufactory
            // 
            this.dsManufactory.DataSetName = "dsManufactory";
            this.dsManufactory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(242, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 12);
            this.label21.TabIndex = 14;
            this.label21.Text = "制造厂商：";
            // 
            // cmbConfigDeviceType
            // 
            this.cmbConfigDeviceType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbConfigDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfigDeviceType.FormattingEnabled = true;
            this.cmbConfigDeviceType.Location = new System.Drawing.Point(9, 32);
            this.cmbConfigDeviceType.Name = "cmbConfigDeviceType";
            this.cmbConfigDeviceType.Size = new System.Drawing.Size(168, 20);
            this.cmbConfigDeviceType.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(65, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 12);
            this.label12.TabIndex = 12;
            this.label12.Text = "设备类型";
            // 
            // manufactoryTableAdapter
            // 
            this.manufactoryTableAdapter.ClearBeforeFill = true;
            // 
            // venderInfoTableAdapter
            // 
            this.venderInfoTableAdapter.ClearBeforeFill = true;
            // 
            // dsDeviceType
            // 
            this.dsDeviceType.DataSetName = "dsDeviceType";
            this.dsDeviceType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deviceTypeTableAdapter
            // 
            this.deviceTypeTableAdapter.ClearBeforeFill = true;
            // 
            // deviceTypeBindingSource
            // 
            this.deviceTypeBindingSource.DataMember = "DeviceType";
            this.deviceTypeBindingSource.DataSource = this.dsDeviceType;
            // 
            // componetTypeTableAdapter
            // 
            this.componetTypeTableAdapter.ClearBeforeFill = true;
            // 
            // componetTypeBindingSource
            // 
            this.componetTypeBindingSource.DataMember = "ComponetType";
            this.componetTypeBindingSource.DataSource = this.dsDeviceType;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.Location = new System.Drawing.Point(12, 61);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(70, 12);
            this.label26.TabIndex = 27;
            this.label26.Text = "接口描述：";
            // 
            // txtConfigSocketDescription
            // 
            this.txtConfigSocketDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfigSocketDescription.Location = new System.Drawing.Point(89, 57);
            this.txtConfigSocketDescription.MaxLength = 500;
            this.txtConfigSocketDescription.Name = "txtConfigSocketDescription";
            this.txtConfigSocketDescription.Size = new System.Drawing.Size(283, 21);
            this.txtConfigSocketDescription.TabIndex = 28;
            // 
            // txtConfigDeviceDescription
            // 
            this.txtConfigDeviceDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfigDeviceDescription.Location = new System.Drawing.Point(77, 118);
            this.txtConfigDeviceDescription.MaxLength = 500;
            this.txtConfigDeviceDescription.Name = "txtConfigDeviceDescription";
            this.txtConfigDeviceDescription.Size = new System.Drawing.Size(295, 21);
            this.txtConfigDeviceDescription.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(7, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 12);
            this.label14.TabIndex = 21;
            this.label14.Text = "设备描述：";
            // 
            // ComponentDefine
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 326);
            this.Controls.Add(this.panlDevice);
            this.Controls.Add(this.panlSocket);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbNote);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComponentDefine";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "组件定义";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComponentDefine_FormClosing);
            this.Load += new System.EventHandler(this.ComponentDefine_Load);
            this.Shown += new System.EventHandler(this.ComponentDefine_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.socketSpeedTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpeedType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socketLogicTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogicType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socketPhyTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPhyType)).EndInit();
            this.panlSocket.ResumeLayout(false);
            this.panlSocket.PerformLayout();
            this.panlDevice.ResumeLayout(false);
            this.panlDevice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venderInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsManufactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeviceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componetTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbConfigSocketSpeed;
        private System.Windows.Forms.ComboBox cmbConfigSocketLogicType;
        private System.Windows.Forms.ComboBox cmbConfigSocketPhyType;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private dsPhyType dsPhyType;
        private System.Windows.Forms.BindingSource socketPhyTypeBindingSource;
        private dsPhyTypeTableAdapters.SocketPhyTypeTableAdapter socketPhyTypeTableAdapter;
        private dsLogicType dsLogicType;
        private System.Windows.Forms.BindingSource socketLogicTypeBindingSource;
        private dsLogicTypeTableAdapters.SocketLogicTypeTableAdapter socketLogicTypeTableAdapter;
        private dsSpeedType dsSpeedType;
        private System.Windows.Forms.BindingSource socketSpeedTypeBindingSource;
        private dsSpeedTypeTableAdapters.SocketSpeedTypeTableAdapter socketSpeedTypeTableAdapter;
        private System.Windows.Forms.Panel panlSocket;
        private System.Windows.Forms.Panel panlDevice;
        private System.Windows.Forms.ComboBox cmbConfigDeviceType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbConfigManufactory;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbConfigVender;
        private System.Windows.Forms.Label label17;
        private dsManufactory dsManufactory;
        private System.Windows.Forms.BindingSource manufactoryBindingSource;
        private dsManufactoryTableAdapters.ManufactoryTableAdapter manufactoryTableAdapter;
        private dsVender dsVender;
        private System.Windows.Forms.BindingSource venderInfoBindingSource;
        private dsVenderTableAdapters.VenderInfoTableAdapter venderInfoTableAdapter;
        private System.Windows.Forms.ComboBox cmbConfigModule;
        private System.Windows.Forms.TextBox txtConfigModule;
        private System.Windows.Forms.Label label8;
        private dsDeviceType dsDeviceType;
        private dsDeviceTypeTableAdapters.DeviceTypeTableAdapter deviceTypeTableAdapter;
        private System.Windows.Forms.BindingSource deviceTypeBindingSource;
        private dsDeviceTypeTableAdapters.ComponetTypeTableAdapter componetTypeTableAdapter;
        private System.Windows.Forms.BindingSource componetTypeBindingSource;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtConfigSocketDescription;
        private System.Windows.Forms.TextBox txtConfigDeviceDescription;
        private System.Windows.Forms.Label label14;
    }
}