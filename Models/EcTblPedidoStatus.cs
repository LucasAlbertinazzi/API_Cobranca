using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Armazena o Statudos do Pedido na Skyhub e E-commerce
/// </summary>
public partial class EcTblPedidoStatus
{
    public int IdPedido { get; set; }

    public string? Codigo { get; set; }

    public string? Tipo { get; set; }

    public string? Label { get; set; }
}
