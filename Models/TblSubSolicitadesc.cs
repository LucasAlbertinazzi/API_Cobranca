using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSubSolicitadesc
{
    public long Codigo { get; set; }

    /// <summary>
    /// Codigo da solicitação
    /// </summary>
    public long? Codsolicita { get; set; }

    /// <summary>
    /// Codigo do pedido
    /// </summary>
    public string? Pedido { get; set; }

    public DateOnly? Vencimento { get; set; }

    public decimal? Vlrparcela { get; set; }

    /// <summary>
    /// dias de atrazo
    /// </summary>
    public short? Atraso { get; set; }

    public decimal? Vlrpagar { get; set; }

    public decimal? Vlrreceber { get; set; }
}
