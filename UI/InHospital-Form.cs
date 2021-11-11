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
    public partial class InHospitalForm : Form
    {
        public InHospitalForm()
        {
            InitializeComponent();
        }
  
          
        private void InHospitalForm_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<sickroom> ssic = new IdCard_BLL().sickroom_select();
           
            foreach (sickroom sic in ssic)
            {
                ListViewItem item = new ListViewItem(sic.Idsickroom + "");
                item.SubItems.Add(sic.Tyep);
                item.SubItems.Add(se[ sic.Sid] + "");
                item.SubItems.Add(sic.Price + "");
                item.ImageIndex = 0;
                listView1.Items.Add(item);
            }
        
        }

        private void 大图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void 小图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void 详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void 块状ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void 缩列图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                listView1.View = View.List;
        }

        private void 类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
            ListViewGroup b = new ListViewGroup("普通病房");
            ListViewGroup m = new ListViewGroup("重病房");
            listView1.Groups.Clear();
            listView1.Groups.Add(b);
            listView1.Groups.Add(m);
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == "普通病房")
                    item.Group = b;
                else if (item.SubItems[1].Text == "重病房")
                    item.Group = m;
            }
        }

        private void 无ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Groups.Clear();
        }
        List<SectionRoom> se = new UsersBLL().Section();
        private void 科别ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
            Dictionary<string , ListViewGroup> Group = new Dictionary<string , ListViewGroup>();
            foreach (SectionRoom item in se)  //按科别分组
            {
                 ListViewGroup G = new ListViewGroup(item.Sname);
                 Group.Add(item.Sname, G);
            }
            listView1.Groups.Clear();
            foreach (ListViewGroup item in Group.Values )//把组添加到ListView1中
            {
                listView1.Groups.Add(item);
            }
            foreach (ListViewItem item in listView1.Items)
            {             
                    item.Group = Group [item.SubItems[2].Text];
            }

        }
  
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<bed> Bed = new IdCard_BLL().Bed_select();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                //判断此行是否被选中
                if (listView1.Items[i].Selected)
                {
                    var result = Bed.Where(p => p.Idsickroom == int.Parse(listView1.Items[i].SubItems[0].Text));
                    listView2.Items.Clear();
                    foreach (var s in result)
                    {
                        ListViewItem item = new ListViewItem(s.Idsickroom+"" );
                        item.SubItems.Add(s.Idbed  + "");
                        item.SubItems.Add(s.KId  + "");
                        item.SubItems.Add(s.State + "");
                        if (s.State == "空")
                            item.ImageIndex = 0;
                        else if (s.State == "占用")
                            item.ImageIndex = 2;
                        else
                            item.ImageIndex = 1;
                        listView2.Items.Add(item);
                    }
                          
                      //    ==  int.Parse (listView1.Items[i].SubItems[0].Text)>; 
                }
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 删除病房ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                PromptingForm p = new PromptingForm("请选择要删除的病房");
                p.ShowDialog();
                return;
            }
            int num = 0;
           
                List<sickroom> sic = new List<sickroom>();
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    //判断此行是否被选中
                    if (listView1.Items[i].Selected)
                    {
                        num++;
                        sickroom s=new sickroom ();
                        s.Idsickroom =int .Parse (listView1.Items[i].SubItems[0].Text+"");
                        sic.Add (s);
                    }
                }
            string str = new IdCard_BLL().Delete(sic);
            if (str == "1")
            {
                PromptingForm prom = new PromptingForm("删除 " + num + "个病房成功");
                InHospitalForm_Load(null,null);
                listView2.Items.Clear();
                prom.ShowDialog();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
