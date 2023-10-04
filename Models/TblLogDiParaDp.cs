using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// logs inseridos na mudança de DI para DP, ou vice-versa, na FrmConsultaPedido
/// </summary>
public partial class TblLogDiParaDp
{
    public int Codigo { get; set; }

    public long? Codusuario { get; set; }

    public DateTime? Data { get; set; }

    public string? Codpedido { get; set; }

    public string? Para { get; set; }
}
