using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Bloqueio dos Pedidos Antes que seja despachado
/// </summary>
public partial class EcTblBloqueioPedido
{
    public int Id { get; set; }

    public string Codpedido { get; set; } = null!;

    public DateTime Data { get; set; }

    public string Motivo { get; set; } = null!;

    public decimal? Codusuario { get; set; }

    public bool? Bloqueado { get; set; }

    public decimal? Codusuariobloqueou { get; set; }
}
