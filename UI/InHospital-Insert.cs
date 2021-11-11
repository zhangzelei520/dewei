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
    public partial class InHospitalInsert : Form
    {
        public InHospitalInsert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control  item in groupBox1 . Controls)
            {
                if (checkBox1.Checked)
                {
                    if (item.Text == "" && item.Name != "txtnum")
                    {
                        PromptingForm frmPrompting = new PromptingForm("请输入完整！");
                        frmPrompting.ShowDialog();
                        return;
                    }
                }
                else
                {
                    if(item.Name == "txtlou1" || item.Name == "txtlou2" || item.Name == "txtfang1" || item.Name == "txtfang2")
                    {
                        break;
                    }
                    if (item.Text == "")
                    {
                        PromptingForm frmPrompting = new PromptingForm("请输入完整！");
                        frmPrompting.ShowDialog();
                        return;
                    }
                    
                }
            }


            List<sickroom> sics = new List<sickroom>();//要添加的病房放到sics集合中
            if (checkBox1.Checked)
            {
                for (int i = int.Parse(txtlou1.Text); i <= int.Parse(txtlou2.Text); i++)
                {
                    for (int j = int.Parse(txtfang1.Text); j <= int.Parse(txtfang2.Text); j++)
                    {
                        sickroom sic = new sickroom();
                        if (j > 9)
                            sic.Idsickroom = int.Parse("" + i + j);
                        else
                            sic.Idsickroom = int.Parse("" + i + 0 + j);
                        sic.Sid = cboKeshi.SelectedIndex;
                        sic.Tyep = cboType.Text;
                        sic.Price = int.Parse(txtPrice.Text);
                        sics.Add(sic);
                    }
                }
            }
            else
            {
                sickroom sic = new sickroom();
                sic.Idsickroom = int.Parse(txtnum.Text );
                sic.Sid = cboKeshi.SelectedIndex;
                sic.Tyep = cboType.Text;
                sic.Price = int.Parse(txtPrice.Text);
                sics.Add(sic);  
            }
            int num=int.Parse (txtBFnum .Text );
            string str = new IdCard_BLL().sickroom(sics ,num);
            PromptingForm prop = new PromptingForm(str);
            prop.ShowDialog();
           
        }

        private void InHospitalInsert_Load(object sender, EventArgs e)
        {
             
            List<SectionRoom> se = new UsersBLL().Section();
            cboKeshi.DataSource = se;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtnum.Enabled = false;
                txtlou1.Enabled = true;
                txtlou2.Enabled = true;
                txtfang1.Enabled = true;
                txtfang2.Enabled = true;
            }
            else
            {
                txtnum.Enabled = true;
                txtlou1.Enabled = false ;
                txtlou2.Enabled = false;
                txtfang1.Enabled = false;
                txtfang2.Enabled = false;
            
            }
        }
    }
}
