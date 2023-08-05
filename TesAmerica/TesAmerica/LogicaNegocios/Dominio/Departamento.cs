using System;
using System.Collections.Generic;

namespace TesAmerica.LogicaNegocios.Dominio;

public partial class Departamento
{
    public string Coddep { get; set; } = null!;

    public string? Nombre { get; set; }

    public virtual ICollection<Ciudad> Ciudads { get; set; } = new List<Ciudad>();
}
