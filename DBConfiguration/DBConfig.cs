using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;
using System.Configuration;

namespace DBConfiguration
{
    public partial class DBConfig : Form
    {
        string ConnStr = "Provider=SQLOLEDB;Data Source=$ip$,$port$;Persist Security Info=True;Password=$password$;User ID=$user$;Initial Catalog=$database$";
        bool validDbSelect = false;
        bool validConnParam = false;
        public DBConfig()
        {
            InitializeComponent();
        }

        private void DBConfig_Load(object sender, EventArgs e)
        {
            ipv4DB.Text = "0.0.0.0";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbDatabase_DropDown(object sender, EventArgs e)
        {
            if (ipv4DB.Text != "0.0.0.0")
            {
                ConnStr = ConnStr.Replace("$ip$", ipv4DB.Text).Replace("$port$", txtPort.Text);
                if (txtUsername.Text != "")
                {
                    if (txtPassword.Text != "")
                    {
                        ConnStr = ConnStr.Replace("$user$", txtUsername.Text).Replace("$password$", txtPassword.Text);
                        string tmp = ConnStr.Replace("$database$", "master");
                        var conn = new OleDbConnection(tmp);
                        try
                        {
                            conn.Open();
                        }
                        catch (Exception err)
                        {
                            Debug.WriteLine(err);
                            validConnParam = false;
                            return;
                        }
                        var cmd = new OleDbCommand("SELECT NAME FROM dbo.sysdatabases", conn);
                        try
                        {
                            var reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                cmbDatabase.Items.Add(reader["NAME"].ToString());
                            }
                        }
                        catch (Exception err)
                        {
                            Debug.WriteLine(err);
                            validConnParam = false;
                            return;
                        }
                        validConnParam = true;
                    }
                    else
                    {
                        MessageBox.Show("请输入密码！");
                        validConnParam = false;
                        txtPassword.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("请输入用户名！");
                    validConnParam = false;
                    txtUsername.Focus();
                }
            }
            else
            {
                MessageBox.Show("请输入数据库地址！");
                validConnParam = false;
                ipv4DB.Focus();
            }
        }

        private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnStr = ConnStr.Replace("$database$", cmbDatabase.SelectedText);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(validDbSelect)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //config.Sections["userSettings"];
                this.Close();
            }
            else
            {
                if(MessageBox.Show("连接未测试成功，是否退出？", "注意", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnChkDBConn_Click(object sender, EventArgs e)
        {
            if (validConnParam)
            {
                if (cmbDatabase.SelectedIndex >= 0)
                {
                    try
                    {
                        var conn = new OleDbConnection(ConnStr);
                        conn.Open();
                        MessageBox.Show("连接测试成功！");
                        validDbSelect = true;
                    }
                    catch (Exception err)
                    {
                        Debug.WriteLine(err);
                        MessageBox.Show("连接测试失败！");
                        validDbSelect = false;
                    }
                }
                else
                {
                    MessageBox.Show("请选择要连接的数据库。");
                }
            }
            else
            {
                MessageBox.Show("请检查数据库连接参数配置！");
            }
        }
    }
}
