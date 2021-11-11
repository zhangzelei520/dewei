namespace UI
{
    partial class BillPrintForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillPrintForm));
            this.panlWork = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.gbAll = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panlWork
            // 
            this.panlWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panlWork.Location = new System.Drawing.Point(3, 17);
            this.panlWork.Name = "panlWork";
            this.panlWork.Size = new System.Drawing.Size(252, 478);
            this.panlWork.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(73, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(108, 21);
            this.txtTitle.TabIndex = 4;
            // 
            // gbAll
            // 
            this.gbAll.Location = new System.Drawing.Point(275, 44);
            this.gbAll.Name = "gbAll";
            this.gbAll.Size = new System.Drawing.Size(89, 347);
            this.gbAll.TabIndex = 2;
            this.gbAll.TabStop = false;
            this.gbAll.Text = "打印项目";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(275, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(276, 465);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(67, 30);
            this.btnFont.TabIndex = 3;
            this.btnFont.Text = "字体";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(276, 499);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(67, 30);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "颜色";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panlWork);
            this.groupBox4.Location = new System.Drawing.Point(11, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 498);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "设计区";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(276, 431);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(67, 30);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "预览";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "标题文本:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(370, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 531);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "预览区";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "添加项目";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(194, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 7;
            // 
            // BillPrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 543);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BillPrintForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "账单设计";
            this.Load += new System.EventHandler(this.BillPrintForm_Load);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panlWork;
        private System.Windows.Forms.GroupBox gbAll;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtName;
    }
}