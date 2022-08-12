using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public class SqlConexion
    {

        public static readonly SqlConnection con = new SqlConnection("Data Source = DKRS\\SQLEXPRESS; Initial Catalog = TEST;Integrated Security=SSPI;");
        public static SqlConnection AbrirConexion()
        {
            try
            {

                if (con.State != ConnectionState.Open)
                {
                    con.Open();

                }
                return con;
            }
            catch (Exception ex)
            {

                return null;
                throw ex;
            }
        }
        public static void CerrarConexion()
        {
            try
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
