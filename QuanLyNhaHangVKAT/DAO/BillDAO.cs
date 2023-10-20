using QuanLyNhaHangVKAT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangVKAT.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get
            {
                if (instance == null) instance = new BillDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private BillDAO() { }

        public int GetBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT* FROM dbo.Bill WHERE idTable =" + id + " AND status = 0 ");

            if(data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1; // k co gia tri nao
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { id });
        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExeucuteScalar("SELECT MAX(id) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }
        public void CheckOut(int id , int discount , float totalPrice)
        {
            string query = "UPDATE dbo.Bill SET DateCheckOut = GETDATE() , status = 1, " +" discount = " + discount + " , totalPrice = " + totalPrice + " WHERE id = "+id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public DataTable GetListDoanhThu(DateTime checkIn, DateTime checkOut) // lấy doanh thu
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetDoanhThu @checkin , @checkout", new object[] { checkIn, checkOut });
        }



    }
}