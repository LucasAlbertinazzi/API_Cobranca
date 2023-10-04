using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSubContagemManu
{
    public int Codigo { get; set; }

    public string? Codproduto { get; set; }

    public string? Volume { get; set; }

    public DateTime? Data { get; set; }

    public int? Codcontagem { get; set; }

    public int? Quant { get; set; }
}
