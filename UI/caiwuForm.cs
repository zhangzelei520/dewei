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
    public partial class caiwuForm : Form
    {
      
        string s="";
        public caiwuForm(string str)
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
            yingyetongji_Form y = new yingyetongji_Form();
            y.TopLevel = false;
            groupBox2.Controls.Add(y);
            y.Show();
            if (lbl.Count != 0)
            {
                string str = (lbl[0].Tag + "").Replace('-', ' ');
                lbl[0].Image = Image.FromFile(Application.StartupPath + "\\imag\\" + str);
                lbl.Clear();
            }
            lbl.Add(((Label)sender));
            ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);

        }

        private void caiwuForm_Load(object sender, EventArgs e)
        {
            lbl.Add(((Label)label1));
            lbl[0].Image = Image.FromFile(Application.StartupPath + "\\imag\\" + lbl[0].Tag);
            groupBox2.Controls.Clear();
            yingyetongji_Form y = new yingyetongji_Form();
            y.TopLevel = false;
            groupBox2.Controls.Add(y);
            y.Show();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);
        }
        List<Label> lbl = new List<Label>();
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            if (lbl.Count != 0 && ((Label)sender).Tag == lbl[0].Tag)
            {
                return;
            }

            string str = (((Label)sender).Tag + "").Replace('-', ' ');
            ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + str);

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
            usesUpdate_Form y = new usesUpdate_Form();
            y.TopLevel = false;
            groupBox2.Controls.Add(y);
            y.Show();

           
        }


        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
          //  e.Graphics.Clear(groupBox2.BackColor);
            //e.Graphics.DrawLine(Pens.Red,1,1,1,1);
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
           // e.Graphics.Clear(groupBox2.BackColor);
           // e.Graphics.DrawLine(Pens.Red, 1,7,8 ,7);
        }
    }
}
