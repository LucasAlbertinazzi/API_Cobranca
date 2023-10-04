using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblScoreLojaHist
{
    public int Codigo { get; set; }

    public long? Codprepedido { get; set; }

    public string? Atenuantes { get; set; }

    public string? Agravantes { get; set; }

    public string? InterpScore { get; set; }

    public decimal? SenhaGerente { get; set; }

    public decimal? SenhaCoordenador { get; set; }

    public decimal? SenhaVendedor { get; set; }

    public DateOnly? Data { get; set; }

    public string? Score { get; set; }
}
