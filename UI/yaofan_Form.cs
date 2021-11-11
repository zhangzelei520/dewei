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
using System.Drawing.Printing;
namespace UI
{
    public partial class yaofan_Form : Form
    {
        public yaofan_Form()
        {
            InitializeComponent();
        }
        List<maidan> maidan;
        private void yaofan_Form_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            maidan = new IdCard_BLL().p_kaiyao_select();
            foreach (maidan item in maidan)
            {
                if (item.zhuangtai == "yes")
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtRid.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[0].Text;
                txtname.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[1].Text;
                //ListViewItem item = new ListViewItem(listView1.Items[listView1.SelectedItems[0].Index].SubItems[0].Text);
                //item.SubItems.Add(listView1.Items[listView1.SelectedItems[0].Index].SubItems[1].Text);
                //item.SubItems.Add(listView1.Items[listView1.SelectedItems[0].Index].SubItems[2].Text);
                //item.SubItems.Add(listView1.Items[listView1.SelectedItems[0].Index].SubItems[3].Text);
                //item.SubItems.Add(listView1.Items[listView1.SelectedItems[0].Index].SubItems[0].Text);
                //listView2.Items.Add(item);
                //listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtRid.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[0].Text;
                txtname.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[1].Text;
                ListViewItem item = new ListViewItem(listView1.Items[listView1.SelectedItems[0].Index].SubItems[0].Text);
                item.SubItems.Add(listView1.Items[listView1.SelectedItems[0].Index].SubItems[1].Text);
                item.SubItems.Add(listView1.Items[listView1.SelectedItems[0].Index].SubItems[2].Text);
                item.SubItems.Add(listView1.Items[listView1.SelectedItems[0].Index].SubItems[3].Text);
                item.SubItems.Add(listView1.Items[listView1.SelectedItems[0].Index].SubItems[0].Text);
                listView2.Items.Add(item);
                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
            }
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Document.DefaultPageSettings.PaperSize = new PaperSize() { Height = 600, Width = 500 };
            printPreviewDialog1.ShowIcon = false;
            printPreviewDialog1.Width = 400;
            printPreviewDialog1.Height = 400;
            printPreviewDialog1.Top = 15;
            printPreviewDialog1.Left = 10;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            Graphics g = e.Graphics;
            // g.DrawImage(Image.FromFile(Application.StartupPath + "//imag//1234.jpg"), 2, 0, 500, 600);

            g.DrawString("挂 单 号：" + txtRid.Text, label5.Font, new SolidBrush(label5.ForeColor), 150, 100);

            g.DrawString("姓    名：" + txtname.Text, label5.Font, new SolidBrush(label5.ForeColor), 100, 160);

            g.DrawString("药    品", label5.Font, new SolidBrush(label5.ForeColor), 100, 220);

            g.DrawString("数    量", label5.Font, new SolidBrush(label5.ForeColor), 250, 220);


            string s = "";
            foreach (var item in maidan.Where(p => p.Rid == txtRid.Text))
            {
                s = item.yaopinName;
                break;
            }
            string[] arr = s.Split('-');
            int num = 220;
            int num2 = 60;
            foreach (string ite in arr)
            {
                if (ite != "")
                {
                    List<Drug_insert> di = new Drug_insert_BLL().SelectAll(ite);
                    for (int i = 0; i < di.Count; )
                    {
                        g.DrawString(di[i].Dname + "", label5.Font, new SolidBrush(label5.ForeColor), 110, num + num2);
                        g.DrawString("1", label5.Font, new SolidBrush(label5.ForeColor), 250, num + num2);
                        num = num + num2;
                        break;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (listView2.SelectedItems.Count > 0)
            {
                string str = listView2.Items[listView2.SelectedItems[0].Index].Text;
                new IdCard_BLL ().p_kaiyaoregister_delete(str);
                listView2.Items.RemoveAt(listView2.SelectedItems[0].Index);
                PromptingForm p = new PromptingForm("药品发药成功");
                p.ShowDialog();

            }
        }
    }
}
