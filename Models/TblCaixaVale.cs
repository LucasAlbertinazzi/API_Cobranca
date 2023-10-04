using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Vales retirado dos caixas quando a falta de dinheiro
/// </summary>
public partial class TblCaixaVale
{
    public long Codigo { get; set; }

    /// <summary>
    /// Codigo do movimento do caixa
    /// </summary>
    public long? Codcaixamov { get; set; }

    /// <summary>
    /// Codigo do usuario do caixa
    /// </summary>
    public long? Codusuario { get; set; }

    public DateTime? Data { get; set; }

    public decimal? Valor { get; set; }

    public char? Pago { get; set; }
}
