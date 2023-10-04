using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: COMPRAS, INCLUSÃO
/// Dados referentes ao pedido de compra, com o codfornecedor, valor do pedido, data do pedido, database, faturamento, número de parcelas, intervalo entre as parcelas, codusuario que lançou o pedido, previsão de entrega (utilizado no setor de inclusão e recebimento do depósito), se o pedido já foi entregue ou não, quem foi o comprador e observações e detalhes adicionais.
/// 
/// </summary>
public partial class TblPedidoCompra
{
    public long Codpedidocompra { get; set; }

    /// <summary>
    /// Codigo Fornecedor
    /// </summary>
    public int? Codfornecedor { get; set; }

    /// <summary>
    /// Valor Total do Pedido
    /// </summary>
    public double? Vlrpedido { get; set; }

    /// <summary>
    /// Prazo medio de Pagamento
    /// </summary>
    public double? Prazomedio { get; set; }

    /// <summary>
    /// Data do fechamento do Pedido
    /// </summary>
    public DateTime? Datapedido { get; set; }

    /// <summary>
    /// Situação do Pedido, Aberto ou Fechado.
    /// </summary>
    public char? Situacao { get; set; }

    /// <summary>
    /// Data Base para Vencimento
    /// </summary>
    public DateOnly? Database { get; set; }

    /// <summary>
    /// Data de Previsao de Faturamento
    /// </summary>
    public DateOnly? Faturamento { get; set; }

    /// <summary>
    /// Numero de Parcelas par Pagamento
    /// </summary>
    public long? Nparcelas { get; set; }

    /// <summary>
    /// Dias entre as parcelas
    /// </summary>
    public double? Intervalo { get; set; }

    /// <summary>
    /// Codigo do Usuario
    /// </summary>
    public int? Codusuario { get; set; }

    /// <summary>
    /// Previsao de Entrega em Dias
    /// </summary>
    public long? Preventregadias { get; set; }

    /// <summary>
    /// Previsao de Entrega Data
    /// </summary>
    public DateOnly? Preventrega { get; set; }

    public long? Codtransportadora { get; set; }

    public char? Entregue { get; set; }

    /// <summary>
    /// Valor das mercadorias Recebidas
    /// </summary>
    public double? Vlrrecebido { get; set; }

    /// <summary>
    /// Pedido completo
    /// </summary>
    public char? Pedcompleto { get; set; }

    /// <summary>
    /// Data do Fechamento do Recebimento
    /// </summary>
    public DateTime? Datafechamento { get; set; }

    /// <summary>
    /// Codigo do usuario que fechou o recebimento
    /// </summary>
    public int? Codusuariofechou { get; set; }

    /// <summary>
    /// Comprador 
    /// </summary>
    public string? Comprador { get; set; }

    /// <summary>
    /// Codigo da Divisão do Pedido
    /// </summary>
    public long? Coddivisao { get; set; }

    /// <summary>
    /// Observações
    /// </summary>
    public string? Obs { get; set; }

    public string? Transportadora { get; set; }

    public char? Alterou { get; set; }

    public short? Coddivdetalhe { get; set; }

    public char? Vp { get; set; }

    public int? Codloja { get; set; }

    public string? Documento { get; set; }

    public short? TipoPedido { get; set; }

    public char? Pedidocredito { get; set; }

    public int? CodProjetoVp { get; set; }

    public int? CodpedidoAnterior { get; set; }

    public int? Protocolo { get; set; }

    public string? PedidoFornecedor { get; set; }

    public string? UfDestino { get; set; }

    public long? IdPedidoDebito { get; set; }

    public double? Desconto { get; set; }

    public double? Devolucao { get; set; }

    public string? Status { get; set; }

    public string? ComentarioDevolucao { get; set; }

    public string? ComentarioDesconto { get; set; }

    public int? IdChamado { get; set; }

    public virtual TblFornecedor? CodfornecedorNavigation { get; set; }

    public virtual TblUsuario? CodusuarioNavigation { get; set; }

    public virtual ICollection<TblPedidoCompraR> TblPedidoCompraRs { get; set; } = new List<TblPedidoCompraR>();

    public virtual ICollection<TblVeiculoHistManutencao> TblVeiculoHistManutencaos { get; set; } = new List<TblVeiculoHistManutencao>();
}
