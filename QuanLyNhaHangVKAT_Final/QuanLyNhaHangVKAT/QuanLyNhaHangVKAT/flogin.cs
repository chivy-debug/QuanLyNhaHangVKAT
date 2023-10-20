using QuanLyNhaHangVKAT.DAO;
using QuanLyNhaHangVKAT.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace QuanLyNhaHangVKAT
{
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
            txtusername.Select();

        }


        bool login(string userName, string passWord)
        {
            return AccountProvider.Instance.login(userName, passWord);
        }

        private void txtusername_Click(object sender, EventArgs e)
        {
            txtusername.SelectAll();
        }

        private void txtpassword_Click(object sender, EventArgs e)
        {
            txtpassword.SelectAll();
        }

        private void flogin_Load(object sender, EventArgs e)
        {
            
            timer1.Start();

        }

        
        private void Loginbtn_Click_1(object sender, EventArgs e)
        {
            
            if (txtusername.Text == "")
            {
                panel5.Visible = true;
                txtusername.Focus();
                return;
            }
            if (txtpassword.Text == "")
            {
                panel9.Visible = true;
                txtpassword.Focus();
                return;
            }
            string userName = txtusername.Text;
            string passWord = txtpassword.Text;
            if (login(userName, passWord))
            {
                Account loginAccount = AccountProvider.Instance.GetAccountByUserName(userName);
                fTableManager f = new fTableManager(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();         // chỉ hiện 1 giao diện sử dụng
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu! ", "Thông báo");
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            panel5.Visible = panel9.Visible = false;
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void txtusername_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (txtusername.Text == "")
                {
                    return;
                }
                txtusername.ForeColor = Color.Black;
                panel5.Visible = false;
            }
            catch { }
        }

        private void txtpassword_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (txtpassword.Text == "")
                {
                    return;
                }
                txtpassword.ForeColor = Color.Black;
                panel9.Visible = false;

            }
            catch { }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (txtpassword.UseSystemPasswordChar == false)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
                txtpassword.UseSystemPasswordChar = false;
        }
    }
}
