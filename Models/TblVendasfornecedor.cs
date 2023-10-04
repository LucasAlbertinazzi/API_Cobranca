using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblVendasfornecedor
{
    public int IdVendasfornecedor { get; set; }

    public string Fornecedor { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Codproduto { get; set; } = null!;

    public string Departamento { get; set; } = null!;
}
