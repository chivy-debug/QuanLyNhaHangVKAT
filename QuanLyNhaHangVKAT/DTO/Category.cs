using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangVKAT.DTO
{
    public class Category
    {
        public Category(int id , string name)
        {
            this.Name = name;
            this.Id = id;
        }
        public Category(DataRow row)
        {
            this.name = row["name"].ToString(); 
            this.id = (int)row["id"];
        }

        private string name;
        private int id;

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
    }
}
