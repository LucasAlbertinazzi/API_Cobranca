using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblEtiquetaPreco
{
    public long Codigo { get; set; }

    /// <summary>
    /// Codigo do produto
    /// </summary>
    public string? Codproduto { get; set; }

    /// <summary>
    /// Codigo da loja que sera imprssa a etiqueta
    /// </summary>
    public int? Codloja { get; set; }

    public decimal? Avista { get; set; }

    public int? Parcelas { get; set; }

    public decimal? Valorparcela { get; set; }

    public string? Juro { get; set; }

    public DateTime? Dataimpre { get; set; }

    public virtual TblLoja? CodlojaNavigation { get; set; }

    public virtual TblProduto? CodprodutoNavigation { get; set; }
}
