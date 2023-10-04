using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblContaEstoquerotativoSub
{
    public int Codigo { get; set; }

    public int? Codcontagem { get; set; }

    public string? Codproduto { get; set; }

    public int? Estoqueinicio { get; set; }

    public int? Estoquefim { get; set; }

    public int? Entregainicio { get; set; }

    public int? Entregafim { get; set; }

    public int? Contado { get; set; }

    public int? Saldo { get; set; }

    public decimal? Custo { get; set; }

    public int? Transentrando { get; set; }

    public int? Transsaindo { get; set; }

    public int? Prepedido { get; set; }
}
