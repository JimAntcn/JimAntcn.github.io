using System.Data;
using System.Data.SqlClient;

namespace DataAcess
{
    public class DACRUD
    {
        public static void ConsultaSql(DataSet ds)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Estaciones order by Cod_Hidro", SqlConexion.con);
          
            da.Fill(ds);
        }
    }
}
