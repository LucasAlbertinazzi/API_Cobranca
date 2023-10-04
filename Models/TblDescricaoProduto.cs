using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblDescricaoProduto
{
    public long Codigo { get; set; }

    public string? Codproduto { get; set; }

    public string? Descricao { get; set; }

    public virtual TblProduto? CodprodutoNavigation { get; set; }
}
