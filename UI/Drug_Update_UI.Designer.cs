namespace UI
{
    partial class Drug_Update_UI
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
            this.dtpDeffectTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDproductTime = new System.Windows.Forms.DateTimePicker();
            this.cboDspec = new System.Windows.Forms.ComboBox();
            this.cboDjiXing = new System.Windows.Forms.ComboBox();
            this.cboDcostName = new System.Windows.Forms.ComboBox();
            this.cboDtype = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDstock = new System.Windows.Forms.TextBox();
            this.txtDinsertPrice = new System.Windows.Forms.TextBox();
            this.txtDname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDstockMin = new System.Windows.Forms.TextBox();
            this.txtDstockMax = new System.Windows.Forms.TextBox();
            this.txtDsellPrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEfficay = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwShow
            // 
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
            this.lvwShow.Location = new System.Drawing.Point(12, 211);
            this.lvwShow.Name = "lvwShow";
            this.lvwShow.Size = new System.Drawing.Size(820, 182);
            this.lvwShow.TabIndex = 39;
            this.lvwShow.UseCompatibleStateImageBehavior = false;
            this.lvwShow.View = System.Windows.Forms.View.Details;
            this.lvwShow.Click += new System.EventHandler(this.lvwShow_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "药品名称";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "药品类型";
            this.columnHeader2.Width = 100;
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
            // dtpDeffectTime
            // 
            this.dtpDeffectTime.Location = new System.Drawing.Point(94, 119);
            this.dtpDeffectTime.Name = "dtpDeffectTime";
            this.dtpDeffectTime.Size = new System.Drawing.Size(143, 21);
            this.dtpDeffectTime.TabIndex = 37;
            // 
            // dtpDproductTime
            // 
            this.dtpDproductTime.Location = new System.Drawing.Point(94, 148);
            this.dtpDproductTime.Name = "dtpDproductTime";
            this.dtpDproductTime.Size = new System.Drawing.Size(143, 21);
            this.dtpDproductTime.TabIndex = 38;
            // 
            // cboDspec
            // 
            this.cboDspec.FormattingEnabled = true;
            this.cboDspec.Items.AddRange(new object[] {
            "片",
            "g"});
            this.cboDspec.Location = new System.Drawing.Point(308, 119);
            this.cboDspec.Name = "cboDspec";
            this.cboDspec.Size = new System.Drawing.Size(69, 20);
            this.cboDspec.TabIndex = 29;
            // 
            // cboDjiXing
            // 
            this.cboDjiXing.FormattingEnabled = true;
            this.cboDjiXing.Items.AddRange(new object[] {
            "片剂"});
            this.cboDjiXing.Location = new System.Drawing.Point(94, 92);
            this.cboDjiXing.Name = "cboDjiXing";
            this.cboDjiXing.Size = new System.Drawing.Size(143, 20);
            this.cboDjiXing.TabIndex = 28;
            // 
            // cboDcostName
            // 
            this.cboDcostName.FormattingEnabled = true;
            this.cboDcostName.Items.AddRange(new object[] {
            "中药费",
            "西药费"});
            this.cboDcostName.Location = new System.Drawing.Point(308, 92);
            this.cboDcostName.Name = "cboDcostName";
            this.cboDcostName.Size = new System.Drawing.Size(69, 20);
            this.cboDcostName.TabIndex = 31;
            // 
            // cboDtype
            // 
            this.cboDtype.FormattingEnabled = true;
            this.cboDtype.Items.AddRange(new object[] {
            "中药",
            "西药"});
            this.cboDtype.Location = new System.Drawing.Point(308, 65);
            this.cboDtype.Name = "cboDtype";
            this.cboDtype.Size = new System.Drawing.Size(69, 20);
            this.cboDtype.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(35, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "生产日期";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(35, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 12);
            this.label12.TabIndex = 27;
            this.label12.Text = "有效日期";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(414, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "库存";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(273, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "进价";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(59, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "剂型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(273, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "规格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(249, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "费用名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(249, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "药品类型";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 15F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(304, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "药品入库表";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "药品名称";
            // 
            // txtDstock
            // 
            this.txtDstock.Location = new System.Drawing.Point(449, 65);
            this.txtDstock.Name = "txtDstock";
            this.txtDstock.Size = new System.Drawing.Size(69, 21);
            this.txtDstock.TabIndex = 10;
            // 
            // txtDinsertPrice
            // 
            this.txtDinsertPrice.Location = new System.Drawing.Point(308, 151);
            this.txtDinsertPrice.Name = "txtDinsertPrice";
            this.txtDinsertPrice.Size = new System.Drawing.Size(69, 21);
            this.txtDinsertPrice.TabIndex = 11;
            // 
            // txtDname
            // 
            this.txtDname.Location = new System.Drawing.Point(94, 65);
            this.txtDname.Name = "txtDname";
            this.txtDname.Size = new System.Drawing.Size(143, 21);
            this.txtDname.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtEfficay);
            this.groupBox1.Controls.Add(this.txtDname);
            this.groupBox1.Controls.Add(this.dtpDeffectTime);
            this.groupBox1.Controls.Add(this.txtDinsertPrice);
            this.groupBox1.Controls.Add(this.dtpDproductTime);
            this.groupBox1.Controls.Add(this.txtDsellPrice);
            this.groupBox1.Controls.Add(this.txtDstock);
            this.groupBox1.Controls.Add(this.cboDspec);
            this.groupBox1.Controls.Add(this.txtDstockMax);
            this.groupBox1.Controls.Add(this.cboDjiXing);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboDcostName);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cboDtype);
            this.groupBox1.Controls.Add(this.txtDstockMin);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 193);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 35);
            this.button1.TabIndex = 39;
            this.button1.Text = "药品修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(414, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "售价";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(390, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "库存上限";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(390, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 12);
            this.label11.TabIndex = 26;
            this.label11.Text = "库存下限";
            // 
            // txtDstockMin
            // 
            this.txtDstockMin.Location = new System.Drawing.Point(449, 119);
            this.txtDstockMin.Name = "txtDstockMin";
            this.txtDstockMin.Size = new System.Drawing.Size(69, 21);
            this.txtDstockMin.TabIndex = 8;
            // 
            // txtDstockMax
            // 
            this.txtDstockMax.Location = new System.Drawing.Point(449, 92);
            this.txtDstockMax.Name = "txtDstockMax";
            this.txtDstockMax.Size = new System.Drawing.Size(69, 21);
            this.txtDstockMax.TabIndex = 7;
            // 
            // txtDsellPrice
            // 
            this.txtDsellPrice.Location = new System.Drawing.Point(449, 151);
            this.txtDsellPrice.Name = "txtDsellPrice";
            this.txtDsellPrice.Size = new System.Drawing.Size(69, 21);
            this.txtDsellPrice.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(524, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 12);
            this.label14.TabIndex = 25;
            this.label14.Text = "病功效";
            // 
            // txtEfficay
            // 
            this.txtEfficay.Location = new System.Drawing.Point(526, 83);
            this.txtEfficay.Multiline = true;
            this.txtEfficay.Name = "txtEfficay";
            this.txtEfficay.Size = new System.Drawing.Size(105, 89);
            this.txtEfficay.TabIndex = 9;
            // 
            // Drug_Update_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(844, 405);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvwShow);
            this.Name = "Drug_Update_UI";
            this.Text = "Drug_Update_UI";
            this.Load += new System.EventHandler(this.Drug_Update_UI_Load);
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
        private System.Windows.Forms.DateTimePicker dtpDeffectTime;
        private System.Windows.Forms.DateTimePicker dtpDproductTime;
        private System.Windows.Forms.ComboBox cboDspec;
        private System.Windows.Forms.ComboBox cboDjiXing;
        private System.Windows.Forms.ComboBox cboDcostName;
        private System.Windows.Forms.ComboBox cboDtype;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDstock;
        private System.Windows.Forms.TextBox txtDinsertPrice;
        private System.Windows.Forms.TextBox txtDname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEfficay;
        private System.Windows.Forms.TextBox txtDsellPrice;
        private System.Windows.Forms.TextBox txtDstockMax;
        private System.Windows.Forms.TextBox txtDstockMin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
    }
}