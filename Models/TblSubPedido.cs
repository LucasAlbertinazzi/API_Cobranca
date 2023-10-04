using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: Pedido, Produto, Garantia Estendida, Fiscal
/// Contém os dados dos produtos de um determinado pedido ou pré-pedido, com seus respectivos códigos, valores, taxas, valor de desconto, código do romaneio por produto, código da NFC-e, IMEI (em caso de celular), garantia de fábrica, código do pedido da garantia, número do bilhete de garantia estendida, data da entrega, valor de frete (em caso do e-commerce).
/// 
/// </summary>
public partial class TblSubPedido
{
    public int Codigo { get; set; }

    public int? Codprepedido { get; set; }

    public string? Codpedido { get; set; }

    public string? Codproduto { get; set; }

    public short? Estoqueanterior { get; set; }

    public short? Quantvendido { get; set; }

    public decimal? Valorcusto { get; set; }

    public decimal? Valorvenda { get; set; }

    public decimal? Valortotal { get; set; }

    public float? Desconto { get; set; }

    public decimal? Totaldesconto { get; set; }

    public short? Taxa { get; set; }

    public int? Coddeposito { get; set; }

    public char? Juroespec { get; set; }

    public char? Promocao { get; set; }

    public char? Botafora { get; set; }

    public decimal? PrecovendaT1 { get; set; }

    public string? Codfabrica { get; set; }

    /// <summary>
    /// Tempo de entrega dos produtos
    /// </summary>
    public int? Tempoentrega { get; set; }

    /// <summary>
    /// Tempo nescessario para montar o produto
    /// </summary>
    public int? Tempomontagem { get; set; }

    /// <summary>
    /// se é nescessario montar o produto no cliente
    /// </summary>
    public char? Montar { get; set; }

    public decimal? Acrescimo { get; set; }

    public decimal? Vlrvendaproduto { get; set; }

    public DateOnly? Datavenda { get; set; }

    public char? Cancelado { get; set; }

    public DateTime? NF { get; set; }

    public string? NumF { get; set; }

    public DateTime? Cf { get; set; }

    public int? NumCf { get; set; }

    public int? UserF { get; set; }

    public int? UserCf { get; set; }

    public string? SerieEcf { get; set; }

    public int? Romaneio { get; set; }

    public string? Divisao { get; set; }

    public string? Departamento { get; set; }

    public int? Ficou { get; set; }

    public char? Liberacupom { get; set; }

    public int? Nfe { get; set; }

    public short? Restou { get; set; }

    public short? TipoEntrega { get; set; }

    public decimal? CustoSemCredito { get; set; }

    public long? Nfce { get; set; }

    public string? Imei { get; set; }

    public string? Codprodutoindex { get; set; }

    public short? Tempogarantia { get; set; }

    public short? Garantiafabrica { get; set; }

    public long? CodsubpedidoGarantia { get; set; }

    public float? PorcProdPedido { get; set; }

    public short? Tipogarantia { get; set; }

    public string? Numerobilhete { get; set; }

    public DateOnly? Dataentrega { get; set; }

    public decimal? Iofgarantia { get; set; }

    public decimal? PremioLiqSeg { get; set; }

    public bool? BaixaEstoqueAuto { get; set; }

    public string? Imei2 { get; set; }

    public decimal? ValorFrete { get; set; }

    public int? NfeIndenizacao { get; set; }

    public int? IdSeguroSabemi { get; set; }

    public virtual TblProduto? CodprodutoNavigation { get; set; }
}
