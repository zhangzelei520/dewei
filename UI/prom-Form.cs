using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class prom_Form : Form
    {
        Form fo;
        public prom_Form(string str ,Form f)
        {
            InitializeComponent();
            lblxinxi.Text = str;
            fo = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fo.Tag = "OK";
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
      

    
    }
}
