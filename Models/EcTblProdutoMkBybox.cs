using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Não esta sendo utilizada
/// </summary>
public partial class EcTblProdutoMkBybox
{
    public int Id { get; set; }

    public string? Codproduto { get; set; }

    public decimal? Valor { get; set; }

    public DateTime? DataConsulta { get; set; }

    public int? Codusuario { get; set; }

    public char? Ultima { get; set; }
}
