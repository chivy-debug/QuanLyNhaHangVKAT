using QuanLyNhaHangVKAT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangVKAT.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance 
        {
            get
            {
                if (instance == null) instance = new TableDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private TableDAO() { }
        public static int tableWidth = 100;
        public static int tableHeight = 100;
        public List<Table> LoadTableList() 
        { 
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_TABLELIST"); 

            foreach (DataRow item in data.Rows)
            { 
                Table table = new Table(item);
                tableList.Add(table);

            }

            return tableList;
        
        }
        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTabel @idTable1 , @idTabel2", new object[] { id1, id2 });
        }
    }
}
