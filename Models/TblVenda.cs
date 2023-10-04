using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblVenda
{
    public string Data { get; set; } = null!;

    public decimal? Totalpedido { get; set; }

    public decimal? Totalcancelado { get; set; }

    public decimal? Saldopedido { get; set; }

    public decimal? Pedidopresente { get; set; }

    public decimal? Cancelpresente { get; set; }

    public decimal? Totalpresente { get; set; }

    public int Loja { get; set; }
}
