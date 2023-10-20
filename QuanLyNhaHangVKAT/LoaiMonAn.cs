using QuanLyNhaHangVKAT.DAO;
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
    public partial class LoaiMonAn : UserControl
    {
        BindingSource categoryList = new BindingSource();

        public LoaiMonAn()
        {
            InitializeComponent();
            dgvCategory.DataSource = categoryList; //binding
            LoadCategory();
            CategoryBinding();
            btnLuuCategory.Enabled = false; 
            btnCancelCategory.Enabled = false;
        }

        void LoadCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        }
        void CategoryBinding()
        {
            txtCategoryName.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtIdCategory.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
        }
        void clearCategory()
        {
            txtCategoryName.Clear();
            txtIdCategory.Clear();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            bntRemoveCategory.Enabled = false;
            btnEditCategory.Enabled = false;
            btnLuuCategory.Enabled = true;
            btnCancelCategory.Enabled = true;
            clearCategory();
            IsAccessible = true; // Thuộc tính này được sử dụng để xác định xem một thành phần giao diện (control) có khả năng tương tác với người dùng hay không
            MessageBox.Show("Vui lòng nhập thông tin loại món ăn", "Thông báo");
        }

        private void bntRemoveCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "" || txtIdCategory.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại món ăn bạn muốn xóa!!!", "Thông báo");
            }
            else
            {
                int id = int.Parse(txtIdCategory.Text);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại món ăn này?\n(Không thể hoàn tác sau khi xóa)", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    CategoryDAO.Instance.DeleteCategory(id);
                    MessageBox.Show("Xóa loại món ăn thành công");
                }
                else
                {

                }

                LoadCategory();
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            bntRemoveCategory.Enabled = false;
            btnAddCategory.Enabled = false;
            btnLuuCategory.Enabled = true;
            btnCancelCategory.Enabled = true;
            
            IsAccessible = false;
            clearCategory();
            MessageBox.Show("Chọn loại món ăn muốn cập nhật", "Thông báo");
        }

        private void btnCancelCategory_Click(object sender, EventArgs e)
        {
            clearCategory();
            btnAddCategory.Enabled = true;
            bntRemoveCategory.Enabled = true;
            btnEditCategory.Enabled = true;
            btnLuuCategory.Enabled = false;
            btnCancelCategory.Enabled = false;
        }

        private void btnLuuCategory_Click(object sender, EventArgs e)
        {
            // Thêm loại món ăn
            if (IsAccessible == true) // Thuộc tính này được sử dụng để xác định xem một thành phần giao diện (control) có khả năng tương tác với người dùng hay không 
            {
                string name = txtCategoryName.Text;
                try
                {

                    if (txtCategoryName.Text == "")
                    {
                        MessageBox.Show("Thêm loại món ăn thất bại , vui lòng nhập đầy đủ thông tin!!!", "Thông báo");
                    }
                    else
                    {
                        if (CategoryDAO.Instance.checkCategoryExists(name))
                        {
                            MessageBox.Show("Thêm loại món thất bại , đã tồn tại loại món ăn này!!!", "Thông báo");
                            clearCategory();
                        }
                        else
                        {
                            CategoryDAO.Instance.InsertCategory(name);
                            MessageBox.Show("Thêm loại món ăn thành công");
                            LoadCategory();
                            bntRemoveCategory.Enabled = true;
                            btnEditCategory.Enabled = true;
                            btnLuuCategory.Enabled = false;
                            btnCancelCategory.Enabled = false;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm loại món ăn thất bại , đã tồn tại loại món ăn này!!!", "Thông báo");
                    clearCategory();
                }

            }
            if (IsAccessible == false) // Update món ăn
            {

                string name = txtCategoryName.Text;
                try
                {
                    if (txtCategoryName.Text == "" || txtIdCategory.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật loại món ăn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            int id = int.Parse(txtIdCategory.Text);
                            CategoryDAO.Instance.UpdateCategory(name, id);
                            MessageBox.Show("Cập nhật loại món ăn thành công");
                            LoadCategory();
                            bntRemoveCategory.Enabled = true;
                            btnAddCategory.Enabled = true;
                            btnLuuCategory.Enabled = false;
                            btnCancelCategory.Enabled = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xảy ra: " + ex.Message);
                }
            }
        }

    }
}
