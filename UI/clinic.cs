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
    public partial class clinic : Form
    {
        public clinic(string str)
        {
            InitializeComponent();
            s = new IdCard_BLL().p_peodom_select(str + "");
            string[] ss = s.Split('-');
            foreach (Control item in groupBox1.Controls  )
            {
                foreach (string  ite in ss)
                {
                    if (item.Text == ite)
                    {
                        item.Enabled = true;
                    }
                }
            }
        }
        List<Label> lbl = new List<Label>();
        private void label1_Click(object sender, EventArgs e)
        {
            if (lbl.Count  !=  0)
            {
                string str = (lbl[0].Tag + "").Replace('-', ' ');
                lbl[0].Image = Image.FromFile(Application.StartupPath + "\\imag\\" + str);
                lbl.Clear();
            }
            lbl.Add(((Label)sender));
            ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag );
            pancontrols.Controls.Clear();
            Register_UI reg = new Register_UI();
            reg.TopLevel = false;
            pancontrols.Controls.Add(reg);
            reg.Show();

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
            pancontrols.Controls.Clear();
            IdCard_UI reg = new IdCard_UI();
            reg.TopLevel = false;
            pancontrols.Controls.Add(reg);
            reg.Show();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            if (lbl.Count !=0 && ((Label)sender).Tag  == lbl[0].Tag  )
            {
                     return ;
            }
          
                string str = (((Label)sender).Tag + "").Replace('-', ' ');
                ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + str);
          
        }
        string s = "";
        private void clinic_Load(object sender, EventArgs e)
        {
            
            lbl.Add(((Label)label1));

            lbl[0].Image = Image.FromFile(Application.StartupPath + "\\imag\\" +  lbl[0].Tag);
            pancontrols.Controls.Clear();
            Register_UI reg = new Register_UI();
            reg.TopLevel = false;
            pancontrols.Controls.Add(reg);
            reg.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
