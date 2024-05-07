using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace HumanResource.src.DbContext
{

    class Dbcontext
    {
        string connectStringDb = "";
        private SqlConnection connection;


        public SqlConnection connectOpen()
        {
            connectStringDb = ConfigurationManager.ConnectionStrings["connectStringDb"].ConnectionString;
            connection = new SqlConnection(connectStringDb);
            return connection;
        }
        public void connectDB()
        {
            connectStringDb = ConfigurationManager.ConnectionStrings["connectStringDb"].ConnectionString;
            using (connection = new SqlConnection(connectStringDb))
            {
                OpenConnection();

            }

        }
        public void OpenConnection()
        {
            try
            {
                connection.Open();
                MessageBox.Show("Kết nối thành công!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                connection.Close();
                MessageBox.Show("Đã đóng kết nối!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi đóng kết nối SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đóng kết nối: " + ex.Message);
            }
        }
        public string HashMD5(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));

                }
                return builder.ToString();
            }
        }
    }
}
