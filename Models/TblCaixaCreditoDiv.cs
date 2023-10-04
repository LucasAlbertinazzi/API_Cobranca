using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Creditos deversos no caixa
/// </summary>
public partial class TblCaixaCreditoDiv
{
    public long Codigo { get; set; }

    public long? Codcaixamov { get; set; }

    public DateTime? Data { get; set; }

    public decimal? Valor { get; set; }

    public string? Descricao { get; set; }

    /// <summary>
    /// Tipo de Credito DI ou CH
    /// </summary>
    public string? Tipo { get; set; }
}
