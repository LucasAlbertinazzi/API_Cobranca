using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblNotaSub
{
    public int Codigo { get; set; }

    public int? Codnota { get; set; }

    public string? Codproduto { get; set; }

    public string? Descricao { get; set; }

    public string? Classfiscal { get; set; }

    public int? Sittributaria { get; set; }

    public string? Un { get; set; }

    public int? Quantidade { get; set; }

    public decimal? Valorunit { get; set; }

    public decimal? Valortotal { get; set; }

    public decimal? Aliquota { get; set; }

    public decimal? Valoricms { get; set; }

    public virtual TblNotum? CodnotaNavigation { get; set; }
}
