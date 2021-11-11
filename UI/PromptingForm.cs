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
    public partial class PromptingForm : Form
    {
        public PromptingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 提示信息
        /// </summary>
        /// <param name="str">提示文字</param>
        public PromptingForm(string str)
        {
            InitializeComponent();
            lblPrompMessage.Text = str;
        }
        /// <summary>
        /// 提示信息、标题
        /// </summary>
        /// <param name="str">提示文字</param>
        /// <param name="str">标题</param>
        public PromptingForm(string str , string title)
        {
            InitializeComponent();
            lblPrompMessage.Text = str;
            lblTitle.Text = title;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
