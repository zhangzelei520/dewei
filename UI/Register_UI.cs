using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Model;
using BLL;
using System.Drawing.Printing;
using System.Configuration;
namespace UI
{
    public partial class Register_UI : Form
    {
        public Register_UI()
        {
            InitializeComponent();
        }
        List<SectionRoom> se;
        private void Register_UI_Load(object sender, EventArgs e)
        {
            se= new UsersBLL().Section();
            cboSectionRoom.DataSource = se;
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["strCon"].ToString());
            SqlCommand cmd = new SqlCommand();
            con.Open();
            string str = "select top 1 Rid from Register order by Rid desc";
            cmd.Connection = con;
            cmd.CommandText = str;
            string id = cmd.ExecuteScalar() + "";
            if (id != "")
            {
                string oldId = id.Substring(1);
                int intOldId = Convert.ToInt32(oldId);

                intOldId += 1;
                string strResult = "";
                switch ((intOldId + "").Length)
                {
                    case 1:
                        strResult = "000" + intOldId;
                        break;
                    case 2:
                        strResult = "00" + intOldId;
                        break;
                    case 3:
                        strResult = "0" + intOldId;
                        break;
                    default:
                        strResult = "编号不够了，请升级软件";
                        break;
                }
                txtRid.Text = strResult;

              

            }
            else
                txtRid.Text = "0001";
            con.Close();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is Label)
                    continue;
                else
                {
                    if (item.Text == "")
                    {
                        PromptingForm p = new PromptingForm("请填写完整信息");
                        p.ShowDialog();
                        return;
                    }

                }

            }
            Register r = new Register();
            r.Rid = txtRid.Text;
            r.KId = int.Parse(txtKid.Text);
            r.IdType = cboIdType.Text;
            r.SectionRoom = cboSectionRoom.Text + "";
            r.Doctor = cboDoctor.Text;
            r.GuaDanFei = int.Parse(txtGuaHaoFei.Text);
            r.OtherFei = int.Parse(txtOtherFei.Text);
            r.ReristerTime = dtpReristerTime.Text;
            r.SeeDoctorTime = dtpSeeDoctorTime.Text;
            string s = new UsersBLL().RegisterRew(r);
            PromptingForm prom = new PromptingForm(s);
            prom.ShowDialog();
            if (cheguadan.Checked && s=="挂号成功")
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.Document.DefaultPageSettings.PaperSize = new PaperSize() { Height = 600, Width = 500 };
                printPreviewDialog1.ShowIcon = false;
                printPreviewDialog1.Width = 400;
                printPreviewDialog1.Height = 400;
                printPreviewDialog1.Top = 15;
                printPreviewDialog1.Left = 10;
                printPreviewDialog1.ShowDialog();
           }
        }

        private void cboSectionRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            us = new IdCard_BLL().p_users_select01();
            cboDoctor.Items.Clear();
            cboDoctor.Text = "";
            foreach (Users q in us.Where(p => p.SectionRoom == cboSectionRoom.Text))//))
            {
                cboDoctor.Items.Add(q.name);
            }
            //txtGuaHaoFei.Text = se[cboSectionRoom.SelectedIndex].Sprice + "";
        }

        private void txtKid_TextChanged(object sender, EventArgs e)
        {
            IdCard IC = new IdCard();
            if (txtKid.Text == "")
                return;
            IC.Kid = int.Parse(txtKid.Text);    
            Dictionary<int,IdCard> Cd= new IdCard_BLL().IdCard(IC);
            foreach (int  item in Cd.Keys)
            {
                if (int.Parse(txtKid.Text)==item)
                {
                    if (txtKid.Text.Length == 5)
                    {
                        txtName.Text = Cd[int.Parse(txtKid.Text)].Name;
                        txtAge.Text = Cd[int.Parse(txtKid.Text)].Age + "";
                        txtPostcode.Text = Cd[int.Parse(txtKid.Text)].Postcode;
                        txtIdcardNo.Text = Cd[int.Parse(txtKid.Text)].IdcardNo;
                        cboCultrue.Text = Cd[int.Parse(txtKid.Text)].Cultrue;
                        cboNation.Text = Cd[int.Parse(txtKid.Text)].Nation;
                        txtPhone.Text = Cd[int.Parse(txtKid.Text)].Phone;
                        cboWork.Text = Cd[int.Parse(txtKid.Text)].Work;
                        txtAddress.Text = Cd[int.Parse(txtKid.Text)].Address;
                        if (Cd[int.Parse(txtKid.Text)].Sex == "女")
                        {
                            rdoGirl.Checked = true;
                        }
                        else
                            rdoBoy.Checked = true;
                        if (Cd[int.Parse(txtKid.Text)].Marriage == "未婚")
                        {
                            rdoMarriageNo.Checked = true;
                        }
                        else
                            rdoMarriageYes.Checked = true;
                    }
                    else
                        return;
                }
            }
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Register_UI_Load(null,null);
            foreach (Control item in groupBox1.Controls)
            {
                if (item is Label || item is DateTimePicker || item is CheckBox )
                {
                    continue;
                }
                else
                {
                    if (item.Name !="txtRid")
                    {
                        item.Text = "";  
                    }
                    
                }
            }
            foreach (Control item in groupBox2.Controls)
            {
                if (item is Label || item is DateTimePicker)
                {
                    continue;
                }
                else
                    item.Text = "";
            }
            txtOtherFei.Text = 0 + "";
            txtGuaHaoFei.Text = 0 + "";
            
        }

     

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Image.FromFile(Application.StartupPath + "//imag//1234.jpg"), 2, 0, 500, 600);
            
            g.DrawString("挂 单 号：" + txtRid.Text, label9.Font, new SolidBrush(label15.ForeColor), 150, 180);

            g.DrawString("姓    名：" + txtName.Text, label9.Font, new SolidBrush(label15.ForeColor), 100, 240);

            g.DrawString("主诊医生：" + cboDoctor.Text , label9.Font, new SolidBrush(label15.ForeColor), 100, 300);

            g.DrawString("科    室：" + cboSectionRoom.Text, label9.Font, new SolidBrush(label15.ForeColor),100, 360);

            g.DrawString("科 地 址：" + se[cboSectionRoom.SelectedIndex].Saddr, label9.Font, new SolidBrush(label15.ForeColor), 100, 420);

            g.DrawString("挂 号 费：" + txtGuaHaoFei.Text , label9.Font, new SolidBrush(label15.ForeColor), 100, 480);            
            
        }
        List<Users> us;
        private void cboIdType_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void cboDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Users q in us.Where(p => p.SectionRoom == cboSectionRoom.Text).Where(p => p.name == cboDoctor.Text))
            {
                txtGuaHaoFei.Text = q.money + "";
            }
        }

       

        

        

       
    }
}
