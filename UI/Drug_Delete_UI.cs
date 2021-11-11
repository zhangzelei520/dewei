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
// 添加命名空间
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace UI
{
    public partial class Drug_Delete_UI : Form
    {
        public Drug_Delete_UI()
        {
            InitializeComponent();
            lvwShow.Items.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDname.Text == "" && lvwShow.SelectedItems.Count == 0)
            {
                PromptingForm p = new PromptingForm("请选择需要删除的数据 !");
                p.ShowDialog();
                return;
            }

            Drug_insert Ddelete = new Drug_insert();
            Ddelete.Dname = txtDname.Text;
            DialogResult dr = MessageBox.Show("确定要删除吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string mes = new Drug_insert_BLL().Delete(Ddelete);
                txtDname.Text = "";
                comboBox1_SelectedIndexChanged(null, null);
                PromptingForm p = new PromptingForm(mes);
                p.ShowDialog();
            }
        }


        private void lvwShow_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvwShow.SelectedItems[0];
            txtDname.Text = item.SubItems[0].Text;
        }

        private void Drug_Delete_UI_Load(object sender, EventArgs e)
        {
            try
            {
                lvwShow.Items.Clear();
                List<Drug_insert> di = new Drug_insert_BLL().SelectAll(txtDname.Text);
                int m = (int)Math.Ceiling(di.Count / 20.0);
                for (int i = 1; i <= m; i++)
                {
                    comboBox1.Items.Add(i + "");
                }
                if (comboBox1.Text == "")
                {
                    comboBox1.Text = "1";
                    return;
                }
            }
            catch { }
        }



        private void button2_Click(object sender, EventArgs e)
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
            comboBox1.Text = 1 + "";
            lvwShow.Items.Clear();
            for (int i = 0; i < di.Count; i++)
            {
                ListViewItem item = new ListViewItem(di[i].Dname + "");
                item.Tag = di[i].Dname;
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

        private void button7_Click(object sender, EventArgs e)
        {
            txtDname.Text = "";
            comboBox1_SelectedIndexChanged(null, null);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvwShow.Items.Clear();
            List<Drug_insert> di = new Drug_insert_BLL().SelectAll(txtDname.Text);
            for (int i = (int.Parse(comboBox1.Text) - 1) * 20; i < 20 * int.Parse(comboBox1.Text); i++)
            {
                if (i < di.Count)
                {
                    ListViewItem item = new ListViewItem(di[i].Dname + "");
                    item.Tag = di[i].Dname;
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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Text = 1 + "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Items.Count + "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "1")
            {
                comboBox1.Text = int.Parse(comboBox1.Text) - 1 + "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != comboBox1.Items.Count + "")
            {
                comboBox1.Text = int.Parse(comboBox1.Text) + 1 + "";
            }
        }
        // 定义全局变量
        Excel.Application App = new Excel.Application();
        Excel.Workbook wb;
        Excel._Worksheet ws;
        object misValue = System.Reflection.Missing.Value;
        // 自定义创建新excel文件的函数
        public bool createNewFile(string newFileName)
        {
            if (App == null)
            {
                MessageBox.Show("无法创建excel对象，请检查您的系统是否安装了excel。");
                return false;
            }
            App.DisplayAlerts = true;
            App.Visible = false; // invisible
            wb = new Excel.Workbook();
            App.Workbooks.Add(wb);
            return true;
        }
        // 保存excel文件
        public void saveFile(string newFileName)
        {
            wb.SaveAs(newFileName, Excel.XlFileFormat.xlWorkbookNormal, misValue,
                       misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive,
                       misValue, misValue, misValue, misValue, misValue);
            wb.Close(true, misValue, misValue);
            App.DisplayAlerts = false;
            App.AlertBeforeOverwriting = false;
            App.Quit();
            MessageBox.Show("文件已经生成。");
            //System.Diagnostics.Process.Start("E:\\");
        }
        // 按照一格一格写入的方式自定义函数
        public void writeCell(string sheet, int row, int col, string cont)
        {
            ws = wb.Sheets[sheet];
            ws.Activate();
            ws.Cells[row, col] = cont;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            int nRow = lvwShow.Items.Count;
            int nCol = lvwShow.Columns.Count;
            if (nRow == 0)
            {
                MessageBox.Show("保存错误，没有任何数据。");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "药品出库.xlsx";//设置默认文件名
            sfd.DefaultExt = "xlsx";//设置默认格式（可以不设）
            sfd.AddExtension = true;//设置自动在文件名中添加扩展名
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                List<List<string>> data = new List<List<string>>();
                for (int i = 0; i < nRow; i++)
                {
                    List<string> line = new List<string>();
                    //line.Add(lvwShow.Items[i].Tag.ToString());
                    for (int j = 0; j < nCol; j++)
                    {
                        line.Add(lvwShow.Items[i].SubItems[j].Text);
                    }
                    data.Add(line);
                }
                SaveToeExcel(sfd.FileName, data);
            }
        }

        public bool SaveToeExcel(string fileName, List<List<string>> data)
        {
            Excel.Application excel = new Excel.Application();
            if (excel == null)
            {
                MessageBox.Show("无法创建Excel对象,可能您的计算机未安装Excel!");
                return false;
            }
            try
            {
                excel.Application.Workbooks.Add(true);
                Worksheet worksheet = excel.ActiveSheet;
                //填充数据              
                for (int i = 0; i < data.Count; i++)
                {
                    for (int j = 0; j < data[i].Count; j++)
                    {
                        excel.Cells[i+1, j+1] = "'" + Convert.ToString(data[i][j]);
                        (excel.Cells[i+1, j+1] as Range).HorizontalAlignment = XlHAlign.xlHAlignLeft;//字段居中
                    }
                }
                worksheet.SaveAs(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            catch(Exception ex) 
            {
                Console.WriteLine("", ex);
            }
            finally
            {
                excel.Quit();
                excel = null;
                GC.Collect();
            }
            //KillProcess("Excel");
            MessageBox.Show("保存成功!");
            return true;
        }

    }
}
