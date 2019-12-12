using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class TraCuu : Form
    {
        ClsBiLL clsbill;
        public TraCuu()
        {
            InitializeComponent();
            clsbill = new ClsBiLL();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            ClsNhanVien nv = new ClsNhanVien();
            nv.GioiTinh = cbgioitinh.Text;
            nv.ChuyenMon = cbChuyenMon.Text;
            nv.XepLoai = cbXepLoai.Text;

            if (!string.IsNullOrEmpty(cbgioitinh.Text))
            {
                DataTable dt = clsbill.FindGIoiTinh(nv);
                dtgtracuu.DataSource = dt;
            }
            if (!string.IsNullOrEmpty(cbChuyenMon.Text))
            {
                DataTable dt = clsbill.FindChuyenMon(nv);
                dtgtracuu.DataSource = dt;
            }
            if (!string.IsNullOrEmpty(cbXepLoai.Text))
            {
                DataTable dt = clsbill.FindLoaiLaoDong(nv);
                dtgtracuu.DataSource = dt;
            }
        }

        private void btnTongLuong_Click(object sender, EventArgs e)
        {
            DataTable dt = clsbill.XemTongLuong();
            dtgtracuu.DataSource = dt;
        }
        
        void BtnCancleClick(object sender, EventArgs e)
        {
        	this.Hide();
        	MainForm fm = new MainForm();
        	fm.Show();
        }

        private void cbgioitinh_TextChanged(object sender, EventArgs e)
        {
            cbChuyenMon.Text = "";
            cbXepLoai.Text = "";
        }

        private void cbChuyenMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbChuyenMon_TextChanged(object sender, EventArgs e)
        {
            cbgioitinh.Text = "";
            cbXepLoai.Text = "";
        }

        private void cbXepLoai_TextChanged(object sender, EventArgs e)
        {
            cbChuyenMon.Text = "";
            cbgioitinh.Text = "";
        }
    }
}
