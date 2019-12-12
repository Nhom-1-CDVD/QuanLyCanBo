namespace QuanLyNhanVien
{
    partial class TraCuu
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
            this.dtgtracuu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnTongLuong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbXepLoai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbChuyenMon = new System.Windows.Forms.ComboBox();
            this.cbgioitinh = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtracuu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgtracuu
            // 
            this.dtgtracuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgtracuu.Location = new System.Drawing.Point(12, 53);
            this.dtgtracuu.Name = "dtgtracuu";
            this.dtgtracuu.Size = new System.Drawing.Size(610, 150);
            this.dtgtracuu.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgtracuu);
            this.groupBox1.Location = new System.Drawing.Point(12, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 209);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Tra Cứu";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnTongLuong
            // 
            this.btnTongLuong.Location = new System.Drawing.Point(323, 67);
            this.btnTongLuong.Name = "btnTongLuong";
            this.btnTongLuong.Size = new System.Drawing.Size(87, 36);
            this.btnTongLuong.TabIndex = 18;
            this.btnTongLuong.Text = "Xem Tổng Lương";
            this.btnTongLuong.UseVisualStyleBackColor = true;
            this.btnTongLuong.Click += new System.EventHandler(this.btnTongLuong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Loại lao động";
            // 
            // cbXepLoai
            // 
            this.cbXepLoai.FormattingEnabled = true;
            this.cbXepLoai.Items.AddRange(new object[] {
            "Giỏi",
            "Trung Bình ",
            "Khá",
            ""});
            this.cbXepLoai.Location = new System.Drawing.Point(111, 95);
            this.cbXepLoai.Name = "cbXepLoai";
            this.cbXepLoai.Size = new System.Drawing.Size(133, 21);
            this.cbXepLoai.TabIndex = 16;
            this.cbXepLoai.TextChanged += new System.EventHandler(this.cbXepLoai_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Chuyên Môn";
            // 
            // cbChuyenMon
            // 
            this.cbChuyenMon.FormattingEnabled = true;
            this.cbChuyenMon.Items.AddRange(new object[] {
            "Công Nghệ Thông Tin",
            "Điều Dưỡng",
            ""});
            this.cbChuyenMon.Location = new System.Drawing.Point(111, 40);
            this.cbChuyenMon.Name = "cbChuyenMon";
            this.cbChuyenMon.Size = new System.Drawing.Size(133, 21);
            this.cbChuyenMon.TabIndex = 14;
            this.cbChuyenMon.SelectedIndexChanged += new System.EventHandler(this.cbChuyenMon_SelectedIndexChanged);
            this.cbChuyenMon.TextChanged += new System.EventHandler(this.cbChuyenMon_TextChanged);
            // 
            // cbgioitinh
            // 
            this.cbgioitinh.FormattingEnabled = true;
            this.cbgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbgioitinh.Location = new System.Drawing.Point(111, 1);
            this.cbgioitinh.Name = "cbgioitinh";
            this.cbgioitinh.Size = new System.Drawing.Size(75, 21);
            this.cbgioitinh.TabIndex = 13;
            this.cbgioitinh.TextChanged += new System.EventHandler(this.cbgioitinh_TextChanged);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(323, 1);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(87, 43);
            this.btnXem.TabIndex = 12;
            this.btnXem.Text = "Xem ";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Giới Tính";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(323, 120);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(87, 43);
            this.btnCancle.TabIndex = 19;
            this.btnCancle.Text = "Thoát";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.BtnCancleClick);
            // 
            // TraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 438);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnTongLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbXepLoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbChuyenMon);
            this.Controls.Add(this.cbgioitinh);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "TraCuu";
            this.Text = "TraCuu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgtracuu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button btnCancle;

        #endregion

        private System.Windows.Forms.DataGridView dtgtracuu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnTongLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbXepLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbChuyenMon;
        private System.Windows.Forms.ComboBox cbgioitinh;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label6;
    }
}