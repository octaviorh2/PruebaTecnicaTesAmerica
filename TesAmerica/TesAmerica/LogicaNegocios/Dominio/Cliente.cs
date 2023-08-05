using System;
using System.Collections.Generic;

namespace TesAmerica.LogicaNegocios.Dominio;

public partial class Cliente
{
    public string Codcli { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public int? Cupo { get; set; }

    public DateTime? Fechacreacion { get; set; }

    public string? Canal { get; set; }

    public string? Vendedor { get; set; }

    public string? Ciudad { get; set; }

    public string? Padre { get; set; }

    public virtual Ciudad? CiudadNavigation { get; set; }

    public virtual ICollection<Cliente> InversePadreNavigation { get; set; } = new List<Cliente>();

    public virtual Cliente? PadreNavigation { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual Vendedor? VendedorNavigation { get; set; }
}
