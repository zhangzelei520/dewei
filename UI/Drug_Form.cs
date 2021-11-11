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
    public partial class Drug_Form : Form
    {
        string s = "";
        public Drug_Form(string str)
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

        private void label1_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            Drug_insert_UI insert = new Drug_insert_UI();
            insert.TopLevel = false;
            groupBox2.Controls.Add(insert);
            insert.Show();

            if (lbl.Count != 0)
            {
                string str = (lbl[0].Tag + "").Replace('-', ' ');
                lbl[0].Image = Image.FromFile(Application.StartupPath + "\\imag\\" + str);
                lbl.Clear();
            }
            lbl.Add(((Label)sender));
            ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (lbl.Count != 0)
            {
                string str = (lbl[0].Tag + "").Replace('-', ' ');
                lbl[0].Image = Image.FromFile(Application.StartupPath + "\\imag\\" + str);
                lbl.Clear();
            }
            lbl.Add(((Label)sender));
            ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);
            groupBox2.Controls.Clear();
            Drug_Select_UI insert = new Drug_Select_UI();
            insert.TopLevel = false;
            groupBox2.Controls.Add(insert);
            insert.Show();
        }
        List<Label> lbl = new List<Label>();
        private void label2_Click(object sender, EventArgs e)
        {
            if (lbl.Count != 0)
            {
                string str = (lbl[0].Tag + "").Replace('-', ' ');
                lbl[0].Image = Image.FromFile(Application.StartupPath + "\\imag\\" + str);
                lbl.Clear();
            }
            lbl.Add(((Label)sender));
            ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);
            groupBox2.Controls.Clear();
            Drug_Delete_UI insert = new Drug_Delete_UI();
            insert.TopLevel = false;
            groupBox2.Controls.Add(insert);
            insert.Show();
        }

        private void Drug_Form_Load(object sender, EventArgs e)
        {
            lbl.Add(((Label)label1));
            lbl[0].Image = Image.FromFile(Application.StartupPath + "\\imag\\" + lbl[0].Tag);
            groupBox2.Controls.Clear();
            Drug_insert_UI insert = new Drug_insert_UI();
            insert.TopLevel = false;
            groupBox2.Controls.Add(insert);
            insert.Show();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            if (lbl.Count != 0 && ((Label)sender).Tag == lbl[0].Tag)
            {
                return;
            }

            string str = (((Label)sender).Tag + "").Replace('-', ' ');
            ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + str);
        }
    }
}
