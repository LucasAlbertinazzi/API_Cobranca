using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Etiquete de identificação do produto com codigo de barra
/// </summary>
public partial class TblEtiquetaIdent
{
    public long Codigo { get; set; }

    /// <summary>
    /// Codigo do produto
    /// </summary>
    public string? Codproduto { get; set; }

    public int? Codloja { get; set; }

    public int? Volume { get; set; }

    public int? Idetiqueta { get; set; }

    public char? Impresso { get; set; }

    public string? Usuario { get; set; }

    public DateTime? Data { get; set; }

    public string? Sigla { get; set; }

    public virtual TblLoja? CodlojaNavigation { get; set; }

    public virtual TblProduto? CodprodutoNavigation { get; set; }
}
