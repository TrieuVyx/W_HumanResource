using System.Configuration;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace HumanResource.src.DbContext
{
    
    class Dbcontext
    {
        string connectStringDb = "";
        private SqlConnection connection;


        public SqlConnection connectOpen() { 
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
        private void OpenConnection()
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

        private void CloseConnection()
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
    }
}
