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
    public partial class yaofangForm : Form
    {
        string s = "";
        public yaofangForm(string str)
        {
            InitializeComponent();
            s = new IdCard_BLL().p_peodom_select(str + "");
            string[] ss = s.Split('-');
            foreach (Control item in groupBox1.Controls)
            {
                foreach (string ite in ss)
                {
                    if (item.Text == ite)
                    {
                        item.Enabled = true;
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            yaofan_Form p = new yaofan_Form();
            p.TopLevel = false;
            groupBox2.Controls.Add(p);
            p.Show();
        }

        private void yaofangForm_Load(object sender, EventArgs e)
        {
            lbl.Add(((Label)label3));
            lbl[0].Image = Image.FromFile(Application.StartupPath + "\\imag\\" + lbl[0].Tag);
            groupBox2.Controls.Clear();
            yaofan_Form p = new yaofan_Form();
            p.TopLevel = false;
            groupBox2.Controls.Add(p);
            p.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

            groupBox2.Controls.Clear();
            yifayaopin_Form p = new yifayaopin_Form();
            p.TopLevel = false;
            groupBox2.Controls.Add(p);
            p.Show();
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            if (lbl.Count != 0 && ((Label)sender).Tag == lbl[0].Tag)
            {
                return;
            }

            string str = (((Label)sender).Tag + "").Replace('-', ' ');
            ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + str);
        }
        List<Label> lbl = new List<Label>();
        private void label3_Click_1(object sender, EventArgs e)
        {
            if (lbl.Count != 0)
            {
                string str = (lbl[0].Tag + "").Replace('-', ' ');
                lbl[0].Image = Image.FromFile(Application.StartupPath + "\\imag\\" + str);
                lbl.Clear();
            }
            lbl.Add(((Label)sender));
            ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);
        }
    }
}
