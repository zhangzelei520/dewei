namespace UI
{
    partial class SectionRoomSon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectionRoomSon));
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSectionRoom = new System.Windows.Forms.ComboBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtSonName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaddr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSprice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(265, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 24);
            this.button4.TabIndex = 34;
            this.button4.Text = "添加";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "病例：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 31;
            this.label5.Text = "科别名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 32;
            this.label3.Text = "科别：";
            // 
            // cboSectionRoom
            // 
            this.cboSectionRoom.FormattingEnabled = true;
            this.cboSectionRoom.Location = new System.Drawing.Point(322, 316);
            this.cboSectionRoom.Name = "cboSectionRoom";
            this.cboSectionRoom.Size = new System.Drawing.Size(108, 20);
            this.cboSectionRoom.TabIndex = 29;
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("宋体-方正超大字符集", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(23, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(198, 488);
            this.treeView1.StateImageList = this.imageList1;
            this.treeView1.TabIndex = 28;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "liujiao-1.png");
            this.imageList1.Images.SetKeyName(1, "sanjiao.png");
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(352, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 30);
            this.button3.TabIndex = 25;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 30);
            this.button2.TabIndex = 26;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 30);
            this.button1.TabIndex = 27;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "名称：";
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(334, 62);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(114, 21);
            this.txtSname.TabIndex = 21;
            // 
            // txtSonName
            // 
            this.txtSonName.Location = new System.Drawing.Point(322, 352);
            this.txtSonName.Name = "txtSonName";
            this.txtSonName.Size = new System.Drawing.Size(114, 21);
            this.txtSonName.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "科别：";
            // 
            // txtSaddr
            // 
            this.txtSaddr.Location = new System.Drawing.Point(334, 96);
            this.txtSaddr.Name = "txtSaddr";
            this.txtSaddr.Size = new System.Drawing.Size(114, 21);
            this.txtSaddr.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "科室地址：";
            // 
            // txtSprice
            // 
            this.txtSprice.Location = new System.Drawing.Point(334, 133);
            this.txtSprice.Name = "txtSprice";
            this.txtSprice.Size = new System.Drawing.Size(114, 21);
            this.txtSprice.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 31;
            this.label7.Text = "挂 号 费：";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(334, 175);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 24);
            this.button5.TabIndex = 34;
            this.button5.Tag = "";
            this.button5.Text = "清除";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(406, 175);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 24);
            this.button6.TabIndex = 35;
            this.button6.Text = "修改科室";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // SectionRoomSon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 503);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboSectionRoom);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtSprice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSaddr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.txtSonName);
            this.Controls.Add(this.label1);
            this.Name = "SectionRoomSon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "科室科别增加";
            this.Load += new System.EventHandler(this.SectionRoomSon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSectionRoom;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.TextBox txtSonName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtSaddr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}