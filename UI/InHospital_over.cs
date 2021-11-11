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
    public partial class InHospital_over : Form
    {
        public InHospital_over()
        {
            InitializeComponent();
        }
        List<zhuyuan> zhu;
        List<SectionRoom> se;
        private void InHospital_over_Load(object sender, EventArgs e)
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

        private void lvwzhuyuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int date = 0;

            lvwselect.Items.Clear();
            if (lvwzhuyuan.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwzhuyuan.SelectedItems[0];
                txtId.Text = item.SubItems[0].Text;
                textBox4.Text = item.SubItems[3].Text;
                textBox4.Tag = item.SubItems[4].Text;
                txtkeshi.Text = item.SubItems[2].Text;
                dTime .Value =  DateTime .Parse ( item.SubItems[8].Text);
                //
                date = int .Parse ((dateTimePicker1.Value - dTime.Value +"").Substring (0,1));
                txtmingzi.Text = item.SubItems[1].Text;
                txtyujiao.Text = item.SubItems[5].Text;
            }
            List<sickroom> ssic = new IdCard_BLL().sickroom_select();
            foreach (sickroom item in ssic.Where(p => p.Idsickroom == int.Parse(textBox4.Text)))
            {
              txtyiyong.Text =  item.Price*( date+1)+"";
            } 

            List<zhuyuanxiaofei> xfs = new IdCard_BLL().p_zhuyuanxiaofei_select(int.Parse(txtId.Text));
            foreach (zhuyuanxiaofei xf in xfs)
            {
                List<Drug_insert> di = new Drug_insert_BLL().SelectAll(xf.yaoName);
                int i = 0;
                ListViewItem item = new ListViewItem(di[i].Dname + "");
                item.SubItems.Add(di[i].Dtype + "");
                item.SubItems.Add(di[i].DcostName + "");
                item.SubItems.Add(xf.yaonum + "");
                item.SubItems.Add(di[i].Dspec + "");
                item.SubItems.Add(di[i].DjiXing + "");
                item.SubItems.Add(di[i].DsellPrice + "");
                item.SubItems.Add(di[i].DeffectTime + "");
                item.SubItems.Add(di[i].DproductTime + "");
                item.SubItems.Add(di[i].Efficay + "");
                lvwselect.Items.Add(item);
                i++;
            }
            int num = 0;
            foreach (ListViewItem item in lvwselect.Items )
            {
                num += int.Parse(item.SubItems[6].Text);  
            }
            textBox3.Text =num+"";
            textBox2.Text = int.Parse(txtyiyong.Text) + int.Parse(textBox3.Text) - int.Parse(txtyujiao.Text) + ""; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                return;
            }
            if (int.Parse(textBox5.Text) - int.Parse(textBox2.Text) >= 0)
            {
                new IdCard_BLL().p_zhuyuanzhuyuanxiaofei_deleted(txtId.Text);
                zhuayuantongji  zhu = new zhuayuantongji();
                zhu.Kid = (txtId.Text);
                zhu.Sname = txtkeshi.Text;
                zhu.time = DateTime.Now+"";
                zhu.ymoney =int .Parse  (textBox3.Text);

                zhu.zmoney = int.Parse(txtyiyong.Text );
                new IdCard_BLL().p_zhuayuantongji_select(zhu);

                new IdCard_BLL().p_bed_update(int.Parse(textBox4.Text), int.Parse(textBox4.Tag +""));
                PromptingForm p = new PromptingForm("出院成功！祝： 你身体健康！");
                p.ShowDialog();
                InHospital_over_Load(null ,null );
                foreach (Control item in groupBox5.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text  = "";
                    }

                }
                lvwselect.Items.Clear();
            }
        }
    }
}
