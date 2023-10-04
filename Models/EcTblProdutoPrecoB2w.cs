using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Preço dos Produtos na Skyhub
/// </summary>
public partial class EcTblProdutoPrecoB2w
{
    public int Id { get; set; }

    public string? Codproduto { get; set; }

    public decimal? Custo { get; set; }

    public decimal? MargemLucro { get; set; }

    public decimal? Venda { get; set; }

    public decimal? Icms { get; set; }

    public decimal? Pis { get; set; }

    public decimal? Cofins { get; set; }

    public decimal? Comissaomkp { get; set; }

    public decimal? TaxaAntecipa { get; set; }

    public decimal? PrevDev { get; set; }

    public decimal? Outros { get; set; }

    public decimal? Markup { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Data { get; set; }

    public DateTime? PrevEntrada { get; set; }

    public int? CodusuarioEnviou { get; set; }

    public DateTime? DataEnvio { get; set; }

    public decimal? Difal { get; set; }

    public decimal OpLogistico { get; set; }

    public decimal DespEnvio { get; set; }
}
