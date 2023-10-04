using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblComprasCota
{
    public int Codigo { get; set; }

    public string? Mes { get; set; }

    public string? Divisao { get; set; }

    public decimal? Porc { get; set; }

    public decimal? Cota { get; set; }
}
