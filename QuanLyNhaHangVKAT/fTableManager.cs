using QuanLyNhaHangVKAT.DAO;
using QuanLyNhaHangVKAT.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHangVKAT
{
    public partial class fTableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount 
        {
            get { return loginAccount; }
            set { loginAccount = value; typeAccount(loginAccount.Type); } // tính đóng gói oop
        }
        

        public fTableManager(Account acc)
        {
            InitializeComponent();
            LoadTable();
            loadCategory();
            loadCbTable(cbSwitchTable);
            this.LoginAccount = acc;
            txtHienThi.Text = "Xin chào " + loginAccount.DisplayName + "";
            
        }

        #region method
        void typeAccount(int type)
        {
            btnAdmin.Enabled = type == 0; // type = 0 là admin

        }
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button()
                {
                    Width = TableDAO.tableWidth,
                    Height = TableDAO.tableHeight
                };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += Btn_Click; // show bên trong bàn
                btn.Tag = item;
                btn.FlatAppearance.BorderColor = Color.Red;
                btn.FlatAppearance.MouseOverBackColor = Color.Salmon;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.White;
                        break;
                    default:
                        btn.BackColor = Color.DarkGray;
                        break;
                }
                flpTable.Controls.Add(btn);
                
            }
        }
        void showBill(int id)
        {
            listViewBill.Items.Clear();
            List<MenuData> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;

            foreach (MenuData item in listBillInfo)
            {
                ListViewItem lviItem = new ListViewItem(item.FoodName.ToString());
                lviItem.SubItems.Add(item.Count.ToString()); // lấy thêm các item của id đó
                lviItem.SubItems.Add(item.Price.ToString());
                lviItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                listViewBill.Items.Add(lviItem);
            }

            txtTotalPrice.Text = totalPrice.ToString("#,##0.00 VNĐ");// chỉnh kiểu Format thành giá tiền Việt Nam
            

        }

        void loadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }
        void loadFoodListByCategory(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }
        void loadCbTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }



        #endregion

        #region Events
       
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID ; // id bàn được chọn
            listViewBill.Tag = (sender as Button).Tag;  // bàn được chọn trong listview
            showBill(tableID); 
        }
        private void btnAccountIn_Click(object sender, EventArgs e)
        {
            fAccountIformation f = new fAccountIformation(loginAccount);
            f.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.loginAccount = loginAccount;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


   
        private void cbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            int id = 0;
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
            {
                return;
            }
            Category selected = cb.SelectedItem as Category;
            id = selected.Id;
            loadFoodListByCategory(id);
        }
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            Table table = listViewBill.Tag as Table;  //Bàn được chọn

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn","Thông báo");
                return;
            }

            int idBill = BillDAO.Instance.GetBillIDByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).Id;
            int count = (int)nmFoodCount.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
                nmFoodCount.Value = 1;
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
                nmFoodCount.Value = 1;
            }

            showBill(table.ID);
            LoadTable();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Table table = listViewBill.Tag as Table; // Bàn được chọn

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn", "Thông báo");
                return;
            }
            int idBill = BillDAO.Instance.GetBillIDByTableID(table.ID);
            int discount = (int)nmDiscount.Value;

            double thanhTien = Convert.ToDouble(txtTotalPrice.Text.Split('.')[0]); // lấy phần số trước dấu chấm , split là hàm tách chuỗi
            double totalPrice = thanhTien - ((thanhTien/100)  * discount );
            if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho {0}\nGiảm giá : {1}% \nTổng tiền cần thanh toán : {2} ", table.Name, discount, totalPrice), "Xác nhận thanh toán", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                BillDAO.Instance.CheckOut(idBill,discount ,(float)totalPrice);
                showBill(table.ID);
                LoadTable();
                nmDiscount.Value = 0;
            }

        }
        private void BtnSwitchTable_Click(object sender, EventArgs e)
        {
            int id1 = (listViewBill.Tag as Table).ID; // bàn được chọn

            int id2 = (cbSwitchTable.SelectedItem as Table).ID; // bàn được chọn trong combobox
            try
            {
                
                    if (MessageBox.Show(string.Format("Bạn có muốn chuyển {0} qua {1}", (listViewBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        TableDAO.Instance.SwitchTable(id1, id2);

                        LoadTable();
                    }
                
            }
            catch
            {
                MessageBox.Show("Hãy chọn bàn muốn chuyển", "Thông báo");
            }

        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void AccountProfile(Account acc) // hien thong tin
        {

            txtHienThi.Text = "Xin chào " + loginAccount.DisplayName + "";
        }








        #endregion
    }
}
