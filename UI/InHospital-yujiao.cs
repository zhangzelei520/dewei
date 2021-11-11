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
    public partial class InHospital_yujiao : Form
    {
        public InHospital_yujiao()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            List<zhuyuan> zhu = new IdCard_BLL().p_zhuyuan_Select();
            List<SectionRoom> se = new UsersBLL().Section();
             txtID2.Text = "";
             txtmingzi2.Text="";
             txtyujiao2.Text = "";
            foreach (Control  item in groupBox4 .Controls )
            {
                if (item is TextBox)
                    item.Text = "";
            }
            foreach (Control item in groupBox3.Controls)
            {
                item.Enabled = false ;
            }
            try
            {
                if (textBox1.Text == "")
                {
                    PromptingForm p = new PromptingForm("请输入卡号!");
                    p.ShowDialog();
                    return;
                }
                if (zhu.Where(p => p.kId == int.Parse(textBox1.Text)).Count() == 0)
                {
                    PromptingForm p = new PromptingForm("没有数据!");
                    p.ShowDialog();
                    return;
                }
                foreach (var z in zhu.Where(p => p.kId == int.Parse(textBox1.Text)))
                {
                    txtId.Text = z.kId + "";
                    txtmingzi.Text = z.Kname;
                    txtkeshi.Text =(se[z.Sid].Sname);
                    txttime.Text =(z.Ztime  + "");
                    txtyujiao.Text =(z.Imprest + "");
                   
                }
                List<zhuyuanxiaofei> xfs = new IdCard_BLL().p_zhuyuanxiaofei_select(int.Parse(txtId.Text));
                int i = 0;
                foreach (zhuyuanxiaofei xf in xfs)
                {
                    List<Drug_insert> di = new Drug_insert_BLL().SelectAll(xf.yaoName);
                    i=i+ int.Parse (xf.yaonum + "")*int.Parse (di[0].DsellPrice + "");
                }
                txtyiyong.Text = i + "";
                txtshengyu.Text = int.Parse(txtyujiao.Text) - int.Parse(txtyiyong.Text) + "";
            }
            catch
            {
                PromptingForm p = new PromptingForm("病人编号只能是数字!");
                p.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
                return;
            foreach (Control item in groupBox3.Controls)
            {
                item.Enabled = true;
            }
            txtID2.Text      =  txtId.Text;
            txtmingzi2.Text = txtmingzi.Text;

              
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                 int i=int .Parse(txtyujiao .Text ) + int.Parse(txtyujiao2.Text);
                 new IdCard_BLL().update_zhuyuan_yujiao( i , txtID2 .Text);
                 PromptingForm p = new PromptingForm("交款成功!");
                 p.ShowDialog();
            }
            catch 
            {
               PromptingForm p=new PromptingForm ("请输入正确金额！");
                p.ShowDialog ();
            }
        }
    }
}
