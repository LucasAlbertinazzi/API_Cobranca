using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// impressao de carta de cobrança
/// </summary>
public partial class TblImpcartum
{
    public int Codigo { get; set; }

    /// <summary>
    /// codigo do cliente
    /// </summary>
    public long? Codcliente { get; set; }

    /// <summary>
    /// codigo do usuario
    /// </summary>
    public int? Codusuario { get; set; }

    /// <summary>
    /// numero de identificação da carta que foi impressa
    /// </summary>
    public int? Carta { get; set; }

    public DateTime? Dataimpressao { get; set; }
}
