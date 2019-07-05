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
    public class VattuDAL
    {
        private string connectionStringVattu;

        public VattuDAL()
        {
            connectionStringVattu = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionStringVattu
        {
            get => connectionStringVattu;
            set => connectionStringVattu = value;
        }
        //-------------------------------------------------------------------------------------------//
        //Phuong Thuc
        public bool themVatTu(VattuDTO vattu)
        {
            string query = string.Empty;
            query += "INSERT INTO [VATTU] ([mavattu],[tenvattu],[diachiban]) ";
            query += "VALUES (@mavattu,@tenvattu,@diachiban)";
            using (SqlConnection con = new SqlConnection(ConnectionStringVattu))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mavattu", vattu.MaVatTuPT);
                    cmd.Parameters.AddWithValue("@tenvattu", vattu.TenVatTuPT);
                    cmd.Parameters.AddWithValue("@diachiban", vattu.DiaChiBanPT);
     
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
        public bool xoaVatTu(VattuDTO vattu)
        {
            string query = string.Empty;
            query += "DELETE FROM VATTU WHERE [mavattu] = @mavattu";
            using (SqlConnection con = new SqlConnection(ConnectionStringVattu))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mavattu", vattu.MaVatTuPT);
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
        public bool suaVatTu(VattuDTO vattu)
        {
            string query = string.Empty;
            query += "UPDATE VATTU SET [tenvattu] = @tenvattu, [diachiban] = @diachiban WHERE [mavattu] = @mavattu";
            using (SqlConnection con = new SqlConnection(ConnectionStringVattu))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@mavattu", vattu.MaVatTuPT);
                    cmd.Parameters.AddWithValue("@tenvattu", vattu.TenVatTuPT);
                    cmd.Parameters.AddWithValue("@diachiban", vattu.DiaChiBanPT);

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

        public List<VattuDTO> selectVatTu()
        {
            string query = string.Empty;
            query += "SELECT[mavattu],[tenvattu],[diachiban]";
            query += "FROM [VATTU]";

            List<VattuDTO> lsVattu = new List<VattuDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionStringVattu))
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
                                VattuDTO vattu = new VattuDTO();
                                vattu.MaVatTuPT = int.Parse(reader["mavattu"].ToString());
                                vattu.TenVatTuPT = reader["tenvattu"].ToString();
                                vattu.DiaChiBanPT = reader["diachiban"].ToString();
                                lsVattu.Add(vattu);
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
            return lsVattu;
        }
    }
}

