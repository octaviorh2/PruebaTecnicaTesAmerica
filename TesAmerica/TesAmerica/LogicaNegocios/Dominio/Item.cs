using System;
using System.Collections.Generic;

namespace TesAmerica.LogicaNegocios.Dominio;

public partial class Item
{
    public string Numpedido { get; set; } = null!;

    public string Producto { get; set; } = null!;

    public decimal Precio { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? Subtotal { get; set; }

    public virtual Pedido NumpedidoNavigation { get; set; } = null!;

    public virtual Producto ProductoNavigation { get; set; } = null!;
}
