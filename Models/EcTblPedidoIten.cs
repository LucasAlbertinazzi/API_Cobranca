using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Armazena os Itens Gerado  no  Pedido da  Skyhub e E-commerce
/// </summary>
public partial class EcTblPedidoIten
{
    public int Id { get; set; }

    public int? IdPedido { get; set; }

    public string? CodItem { get; set; }

    public string? CodProduto { get; set; }

    public string? Nome { get; set; }

    public int? Quant { get; set; }

    public decimal? Valor { get; set; }

    public decimal? ValorPromo { get; set; }

    public decimal? Montagem { get; set; }
}
