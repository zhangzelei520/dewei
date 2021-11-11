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
    public partial class InHospitalzhu : Form
    {
        string s = "";
        public InHospitalzhu(string str)
        {
            InitializeComponent();
            s = new IdCard_BLL().p_peodom_select(str + "");
            s = s.Replace(" ", "");
            string[] ss = s.Split('-');
            foreach (Control item in groupBox1.Controls)
            {
                foreach (string ite in ss)
                {
                    if (item.Text.Substring(1,4) == ite)
                    {
                        item.Enabled = true;
                    }
                }
            }
        }

        private void InHospitalzhu_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
            label7.Visible = false;
            label2.Top = label2.Top - 72;
            label3.Top = label3.Top - 72;
            label4.Top = label4.Top - 72;
            label5.Top = label5.Top - 72;
            label8.Top = label8.Top - 72;

            label1_Click(null ,null );

            label7.Image = Image.FromFile(Application.StartupPath + "\\imag\\Biaoti-1.png");
            if (lbl.Count != 0)
            {
                lbl[0].Image = null;
                lbl[0].ForeColor = System.Drawing.Color.DarkSlateBlue;
            }
            lbl.Clear();
            lbl.Add(label7);
            groupBox2.Controls.Clear();
            InHospitalForm ihf = new InHospitalForm();
            yy(ihf);
        }
        int i = 0;
        private void label1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                label6.Visible = true;
                label7.Visible = true;
                label2.Top = label2.Top + 72;
                label3.Top = label3.Top + 72;
                label4.Top = label4.Top + 72;
                label5.Top = label5.Top + 72;
                label8.Top = label8.Top + 72;
                i = 1;
            }
            else 
            {
                label6.Visible = false;
                label7.Visible = false;
                label2.Top = label2.Top - 72;
                label3.Top = label3.Top - 72;
                label4.Top = label4.Top - 72;
                label5.Top = label5.Top - 72;
                label8.Top = label8.Top - 72;
                i = 0;
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (lbl.Count != 0 && ((Label)sender) == lbl[0])
                return;
           
                ((Label)sender).ForeColor = System.Drawing.Color.Blue;
                ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\Biaoti-0.png");
            
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            if (lbl.Count != 0 && ((Label)sender) == lbl[0])
                return;
           
                ((Label)sender).ForeColor = System.Drawing.Color.DarkSlateBlue;
                ((Label)sender).Image = null;
            
        }

        void yy(Form ihf)
        {
            ihf.TopLevel = false;
            groupBox2.Controls.Add(ihf);
            ihf.Show();
        }
        List<Label> lbl = new List<Label>();
        void xx(Label lb)
        {
            lb.Image = Image.FromFile(Application.StartupPath + "\\imag\\Biaoti-1.png");
            if (lbl.Count != 0)
            {
                lbl[0].Image = null;
                lbl[0].ForeColor = System.Drawing.Color.DarkSlateBlue;
            }
                lbl.Clear();
            lbl.Add(lb);
        }
        private void label7_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            InHospitalForm ihf = new InHospitalForm();
            yy(ihf);
            xx(((Label)sender));
        }

        private void label6_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            InHospitalInsert ihf = new InHospitalInsert();
            yy(ihf);
            xx(((Label)sender));
        }

        private void label5_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            InHospitalzhuyuan ihf = new InHospitalzhuyuan();
            yy(ihf);
            xx(((Label)sender));
        }

        private void label2_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            InHospital_yujiao inh = new InHospital_yujiao();
            yy(inh);
            xx(((Label)sender));
        }

        private void label4_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            inHospital_zhiban ihf = new inHospital_zhiban();
            yy(ihf);
            xx(((Label)sender));
        }

        private void label3_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            feiyong ihf = new feiyong();
            yy(ihf);
            xx(((Label)sender));
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            InHospital_over ihf = new InHospital_over();
            yy(ihf);
            xx(((Label)sender));
        }


    }
}
