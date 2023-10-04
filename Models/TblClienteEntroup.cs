using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblClienteEntroup
{
    public int Codigo { get; set; }

    public int? Codcliente { get; set; }

    public DateOnly? Data { get; set; }

    public decimal? Valor { get; set; }

    public int? Codloja { get; set; }
}
