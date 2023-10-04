using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// estado de estoque por departamento
/// </summary>
public partial class TblStatusEstoqueDep
{
    public int Codigo { get; set; }

    public DateOnly? Data { get; set; }

    public int? Coddepartamento { get; set; }

    public string? Departamento { get; set; }

    public decimal? Custo { get; set; }

    public decimal? Venda { get; set; }

    public decimal? EstoqueMedio { get; set; }
}
