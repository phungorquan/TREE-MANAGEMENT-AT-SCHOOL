using System;
using TreeDTO;
using System.Configuration;
using System.Data.SqlClient;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDAL
{
    public class TTrangDAL
    {
        private string connectionString;
        public TTrangDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public bool themTT(TTCayDTO TT)
        {
            string query = string.Empty;
            query += "INSERT INTO [TINHTRANGCAYCANH] ([matinhtrangthang],[thangtt]) ";
            query += "VALUES (@matinhtrangthang,@thangtt)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@machiphithang", TT.MaTinhTrangThangPT);
                    cmd.Parameters.AddWithValue("@thang", TT.ThangTTPT);

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

