using QuanLyNhaHangVKAT.DAO;
using QuanLyNhaHangVKAT.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHangVKAT
{
    public partial class TaiKhoan : UserControl
    {
        BindingSource accountList = new BindingSource();

        public TaiKhoan()
        {
            InitializeComponent();
            dgvAccount.DataSource = accountList;
            AccountBinding();
            LoadAccount();
            btnLuuAccount.Enabled = false;
            btnKhongLuu.Enabled = false;

        }
        void AccountBinding()
        {
            txtUserName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txtDisplayname.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            txtPassWord.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Password", true, DataSourceUpdateMode.Never));
            nmType.DataBindings.Add(new Binding("Value", dgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }
        void LoadAccount()
        {
            accountList.DataSource = AccountProvider.Instance.GetListAccount();
        }
        void clearAccount()
        {
            txtUserName.Clear();
            txtDisplayname.Clear();
            txtPassWord.Clear();
            nmType.Accelerations.Clear();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            clearAccount();
            btnRemoveAccount.Enabled = false;
            btnEditAccount.Enabled = false;
            btnLuuAccount.Enabled = true;
            btnKhongLuu.Enabled = true;
            IsAccessible = true; // Thuộc tính này được sử dụng để xác định xem một thành phần giao diện (control) có khả năng tương tác với người dùng hay không
            MessageBox.Show("Vui lòng nhập thông tin tài khoản", "Thông báo");
        }

        private void btnRemoveAccount_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtDisplayname.Text == "" || txtPassWord.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản bạn muốn xóa!!!", "Thông báo");
            }
            else
            {
                string userName = txtUserName.Text;
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?\n(Không thể hoàn tác sau khi xóa)", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    AccountProvider.Instance.DeleteAccount(userName);
                    MessageBox.Show("Xóa tài khoản thành công");
                }

                LoadAccount();
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            btnAddAccount.Enabled = false;
            btnRemoveAccount.Enabled = false;
            btnLuuAccount.Enabled = true;
            btnKhongLuu.Enabled = true;
            IsAccessible = false;
            clearAccount();
            MessageBox.Show("Chọn tài khoản muốn cập nhật", "Thông báo");
        }

        private void btnLuuAccount_Click(object sender, EventArgs e)
        {
            // Thêm tài khoản
            if (IsAccessible == true) // Thuộc tính này được sử dụng để xác định xem một thành phần giao diện (control) có khả năng tương tác với người dùng hay không 
            {
                string userName = txtUserName.Text;
                string displayName = txtDisplayname.Text;
                string password = txtPassWord.Text;
                int type = (int)nmType.Value;
                try
                {

                    if (txtUserName.Text == "" || txtDisplayname.Text == "" || txtPassWord.Text == "")
                    {
                        MessageBox.Show("Thêm tài khoản thất bại , vui lòng nhập đầy đủ thông tin!!!", "Thông báo");
                    }
                    else
                    {
                        if (AccountProvider.Instance.checkAccountExists(userName))
                        {
                            MessageBox.Show("Thêm tài khoản thất bại , đã tồn tại tài khoản này!!!", "Thông báo");
                            clearAccount();
                        }
                        else
                        {
                            AccountProvider.Instance.InsertAccount(userName, displayName, type, password);
                            MessageBox.Show("Thêm tài khoản thành công");
                            LoadAccount();
                            btnRemoveAccount.Enabled = true;
                            btnEditAccount.Enabled = true;
                            btnLuuAccount.Enabled = false;
                            btnKhongLuu.Enabled = false;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm tài khoản thất bại , đã tồn tại tài khoản này!!!", "Thông báo");
                    clearAccount();
                }

            }
            if (IsAccessible == false) // Update tài khoản
            {
                string userName = txtUserName.Text;
                string displayName = txtDisplayname.Text;
                string password = txtPassWord.Text;
                int type = (int)nmType.Value;
                try
                {
                    if (txtUserName.Text == "" || txtDisplayname.Text == "" || txtPassWord.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            AccountProvider.Instance.UpdateAccount(userName, displayName, type, password);
                            MessageBox.Show("Cập nhật tài khoản thành công");
                            LoadAccount();
                            btnAddAccount.Enabled = true;
                            btnRemoveAccount.Enabled = true;
                            btnLuuAccount.Enabled = false;
                            btnKhongLuu.Enabled = false;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xảy ra: " + ex.Message);
                }
            }
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            clearAccount();
            btnRemoveAccount.Enabled = true;
            btnEditAccount.Enabled = true;
            btnAddAccount.Enabled = true;
            btnLuuAccount.Enabled = false;
            btnKhongLuu.Enabled = false;
        }


    }
}
