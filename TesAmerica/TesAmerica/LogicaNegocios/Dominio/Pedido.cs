using System;
using System.Collections.Generic;

namespace TesAmerica.LogicaNegocios.Dominio;

public partial class Pedido
{
    public string Numpedido { get; set; } = null!;

    public string? Cliente { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Vendedor { get; set; }

    public virtual Cliente? ClienteNavigation { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual Vendedor? VendedorNavigation { get; set; }
}
