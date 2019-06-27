using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDTO;
using System.Configuration;
using System.Data.SqlClient;

namespace TreeDAL
{
    public class PhieuMuaVatTuDAL
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public PhieuMuaVatTuDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool themPhieu(PhieuMuaVatTuDTO phieu)
        {
            string query = string.Empty;
            query += "INSERT INTO [PHIEUMUAVATTU] ([maphieumua],[mavattu],[madonvitinh],[diachimua],[soluong],[sotien],[ngaymua])";
            query += "VALUES (@maphieumua,@mavattu,@madonvitinh,@diachimua,@soluong,@sotien,@ngaymua)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maphieumua", phieu.PhieuMuaVatTuPT);
                    cmd.Parameters.AddWithValue("@mavattu", phieu.MaVatTuPT);
                    cmd.Parameters.AddWithValue("@madonvitinh", phieu.MaDonViTinhPT);
                    cmd.Parameters.AddWithValue("@diachimua", phieu.DiaChiMuaPT);
                    cmd.Parameters.AddWithValue("@soluong", phieu.SoLuongPT);
                    cmd.Parameters.AddWithValue("@sotien", phieu.SoTienPT);
                    cmd.Parameters.AddWithValue("@ngaymua", phieu.NgayMuaPT);
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
        public List<PhieuMuaVatTuDTO> selectPhieu()
        {
            string query = string.Empty;
            query += "SELECT[maphieumua],[mavattu],[madonvitinh],[diachimua],[soluong],[sotien],[ngaymua]";
            query += "FROM [PHIEUMUAVATTU]";

            List<PhieuMuaVatTuDTO> lsPhieuMua = new List<PhieuMuaVatTuDTO>();

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
                                PhieuMuaVatTuDTO phieu = new PhieuMuaVatTuDTO();
                                phieu.PhieuMuaVatTuPT = reader["maphieumua"].ToString();
                                phieu.MaVatTuPT = int.Parse(reader["mavattu"].ToString());
                                phieu.MaDonViTinhPT = int.Parse(reader["madonvitinh"].ToString());
                                phieu.DiaChiMuaPT = reader["diachimua"].ToString();
                                phieu.SoLuongPT = int.Parse(reader["soluong"].ToString());
                                phieu.SoTienPT = int.Parse(reader["sotien"].ToString());
                                phieu.NgayMuaPT = DateTime.Parse(reader["ngaymua"].ToString());
                                lsPhieuMua.Add(phieu);
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
            return lsPhieuMua;
        }
    }
}
