
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
    public class BaoCaoDAL
    {
        private string connectionStringBaoCao;

        public BaoCaoDAL()
        {
            connectionStringBaoCao = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionStringBaoCao
        {
            get => connectionStringBaoCao;
            set => connectionStringBaoCao = value;
        }
        //-------------------------------------------------------------------------------------------//
        //Phuong Thuc
        public void BCchamsoc(VattuDTO tree)
        {
         
        }
        public void BCcay(CaycanhDTO tree)
        {
         
        }

    }
}
