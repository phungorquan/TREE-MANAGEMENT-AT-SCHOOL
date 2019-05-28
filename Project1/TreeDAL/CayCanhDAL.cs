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
            query += "UPDATE tblCayCanh SET [tenCay] = @tenCay, [loai] = @loai WHERE [maCay] = @maCay";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maCay", tree.MaCayCanhPT);
                    cmd.Parameters.AddWithValue("@tenCay", tree.TenCayPT);
                    cmd.Parameters.AddWithValue("@loai", tree.MaLoaiCayCanhPT);
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
            return null;
        }
    }
}
