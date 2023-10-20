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
    public partial class UserMonAn : UserControl
    {
        BindingSource foodList = new BindingSource();
        public UserMonAn()
        {
            InitializeComponent();
            dgvFood.DataSource = foodList; // binding food
            loadListFood();
            FoodBinding();
            LoadCategoryIntoCombobox(cbFoodCategory);
            btnLuuFood.Enabled = false; 
            btnCancelFood.Enabled = false;
        }

        void loadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }
        void FoodBinding() // hàm binding food , true là chấp nhận ép kiểu chuỗi cho nó , DataSourceUpdateMode.Never là không cho sửa đổi giá trị khi binding
        {
            txtFoodName.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtFoodId.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
            cb.ValueMember = "id";
        }
        void clearFood()
        {
            txtFoodId.Clear();
            txtFoodName.Clear();
            cbFoodCategory.Text = string.Empty;
            nmFoodPrice.Value = 0;
        }


        private void txtFoodId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvFood.SelectedCells.Count > 0) 
                {
                    DataGridViewCell selectedCell = dgvFood.SelectedCells[0]; // nếu có dữ liệu sẽ truy cập vào dữ liệu đầu tiên [0] 

                    if (selectedCell.OwningRow.Cells["idCategory"].Value != null) // ktra xem idCategory có trống không , nếu không trống sẽ chọn dữ liệu để xuất ra
                    {
                        int categoryId = Convert.ToInt32(selectedCell.OwningRow.Cells["idCategory"].Value);
                        cbFoodCategory.SelectedValue = categoryId;
                    }
                }
            }
            catch
            {

            }
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            clearFood();
            btnEditFood.Enabled = false;
            btnRemoveFood.Enabled = false;
            btnFoodWatch.Enabled = false;
            btnSearchFood.Enabled = false;
            btnLuuFood.Enabled = true;
            btnCancelFood.Enabled = true;
            IsAccessible = true; // Thuộc tính này được sử dụng để xác định xem một thành phần giao diện (control) có khả năng tương tác với người dùng hay không
            MessageBox.Show("Vui lòng nhập thông tin món ăn", "Thông báo");
        }

        private void UserMonAn_Load(object sender, EventArgs e)
        {

        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            clearFood();
            btnAddFood.Enabled = false;
            btnRemoveFood.Enabled = false;
            btnFoodWatch.Enabled = false;
            btnSearchFood.Enabled = false;
            btnLuuFood.Enabled = true;
            btnCancelFood.Enabled = true;
            IsAccessible = false;
            MessageBox.Show("Vui lòng chọn món ăn muốn cập nhật", "Thông báo");
        }

        private void btnRemoveFood_Click(object sender, EventArgs e)
        {
            if (txtFoodName.Text == "" || txtFoodId.Text == "")
            {
                MessageBox.Show("Vui lòng chọn món ăn muốn xóa!!!", "Thông báo");
            }
            else
            {
                int id = Convert.ToInt32(txtFoodId.Text);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn này?\n(Không thể hoàn tác sau khi xóa)", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    FoodDAO.Instance.DeleteFood(id);
                    MessageBox.Show("Xóa món thành công");
                }
                loadListFood();
            }
        }

        private void btnFoodWatch_Click(object sender, EventArgs e)
        {
            loadListFood();
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            string name = txtSearchFood.Text;
            if (txtSearchFood.Text == "")
            {
                MessageBox.Show("Nhập tên món ăn cần tìm", "Thông báo");
            }
            else
            {
                try
                {
                    foodList.DataSource = FoodDAO.Instance.SearchFoodByName(name);
                }
                catch
                {
                    MessageBox.Show("Không tìm thấy tên món ăn");
                }
            }
        }

        private void btnLuuFood_Click(object sender, EventArgs e)
        {
            // Thêm món ăn
            if (IsAccessible == true) // Thuộc tính này được sử dụng để xác định xem một thành phần giao diện (control) có khả năng tương tác với người dùng hay không 
            {
                string name = txtFoodName.Text;
                int categoryID = (cbFoodCategory.SelectedItem as Category).Id;
                float price = (float)nmFoodPrice.Value;
                try
                {

                    if (txtFoodName.Text == "")
                    {
                        MessageBox.Show("Thêm món ăn thất bại , vui lòng nhập đầy đủ thông tin!!!", "Thông báo");
                    }
                    else
                    {
                        if (FoodDAO.Instance.checkFoodExists(name))  // nếu có dữ liệu trả về thì món ăn đã tồn tại
                        {
                            MessageBox.Show("Thêm món thất bại , đã tồn tại món ăn này!!!", "Thông báo");
                            clearFood();
                        }
                        else
                        {
                            FoodDAO.Instance.InsertFood(name, categoryID, price);
                            MessageBox.Show("Thêm món ăn thành công");
                            loadListFood();
                            btnEditFood.Enabled = true;
                            btnRemoveFood.Enabled = true;
                            btnFoodWatch.Enabled = true;
                            btnSearchFood.Enabled = true;
                            btnLuuFood.Enabled = false;
                            btnCancelFood.Enabled = false;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm món ăn thất bại , đã tồn tại món ăn này!!!", "Thông báo");
                    clearFood();
                }

            }

            if (IsAccessible == false) // Update món ăn
            {
                string name = txtFoodName.Text;
                int categoryID = (cbFoodCategory.SelectedItem as Category).Id;
                float price = (float)nmFoodPrice.Value;
                try
                {
                    if (txtFoodName.Text == "" || txtFoodId.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật món ăn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            int id = Convert.ToInt32(txtFoodId.Text);
                            FoodDAO.Instance.UpdateFood(id, name, categoryID, price);
                            MessageBox.Show("Cập nhật món ăn thành công");
                            loadListFood();
                            btnRemoveFood.Enabled = true;
                            btnFoodWatch.Enabled = true;
                            btnSearchFood.Enabled = true;
                            btnAddFood.Enabled = true;
                            btnLuuFood.Enabled = false;
                            btnCancelFood.Enabled = false;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xảy ra: " + ex.Message);
                }
            }
        }

        private void btnCancelFood_Click(object sender, EventArgs e)
        {
            clearFood();
            btnEditFood.Enabled = true;
            btnRemoveFood.Enabled = true;
            btnFoodWatch.Enabled = true;
            btnSearchFood.Enabled = true;
            btnAddFood.Enabled = true;
            btnLuuFood.Enabled = false;
            btnCancelFood.Enabled = false;
        }

    }
}
