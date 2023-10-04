using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Descrição dos Produtos  na Skyhub e E-commerce
/// </summary>
public partial class EcTblProdutoDesc
{
    public int Codproduto { get; set; }

    public string? Descricao { get; set; }
}
