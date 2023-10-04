using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Armazena os Logs de movimentação da Skyhub
/// </summary>
public partial class EcTblLog
{
    public int Id { get; set; }

    public DateTime? Data { get; set; }

    public string? Tipo { get; set; }

    public string? Descricao { get; set; }

    public string? Log { get; set; }

    public int? Codusuario { get; set; }
}
