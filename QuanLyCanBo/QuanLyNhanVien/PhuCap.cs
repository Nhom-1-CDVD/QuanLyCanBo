﻿/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 11/12/2019
 * Time: 9:53 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace QuanLyNhanVien
{
	/// <summary>
	/// Description of PhuCap.
	/// </summary>
	public partial class PhuCap : Form
	{
		ClsBiLL clsill = new ClsBiLL();
		public PhuCap()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PhuCapLoad(object sender, EventArgs e)
		{
			ShowPhuCap(dgvPhucap);
		}
		
		public void ShowPhuCap(DataGridView gv){
			DataTable dt = clsill.GetAllPhuCap();
			gv.DataSource = dt;
			gv.Refresh();
		}
		
		void DgvPhucapCellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
            try
            {
                if (index >= 0)
                {
                    txtMaPhuCap.Text=dgvPhucap.Rows[index].Cells["MaPhuCap"].Value.ToString();
                    txtTenPhuCap.Text=dgvPhucap.Rows[index].Cells["TenPhuCap"].Value.ToString();
                    txtTienPhuCap.Text=dgvPhucap.Rows[index].Cells["SoTienPhuCap"].Value.ToString();
                    
                }
            }
            catch
            {
                MessageBox.Show("Khong co Phu Cap Nay", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
		}
		
		void BtnThemClick(object sender, EventArgs e)
		{
			int maphucap = Int32.Parse(txtMaPhuCap.Text);
			if(clsill.checkPC(maphucap)){
				MessageBox.Show("Mã phụ cấp đã tồn tại");
			}
			else{
				string tenphucap = txtTenPhuCap.Text;
				double tienphucap = double.Parse(txtTienPhuCap.Text);
				clsill.addPhuCap(maphucap,tenphucap,tienphucap);
				MessageBox.Show("Thêm Phụ Cấp thành công");
			}
			ShowPhuCap(dgvPhucap);
		}
		
		void BtnXoaClick(object sender, EventArgs e)
		{
			int maphucap = Int32.Parse(txtMaPhuCap.Text);
			clsill.deletePhuCap(maphucap);
			ShowPhuCap(dgvPhucap);
		}
		
		void BtnSuaClick(object sender, EventArgs e)
		{
			if(clsill.updatePC(Int32.Parse(txtMaPhuCap.Text),txtTenPhuCap.Text,double.Parse(txtTienPhuCap.Text)))
			{
				MessageBox.Show("Chinh Sua Thanh Cong");
				ShowPhuCap(dgvPhucap);
			}
			else{
				MessageBox.Show("Khong co ma phu cap: "+ txtMaPhuCap.Text + " trong du lieu !");
			}
		}
		
		void BtnCancleClick(object sender, EventArgs e)
		{
			this.Hide();
			DanhSachPhuCap dspc = new DanhSachPhuCap();
			dspc.Show();
		}
	}
}
