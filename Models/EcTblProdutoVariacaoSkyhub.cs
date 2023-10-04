using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Armazena os produtos da skyhub e coloca no campo variação, quanod este mesmo produto é agrupado por cores ou voltagem, quer dizer que existe varios produtos agrupados.
/// </summary>
public partial class EcTblProdutoVariacaoSkyhub
{
    public string CodprodutoPai { get; set; } = null!;

    public string? Descricao { get; set; }

    public bool? Variacao { get; set; }
}
