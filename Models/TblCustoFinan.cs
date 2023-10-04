using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblCustoFinan
{
    public int Codigo { get; set; }

    public string? Mes { get; set; }

    public decimal? Valor { get; set; }

    /// <summary>
    /// custo operacional ou custo dinheiro
    /// </summary>
    public char? Tipo { get; set; }
}
