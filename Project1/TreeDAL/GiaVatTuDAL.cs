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
    public class GiaVatTuDAL
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public GiaVatTuDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool themGia(GiaVatTuDTO gia)
        {
            string query = string.Empty;
            query += "INSERT INTO [GIAVATTU] ([magiavattu],[giavattu],[mavattu]) ";
            query += "VALUES (@magiavattu,@giavattu,@mavattu)";
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@magiavattu", gia.MaGiaVatTuPT);
                    cmd.Parameters.AddWithValue("@giavattu", gia.GiaVatTuPT);
                    cmd.Parameters.AddWithValue("@mavattu", gia.MaVatTuPTGV);

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

        public bool xoaGia(GiaVatTuDTO Gia)
        {
            string query = string.Empty;
            query += "DELETE FROM GIAVATTU WHERE [mavattu] = @mavattu";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mavattu", Gia.MaVatTuPTGV);
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

        public bool suaGia(GiaVatTuDTO Gia)
        {
            string query = string.Empty;
            query += "UPDATE GIAVATTU SET [magiavattu] = @magiavattu, [giavattu] = @giavattu WHERE [mavattu] = @mavattu";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@magiavattu", Gia.MaGiaVatTuPT);
                    cmd.Parameters.AddWithValue("@giavattu", Gia.GiaVatTuPT);
                    cmd.Parameters.AddWithValue("@mavattu", Gia.MaVatTuPTGV);
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
        public List<GiaVatTuDTO> selectGiaVat()
        {
            string query = string.Empty;
            query += "SELECT [magiavattu], [giavattu],[mavattu]";
            query += "FROM [GIAVATTU]";

            List<GiaVatTuDTO> lsGiaVatTu = new List<GiaVatTuDTO>();

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
                                GiaVatTuDTO GVT = new GiaVatTuDTO();
                                GVT.MaGiaVatTuPT = int.Parse(reader["magiavattu"].ToString());
                                GVT.GiaVatTuPT = int.Parse(reader["giavattu"].ToString());
                                GVT.MaVatTuPTGV  = int.Parse(reader["mavattu"].ToString());
                                lsGiaVatTu.Add(GVT);
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
            return lsGiaVatTu;
        }

    }
}
