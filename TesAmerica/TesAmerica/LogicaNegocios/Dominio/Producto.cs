using System;
using System.Collections.Generic;

namespace TesAmerica.LogicaNegocios.Dominio;

public partial class Producto
{
    public string Codprod { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Familia { get; set; }

    public decimal? Precio { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
