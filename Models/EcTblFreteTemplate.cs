using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Não Esta Sendo Utilizada
/// </summary>
public partial class EcTblFreteTemplate
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public string? Obs { get; set; }

    public DateTime? Datacriacao { get; set; }

    public DateTime? Atualizado { get; set; }

    public int? Codusuario { get; set; }
}
