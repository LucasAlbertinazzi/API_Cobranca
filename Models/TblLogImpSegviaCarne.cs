using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// log impressão segunda via carnê parcelas pagas
/// </summary>
public partial class TblLogImpSegviaCarne
{
    public int Codigo { get; set; }

    public int? Codcliente { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Data { get; set; }

    public string? Nomemaquina { get; set; }

    public string? Ip { get; set; }
}
