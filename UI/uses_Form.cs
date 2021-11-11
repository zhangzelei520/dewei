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
    public partial class uses_Form : Form
    {
        public uses_Form()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void uses_Form_Load(object sender, EventArgs e)
        {
            List<usersType> type = new IdCard_BLL().p_usesType_select();
            foreach (var item in type)
            {
                comboBox1.Items.Add(item.Type );
            }
            List<SectionRoom> se = new UsersBLL().Section();
            foreach (var item in se)
            {
                comboBox2.Items.Add (item .Sname );
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control  item in groupBox1.Controls )
            {
                if (comboBox1.Text != "医师" && (item.Name == "textBox9" || item.Name == "comboBox2"))
                {
                    textBox9.Text = 0+"";
                    continue;
                }
                else if (item.Text == "")
                {
                    PromptingForm p = new PromptingForm("请输入完整");
                    p.ShowDialog();
                    return;
                }
            }
            try
            {
                int.Parse(textBox9.Text);
            }
            catch
            {
                PromptingForm pp = new PromptingForm("请正确输入挂号费");
                pp.ShowDialog();
            }
            Users u = new Users();
            u . Uname = textBox1 .Text;
            u . name = textBox4.Text;
            u. Pwd   =   textBox2.Text;
            if (radioButton1.Checked)
                u.Sex = "男";
            else
                u.Sex = "女";
            u. Address =textBox5.Text;
            u. Phone  =   textBox6.Text;
            u. Spell  =  textBox7.Text;
            u. Type   = comboBox1.Text;
            u.SectionRoom = comboBox2.Text;
            u. money  =  int .Parse (textBox9.Text);
            u.Peodom = "";
        string s=    new IdCard_BLL().p_users_insert(u);
        PromptingForm ps = new PromptingForm(s);
        ps.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            int i = 0;
            ushort key = 0;
            string strResult = string.Empty;

            //创建两个不同的encoding对象
            Encoding unicode = Encoding.Unicode;
            //创建GBK码对象
            Encoding gbk = Encoding.GetEncoding(936);
            //将unicode字符串转换为字节
            byte[] unicodeBytes = unicode.GetBytes(textBox1.Text);
            //再转化为GBK码
            byte[] gbkBytes = Encoding.Convert(unicode, gbk, unicodeBytes);
            while (i < gbkBytes.Length)
            {
                //如果为数字\字母\其他ASCII符号
                if (gbkBytes[i] <= 127)
                {
                    strResult = strResult + (char)gbkBytes[i];
                    i++;
                }
                #region 否则生成汉字拼音简码,取拼音首字母
                else
                {

                    key = (ushort)(gbkBytes[i] * 256 + gbkBytes[i + 1]);
                    if (key >= '\uB0A1' && key <= '\uB0C4')
                    {
                        strResult = strResult + "A";
                    }
                    else if (key >= '\uB0C5' && key <= '\uB2C0')
                    {
                        strResult = strResult + "B";
                    }
                    else if (key >= '\uB2C1' && key <= '\uB4ED')
                    {
                        strResult = strResult + "C";
                    }
                    else if (key >= '\uB4EE' && key <= '\uB6E9')
                    {
                        strResult = strResult + "D";
                    }
                    else if (key >= '\uB6EA' && key <= '\uB7A1')
                    {
                        strResult = strResult + "E";
                    }
                    else if (key >= '\uB7A2' && key <= '\uB8C0')
                    {
                        strResult = strResult + "F";
                    }
                    else if (key >= '\uB8C1' && key <= '\uB9FD')
                    {
                        strResult = strResult + "G";
                    }
                    else if (key >= '\uB9FE' && key <= '\uBBF6')
                    {
                        strResult = strResult + "H";
                    }
                    else if (key >= '\uBBF7' && key <= '\uBFA5')
                    {
                        strResult = strResult + "J";
                    }
                    else if (key >= '\uBFA6' && key <= '\uC0AB')
                    {
                        strResult = strResult + "K";
                    }
                    else if (key >= '\uC0AC' && key <= '\uC2E7')
                    {
                        strResult = strResult + "L";
                    }
                    else if (key >= '\uC2E8' && key <= '\uC4C2')
                    {
                        strResult = strResult + "M";
                    }
                    else if (key >= '\uC4C3' && key <= '\uC5B5')
                    {
                        strResult = strResult + "N";
                    }
                    else if (key >= '\uC5B6' && key <= '\uC5BD')
                    {
                        strResult = strResult + "O";
                    }
                    else if (key >= '\uC5BE' && key <= '\uC6D9')
                    {
                        strResult = strResult + "P";
                    }
                    else if (key >= '\uC6DA' && key <= '\uC8BA')
                    {
                        strResult = strResult + "Q";
                    }
                    else if (key >= '\uC8BB' && key <= '\uC8F5')
                    {
                        strResult = strResult + "R";
                    }
                    else if (key >= '\uC8F6' && key <= '\uCBF9')
                    {
                        strResult = strResult + "S";
                    }
                    else if (key >= '\uCBFA' && key <= '\uCDD9')
                    {
                        strResult = strResult + "T";
                    }
                    else if (key >= '\uCDDA' && key <= '\uCEF3')
                    {
                        strResult = strResult + "W";
                    }
                    else if (key >= '\uCEF4' && key <= '\uD188')
                    {
                        strResult = strResult + "X";
                    }
                    else if (key >= '\uD1B9' && key <= '\uD4D0')
                    {
                        strResult = strResult + "Y";
                    }
                    else if (key >= '\uD4D1' && key <= '\uD7F9')
                    {
                        strResult = strResult + "Z";
                    }
                    else
                    {
                        strResult = strResult + "?";
                    }
                    i = i + 2;
                }
                #endregion
            }//end while
            textBox7.Text = strResult;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "医师")
            {
                comboBox2.Enabled = true;
                textBox9.Enabled = true;

            }
            else
            {
                comboBox2.Text = "";
                textBox9.Text = "";
                comboBox2.Enabled = false ;
                textBox9.Enabled = false ;
            
            }
            
        }
    }
}
