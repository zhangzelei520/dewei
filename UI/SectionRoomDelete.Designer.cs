namespace UI
{
    partial class SectionRoomDelete
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Sname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Saddr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSprice = new System.Windows.Forms.TextBox();
            this.txtSaddr = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sname,
            this.Saddr,
            this.Sprice});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(373, 155);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Sname
            // 
            this.Sname.Text = "科室";
            this.Sname.Width = 103;
            // 
            // Saddr
            // 
            this.Saddr.Text = "科室地址";
            this.Saddr.Width = 115;
            // 
            // Sprice
            // 
            this.Sprice.Text = "挂号费";
            this.Sprice.Width = 127;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 35;
            this.label7.Text = "挂号费：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 36;
            this.label6.Text = "科室地址：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 37;
            this.label5.Text = "科别名称：";
            // 
            // txtSprice
            // 
            this.txtSprice.Location = new System.Drawing.Point(93, 293);
            this.txtSprice.Name = "txtSprice";
            this.txtSprice.Size = new System.Drawing.Size(114, 21);
            this.txtSprice.TabIndex = 33;
            // 
            // txtSaddr
            // 
            this.txtSaddr.Location = new System.Drawing.Point(93, 250);
            this.txtSaddr.Name = "txtSaddr";
            this.txtSaddr.Size = new System.Drawing.Size(114, 21);
            this.txtSaddr.TabIndex = 32;
            // 
            // txtSname
            // 
            this.txtSname.Enabled = false;
            this.txtSname.Location = new System.Drawing.Point(93, 202);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(114, 21);
            this.txtSname.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 49);
            this.button1.TabIndex = 39;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 49);
            this.button2.TabIndex = 39;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SectionRoomDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 355);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSprice);
            this.Controls.Add(this.txtSaddr);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.listView1);
            this.Name = "SectionRoomDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SectionRoomInsert";
            this.Load += new System.EventHandler(this.SectionRoomDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSprice;
        private System.Windows.Forms.TextBox txtSaddr;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader Sname;
        private System.Windows.Forms.ColumnHeader Saddr;
        private System.Windows.Forms.ColumnHeader Sprice;
    }
}