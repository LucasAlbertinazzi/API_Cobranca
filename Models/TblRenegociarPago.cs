using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblRenegociarPago
{
    public int Codigo { get; set; }

    public int? Codreneg { get; set; }

    public int? Codparcela { get; set; }

    public string? Codpedido { get; set; }

    public DateOnly? Vencimento { get; set; }

    public decimal? Valor { get; set; }

    public int? Atraso { get; set; }

    public float? Valoratual { get; set; }
}
