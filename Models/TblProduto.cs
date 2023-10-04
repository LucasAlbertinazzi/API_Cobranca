using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: Produtos, Pedido
/// Contém as informações e detalhes referentes aos produtos (SKUs) de nosso estoque, devidamente subdivididos em divisões, departamentos e dígitos. Possui o código de fábrica, descrição, custo, margem, valor de venda, se o produto está na promoção, bota-fora, possui juros especiais ou custo de aquisição, custo médio, margem de lucro, volumes, código da cor, se o produto está ativo, código da marca da tbl_marca, quantidade que está na assistência, se é necessário montagem, grupo, caso produto tenha agrupamento; tempo de garantia em dias, despesa para abastecer o caixa da assistência, se o produto está com imagem, margem normal do produto, data do cadastramento, taxa do preço a vista, preço do cartaz a vista, taxa a prazo e preço do cartaz a prazo, se o parcelamente tem ou não entrada, tamanho do cartaz, se o produto está no jornal, se é necessário comprar mais, estoque mínimo, impostos (ICMS, IPI, PIS, COFINS), frete, VA, IVA, alíquotas do imposto, último custo, código da garantia estendida deste produto, margem de lucro normal.
/// </summary>
public partial class TblProduto
{
    public int? Codigo { get; set; }

    public long? Coddepartamento { get; set; }

    public string? Coddivisao { get; set; }

    public int? Coddigito { get; set; }

    public string Codproduto { get; set; } = null!;

    public string? Codfabrica { get; set; }

    public string? Descricao { get; set; }

    public double? Custo { get; set; }

    public decimal? Margem { get; set; }

    public decimal? Venda { get; set; }

    public string? Promocao { get; set; }

    public string? Bfora { get; set; }

    public string? Juroespec { get; set; }

    public double? Custodiversos { get; set; }

    public double? Valorpago { get; set; }

    public double? Freteporc { get; set; }

    public string? Observacoes { get; set; }

    public long? Codmarca { get; set; }

    public string? Ativo { get; set; }

    public long? Codcor { get; set; }

    public int? Volume { get; set; }

    /// <summary>
    /// Quantidade de produtos em Assistencia
    /// </summary>
    public long? Quantassistencia { get; set; }

    /// <summary>
    /// Se o produto nescessita de montagem na casa do cliente S ou N
    /// </summary>
    public char? Montar { get; set; }

    public decimal? Margemlucro { get; set; }

    /// <summary>
    /// data do pagamento medio
    /// </summary>
    public DateOnly? Datapagamento { get; set; }

    /// <summary>
    /// Grupo a qual o produto pertence
    /// </summary>
    public int? Grupo { get; set; }

    public DateTime? Atualizado { get; set; }

    public string? Useratualizado { get; set; }

    /// <summary>
    /// tempo de garantia
    /// </summary>
    public int? Garantia { get; set; }

    /// <summary>
    /// Despesa de assistência tecnica
    /// </summary>
    public decimal? Despesaassist { get; set; }

    public char? Imagem { get; set; }

    public string? Medidas { get; set; }

    public decimal? Aliquota { get; set; }

    /// <summary>
    /// margem de lucro quando o produto não esta em promocao.
    /// </summary>
    public decimal? Margemnormal { get; set; }

    public long? ClassFiscal { get; set; }

    public DateTime? Datacadastro { get; set; }

    public int? Tvista { get; set; }

    public decimal? Cartazvista { get; set; }

    public int? Tprazo { get; set; }

    public int? Parcprazo { get; set; }

    public decimal? Cartazprazo { get; set; }

    public char? Valorvista { get; set; }

    public char? Entrada { get; set; }

    public char? Cartaztamanho { get; set; }

    public char? Jornal { get; set; }

    public char? Comprar { get; set; }

    public int? Minimo { get; set; }

    public decimal? Vunit { get; set; }

    public decimal? Bcalculoicms { get; set; }

    public decimal? Vicms { get; set; }

    public decimal? Vst { get; set; }

    public decimal? Vipi { get; set; }

    public decimal? Vfrete { get; set; }

    public decimal? Pfrete { get; set; }

    public decimal? Totalsemcredito { get; set; }

    public decimal? Credicms { get; set; }

    public decimal? Credpis { get; set; }

    public decimal? Credcofins { get; set; }

    public decimal? Totalcomcredito { get; set; }

    public decimal? Va { get; set; }

    public decimal? Vendor { get; set; }

    public decimal? Icmssaida { get; set; }

    public decimal? Pissaida { get; set; }

    public decimal? Cofinssaida { get; set; }

    public decimal? MarkupDescImposto { get; set; }

    public decimal? Ultimocusto { get; set; }

    public decimal? Porcicms { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Porcipi { get; set; }

    public decimal? Porcfrete { get; set; }

    public decimal? Porccredicms { get; set; }

    public decimal? Porccredpis { get; set; }

    public decimal? Porccredcofins { get; set; }

    public int? Tempoentrega { get; set; }

    public int? Tempomontagem { get; set; }

    public decimal? TotalsemcreditoMedia { get; set; }

    public decimal? Bcalculoicmsst { get; set; }

    public string? Codprodgarantia { get; set; }

    public decimal? MargemLucroNormal { get; set; }

    public string? Cest { get; set; }

    public string? Material { get; set; }

    public bool? Exclusivo21 { get; set; }

    public decimal? Vp { get; set; }

    public decimal? Porcvp { get; set; }

    public bool? Exclusivo22 { get; set; }

    public decimal? OperLogistico { get; set; }

    public decimal? FreteTransf22 { get; set; }

    public decimal? Difal { get; set; }

    public string? ObservacaoTransf { get; set; }

    public bool? NewImage { get; set; }

    public bool? Mostruario { get; set; }

    public string? ClassificacaoEnergetica { get; set; }

    public bool ManualProduto { get; set; }

    public bool? Exclusivo24 { get; set; }

    public virtual ICollection<TblDescricaoProduto> TblDescricaoProdutos { get; set; } = new List<TblDescricaoProduto>();

    public virtual ICollection<TblEtiquetaIdent> TblEtiquetaIdents { get; set; } = new List<TblEtiquetaIdent>();

    public virtual ICollection<TblEtiquetaPreco> TblEtiquetaPrecos { get; set; } = new List<TblEtiquetaPreco>();

    public virtual ICollection<TblProdutoBaixa> TblProdutoBaixas { get; set; } = new List<TblProdutoBaixa>();

    public virtual ICollection<TblSubPedidoOrc> TblSubPedidoOrcs { get; set; } = new List<TblSubPedidoOrc>();

    public virtual ICollection<TblSubPedido> TblSubPedidos { get; set; } = new List<TblSubPedido>();
}
