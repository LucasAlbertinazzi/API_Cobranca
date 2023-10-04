using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Armazena a Chave de Acesso para a Skyhub.
/// A coluna API contém os nomes de cada api na skyhub, estes nomes são utilizados numa série de métodos internos em nosso sistema.
/// Utilizado na classe Marketplaces.cs
/// </summary>
public partial class EcTblHeadersSkyhub
{
    public string Email { get; set; } = null!;

    public string? ApiKey { get; set; }

    public string? AccountmanagerKey { get; set; }

    public string? Url { get; set; }

    public string? Api { get; set; }

    public int? Codloja { get; set; }
}
