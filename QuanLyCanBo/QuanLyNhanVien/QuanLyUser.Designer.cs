namespace QuanLyNhanVien
{
    partial class QuanLyUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.btnadduser = new System.Windows.Forms.Button();
            this.btnupdateuser = new System.Windows.Forms.Button();
            this.btndeleteuser = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.dtguser = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtguser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(112, 23);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(186, 20);
            this.txtusername.TabIndex = 4;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(112, 65);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(186, 20);
            this.txtpassword.TabIndex = 5;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(112, 105);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(115, 20);
            this.txtphone.TabIndex = 6;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(112, 147);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(258, 88);
            this.txtaddress.TabIndex = 7;
            // 
            // btnadduser
            // 
            this.btnadduser.Location = new System.Drawing.Point(428, 23);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(75, 32);
            this.btnadduser.TabIndex = 8;
            this.btnadduser.Text = "Thêm User";
            this.btnadduser.UseVisualStyleBackColor = true;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // btnupdateuser
            // 
            this.btnupdateuser.Location = new System.Drawing.Point(428, 76);
            this.btnupdateuser.Name = "btnupdateuser";
            this.btnupdateuser.Size = new System.Drawing.Size(75, 31);
            this.btnupdateuser.TabIndex = 9;
            this.btnupdateuser.Text = "Update User";
            this.btnupdateuser.UseVisualStyleBackColor = true;
            this.btnupdateuser.Click += new System.EventHandler(this.btnupdateuser_Click);
            // 
            // btndeleteuser
            // 
            this.btndeleteuser.Location = new System.Drawing.Point(428, 126);
            this.btndeleteuser.Name = "btndeleteuser";
            this.btndeleteuser.Size = new System.Drawing.Size(75, 34);
            this.btndeleteuser.TabIndex = 10;
            this.btndeleteuser.Text = "Delete User";
            this.btndeleteuser.UseVisualStyleBackColor = true;
            this.btndeleteuser.Click += new System.EventHandler(this.btndeleteuser_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(428, 175);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 31);
            this.btn.TabIndex = 11;
            this.btn.Text = "Cancel";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // dtguser
            // 
            this.dtguser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtguser.Location = new System.Drawing.Point(28, 19);
            this.dtguser.Name = "dtguser";
            this.dtguser.Size = new System.Drawing.Size(485, 150);
            this.dtguser.TabIndex = 12;
            this.dtguser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtguser_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtguser);
            this.groupBox1.Location = new System.Drawing.Point(13, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 174);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng User";
            // 
            // QuanLyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btndeleteuser);
            this.Controls.Add(this.btnupdateuser);
            this.Controls.Add(this.btnadduser);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyUser";
            this.Text = "QuanLyUser";
            this.Load += new System.EventHandler(this.QuanLyUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtguser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Button btnadduser;
        private System.Windows.Forms.Button btnupdateuser;
        private System.Windows.Forms.Button btndeleteuser;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.DataGridView dtguser;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}