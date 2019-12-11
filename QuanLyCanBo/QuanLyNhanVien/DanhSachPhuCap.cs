/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 11/12/2019
 * Time: 9:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace QuanLyNhanVien
{
	/// <summary>
	/// Description of DanhSachPhuCap.
	/// </summary>
	public partial class DanhSachPhuCap : Form
	{
		ClsBiLL clsbill = new ClsBiLL();
		public DanhSachPhuCap()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void DanhSachPhuCapLoad(object sender, EventArgs e)
		{
			 SqlDataReader DR = clsbill.getTenCanBo();
			 while (DR.Read())
            {
                cbCanBo.Items.Add(DR[0]);

            }
			 DR = clsbill.getTenPhuCap();
			  while (DR.Read())
            {
                cbPhuCap.Items.Add(DR[0]);

            }
			  showDSPC(dgvDanhSachPhuCap);
			
		}
		void showDSPC(DataGridView dgv){
			DataTable dt = clsbill.getAllDSPC();
			dgv.DataSource = dt;
			dgv.Refresh();
		}
		
		void CbCanBoSelectedIndexChanged(object sender, EventArgs e)
		{
			string macanbo = cbCanBo.Text;
			SqlDataReader DR = clsbill.getCanBoTen(macanbo);
			while(DR.Read()){
				txtTenCanBo.Text = DR[0].ToString();
			}
		}
		
		void CbPhuCapSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void CbCanBoTextChanged(object sender, EventArgs e)
		{
			txtTenCanBo.Text = "";
			string macanbo = cbCanBo.Text;
			SqlDataReader DR = clsbill.getCanBoTen(macanbo);
			while(DR.Read()){
				txtTenCanBo.Text = DR[0].ToString();
			}
		}
		
		void CbPhuCapTextChanged(object sender, EventArgs e)
		{
			txtTenPhuCap.Text = "";
			txtSoTienPhuCap.Text = "";
			string maPhuCap = cbPhuCap.Text;
			SqlDataReader DR = clsbill.getTTPhuCap(maPhuCap);
			while(DR.Read()){
				txtTenPhuCap.Text = DR[0].ToString();
				txtSoTienPhuCap.Text = DR[1].ToString();
			}
		}
		
		void BtnThemClick(object sender, EventArgs e)
		{
			clsbill.InsertDSPC(cbCanBo.Text,txtTenCanBo.Text,cbPhuCap.Text,txtTenPhuCap.Text);
			showDSPC(dgvDanhSachPhuCap);
		}
		
		void BtnXoaClick(object sender, EventArgs e)
		{
			if(clsbill.XoaDSPC(cbCanBo.Text,txtTenPhuCap.Text)){
				showDSPC(dgvDanhSachPhuCap);
				MessageBox.Show("Xoa Thanh Cong");
			}
			else{
				MessageBox.Show("Xoa Khong Thanh Cong");
			}
			
			
		}
	}
}
