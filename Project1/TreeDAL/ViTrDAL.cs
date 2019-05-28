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
    public class ViTrDAL
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public ViTrDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        //Phuong Thuc

        public List<ViTriDTO> selectViTri()
        {
            string query = string.Empty;
            query += "SELECT [mavitri], [tenvitri]";
            query += "FROM [VITRI]";

            List<ViTriDTO> lsViTri = new List<ViTriDTO>();

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
                                ViTriDTO VT = new ViTriDTO();
                                VT.MaViTriPT = int.Parse(reader["mavitri"].ToString());
                                VT.TenViTriPT = reader["tenvitri"].ToString();
                                lsViTri.Add(VT);
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
            return lsViTri;


        }
    }
}
