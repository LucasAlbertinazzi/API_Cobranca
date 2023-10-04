using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblRenegociarOcorrencium
{
    public int Codigo { get; set; }

    public int? Codocorrencia { get; set; }

    public int? Codreneg { get; set; }

    public string? Obs { get; set; }
}
