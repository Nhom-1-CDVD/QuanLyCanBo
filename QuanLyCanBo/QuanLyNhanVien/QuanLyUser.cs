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
    public partial class QuanLyUser : Form
    {
        ClsBiLL clsbill;
        public QuanLyUser()
        {
            InitializeComponent();
            clsbill = new ClsBiLL();
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtusername.Text))
            {
                MessageBox.Show("Bạn chưa nhập vào Usernane");
                return false;
                txtusername.Focus();
            }
            if (string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Bạn chưa nhập vào Usernane");
                return false;
                txtpassword.Focus();
            }
            if (string.IsNullOrEmpty(txtphone.Text))
            {
                MessageBox.Show("Bạn chưa nhập vào Usernane");
                return false;
                txtphone.Focus();
            }
            if (string.IsNullOrEmpty(txtaddress.Text))
            {
                MessageBox.Show("Bạn chưa nhập vào Usernane");
                return false;
                txtaddress.Focus();
            }
            return true;
        }
        private void btnadduser_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                ClsUser us = new ClsUser();
                us.Username = txtusername.Text;
                us.password = txtpassword.Text;
                us.Phone = txtphone.Text;
                us.Address = txtaddress.Text;
                if (clsbill.AddUser(us))
                {
                    MessageBox.Show("Thêm User thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ShowAddUser();
                }
                else
                {
                    MessageBox.Show("Thêm User không công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void ShowAddUser()
        {
            DataTable tb = clsbill.getAllUser();
            dtguser.DataSource = tb;
        }
       
        private void QuanLyUser_Load(object sender, EventArgs e)
        {
            ShowAddUser();
        }
     
  

        private void btnupdateuser_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                ClsUser us = new ClsUser();
                us.ID = ID;
                us.Username = txtusername.Text;
                us.password = txtpassword.Text;
                us.Phone = txtphone.Text;
                us.Address = txtaddress.Text;
                if (clsbill.UpdateUser(us))
                {
                    MessageBox.Show("Update User thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ShowAddUser();
                }
                else
                {
                    MessageBox.Show("Update User không công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btndeleteuser_Click(object sender, EventArgs e)
        {
            ClsUser us = new ClsUser();
            us.ID = ID;
            if (MessageBox.Show("Bạn có muốn chắc muốn xóa hay không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsbill.DeleteUser(us))
                {
                    MessageBox.Show("Delete User thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ShowAddUser();

                }
                else
                {
                    MessageBox.Show("Delete User không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }
        int ID;
        private void dtguser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            try
            {
                if (index >= 0)
                {
                    ID = Int32.Parse(dtguser.Rows[index].Cells["id"].Value.ToString());
                    txtusername.Text = dtguser.Rows[index].Cells["username"].Value.ToString();
                    txtpassword.Text = dtguser.Rows[index].Cells["password"].Value.ToString();
                    txtphone.Text = dtguser.Rows[index].Cells["phone"].Value.ToString();
                    txtaddress.Text = dtguser.Rows[index].Cells["address"].Value.ToString();

                }
            }
            catch
            {
                MessageBox.Show("Khong co User", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
