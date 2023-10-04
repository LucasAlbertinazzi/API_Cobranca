using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblEmailAssist
{
    public int Codigo { get; set; }

    public int? Codfornecedor { get; set; }

    public string? Contato { get; set; }

    public string? Email { get; set; }
}
