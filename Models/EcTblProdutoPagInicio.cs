using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Produtos para ser exibido na página inicial do e-commerce
/// </summary>
public partial class EcTblProdutoPagInicio
{
    public string Codproduto { get; set; } = null!;

    public short? Index { get; set; }
}
