using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblGastoveiculo
{
    public int Codigo { get; set; }

    public int? Codveiculo { get; set; }

    public decimal? Quantidade { get; set; }

    public decimal? Valor { get; set; }

    public decimal? Km { get; set; }

    public DateOnly? Data { get; set; }
}
