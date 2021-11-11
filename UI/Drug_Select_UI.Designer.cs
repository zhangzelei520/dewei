namespace UI
{
    partial class Drug_Select_UI
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
            this.lvwShow = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboDjiXing = new System.Windows.Forms.ComboBox();
            this.cboDtype = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblypcx = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDsellPrice = new System.Windows.Forms.TextBox();
            this.txtDinsertPrice = new System.Windows.Forms.TextBox();
            this.txtDname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwShow
            // 
            this.lvwShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwShow.BackColor = System.Drawing.SystemColors.Control;
            this.lvwShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader8,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lvwShow.ForeColor = System.Drawing.Color.Black;
            this.lvwShow.FullRowSelect = true;
            this.lvwShow.Location = new System.Drawing.Point(12, 150);
            this.lvwShow.Name = "lvwShow";
            this.lvwShow.Size = new System.Drawing.Size(820, 243);
            this.lvwShow.TabIndex = 39;
            this.lvwShow.UseCompatibleStateImageBehavior = false;
            this.lvwShow.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "药品名称";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "药品类型";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "费用名称";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "规格";
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "剂型";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "进价";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "售价";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "库存";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "库存上限";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "库存下限";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "生产日期";
            this.columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "有效日期";
            this.columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "病功效";
            this.columnHeader13.Width = 100;
            // 
            // cboDjiXing
            // 
            this.cboDjiXing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboDjiXing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDjiXing.FormattingEnabled = true;
            this.cboDjiXing.Items.AddRange(new object[] {
            "片剂"});
            this.cboDjiXing.Location = new System.Drawing.Point(583, 60);
            this.cboDjiXing.Name = "cboDjiXing";
            this.cboDjiXing.Size = new System.Drawing.Size(87, 20);
            this.cboDjiXing.TabIndex = 28;
            // 
            // cboDtype
            // 
            this.cboDtype.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboDtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDtype.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboDtype.FormattingEnabled = true;
            this.cboDtype.Items.AddRange(new object[] {
            "中药",
            "西药"});
            this.cboDtype.Location = new System.Drawing.Point(360, 63);
            this.cboDtype.Name = "cboDtype";
            this.cboDtype.Size = new System.Drawing.Size(69, 20);
            this.cboDtype.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(301, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "售价:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(29, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "进    价:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(514, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "剂    型:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(300, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "药品类型:";
            // 
            // lblypcx
            // 
            this.lblypcx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblypcx.AutoSize = true;
            this.lblypcx.Font = new System.Drawing.Font("宋体", 15F);
            this.lblypcx.ForeColor = System.Drawing.Color.Black;
            this.lblypcx.Location = new System.Drawing.Point(334, 18);
            this.lblypcx.Name = "lblypcx";
            this.lblypcx.Size = new System.Drawing.Size(89, 20);
            this.lblypcx.TabIndex = 19;
            this.lblypcx.Text = "药品查询";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "药品名称:";
            // 
            // txtDsellPrice
            // 
            this.txtDsellPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDsellPrice.Location = new System.Drawing.Point(362, 93);
            this.txtDsellPrice.Name = "txtDsellPrice";
            this.txtDsellPrice.Size = new System.Drawing.Size(69, 21);
            this.txtDsellPrice.TabIndex = 13;
            // 
            // txtDinsertPrice
            // 
            this.txtDinsertPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDinsertPrice.Location = new System.Drawing.Point(91, 92);
            this.txtDinsertPrice.Name = "txtDinsertPrice";
            this.txtDinsertPrice.Size = new System.Drawing.Size(109, 21);
            this.txtDinsertPrice.TabIndex = 11;
            // 
            // txtDname
            // 
            this.txtDname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDname.Location = new System.Drawing.Point(91, 65);
            this.txtDname.Name = "txtDname";
            this.txtDname.Size = new System.Drawing.Size(109, 21);
            this.txtDname.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtDname);
            this.groupBox1.Controls.Add(this.txtDinsertPrice);
            this.groupBox1.Controls.Add(this.txtDsellPrice);
            this.groupBox1.Controls.Add(this.cboDjiXing);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblypcx);
            this.groupBox1.Controls.Add(this.cboDtype);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 132);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Location = new System.Drawing.Point(583, 93);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 24);
            this.button5.TabIndex = 39;
            this.button5.Text = "显示全部";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.Location = new System.Drawing.Point(437, 93);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 24);
            this.button6.TabIndex = 39;
            this.button6.Text = "药品查询";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(437, 59);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 24);
            this.button4.TabIndex = 39;
            this.button4.Text = "药品查询";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(206, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 24);
            this.button3.TabIndex = 39;
            this.button3.Text = "药品查询";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(676, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 24);
            this.button2.TabIndex = 39;
            this.button2.Text = "药品查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(206, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 24);
            this.button1.TabIndex = 39;
            this.button1.Text = "药品查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // Drug_Select_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(844, 405);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvwShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Drug_Select_UI";
            this.Text = "Drug_Select_UI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Drug_Select_UI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwShow;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ComboBox cboDjiXing;
        private System.Windows.Forms.ComboBox cboDtype;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblypcx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDsellPrice;
        private System.Windows.Forms.TextBox txtDinsertPrice;
        private System.Windows.Forms.TextBox txtDname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;

    }
}