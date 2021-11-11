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
    public partial class Prescribe_UI : Form
    {
        List<Drug_insert> di;
        string s;
        string kroom;
        public Prescribe_UI(string str)
        {
            InitializeComponent();
            s = new IdCard_BLL().p_peodom_select(str+ "");
            //List<Users>  us = new IdCard_BLL().p_users_select01();
            //Users  u =  us.Single(p => p.Uname == str);
            //kroom = u.SectionRoom;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            lvwSelect.Items.Clear();
            di = new Drug_insert_BLL().SelectAll(txtSelect.Text);
            di.Where(p => p.Dtype == "中药");
            for (int i = 0; i < di.Count; i++)
            {
                ListViewItem item = new ListViewItem(i + 1 + "");
                item.SubItems.Add(di[i].Dname + "");
                item.SubItems.Add(di[i].Dspec + "");
                item.SubItems.Add(di[i].DjiXing + "");
                item.SubItems.Add(di[i].DsellPrice + "");
                item.SubItems.Add(di[i].Efficay + "");
                lvwSelect.Items.Add(item);
            }
        }
        void yy()
        {
            int count = 1;
            foreach (ListViewItem i in lvwYaofang.Items)
            {
                i.SubItems[0].Text = count + "";
                count++;
            }
        }
        void ww()
        {
            int count = 1;
            foreach (ListViewItem i in lvwYaofang2.Items)
            {
                i.SubItems[0].Text = count + "";
                count++;
            }
        }
        private void lvwSelect_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            yy();

            ListViewItem no = lvwSelect.SelectedItems[0];
            string s = no.SubItems[1].Text;
            foreach (ListViewItem ite in lvwYaofang.Items)
            {
                if (s == ite.SubItems[1].Text)
                {
                    PromptingForm p = new PromptingForm("已经添加了该药品 !");
                    p.ShowDialog();
                    return;
                }
            }
            ListViewItem item = new ListViewItem(lvwYaofang.Items.Count + 1 + "");
            item.SubItems.Add(no.SubItems[1].Text);
            item.SubItems.Add(no.SubItems[2].Text);
            item.SubItems.Add(no.SubItems[3].Text);
            item.SubItems.Add(no.SubItems[4].Text);
            item.SubItems.Add(no.SubItems[5].Text);
            lvwYaofang.Items.Add(item);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwYaofang.SelectedItems.Count == 0)
            {
                PromptingForm p = new PromptingForm("请选中要删除的药品 !");
                p.ShowDialog();
                return;
            }

            int deleteNo = int.Parse(lvwYaofang.SelectedItems[0].Text);
            lvwYaofang.Items.RemoveAt(deleteNo - 1);
            yy();
        }

        private void btnJinji_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems .Count ==0)
                return;
            txtJinji.Text += listBox1.SelectedItems[0] + "，";
            listBox1.Visible = false;
        }

        private void btnYongfa_Click(object sender, EventArgs e)
        {
            listBox2.Visible = true;
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 0)
                return;
            txtJinji.Text += listBox2.SelectedItems[0] + "，";
            listBox2.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lvwSelect2.Items.Clear();
            di = new Drug_insert_BLL().SelectAll(txtSelect2.Text);
            int i = 0;
            foreach (var d in di.Where(p => p.Dtype == "西药"))
            {
                ListViewItem item = new ListViewItem(i + 1 + "");
                item.SubItems.Add(d.Dname + "");
                item.SubItems.Add(d.Dspec + "");
                item.SubItems.Add(d.DjiXing + "");
                item.SubItems.Add(d.DsellPrice + "");
                item.SubItems.Add(d.Efficay + "");
                lvwSelect2.Items.Add(item);
                i++;
            }
            //for (int i = 0; i < di.Count; i++)
            //{
            //    ListViewItem item = new ListViewItem(i + 1 + "");
            //    item.SubItems.Add(di[i].Dname + "");
            //    item.SubItems.Add(di[i].Dspec + "");
            //    item.SubItems.Add(di[i].DjiXing + "");
            //    item.SubItems.Add(di[i].DsellPrice + "");
            //    item.SubItems.Add(di[i].Efficay + "");
            //    lvwSelect2.Items.Add(item);
            //}
        }

        private void lvwSelect2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ww();

            ListViewItem no = lvwSelect2.SelectedItems[0];
            string s = no.SubItems[1].Text;
            foreach (ListViewItem ite in lvwYaofang2.Items)
            {
                if (s == ite.SubItems[1].Text)
                {
                    PromptingForm p = new PromptingForm("已经添加了该药品 !");
                    p.ShowDialog();
                    return;
                }
            }
            ListViewItem item = new ListViewItem(lvwYaofang2.Items.Count + 1 + "");
            item.SubItems.Add(no.SubItems[1].Text);
            item.SubItems.Add(no.SubItems[2].Text);
            item.SubItems.Add(no.SubItems[3].Text);
            item.SubItems.Add(no.SubItems[4].Text);
            item.SubItems.Add(no.SubItems[5].Text);
            lvwYaofang2.Items.Add(item);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lvwYaofang2.SelectedItems.Count == 0)
            {
                PromptingForm p = new PromptingForm("请选中要删除的药品 !");
                p.ShowDialog();
                return;
            }

            int deleteNo = int.Parse(lvwYaofang2.SelectedItems[0].Text);
            lvwYaofang2.Items.RemoveAt(deleteNo - 1);
            ww();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Visible = true;
        }

        private void listBox3_Click(object sender, EventArgs e)
        {
            txtJinji2.Text += listBox3.SelectedItems[0] + "，";
            listBox3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox4.Visible = true;
        }

        private void listBox4_Click(object sender, EventArgs e)
        {
            txtJinji2.Text += listBox4.SelectedItems[0] + "，";
            listBox4.Visible = false;
        }
        List<SectionRoom> se;
        List<SectionRoomSo> sw;
        private void Prescribe_UI_Load(object sender, EventArgs e)
        {
            List<Register> lRegi = new Register_BLL().SelectAll();
            foreach (Register lR in lRegi)
            {
                //if (kroom == lR.SectionRoom)
                //{
                    ListViewItem item = new ListViewItem(lR.Rid);
                    item.SubItems.Add(lR.KId + "");
                    item.SubItems.Add(lR.IdType);
                    item.SubItems.Add(lR.GuaDanFei + "");
                    item.SubItems.Add(lR.OtherFei + "");
                    item.SubItems.Add(lR.SectionRoom);
                    item.SubItems.Add(lR.Doctor);
                    item.SubItems.Add(lR.ReristerTime);
                    item.SubItems.Add(lR.SeeDoctorTime);
                    lvwGuahaoShow.Items.Add(item);
                //}
            }


            se = new UsersBLL().Section();
            treeView1.Nodes.Clear();

            sw = new SectionRoomSonBLL().Section();

            foreach (SectionRoom item in se)
            {

                TreeNode n = new TreeNode(item.Sname);
                n.ImageIndex = 0;
                treeView1.Nodes.Add(n);
                foreach (SectionRoomSo it in sw)
                {
                    if (it.Sname == item.Sname)
                    {
                        n.Nodes.Add(it.SonSname).ImageIndex = 1;
                    }

                }
            }
        }

        private void lvwGuahaoShow_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvwGuahaoShow.SelectedItems[0];
            txtRid.Text = item.SubItems[0].Text;
            txtKId.Text = item.SubItems[1].Text;
            txtIdType.Text = item.SubItems[2].Text;
            txtGuaDanFei.Text = item.SubItems[3].Text;
            txtOtherFei.Text = item.SubItems[4].Text;
            txtSectionRoom.Text = item.SubItems[5].Text;
            txtDoctor.Text = item.SubItems[6].Text;
            dtpReristerTime.Text = item.SubItems[7].Text;
            dtpSeeDoctorTime.Text = item.SubItems[8].Text;

            List<IdCard> Lic = new Prescribe_BLL().SelectAll(int.Parse(txtKId.Text));
            txtName.Text = Lic[0].Name;
            txtSex.Text = Lic[0].Sex;
            txtAge.Text = Lic[0].Age+"";
            txtAddress.Text = Lic[0].Address;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtKId.Text == "" || txtRid.Text == "")
            {
                MessageBox.Show("请先选择挂号单 !");
                return;
            }
            foreach (Control item in tabPage2.Controls)
            {
                if (item is TextBox)
                    if (item.Text == "")
                    {
                        MessageBox.Show("请把病历填写完整 !");
                        return;
                    }
            }
            Bingli Bl = new Bingli();
            Bl.kId = int.Parse(txtKId.Text);
            Bl.Rid = txtRid.Text;
            Bl.bing = txtChenduan.Text;
            Bl.zhusu = txtZhushu.Text;
            Bl.xianbingshi = txtXianbingshi.Text;
            Bl.jiwangbingshi = txtJiwangshi.Text;
            Bl.guominshi = txtGuominshi.Text;
            Bl.geirenshi = txtGerenshi.Text;
            Bl.jiatingshi = txtJiatingshi.Text;
            Bl.tijian = txtTijian.Text;
            Bl.fuzhu = txtFuzhu.Text;
            Bl.zhiliaojianyi = txtJianyi.Text;

            string mes = new Prescribe_BLL().Bingli_Insert(Bl);
            MessageBox.Show(mes);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtKId.Text == "" || txtRid.Text == "")
            {
                MessageBox.Show("请先选择挂号单 !");
                return;
            }
            if (txtYizhu.Text == "" || txtJinji.Text == "")
            {
                MessageBox.Show("请把药方填写完整 !");
                return;
            }
            string ypName = "";
            foreach (ListViewItem item in lvwYaofang.Items)
            {
                ypName += item.SubItems[1].Text + "-";
            }
            kaiyao ky = new kaiyao();
            ky.Rid = txtRid.Text;
            ky.Kid = int.Parse(txtKId.Text);
            ky.yaopinName = ypName;
            ky.zhuangtai = "no";
            ky.yizhu = txtYizhu.Text;
            ky.yongfa = txtJinji.Text;
            lvwGuahaoShow.Items.RemoveAt(0);
            string mes = new Prescribe_BLL().kaiyao_Insert(ky);
            MessageBox.Show(mes);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
          
            foreach (SectionRoomSo item in sw)
            {
                if (treeView1.SelectedNode != null)
                {
                    if (treeView1.SelectedNode.Text == item.SonSname)
                    {
                        txtChenduan.Text =item.Sname + item.SonSname;
                        //txtSonName.Text = item.SonSname;
                        //cboSectionRoom.Text = ;
                    }
                }
            }
        }

        private void lvwGuahaoShow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
