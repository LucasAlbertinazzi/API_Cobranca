using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblImpCarneQuitado
{
    public string? Caixa { get; set; }

    public DateTime Data { get; set; }

    public int Codcliente { get; set; }

    public int? Codloja { get; set; }
}
