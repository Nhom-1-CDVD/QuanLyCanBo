/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 11/12/2019
 * Time: 9:53 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace QuanLyNhanVien
{
	partial class PhuCap
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
			this.dgvPhucap = new System.Windows.Forms.DataGridView();
			this.lbPhuCap = new System.Windows.Forms.Label();
			this.txtMaPhuCap = new System.Windows.Forms.TextBox();
			this.txtTenPhuCap = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTienPhuCap = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvPhucap)).BeginInit();
			this.SuspendLayout();
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(445, 32);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 0;
			this.btnThem.Text = "Them";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.BtnThemClick);
			// 
			// dgvPhucap
			// 
			this.dgvPhucap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPhucap.Location = new System.Drawing.Point(12, 135);
			this.dgvPhucap.Name = "dgvPhucap";
			this.dgvPhucap.Size = new System.Drawing.Size(642, 150);
			this.dgvPhucap.TabIndex = 1;
			this.dgvPhucap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPhucapCellClick);
			// 
			// lbPhuCap
			// 
			this.lbPhuCap.Location = new System.Drawing.Point(28, 32);
			this.lbPhuCap.Name = "lbPhuCap";
			this.lbPhuCap.Size = new System.Drawing.Size(100, 23);
			this.lbPhuCap.TabIndex = 2;
			this.lbPhuCap.Text = "Ma Phu Cap";
			// 
			// txtMaPhuCap
			// 
			this.txtMaPhuCap.Location = new System.Drawing.Point(135, 32);
			this.txtMaPhuCap.Name = "txtMaPhuCap";
			this.txtMaPhuCap.Size = new System.Drawing.Size(145, 20);
			this.txtMaPhuCap.TabIndex = 3;
			// 
			// txtTenPhuCap
			// 
			this.txtTenPhuCap.Location = new System.Drawing.Point(135, 69);
			this.txtTenPhuCap.Name = "txtTenPhuCap";
			this.txtTenPhuCap.Size = new System.Drawing.Size(145, 20);
			this.txtTenPhuCap.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(28, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Ten Phu Cap";
			// 
			// txtTienPhuCap
			// 
			this.txtTienPhuCap.Location = new System.Drawing.Point(135, 109);
			this.txtTienPhuCap.Name = "txtTienPhuCap";
			this.txtTienPhuCap.Size = new System.Drawing.Size(145, 20);
			this.txtTienPhuCap.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(28, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "So Tien Phu Cap";
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(445, 109);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 8;
			this.btnSua.Text = "Sua";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.BtnSuaClick);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(445, 69);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 9;
			this.btnXoa.Text = "Xoa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.BtnXoaClick);
			// 
			// PhuCap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 297);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.txtTienPhuCap);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTenPhuCap);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtMaPhuCap);
			this.Controls.Add(this.lbPhuCap);
			this.Controls.Add(this.dgvPhucap);
			this.Controls.Add(this.btnThem);
			this.Name = "PhuCap";
			this.Text = "PhuCap";
			this.Load += new System.EventHandler(this.PhuCapLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvPhucap)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTienPhuCap;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTenPhuCap;
		private System.Windows.Forms.TextBox txtMaPhuCap;
		private System.Windows.Forms.Label lbPhuCap;
		private System.Windows.Forms.DataGridView dgvPhucap;
		private System.Windows.Forms.Button btnThem;
	}
}
