namespace ITInventory
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加设备ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加接口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除设备ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.从模版导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑模版ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新获取配置数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabAll = new System.Windows.Forms.TabControl();
            this.tabFindDevice = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.listDevices = new System.Windows.Forms.ListBox();
            this.trvwDevice = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gdvwDeviceInfo = new System.Windows.Forms.DataGridView();
            this.getModulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDeviceInfo = new ITInventory.dsDeviceInfo();
            this.contMenuGdvw = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制内容ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gdvwSocketInfo = new System.Windows.Forms.DataGridView();
            this.getSocketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSocketInfo = new ITInventory.dsSocketInfo();
            this.groupFindDevice = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbDeviceType = new System.Windows.Forms.ComboBox();
            this.deviceTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDeviceType = new ITInventory.dsDeviceType();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbManufactory = new System.Windows.Forms.ComboBox();
            this.manufactoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsManufactory = new ITInventory.dsManufactory();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbVender = new System.Windows.Forms.ComboBox();
            this.venderInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsVender = new ITInventory.dsVender();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.iPv4Start = new CommonClass.IPv4Address();
            this.iPv4End = new CommonClass.IPv4Address();
            this.label30 = new System.Windows.Forms.Label();
            this.chkIP = new System.Windows.Forms.CheckBox();
            this.txtDeviceDescrip = new System.Windows.Forms.TextBox();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.chkEnableDate = new System.Windows.Forms.CheckBox();
            this.btnListDevice = new System.Windows.Forms.Button();
            this.dtpkWarrantyDate = new System.Windows.Forms.DateTimePicker();
            this.label31 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panlWarrantyDate = new System.Windows.Forms.Panel();
            this.rdoWarrantyOut = new System.Windows.Forms.RadioButton();
            this.rdoWarrantyIn = new System.Windows.Forms.RadioButton();
            this.panlDeivceModule = new System.Windows.Forms.Panel();
            this.rdoModuleFuzzy = new System.Windows.Forms.RadioButton();
            this.rdoModulePrecise = new System.Windows.Forms.RadioButton();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.panlDeviceName = new System.Windows.Forms.Panel();
            this.rdoNameFuzzy = new System.Windows.Forms.RadioButton();
            this.rdoNamePrecise = new System.Windows.Forms.RadioButton();
            this.txtDeviceModule = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabDefineDevice = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvwConfigDevice = new System.Windows.Forms.TreeView();
            this.trvwTempletes = new System.Windows.Forms.TreeView();
            this.btnSaveDevice2File = new System.Windows.Forms.Button();
            this.btnSaveCurrentDevice = new System.Windows.Forms.Button();
            this.btnSaveAllDevice = new System.Windows.Forms.Button();
            this.groupConfigSocket = new System.Windows.Forms.GroupBox();
            this.chkAddrInfo = new System.Windows.Forms.CheckBox();
            this.ipv4Mask = new CommonClass.IPv4Mask();
            this.ipv4Address = new CommonClass.IPv4Address();
            this.btnResetSocketConfig = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtConfigSocketName = new System.Windows.Forms.TextBox();
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
            this.txtConfigSocketDescription = new System.Windows.Forms.TextBox();
            this.groupConfigDevice = new System.Windows.Forms.GroupBox();
            this.txtConfigWarranty = new System.Windows.Forms.MaskedTextBox();
            this.chkConfigPurchaseDate = new System.Windows.Forms.CheckBox();
            this.btnResetDeviceConfig = new System.Windows.Forms.Button();
            this.dtpkConfigPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.cmbConfigArea = new System.Windows.Forms.ComboBox();
            this.cmbConfigVender = new System.Windows.Forms.ComboBox();
            this.cmbConfigManufactory = new System.Windows.Forms.ComboBox();
            this.cmbConfigModule = new System.Windows.Forms.ComboBox();
            this.cmbConfigRole = new System.Windows.Forms.ComboBox();
            this.cmbConfigDeviceType = new System.Windows.Forms.ComboBox();
            this.deviceTypeAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDeviceTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbConfigLocation = new System.Windows.Forms.ComboBox();
            this.cmbConfigCity = new System.Windows.Forms.ComboBox();
            this.txtConfigDeviceDescription = new System.Windows.Forms.TextBox();
            this.txtConfigModule = new System.Windows.Forms.TextBox();
            this.txtConfigQuickService = new System.Windows.Forms.TextBox();
            this.txtConfigDeviceSN = new System.Windows.Forms.TextBox();
            this.txtConfigDeviceName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeleteDevice = new System.Windows.Forms.Button();
            this.btnAddSocket = new System.Windows.Forms.Button();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.tabDeviceTopo = new System.Windows.Forms.TabPage();
            this.contMenuTrvwDevice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.在设备定义中编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新设备信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.tlstrplbDeviceCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlstrplbDBServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.deviceTypeTableAdapter = new ITInventory.dsDeviceTypeTableAdapters.DeviceTypeTableAdapter();
            this.manufactoryTableAdapter = new ITInventory.dsManufactoryTableAdapters.ManufactoryTableAdapter();
            this.venderInfoTableAdapter = new ITInventory.dsVenderTableAdapters.VenderInfoTableAdapter();
            this.getModulesTableAdapter = new ITInventory.dsDeviceInfoTableAdapters.GetModulesTableAdapter();
            this.socketPhyTypeTableAdapter = new ITInventory.dsPhyTypeTableAdapters.SocketPhyTypeTableAdapter();
            this.socketLogicTypeTableAdapter = new ITInventory.dsLogicTypeTableAdapters.SocketLogicTypeTableAdapter();
            this.socketSpeedTypeTableAdapter = new ITInventory.dsSpeedTypeTableAdapters.SocketSpeedTypeTableAdapter();
            this.getSocketsTableAdapter = new ITInventory.dsSocketInfoTableAdapters.GetSocketsTableAdapter();
            this.opfDialog = new System.Windows.Forms.OpenFileDialog();
            this.contMenuTrvwTemplete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.从该模版导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fsTempleteWatcher = new System.IO.FileSystemWatcher();
            this.contMenuTrvwConfigDevice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.清除该设备ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除全部设备ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeExpandCountDown = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.deviceTypeAllTableAdapter = new ITInventory.dsDeviceTypeTableAdapters.DeviceTypeAllTableAdapter();
            this.device_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_module = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_quick_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vender_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_purchase_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_warranty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufactory_alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socket_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socket_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socket_ipv4_addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socket_ipv4_mask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socket_ipv4_gw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socket_ipv4_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socket_speed_type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socket_phy_type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socket_logic_type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuMain.SuspendLayout();
            this.tabAll.SuspendLayout();
            this.tabFindDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvwDeviceInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getModulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeviceInfo)).BeginInit();
            this.contMenuGdvw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvwSocketInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSocketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSocketInfo)).BeginInit();
            this.groupFindDevice.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeviceType)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manufactoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsManufactory)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venderInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVender)).BeginInit();
            this.panel4.SuspendLayout();
            this.panlWarrantyDate.SuspendLayout();
            this.panlDeivceModule.SuspendLayout();
            this.panlDeviceName.SuspendLayout();
            this.tabDefineDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupConfigSocket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.socketSpeedTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpeedType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socketLogicTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogicType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socketPhyTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPhyType)).BeginInit();
            this.groupConfigDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTypeAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeviceTypeBindingSource)).BeginInit();
            this.contMenuTrvwDevice.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.contMenuTrvwTemplete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fsTempleteWatcher)).BeginInit();
            this.contMenuTrvwConfigDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1100, 25);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加设备ToolStripMenuItem,
            this.添加接口ToolStripMenuItem,
            this.删除设备ToolStripMenuItem,
            this.toolStripSeparator1,
            this.从模版导入ToolStripMenuItem,
            this.编辑模版ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Enabled = false;
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.编辑ToolStripMenuItem.Text = "设备配置";
            // 
            // 添加设备ToolStripMenuItem
            // 
            this.添加设备ToolStripMenuItem.Name = "添加设备ToolStripMenuItem";
            this.添加设备ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加设备ToolStripMenuItem.Text = "添加设备";
            this.添加设备ToolStripMenuItem.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // 添加接口ToolStripMenuItem
            // 
            this.添加接口ToolStripMenuItem.Enabled = false;
            this.添加接口ToolStripMenuItem.Name = "添加接口ToolStripMenuItem";
            this.添加接口ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加接口ToolStripMenuItem.Text = "添加接口";
            this.添加接口ToolStripMenuItem.Click += new System.EventHandler(this.btnAddSocket_Click);
            // 
            // 删除设备ToolStripMenuItem
            // 
            this.删除设备ToolStripMenuItem.Enabled = false;
            this.删除设备ToolStripMenuItem.Name = "删除设备ToolStripMenuItem";
            this.删除设备ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除设备ToolStripMenuItem.Text = "删除设备";
            this.删除设备ToolStripMenuItem.Click += new System.EventHandler(this.btnDeleteDevice_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // 从模版导入ToolStripMenuItem
            // 
            this.从模版导入ToolStripMenuItem.Name = "从模版导入ToolStripMenuItem";
            this.从模版导入ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.从模版导入ToolStripMenuItem.Text = "导入模版";
            this.从模版导入ToolStripMenuItem.Click += new System.EventHandler(this.导入模版ToolStripMenuItem_Click);
            // 
            // 编辑模版ToolStripMenuItem
            // 
            this.编辑模版ToolStripMenuItem.Name = "编辑模版ToolStripMenuItem";
            this.编辑模版ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.编辑模版ToolStripMenuItem.Text = "编辑模版";
            this.编辑模版ToolStripMenuItem.Click += new System.EventHandler(this.编辑模版ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据库配置ToolStripMenuItem,
            this.重新获取配置数据ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.设置ToolStripMenuItem.Text = "数据库配置";
            // 
            // 数据库配置ToolStripMenuItem
            // 
            this.数据库配置ToolStripMenuItem.Enabled = false;
            this.数据库配置ToolStripMenuItem.Name = "数据库配置ToolStripMenuItem";
            this.数据库配置ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.数据库配置ToolStripMenuItem.Text = "数据库连接配置";
            // 
            // 重新获取配置数据ToolStripMenuItem
            // 
            this.重新获取配置数据ToolStripMenuItem.Name = "重新获取配置数据ToolStripMenuItem";
            this.重新获取配置数据ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.重新获取配置数据ToolStripMenuItem.Text = "重新获取配置数据";
            this.重新获取配置数据ToolStripMenuItem.Click += new System.EventHandler(this.重新获取配置数据ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem1,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 帮助ToolStripMenuItem1
            // 
            this.帮助ToolStripMenuItem1.Enabled = false;
            this.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1";
            this.帮助ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.帮助ToolStripMenuItem1.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Enabled = false;
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // tabAll
            // 
            this.tabAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabAll.Controls.Add(this.tabFindDevice);
            this.tabAll.Controls.Add(this.tabDefineDevice);
            this.tabAll.Controls.Add(this.tabDeviceTopo);
            this.tabAll.Location = new System.Drawing.Point(12, 28);
            this.tabAll.Name = "tabAll";
            this.tabAll.SelectedIndex = 0;
            this.tabAll.Size = new System.Drawing.Size(1076, 634);
            this.tabAll.TabIndex = 1;
            this.tabAll.SelectedIndexChanged += new System.EventHandler(this.tabAll_SelectedIndexChanged);
            // 
            // tabFindDevice
            // 
            this.tabFindDevice.Controls.Add(this.splitContainer4);
            this.tabFindDevice.Controls.Add(this.groupFindDevice);
            this.tabFindDevice.Location = new System.Drawing.Point(4, 22);
            this.tabFindDevice.Name = "tabFindDevice";
            this.tabFindDevice.Padding = new System.Windows.Forms.Padding(3);
            this.tabFindDevice.Size = new System.Drawing.Size(1068, 608);
            this.tabFindDevice.TabIndex = 2;
            this.tabFindDevice.Text = "设备查询";
            this.tabFindDevice.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer4.Location = new System.Drawing.Point(6, 145);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer4.Size = new System.Drawing.Size(1056, 460);
            this.splitContainer4.SplitterDistance = 295;
            this.splitContainer4.TabIndex = 17;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.listDevices);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.trvwDevice);
            this.splitContainer3.Size = new System.Drawing.Size(295, 460);
            this.splitContainer3.SplitterDistance = 134;
            this.splitContainer3.TabIndex = 4;
            // 
            // listDevices
            // 
            this.listDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDevices.HorizontalScrollbar = true;
            this.listDevices.IntegralHeight = false;
            this.listDevices.ItemHeight = 12;
            this.listDevices.Location = new System.Drawing.Point(0, 0);
            this.listDevices.Name = "listDevices";
            this.listDevices.Size = new System.Drawing.Size(134, 460);
            this.listDevices.TabIndex = 18;
            this.listDevices.SelectedIndexChanged += new System.EventHandler(this.listDevices_SelectedIndexChanged);
            this.listDevices.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listDevices_MouseDown);
            // 
            // trvwDevice
            // 
            this.trvwDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvwDevice.Location = new System.Drawing.Point(0, 0);
            this.trvwDevice.Name = "trvwDevice";
            this.trvwDevice.Size = new System.Drawing.Size(157, 460);
            this.trvwDevice.TabIndex = 19;
            this.trvwDevice.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvwDevice_AfterSelect);
            this.trvwDevice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trvwDevice_MouseDown);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gdvwDeviceInfo);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gdvwSocketInfo);
            this.splitContainer2.Size = new System.Drawing.Size(757, 460);
            this.splitContainer2.SplitterDistance = 211;
            this.splitContainer2.TabIndex = 16;
            // 
            // gdvwDeviceInfo
            // 
            this.gdvwDeviceInfo.AllowUserToAddRows = false;
            this.gdvwDeviceInfo.AllowUserToDeleteRows = false;
            this.gdvwDeviceInfo.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvwDeviceInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvwDeviceInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvwDeviceInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.device_name,
            this.device_module,
            this.device_sn,
            this.device_quick_service,
            this.device_description,
            this.device_type_name,
            this.vender_name,
            this.device_purchase_date,
            this.device_warranty,
            this.device_end_date,
            this.manufactory_alias});
            this.gdvwDeviceInfo.DataSource = this.getModulesBindingSource;
            this.gdvwDeviceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvwDeviceInfo.Location = new System.Drawing.Point(0, 0);
            this.gdvwDeviceInfo.Name = "gdvwDeviceInfo";
            this.gdvwDeviceInfo.ReadOnly = true;
            this.gdvwDeviceInfo.RowHeadersWidth = 20;
            this.gdvwDeviceInfo.RowTemplate.ContextMenuStrip = this.contMenuGdvw;
            this.gdvwDeviceInfo.RowTemplate.Height = 23;
            this.gdvwDeviceInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvwDeviceInfo.Size = new System.Drawing.Size(757, 211);
            this.gdvwDeviceInfo.TabIndex = 20;
            this.gdvwDeviceInfo.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gdvwCellMouseDown);
            // 
            // getModulesBindingSource
            // 
            this.getModulesBindingSource.DataMember = "GetModules";
            this.getModulesBindingSource.DataSource = this.dsDeviceInfo;
            // 
            // dsDeviceInfo
            // 
            this.dsDeviceInfo.DataSetName = "dsDeviceInfo";
            this.dsDeviceInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contMenuGdvw
            // 
            this.contMenuGdvw.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制内容ToolStripMenuItem});
            this.contMenuGdvw.Name = "contMenuGdvw";
            this.contMenuGdvw.Size = new System.Drawing.Size(125, 26);
            // 
            // 复制内容ToolStripMenuItem
            // 
            this.复制内容ToolStripMenuItem.Name = "复制内容ToolStripMenuItem";
            this.复制内容ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.复制内容ToolStripMenuItem.Text = "复制内容";
            this.复制内容ToolStripMenuItem.Click += new System.EventHandler(this.复制内容ToolStripMenuItem_Click);
            // 
            // gdvwSocketInfo
            // 
            this.gdvwSocketInfo.AllowUserToAddRows = false;
            this.gdvwSocketInfo.AllowUserToDeleteRows = false;
            this.gdvwSocketInfo.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvwSocketInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdvwSocketInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvwSocketInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.socket_name,
            this.socket_description,
            this.socket_ipv4_addr,
            this.socket_ipv4_mask,
            this.socket_ipv4_gw,
            this.socket_ipv4_description,
            this.socket_speed_type_name,
            this.socket_phy_type_name,
            this.socket_logic_type_name});
            this.gdvwSocketInfo.DataSource = this.getSocketsBindingSource;
            this.gdvwSocketInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvwSocketInfo.Location = new System.Drawing.Point(0, 0);
            this.gdvwSocketInfo.Name = "gdvwSocketInfo";
            this.gdvwSocketInfo.ReadOnly = true;
            this.gdvwSocketInfo.RowHeadersWidth = 20;
            this.gdvwSocketInfo.RowTemplate.ContextMenuStrip = this.contMenuGdvw;
            this.gdvwSocketInfo.RowTemplate.Height = 23;
            this.gdvwSocketInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvwSocketInfo.Size = new System.Drawing.Size(757, 245);
            this.gdvwSocketInfo.TabIndex = 21;
            this.gdvwSocketInfo.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gdvwCellMouseDown);
            this.gdvwSocketInfo.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gdvwSocketInfo_DataBindingComplete);
            // 
            // getSocketsBindingSource
            // 
            this.getSocketsBindingSource.DataMember = "GetSockets";
            this.getSocketsBindingSource.DataSource = this.dsSocketInfo;
            // 
            // dsSocketInfo
            // 
            this.dsSocketInfo.DataSetName = "dsSocketInfo";
            this.dsSocketInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupFindDevice
            // 
            this.groupFindDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFindDevice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupFindDevice.Controls.Add(this.flowLayoutPanel1);
            this.groupFindDevice.Controls.Add(this.txtDeviceDescrip);
            this.groupFindDevice.Controls.Add(this.btnAdvance);
            this.groupFindDevice.Controls.Add(this.btnResetFilter);
            this.groupFindDevice.Controls.Add(this.chkEnableDate);
            this.groupFindDevice.Controls.Add(this.btnListDevice);
            this.groupFindDevice.Controls.Add(this.dtpkWarrantyDate);
            this.groupFindDevice.Controls.Add(this.label31);
            this.groupFindDevice.Controls.Add(this.label1);
            this.groupFindDevice.Controls.Add(this.panlWarrantyDate);
            this.groupFindDevice.Controls.Add(this.panlDeivceModule);
            this.groupFindDevice.Controls.Add(this.txtDeviceName);
            this.groupFindDevice.Controls.Add(this.panlDeviceName);
            this.groupFindDevice.Controls.Add(this.txtDeviceModule);
            this.groupFindDevice.Controls.Add(this.label4);
            this.groupFindDevice.Controls.Add(this.label2);
            this.groupFindDevice.Location = new System.Drawing.Point(6, 6);
            this.groupFindDevice.Name = "groupFindDevice";
            this.groupFindDevice.Size = new System.Drawing.Size(1056, 133);
            this.groupFindDevice.TabIndex = 6;
            this.groupFindDevice.TabStop = false;
            this.groupFindDevice.Text = "查询条件";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 68);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(853, 66);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.cmbDeviceType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 26);
            this.panel1.TabIndex = 12;
            // 
            // cmbDeviceType
            // 
            this.cmbDeviceType.DataSource = this.deviceTypeBindingSource;
            this.cmbDeviceType.DisplayMember = "device_type_description";
            this.cmbDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeviceType.FormattingEnabled = true;
            this.cmbDeviceType.Location = new System.Drawing.Point(75, 3);
            this.cmbDeviceType.Name = "cmbDeviceType";
            this.cmbDeviceType.Size = new System.Drawing.Size(133, 20);
            this.cmbDeviceType.TabIndex = 9;
            this.cmbDeviceType.ValueMember = "device_type_id";
            // 
            // deviceTypeBindingSource
            // 
            this.deviceTypeBindingSource.DataMember = "DeviceType";
            this.deviceTypeBindingSource.DataSource = this.dsDeviceType;
            // 
            // dsDeviceType
            // 
            this.dsDeviceType.DataSetName = "dsDeviceType";
            this.dsDeviceType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "设备类型：";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbManufactory);
            this.panel2.Location = new System.Drawing.Point(220, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 26);
            this.panel2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "设备厂商：";
            // 
            // cmbManufactory
            // 
            this.cmbManufactory.DataSource = this.manufactoryBindingSource;
            this.cmbManufactory.DisplayMember = "manufactory_alias";
            this.cmbManufactory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbManufactory.FormattingEnabled = true;
            this.cmbManufactory.Location = new System.Drawing.Point(79, 3);
            this.cmbManufactory.Name = "cmbManufactory";
            this.cmbManufactory.Size = new System.Drawing.Size(133, 20);
            this.cmbManufactory.TabIndex = 10;
            this.cmbManufactory.ValueMember = "manufactory_id";
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
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cmbVender);
            this.panel3.Location = new System.Drawing.Point(441, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(409, 26);
            this.panel3.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "供 应 商：";
            // 
            // cmbVender
            // 
            this.cmbVender.DataSource = this.venderInfoBindingSource;
            this.cmbVender.DisplayMember = "vender_name";
            this.cmbVender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVender.FormattingEnabled = true;
            this.cmbVender.Location = new System.Drawing.Point(79, 3);
            this.cmbVender.Name = "cmbVender";
            this.cmbVender.Size = new System.Drawing.Size(327, 20);
            this.cmbVender.TabIndex = 11;
            this.cmbVender.ValueMember = "vender_id";
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
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.label29);
            this.panel4.Controls.Add(this.iPv4Start);
            this.panel4.Controls.Add(this.iPv4End);
            this.panel4.Controls.Add(this.label30);
            this.panel4.Controls.Add(this.chkIP);
            this.panel4.Location = new System.Drawing.Point(3, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(454, 28);
            this.panel4.TabIndex = 20;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.Location = new System.Drawing.Point(3, 8);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(70, 12);
            this.label29.TabIndex = 17;
            this.label29.Text = "地址范围：";
            // 
            // iPv4Start
            // 
            this.iPv4Start.Enabled = false;
            this.iPv4Start.Location = new System.Drawing.Point(76, 4);
            this.iPv4Start.Name = "iPv4Start";
            this.iPv4Start.Size = new System.Drawing.Size(164, 21);
            this.iPv4Start.TabIndex = 13;
            // 
            // iPv4End
            // 
            this.iPv4End.Enabled = false;
            this.iPv4End.Location = new System.Drawing.Point(266, 4);
            this.iPv4End.Name = "iPv4End";
            this.iPv4End.Size = new System.Drawing.Size(164, 21);
            this.iPv4End.TabIndex = 14;
            this.iPv4End.Enter += new System.EventHandler(this.iPv4End_Enter);
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.Location = new System.Drawing.Point(246, 7);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(17, 16);
            this.label30.TabIndex = 18;
            this.label30.Text = "~";
            // 
            // chkIP
            // 
            this.chkIP.AutoSize = true;
            this.chkIP.Location = new System.Drawing.Point(436, 7);
            this.chkIP.Name = "chkIP";
            this.chkIP.Size = new System.Drawing.Size(15, 14);
            this.chkIP.TabIndex = 12;
            this.chkIP.UseVisualStyleBackColor = true;
            this.chkIP.CheckedChanged += new System.EventHandler(this.chkIP_CheckedChanged);
            // 
            // txtDeviceDescrip
            // 
            this.txtDeviceDescrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeviceDescrip.Location = new System.Drawing.Point(632, 17);
            this.txtDeviceDescrip.Name = "txtDeviceDescrip";
            this.txtDeviceDescrip.Size = new System.Drawing.Size(407, 21);
            this.txtDeviceDescrip.TabIndex = 5;
            // 
            // btnAdvance
            // 
            this.btnAdvance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdvance.Enabled = false;
            this.btnAdvance.Location = new System.Drawing.Point(958, 101);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(81, 23);
            this.btnAdvance.TabIndex = 17;
            this.btnAdvance.Text = "高级查询";
            this.btnAdvance.UseVisualStyleBackColor = true;
            this.btnAdvance.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetFilter.Location = new System.Drawing.Point(958, 72);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(81, 23);
            this.btnResetFilter.TabIndex = 16;
            this.btnResetFilter.Text = "重置";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // chkEnableDate
            // 
            this.chkEnableDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEnableDate.AutoSize = true;
            this.chkEnableDate.Location = new System.Drawing.Point(860, 49);
            this.chkEnableDate.Name = "chkEnableDate";
            this.chkEnableDate.Size = new System.Drawing.Size(15, 14);
            this.chkEnableDate.TabIndex = 6;
            this.chkEnableDate.UseVisualStyleBackColor = true;
            this.chkEnableDate.CheckedChanged += new System.EventHandler(this.chkEnableDate_CheckedChanged);
            // 
            // btnListDevice
            // 
            this.btnListDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListDevice.Font = new System.Drawing.Font("微软雅黑", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnListDevice.Location = new System.Drawing.Point(869, 72);
            this.btnListDevice.Name = "btnListDevice";
            this.btnListDevice.Size = new System.Drawing.Size(81, 52);
            this.btnListDevice.TabIndex = 15;
            this.btnListDevice.Text = "查询";
            this.btnListDevice.UseVisualStyleBackColor = true;
            this.btnListDevice.Click += new System.EventHandler(this.btnListDevice_Click);
            // 
            // dtpkWarrantyDate
            // 
            this.dtpkWarrantyDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpkWarrantyDate.Enabled = false;
            this.dtpkWarrantyDate.Location = new System.Drawing.Point(632, 46);
            this.dtpkWarrantyDate.Name = "dtpkWarrantyDate";
            this.dtpkWarrantyDate.Size = new System.Drawing.Size(221, 21);
            this.dtpkWarrantyDate.TabIndex = 7;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label31.Location = new System.Drawing.Point(555, 21);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(70, 12);
            this.label31.TabIndex = 1;
            this.label31.Text = "设备描述：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "设备名称：";
            // 
            // panlWarrantyDate
            // 
            this.panlWarrantyDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panlWarrantyDate.Controls.Add(this.rdoWarrantyOut);
            this.panlWarrantyDate.Controls.Add(this.rdoWarrantyIn);
            this.panlWarrantyDate.Enabled = false;
            this.panlWarrantyDate.Location = new System.Drawing.Point(879, 46);
            this.panlWarrantyDate.Name = "panlWarrantyDate";
            this.panlWarrantyDate.Size = new System.Drawing.Size(160, 21);
            this.panlWarrantyDate.TabIndex = 8;
            // 
            // rdoWarrantyOut
            // 
            this.rdoWarrantyOut.AutoSize = true;
            this.rdoWarrantyOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.rdoWarrantyOut.Location = new System.Drawing.Point(89, 0);
            this.rdoWarrantyOut.Name = "rdoWarrantyOut";
            this.rdoWarrantyOut.Size = new System.Drawing.Size(71, 21);
            this.rdoWarrantyOut.TabIndex = 2;
            this.rdoWarrantyOut.Text = "保修到期";
            this.rdoWarrantyOut.UseVisualStyleBackColor = true;
            // 
            // rdoWarrantyIn
            // 
            this.rdoWarrantyIn.AutoSize = true;
            this.rdoWarrantyIn.Checked = true;
            this.rdoWarrantyIn.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoWarrantyIn.Location = new System.Drawing.Point(0, 0);
            this.rdoWarrantyIn.Name = "rdoWarrantyIn";
            this.rdoWarrantyIn.Size = new System.Drawing.Size(71, 21);
            this.rdoWarrantyIn.TabIndex = 1;
            this.rdoWarrantyIn.TabStop = true;
            this.rdoWarrantyIn.Text = "保修期内";
            this.rdoWarrantyIn.UseVisualStyleBackColor = true;
            // 
            // panlDeivceModule
            // 
            this.panlDeivceModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panlDeivceModule.Controls.Add(this.rdoModuleFuzzy);
            this.panlDeivceModule.Controls.Add(this.rdoModulePrecise);
            this.panlDeivceModule.Location = new System.Drawing.Point(389, 46);
            this.panlDeivceModule.Name = "panlDeivceModule";
            this.panlDeivceModule.Size = new System.Drawing.Size(160, 21);
            this.panlDeivceModule.TabIndex = 4;
            // 
            // rdoModuleFuzzy
            // 
            this.rdoModuleFuzzy.AutoSize = true;
            this.rdoModuleFuzzy.Checked = true;
            this.rdoModuleFuzzy.Dock = System.Windows.Forms.DockStyle.Right;
            this.rdoModuleFuzzy.Location = new System.Drawing.Point(89, 0);
            this.rdoModuleFuzzy.Name = "rdoModuleFuzzy";
            this.rdoModuleFuzzy.Size = new System.Drawing.Size(71, 21);
            this.rdoModuleFuzzy.TabIndex = 1;
            this.rdoModuleFuzzy.TabStop = true;
            this.rdoModuleFuzzy.Text = "模糊匹配";
            this.rdoModuleFuzzy.UseVisualStyleBackColor = true;
            // 
            // rdoModulePrecise
            // 
            this.rdoModulePrecise.AutoSize = true;
            this.rdoModulePrecise.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoModulePrecise.Location = new System.Drawing.Point(0, 0);
            this.rdoModulePrecise.Name = "rdoModulePrecise";
            this.rdoModulePrecise.Size = new System.Drawing.Size(71, 21);
            this.rdoModulePrecise.TabIndex = 2;
            this.rdoModulePrecise.Text = "精确匹配";
            this.rdoModulePrecise.UseVisualStyleBackColor = true;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(77, 17);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(299, 21);
            this.txtDeviceName.TabIndex = 1;
            // 
            // panlDeviceName
            // 
            this.panlDeviceName.Controls.Add(this.rdoNameFuzzy);
            this.panlDeviceName.Controls.Add(this.rdoNamePrecise);
            this.panlDeviceName.Location = new System.Drawing.Point(389, 17);
            this.panlDeviceName.Name = "panlDeviceName";
            this.panlDeviceName.Size = new System.Drawing.Size(160, 21);
            this.panlDeviceName.TabIndex = 2;
            // 
            // rdoNameFuzzy
            // 
            this.rdoNameFuzzy.AutoSize = true;
            this.rdoNameFuzzy.Checked = true;
            this.rdoNameFuzzy.Dock = System.Windows.Forms.DockStyle.Right;
            this.rdoNameFuzzy.Location = new System.Drawing.Point(89, 0);
            this.rdoNameFuzzy.Name = "rdoNameFuzzy";
            this.rdoNameFuzzy.Size = new System.Drawing.Size(71, 21);
            this.rdoNameFuzzy.TabIndex = 1;
            this.rdoNameFuzzy.TabStop = true;
            this.rdoNameFuzzy.Text = "模糊匹配";
            this.rdoNameFuzzy.UseVisualStyleBackColor = true;
            // 
            // rdoNamePrecise
            // 
            this.rdoNamePrecise.AutoSize = true;
            this.rdoNamePrecise.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoNamePrecise.Location = new System.Drawing.Point(0, 0);
            this.rdoNamePrecise.Name = "rdoNamePrecise";
            this.rdoNamePrecise.Size = new System.Drawing.Size(71, 21);
            this.rdoNamePrecise.TabIndex = 2;
            this.rdoNamePrecise.Text = "精确匹配";
            this.rdoNamePrecise.UseVisualStyleBackColor = true;
            // 
            // txtDeviceModule
            // 
            this.txtDeviceModule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeviceModule.Location = new System.Drawing.Point(77, 46);
            this.txtDeviceModule.Name = "txtDeviceModule";
            this.txtDeviceModule.Size = new System.Drawing.Size(299, 21);
            this.txtDeviceModule.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(555, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "保修日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "设备型号：";
            // 
            // tabDefineDevice
            // 
            this.tabDefineDevice.Controls.Add(this.splitContainer1);
            this.tabDefineDevice.Controls.Add(this.btnSaveDevice2File);
            this.tabDefineDevice.Controls.Add(this.btnSaveCurrentDevice);
            this.tabDefineDevice.Controls.Add(this.btnSaveAllDevice);
            this.tabDefineDevice.Controls.Add(this.groupConfigSocket);
            this.tabDefineDevice.Controls.Add(this.groupConfigDevice);
            this.tabDefineDevice.Controls.Add(this.btnDeleteDevice);
            this.tabDefineDevice.Controls.Add(this.btnAddSocket);
            this.tabDefineDevice.Controls.Add(this.btnAddDevice);
            this.tabDefineDevice.Location = new System.Drawing.Point(4, 22);
            this.tabDefineDevice.Name = "tabDefineDevice";
            this.tabDefineDevice.Padding = new System.Windows.Forms.Padding(3);
            this.tabDefineDevice.Size = new System.Drawing.Size(1068, 608);
            this.tabDefineDevice.TabIndex = 0;
            this.tabDefineDevice.Text = "设备定义";
            this.tabDefineDevice.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 69);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvwConfigDevice);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.trvwTempletes);
            this.splitContainer1.Size = new System.Drawing.Size(171, 533);
            this.splitContainer1.SplitterDistance = 374;
            this.splitContainer1.TabIndex = 11;
            // 
            // trvwConfigDevice
            // 
            this.trvwConfigDevice.AllowDrop = true;
            this.trvwConfigDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvwConfigDevice.Location = new System.Drawing.Point(0, 0);
            this.trvwConfigDevice.Name = "trvwConfigDevice";
            this.trvwConfigDevice.Size = new System.Drawing.Size(171, 374);
            this.trvwConfigDevice.TabIndex = 3;
            this.trvwConfigDevice.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.trvwConfigDevice_ItemDrag);
            this.trvwConfigDevice.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvwConfigDevice_AfterSelect);
            this.trvwConfigDevice.DragDrop += new System.Windows.Forms.DragEventHandler(this.trvwConfigDevice_DragDrop);
            this.trvwConfigDevice.DragOver += new System.Windows.Forms.DragEventHandler(this.trvwConfigDevice_DragOver);
            this.trvwConfigDevice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trvwConfigDevice_KeyDown);
            this.trvwConfigDevice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trvwConfigDevice_MouseDown);
            // 
            // trvwTempletes
            // 
            this.trvwTempletes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.trvwTempletes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvwTempletes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.trvwTempletes.Location = new System.Drawing.Point(0, 0);
            this.trvwTempletes.Name = "trvwTempletes";
            this.trvwTempletes.Size = new System.Drawing.Size(171, 155);
            this.trvwTempletes.TabIndex = 10;
            this.trvwTempletes.TabStop = false;
            this.trvwTempletes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trvwTempletes_MouseDown);
            // 
            // btnSaveDevice2File
            // 
            this.btnSaveDevice2File.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDevice2File.Enabled = false;
            this.btnSaveDevice2File.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveDevice2File.Location = new System.Drawing.Point(645, 505);
            this.btnSaveDevice2File.Name = "btnSaveDevice2File";
            this.btnSaveDevice2File.Size = new System.Drawing.Size(106, 70);
            this.btnSaveDevice2File.TabIndex = 6;
            this.btnSaveDevice2File.Text = "保存全部设备配置文件";
            this.btnSaveDevice2File.UseVisualStyleBackColor = true;
            this.btnSaveDevice2File.Click += new System.EventHandler(this.btnSaveDevice2File_Click);
            // 
            // btnSaveCurrentDevice
            // 
            this.btnSaveCurrentDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCurrentDevice.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveCurrentDevice.Location = new System.Drawing.Point(788, 505);
            this.btnSaveCurrentDevice.Name = "btnSaveCurrentDevice";
            this.btnSaveCurrentDevice.Size = new System.Drawing.Size(106, 70);
            this.btnSaveCurrentDevice.TabIndex = 6;
            this.btnSaveCurrentDevice.Text = "保存所选设备至数据库";
            this.btnSaveCurrentDevice.UseVisualStyleBackColor = true;
            this.btnSaveCurrentDevice.Click += new System.EventHandler(this.btnSaveCurrentDevice_Click);
            // 
            // btnSaveAllDevice
            // 
            this.btnSaveAllDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAllDevice.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveAllDevice.Location = new System.Drawing.Point(929, 505);
            this.btnSaveAllDevice.Name = "btnSaveAllDevice";
            this.btnSaveAllDevice.Size = new System.Drawing.Size(106, 70);
            this.btnSaveAllDevice.TabIndex = 6;
            this.btnSaveAllDevice.Text = "保存全部设备至数据库";
            this.btnSaveAllDevice.UseVisualStyleBackColor = true;
            this.btnSaveAllDevice.Click += new System.EventHandler(this.btnSaveAllDevice_Click);
            // 
            // groupConfigSocket
            // 
            this.groupConfigSocket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupConfigSocket.Controls.Add(this.chkAddrInfo);
            this.groupConfigSocket.Controls.Add(this.ipv4Mask);
            this.groupConfigSocket.Controls.Add(this.ipv4Address);
            this.groupConfigSocket.Controls.Add(this.btnResetSocketConfig);
            this.groupConfigSocket.Controls.Add(this.label28);
            this.groupConfigSocket.Controls.Add(this.label27);
            this.groupConfigSocket.Controls.Add(this.label26);
            this.groupConfigSocket.Controls.Add(this.label22);
            this.groupConfigSocket.Controls.Add(this.txtConfigSocketName);
            this.groupConfigSocket.Controls.Add(this.cmbConfigSocketSpeed);
            this.groupConfigSocket.Controls.Add(this.cmbConfigSocketLogicType);
            this.groupConfigSocket.Controls.Add(this.cmbConfigSocketPhyType);
            this.groupConfigSocket.Controls.Add(this.label25);
            this.groupConfigSocket.Controls.Add(this.label24);
            this.groupConfigSocket.Controls.Add(this.label23);
            this.groupConfigSocket.Controls.Add(this.txtConfigSocketDescription);
            this.groupConfigSocket.Enabled = false;
            this.groupConfigSocket.Location = new System.Drawing.Point(183, 288);
            this.groupConfigSocket.Name = "groupConfigSocket";
            this.groupConfigSocket.Size = new System.Drawing.Size(863, 175);
            this.groupConfigSocket.TabIndex = 5;
            this.groupConfigSocket.TabStop = false;
            this.groupConfigSocket.Text = "接口详细信息设置";
            this.groupConfigSocket.Leave += new System.EventHandler(this.groupConfigSocket_Leave);
            // 
            // chkAddrInfo
            // 
            this.chkAddrInfo.AutoSize = true;
            this.chkAddrInfo.Location = new System.Drawing.Point(498, 106);
            this.chkAddrInfo.Name = "chkAddrInfo";
            this.chkAddrInfo.Size = new System.Drawing.Size(15, 14);
            this.chkAddrInfo.TabIndex = 6;
            this.chkAddrInfo.UseVisualStyleBackColor = true;
            this.chkAddrInfo.CheckedChanged += new System.EventHandler(this.chkAddrInfo_CheckedChanged);
            // 
            // ipv4Mask
            // 
            this.ipv4Mask.Location = new System.Drawing.Point(325, 102);
            this.ipv4Mask.Name = "ipv4Mask";
            this.ipv4Mask.Size = new System.Drawing.Size(167, 21);
            this.ipv4Mask.TabIndex = 8;
            // 
            // ipv4Address
            // 
            this.ipv4Address.Location = new System.Drawing.Point(88, 102);
            this.ipv4Address.Name = "ipv4Address";
            this.ipv4Address.Size = new System.Drawing.Size(164, 21);
            this.ipv4Address.TabIndex = 7;
            // 
            // btnResetSocketConfig
            // 
            this.btnResetSocketConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetSocketConfig.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnResetSocketConfig.Location = new System.Drawing.Point(778, 138);
            this.btnResetSocketConfig.Name = "btnResetSocketConfig";
            this.btnResetSocketConfig.Size = new System.Drawing.Size(75, 23);
            this.btnResetSocketConfig.TabIndex = 11;
            this.btnResetSocketConfig.Text = "重置";
            this.btnResetSocketConfig.UseVisualStyleBackColor = true;
            this.btnResetSocketConfig.Click += new System.EventHandler(this.btnResetSocketConfig_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.Location = new System.Drawing.Point(258, 107);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(70, 12);
            this.label28.TabIndex = 5;
            this.label28.Text = "子网掩码：";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.Location = new System.Drawing.Point(11, 107);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(70, 12);
            this.label27.TabIndex = 5;
            this.label27.Text = "接口地址：";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.Location = new System.Drawing.Point(11, 79);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(70, 12);
            this.label26.TabIndex = 5;
            this.label26.Text = "接口描述：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(11, 50);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 12);
            this.label22.TabIndex = 1;
            this.label22.Text = "接口名称：";
            // 
            // txtConfigSocketName
            // 
            this.txtConfigSocketName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfigSocketName.Location = new System.Drawing.Point(88, 46);
            this.txtConfigSocketName.MaxLength = 100;
            this.txtConfigSocketName.Name = "txtConfigSocketName";
            this.txtConfigSocketName.Size = new System.Drawing.Size(384, 21);
            this.txtConfigSocketName.TabIndex = 1;
            // 
            // cmbConfigSocketSpeed
            // 
            this.cmbConfigSocketSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbConfigSocketSpeed.DataSource = this.socketSpeedTypeBindingSource;
            this.cmbConfigSocketSpeed.DisplayMember = "socket_speed_type_name";
            this.cmbConfigSocketSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfigSocketSpeed.FormattingEnabled = true;
            this.cmbConfigSocketSpeed.Location = new System.Drawing.Point(734, 46);
            this.cmbConfigSocketSpeed.Name = "cmbConfigSocketSpeed";
            this.cmbConfigSocketSpeed.Size = new System.Drawing.Size(118, 20);
            this.cmbConfigSocketSpeed.TabIndex = 4;
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
            this.cmbConfigSocketLogicType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbConfigSocketLogicType.DataSource = this.socketLogicTypeBindingSource;
            this.cmbConfigSocketLogicType.DisplayMember = "socket_logic_type_name";
            this.cmbConfigSocketLogicType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfigSocketLogicType.FormattingEnabled = true;
            this.cmbConfigSocketLogicType.Location = new System.Drawing.Point(606, 46);
            this.cmbConfigSocketLogicType.Name = "cmbConfigSocketLogicType";
            this.cmbConfigSocketLogicType.Size = new System.Drawing.Size(118, 20);
            this.cmbConfigSocketLogicType.TabIndex = 3;
            this.cmbConfigSocketLogicType.ValueMember = "socket_logic_type_id";
            this.cmbConfigSocketLogicType.DropDownClosed += new System.EventHandler(this.cmbConfigSocketLogicType_DropDownClosed);
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
            this.cmbConfigSocketPhyType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbConfigSocketPhyType.DataSource = this.socketPhyTypeBindingSource;
            this.cmbConfigSocketPhyType.DisplayMember = "socket_phy_type_name";
            this.cmbConfigSocketPhyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfigSocketPhyType.FormattingEnabled = true;
            this.cmbConfigSocketPhyType.Location = new System.Drawing.Point(478, 46);
            this.cmbConfigSocketPhyType.Name = "cmbConfigSocketPhyType";
            this.cmbConfigSocketPhyType.Size = new System.Drawing.Size(118, 20);
            this.cmbConfigSocketPhyType.TabIndex = 2;
            this.cmbConfigSocketPhyType.ValueMember = "socket_phy_type_id";
            this.cmbConfigSocketPhyType.DropDownClosed += new System.EventHandler(this.cmbConfigSocketPhyType_DropDownClosed);
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
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(765, 26);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(57, 12);
            this.label25.TabIndex = 20;
            this.label25.Text = "接口速率";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(624, 26);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 12);
            this.label24.TabIndex = 20;
            this.label24.Text = "逻辑接口类型";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(496, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 12);
            this.label23.TabIndex = 20;
            this.label23.Text = "物理接口类型";
            // 
            // txtConfigSocketDescription
            // 
            this.txtConfigSocketDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfigSocketDescription.Location = new System.Drawing.Point(88, 75);
            this.txtConfigSocketDescription.MaxLength = 500;
            this.txtConfigSocketDescription.Name = "txtConfigSocketDescription";
            this.txtConfigSocketDescription.Size = new System.Drawing.Size(765, 21);
            this.txtConfigSocketDescription.TabIndex = 5;
            // 
            // groupConfigDevice
            // 
            this.groupConfigDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupConfigDevice.Controls.Add(this.txtConfigWarranty);
            this.groupConfigDevice.Controls.Add(this.chkConfigPurchaseDate);
            this.groupConfigDevice.Controls.Add(this.btnResetDeviceConfig);
            this.groupConfigDevice.Controls.Add(this.dtpkConfigPurchaseDate);
            this.groupConfigDevice.Controls.Add(this.cmbConfigArea);
            this.groupConfigDevice.Controls.Add(this.cmbConfigVender);
            this.groupConfigDevice.Controls.Add(this.cmbConfigManufactory);
            this.groupConfigDevice.Controls.Add(this.cmbConfigModule);
            this.groupConfigDevice.Controls.Add(this.cmbConfigRole);
            this.groupConfigDevice.Controls.Add(this.cmbConfigDeviceType);
            this.groupConfigDevice.Controls.Add(this.cmbConfigLocation);
            this.groupConfigDevice.Controls.Add(this.cmbConfigCity);
            this.groupConfigDevice.Controls.Add(this.txtConfigDeviceDescription);
            this.groupConfigDevice.Controls.Add(this.txtConfigModule);
            this.groupConfigDevice.Controls.Add(this.txtConfigQuickService);
            this.groupConfigDevice.Controls.Add(this.txtConfigDeviceSN);
            this.groupConfigDevice.Controls.Add(this.txtConfigDeviceName);
            this.groupConfigDevice.Controls.Add(this.label16);
            this.groupConfigDevice.Controls.Add(this.label20);
            this.groupConfigDevice.Controls.Add(this.label19);
            this.groupConfigDevice.Controls.Add(this.label18);
            this.groupConfigDevice.Controls.Add(this.label17);
            this.groupConfigDevice.Controls.Add(this.label15);
            this.groupConfigDevice.Controls.Add(this.label14);
            this.groupConfigDevice.Controls.Add(this.label21);
            this.groupConfigDevice.Controls.Add(this.label8);
            this.groupConfigDevice.Controls.Add(this.label13);
            this.groupConfigDevice.Controls.Add(this.label12);
            this.groupConfigDevice.Controls.Add(this.label11);
            this.groupConfigDevice.Controls.Add(this.label10);
            this.groupConfigDevice.Controls.Add(this.label9);
            this.groupConfigDevice.Controls.Add(this.label7);
            this.groupConfigDevice.Enabled = false;
            this.groupConfigDevice.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupConfigDevice.Location = new System.Drawing.Point(183, 41);
            this.groupConfigDevice.Name = "groupConfigDevice";
            this.groupConfigDevice.Size = new System.Drawing.Size(863, 241);
            this.groupConfigDevice.TabIndex = 4;
            this.groupConfigDevice.TabStop = false;
            this.groupConfigDevice.Text = "设备/组件 详细信息设置";
            this.groupConfigDevice.Leave += new System.EventHandler(this.groupConfigDevice_Leave);
            // 
            // txtConfigWarranty
            // 
            this.txtConfigWarranty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfigWarranty.Location = new System.Drawing.Point(810, 164);
            this.txtConfigWarranty.Mask = "9";
            this.txtConfigWarranty.Name = "txtConfigWarranty";
            this.txtConfigWarranty.Size = new System.Drawing.Size(19, 21);
            this.txtConfigWarranty.TabIndex = 21;
            this.txtConfigWarranty.Text = "3";
            // 
            // chkConfigPurchaseDate
            // 
            this.chkConfigPurchaseDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkConfigPurchaseDate.AutoSize = true;
            this.chkConfigPurchaseDate.Location = new System.Drawing.Point(727, 167);
            this.chkConfigPurchaseDate.Name = "chkConfigPurchaseDate";
            this.chkConfigPurchaseDate.Size = new System.Drawing.Size(15, 14);
            this.chkConfigPurchaseDate.TabIndex = 14;
            this.chkConfigPurchaseDate.UseVisualStyleBackColor = true;
            this.chkConfigPurchaseDate.CheckedChanged += new System.EventHandler(this.chkConfigPurchaseDate_CheckedChanged);
            // 
            // btnResetDeviceConfig
            // 
            this.btnResetDeviceConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetDeviceConfig.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnResetDeviceConfig.Location = new System.Drawing.Point(779, 202);
            this.btnResetDeviceConfig.Name = "btnResetDeviceConfig";
            this.btnResetDeviceConfig.Size = new System.Drawing.Size(75, 23);
            this.btnResetDeviceConfig.TabIndex = 18;
            this.btnResetDeviceConfig.Text = "重置";
            this.btnResetDeviceConfig.UseVisualStyleBackColor = true;
            this.btnResetDeviceConfig.Click += new System.EventHandler(this.btnResetConfig_Click);
            // 
            // dtpkConfigPurchaseDate
            // 
            this.dtpkConfigPurchaseDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpkConfigPurchaseDate.Enabled = false;
            this.dtpkConfigPurchaseDate.Location = new System.Drawing.Point(597, 164);
            this.dtpkConfigPurchaseDate.Name = "dtpkConfigPurchaseDate";
            this.dtpkConfigPurchaseDate.Size = new System.Drawing.Size(124, 21);
            this.dtpkConfigPurchaseDate.TabIndex = 15;
            // 
            // cmbConfigArea
            // 
            this.cmbConfigArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbConfigArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfigArea.Enabled = false;
            this.cmbConfigArea.FormattingEnabled = true;
            this.cmbConfigArea.Location = new System.Drawing.Point(604, 52);
            this.cmbConfigArea.Name = "cmbConfigArea";
            this.cmbConfigArea.Size = new System.Drawing.Size(71, 20);
            this.cmbConfigArea.TabIndex = 4;
            // 
            // cmbConfigVender
            // 
            this.cmbConfigVender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbConfigVender.DataSource = this.venderInfoBindingSource;
            this.cmbConfigVender.DisplayMember = "vender_name";
            this.cmbConfigVender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfigVender.FormattingEnabled = true;
            this.cmbConfigVender.Location = new System.Drawing.Point(88, 164);
            this.cmbConfigVender.Name = "cmbConfigVender";
            this.cmbConfigVender.Size = new System.Drawing.Size(427, 20);
            this.cmbConfigVender.TabIndex = 13;
            this.cmbConfigVender.ValueMember = "vender_id";
            // 
            // cmbConfigManufactory
            // 
            this.cmbConfigManufactory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbConfigManufactory.DataSource = this.manufactoryBindingSource;
            this.cmbConfigManufactory.DisplayMember = "manufactory_alias";
            this.cmbConfigManufactory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfigManufactory.FormattingEnabled = true;
            this.cmbConfigManufactory.Location = new System.Drawing.Point(680, 80);
            this.cmbConfigManufactory.Name = "cmbConfigManufactory";
            this.cmbConfigManufactory.Size = new System.Drawing.Size(173, 20);
            this.cmbConfigManufactory.TabIndex = 9;
            this.cmbConfigManufactory.ValueMember = "manufactory_id";
            // 
            // cmbConfigModule
            // 
            this.cmbConfigModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbConfigModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfigModule.Enabled = false;
            this.cmbConfigModule.FormattingEnabled = true;
            this.cmbConfigModule.Location = new System.Drawing.Point(478, 80);
            this.cmbConfigModule.Name = "cmbConfigModule";
            this.cmbConfigModule.Size = new System.Drawing.Size(120, 20);
            this.cmbConfigModule.TabIndex = 8;
            // 
            // cmbConfigRole
            // 
            this.cmbConfigRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbConfigRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfigRole.Enabled = false;
            this.cmbConfigRole.FormattingEnabled = true;
            this.cmbConfigRole.Location = new System.Drawing.Point(680, 52);
            this.cmbConfigRole.Name = "cmbConfigRole";
            this.cmbConfigRole.Size = new System.Drawing.Size(83, 20);
            this.cmbConfigRole.TabIndex = 5;
            // 
            // cmbConfigDeviceType
            // 
            this.cmbConfigDeviceType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbConfigDeviceType.DataSource = this.deviceTypeAllBindingSource;
            this.cmbConfigDeviceType.DisplayMember = "device_type_name";
            this.cmbConfigDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfigDeviceType.FormattingEnabled = true;
            this.cmbConfigDeviceType.Location = new System.Drawing.Point(770, 52);
            this.cmbConfigDeviceType.Name = "cmbConfigDeviceType";
            this.cmbConfigDeviceType.Size = new System.Drawing.Size(83, 20);
            this.cmbConfigDeviceType.TabIndex = 6;
            this.cmbConfigDeviceType.ValueMember = "device_type_id";
            // 
            // deviceTypeAllBindingSource
            // 
            this.deviceTypeAllBindingSource.DataMember = "DeviceTypeAll";
            this.deviceTypeAllBindingSource.DataSource = this.dsDeviceTypeBindingSource;
            // 
            // dsDeviceTypeBindingSource
            // 
            this.dsDeviceTypeBindingSource.DataSource = this.dsDeviceType;
            this.dsDeviceTypeBindingSource.Position = 0;
            // 
            // cmbConfigLocation
            // 
            this.cmbConfigLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbConfigLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfigLocation.Enabled = false;
            this.cmbConfigLocation.FormattingEnabled = true;
            this.cmbConfigLocation.Location = new System.Drawing.Point(541, 52);
            this.cmbConfigLocation.Name = "cmbConfigLocation";
            this.cmbConfigLocation.Size = new System.Drawing.Size(57, 20);
            this.cmbConfigLocation.TabIndex = 3;
            // 
            // cmbConfigCity
            // 
            this.cmbConfigCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbConfigCity.DisplayMember = "SH,DL,ZZ";
            this.cmbConfigCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfigCity.Enabled = false;
            this.cmbConfigCity.FormattingEnabled = true;
            this.cmbConfigCity.Items.AddRange(new object[] {
            "上海",
            "大连",
            "郑州"});
            this.cmbConfigCity.Location = new System.Drawing.Point(478, 52);
            this.cmbConfigCity.Name = "cmbConfigCity";
            this.cmbConfigCity.Size = new System.Drawing.Size(57, 20);
            this.cmbConfigCity.TabIndex = 2;
            this.cmbConfigCity.ValueMember = "SH,DL,ZZ";
            // 
            // txtConfigDeviceDescription
            // 
            this.txtConfigDeviceDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfigDeviceDescription.Location = new System.Drawing.Point(88, 110);
            this.txtConfigDeviceDescription.MaxLength = 500;
            this.txtConfigDeviceDescription.Name = "txtConfigDeviceDescription";
            this.txtConfigDeviceDescription.Size = new System.Drawing.Size(765, 21);
            this.txtConfigDeviceDescription.TabIndex = 10;
            // 
            // txtConfigModule
            // 
            this.txtConfigModule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfigModule.Location = new System.Drawing.Point(88, 80);
            this.txtConfigModule.MaxLength = 100;
            this.txtConfigModule.Name = "txtConfigModule";
            this.txtConfigModule.Size = new System.Drawing.Size(384, 21);
            this.txtConfigModule.TabIndex = 7;
            // 
            // txtConfigQuickService
            // 
            this.txtConfigQuickService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfigQuickService.Location = new System.Drawing.Point(609, 137);
            this.txtConfigQuickService.MaxLength = 200;
            this.txtConfigQuickService.Name = "txtConfigQuickService";
            this.txtConfigQuickService.Size = new System.Drawing.Size(244, 21);
            this.txtConfigQuickService.TabIndex = 12;
            // 
            // txtConfigDeviceSN
            // 
            this.txtConfigDeviceSN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfigDeviceSN.Location = new System.Drawing.Point(88, 137);
            this.txtConfigDeviceSN.MaxLength = 200;
            this.txtConfigDeviceSN.Name = "txtConfigDeviceSN";
            this.txtConfigDeviceSN.Size = new System.Drawing.Size(427, 21);
            this.txtConfigDeviceSN.TabIndex = 11;
            // 
            // txtConfigDeviceName
            // 
            this.txtConfigDeviceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfigDeviceName.Location = new System.Drawing.Point(88, 52);
            this.txtConfigDeviceName.MaxLength = 100;
            this.txtConfigDeviceName.Name = "txtConfigDeviceName";
            this.txtConfigDeviceName.Size = new System.Drawing.Size(384, 21);
            this.txtConfigDeviceName.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(521, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 12);
            this.label16.TabIndex = 12;
            this.label16.Text = "快速服务号：";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(835, 168);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 12);
            this.label20.TabIndex = 16;
            this.label20.Text = "年";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(747, 167);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 12);
            this.label19.TabIndex = 17;
            this.label19.Text = "保修期：";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(522, 168);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 12);
            this.label18.TabIndex = 14;
            this.label18.Text = "验收日期：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(11, 168);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 12);
            this.label17.TabIndex = 13;
            this.label17.Text = "供 应 商：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(11, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 12);
            this.label15.TabIndex = 11;
            this.label15.Text = "序 列 号：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(11, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 12);
            this.label14.TabIndex = 10;
            this.label14.Text = "设备描述：";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(607, 84);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 12);
            this.label21.TabIndex = 9;
            this.label21.Text = "制造厂商：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(11, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "设备型号：";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(706, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 12);
            this.label13.TabIndex = 11;
            this.label13.Text = "角色";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(783, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 12);
            this.label12.TabIndex = 10;
            this.label12.Text = "设备类型";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(617, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "功能区";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(554, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "位置";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(491, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "地域";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(11, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "设备名称：";
            // 
            // btnDeleteDevice
            // 
            this.btnDeleteDevice.Enabled = false;
            this.btnDeleteDevice.Location = new System.Drawing.Point(6, 40);
            this.btnDeleteDevice.Name = "btnDeleteDevice";
            this.btnDeleteDevice.Size = new System.Drawing.Size(171, 23);
            this.btnDeleteDevice.TabIndex = 8;
            this.btnDeleteDevice.TabStop = false;
            this.btnDeleteDevice.Text = "删除设备";
            this.btnDeleteDevice.UseVisualStyleBackColor = true;
            this.btnDeleteDevice.Click += new System.EventHandler(this.btnDeleteDevice_Click);
            // 
            // btnAddSocket
            // 
            this.btnAddSocket.Enabled = false;
            this.btnAddSocket.Location = new System.Drawing.Point(97, 12);
            this.btnAddSocket.Name = "btnAddSocket";
            this.btnAddSocket.Size = new System.Drawing.Size(80, 23);
            this.btnAddSocket.TabIndex = 2;
            this.btnAddSocket.Text = "添加接口";
            this.btnAddSocket.UseVisualStyleBackColor = true;
            this.btnAddSocket.Click += new System.EventHandler(this.btnAddSocket_Click);
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Location = new System.Drawing.Point(6, 12);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(80, 23);
            this.btnAddDevice.TabIndex = 1;
            this.btnAddDevice.Text = "添加设备";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // tabDeviceTopo
            // 
            this.tabDeviceTopo.Location = new System.Drawing.Point(4, 22);
            this.tabDeviceTopo.Name = "tabDeviceTopo";
            this.tabDeviceTopo.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeviceTopo.Size = new System.Drawing.Size(1068, 608);
            this.tabDeviceTopo.TabIndex = 1;
            this.tabDeviceTopo.Text = "设备拓扑";
            this.tabDeviceTopo.UseVisualStyleBackColor = true;
            // 
            // contMenuTrvwDevice
            // 
            this.contMenuTrvwDevice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.在设备定义中编辑ToolStripMenuItem,
            this.刷新设备信息ToolStripMenuItem});
            this.contMenuTrvwDevice.Name = "contMenuConfigDevice";
            this.contMenuTrvwDevice.Size = new System.Drawing.Size(125, 48);
            // 
            // 在设备定义中编辑ToolStripMenuItem
            // 
            this.在设备定义中编辑ToolStripMenuItem.Name = "在设备定义中编辑ToolStripMenuItem";
            this.在设备定义中编辑ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.在设备定义中编辑ToolStripMenuItem.Text = "编辑设备";
            this.在设备定义中编辑ToolStripMenuItem.Click += new System.EventHandler(this.在设备定义中编辑ToolStripMenuItem_Click);
            // 
            // 刷新设备信息ToolStripMenuItem
            // 
            this.刷新设备信息ToolStripMenuItem.Name = "刷新设备信息ToolStripMenuItem";
            this.刷新设备信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.刷新设备信息ToolStripMenuItem.Text = "刷新设备";
            this.刷新设备信息ToolStripMenuItem.Click += new System.EventHandler(this.刷新设备信息ToolStripMenuItem_Click);
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrplbDeviceCount,
            this.tlstrplbDBServer});
            this.statusMain.Location = new System.Drawing.Point(0, 665);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(1100, 22);
            this.statusMain.TabIndex = 2;
            this.statusMain.Text = "statusStrip1";
            // 
            // tlstrplbDeviceCount
            // 
            this.tlstrplbDeviceCount.Name = "tlstrplbDeviceCount";
            this.tlstrplbDeviceCount.Size = new System.Drawing.Size(135, 17);
            this.tlstrplbDeviceCount.Text = "查询到的设备合计：0台";
            // 
            // tlstrplbDBServer
            // 
            this.tlstrplbDBServer.Name = "tlstrplbDBServer";
            this.tlstrplbDBServer.Size = new System.Drawing.Size(140, 17);
            this.tlstrplbDBServer.Text = "当前连接的服务器地址：";
            // 
            // deviceTypeTableAdapter
            // 
            this.deviceTypeTableAdapter.ClearBeforeFill = true;
            // 
            // manufactoryTableAdapter
            // 
            this.manufactoryTableAdapter.ClearBeforeFill = true;
            // 
            // venderInfoTableAdapter
            // 
            this.venderInfoTableAdapter.ClearBeforeFill = true;
            // 
            // getModulesTableAdapter
            // 
            this.getModulesTableAdapter.ClearBeforeFill = true;
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
            // getSocketsTableAdapter
            // 
            this.getSocketsTableAdapter.ClearBeforeFill = true;
            // 
            // opfDialog
            // 
            this.opfDialog.AutoUpgradeEnabled = false;
            this.opfDialog.DefaultExt = "xml";
            this.opfDialog.FileName = "DeviceTempletes.xml";
            this.opfDialog.Filter = "模版文件|*.xml";
            this.opfDialog.InitialDirectory = ".";
            this.opfDialog.ReadOnlyChecked = true;
            this.opfDialog.RestoreDirectory = true;
            this.opfDialog.Title = "请选择模版文件";
            // 
            // contMenuTrvwTemplete
            // 
            this.contMenuTrvwTemplete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.从该模版导入ToolStripMenuItem});
            this.contMenuTrvwTemplete.Name = "contMenuImportTemplete";
            this.contMenuTrvwTemplete.Size = new System.Drawing.Size(149, 26);
            // 
            // 从该模版导入ToolStripMenuItem
            // 
            this.从该模版导入ToolStripMenuItem.Name = "从该模版导入ToolStripMenuItem";
            this.从该模版导入ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.从该模版导入ToolStripMenuItem.Text = "从该模版导入";
            this.从该模版导入ToolStripMenuItem.Click += new System.EventHandler(this.从该模版导入ToolStripMenuItem_Click);
            // 
            // fsTempleteWatcher
            // 
            this.fsTempleteWatcher.EnableRaisingEvents = true;
            this.fsTempleteWatcher.Filter = "*.xml";
            this.fsTempleteWatcher.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.fsTempleteWatcher.Path = ".";
            this.fsTempleteWatcher.SynchronizingObject = this;
            this.fsTempleteWatcher.Changed += new System.IO.FileSystemEventHandler(this.fsTempleteWatcher_Changed);
            // 
            // contMenuTrvwConfigDevice
            // 
            this.contMenuTrvwConfigDevice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制节点ToolStripMenuItem,
            this.剪切节点ToolStripMenuItem,
            this.粘贴节点ToolStripMenuItem,
            this.toolStripSeparator2,
            this.清除该设备ToolStripMenuItem,
            this.清除全部设备ToolStripMenuItem});
            this.contMenuTrvwConfigDevice.Name = "contMenuStrip1";
            this.contMenuTrvwConfigDevice.Size = new System.Drawing.Size(149, 120);
            // 
            // 复制节点ToolStripMenuItem
            // 
            this.复制节点ToolStripMenuItem.Name = "复制节点ToolStripMenuItem";
            this.复制节点ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.复制节点ToolStripMenuItem.Text = "复制节点";
            this.复制节点ToolStripMenuItem.Click += new System.EventHandler(this.复制节点ToolStripMenuItem_Click);
            // 
            // 剪切节点ToolStripMenuItem
            // 
            this.剪切节点ToolStripMenuItem.Name = "剪切节点ToolStripMenuItem";
            this.剪切节点ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.剪切节点ToolStripMenuItem.Text = "剪切节点";
            this.剪切节点ToolStripMenuItem.Click += new System.EventHandler(this.剪切节点ToolStripMenuItem_Click);
            // 
            // 粘贴节点ToolStripMenuItem
            // 
            this.粘贴节点ToolStripMenuItem.Enabled = false;
            this.粘贴节点ToolStripMenuItem.Name = "粘贴节点ToolStripMenuItem";
            this.粘贴节点ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.粘贴节点ToolStripMenuItem.Text = "粘贴节点";
            this.粘贴节点ToolStripMenuItem.Click += new System.EventHandler(this.粘贴节点ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // 清除该设备ToolStripMenuItem
            // 
            this.清除该设备ToolStripMenuItem.Name = "清除该设备ToolStripMenuItem";
            this.清除该设备ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.清除该设备ToolStripMenuItem.Text = "清除该设备";
            this.清除该设备ToolStripMenuItem.Click += new System.EventHandler(this.清除该设备ToolStripMenuItem_Click);
            // 
            // 清除全部设备ToolStripMenuItem
            // 
            this.清除全部设备ToolStripMenuItem.Name = "清除全部设备ToolStripMenuItem";
            this.清除全部设备ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.清除全部设备ToolStripMenuItem.Text = "清除全部设备";
            this.清除全部设备ToolStripMenuItem.Click += new System.EventHandler(this.清除全部设备ToolStripMenuItem_Click);
            // 
            // timeExpandCountDown
            // 
            this.timeExpandCountDown.Interval = 1000;
            this.timeExpandCountDown.Tick += new System.EventHandler(this.timeExpandCountDown_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // deviceTypeAllTableAdapter
            // 
            this.deviceTypeAllTableAdapter.ClearBeforeFill = true;
            // 
            // device_name
            // 
            this.device_name.DataPropertyName = "device_name";
            this.device_name.HeaderText = "设备名称";
            this.device_name.MinimumWidth = 100;
            this.device_name.Name = "device_name";
            this.device_name.ReadOnly = true;
            this.device_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // device_module
            // 
            this.device_module.DataPropertyName = "device_module";
            this.device_module.HeaderText = "设备型号";
            this.device_module.MinimumWidth = 100;
            this.device_module.Name = "device_module";
            this.device_module.ReadOnly = true;
            this.device_module.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // device_sn
            // 
            this.device_sn.DataPropertyName = "device_sn";
            this.device_sn.HeaderText = "设备序列号";
            this.device_sn.MinimumWidth = 100;
            this.device_sn.Name = "device_sn";
            this.device_sn.ReadOnly = true;
            this.device_sn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // device_quick_service
            // 
            this.device_quick_service.DataPropertyName = "device_quick_service";
            this.device_quick_service.HeaderText = "快速服务代码";
            this.device_quick_service.MinimumWidth = 120;
            this.device_quick_service.Name = "device_quick_service";
            this.device_quick_service.ReadOnly = true;
            this.device_quick_service.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.device_quick_service.Width = 120;
            // 
            // device_description
            // 
            this.device_description.DataPropertyName = "device_description";
            this.device_description.HeaderText = "设备描述";
            this.device_description.MinimumWidth = 280;
            this.device_description.Name = "device_description";
            this.device_description.ReadOnly = true;
            this.device_description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.device_description.Width = 280;
            // 
            // device_type_name
            // 
            this.device_type_name.DataPropertyName = "device_type_name";
            this.device_type_name.HeaderText = "设备类型";
            this.device_type_name.MinimumWidth = 90;
            this.device_type_name.Name = "device_type_name";
            this.device_type_name.ReadOnly = true;
            this.device_type_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.device_type_name.Width = 90;
            // 
            // vender_name
            // 
            this.vender_name.DataPropertyName = "vender_name";
            this.vender_name.HeaderText = "供 应 商";
            this.vender_name.MinimumWidth = 230;
            this.vender_name.Name = "vender_name";
            this.vender_name.ReadOnly = true;
            this.vender_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.vender_name.Width = 230;
            // 
            // device_purchase_date
            // 
            this.device_purchase_date.DataPropertyName = "device_purchase_date";
            this.device_purchase_date.HeaderText = "采购日期";
            this.device_purchase_date.MinimumWidth = 90;
            this.device_purchase_date.Name = "device_purchase_date";
            this.device_purchase_date.ReadOnly = true;
            this.device_purchase_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.device_purchase_date.Width = 90;
            // 
            // device_warranty
            // 
            this.device_warranty.DataPropertyName = "device_warranty";
            this.device_warranty.HeaderText = "保 修 期";
            this.device_warranty.MinimumWidth = 90;
            this.device_warranty.Name = "device_warranty";
            this.device_warranty.ReadOnly = true;
            this.device_warranty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.device_warranty.Width = 90;
            // 
            // device_end_date
            // 
            this.device_end_date.DataPropertyName = "device_end_date";
            this.device_end_date.HeaderText = "过保日期";
            this.device_end_date.MinimumWidth = 90;
            this.device_end_date.Name = "device_end_date";
            this.device_end_date.ReadOnly = true;
            this.device_end_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.device_end_date.Width = 90;
            // 
            // manufactory_alias
            // 
            this.manufactory_alias.DataPropertyName = "manufactory_alias";
            this.manufactory_alias.HeaderText = "制造厂商";
            this.manufactory_alias.MinimumWidth = 90;
            this.manufactory_alias.Name = "manufactory_alias";
            this.manufactory_alias.ReadOnly = true;
            this.manufactory_alias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.manufactory_alias.Width = 90;
            // 
            // socket_name
            // 
            this.socket_name.DataPropertyName = "socket_name";
            this.socket_name.HeaderText = "接口名称";
            this.socket_name.MinimumWidth = 100;
            this.socket_name.Name = "socket_name";
            this.socket_name.ReadOnly = true;
            this.socket_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // socket_description
            // 
            this.socket_description.DataPropertyName = "socket_description";
            this.socket_description.HeaderText = "接口描述";
            this.socket_description.MinimumWidth = 260;
            this.socket_description.Name = "socket_description";
            this.socket_description.ReadOnly = true;
            this.socket_description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.socket_description.Width = 260;
            // 
            // socket_ipv4_addr
            // 
            this.socket_ipv4_addr.HeaderText = "接口地址";
            this.socket_ipv4_addr.MinimumWidth = 100;
            this.socket_ipv4_addr.Name = "socket_ipv4_addr";
            this.socket_ipv4_addr.ReadOnly = true;
            this.socket_ipv4_addr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // socket_ipv4_mask
            // 
            this.socket_ipv4_mask.HeaderText = "接口掩码";
            this.socket_ipv4_mask.MinimumWidth = 100;
            this.socket_ipv4_mask.Name = "socket_ipv4_mask";
            this.socket_ipv4_mask.ReadOnly = true;
            this.socket_ipv4_mask.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // socket_ipv4_gw
            // 
            this.socket_ipv4_gw.HeaderText = "地址网关";
            this.socket_ipv4_gw.MinimumWidth = 100;
            this.socket_ipv4_gw.Name = "socket_ipv4_gw";
            this.socket_ipv4_gw.ReadOnly = true;
            this.socket_ipv4_gw.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // socket_ipv4_description
            // 
            this.socket_ipv4_description.DataPropertyName = "socket_ipv4_description";
            this.socket_ipv4_description.HeaderText = "地址描述";
            this.socket_ipv4_description.MinimumWidth = 100;
            this.socket_ipv4_description.Name = "socket_ipv4_description";
            this.socket_ipv4_description.ReadOnly = true;
            this.socket_ipv4_description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // socket_speed_type_name
            // 
            this.socket_speed_type_name.DataPropertyName = "socket_speed_type_name";
            this.socket_speed_type_name.HeaderText = "接口速率";
            this.socket_speed_type_name.MinimumWidth = 100;
            this.socket_speed_type_name.Name = "socket_speed_type_name";
            this.socket_speed_type_name.ReadOnly = true;
            this.socket_speed_type_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // socket_phy_type_name
            // 
            this.socket_phy_type_name.DataPropertyName = "socket_phy_type_name";
            this.socket_phy_type_name.HeaderText = "物理接口类型";
            this.socket_phy_type_name.MinimumWidth = 120;
            this.socket_phy_type_name.Name = "socket_phy_type_name";
            this.socket_phy_type_name.ReadOnly = true;
            this.socket_phy_type_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.socket_phy_type_name.Width = 120;
            // 
            // socket_logic_type_name
            // 
            this.socket_logic_type_name.DataPropertyName = "socket_logic_type_name";
            this.socket_logic_type_name.HeaderText = "逻辑接口类型";
            this.socket_logic_type_name.MinimumWidth = 120;
            this.socket_logic_type_name.Name = "socket_logic_type_name";
            this.socket_logic_type_name.ReadOnly = true;
            this.socket_logic_type_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.socket_logic_type_name.Width = 120;
            // 
            // MainWindow
            // 
            this.AcceptButton = this.btnListDevice;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 687);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.tabAll);
            this.Controls.Add(this.menuMain);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuMain;
            this.MinimumSize = new System.Drawing.Size(1116, 726);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "量投科技IT资产管理系统";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.tabAll.ResumeLayout(false);
            this.tabFindDevice.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvwDeviceInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getModulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeviceInfo)).EndInit();
            this.contMenuGdvw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvwSocketInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSocketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSocketInfo)).EndInit();
            this.groupFindDevice.ResumeLayout(false);
            this.groupFindDevice.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeviceType)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manufactoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsManufactory)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venderInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVender)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panlWarrantyDate.ResumeLayout(false);
            this.panlWarrantyDate.PerformLayout();
            this.panlDeivceModule.ResumeLayout(false);
            this.panlDeivceModule.PerformLayout();
            this.panlDeviceName.ResumeLayout(false);
            this.panlDeviceName.PerformLayout();
            this.tabDefineDevice.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupConfigSocket.ResumeLayout(false);
            this.groupConfigSocket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.socketSpeedTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpeedType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socketLogicTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLogicType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socketPhyTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPhyType)).EndInit();
            this.groupConfigDevice.ResumeLayout(false);
            this.groupConfigDevice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTypeAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeviceTypeBindingSource)).EndInit();
            this.contMenuTrvwDevice.ResumeLayout(false);
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.contMenuTrvwTemplete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fsTempleteWatcher)).EndInit();
            this.contMenuTrvwConfigDevice.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabAll;
        private System.Windows.Forms.TabPage tabDefineDevice;
        private System.Windows.Forms.TabPage tabDeviceTopo;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.TabPage tabFindDevice;
        private dsDeviceType dsDeviceType;
        private System.Windows.Forms.BindingSource deviceTypeBindingSource;
        private dsDeviceTypeTableAdapters.DeviceTypeTableAdapter deviceTypeTableAdapter;
        private dsManufactory dsManufactory;
        private System.Windows.Forms.BindingSource manufactoryBindingSource;
        private dsManufactoryTableAdapters.ManufactoryTableAdapter manufactoryTableAdapter;
        private dsVender dsVender;
        private System.Windows.Forms.BindingSource venderInfoBindingSource;
        private dsVenderTableAdapters.VenderInfoTableAdapter venderInfoTableAdapter;
        private System.Windows.Forms.TreeView trvwDevice;
        private System.Windows.Forms.DataGridView gdvwDeviceInfo;
        //private System.Windows.Forms.BindingSource updateOrderOptionBindingSource;
        private System.Windows.Forms.BindingSource getModulesBindingSource;
        private dsDeviceInfo dsDeviceInfo;
        private dsDeviceInfoTableAdapters.GetModulesTableAdapter getModulesTableAdapter;
        private System.Windows.Forms.TreeView trvwConfigDevice;
        private System.Windows.Forms.GroupBox groupConfigDevice;
        private System.Windows.Forms.DateTimePicker dtpkConfigPurchaseDate;
        private System.Windows.Forms.ComboBox cmbConfigArea;
        private System.Windows.Forms.ComboBox cmbConfigVender;
        private System.Windows.Forms.ComboBox cmbConfigModule;
        private System.Windows.Forms.ComboBox cmbConfigRole;
        private System.Windows.Forms.ComboBox cmbConfigDeviceType;
        private System.Windows.Forms.ComboBox cmbConfigLocation;
        private System.Windows.Forms.ComboBox cmbConfigCity;
        private System.Windows.Forms.TextBox txtConfigDeviceDescription;
        private System.Windows.Forms.TextBox txtConfigModule;
        private System.Windows.Forms.TextBox txtConfigQuickService;
        private System.Windows.Forms.TextBox txtConfigDeviceSN;
        private System.Windows.Forms.TextBox txtConfigDeviceName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnResetDeviceConfig;
        private System.Windows.Forms.Button btnDeleteDevice;
        private System.Windows.Forms.CheckBox chkConfigPurchaseDate;
        private System.Windows.Forms.ComboBox cmbConfigManufactory;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupConfigSocket;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtConfigSocketName;
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
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtConfigSocketDescription;
        private System.Windows.Forms.Button btnResetSocketConfig;
        private System.Windows.Forms.ContextMenuStrip contMenuTrvwDevice;
        private System.Windows.Forms.ToolStripMenuItem 在设备定义中编辑ToolStripMenuItem;
        private System.Windows.Forms.Button btnAddSocket;
        private System.Windows.Forms.Button btnSaveAllDevice;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加设备ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加接口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除设备ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 从模版导入ToolStripMenuItem;
        private System.Windows.Forms.Button btnSaveDevice2File;
        private System.Windows.Forms.ToolStripMenuItem 数据库配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.BindingSource getSocketsBindingSource;
        private dsSocketInfo dsSocketInfo;
        private dsSocketInfoTableAdapters.GetSocketsTableAdapter getSocketsTableAdapter;
        private System.Windows.Forms.DataGridView gdvwSocketInfo;
        private System.Windows.Forms.ToolStripMenuItem 刷新设备信息ToolStripMenuItem;
        private System.Windows.Forms.Button btnSaveCurrentDevice;
        private System.Windows.Forms.MaskedTextBox txtConfigWarranty;
        private System.Windows.Forms.ListBox listDevices;
        private System.Windows.Forms.TreeView trvwTempletes;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.OpenFileDialog opfDialog;
        private System.Windows.Forms.ContextMenuStrip contMenuTrvwTemplete;
        private System.Windows.Forms.ToolStripMenuItem 从该模版导入ToolStripMenuItem;
        private System.IO.FileSystemWatcher fsTempleteWatcher;
        private System.Windows.Forms.ToolStripMenuItem 编辑模版ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contMenuTrvwConfigDevice;
        private System.Windows.Forms.ToolStripMenuItem 清除全部设备ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 清除该设备ToolStripMenuItem;
        private System.Windows.Forms.Timer timeExpandCountDown;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.CheckBox chkAddrInfo;
        private CommonClass.IPv4Mask ipv4Mask;
        private CommonClass.IPv4Address ipv4Address;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupFindDevice;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.CheckBox chkEnableDate;
        private System.Windows.Forms.Button btnListDevice;
        private System.Windows.Forms.DateTimePicker dtpkWarrantyDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panlWarrantyDate;
        private System.Windows.Forms.RadioButton rdoWarrantyOut;
        private System.Windows.Forms.RadioButton rdoWarrantyIn;
        private System.Windows.Forms.Panel panlDeivceModule;
        private System.Windows.Forms.RadioButton rdoModuleFuzzy;
        private System.Windows.Forms.RadioButton rdoModulePrecise;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Panel panlDeviceName;
        private System.Windows.Forms.RadioButton rdoNameFuzzy;
        private System.Windows.Forms.RadioButton rdoNamePrecise;
        private System.Windows.Forms.TextBox txtDeviceModule;
        private System.Windows.Forms.ComboBox cmbVender;
        private System.Windows.Forms.ComboBox cmbManufactory;
        private System.Windows.Forms.ComboBox cmbDeviceType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel tlstrplbDeviceCount;
        private System.Windows.Forms.BindingSource dsDeviceTypeBindingSource;
        private System.Windows.Forms.BindingSource deviceTypeAllBindingSource;
        private dsDeviceTypeTableAdapters.DeviceTypeAllTableAdapter deviceTypeAllTableAdapter;
        private System.Windows.Forms.TextBox txtDeviceDescrip;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ToolStripStatusLabel tlstrplbDBServer;
        private System.Windows.Forms.Label label29;
        private CommonClass.IPv4Address iPv4End;
        private System.Windows.Forms.Label label30;
        private CommonClass.IPv4Address iPv4Start;
        private System.Windows.Forms.Button btnAdvance;
        private System.Windows.Forms.CheckBox chkIP;
        private System.Windows.Forms.ContextMenuStrip contMenuGdvw;
        private System.Windows.Forms.ToolStripMenuItem 复制内容ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新获取配置数据ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_module;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_quick_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_type_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn vender_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_purchase_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_warranty;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_end_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufactory_alias;
        private System.Windows.Forms.DataGridViewTextBoxColumn socket_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn socket_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn socket_ipv4_addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn socket_ipv4_mask;
        private System.Windows.Forms.DataGridViewTextBoxColumn socket_ipv4_gw;
        private System.Windows.Forms.DataGridViewTextBoxColumn socket_ipv4_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn socket_speed_type_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn socket_phy_type_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn socket_logic_type_name;
    }
}

