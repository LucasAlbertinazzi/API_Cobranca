using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: Pedido, Produto, Inclusão
/// Relacionada a tabela tbl_produto. Esta tabela contém a quantidade de cada produto em cada loja
/// </summary>
public partial class TblProdutoQuant
{
    public long Codigo { get; set; }

    public string Codproduto { get; set; } = null!;

    public int Coddeposito { get; set; }

    public long? Quantidade { get; set; }

    /// <summary>
    /// Somar produto ao estoque
    /// </summary>
    public char? Somarestoque { get; set; }

    /// <summary>
    /// Valor de custo do produto
    /// </summary>
    public decimal? Valorcusto { get; set; }

    /// <summary>
    /// Estoque minimo para transferencia
    /// </summary>
    public int? MinimoTransf { get; set; }

    public DateOnly? Adiarate { get; set; }

    /// <summary>
    /// usuario que configurou estoque minimo
    /// </summary>
    public int? UserMinimo { get; set; }

    /// <summary>
    /// data que configurou o estoque minimo
    /// </summary>
    public DateTime? DataMinimo { get; set; }

    public decimal? CustoSemCredito { get; set; }

    public virtual TblLoja CoddepositoNavigation { get; set; } = null!;
}
