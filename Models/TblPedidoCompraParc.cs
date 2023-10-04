using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: COMPRAS, INCLUSÃO
/// Contém as parcelas dos pedidos de compra e seus respectivos detalhes, como valor e vencimento. Esta tabela está relacionada com a tbl_pedido_compra. 
/// 
/// </summary>
public partial class TblPedidoCompraParc
{
    /// <summary>
    /// Codigo Operacao
    /// </summary>
    public long Codigo { get; set; }

    /// <summary>
    /// Codigo do Pedido de Compra
    /// </summary>
    public long? Codpedidocompra { get; set; }

    /// <summary>
    /// Prazo de Pagamento
    /// </summary>
    public long? Prazo { get; set; }

    /// <summary>
    /// Data do Vencimento
    /// </summary>
    public DateOnly? Vencimento { get; set; }

    /// <summary>
    /// Valor da Parcela
    /// </summary>
    public double? Valorparcela { get; set; }

    public char? Entregue { get; set; }

    public string? Parcela { get; set; }

    public short? Tipo { get; set; }
}
