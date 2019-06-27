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
    public class LichChamSocDAL
    {
        private string connectionString;


        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public LichChamSocDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool themLich(LichchamsocDTO lich)
        {
            string query = string.Empty;
            query += "INSERT INTO [LICHCHAMSOC] ([machamsoc],[thoigian],[mavattu],[madonvitinh],[soluong],[ghichu],[macay],[ngaylaplich])";
            query += "VALUES (@machamsoc,@thoigian,@mavattu,@madonvitinh,@soluong,@ghichu,@macay,@ngaylaplich)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@machamsoc", lich.MaChamSocPT);
                    cmd.Parameters.AddWithValue("@thoigian", lich.ThoiGianPT);
                    cmd.Parameters.AddWithValue("@mavattu", lich.MaVatTuPT);
                    cmd.Parameters.AddWithValue("@madonvitinh", lich.MaDonViTinhPT);
                    cmd.Parameters.AddWithValue("@soluong", lich.SoLuongPT);
                    cmd.Parameters.AddWithValue("@ghichu", lich.GhiChuPT);
                    cmd.Parameters.AddWithValue("@macay", lich.MaCayPT);
                    cmd.Parameters.AddWithValue("@ngaylaplich", lich.NgayLapLichPT);

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
        public List<LichchamsocDTO> selectByKeyWord(string sKeyword)
        {

            string query = string.Empty;
            query += " SELECT [machamsoc],[thoigian],[mavattu],[madonvitinh],[soluong],[ghichu],[macay],[ngaylaplich]";
            query += " FROM [LICHCHAMSOC]";
            query += " WHERE ([macay] LIKE CONCAT('%',@sKeyword,'%'))";



            List<LichchamsocDTO> lsLich = new List<LichchamsocDTO>();

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
                                LichchamsocDTO lich = new LichchamsocDTO();
                                lich.MaChamSocPT = reader["machamsoc"].ToString();
                                lich.MaVatTuPT = int.Parse(reader["mavattu"].ToString());
                                lich.MaDonViTinhPT = int.Parse(reader["madonvitinh"].ToString());
                                lich.SoLuongPT = int.Parse(reader["soluong"].ToString());
                                lich.ThoiGianPT = long.Parse(reader["thoigian"].ToString());
                                lich.GhiChuPT = reader["ghichu"].ToString();
                                lich.MaCayPT = reader["macay"].ToString();
                                lich.NgayLapLichPT = DateTime.Parse(reader["ngaylaplich"].ToString());
                                lsLich.Add(lich);
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
            return lsLich;
        }
    }
}
