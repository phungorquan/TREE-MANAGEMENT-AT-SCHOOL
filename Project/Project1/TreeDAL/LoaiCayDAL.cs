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
    public class LoaiCayDAL
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public LoaiCayDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        //Phuong Thuc


        public List<LoaiCayDTO> selectLoaiCay()
        {
            string query = string.Empty;
            query += "SELECT [maloaicay], [tenloaicay]";
            query += "FROM [LOAICAY]";

            List<LoaiCayDTO> lsLoaiCay = new List<LoaiCayDTO>();

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
                                LoaiCayDTO LC = new LoaiCayDTO();
                                LC.MaLoaiCayPT = int.Parse(reader["maloaicay"].ToString());
                                LC.TenLoaiCayPT = reader["tenloaicay"].ToString();
                                lsLoaiCay.Add(LC);
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
            return lsLoaiCay;
        }
    }
}
