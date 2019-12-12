/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 11/12/2019
 * Time: 9:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace QuanLyNhanVien
{
	partial class DanhSachPhuCap
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
			this.btnThem = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cbCanBo = new System.Windows.Forms.ComboBox();
			this.cbPhuCap = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnXoa = new System.Windows.Forms.Button();
			this.dgvDanhSachPhuCap = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTenCanBo = new System.Windows.Forms.TextBox();
			this.txtTenPhuCap = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSoTienPhuCap = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnThemPC = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhuCap)).BeginInit();
			this.SuspendLayout();
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(592, 23);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 0;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.BtnThemClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(29, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mã Cán Bộ";
			// 
			// cbCanBo
			// 
			this.cbCanBo.FormattingEnabled = true;
			this.cbCanBo.Location = new System.Drawing.Point(147, 20);
			this.cbCanBo.Name = "cbCanBo";
			this.cbCanBo.Size = new System.Drawing.Size(121, 21);
			this.cbCanBo.TabIndex = 2;
			this.cbCanBo.SelectedIndexChanged += new System.EventHandler(this.CbCanBoSelectedIndexChanged);
			this.cbCanBo.TextChanged += new System.EventHandler(this.CbCanBoTextChanged);
			// 
			// cbPhuCap
			// 
			this.cbPhuCap.FormattingEnabled = true;
			this.cbPhuCap.Location = new System.Drawing.Point(147, 65);
			this.cbPhuCap.Name = "cbPhuCap";
			this.cbPhuCap.Size = new System.Drawing.Size(121, 21);
			this.cbPhuCap.TabIndex = 4;
			this.cbPhuCap.SelectedIndexChanged += new System.EventHandler(this.CbPhuCapSelectedIndexChanged);
			this.cbPhuCap.TextChanged += new System.EventHandler(this.CbPhuCapTextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(29, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Phụ Cấp";
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(592, 65);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 5;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.BtnXoaClick);
			// 
			// dgvDanhSachPhuCap
			// 
			this.dgvDanhSachPhuCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDanhSachPhuCap.Location = new System.Drawing.Point(28, 147);
			this.dgvDanhSachPhuCap.Name = "dgvDanhSachPhuCap";
			this.dgvDanhSachPhuCap.Size = new System.Drawing.Size(688, 150);
			this.dgvDanhSachPhuCap.TabIndex = 6;
			this.dgvDanhSachPhuCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDanhSachPhuCapCellClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(313, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Tên Cán Bộ";
			// 
			// txtTenCanBo
			// 
			this.txtTenCanBo.Location = new System.Drawing.Point(405, 23);
			this.txtTenCanBo.Name = "txtTenCanBo";
			this.txtTenCanBo.Size = new System.Drawing.Size(121, 20);
			this.txtTenCanBo.TabIndex = 8;
			// 
			// txtTenPhuCap
			// 
			this.txtTenPhuCap.Location = new System.Drawing.Point(147, 107);
			this.txtTenPhuCap.Name = "txtTenPhuCap";
			this.txtTenPhuCap.Size = new System.Drawing.Size(121, 20);
			this.txtTenPhuCap.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(29, 107);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Tên Phụ Cấp";
			// 
			// txtSoTienPhuCap
			// 
			this.txtSoTienPhuCap.Location = new System.Drawing.Point(405, 104);
			this.txtSoTienPhuCap.Name = "txtSoTienPhuCap";
			this.txtSoTienPhuCap.Size = new System.Drawing.Size(121, 20);
			this.txtSoTienPhuCap.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(313, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "Số Tiền Phụ Cấp";
			// 
			// btnThemPC
			// 
			this.btnThemPC.Location = new System.Drawing.Point(291, 63);
			this.btnThemPC.Name = "btnThemPC";
			this.btnThemPC.Size = new System.Drawing.Size(75, 23);
			this.btnThemPC.TabIndex = 13;
			this.btnThemPC.Text = "Thêm PC";
			this.btnThemPC.UseVisualStyleBackColor = true;
			this.btnThemPC.Click += new System.EventHandler(this.BtnThemPCClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(592, 104);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 14;
			this.button1.Text = "Thoát";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// DanhSachPhuCap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(788, 262);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnThemPC);
			this.Controls.Add(this.txtSoTienPhuCap);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtTenPhuCap);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTenCanBo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dgvDanhSachPhuCap);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.cbPhuCap);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbCanBo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnThem);
			this.Name = "DanhSachPhuCap";
			this.Text = "DanhSachPhuCap";
			this.Load += new System.EventHandler(this.DanhSachPhuCapLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhuCap)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnThemPC;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSoTienPhuCap;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTenPhuCap;
		private System.Windows.Forms.TextBox txtTenCanBo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgvDanhSachPhuCap;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbPhuCap;
		private System.Windows.Forms.ComboBox cbCanBo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnThem;
	}
}
