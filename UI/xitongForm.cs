using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class xitongForm : Form
    {
        string s="";
        public xitongForm(string str)
        {
            InitializeComponent();
            s = new IdCard_BLL().p_peodom_select(str+ "");
            string []ss = s.Split('-');

            foreach (Control item in groupBox1.Controls)
            {
                if (item is Label)
                {
                    foreach (string ite in ss)
                    {
                        if (ite == item.Text)
                        {
                            item.Enabled = true;
                        }
                    }
                }
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            SectionRoomSon s = new SectionRoomSon();
            s.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            BillPrintForm p = new BillPrintForm("挂号单");
            p.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BillPrintForm p = new BillPrintForm("门诊单");
            p.ShowDialog();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            BillPrintForm p = new BillPrintForm("住院单");
            p.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            quanxian_Form q = new quanxian_Form();
            q.ShowDialog ();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            uses_Form u = new uses_Form();
            u.ShowDialog();
        }
    }
}
