using TreeDTO;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TreeDAL
{
    public class ThamSoDAL
    {
        private string connectionString;
        public ThamSoDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public bool suaThamSo(ThamSoDTO thamso)
        {
            string query = string.Empty;
            query += "UPDATE THAMSO SET [SoLuongCayCanhToiDa] = @SoLuongCayCanhToiDa, [SoTienMuaToiDa] = @SoTienMuaToiDa";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query; 
                    cmd.Parameters.AddWithValue("@SoTienMuaToiDa", thamso.SoTienToiDaPT);
                    cmd.Parameters.AddWithValue("@SoLuongCayCanhToiDa", thamso.SoCayToiDaPT);

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

        public List<ThamSoDTO> selectThamSo()
        {
            string query = string.Empty; 
             query += "SELECT[SoTienMuaToiDa],[SoLuongCayCanhToiDa]";
            query += "FROM [THAMSO]";

            List<ThamSoDTO> lsThamSo = new List<ThamSoDTO>();

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
                                ThamSoDTO thamSo = new ThamSoDTO(); 
                                thamSo.SoTienToiDaPT = int.Parse(reader["SoTienMuaToiDa"].ToString());
                                thamSo.SoCayToiDaPT = int.Parse(reader["SoLuongCayCanhToiDa"].ToString());
                                lsThamSo.Add(thamSo);
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
            return lsThamSo;
        }
    }
}
