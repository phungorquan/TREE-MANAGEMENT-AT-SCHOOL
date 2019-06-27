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

        public bool themViTri(ViTriDTO vitri)
        {
            string query = string.Empty;
            query += "INSERT INTO [VITRI] ([mavitri],[tenvitri],[soluong])";
            query += "VALUES (@mavitri,@tenvitri,@soluong)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mavitri", vitri.MaViTriPT);
                    cmd.Parameters.AddWithValue("@tenvitri", vitri.TenViTriPT);
                    cmd.Parameters.AddWithValue("@soluong", vitri.SoLuongPT);
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

        public bool xoaViTri(ViTriDTO vitri)
        {
            string query = string.Empty;
            query += "DELETE FROM tblCayCanh WHERE [mavitri] = @mavitri";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mavitri", vitri.MaViTriPT);
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

        public bool suaViTri(ViTriDTO vitri)
        {
            string query = string.Empty;
            query += "UPDATE VITRI SET [mavitri] = @mavitri, [tenvitri] = @tenvitri, [soluong] = @soluong WHERE [mavitri] = @mavitri";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mavitri", vitri.MaViTriPT);
                    cmd.Parameters.AddWithValue("@tenvitri", vitri.TenViTriPT);
                    cmd.Parameters.AddWithValue("@soluong", vitri.SoLuongPT);
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

        public List<ViTriDTO> selectViTri()
        {
            string query = string.Empty;
            query += "SELECT [mavitri], [tenvitri],[soluong]";
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
                                VT.SoLuongPT = int.Parse(reader["soluong"].ToString());
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
