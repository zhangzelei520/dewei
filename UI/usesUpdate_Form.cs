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
using System.Reflection;  //导入反射的命名空间

namespace UI
{
    public partial class usesUpdate_Form : Form
    {
        public usesUpdate_Form()
        {
            InitializeComponent();
        }
       List < Users> us;
        private void usesUpdate_Form_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            us = new IdCard_BLL().p_users_select01();
            foreach (Users q in us)
            {
                ListViewItem item = new ListViewItem(q.Id  + "");
                //获取q对象中的所有属性
                PropertyInfo[] ps = q.GetType().GetProperties();
                foreach (PropertyInfo p in ps)
                {
                    if (p.Name == "Id" || p.Name == "Pwd")//排除第一个属性
                    {  //获取q对象每个属性对应的值
                        continue;
                    }
                    item.SubItems.Add(p.GetValue(q, null) + "");

                }
                listView1.Items.Add(item);
            }



            List<usersType> type = new IdCard_BLL().p_usesType_select();
            foreach (var item in type)
            {
                comboBox1.Items.Add(item.Type);
            }
            List<SectionRoom> se = new UsersBLL().Section();
            foreach (var item in se)
            {
                comboBox2.Items.Add(item.Sname);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "医师")
            {
                comboBox2.Enabled = true;
                textBox9.Enabled = true;

            }
            else
            {
                comboBox2.Text = "";
                textBox9.Text = "";
                comboBox2.Enabled = false;
                textBox9.Enabled = false;

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                textBox1.Text = item.SubItems[1].Text;
                textBox4.Text = item.SubItems[2].Text;

                if (item.SubItems[3].Text == "男")
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;

                textBox5.Text = item.SubItems[4].Text;
                textBox6.Text = item.SubItems[5].Text;
                textBox7.Text = item.SubItems[6].Text;
                comboBox1.Text = item.SubItems[7].Text;
                comboBox2.Text = item.SubItems[8].Text;
                textBox9.Text = item.SubItems[9].Text;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                new IdCard_BLL().p_users_delete( item.SubItems [0].Text);
                usesUpdate_Form_Load(null,null );
            }
        }
    }
}
