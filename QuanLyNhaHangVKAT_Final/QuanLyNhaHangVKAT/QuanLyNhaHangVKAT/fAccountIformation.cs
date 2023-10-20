using QuanLyNhaHangVKAT.DAO;
using QuanLyNhaHangVKAT.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHangVKAT
{
    public partial class fAccountIformation : Form
    {
        private Account loginAccount; // các constructor

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; AccountProfile(LoginAccount);  } 
        }
        public fAccountIformation(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }
        void AccountProfile(Account acc) // hien thong tin
        {
            txtusername.Text = loginAccount.UserName;
            txtdisplayName.Text = loginAccount.DisplayName;
            lbDisplayname.Text = "Xin chào "+loginAccount.DisplayName+"";
        }
        private static string CalculateMD5Hash(string input) // hàm mã hóa MD5
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
        void updateAccount()
        {
            string userName = txtusername.Text;
            string displayName = txtdisplayName.Text;
            string passWord = txtPassword.Text;
            string newPass = txtNewPassword.Text;
            string reenterPass = txtReenterPass.Text;
            // mã hóa mật khẩu
            string hashedPassword = CalculateMD5Hash(passWord);
            string hashedNewPassword = CalculateMD5Hash(newPass);
            string hashedReenterPassword = CalculateMD5Hash(reenterPass);
            if (!hashedPassword.Equals(loginAccount.Password))
            {
                MessageBox.Show("Vui lòng nhập đúng mật khẩu hiện tại", "Thông báo");
            }
            else
            {
                if (!hashedNewPassword.Equals(hashedReenterPassword)) // so sánh chuỗi 2 cái có giống nhau hay không
                {
                    MessageBox.Show("Vui lòng nhập lại mật khẩu giống với mật khẩu mới!", "Thông báp");
                }
                else
                {
                    if (AccountProvider.Instance.UpdateAccountInformation(userName, displayName, passWord, newPass))
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo");
                        txtPassword.Clear();
                        txtNewPassword.Clear();
                        txtReenterPass.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền đúng mật khẩu!", "Thông báo");
                    }
                }
            }

        }

        private void Editbtn_Click_1(object sender, EventArgs e)
        {
            if (txtdisplayName.Text == "Nhập tên hiện thị")
            {
                pnlTenhienthi.Visible = true;
                txtusername.Focus();
                return;
            }
            if (txtPassword.Text == "Nhập mật khẩu")
            {
                pnlPassword.Visible = true;
                txtPassword.Focus();
                return;
            }
            if (txtNewPassword.Text == "Nhập mật khẩu mới")
            {
                pnlNewpassword.Visible = true;
                txtNewPassword.Focus();
                return;
            }
            if (txtReenterPass.Text == "Nhập mật khẩu mới")
            {
                pnlCnpassword.Visible = false;
                txtReenterPass.Focus();
                return;
            }
            updateAccount();
        }

        private void Exitbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
