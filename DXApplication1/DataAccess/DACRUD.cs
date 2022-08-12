using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DACRUD
    {
        public static void ConsultaSql(DataSet ds)
        {
            SqlDataAdapter da = new SqlDataAdapter("select Cod_Hidro, Estacion, Rio, Cuenca,Ancho,Alto, Dpto, Prov from Estaciones order by Cod_Hidro", SqlConexion.con);

            da.Fill(ds);
        }


        public static void ConsultaEstaciones(DataSet ds)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Cod_Hidro, Estacion from Estaciones order by Cod_Hidro", SqlConexion.con);
            da.Fill(ds);
        }

        public static void BorrarEstacion(string estacion)
        {
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = SqlConexion.con;
                command.CommandText = "DELETE FROM Estaciones WHERE Estacion = @Estacion";
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@Estacion", estacion);

                SqlConexion.con.Open();
                command.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                SqlConexion.con.Close();
                
            }
        }


        public static void ConsultaRioYCuenca(DataSet ds)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT DISTINCT Rio from Estaciones order by Rio;
                                                    SELECT DISTINCT Cuenca from Estaciones order by Cuenca", SqlConexion.con);
            da.Fill(ds);
        }

   


        public static void AgregarEstación(Estacion estacion)
        {
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = SqlConexion.con;
                command.CommandText = "INSERT Estaciones (Cod_HIdro, Estacion,Rio, Cuenca,Ancho,Alto, Dpto, Prov) VALUES (@CodHIdro, @Estacion,@Rio, @Cuenca,@Ancho,@Alto, @Dpto, @Prov)";
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@CodHIdro", estacion.CodHidro);
                command.Parameters.AddWithValue("@Estacion", estacion.Nombre);
                command.Parameters.AddWithValue("@Rio", estacion.Rio);
                command.Parameters.AddWithValue("@Cuenca", estacion.Cuenca);
                command.Parameters.AddWithValue("@Ancho", estacion.Ancho);
                command.Parameters.AddWithValue("@Alto", estacion.Alto);
                command.Parameters.AddWithValue("@Dpto", estacion.Dpto);
                command.Parameters.AddWithValue("@Prov", estacion.Prov);


                SqlConexion.con.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                SqlConexion.con.Close();

            }
        }

        public static Estacion DatosDeEstacion(string cod)
        {
            SqlDataAdapter da = new SqlDataAdapter("select Cod_Hidro, Estacion, Rio, Cuenca,Ancho,Alto, Dpto, Prov from Estaciones where Cod_Hidro = @CodHidro", SqlConexion.con);
            DataTable dt = new DataTable();
            da.SelectCommand.Parameters.AddWithValue("@CodHidro", cod);            
            da.Fill(dt);

            DataRow dr = dt.Rows[0];

            return new Estacion()
            {
                CodHidro = dr["Cod_Hidro"].ToString(),
                Nombre = dr["Estacion"].ToString(),
                Rio = dr["Rio"].ToString(),
                Cuenca = dr["Cuenca"].ToString(),
                Ancho = decimal.Parse(dr["Ancho"].ToString()),
                Alto = (int)decimal.Parse(dr["Alto"].ToString()),
                Dpto = dr["Dpto"].ToString(),
                Prov = dr["Prov"].ToString()
            };
        }

    }
}
