using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblFluxo1
{
    public DateOnly? Data { get; set; }

    public double? Chepre { get; set; }

    public double? Vendas { get; set; }

    public double? Recebi { get; set; }

    public double? Estorn { get; set; }

    public double? Total { get; set; }
}
