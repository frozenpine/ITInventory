namespace TempleteEditor
{
    partial class EditorMainWindow
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
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.trvwXML = new System.Windows.Forms.TreeView();
            this.opfDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.btnAddSocket = new System.Windows.Forms.Button();
            this.btnDelDevice = new System.Windows.Forms.Button();
            this.btnSaveTemplete = new System.Windows.Forms.Button();
            this.contMenuTemplete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeExpandCountDown = new System.Windows.Forms.Timer(this.components);
            this.contMenuTemplete.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(107, 14);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(583, 21);
            this.txtFilePath.TabIndex = 0;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(13, 13);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 1;
            this.btnBrowser.Text = "浏览";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // trvwXML
            // 
            this.trvwXML.AllowDrop = true;
            this.trvwXML.Location = new System.Drawing.Point(13, 43);
            this.trvwXML.Name = "trvwXML";
            this.trvwXML.Size = new System.Drawing.Size(174, 361);
            this.trvwXML.TabIndex = 2;
            this.trvwXML.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.trvwXML_ItemDrag);
            this.trvwXML.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvwXML_AfterSelect);
            this.trvwXML.DragDrop += new System.Windows.Forms.DragEventHandler(this.trvwXML_DragDrop);
            this.trvwXML.DragOver += new System.Windows.Forms.DragEventHandler(this.trvwXML_DragOver);
            this.trvwXML.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trvwXML_MouseDown);
            // 
            // opfDialog
            // 
            this.opfDialog.DefaultExt = "xml";
            this.opfDialog.FileName = "./DeviceTempletes.xml";
            this.opfDialog.Filter = "模版文件|*.xml";
            this.opfDialog.InitialDirectory = "./";
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Location = new System.Drawing.Point(13, 411);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(84, 23);
            this.btnAddDevice.TabIndex = 7;
            this.btnAddDevice.Text = "添加设备";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // btnAddSocket
            // 
            this.btnAddSocket.Enabled = false;
            this.btnAddSocket.Location = new System.Drawing.Point(103, 411);
            this.btnAddSocket.Name = "btnAddSocket";
            this.btnAddSocket.Size = new System.Drawing.Size(84, 23);
            this.btnAddSocket.TabIndex = 7;
            this.btnAddSocket.Text = "添加接口";
            this.btnAddSocket.UseVisualStyleBackColor = true;
            this.btnAddSocket.Click += new System.EventHandler(this.btnAddSocket_Click);
            // 
            // btnDelDevice
            // 
            this.btnDelDevice.Location = new System.Drawing.Point(13, 441);
            this.btnDelDevice.Name = "btnDelDevice";
            this.btnDelDevice.Size = new System.Drawing.Size(174, 23);
            this.btnDelDevice.TabIndex = 8;
            this.btnDelDevice.Text = "删除设备";
            this.btnDelDevice.UseVisualStyleBackColor = true;
            this.btnDelDevice.Click += new System.EventHandler(this.btnDelDevice_Click);
            // 
            // btnSaveTemplete
            // 
            this.btnSaveTemplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveTemplete.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveTemplete.Location = new System.Drawing.Point(570, 384);
            this.btnSaveTemplete.Name = "btnSaveTemplete";
            this.btnSaveTemplete.Size = new System.Drawing.Size(75, 75);
            this.btnSaveTemplete.TabIndex = 9;
            this.btnSaveTemplete.Text = "保存模版";
            this.btnSaveTemplete.UseVisualStyleBackColor = true;
            this.btnSaveTemplete.Click += new System.EventHandler(this.btnSaveTemplete_Click);
            // 
            // contMenuTemplete
            // 
            this.contMenuTemplete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制节点ToolStripMenuItem,
            this.剪切节点ToolStripMenuItem,
            this.粘贴节点ToolStripMenuItem});
            this.contMenuTemplete.Name = "contMenuTemplete";
            this.contMenuTemplete.Size = new System.Drawing.Size(125, 70);
            // 
            // 复制节点ToolStripMenuItem
            // 
            this.复制节点ToolStripMenuItem.Name = "复制节点ToolStripMenuItem";
            this.复制节点ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.复制节点ToolStripMenuItem.Text = "复制节点";
            this.复制节点ToolStripMenuItem.Click += new System.EventHandler(this.复制该节点ToolStripMenuItem_Click);
            // 
            // 剪切节点ToolStripMenuItem
            // 
            this.剪切节点ToolStripMenuItem.Name = "剪切节点ToolStripMenuItem";
            this.剪切节点ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.剪切节点ToolStripMenuItem.Text = "剪切节点";
            this.剪切节点ToolStripMenuItem.Click += new System.EventHandler(this.剪切该节点ToolStripMenuItem_Click);
            // 
            // 粘贴节点ToolStripMenuItem
            // 
            this.粘贴节点ToolStripMenuItem.Enabled = false;
            this.粘贴节点ToolStripMenuItem.Name = "粘贴节点ToolStripMenuItem";
            this.粘贴节点ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.粘贴节点ToolStripMenuItem.Text = "粘贴节点";
            this.粘贴节点ToolStripMenuItem.Click += new System.EventHandler(this.粘贴节点ToolStripMenuItem_Click);
            // 
            // timeExpandCountDown
            // 
            this.timeExpandCountDown.Interval = 1000;
            this.timeExpandCountDown.Tick += new System.EventHandler(this.timeExpandCountDown_Tick);
            // 
            // EditorMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 472);
            this.Controls.Add(this.btnSaveTemplete);
            this.Controls.Add(this.btnDelDevice);
            this.Controls.Add(this.btnAddSocket);
            this.Controls.Add(this.btnAddDevice);
            this.Controls.Add(this.trvwXML);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.txtFilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(718, 511);
            this.Name = "EditorMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "模版编辑器";
            this.Load += new System.EventHandler(this.TempleteEditor_Load);
            this.contMenuTemplete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TreeView trvwXML;
        private System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
        private System.Windows.Forms.OpenFileDialog opfDialog;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.Button btnAddSocket;
        private System.Windows.Forms.Button btnDelDevice;
        private System.Windows.Forms.Button btnSaveTemplete;
        private dsDeviceType dsDeviceType=new dsDeviceType();
        private dsDeviceTypeTableAdapters.DeviceTypeTableAdapter deviceTypeTableAdapter = new dsDeviceTypeTableAdapters.DeviceTypeTableAdapter();
        private System.Windows.Forms.ContextMenuStrip contMenuTemplete;
        private System.Windows.Forms.ToolStripMenuItem 复制节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴节点ToolStripMenuItem;
        private System.Windows.Forms.Timer timeExpandCountDown;
    }
}

