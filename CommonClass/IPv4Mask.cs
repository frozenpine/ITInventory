using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;

namespace CommonClass
{
    public partial class IPv4Mask : UserControl
    {
        public IPv4Mask()
        {
            InitializeComponent();
        }

        new public void Focus()
        {
            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar=='/')
            {
                textBox2.Visible = textBox3.Visible = textBox4.Visible = false;
                label1.Visible = label2.Visible = label3.Visible = false;
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {
                textBox2.Focus();
                e.Handled = true;
            }
            else if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Escape)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                textBox3.Focus();
                e.Handled = true;
            }
            else if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Escape)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                if (((TextBox)sender).Text.Length == 0)
                {
                    textBox1.Focus();
                }
            }
            else
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                textBox4.Focus();
                e.Handled = true;
            }
            else if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Escape)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                if (((TextBox)sender).Text.Length == 0)
                {
                    textBox2.Focus();
                }
            }
            else
                e.Handled = true;
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Escape)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                if (((TextBox)sender).Text.Length == 0)
                {
                    textBox3.Focus();
                }
            }
            else
                e.Handled = true;
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void textBox_MouseClick(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void IPv4Mask_Leave(object sender, EventArgs e)
        {
            if (textBox2.Visible == textBox3.Visible == textBox4.Visible == true)
            {
                foreach (var control in this.Controls)
                {
                    if (control.GetType() == typeof(TextBox) && ((TextBox)control).Text == "")
                    {
                        ((TextBox)control).Focus();
                        return;
                    }
                }
            }
        }

        public override string Text
        {
            get
            {
                if (textBox2.Visible == textBox3.Visible == textBox4.Visible == true)
                {
                    return textBox1.Text + "." + textBox2.Text + "." + textBox3.Text + "." + textBox4.Text;
                }
                else
                {
                    return TCPIP.Uint2StrAddr4(TCPIP.Bit2UintMask(int.Parse(textBox1.Text)));
                }
            }
            set
            {
                string[] tmp = value.Split('.');
                textBox1.Text = tmp[0];
                textBox2.Text = tmp[1];
                textBox3.Text = tmp[2];
                textBox4.Text = tmp[3];
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            if (textBox2.Visible == textBox3.Visible == textBox4.Visible == false)
            {
                if (((TextBox)sender).Text == "" || int.Parse(((TextBox)sender).Text) <= 0 || int.Parse(((TextBox)sender).Text) > 30)
                {
                    ((TextBox)sender).Focus();
                    return;
                }
            }
            else
            {
                if (((TextBox)sender).Text != "")
                {
                    switch (int.Parse(((TextBox)sender).Text))
                    {
                        case 255:
                            break;
                        case 254:
                            break;
                        case 252:
                            break;
                        case 248:
                            break;
                        case 240:
                            break;
                        case 224:
                            break;
                        case 192:
                            break;
                        case 128:
                            break;
                        case 0:
                            break;
                        default:
                            ((TextBox)sender).Focus();
                            break;
                    }
                }
                else
                {
                    ((TextBox)sender).Text = "255";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length==3)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 3)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 3)
            {
                textBox4.Focus();
            }
        }

        public void Reset()
        {
            textBox1.Visible = textBox2.Visible = textBox3.Visible = textBox4.Visible = true;
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            label1.Visible = label2.Visible = label3.Visible = true;
        }
    }
}
