using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblParcelasFinan
{
    public int Codigo { get; set; }

    public double? Valor { get; set; }

    public DateOnly? Vencimento { get; set; }

    public long? Codcliente { get; set; }

    public string? Codpedido { get; set; }

    public int? Financeira { get; set; }

    public string? Parcela { get; set; }
}
