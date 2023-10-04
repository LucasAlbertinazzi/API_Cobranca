using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Parcelas dos pedidos
/// </summary>
public partial class TblParcelasPrazoOrc
{
    public long? Codprepedido { get; set; }

    public string? Codpedido { get; set; }

    /// <summary>
    /// Data do Pedido
    /// </summary>
    public DateOnly? Datapedido { get; set; }

    /// <summary>
    /// Quantidade de parcelas
    /// </summary>
    public long? Quantparcela { get; set; }

    public long? Parcela { get; set; }

    public DateOnly? Vencimento { get; set; }

    public decimal? Valor { get; set; }

    /// <summary>
    /// Forma pagamento
    /// </summary>
    public string? Forma { get; set; }

    public string? Documento { get; set; }

    public long? Codcliente { get; set; }

    /// <summary>
    /// Tipo de Venda Crediario Proprio Financeira ou Cartão
    /// </summary>
    public int? Tipovenda { get; set; }

    /// <summary>
    /// Pago S ou N
    /// </summary>
    public char? Pago { get; set; }

    /// <summary>
    /// Data que foi efetuado o pagamento.
    /// </summary>
    public DateTime? Datapgto { get; set; }

    /// <summary>
    /// Dias de atrazo 
    /// </summary>
    public short? Diasatraso { get; set; }

    /// <summary>
    /// Juro cobrado ao dia
    /// </summary>
    public decimal? Jurodia { get; set; }

    /// <summary>
    /// Valor do juro cobrado
    /// </summary>
    public decimal? Valorjuro { get; set; }

    /// <summary>
    /// Valor a pagar com o juro
    /// </summary>
    public decimal? Valorpagar { get; set; }

    /// <summary>
    /// Valor do desconto
    /// </summary>
    public decimal? Desconto { get; set; }

    /// <summary>
    /// Valor pago com juro e desconto
    /// </summary>
    public decimal? Valorpago { get; set; }

    /// <summary>
    /// Codigo do Usuario que Recebeu a Parcela
    /// </summary>
    public int? Codusuario { get; set; }

    /// <summary>
    /// Caixa que recebeu a parcela
    /// </summary>
    public string? Caixa { get; set; }

    /// <summary>
    /// Codigo da loja que recebeu a parcela. (codigo que o caixa esta indentificado)
    /// </summary>
    public int? Codloja { get; set; }

    /// <summary>
    /// Codigo identificador do caixa
    /// </summary>
    public long? Idcaixa { get; set; }

    /// <summary>
    /// data do cheque pre Se pagamento for efetuado com cheque pre
    /// </summary>
    public DateOnly? Chequepre { get; set; }

    /// <summary>
    /// se foi feita baixa parcial ou total
    /// </summary>
    public char? Baixaparcial { get; set; }

    /// <summary>
    /// se a parcela é integral ou parcial
    /// 
    /// valores I ou P
    /// </summary>
    public char? Tipoparcela { get; set; }

    /// <summary>
    /// codigo do pagamento da parcela
    /// </summary>
    public string? Codpagamento { get; set; }

    /// <summary>
    /// se o pedido foi cancelado
    /// </summary>
    public char? Cancelado { get; set; }

    public string? Pagoparcial { get; set; }

    public char? Pgtocheque { get; set; }

    /// <summary>
    /// Motivo de desconto solicitado pelo caixa
    /// </summary>
    public string? Motdesc { get; set; }

    /// <summary>
    /// motivo do desconto dado pelo gerente
    /// </summary>
    public string? Motdescger { get; set; }

    public string? Descautorizado { get; set; }

    public int Codigo { get; set; }

    public virtual TblTipoVendum? TipovendaNavigation { get; set; }
}
