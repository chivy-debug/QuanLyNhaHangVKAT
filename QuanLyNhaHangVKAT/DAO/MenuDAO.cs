using QuanLyNhaHangVKAT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangVKAT.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return instance; }
            private set { instance = value; }
        }

        private MenuDAO() { }
        public List<MenuData> GetListMenuByTable(int id)
        {

            List<MenuData> listMenu = new List<MenuData>();

            string query = "SELECT f.name , bi.count , f.price , f.price*bi.count AS TotalPrice \r\nFROM BillInfor bi , Bill b , Food f\r\nWHERE bi.idBill = b.id and bi.idFood = f.id and Status =0 and b.idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MenuData menu = new MenuData(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
