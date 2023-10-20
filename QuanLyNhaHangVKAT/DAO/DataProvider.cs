using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangVKAT.DAO
{
    public class DataProvider
    {
        private string connectionSTR = @"Data Source=DESKTOP-PBTKRR7;Initial Catalog=QUANLYNHAHANGVKAT;Integrated Security=True";

        private static DataProvider instance;

        public static DataProvider Instance
        {
            get 
            { 
                if (instance == null) instance = new DataProvider();
                return instance; 
            }
            private set { instance = value; }
        }
        private DataProvider() 
        { 

        }

        public DataTable ExecuteQuery(string query, object[] parameter = null)//tra ra ket qua
        {
            DataTable data = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(connectionSTR))
            {//giai phong du lieu

                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(data);
                sqlConnection.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)//tra ve so dong duoc thuc thi
        {
            int data = 0;

            using (SqlConnection sqlConnection = new SqlConnection(connectionSTR))
            {//giai phong du lieu

                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
  
                data = cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return data;
        }

        public object ExeucuteScalar(string query, object[] parameter = null)//tra ve count *
        {
            object data = 0;

            using (SqlConnection sqlConnection = new SqlConnection(connectionSTR))
            {//giai phong du lieu

                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                sqlConnection.Close();
            }
            return data;
        }

    }
}
