using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: FINANCEIRO
/// Uma agenda com os pagamentos para os fornecedores, movimentação de caixa.
/// 
/// </summary>
public partial class TblAgendaPgto
{
    /// <summary>
    /// Codigo da Operação
    /// </summary>
    public long Codigo { get; set; }

    /// <summary>
    /// Codigo do Pedido de Compra
    /// </summary>
    public long? Codpedidocompra { get; set; }

    /// <summary>
    /// Codigo do Pedido de Recebimento
    /// </summary>
    public long? Codrecebimento { get; set; }

    /// <summary>
    /// Valor a pagar
    /// </summary>
    public double? Vlrpagar { get; set; }

    public DateOnly? Vencimento { get; set; }

    /// <summary>
    /// Codigo do Fornecedor
    /// </summary>
    public long? Codfornecedor { get; set; }

    /// <summary>
    /// Codigo da Divisao os Produtos
    /// </summary>
    public long? Coddivisao { get; set; }

    public long? Codusuario { get; set; }

    public DateTime? Atualiza { get; set; }

    public char Lancada { get; set; }

    /// <summary>
    /// Prazo de pagamento
    /// </summary>
    public long? Prazo { get; set; }

    /// <summary>
    /// Numero do Documento da mercadoria
    /// </summary>
    public string? Ndocumento { get; set; }

    /// <summary>
    /// quantidade de parcelas
    /// </summary>
    public string? Parcela { get; set; }

    public short? Coddivdetalhe { get; set; }

    public short? Tipo { get; set; }

    public char Ativo { get; set; }

    public short? Nbanco { get; set; }

    public string? Agencia { get; set; }

    public string? Conta { get; set; }

    public string? Favorecido { get; set; }

    public string? Cnpj { get; set; }

    public string? Ident { get; set; }

    public int? Ncheque { get; set; }

    public short? Tipopgto { get; set; }

    public string? Obs { get; set; }

    public long? Codvale { get; set; }

    public char Excluir { get; set; }

    public short? CaixaPgto { get; set; }

    public char? Conferida { get; set; }

    public char? Comprovante { get; set; }

    public char? Destacar { get; set; }

    public decimal? Grupo { get; set; }

    /// <summary>
    /// Data em que ocorreu o debito na conta
    /// </summary>
    public DateOnly? DataDebito { get; set; }

    public DateOnly? DataLiquidacao { get; set; }

    public string? AnexoNotaServ { get; set; }
}
