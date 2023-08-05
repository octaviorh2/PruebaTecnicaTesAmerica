using Microsoft.Extensions.Configuration;

namespace TesAmerica.Datos
{
    public class ConnectionManager
    {
        private string Cadena = string.Empty;

        public ConnectionManager()
        {
            var builder =   new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            Cadena = builder.GetSection("ConnectionStrings:DefaultConnection").Value;
        }
        public string GetCadena() { 
            return Cadena;
        }


    }
}
