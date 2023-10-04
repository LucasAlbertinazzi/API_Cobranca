using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// tempo gasto por desenvolvedor num determinado chamado.
/// </summary>
public partial class TblDevWork
{
    public long Id { get; set; }

    public int? Numerochamado { get; set; }

    public int? Codusuario { get; set; }

    public TimeSpan? TempoDev { get; set; }

    public DateTime? DataDev { get; set; }
}
