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
    public partial class Register : Form
    {
        ClsBiLL clsbill;
        public Register()
        {
            InitializeComponent();
            clsbill = new ClsBiLL();
        }

        private void btncanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        public bool CheckData()
        {
            if(string.IsNullOrEmpty(txtusername.Text))
            {
                MessageBox.Show("Xin vui lòng chưa nhập vào Username:","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtusername.Focus();
                return false;
            }
            if(clsbill.checkUser(txtusername.Text)){
            	MessageBox.Show("Username đã tồn tại :","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtusername.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Xin vui lòng chưa nhập vào password:", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpassword.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtphone.Text))
            {
                MessageBox.Show("Xin vui lòng chưa nhập vào Phone:", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtphone.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtaddress.Text))
            {
                MessageBox.Show("Xin vui lòng chưa nhập vào Address:", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtaddress.Focus();
                return false;
            }
            return true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(CheckData())
            {
                ClsUser us = new ClsUser();
                us.Username = txtusername.Text;
                us.password = txtpassword.Text;
                us.Phone = txtphone.Text;
                us.Address = txtaddress.Text;
                if(clsbill.RegisterUser(us))
                {
                    MessageBox.Show("Đăng ký User thành công","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Đăng ký User không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
