using System.Data;
using TesAmerica.Datos;
using TesAmerica.LogicaNegocios.Dominio;

namespace TesAmerica.LogicaNegocios.Servicio
{
    public class VentaService
    {
        VentasRepositorio ventasRepositorio =  new VentasRepositorio();

        public List<AcumuladoVenta> Acumulado( DateTime fechainicial , DateTime fechafinal) {

            List<AcumuladoVenta> acumulados = new List<AcumuladoVenta>();
            acumulados = ventasRepositorio.AcumuladoDepartamento(fechainicial, fechafinal);
            return acumulados;
        
        }

        public List<Vendedor> VendedorComision( DateTime fecha) {
            List<Vendedor> vendedors = new List<Vendedor>();
            vendedors = ventasRepositorio.Comusion_Vendendor(fecha);
            return vendedors;
        }
        
    }
}
