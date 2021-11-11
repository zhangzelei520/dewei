using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Model;
using BLL;

namespace UI
{
    public partial class SectionRoomDelete : Form
    {
        public SectionRoomDelete()
        {
            InitializeComponent();
        }
        List<SectionRoom> se; 
        private void SectionRoomDelete_Load(object sender, EventArgs e)
        {
            se= new UsersBLL().Section();
            foreach (SectionRoom item in se)
            {
                ListViewItem it = new ListViewItem(item.Sname);
                PropertyInfo [] pt= item.GetType().GetProperties();
                foreach (PropertyInfo po in pt)
                {
                    if (po.Name!="Sname" && po.Name!="Sid")
                    {
                        it.SubItems.Add(po.GetValue(item,null)+"");
                    }
                }
                listView1.Items.Add(it);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SectionRoom s = new SectionRoom();
            if (listView1.SelectedItems.Count > 0)
            {
                int i = listView1.SelectedItems[0].Index ;
                s.Sname = listView1.Items[i].Text + ""; 
               new SectionRoomBLL().Delete(s);
            }
            listView1.Items.Clear();
            SectionRoomDelete_Load(null, null);

            PromptingForm  p= new PromptingForm("删除成功");
            p.ShowDialog();
            txtSname.Text = "";
            txtSaddr.Text = "";
            txtSprice.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SectionRoom s = new SectionRoom();
            s.Sname = txtSname.Text;
            s.Saddr = txtSaddr.Text;
            s.Sprice =int.Parse( txtSprice.Text);
            new SectionRoomBLL().Update(s);
            listView1.Items.Clear();
            SectionRoomDelete_Load(null, null);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
            if (listView1.SelectedItems.Count>0)
            {  
                txtSname.Text = listView1.Items[listView1.SelectedItems[0].Index].Text;
                txtSaddr.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems [1]. Text;
                txtSprice.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[2].Text;    
            }
            
        }

        
    }
}
