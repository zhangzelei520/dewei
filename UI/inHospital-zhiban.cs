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
    public partial class inHospital_zhiban : Form
    {
        public inHospital_zhiban()
        {
            InitializeComponent();
        }
        List<SectionRoom> se;
        List<zhuyuan> zhu;
        private void inHospital_zhiban_Load(object sender, EventArgs e)
        {
            se = new UsersBLL().Section();
            comboBox1.DataSource = se;
            comboBox1.SelectedIndex = 0;
            zhu= new IdCard_BLL().p_zhuyuan_Select();
            foreach (zhuyuan z in zhu)
            {
               ListViewItem item=new ListViewItem (z.kId+"" );
               item.SubItems.Add(z.Kname );
               item.SubItems.Add(se[z.Sid].Sname);
               item.SubItems.Add(z.Idsickroom+"");
               item.SubItems.Add(z.BedNo );
               item.SubItems.Add(z.Imprest+"");
               item.SubItems.Add(z.Bewrite);
               item.SubItems.Add(z.Tabu);
               item.SubItems.Add(z.Ztime);
               lvwzhuyuan.Items.Add(item);    
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
            catch {
                PromptingForm p = new PromptingForm("病人编号只能是数字!");
                p.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lvwzhuyuan.Items.Clear();
            if (zhu.Where(p => p.Sid == comboBox1.SelectedIndex).Count()  == 0)
            {
                PromptingForm p = new PromptingForm("没有数据!");
                p.ShowDialog();
                return;
            }
            foreach (var z in zhu.Where(p => p.Sid == comboBox1.SelectedIndex))
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text== "")
            {
                PromptingForm p = new PromptingForm("请输入姓名!");
                p.ShowDialog();
                return;
            }
            lvwzhuyuan.Items.Clear();
            
            if (zhu.Where(p => p.Kname == (textBox3.Text)).Count() == 0)
            {
                PromptingForm p = new PromptingForm("没有数据!");
                p.ShowDialog();
                return;
            }
            foreach (var z in zhu.Where(p => p.Kname  ==(textBox3.Text) ))
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

        private void button5_Click(object sender, EventArgs e)
        {

            if (textBox5.Text == "")
            {
                PromptingForm p = new PromptingForm("请输入楼房号!");
                p.ShowDialog();
                return;
            }
            lvwzhuyuan.Items.Clear();
            if (zhu.Where(p => (p.Idsickroom + "").Substring(0, 1) == textBox5.Text).Count() == 0)
            {
                PromptingForm p = new PromptingForm("没有数据");
                p.ShowDialog();
                return;
            }
            foreach (var z in zhu.Where(p => ( p.Idsickroom+"").Substring(0,1)  == textBox5.Text ))
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
            if (textBox4.Text == "")
            {
                PromptingForm p = new PromptingForm("请输入病房号!");
                p.ShowDialog();
                return;
            }
            lvwzhuyuan.Items.Clear();
            if (zhu.Where(p => (p.Idsickroom + "") == textBox4.Text).Count() == 0)
            {
                PromptingForm p = new PromptingForm("没有数据");
                p.ShowDialog();
                return;
            }
            foreach (var z in zhu.Where(p => (p.Idsickroom + "") == textBox4.Text))
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

        private void button6_Click(object sender, EventArgs e)
        {
            lvwzhuyuan.Items.Clear();
            inHospital_zhiban_Load(null ,null );
        }
    }
}
