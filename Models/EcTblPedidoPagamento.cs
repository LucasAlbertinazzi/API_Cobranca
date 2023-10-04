using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Armazena as Parcelas e Forma de Pagamento Gerado na Skyhub e E-commerce
/// </summary>
public partial class EcTblPedidoPagamento
{
    public int Id { get; set; }

    public int? IdPedido { get; set; }

    public string? Metodo { get; set; }

    public decimal? Valor { get; set; }

    public short? Parcelas { get; set; }

    public string? Descricao { get; set; }

    public string? CodigoPagamento { get; set; }
}
