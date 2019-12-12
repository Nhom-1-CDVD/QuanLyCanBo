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
    public partial class Login : Form
    {
        ClsBiLL clbill;
        public Login()
        {
            InitializeComponent();
            clbill = new ClsBiLL();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register  register = new Register();
            register.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtusername.Text))
            {
                MessageBox.Show("Xin vui lòng chưa nhập vào Username:", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusername.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtusername.Text))
            {
                MessageBox.Show("Xin vui lòng chưa nhập vào Username:", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusername.Focus();
                return false;
            }
            return true;
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(CheckData())
            {
                ClsUser us = new ClsUser();
                us.Username = txtusername.Text;
                us.password = txtpassword.Text;
                if(clbill.LoginUser(us))
                {
                    MessageBox.Show("Đăng Nhập Thành Công:", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    MainForm mf = new MainForm();
                   	mf.Show();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại:", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
