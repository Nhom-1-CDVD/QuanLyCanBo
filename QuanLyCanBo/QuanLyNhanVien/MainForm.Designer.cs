/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 28/11/2019
 * Time: 16:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace QuanLyNhanVien
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvnhanvien = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtMacanbo = new System.Windows.Forms.TextBox();
			this.txtHoten = new System.Windows.Forms.TextBox();
			this.cbChuyenmon = new System.Windows.Forms.ComboBox();
			this.txtHesoluong = new System.Windows.Forms.TextBox();
			this.cbtrinhdo = new System.Windows.Forms.ComboBox();
			this.cbXeploai = new System.Windows.Forms.ComboBox();
			this.cbGioitinh = new System.Windows.Forms.ComboBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.dtNamsinh = new System.Windows.Forms.DateTimePicker();
			this.dtNamtanluong = new System.Windows.Forms.DateTimePicker();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.quảnLýCánBộToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.traCuuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txttimkiem = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvnhanvien
			// 
			this.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvnhanvien.Location = new System.Drawing.Point(11, 19);
			this.dgvnhanvien.Name = "dgvnhanvien";
			this.dgvnhanvien.Size = new System.Drawing.Size(831, 150);
			this.dgvnhanvien.TabIndex = 0;
			this.dgvnhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhanvien_CellClick);
			this.dgvnhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhanvien_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mã Cán Bộ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Họ Tên";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Năm Sinh";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 176);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Chuyên Môn";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(240, 45);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Trình Độ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(240, 93);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Hệ Số Lương";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(240, 176);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(84, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "Năm Tân Lương";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(517, 49);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(49, 13);
			this.label9.TabIndex = 9;
			this.label9.Text = "Xếp Loại";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(517, 93);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(51, 13);
			this.label10.TabIndex = 10;
			this.label10.Text = "Giới Tính";
			// 
			// txtMacanbo
			// 
			this.txtMacanbo.Location = new System.Drawing.Point(84, 46);
			this.txtMacanbo.Name = "txtMacanbo";
			this.txtMacanbo.Size = new System.Drawing.Size(140, 20);
			this.txtMacanbo.TabIndex = 11;
			// 
			// txtHoten
			// 
			this.txtHoten.Location = new System.Drawing.Point(84, 86);
			this.txtHoten.Name = "txtHoten";
			this.txtHoten.Size = new System.Drawing.Size(140, 20);
			this.txtHoten.TabIndex = 12;
			this.txtHoten.TextChanged += new System.EventHandler(this.txtHoten_TextChanged);
			// 
			// cbChuyenmon
			// 
			this.cbChuyenmon.FormattingEnabled = true;
			this.cbChuyenmon.Items.AddRange(new object[] {
									"Công Nghệ Thông Tin",
									"Điều Dưỡng",
									"Đồ Họa ",
									"Cơ Khí",
									"Tiến Anh"});
			this.cbChuyenmon.Location = new System.Drawing.Point(88, 167);
			this.cbChuyenmon.Name = "cbChuyenmon";
			this.cbChuyenmon.Size = new System.Drawing.Size(136, 21);
			this.cbChuyenmon.TabIndex = 13;
			// 
			// txtHesoluong
			// 
			this.txtHesoluong.Location = new System.Drawing.Point(336, 86);
			this.txtHesoluong.Name = "txtHesoluong";
			this.txtHesoluong.Size = new System.Drawing.Size(140, 20);
			this.txtHesoluong.TabIndex = 16;
			// 
			// cbtrinhdo
			// 
			this.cbtrinhdo.FormattingEnabled = true;
			this.cbtrinhdo.Items.AddRange(new object[] {
									"Đại Học",
									"Cao Đẵng",
									"Thạc Sĩ ",
									"Tiến Sĩ ",
									"Giáo Sư "});
			this.cbtrinhdo.Location = new System.Drawing.Point(336, 42);
			this.cbtrinhdo.Name = "cbtrinhdo";
			this.cbtrinhdo.Size = new System.Drawing.Size(140, 21);
			this.cbtrinhdo.TabIndex = 21;
			// 
			// cbXeploai
			// 
			this.cbXeploai.FormattingEnabled = true;
			this.cbXeploai.Items.AddRange(new object[] {
									"Giỏi",
									"Khá ",
									"Trung Bình"});
			this.cbXeploai.Location = new System.Drawing.Point(606, 41);
			this.cbXeploai.Name = "cbXeploai";
			this.cbXeploai.Size = new System.Drawing.Size(136, 21);
			this.cbXeploai.TabIndex = 22;
			// 
			// cbGioitinh
			// 
			this.cbGioitinh.FormattingEnabled = true;
			this.cbGioitinh.Items.AddRange(new object[] {
									"Nam",
									"Nữ"});
			this.cbGioitinh.Location = new System.Drawing.Point(606, 85);
			this.cbGioitinh.Name = "cbGioitinh";
			this.cbGioitinh.Size = new System.Drawing.Size(136, 21);
			this.cbGioitinh.TabIndex = 23;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(569, 155);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(81, 33);
			this.btnAdd.TabIndex = 24;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(668, 155);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(74, 33);
			this.btnUpdate.TabIndex = 25;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(757, 155);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(73, 33);
			this.btnDelete.TabIndex = 26;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// dtNamsinh
			// 
			this.dtNamsinh.CustomFormat = "dd/MM/yyyy";
			this.dtNamsinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtNamsinh.Location = new System.Drawing.Point(84, 129);
			this.dtNamsinh.Name = "dtNamsinh";
			this.dtNamsinh.Size = new System.Drawing.Size(200, 20);
			this.dtNamsinh.TabIndex = 27;
			// 
			// dtNamtanluong
			// 
			this.dtNamtanluong.CustomFormat = "dd/MM/yyy";
			this.dtNamtanluong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtNamtanluong.Location = new System.Drawing.Point(336, 169);
			this.dtNamtanluong.Name = "dtNamtanluong";
			this.dtNamtanluong.Size = new System.Drawing.Size(200, 20);
			this.dtNamtanluong.TabIndex = 28;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.quảnLýCánBộToolStripMenuItem,
									this.quảnLýUserToolStripMenuItem,
									this.traCuuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(882, 24);
			this.menuStrip1.TabIndex = 29;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// quảnLýCánBộToolStripMenuItem
			// 
			this.quảnLýCánBộToolStripMenuItem.Name = "quảnLýCánBộToolStripMenuItem";
			this.quảnLýCánBộToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
			this.quảnLýCánBộToolStripMenuItem.Text = "Quản Lý Cán Bộ";
			this.quảnLýCánBộToolStripMenuItem.Click += new System.EventHandler(this.quảnLýCánBộToolStripMenuItem_Click);
			// 
			// quảnLýUserToolStripMenuItem
			// 
			this.quảnLýUserToolStripMenuItem.Name = "quảnLýUserToolStripMenuItem";
			this.quảnLýUserToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
			this.quảnLýUserToolStripMenuItem.Text = "Quản Lý User";
			this.quảnLýUserToolStripMenuItem.Click += new System.EventHandler(this.quảnLýUserToolStripMenuItem_Click);
			// 
			// traCuuToolStripMenuItem
			// 
			this.traCuuToolStripMenuItem.Name = "traCuuToolStripMenuItem";
			this.traCuuToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.traCuuToolStripMenuItem.Text = "Tra Cứu";
			this.traCuuToolStripMenuItem.Click += new System.EventHandler(this.traCuuToolStripMenuItem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvnhanvien);
			this.groupBox1.Location = new System.Drawing.Point(18, 260);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(857, 194);
			this.groupBox1.TabIndex = 30;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Bảng Thông Tin Cán Bộ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(21, 216);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 13);
			this.label8.TabIndex = 31;
			this.label8.Text = "Tìm Kiếm";
			// 
			// txttimkiem
			// 
			this.txttimkiem.Location = new System.Drawing.Point(88, 213);
			this.txttimkiem.Name = "txttimkiem";
			this.txttimkiem.Size = new System.Drawing.Size(179, 20);
			this.txttimkiem.TabIndex = 32;
			this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(882, 524);
			this.Controls.Add(this.txttimkiem);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dtNamtanluong);
			this.Controls.Add(this.dtNamsinh);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.cbGioitinh);
			this.Controls.Add(this.cbXeploai);
			this.Controls.Add(this.cbtrinhdo);
			this.Controls.Add(this.txtHesoluong);
			this.Controls.Add(this.cbChuyenmon);
			this.Controls.Add(this.txtHoten);
			this.Controls.Add(this.txtMacanbo);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "QuanLyNhanVien";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

        private System.Windows.Forms.DataGridView dgvnhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMacanbo;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.ComboBox cbChuyenmon;
        private System.Windows.Forms.TextBox txtHesoluong;
        private System.Windows.Forms.ComboBox cbtrinhdo;
        private System.Windows.Forms.ComboBox cbGioitinh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbXeploai;
        private System.Windows.Forms.DateTimePicker dtNamtanluong;
        internal System.Windows.Forms.DateTimePicker dtNamsinh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýCánBộToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýUserToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.ToolStripMenuItem traCuuToolStripMenuItem;
	}
}
