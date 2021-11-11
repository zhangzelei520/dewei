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
//|5|1|a|s|p|x
namespace UI
{
    public partial class IdCard_UI : Form
    {
        public IdCard_UI()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox || item is ComboBox)
                    if (item.Text == "")
                    {
                        PromptingForm p = new PromptingForm("请把信息填写完整！");
                        p.ShowDialog();
                        return;
                    }
            }


            IdCard IC = new IdCard();
            IC.Name = txtName.Text;
            if (rdoBoy.Checked)
                IC.Sex = rdoBoy.Text;
            else
                IC.Sex = rdoGirl.Text;
            IC.Age = int.Parse( txtAge.Text);
            IC.Birthday = dtpBrithday.Text;
            IC.Address = txtAddress.Text;
            IC.Phone = (txtPhone.Text);
            IC.Nation = cboNation.Text;
            IC.Cultrue = cboCultrue.Text;
            if (rdoMarriageYes.Checked)
                IC.Marriage = rdoMarriageYes.Text;
            else
                IC.Marriage = rdoMarriageNo.Text;
            IC.Work = cboWork.Text;
            IC.Postcode = (txtPostcode.Text);
            IC.IdcardNo = txtIdcardNo.Text;

            string mes = new IdCard_BLL().Reg(IC);


            string s = new IdCard_BLL().p_IdCard_select();
        
            PromptingForm pp = new PromptingForm("注册成功!卡号为："+ s );
            pp.ShowDialog();
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IdCard_UI_Load(object sender, EventArgs e)
        {

        }
    }
}
