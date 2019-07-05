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
    public class CayCanhDAL
    {
        private string connectionString;
        public CayCanhDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        //-------------------------------------------------------------------------------------------//
        //Phuong Thuc

        public bool themCay(CaycanhDTO tree)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblCayCanh] ([maCay],[tenCay],[maloaicay],[ngayTrong],[mavitri],[tinhTrang]) ";
            query += "VALUES (@maCay,@tenCay,@maloaicay,@ngayTrong,@mavitri,@tinhTrang)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maCay", tree.MaCayCanhPT);
                    cmd.Parameters.AddWithValue("@tenCay", tree.TenCayPT);
                    cmd.Parameters.AddWithValue("@maloaicay", tree.MaLoaiCayCanhPT);
                    cmd.Parameters.AddWithValue("@ngayTrong", tree.NgayTrongPT);
                    cmd.Parameters.AddWithValue("@mavitri", tree.MaViTriPT);
                    cmd.Parameters.AddWithValue("@tinhTrang", tree.TinhTrangPT);
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

        public bool xoaCay(CaycanhDTO tree)
        {
            string query = string.Empty;
            query += "DELETE FROM tblCayCanh WHERE [maCay] = @maCay";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maCay", tree.MaCayCanhPT);
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

        public bool suaCay(CaycanhDTO tree)
        {
            string query = string.Empty;
            query += "UPDATE tblCayCanh SET [tenCay] = @tenCay, [maloaicay] = @maloaicay, [ngayTrong] = @ngayTrong, [mavitri] = @mavitri,[tinhTrang] = @tinhTrang WHERE [maCay] = @maCay";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maCay", tree.MaCayCanhPT);
                    cmd.Parameters.AddWithValue("@tenCay", tree.TenCayPT);
                    cmd.Parameters.AddWithValue("@maloaicay", tree.MaLoaiCayCanhPT);
                    cmd.Parameters.AddWithValue("@ngayTrong", tree.NgayTrongPT);
                    cmd.Parameters.AddWithValue("@mavitri", tree.MaViTriPT);
                    cmd.Parameters.AddWithValue("@tinhTrang", tree.TinhTrangPT);
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

        public List<CaycanhDTO> selectCay()
        {
            string query = string.Empty;
            query += "SELECT[maCay],[tenCay],[maloaicay],[ngayTrong],[mavitri],[tinhTrang]";
            query += "FROM [tblCayCanh]";

            List<CaycanhDTO> lsCayCanh = new List<CaycanhDTO>();

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
                                CaycanhDTO cay = new CaycanhDTO();
                                cay.MaCayCanhPT = reader["maCay"].ToString();
                                cay.TenCayPT = reader["tenCay"].ToString();
                                cay.MaLoaiCayCanhPT = int.Parse(reader["maloaicay"].ToString());
                                cay.NgayTrongPT = DateTime.Parse(reader["ngayTrong"].ToString());
                                cay.MaViTriPT = int.Parse(reader["mavitri"].ToString());
                                cay.TinhTrangPT = int.Parse(reader["tinhTrang"].ToString());
                                lsCayCanh.Add(cay);
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
            return lsCayCanh;
        }
        public List<CaycanhDTO> selectByKeyWord(string sKeyword)
        {
            string query = string.Empty;
            query += " SELECT [maCay],[tenCay],[maloaicay],[ngayTrong],[mavitri],[tinhTrang]";
            query += " FROM [tblCayCanh]";
            query += " WHERE ([maCay] LIKE CONCAT('%',@sKeyword,'%'))";


            List<CaycanhDTO> lsCayCanh = new List<CaycanhDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@sKeyword", sKeyword);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                CaycanhDTO cay = new CaycanhDTO();
                                cay.MaCayCanhPT = reader["maCay"].ToString();
                                cay.TenCayPT = reader["tenCay"].ToString();
                                cay.MaLoaiCayCanhPT = int.Parse(reader["maloaicay"].ToString());
                                cay.NgayTrongPT = DateTime.Parse(reader["ngayTrong"].ToString());
                                cay.MaViTriPT = int.Parse(reader["mavitri"].ToString());
                                cay.TinhTrangPT = int.Parse(reader["tinhTrang"].ToString());
                                lsCayCanh.Add(cay);
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
            return lsCayCanh;
        }
    }
}
