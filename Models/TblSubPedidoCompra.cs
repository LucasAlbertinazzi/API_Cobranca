using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Armazena produtos do pedido de compra
/// </summary>
public partial class TblSubPedidoCompra
{
    /// <summary>
    /// Codigo do Pedido de Compra
    /// </summary>
    public long Codigo { get; set; }

    /// <summary>
    /// Codigo do Produto
    /// </summary>
    public string? Codproduto { get; set; }

    /// <summary>
    /// Descrição do Produto 
    /// </summary>
    public string? Descricao { get; set; }

    /// <summary>
    /// Quantidade da compra
    /// </summary>
    public long? Quantidade { get; set; }

    /// <summary>
    /// Valor unitario do Produto
    /// </summary>
    public double? Vlrunitario { get; set; }

    /// <summary>
    /// Valor total da Compra
    /// </summary>
    public double? Vlrtotal { get; set; }

    public long? Codpedidocompra { get; set; }

    /// <summary>
    /// Quantidade de Produtos Recebidos
    /// </summary>
    public long? Recebeu { get; set; }

    /// <summary>
    /// previsao de entrega da mercadoria
    /// </summary>
    public DateOnly? Previsaoentrega { get; set; }

    public char? Entregue { get; set; }

    public string? Codfabrica { get; set; }

    public decimal NfeEntrada { get; set; }

    public long Qtdefaturada { get; set; }

    public string? Chaveacesso { get; set; }

    public DateOnly? DataRecebimento { get; set; }
}
