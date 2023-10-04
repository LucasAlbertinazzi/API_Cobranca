using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Tabela de descrição completa do produto
/// </summary>
public partial class EcTblProdutoDescComp
{
    public int Codigo { get; set; }

    public long? Codproduto { get; set; }

    public string? Item { get; set; }

    public string? Descricao { get; set; }

    public short? Ordenacao { get; set; }
}
