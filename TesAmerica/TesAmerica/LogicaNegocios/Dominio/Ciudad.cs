using System;
using System.Collections.Generic;

namespace TesAmerica.LogicaNegocios.Dominio;

public partial class Ciudad
{
    public string Codciu { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Departamento { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual Departamento? DepartamentoNavigation { get; set; }
}
