/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 28/11/2019
 * Time: 16:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
namespace QuanLyNhanVien
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
        ClsBiLL clsbill;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            clsbill = new ClsBiLL();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        public void ShowAllNhanVien()
        {
            DataTable tb = clsbill.getAllNhanVien();
            dgvnhanvien.DataSource = tb;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowAllNhanVien();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {

        }
        public bool CheckData()
        {
            if(string.IsNullOrEmpty(txtMacanbo.Text))
            {
                MessageBox.Show("Bạn chưa nhập vào Mã Cán Bộ","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtMacanbo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtHoten.Text))
            {
                MessageBox.Show("Bạn chưa nhập vào Họ Tên Cán Bộ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMacanbo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtHoten.Text))
            {
                MessageBox.Show("Bạn chưa nhập vào Họ Tên Cán Bộ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMacanbo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbtrinhdo.Text))
            {
                MessageBox.Show("Bạn chưa nhập vào Trình độ Cán Bộ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMacanbo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtHesoluong.Text))
            {
                MessageBox.Show("Bạn chưa nhập vào Trình độ Cán Bộ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMacanbo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbXeploai.Text))
            {
                MessageBox.Show("Bạn chưa nhập vào Xếp Loại Cán Bộ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMacanbo.Focus();
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(CheckData())
            {
                ClsNhanVien nv = new ClsNhanVien();
                nv.MaCanBo = txtMacanbo.Text;
                nv.HoTen = txtHoten.Text;
                nv.ChuyenMon = cbChuyenmon.Text;
                nv.TrinhDo = cbtrinhdo.Text;
                nv.HesoLuong = int.Parse(txtHesoluong.Text);
                nv.XepLoai = cbXeploai.Text;
                nv.GioiTinh = cbGioitinh.Text;
                nv.NamSinh = dtNamsinh.Text;
                nv.NamTanLuong = dtNamtanluong.Text;
                if (clsbill.AddNhanVien(nv))
                {
                    MessageBox.Show("Them Cán Bộ thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ShowAllNhanVien();
                }
                else
                {
                    MessageBox.Show("Them Cán Bộ không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClsNhanVien nv = new ClsNhanVien();
            nv.MaCanBo = txtMacanbo.Text;
            nv.HoTen = txtHoten.Text;
            nv.ChuyenMon = cbChuyenmon.Text;
            nv.TrinhDo = cbtrinhdo.Text;
            nv.HesoLuong = int.Parse(txtHesoluong.Text);
            nv.XepLoai = cbXeploai.Text;
            nv.GioiTinh = cbGioitinh.Text;
            nv.NamSinh = dtNamsinh.Text;
            nv.NamTanLuong = dtNamtanluong.Text;
            if(clsbill.UpdateNhanCanBo(nv))
            {
                MessageBox.Show("Update Cán Bộ thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ShowAllNhanVien();
            }
            else
            {
                MessageBox.Show("Update Cán Bộ không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClsNhanVien nv = new ClsNhanVien();
            nv.MaCanBo = txtMacanbo.Text;
            if(clsbill.DeleteCanBo(nv))
            {
                MessageBox.Show("Delete Cán Bộ thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ShowAllNhanVien();
            }
            else
            {
                MessageBox.Show("Delete Cán Bộ không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void quaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýCánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void quảnLýUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyUser qluser = new QuanLyUser();
            qluser.Show();
        }

        private void tínhLươngCánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        int ID;
        private void dgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            try
            {
                if (index >= 0)
                {
                    txtMacanbo.Text=dgvnhanvien.Rows[index].Cells["MaCanBo"].Value.ToString();
                    txtHoten.Text = dgvnhanvien.Rows[index].Cells["HoTen"].Value.ToString();
                    cbtrinhdo.Text = dgvnhanvien.Rows[index].Cells["TrinhDo"].Value.ToString();
                    cbChuyenmon.Text = dgvnhanvien.Rows[index].Cells["ChuyenMon"].Value.ToString();
                    txtHesoluong.Text = dgvnhanvien.Rows[index].Cells["HeSoLuong"].Value.ToString();
                    cbXeploai.Text = dgvnhanvien.Rows[index].Cells["XepLoai"].Value.ToString();
                    cbGioitinh.Text = dgvnhanvien.Rows[index].Cells["GioiTinh"].Value.ToString();
                    dtNamtanluong.Text = dgvnhanvien.Rows[index].Cells["NamTanLuong"].Value.ToString();
                    dtNamsinh.Text = dgvnhanvien.Rows[index].Cells["NamSinh"].Value.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Khong co sinh vien", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgvnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string value = txttimkiem.Text;
            if(!string.IsNullOrEmpty(value))
            {
                DataTable dt = clsbill.FindCanBo(value);
                dgvnhanvien.DataSource = dt;
            }
            else
            {
                ShowAllNhanVien();
            }
        }

        private void traCuuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TraCuu tc = new TraCuu();
            tc.Show();
        }
		
		void BtnTangClick(object sender, EventArgs e)
		{
			DataTable dt = clsbill.sapXepTang();
			dgvnhanvien.DataSource = dt;
			dgvnhanvien.Refresh();
		}
		
		void BtnGiamClick(object sender, EventArgs e)
		{
			DataTable dt = clsbill.sapXepGiam();
			dgvnhanvien.DataSource = dt;
			dgvnhanvien.Refresh();
		}
	}
}
