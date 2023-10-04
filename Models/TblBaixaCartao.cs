using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblBaixaCartao
{
    public int? Excluir { get; set; }

    public DateOnly? Datacredito { get; set; }

    public DateOnly? Datadeposito { get; set; }

    public string? Nestabelecimento { get; set; }

    public string? Nresumo { get; set; }

    public int? Ncomprovante { get; set; }

    public string? Descricao { get; set; }

    public decimal? Valorbruto { get; set; }

    public decimal? Valorliquido { get; set; }

    public int Codigo { get; set; }

    public DateTime? Databaixa { get; set; }
}
