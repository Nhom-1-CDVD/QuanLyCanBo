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
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhuCap)).BeginInit();
			this.SuspendLayout();
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(592, 32);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 0;
			this.btnThem.Text = "Them";
			this.btnThem.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(29, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Can Bo";
			// 
			// cbCanBo
			// 
			this.cbCanBo.FormattingEnabled = true;
			this.cbCanBo.Location = new System.Drawing.Point(147, 23);
			this.cbCanBo.Name = "cbCanBo";
			this.cbCanBo.Size = new System.Drawing.Size(121, 21);
			this.cbCanBo.TabIndex = 2;
			// 
			// cbPhuCap
			// 
			this.cbPhuCap.FormattingEnabled = true;
			this.cbPhuCap.Location = new System.Drawing.Point(147, 65);
			this.cbPhuCap.Name = "cbPhuCap";
			this.cbPhuCap.Size = new System.Drawing.Size(121, 21);
			this.cbPhuCap.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(29, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Phu Cap";
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(592, 78);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 5;
			this.btnXoa.Text = "Xoa";
			this.btnXoa.UseVisualStyleBackColor = true;
			// 
			// dgvDanhSachPhuCap
			// 
			this.dgvDanhSachPhuCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDanhSachPhuCap.Location = new System.Drawing.Point(28, 147);
			this.dgvDanhSachPhuCap.Name = "dgvDanhSachPhuCap";
			this.dgvDanhSachPhuCap.Size = new System.Drawing.Size(688, 150);
			this.dgvDanhSachPhuCap.TabIndex = 6;
			// 
			// DanhSachPhuCap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(788, 262);
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
		}
		private System.Windows.Forms.DataGridView dgvDanhSachPhuCap;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbPhuCap;
		private System.Windows.Forms.ComboBox cbCanBo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnThem;
	}
}
