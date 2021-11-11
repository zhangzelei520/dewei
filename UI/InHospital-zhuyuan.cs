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
    public partial class InHospitalzhuyuan : Form
    {
        public InHospitalzhuyuan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control  item in groupBox1 . Controls)
            {
                if ((item is TextBox || item is ComboBox) && item.Text == "")
                {
                    PromptingForm prom = new PromptingForm("请把信息填完整！");
                    prom.ShowDialog();
                    return;
                }
            }
            zhuyuan zhu = new zhuyuan();
            zhu.kId = int.Parse (txtKId.Text);
            zhu.Idsickroom =int .Parse ( cbobingfang.Text );
            zhu.Sid = cboKebie.SelectedIndex;
            zhu.BedNo = cbobingchuang.Text;
            zhu.Imprest = int.Parse (txtyujiaofei.Text);
            zhu.Bewrite = txtmiaoshu.Text;
            zhu.Tabu = txtjinji.Text;
            zhu.Ztime = DateTime.Now.ToString();
            string str= new IdCard_BLL().p_zhuyuan_insert(zhu);
            PromptingForm p = new PromptingForm(str);
            p.ShowDialog();

        }
        List<sickroom> ssic = new IdCard_BLL().sickroom_select();
        List<SectionRoom> se = new UsersBLL().Section();
        private void InHospitalzhuyuan_Load(object sender, EventArgs e)
        {
           
            cboKebie.DataSource = se;

        }

        private void cboKebie_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbobingfang.Items.Clear();
            cbobingchuang.Items.Clear();
            txtyujiaofei.Text = "";
             foreach (var item in ssic.Where(p => p.Sid == cboKebie.SelectedIndex))
            {
                cbobingfang.Items.Add(item.Idsickroom);       
            }
           
        }

        private void cbobingfang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbobingchuang .Items.Clear();
            txtyujiaofei.Text = "";
            List<bed> Bed = new IdCard_BLL().Bed_select();
            if (cbobingfang.Text != "")
            {
                foreach (var item in Bed.Where(p => p.Idsickroom == int.Parse(cbobingfang.Text)))
                {
                    if (item.State == "空")
                        cbobingchuang.Items.Add(item.Idbed);
                }
            }
        }

        private void cbobingchuang_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in ssic.Where(p=>p.Idsickroom == int.Parse (cbobingfang.Text)))
            {
                txtyujiaofei.Text=item.Price+"";
            }
          ;
        }
    }
}
