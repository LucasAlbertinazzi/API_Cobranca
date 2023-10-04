using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Contatos realizados pela cobrança
/// </summary>
public partial class TblCobrancaCont
{
    public int Codigo { get; set; }

    public long? Codcliente { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Datacontato { get; set; }

    public string? Descricao { get; set; }

    public bool? ClienteProcessado { get; set; }
}
