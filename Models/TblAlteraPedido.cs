using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: FINANCEIRO
/// Aparentemente continha um registro dos pedidos que foram alterados e os usuários que os alteraram.
/// 
/// </summary>
public partial class TblAlteraPedido
{
    public int Codigo { get; set; }

    public string? Codpedido { get; set; }

    public DateTime? Data { get; set; }

    public string? Usuario { get; set; }

    public string? Motivo { get; set; }
}
