using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class ATempInventario
{
    public int Id { get; set; }

    public string? Codproduto { get; set; }

    public string? Descricao { get; set; }

    public decimal? Quant { get; set; }

    public decimal? Custo { get; set; }

    public decimal? Total { get; set; }
}
