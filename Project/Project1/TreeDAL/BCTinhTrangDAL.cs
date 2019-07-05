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
    public class BCTinhTrangDAL
    {
        private string connectionString;
        public BCTinhTrangDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public bool themBCTT(BCTinhTrangDTO baocao)
        {
            string query = string.Empty;
            query += "INSERT INTO [CTCHIPHICHAMSOCTHANG] ([macttinhtrangcay],[matinhtrangthang],[macay],[maloaicay],[matinhtrang]) ";
            query += "VALUES (@macttinhtrangcay,@matinhtrangthang,@macay,@maloaicay,@matinhtrang)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@macttinhtrangcay", baocao.MaCTTinhTrangCayPT);
                    cmd.Parameters.AddWithValue("@matinhtrangthang", baocao.MaTinhTrangThangPT);
                    cmd.Parameters.AddWithValue("@macay", baocao.MaCayPT);
                    cmd.Parameters.AddWithValue("@maloaicay", baocao.MaLoaiCayPT);
                    cmd.Parameters.AddWithValue("@matinhtrang", baocao.MaTinhTrangPT);

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
        public List<BCTinhTrangDTO> selectBCTT()
        {
            string query = string.Empty;
            query += "SELECT[mactchiphithang],[machiphithang],[mavattu],[sophieumua],[tongtrigia],[tyle]";
            query += "FROM [CTCHIPHICHAMSOCTHANG]";

            List<BCTinhTrangDTO> lsBaoCao = new List<BCTinhTrangDTO>();

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
                                BCTinhTrangDTO BaoCao = new BCTinhTrangDTO();
                                BaoCao.MaCTTinhTrangCayPT = reader["macttinhtrangcay"].ToString();
                                BaoCao.MaTinhTrangThangPT = reader["matinhtrangthang"].ToString();
                                BaoCao.MaCayPT = reader["macay"].ToString();
                                BaoCao.MaLoaiCayPT = int.Parse(reader["maloaicay"].ToString());
                                BaoCao.MaTinhTrangPT = int.Parse(reader["matinhtrang"].ToString());

                                lsBaoCao.Add(BaoCao);
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
            return lsBaoCao;
        }
    }
}

