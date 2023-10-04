using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblRenegociarGerou
{
    public int Codigo { get; set; }

    public int? Codreneg { get; set; }

    public DateOnly? Vencimento { get; set; }

    public decimal? Valor { get; set; }

    public string? Tipo { get; set; }
}
