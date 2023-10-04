using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Armazena o Json do Status do Pedido na Skyhub
/// </summary>
public partial class EcTblPedidoEntradum
{
    public int Id { get; set; }

    public DateTime? Data { get; set; }

    public string? Codigo { get; set; }

    public string? Arquivo { get; set; }
}
