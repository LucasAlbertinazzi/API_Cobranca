using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// tabela provisória para guardar os códigos de pedido dos marketplaces, gerados manualmente.
/// 
/// Junior - 24/06/2020
/// </summary>
public partial class EcTblPedidoManual
{
    public int Id { get; set; }

    public long? Codprepedido { get; set; }

    public string? CodEc { get; set; }

    public string? Codpedido { get; set; }

    public DateTime? Data { get; set; }

    public int? Codusuario { get; set; }
}
