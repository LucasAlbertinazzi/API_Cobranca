using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblPedidoPrazoApagar
{
    public long Codigo { get; set; }

    public int? Codprepedido { get; set; }

    /// <summary>
    /// Codigo do Pedido
    /// </summary>
    public long? Codpedido { get; set; }

    /// <summary>
    /// Vencimento da duplicata
    /// </summary>
    public DateOnly? Vencimento { get; set; }

    /// <summary>
    /// Valor da duplicata
    /// </summary>
    public decimal? Valor { get; set; }

    /// <summary>
    /// Forma de pagamento DI DP CH EX
    /// </summary>
    public string? Formapagamento { get; set; }

    public char? Ativa { get; set; }

    public virtual TblPrePedido? CodprepedidoNavigation { get; set; }
}
