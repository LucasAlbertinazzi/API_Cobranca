using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblDivisaoGasto
{
    public int Codigo { get; set; }

    public string? Descricao { get; set; }

    /// <summary>
    /// 1 = Operacional
    /// 2 = Estoque
    /// 3 = Investimento
    /// </summary>
    public int? Divisao { get; set; }

    public int? Ativo { get; set; }
}
