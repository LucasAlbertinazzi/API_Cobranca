using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: FINANCEIRO, PEDIDO
/// Contém valores de crédito de estornos de pedidos cancelados. 
/// 
/// </summary>
public partial class TblPedidoEx
{
    /// <summary>
    /// codigo do pedido estornado
    /// </summary>
    public string Codpedido { get; set; } = null!;

    /// <summary>
    /// Valor do credito do cliente
    /// </summary>
    public decimal? Valorcredito { get; set; }

    /// <summary>
    /// Se o credito do cliente ja foi utilizado
    /// </summary>
    public char? Utilizado { get; set; }
}
