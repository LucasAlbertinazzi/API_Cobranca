using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblBanco
{
    public int Codigo { get; set; }

    /// <summary>
    /// Nunero do banco
    /// </summary>
    public string? Numero { get; set; }

    public string? Banco { get; set; }

    public string? Site { get; set; }
}
