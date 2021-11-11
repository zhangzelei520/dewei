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
    public partial class SectionRoomSon : Form
    {
        public SectionRoomSon()
        {
            InitializeComponent();
        }
        List<SectionRoom> se;
        List<SectionRoomSo> sw;
       
        private void SectionRoomSon_Load(object sender, EventArgs e)
        {
           
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
                    if (it.Sname==item.Sname)
                    {
                        n.Nodes.Add(it.SonSname).ImageIndex=1;
                        
                    }
                    
                } 
            }
            cboSectionRoom.DataSource = se;           
            
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtSaddr.Text == "" && txtSname.Text == "" && txtSprice.Text == "")

                return;     
           
            treeView1.Nodes.Clear();
            SectionRoom s = new SectionRoom();
            s.Sname = txtSname.Text;
            s.Saddr = txtSaddr.Text;
            s.Sprice =int.Parse( txtSprice.Text);
            string result= new SectionRoomBLL().Chuan(s);
            if (result==1+"")
                se.Add(s);
            else
              MessageBox.Show(result);
            SectionRoomSon_Load(null,null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            treeView1.Nodes.Clear();
            SectionRoomSo w = new SectionRoomSo();
            w.Sname = cboSectionRoom.Text;
            w.SonSname = txtSonName.Text;
            string str= new SectionRoomSonBLL().Son(w);
            if (str=="")
            {
                sw.Add(w);
                
            }
            else
                MessageBox.Show(str);           
            SectionRoomSon_Load(null, null);
       }
      
        private void button3_Click(object sender, EventArgs e)
        {
            
            SectionRoomSo s = new SectionRoomSo();
            foreach (SectionRoomSo item in sw)
            {
                if (treeView1.SelectedNode.Text==item.SonSname)
                {
                    s.SonSname = item.SonSname;
                    treeView1.Nodes.Remove(treeView1.SelectedNode);
                    sw.Remove(item);
                    txtSonName.Text = "";
                    new SectionRoomSonBLL().SonDelet(s);
                   
                    return;
                }    
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //foreach (SectionRoomSo item in sw)
            //{
            //    if (treeView1.SelectedNode != null)
            //    {
            //        if (treeView1.SelectedNode.Text == item.SonSname)
            //        {
            //            txtSonName.Text = item.SonSname;
            //            cboSectionRoom.Text = item.Sname;
            //        }
            //    }
            //}
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            foreach (SectionRoom item in se)
            {
                if (treeView1.SelectedNode!=null)
                {
                    if (treeView1.SelectedNode.Text==item.Sname)
                    {
                        txtSaddr.Text = item.Saddr;
                        txtSprice.Text = item.Sprice+"";
                        txtSname.Text = item.Sname;
                    }
                }
            }
            foreach (SectionRoomSo item in sw)
            {
                if (treeView1.SelectedNode != null)
                {
                    if (treeView1.SelectedNode.Text == item.SonSname)
                    {
                        txtSonName.Text = item.SonSname;
                        cboSectionRoom.Text = item.Sname;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtSaddr.Text = "";
            txtSprice.Text = "";
            txtSname.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SectionRoomDelete s = new SectionRoomDelete();
            s.ShowDialog();
        }  
    }
}
