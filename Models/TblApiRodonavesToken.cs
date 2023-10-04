using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: E-COMMERCE
/// Dados conexão com a API Rodonaves, Token de acesso e sua validade.
/// </summary>
public partial class TblApiRodonavesToken
{
    public int Codigo { get; set; }

    public string? Json { get; set; }

    public string? Token { get; set; }

    public DateTime? Emissao { get; set; }

    public DateTime? Expira { get; set; }
}
