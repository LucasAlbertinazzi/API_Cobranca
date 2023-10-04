using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblBairro
{
    public long Codbairro { get; set; }

    public string? Bairro { get; set; }

    public string? User { get; set; }
}
