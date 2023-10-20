using QuanLyNhaHangVKAT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangVKAT.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null) instance = new CategoryDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private CategoryDAO() { }

        public List<Category> GetListCategory() // danh sách category
        {
            List<Category> list = new List<Category>();

            string query = "select * from FoodCategory";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }
        public Category GetCategoryByID(int id)  // xuất category theo id
        {
            Category category = null;

            string query = "select * from FoodCategory where id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }

            return category;
        }
        public bool checkCategoryExists(string categoryName) // kiểm tra loại món ăn đã tồn tại chưa
        {
            string query = string.Format("SELECT COUNT(*) FROM FoodCategory WHERE name = N'{0}' ", categoryName);
            int result = (int)DataProvider.Instance.ExeucuteScalar(query);

            return result > 0; // nếu có 1 dòng chạy sẽ trả về
        }
        public bool InsertCategory(string name)
        {
            string query = string.Format("INSERT FoodCategory ( name )VALUES  ( N'{0}')", name );
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCategory(string name , int id)
        {
            string query = string.Format("UPDATE dbo.FoodCategory SET name = N'{0}' WHERE id = N'{1}'", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteCategory(int id)
        {
            string query = string.Format("Delete FoodCategory WHERE id = N'{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
