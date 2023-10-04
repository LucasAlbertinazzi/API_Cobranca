using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Link dos produtos na skyhub - Americanas ou Submarino
/// </summary>
public partial class EcTblProdutosUrl
{
    public string Sku { get; set; } = null!;

    public string Canal { get; set; } = null!;

    public string Href { get; set; } = null!;

    public int CodUsuario { get; set; }

    public DateTime Datetime { get; set; }

    public int Id { get; set; }
}
