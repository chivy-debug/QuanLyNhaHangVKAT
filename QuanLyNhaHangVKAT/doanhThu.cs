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
    public partial class doanhThu : UserControl
    {
        public doanhThu()
        {
            InitializeComponent();

        }
        decimal loadListDoanhThu(DateTime checkIn, DateTime checkOut)  // decimal là 1 dạng số thực
        {
            dgvThongKe.DataSource = BillDAO.Instance.GetListDoanhThu(checkIn, checkOut);  // xuất danh sách doanh thu
            DataTable resultTable = DataProvider.Instance.ExecuteQuery("exec USP_TongDoanhThu @checkin , @checkout", new object[] { checkIn, checkOut });
            try
            {
                if (resultTable.Rows.Count > 0)
                {
                    // Lấy kết quả từ DataTable 
                    decimal tongDoanhThu = Convert.ToDecimal(resultTable.Rows[0][0]);

                    // Hiển thị kết quả lên TextBox
                    txtTotalDoanhThu.Text = tongDoanhThu.ToString("#,##0 VNĐ");

                    return tongDoanhThu;
                }
            }
            catch { }

            return 0; // hoặc giá trị mặc định khác nếu không có kết quả
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            loadListDoanhThu(dtIn.Value, dtOut.Value);
        }

        private void btnThoatDoanhThu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
