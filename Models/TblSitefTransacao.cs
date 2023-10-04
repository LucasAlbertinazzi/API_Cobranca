using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSitefTransacao
{
    public int Idtransacao { get; set; }

    public int CupomFiscal { get; set; }

    public long NsuHost { get; set; }

    public long NsuSitef { get; set; }

    public DateTime DataTransacao { get; set; }

    public int Parcelas { get; set; }

    public decimal Valor { get; set; }

    public int? CupomCancelamento { get; set; }

    public string? Retornos { get; set; }
}
