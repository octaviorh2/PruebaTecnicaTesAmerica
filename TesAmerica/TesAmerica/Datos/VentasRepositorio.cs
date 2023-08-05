using System.Data;
using System.Data.SqlClient;
using TesAmerica.LogicaNegocios.Dominio;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TesAmerica.Datos
{
    public class VentasRepositorio
    {
        ConnectionManager conexion = new ConnectionManager();
        public List<AcumuladoVenta> AcumuladoDepartamento(DateTime fehainicial, DateTime fechafinal)
        {
           
            try
            {
                List<AcumuladoVenta> acumulados = new List<AcumuladoVenta>();

                using (var cn = new SqlConnection(conexion.GetCadena()))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("ObtenerVentasAcumuladasPorDepartamento", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FechaInicio", FechaPArseada(fehainicial)));
                    cmd.Parameters.Add(new SqlParameter("@FechaFin", FechaPArseada(fechafinal)));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AcumuladoVenta acumulado = new AcumuladoVenta
                            {
                                NombreDepartamento = reader["Departamento"].ToString(),
                                Acumulado = Convert.ToDecimal(reader["VentasAcumuladas"])
                            };

                            acumulados.Add(acumulado);
                        }
                    }
                }

                return acumulados;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public List<Vendedor> Comusion_Vendendor( DateTime fecha) {
            try
            {
                List<Vendedor> vendedor = new List<Vendedor>();
                int mes = fecha.Month;
                int Anio = fecha.Year;
                using (var cn = new SqlConnection(conexion.GetCadena()))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("ObtenerComisionPorVendedor", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Mes", mes));
                    cmd.Parameters.Add(new SqlParameter("@Anio", Anio));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Vendedor vendedor1 = new Vendedor
                            {
                                Codvend = reader["CodigoVendedor"].ToString(),
                                Nombre = reader["NombreVendedor"].ToString(),
                                Comision = Convert.ToDecimal(reader["ComisionObtenida"])
                            };

                            vendedor.Add(vendedor1);
                        }
                    }
                }

                return vendedor;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string FechaPArseada(DateTime fecha) {

            int dia = fecha.Day;
            int mes = fecha.Month;
                int año = fecha.Year;
            return $"{mes}-{dia}-{año}";
        }


    }
}
