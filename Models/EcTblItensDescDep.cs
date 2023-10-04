using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Itens da descrição dos produtos por departamento
/// </summary>
public partial class EcTblItensDescDep
{
    public int Codigo { get; set; }

    public int? Coddep { get; set; }

    public string? Item { get; set; }

    public short? Ordenacao { get; set; }
}
