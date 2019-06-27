using System;
using TreeDTO;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDAL
{
    public class ChamSocThangDAL
    {
        private string connectionString;
        public ChamSocThangDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public bool themThang(ChamSocThangDTO thang)
        {
            string query = string.Empty;
            query += "INSERT INTO [CHIPHICHAMSOCTHANG] ([machiphithang],[thang]) ";
            query += "VALUES (@machiphithang,@thang)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@machiphithang", thang.MaChiPhiThangPT);
                    cmd.Parameters.AddWithValue("@thang", thang.ThangPT);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
