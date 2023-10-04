using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: COMPRAS, INCLUSÃO
/// Contém informações de pedidos de compra que tiveram o recebimento fechado pelo setor de inclusão. Possui data e hora do fechamento do recebimento, data do faturamento, data da entrega, valor do pedido e código do pedido de compra.
/// 
/// </summary>
public partial class TblPedidoCompraR
{
    /// <summary>
    /// Codigo Da Operação
    /// </summary>
    public long Codrecebimento { get; set; }

    /// <summary>
    /// Codigo do Pedido de Compra
    /// </summary>
    public long? Codpedidocompra { get; set; }

    /// <summary>
    /// Valor do Pedido Entregue
    /// </summary>
    public double? Vlrpedido { get; set; }

    /// <summary>
    /// Prazo medio do Pedido Entregue
    /// </summary>
    public long? PrazoMedio { get; set; }

    /// <summary>
    /// Data do Faturamento
    /// </summary>
    public DateOnly? Faturamento { get; set; }

    /// <summary>
    /// Data da Entrega
    /// </summary>
    public DateOnly? Dataentrega { get; set; }

    /// <summary>
    /// Codigo do Usuario da Operação
    /// </summary>
    public long? Codusuario { get; set; }

    public char? Situacao { get; set; }

    /// <summary>
    /// Data do fechamento do Recebimento
    /// </summary>
    public DateTime? Datafechareceb { get; set; }

    public virtual TblPedidoCompra? CodpedidocompraNavigation { get; set; }
}
