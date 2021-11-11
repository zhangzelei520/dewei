using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using System.Drawing.Printing;
using Model;
namespace UI
{
    public partial class BillPrintForm : Form
    {
        public BillPrintForm()
        {
            InitializeComponent();
        }
        public BillPrintForm(string s)
        {
            InitializeComponent();
            txtTitle.Text = s;
        }
        bool mouseDown;
        Point p;
        Font selectFont;
        Color selectColor;
        BillPrintBLL billPrintBLL;
        PromptingForm frmPrompting;

        private void lblBillId_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                p =e.Location;
            }
        }

        private void lblBillId_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mouseDown = false;
        }

        private void lblBillId_MouseMove(object sender, MouseEventArgs e)
        {
            //if (e.Y <= 0 || e.Y - ((Label)sender).Height >= panlWork.Height || e.X <= 0 || e.X - ((Label)sender).Width >= panlWork.Width)
            //    return;
            if (mouseDown)
            {
                p.Offset(e.X - 10, e.Y - 5);
                ((Label)sender).Location = p;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                selectFont = font.Font;
                foreach (Label item in panlWork.Controls)
                {
                    item.Font = selectFont;
                }
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                selectColor = color.Color;
                foreach (Label item in panlWork.Controls)
                {
                    item.ForeColor = selectColor;
                }
            }
        }
        private void chkBillId_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Label item in panlWork.Controls)
            {
                if (item.Text == ((CheckBox)sender).Text)
                    item.Visible = ((CheckBox)sender).Checked;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<MyControl> controls = new List<MyControl>();
            foreach (Label item in panlWork.Controls)
            {
                if (item.Visible)
                {
                    MyControl myControl = new MyControl();
                    myControl.Name= item.Text;
                    myControl.CLocation = item.Location.X +","+ item.Location.Y;
                    myControl.CFont = item.Font.Name +","+ item.Font.Style +","+ item.Font.Size;
                    myControl.CColor = item.ForeColor.R + "," + item.ForeColor.G + "," + item.ForeColor.B;
                    controls.Add(myControl);
                }
            }
            billPrintBLL = new BillPrintBLL();
            billPrintBLL.SaveControl(controls);
            frmPrompting = new PromptingForm("保存成功！");
            frmPrompting.Show();
        }

        private void BillPrintForm_Load(object sender, EventArgs e)
        {
            int i = 15 ;
            List<string> str = new IdCard_BLL().controls_select();
            foreach (string item in str)
            {
                CheckBox che = new CheckBox();
                che.AutoSize = true;
               // che.Location = new System.Drawing.Point(6, 86);
                che.Size = new System.Drawing.Size(72, 16);
                che.Top = i ;
                che.Left = 10;
                che.TabIndex = 0;
                che.Text = item;
                che.UseVisualStyleBackColor = true;
                che.CheckedChanged += new System.EventHandler(this.chkBillId_CheckedChanged);
                this.gbAll.Controls.Add(che);

                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.BackColor = System.Drawing.Color.Transparent;
                lbl.Cursor = System.Windows.Forms.Cursors.Hand;
               // lbl.Location = new System.Drawing.Point(6, 179);
                lbl.Size = new System.Drawing.Size(53, 24);
                lbl.Top = i;
                lbl. Left = 10;
                lbl.Text = item;
                lbl.Visible = false;
                lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblBillId_MouseDown);
                lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblBillId_MouseMove);
                lbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblBillId_MouseUp);
                this.panlWork.Controls.Add(lbl);
                i = i + 20;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Graphics g = e.Graphics;
            g.DrawImage(Image.FromFile(Application.StartupPath + "//imag//1234.jpg"), 2, 0, 500, 600);
            foreach (CheckBox  item in gbAll .Controls )
            {
                
                if (item.Checked)
                {
                   
                    foreach (Label lbl in panlWork.Controls)
                    {
                        if (item.Text == "标题")
                        {
                            g.DrawString(txtTitle.Text, lbl.Font, new SolidBrush(lbl.ForeColor), lbl.Location.X, lbl.Location.Y);
                            break;
                        }
                        else  if (item.Text == lbl.Text)
                        {
                            g.DrawString(item.Text, lbl.Font, new SolidBrush(lbl.ForeColor), lbl.Location.X, lbl.Location.Y);
                        }
                    }
                   
                }

            }

            //if (chkTitle.Checked)
            //    g.DrawString(txtTitle.Text, lblBillId.Font, new SolidBrush(lblBillId.ForeColor), lblTitle.Location.X, lblTitle.Location.Y);

            //if (chkBillId.Checked)
            //    g.DrawString(lblBillId.Text + ": 00001", lblBillId.Font, new SolidBrush(lblBillId.ForeColor), lblBillId.Location.X, lblBillId.Location.Y);

            //if (chkEndTime.Checked)
            //    g.DrawString(lblEndtime.Text + ": " + DateTime.Now, lblBillId.Font, new SolidBrush(lblBillId.ForeColor), lblEndtime.Location.X, lblEndtime.Location.Y);

            //if (chkStartTime.Checked)
            //    g.DrawString(lblStartTime.Text + ": " + DateTime.Now, lblBillId.Font, new SolidBrush(lblBillId.ForeColor), lblStartTime.Location.X, lblStartTime.Location.Y);

            //if (chkStaName.Checked)
            //    g.DrawString(lblStaName.Text + ": 100001", lblBillId.Font, new SolidBrush(lblBillId.ForeColor), lblStaName.Location.X, lblStaName.Location.Y);

            //if (chkRoomId.Checked)
            //    g.DrawString(lblRoomId.Text + ": 101", lblBillId.Font, new SolidBrush(lblBillId.ForeColor), lblRoomId.Location.X, lblRoomId.Location.Y);

            //if (chkVip.Checked)
            //    g.DrawString(lblVip.Text + ": 000", lblBillId.Font, new SolidBrush(lblBillId.ForeColor), lblVip.Location.X, lblVip.Location.Y);

            //if (chkMoney.Checked)
            //    g.DrawString(lblMoney.Text + ": 1.00￥", lblBillId.Font, new SolidBrush(lblBillId.ForeColor), lblMoney.Location.X, lblMoney.Location.Y);
        
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Document.DefaultPageSettings.PaperSize = new PaperSize() { Height = 600, Width = 500 };
          //  printPreviewDialog1.Document.DefaultPageSettings.PaperSize = new PaperSize() { Height = panlWork.Height, Width = panlWork.Width };
            printPreviewDialog1.ShowIcon = false;
            printPreviewDialog1.Width = 400;
            printPreviewDialog1.Height = 400;
            printPreviewDialog1.Top = 15;
            printPreviewDialog1.Left  = 10;
            printPreviewDialog1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            printPreviewDialog1.TopLevel = false;
            groupBox1.Controls.Add(printPreviewDialog1);
            printPreviewDialog1.Show();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new IdCard_BLL().controls_select();
        }

    }
}
