using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Model;


namespace UI
{
    public partial class zhufrom : Form
    {
        public zhufrom()
        {
            InitializeComponent();
        }
        #region  控件移动
        List<Label> l = new List<Label>();
        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
          // if ((( Label )sender ).Tag +""=="btn_right .png")
           timer1.Enabled = true;
           l.Add(((Label)sender));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Control  item in  panel1.Controls)
            {
                if (item.TabIndex + "" != "1")
                {

                    if (l[0].Tag + "" == "btn_right .png")
                    {
                        item.Left = item.Left - 2;
                    }
                    else
                    {
                        item.Left = item.Left + 2;
                    }
                }
            }
        }

        private void label7_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            l.RemoveAt(0);
        }
        #endregion
        List<Label> pic = new List<Label>();
        List<Label> lab = new List<Label>();
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            ((Label)sender).Image = Image.FromFile(Application.StartupPath +"\\imag\\" + ((Label)sender).Tag);
            ((Label)sender).ForeColor = System.Drawing.Color.White;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            if (lab.Count != 0 && lab[0] == ((Label)sender))
                return;
            if (pic.Where(p => p == ((Label)sender)) != null)
            {
                pic.Add(((Label)sender));
                if (100 - pic.Count * 10 > 0 )
                    timer2.Interval = 100 - pic.Count * 10;
            }
           // ((Label)sender).Image = Image.FromFile("imag\\" + (((Label)sender).Tag+"").Replace (' ','-'));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //获取系统时间
            string time = DateTime.Now + "";
            lblTime.Text = time.Substring(time.IndexOf(' ') + 1);
            if (pic.Count != 0)
            {

                if (lab.Count != 0 && lab[0] == pic[0])
                    return;
                pic[0].Image = Image.FromFile(Application.StartupPath + "\\imag\\" + (pic[0].Tag + "").Replace(' ', '-'));

                pic[0].ForeColor = System.Drawing.Color.Black ;

                pic.RemoveAt(0);
                if (pic == null)
                    timer1.Interval = 100;
            }
        }
       
        private void label1_Click(object sender, EventArgs e)//生成按钮的单击事件
        {
            if (lab.Count != 0)
            {
                lab[0].Image = Image.FromFile(Application.StartupPath + "\\imag\\" + (lab[0].Tag + "").Replace(' ', '-'));
                lab[0].ForeColor = System.Drawing.Color.Black;
                lab.RemoveAt(0);
            }
            lab.Add(((Label)sender));
            if (((Label)sender).Text=="门诊医生")
            {
                panel4.Controls.Clear();
                Prescribe_UI zhu = new Prescribe_UI(lblUname.Text);
                zhu.TopLevel = false;
                this.panel4.Controls.Add(zhu);
                zhu.Show();
            
            }
            else if (((Label)sender).Text == "系统管理")
            
            {
                panel4.Controls.Clear();
                xitongForm zhu = new xitongForm(lblUname.Text);
                zhu.TopLevel = false;
                this.panel4.Controls.Add(zhu);
                zhu.Show();
            
            }
            else if (((Label)sender).Text == "门诊管理") 
            {
                panel4.Controls.Clear();
                clinic zhu = new clinic(lblUname.Text);
                zhu.TopLevel = false;
                this.panel4.Controls.Add(zhu);
                zhu.Show();
            }
            else if (((Label)sender).Text == "财务管理") 
            {
                panel4.Controls.Clear();
                caiwuForm zhu = new caiwuForm(lblUname.Text);
                zhu.TopLevel = false;
                this.panel4.Controls.Add(zhu);
                zhu.Show();
            }
            else if (((Label)sender).Text == "药房管理")
            {
                panel4.Controls.Clear();
                yaofangForm zhu = new yaofangForm(lblUname.Text);
                zhu.TopLevel = false;
                this.panel4.Controls.Add(zhu);
                zhu.Show();
            }
            else if (((Label)sender).Text == "住院管理")
            {
                panel4.Controls.Clear();
                InHospitalzhu zhu = new InHospitalzhu(lblUname.Text);
                zhu.TopLevel = false;
                this.panel4.Controls.Add(zhu);
                zhu.Show();
            }
            else if (((Label)sender).Text == "门诊收费") 
            {
                panel4.Controls.Clear();
                maidanForm zhu = new maidanForm(lblUname.Text);
                zhu.TopLevel = false;
                this.panel4.Controls.Add(zhu);
                zhu.Show();
            
            }
            else if (((Label)sender).Text == "药库管理") 
            {
                panel4.Controls.Clear();
                Drug_Form zhu = new Drug_Form(lblUname.Text);
                zhu.TopLevel = false;
                this.panel4.Controls.Add(zhu);
                zhu.Show();

            }    
        }
        List<Label > btn = new List<Label>();
        private void zhufrom_Load(object sender, EventArgs e)//窗体加载事件
        {

            string str = new IdCard_BLL().p_peodom_select(this.Tag+"");
            str = str.Replace(" ", "");
            string[] strArr = str.Split('-');
            #region 自动生成按钮
            string[] ss = { "门诊医生", "系统管理", "门诊管理", "财务管理", "药房管理", "住院管理", "门诊收费", "药库管理" };
            int i = 38;
            foreach (string  item in ss)
            {
                int num = 0;
                foreach (string   sArr in strArr)
                {
                    if (item == sArr)
                    {
                        num = 1;
                        Label lbl = new Label();
                        lbl.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        lbl.ForeColor = System.Drawing.Color.Black;
                        lbl.Image = Image.FromFile("imag\\Btn-.png");
                        lbl.Location = new System.Drawing.Point(i, 1);
                        lbl.Size = new System.Drawing.Size(152, 52);
                        lbl.Tag = "Btn .png";
                      
                        lbl.Text = item;
                        lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        lbl.Click += new EventHandler(label1_Click);
                        lbl.MouseLeave += new EventHandler(label4_MouseLeave);
                        lbl.MouseMove += new MouseEventHandler(label1_MouseMove);
                        this.panel1.Controls.Add(lbl);
                        i = i + 161;
                        break;
                    }
                    
                }
                if (num == 0)
                {
                    Label lb = new Label();
                    lb.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    lb.ForeColor = System.Drawing.Color.Black;
                    lb.Image = Image.FromFile("imag\\Btn-.png");
                    lb.Location = new System.Drawing.Point(i, 1);
                    lb.Size = new System.Drawing.Size(152, 52);
                    lb.Tag = "Btn .png";
                    lb.Text = item;
                    lb.Enabled = false;
                    lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    lb.Click += new EventHandler(label1_Click);
                    lb.MouseLeave += new EventHandler(label4_MouseLeave);
                    lb.MouseMove += new MouseEventHandler(label1_MouseMove);
                    this.panel1.Controls.Add(lb);
                    i = i + 161;
                }
            }
            #endregion
            
            string Data=(DateTime.Now + "");
            string[] data = (DateTime.Now + "").Substring(0,(DateTime.Now + "").IndexOf (' ')).Split('/');
           // lblData .Text =data[0]+"年"+data[1] +"月"+data[2] +"日 ";
            string date = DateTime.Now.DayOfWeek + "";
            if (date == "Monday") { lblData.Text += "星期一"; }
            else if (date == "Tuesday") { lblData.Text += "星期二"; }
            else if (date == "Wednesday") { lblData.Text += "星期三"; }
            else if (date == "Thursday") { lblData.Text += "星期四"; }
            else if (date == "Friday") { lblData.Text += "星期五"; }
            else if (date == "Saturday") { lblData.Text += "星期六"; }
            else if (date == "Sunday") { lblData.Text += "星期日"; }
            lblUname.Text = this.Tag+"";
            //*******************************
            panel4.Controls.Clear();
            Prescribe_UI zhu = new Prescribe_UI(lblUname.Text);
            zhu.TopLevel = false;
            this.panel4.Controls.Add(zhu);
            zhu.Show();
            foreach (Control  item in panel1.Controls )
            {
                if (item is Label && item.Text == "门诊医生")
                {
                    lab.Add( (Label)item);
                    ((Label)item).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)item).Tag);
                    ((Label)item).ForeColor = System.Drawing.Color.White;
                }
            }
            //*********************************
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int num = 0;
        private void label5_Click(object sender, EventArgs e)
        {
            if (num == 0)
            {
                label5.Image = Image.FromFile(Application.StartupPath+"\\imag\\num1.png");
                label5.Top = 65;
                panel4.Top = 58;
                panel4.Height = panel4.Height + 117 - 58;
                num = 1;
            }
            else
            {

                label5.Image = Image.FromFile(Application.StartupPath + "\\imag\\num0.png");
                label5.Top = 130;
                panel4.Top = 117;
                panel4.Height = panel4.Height - (117 - 58);
                num = 0;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
