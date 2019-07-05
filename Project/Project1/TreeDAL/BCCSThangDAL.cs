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
    public class BCCSThangDAL
    {
        private string connectionString;
        public BCCSThangDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public bool themChiPhi(BCCSThangDTO thang)
        {
            string query = string.Empty;
            query += "INSERT INTO [CTCHIPHICHAMSOCTHANG] ([mactchiphithang],[machiphithang],[mavattu],[sophieumua],[tongtrigia],[tyle]) ";
            query += "VALUES (@mactchiphithang,@machiphithang,@mavattu,@sophieumua,@tongtrigia,@tyle)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mactchiphithang", thang.MaCTChiPhiThangPT);
                    cmd.Parameters.AddWithValue("@machiphithang", thang.MaChiPhiThangPT);
                    cmd.Parameters.AddWithValue("@mavattu", thang.MaVatTuPT);
                    cmd.Parameters.AddWithValue("@sophieumua", thang.SoPhieuMuaPT);
                    cmd.Parameters.AddWithValue("@tongtrigia", thang.TongTriGiaPT);
                    cmd.Parameters.AddWithValue("@tyle", thang.TyLePT);

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
        public List<BCCSThangDTO> selectChiPhi()
        {
            string query = string.Empty;
            query += "SELECT[mactchiphithang],[machiphithang],[mavattu],[sophieumua],[tongtrigia],[tyle]";
            query += "FROM [CTCHIPHICHAMSOCTHANG]";

            List<BCCSThangDTO> lsChiPhi = new List<BCCSThangDTO>();

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
                                BCCSThangDTO chiphi = new BCCSThangDTO();
                                chiphi.MaCTChiPhiThangPT = reader["mactchiphithang"].ToString();
                                chiphi.MaChiPhiThangPT = reader["machiphithang"].ToString();
                                chiphi.MaVatTuPT = int.Parse(reader["sophieumua"].ToString());
                                chiphi.SoPhieuMuaPT = int.Parse(reader["ngayTrong"].ToString());
                                chiphi.TongTriGiaPT= int.Parse(reader["tongtrigia"].ToString());
                                chiphi.TyLePT = double.Parse(reader["tyle"].ToString());
                                lsChiPhi.Add(chiphi);
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
            return lsChiPhi;
        }
    }
}
