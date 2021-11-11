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
    public partial class maidanForm : Form
    {
        string s = "";
        public maidanForm(string str)
        {
            InitializeComponent();
            s = new IdCard_BLL().p_peodom_select(str + "");
            string[] ss = s.Split('-');
            foreach (Control item in groupBox3.Controls)
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


        List<maidan> maidan;
        private void timer1_Tick(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            maidan =new IdCard_BLL().p_kaiyao_select();
            foreach (maidan item in maidan)
            {
                if (item.zhuangtai == "no")
                {
                    ListViewItem i = new ListViewItem(item.Rid);
                    i.SubItems.Add(item.Name);
                    i.SubItems.Add(item.Sex);
                    i.SubItems.Add(item.SectionRoom);
                    i.SubItems.Add(item.IdcardNo);
                    listView1.Items.Add(i);
                }
            }
        }
        List<SectionRoom> se;
        private void maidanForm_Load(object sender, EventArgs e)
        {
            se = new UsersBLL().Section();
            cboroom.DataSource = se;
            timer1_Tick(null, null);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1 .SelectedItems .Count >0)
            {
                string str=listView1 .Items [listView1 .SelectedItems [0].Index ].Text ;
                string s="";
                foreach (var item in maidan.Where(p => p.Rid == str))
	            {
                    txtdoct.Text = item.Doctor;
                    txtidno.Text = item.IdcardNo;
                    txtname.Text = item.Name;
                    txtRid.Text = item.Rid;
                    cboroom.Text = item.SectionRoom;
                    cbosex.Text = item.Sex;
                    s = item.yaopinName;
                    break;         
	            }
                string []arr = s.Split('-');
                listView2.Items.Clear();
                int num = 0;
                foreach (string ite in arr)
                {
                    if (ite != "")
                    {
                        List<Drug_insert> di = new Drug_insert_BLL().SelectAll(ite);
                        for (int i = 0; i < di.Count; i++)
                        {
                            ListViewItem item = new ListViewItem(di[i].Dname + "");
                            item.SubItems.Add(di[i].DsellPrice + "");
                            item.SubItems.Add("1");
                            listView2.Items.Add(item);
                            num += int .Parse (di[i].DsellPrice+"") * 1;
                        }
                    }
                }
                textBox4.Text = num + "";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (textBox5.Text == "")
                {
                    textBox6.Text = "";
                    return;
                }
                textBox6.Text = int.Parse(textBox5.Text) - int.Parse(textBox4.Text) + "";
            }
            catch {

                PromptingForm p = new PromptingForm("请正确输入金钱！");
                p.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRid.Text == "")
            {
                PromptingForm pf = new PromptingForm("没有要结账病人信息！");
                pf.ShowDialog();
                return;
            }
            if (textBox6.Text == "")
            {
                PromptingForm pm = new PromptingForm("付款金额不足！");
                pm.ShowDialog();
                return;
            }
            if (int.Parse(textBox6.Text) <0)
            {
                PromptingForm pm = new PromptingForm("付款金额不足！");
                pm.ShowDialog();
                return;
            }
            prom_Form p=new prom_Form ("确定结账",this);
            p.ShowDialog ();
            if (this.Tag + "" == "OK")
            {
                new IdCard_BLL().p_kaiyao_update(txtRid.Text);
                PromptingForm pp=new PromptingForm ("结账成功!请到药房取药!");
                pp.ShowDialog();




                zhuayuantongji zhu = new zhuayuantongji();
                zhu.Kid = (txtRid.Text);
                zhu.Sname = cboroom.Text;
                zhu.time = DateTime.Now + "";
                zhu.ymoney = int.Parse(textBox4.Text);
                zhu.zmoney = 0;
                new IdCard_BLL().p_zhuayuantongji_select(zhu);






                maidanForm_Load(null ,null );
                foreach (Control item in groupBox3.Controls)
                {
                    if (item is TextBox || item is ComboBox)
                    {
                        item.Text = "";
                    }
                }
                listView2.Items.Clear();
            }

            //*************************************************

             
        }
    }
}
