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
    public class TinhTrangDAL
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public TinhTrangDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public List<TinhTrangDTO> selectTinhTrang()
        {
            string query = string.Empty;
            query += "SELECT [matinhtrang], [tentinhtrang]";
            query += "FROM [TINHTRANG]";

            List<TinhTrangDTO> lsTinhTrang = new List<TinhTrangDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                TinhTrangDTO TT = new TinhTrangDTO();
                                TT.MaTinhTrangPT = int.Parse(reader["matinhtrang"].ToString());
                                TT.TenTinhTrangPT = reader["tentinhtrang"].ToString();
                                lsTinhTrang.Add(TT);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lsTinhTrang;


        }
    }
}
