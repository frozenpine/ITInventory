using System;
using System.Windows.Forms;
using System.Net;

namespace CommonClass
{
    public partial class IPv4Address : UserControl
    {
        public IPv4Address()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            foreach (var control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        new public void Focus()
        {
            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
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

        private void textBox_Leave(object sender, EventArgs e)
        {
            if(((TextBox)sender).Text=="")
            {
                ((TextBox)sender).Text = "0";
            }
        }

        private void textBox_MouseClick(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void IPv4Address_Leave(object sender, EventArgs e)
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

        public override string Text
        {
            get
            {
                return textBox1.Text + "." + textBox2.Text + "." + textBox3.Text + "." + textBox4.Text;
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

        public bool IsNull()
        {
            return textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "";
        }
    }
}
