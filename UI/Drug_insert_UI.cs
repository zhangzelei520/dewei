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
    public partial class Drug_insert_UI : Form
    {
        public Drug_insert_UI()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if(item is TextBox)
                if (item.Text == "")
                    {
                        PromptingForm p = new PromptingForm("请把信息填写完整 !");
                        p.ShowDialog();
                        return;
                    }
                if (item is ComboBox)
                if (item.Text == "")
                {
                    PromptingForm p = new PromptingForm("请把信息填写完整 !");
                    p.ShowDialog();
                
                    return;
                }
            }

            Drug_insert Dinsert = new Drug_insert();
            Dinsert.Dname = txtDname.Text;
            Dinsert.Dtype = cboDtype.Text;
            Dinsert.DcostName = cboDcostName.Text;
            Dinsert.Dspec =cboDspec.Text;
            Dinsert.DjiXing = cboDjiXing.Text;
            Dinsert.DinsertPrice = int.Parse(txtDinsertPrice.Text);
            Dinsert.DsellPrice = int.Parse(txtDsellPrice.Text);
            Dinsert.Dstock = int.Parse(txtDstock.Text);
            Dinsert.DstockMax=int.Parse(txtDstockMax.Text);
            Dinsert.DstockMin=int.Parse(txtDstockMin.Text);
            Dinsert.DeffectTime=dtpDproductTime.Text;
            Dinsert.DproductTime = dtpDeffectTime.Text;
            Dinsert.Efficay = txtEfficay.Text;

            string mes = new Drug_insert_BLL().Insert(Dinsert);
            txtDname.Text = "";
            btnSelect_Click(null, null);
            PromptingForm pp = new PromptingForm(mes);
            pp.ShowDialog();
          
        }

        private void Drug_insert_UI_Load(object sender, EventArgs e)
        {
            btnSelect_Click(null, null);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            lvwShow.Items.Clear();
            List<Drug_insert> di = new Drug_insert_BLL().SelectAll(txtDname.Text);
            for (int i = 0; i < di.Count; i++)
            {
                ListViewItem item = new ListViewItem(di[i].Dname + "");
                item.SubItems.Add(di[i].Dtype + "");
                item.SubItems.Add(di[i].DcostName + "");
                item.SubItems.Add(di[i].Dspec + "");
                item.SubItems.Add(di[i].DjiXing + "");
                item.SubItems.Add(di[i].DinsertPrice + "");
                item.SubItems.Add(di[i].DsellPrice + "");
                item.SubItems.Add(di[i].Dstock + "");
                item.SubItems.Add(di[i].DstockMax + "");
                item.SubItems.Add(di[i].DstockMin + "");
                item.SubItems.Add(di[i].DeffectTime + "");
                item.SubItems.Add(di[i].DproductTime + "");
                item.SubItems.Add(di[i].Efficay + "");
                lvwShow.Items.Add(item);
            }
        }

        private void lvwShow_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvwShow.SelectedItems[0];
            txtDname.Text = item.SubItems[0].Text;
            cboDtype.Text = item.SubItems[1].Text;
            cboDcostName.Text = item.SubItems[2].Text;
            cboDspec.Text = item.SubItems[3].Text;
            cboDjiXing.Text = item.SubItems[4].Text;
            txtDinsertPrice.Text = item.SubItems[5].Text;
            txtDsellPrice.Text = item.SubItems[6].Text;
            txtDstock.Text = item.SubItems[7].Text;
            txtDstockMax.Text = item.SubItems[8].Text;
            txtDstockMin.Text = item.SubItems[9].Text;
            dtpDeffectTime.Text = item.SubItems[10].Text;
            dtpDproductTime.Text = item.SubItems[11].Text;
            txtEfficay.Text = item.SubItems[12].Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDname.Text == "")
            {
                PromptingForm p = new PromptingForm("请选择需要修改的数据 !");
                p.ShowDialog();
                return;
            }
            Drug_insert Dupdate = new Drug_insert();
            Dupdate.Dname = txtDname.Text;
            Dupdate.Dtype = cboDtype.Text;
            Dupdate.DcostName = cboDcostName.Text;
            Dupdate.Dspec = cboDspec.Text;
            Dupdate.DjiXing = cboDjiXing.Text;
            Dupdate.DinsertPrice = int.Parse(txtDinsertPrice.Text);
            Dupdate.DsellPrice = int.Parse(txtDsellPrice.Text);
            Dupdate.Dstock = int.Parse(txtDstock.Text);
            Dupdate.DstockMax = int.Parse(txtDstockMax.Text);
            Dupdate.DstockMin = int.Parse(txtDstockMin.Text);
            Dupdate.DeffectTime = dtpDproductTime.Text;
            Dupdate.DproductTime = dtpDeffectTime.Text;
            Dupdate.Efficay = txtEfficay.Text;
            string mes = new Drug_insert_BLL().Update(Dupdate);
            
            button3_Click(null, null);
            PromptingForm pp = new PromptingForm(mes);
            pp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtDname.Text == "")
            {
                PromptingForm p = new PromptingForm("请输入药品名字！");
                p.ShowDialog();
                return;
            }
            lvwShow.Items.Clear();
            List<Drug_insert> di = new Drug_insert_BLL().SelectAll(txtDname.Text);
            if (di.Count == 0)
            {

                PromptingForm p = new PromptingForm("没有你要查找的数据！");
                p.ShowDialog();
                return;
            }
            for (int i = 0; i < di.Count; i++)
            {
                ListViewItem item = new ListViewItem(di[i].Dname + "");
                item.SubItems.Add(di[i].Dtype + "");
                item.SubItems.Add(di[i].DcostName + "");
                item.SubItems.Add(di[i].Dspec + "");
                item.SubItems.Add(di[i].DjiXing + "");
                item.SubItems.Add(di[i].DinsertPrice + "");
                item.SubItems.Add(di[i].DsellPrice + "");
                item.SubItems.Add(di[i].Dstock + "");
                item.SubItems.Add(di[i].DstockMax + "");
                item.SubItems.Add(di[i].DstockMin + "");
                item.SubItems.Add(di[i].DeffectTime + "");
                item.SubItems.Add(di[i].DproductTime + "");
                item.SubItems.Add(di[i].Efficay + "");
                lvwShow.Items.Add(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDname.Text = "";
            Drug_insert_UI_Load(null, null);
        }

    }
}
