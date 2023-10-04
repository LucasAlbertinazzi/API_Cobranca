using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblFinanceira
{
    public int Codigo { get; set; }

    public string? Financeira { get; set; }

    public string? User { get; set; }

    /// <summary>
    /// tipo convenio ou financeira
    /// </summary>
    public char? Tipo { get; set; }
}
