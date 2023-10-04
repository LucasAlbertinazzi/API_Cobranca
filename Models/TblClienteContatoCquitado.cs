using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// tabela com o histórico de contatos de ligação de carnê quitado
/// </summary>
public partial class TblClienteContatoCquitado
{
    public long IdCquitado { get; set; }

    public long? Codcliente { get; set; }

    public string? ObsQuitado { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? DatacontatoQuitado { get; set; }
}
