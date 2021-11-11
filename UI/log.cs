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
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }

        #region 窗体移动
      
        private bool IsMouseDownInForm = false;
        private Point p;


     

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDownInForm)
            {
                Left += e.Location.X - p.X;
                Top += e.Location.Y - p.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDownInForm = true;
            p = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDownInForm = false;
        }
        #endregion


        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).Image =Image .FromFile ("imag\\"+ ((PictureBox)sender).Tag );

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = Image.FromFile("imag\\" +  (((PictureBox)sender).Tag+"").Replace (' ','-'));
        }
        List<Label> lbl = new List<Label>(); 
       

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.Uname = txtUname.Text;
            u.Pwd = txtPwd.Text;
            int i= new UsersBLL().Check(u);

            if (txtUname.Text == "")
            {
                lblUname.Visible = true;
                lblUname.Text = "用户名不能为空";
                return;
            }
            else if(txtPwd.Text=="")
            {
                lblPwd.Visible = true;
                lblPwd.Text = "密码不能为空";
                return;
            }
            else
            if (i==1)
            {
                lblPwd.Visible = true;
                
                lblPwd.Text = "密码不正确";
                
            }
            else if(i==0)
            {
                lblUname.Visible = true;
                
                lblUname.Text = "没有此用户";
            }
            else if(i==3)
            {
                MessageBox.Show("系统错误");
                
            }
            else
            {
                zhufrom zhu = new zhufrom();
                zhu.Tag = txtUname.Text;
                zhu.Show();
                this.Hide();    
            }
            
        }

        private void log_Load(object sender, EventArgs e)
        {
            lblUname.Visible = false;
            lblPwd.Visible = false;
        }

        private void txtUname_TextChanged(object sender, EventArgs e)
        {
            lblUname.Visible = false;
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            lblPwd.Visible = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
