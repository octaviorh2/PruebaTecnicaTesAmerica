using System;
using System.Collections.Generic;

namespace TesAmerica.LogicaNegocios.Dominio;

public partial class Vendedor
{
    public string Codvend { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public decimal Comision { get; set; }
}
