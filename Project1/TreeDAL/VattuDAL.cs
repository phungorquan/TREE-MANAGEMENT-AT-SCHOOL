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
        public bool themVatTu(VattuDTO tree)
        {
            return true;
        }
        public bool xoaVatTu(VattuDTO tree)
        {
            return true;
        }
        public bool suaVatTu(VattuDTO kn)
        {
            return true;
        }

        public List<VattuDTO> selectVatTu()
        {
            return null;
        }
    }
}

