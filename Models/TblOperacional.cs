using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblOperacional
{
    public int Codigo { get; set; }

    public int? Loja { get; set; }

    public string? Mes { get; set; }

    public decimal? Valorloja { get; set; }

    public decimal? Valorlojadep { get; set; }
}
