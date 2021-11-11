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
     
    public partial class feiyong : Form
    {
        public feiyong()
        {
            InitializeComponent();
        }
        List<zhuyuan> zhu;
        List<SectionRoom> se;
        private void feiyong_Load(object sender, EventArgs e)
        {
            lvwzhuyuan.Items.Clear();
            se = new UsersBLL().Section();
           //comboBox1.DataSource = se;
            //comboBox1.SelectedIndex = 0;
            zhu = new IdCard_BLL().p_zhuyuan_Select();
            foreach (zhuyuan z in zhu)
            {
                ListViewItem item = new ListViewItem(z.kId + "");
                item.SubItems.Add(z.Kname);
                item.SubItems.Add(se[z.Sid].Sname);
                item.SubItems.Add(z.Idsickroom + "");
                item.SubItems.Add(z.BedNo);
                item.SubItems.Add(z.Imprest + "");
                item.SubItems.Add(z.Bewrite);
                item.SubItems.Add(z.Tabu);
                item.SubItems.Add(z.Ztime);
                lvwzhuyuan.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    PromptingForm p = new PromptingForm("请输入卡号!");
                    p.ShowDialog();
                    return;
                }
                lvwzhuyuan.Items.Clear();
                if (zhu.Where(p => p.kId == int.Parse(textBox1.Text)).Count() == 0)
                {
                    PromptingForm p = new PromptingForm("没有数据!");
                    p.ShowDialog();
                    return;
                }
                foreach (var z in zhu.Where(p => p.kId == int.Parse(textBox1.Text)))
                {
                    ListViewItem item = new ListViewItem(z.kId + "");
                    item.SubItems.Add(z.Kname);
                    item.SubItems.Add(se[z.Sid].Sname);
                    item.SubItems.Add(z.Idsickroom + "");
                    item.SubItems.Add(z.BedNo);
                    item.SubItems.Add(z.Imprest + "");
                    item.SubItems.Add(z.Bewrite);
                    item.SubItems.Add(z.Tabu);
                    item.SubItems.Add(z.Ztime);
                    lvwzhuyuan.Items.Add(item);
                }

            }
            catch
            {
                PromptingForm p = new PromptingForm("病人编号只能是数字!");
                p.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            feiyong_Load(null,null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                PromptingForm p = new PromptingForm("请输入姓名!");
                p.ShowDialog();
                return;
            }
            lvwzhuyuan.Items.Clear();

            if (zhu.Where(p => p.Kname == (txtName.Text)).Count() == 0)
            {
                PromptingForm p = new PromptingForm("没有数据!");
                p.ShowDialog();
                return;
            }
            foreach (var z in zhu.Where(p => p.Kname == (txtName.Text)))
            {
                ListViewItem item = new ListViewItem(z.kId + "");
                item.SubItems.Add(z.Kname);
                item.SubItems.Add(se[z.Sid].Sname);
                item.SubItems.Add(z.Idsickroom + "");
                item.SubItems.Add(z.BedNo);
                item.SubItems.Add(z.Imprest + "");
                item.SubItems.Add(z.Bewrite);
                item.SubItems.Add(z.Tabu);
                item.SubItems.Add(z.Ztime);
                lvwzhuyuan.Items.Add(item);
            }
        }

        private void lvwzhuyuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvwselect.Items.Clear();
            if (lvwzhuyuan.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwzhuyuan.SelectedItems[0];
                txtId.Text = item.SubItems[0].Text;
                txtkeshi.Text  = item.SubItems[2].Text;
                txttime .Text =item.SubItems [8].Text ;
                txtmingzi .Text =item.SubItems [1].Text ;
                txtyujiao .Text =item.SubItems [5].Text ;

                lvwselect.Visible = true;
                txtyaoping.Enabled = false;
                btninsert.Text = "新单";
                num = 0;
                txtyaoping.Text = "";
            }
            List < zhuyuanxiaofei > xfs = new IdCard_BLL().p_zhuyuanxiaofei_select( int.Parse (txtId.Text));  
            foreach (zhuyuanxiaofei xf in xfs)
            {
                    List<Drug_insert> di = new Drug_insert_BLL().SelectAll(xf.yaoName);
                    int i = 0;
                    ListViewItem item = new ListViewItem(di[i].Dname + "");
                    item.SubItems.Add(di[i].Dtype + "");
                    item.SubItems.Add(di[i].DcostName + "");
                    item.SubItems.Add(xf.yaonum+"");
                    item.SubItems.Add(di[i].Dspec + "");
                    item.SubItems.Add(di[i].DjiXing + "");
                    item.SubItems.Add(di[i].DsellPrice + "");
                    item.SubItems.Add(di[i].DeffectTime + "");
                    item.SubItems.Add(di[i].DproductTime + "");
                    item.SubItems.Add(di[i].Efficay + "");
                    lvwselect.Items.Add(item);
                    i++;
            }
        }
        int num = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            if (num == 0)
            {
                lvwselect.Visible = false;
                txtyaoping.Enabled = true;
                btninsert.Text = "返回";
                num = 1;
                txtyaoping_TextChanged(null,null);

            }
            else
            {
                lvwselect.Visible = true ;
                txtyaoping.Enabled = false ;
                btninsert.Text = "新单";
                num = 0;
            
            }
        }

        private void txtyaoping_TextChanged(object sender, EventArgs e)
        {
            lvwxin.Items.Clear();
            List<Drug_insert> di = new Drug_insert_BLL().SelectAll(txtyaoping.Text);
            for (int i = 0; i < di.Count; i++)
            {
                ListViewItem item = new ListViewItem(di[i].Dname + "");
                item.SubItems.Add(di[i].Dtype + "");
                item.SubItems.Add(di[i].DcostName + "");
                item.SubItems.Add(di[i].Dspec + "");
                item.SubItems.Add(di[i].DjiXing + "");
                item.SubItems.Add(di[i].DsellPrice + "");
                item.SubItems.Add(di[i].DeffectTime + "");
                item.SubItems.Add(di[i].DproductTime + "");
                item.SubItems.Add(di[i].Efficay + "");
                lvwxin.Items.Add(item);
            }
        }

        private void lvwxin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwxin.SelectedItems.Count > 0)
            {
                  ListViewItem item =  lvwxin.SelectedItems[0];
                  textBox11.Text   =item.SubItems[0].Text;
                  textBox12.Text = item.SubItems[3].Text;
                  textBox13.Text = item.SubItems[4].Text;
                  textBox14.Text = item.SubItems[5].Text;
                  textBox15.Text = "1";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox15.Text = int.Parse(textBox15.Text) + 1+""; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox15.Text) - 1 >= 0)
            textBox15.Text = int.Parse(textBox15.Text)  - 1 + ""; 
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (textBox15.Text == "0")
            {
                PromptingForm pm = new PromptingForm("增加的数量不能为0！");
                pm.ShowDialog();
                return;
            }
            if (lvwselect.Visible)
            {
                if (lvwselect.SelectedItems.Count > 0)
                {
                    int i = lvwselect.SelectedItems[0].Index;
                    lvwselect.Items[i].SubItems[3].Text = int.Parse(lvwselect.Items[i].SubItems[3].Text) + int .Parse ( textBox15.Text)  + "";
                    button9_Click(null, null);
                  
                    PromptingForm p = new PromptingForm("添加成功！");
                    p.ShowDialog();
                    textBox15.Text = "0";
                    return;
                }
            }
            foreach (ListViewItem item in lvwselect .Items )
            {
                if (item.SubItems[0].Text == textBox11.Text)
                {
                    item.SubItems[3].Text =int.Parse ( item.SubItems[3].Text) + int.Parse ( textBox15.Text) + "";
                    lvwselect.Visible = true;
                    txtyaoping.Enabled = false;
                    btninsert.Text = "新单";
                    num = 0;
                    textBox15.Text = "0";
                    button9_Click(null, null);
                    
                    PromptingForm p = new PromptingForm("添加成功！");
                    p.ShowDialog();
                    textBox15.Text = "0";
                    return;
                }
                
            }
            if (lvwxin.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwxin.SelectedItems[0];
                ListViewItem newitem = new ListViewItem(item.SubItems [0].Text );
                newitem.SubItems.Add(item.SubItems[1].Text);
                newitem.SubItems.Add(item.SubItems[2].Text);
                newitem.SubItems.Add(textBox15.Text);
                newitem.SubItems.Add(item.SubItems[3].Text);
                
                newitem.SubItems.Add(item.SubItems[4].Text);
                newitem.SubItems.Add(item.SubItems[5].Text);
                newitem.SubItems.Add(item.SubItems[6].Text);
                newitem.SubItems.Add(item.SubItems[7].Text);
                lvwselect.Items.Add(newitem);

                lvwselect.Visible = true;
                txtyaoping.Enabled = false;
                btninsert.Text = "新单";
                num = 0;
                textBox15.Text = "0";
                button9_Click(null, null);
                PromptingForm p = new PromptingForm("添加成功！");
                p.ShowDialog();
                textBox15.Text = "0";
                return;
            }
            PromptingForm pp = new PromptingForm("没有添加信息！");
            pp.ShowDialog();
         
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (lvwselect.SelectedItems.Count > 0)
            {
                
                prom_Form p = new prom_Form("确定要删除？", this );
                p.ShowDialog();
                if (this.Tag + "" == "OK")
                {
                    new IdCard_BLL().p_zhuyuanxiaofei_delete(int.Parse(txtId.Text), lvwselect.SelectedItems[0].Text);
                    lvwselect.Items.RemoveAt(lvwselect.SelectedItems[0].Index);
                    this.Tag = "";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label17.Text = "" + lvwselect.Items.Count;
            int i = 0;
            foreach (ListViewItem  item in lvwselect.Items )
            {
                i += int.Parse(item.SubItems[3].Text) * int.Parse(item.SubItems[6].Text);
            }
            label20.Text = i + ":00";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<zhuyuanxiaofei> xfs = new List<zhuyuanxiaofei>();
            foreach (ListViewItem item in lvwselect.Items)
            {
                zhuyuanxiaofei xf = new zhuyuanxiaofei();
                xf.kId = int .Parse ( txtId.Text);
                xf.yaoName = item.SubItems[0].Text;
                xf.yaonum =int.Parse(item.SubItems[3].Text) ;
                xfs.Add(xf);
                //MessageBox.Show(item.SubItems[3].Text);
            }

            new IdCard_BLL().p_zhuyuanxiaofei_insert(xfs);
        }

        private void lvwselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwselect.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwselect.SelectedItems[0];
                textBox11.Text =  item.SubItems[0].Text;
                textBox12.Text = item.SubItems[4].Text;
                textBox13.Text = item.SubItems[5].Text;
                textBox14.Text = item.SubItems[6].Text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     
    }
}
