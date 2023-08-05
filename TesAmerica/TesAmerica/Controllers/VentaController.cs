using Microsoft.AspNetCore.Mvc;
using TesAmerica.LogicaNegocios.Dominio;
using TesAmerica.LogicaNegocios.Servicio;

namespace TesAmerica.Controllers
{
    public class VentaController : Controller
    {
        VentaService ventaService =  new VentaService();
        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Acumulado(DateTime fechaInicial, DateTime fechaFinal)
        {

            List<AcumuladoVenta> acumulados = ventaService.Acumulado(fechaInicial, fechaFinal);
            return Json(acumulados);

        }

        public IActionResult ComisionVendedor()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Comision(DateTime fecha)
        {

            List<Vendedor> vendedors = ventaService.VendedorComision(fecha);
            return Json(vendedors);

        }

    }
}
