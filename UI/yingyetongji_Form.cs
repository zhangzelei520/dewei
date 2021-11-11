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
    public partial class yingyetongji_Form : Form
    {
        public yingyetongji_Form()
        {
            InitializeComponent();
        }
        List<SectionRoom> se;
        List<zhuayuantongji> zhuyuantongji;
        private void yingyetongji_Form_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            se = new UsersBLL().Section();
            comboBox1.DataSource = se;
            zhuyuantongji= new IdCard_BLL().p_zhuayuantongji();
            int i = 0;
            int i1 = 0;
            foreach (zhuayuantongji ite in zhuyuantongji)
            {
                string str = ite.Kid + "";
                if (str.Length < 2)
                {
                    str = "0000" + str;
                }
                ListViewItem item = new ListViewItem(str);
                item.SubItems.Add(ite.Sname );
                item.SubItems.Add(ite.ymoney +"");
                item.SubItems.Add(ite.zmoney +"");
                item.SubItems.Add(ite.time );
                listView1.Items.Add(item);
                i += ite.ymoney;
                i1 += ite.zmoney;
            }
            label5.Text = i + "";
            label3.Text = i1 + "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (!checkBox1.Checked)
            {
                int i1 = 0;
                int i = 0;
                foreach (var ite in zhuyuantongji.Where(p => p.zmoney != 0))
                {
                    string str = ite.Kid + "";
                    if (str.Length < 2)
                    {
                        str = "0000" + str;
                    }
                    ListViewItem item = new ListViewItem(str);
                    item.SubItems.Add(ite.Sname);
                    item.SubItems.Add(ite.ymoney + "");
                    item.SubItems.Add(ite.zmoney + "");
                    item.SubItems.Add(ite.time);
                    listView1.Items.Add(item);
                    i += ite.ymoney;
                    i1 += ite.zmoney;
                }
                label5.Text = i + "";
                label3.Text = i1 + "";
            }

            if (checkBox1.Checked && checkBox2.Checked)
            {
                yingyetongji_Form_Load(null,null);
            }
        }
    }
}
