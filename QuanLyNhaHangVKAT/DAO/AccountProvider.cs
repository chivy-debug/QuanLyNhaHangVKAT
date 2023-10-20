using QuanLyNhaHangVKAT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHangVKAT.DAO
{
    public class AccountProvider
    {
        private static AccountProvider instance;

        public static AccountProvider Instance 
        {
            get
            {
                if (instance == null) instance = new AccountProvider();
                return instance;
            }
            private set { instance = value; }
        }
        private AccountProvider() { }
        public bool login(string userName, string passWord)
        {
            string query = " USP_LOGIN @userName , @passWord ";
            DataTable loGin = DataProvider.Instance.ExecuteQuery(query, new object[] {userName , passWord});
            return loGin.Rows.Count > 0;  // Nếu câu query có thực hiện thì sẽ trả về
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT* FROM dbo.Account WHERE Username ='" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }
        public bool UpdateAccountInformation(string userName , string displayName , string passWord , string newPass) // trong fAccountInformation
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_UpdateAccount @username , @displayname , @password , @newpassword ",new object[] {userName , displayName , passWord , newPass});
            return result > 0;
        }
        public bool checkAccountExists(string userName) // kiểm tra tài khoản đã tồn tại chưa
        {
            string query = string.Format("SELECT COUNT(*) FROM Account WHERE UserName = N'{0}' ", userName);
            int result = (int)DataProvider.Instance.ExeucuteScalar(query);

            return result > 0; // nếu có 1 dòng chạy sẽ trả về
        }
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT UserName, DisplayName, Password , Type FROM dbo.Account");
        }
        public bool InsertAccount(string name, string displayName, int type , string password)
        {
            string query = string.Format("INSERT dbo.Account ( UserName, DisplayName, Type, password )VALUES  ( N'{0}', N'{1}', {2}, N'{3}')", name, displayName, type, password);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string name, string displayName, int type , string password)
        {
            string query = string.Format("UPDATE dbo.Account SET DisplayName = N'{1}', Type = {2} , Password = N'{3}' WHERE UserName = N'{0}'", name, displayName, type , password);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string name)
        {
            string query = string.Format("Delete Account where UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
