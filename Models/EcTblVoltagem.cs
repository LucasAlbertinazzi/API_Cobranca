using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Voltagem dos Produtos no E-commerce
/// </summary>
public partial class EcTblVoltagem
{
    public short Codigo { get; set; }

    public string? Voltagem { get; set; }
}
