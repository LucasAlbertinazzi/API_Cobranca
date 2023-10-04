using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// divisao de gasto principal
/// </summary>
public partial class TblDivisaoGastoPrinc
{
    public int Codigo { get; set; }

    public string? Descricao { get; set; }
}
