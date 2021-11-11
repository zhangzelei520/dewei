using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using BLL;
namespace UI
{
    public partial class usesType_Form : Form
    {
        public usesType_Form()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                foreach (CheckBox item in groupBox1.Controls)
                {
                    item.Checked = true;
                    item.Enabled = true;
                }
            }
            else
            {
                foreach (CheckBox item in groupBox1.Controls)
                {
                    if (item.Name != "checkBox1")
                    {
                        item.Checked = false;
                        item.Enabled = false;
                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                foreach (CheckBox item in groupBox2.Controls)
                {
                    item.Checked = true;
                    item.Enabled = true;
                }
            }
            else
            {
                foreach (CheckBox item in groupBox2.Controls)
                {
                    if (item.Name != "checkBox2")
                    {
                        item.Checked = false;
                        item.Enabled = false;
                    }
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                foreach (CheckBox item in groupBox3.Controls)
                {
                    item.Checked = true;
                    item.Enabled = true;
                }
            }
            else
            {
                foreach (CheckBox item in groupBox3.Controls)
                {
                    if (item.Name != "checkBox3")
                    {
                        item.Checked = false;
                        item.Enabled = false;
                    }
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                foreach (CheckBox item in groupBox4.Controls)
                {
                    item.Checked = true;
                    item.Enabled = true;
                }
            }
            else
            {
                foreach (CheckBox item in groupBox4.Controls)
                {
                    if (item.Name != "checkBox4")
                    {
                        item.Checked = false;
                        item.Enabled = false;
                    }
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                foreach (CheckBox item in groupBox5.Controls)
                {
                    item.Checked = true;
                    item.Enabled = true;
                }
            }
            else
            {
                foreach (CheckBox item in groupBox5.Controls)
                {
                    if (item.Name != "checkBox5")
                    {
                        item.Checked = false;
                        item.Enabled = false;
                    }
                }
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                foreach (CheckBox item in groupBox6.Controls)
                {
                    item.Checked = true;
                    item.Enabled = true;
                }
            }
            else
            {
                foreach (CheckBox item in groupBox6.Controls)
                {
                    if (item.Name != "checkBox6")
                    {
                        item.Checked = false;
                        item.Enabled = false;
                    }
                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                foreach (CheckBox item in groupBox7.Controls)
                {
                    item.Checked = true;
                    item.Enabled = true;
                }
            }
            else
            {
                foreach (CheckBox item in groupBox7.Controls)
                {
                    if (item.Name != "checkBox7")
                    {
                        item.Checked = false;
                        item.Enabled = false;
                    }
                }
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                foreach (CheckBox item in groupBox8.Controls)
                {
                    item.Checked = true;
                    item.Enabled = true;
                }
            }
            else
            {
                foreach (CheckBox item in groupBox8.Controls)
                {
                    if (item.Name != "checkBox8")
                    {
                        item.Checked = false;
                        item.Enabled = false;
                    }
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                PromptingForm p = new PromptingForm("请输入类型、");
                p.ShowDialog();
                return;
            }
            string str = "";
            foreach (Control item in Controls)
            {
                if (item is GroupBox)
                {
                    foreach (Control ite in item.Controls)
                    {
                        if (ite is CheckBox)
                        {
                            if (((CheckBox)ite).Checked)
                                str += ite.Text + "-";
                        }
                    }
                }
            }

           string  s=  new IdCard_BLL().p_usersType_insert(textBox1.Text, str);
           MessageBox.Show(str);
           PromptingForm pp = new PromptingForm(str);
           pp.ShowDialog();
           this.Close();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
