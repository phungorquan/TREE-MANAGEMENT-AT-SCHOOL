using TreeDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDAL
{
    public class DonViTinhDAL
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public DonViTinhDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public List<DonViTinhDTO> selectDonViTinh()
        {
            string query = string.Empty;
            query += "SELECT [madonvitinh], [tendonvitinh]";
            query += "FROM [DONVITINH]";

            List<DonViTinhDTO> lsDonViTinh = new List<DonViTinhDTO>();

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
                                DonViTinhDTO DVT = new DonViTinhDTO();
                                DVT.MaDonViTinhPT = int.Parse(reader["madonvitinh"].ToString());
                                DVT.TenDonViTinhPT = reader["tendonvitinh"].ToString();
                                lsDonViTinh.Add(DVT);
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
            return lsDonViTinh;
        }
    }
}
