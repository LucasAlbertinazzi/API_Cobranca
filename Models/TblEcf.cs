using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblEcf
{
    public int Codfabrica { get; set; }

    public int? Ecf { get; set; }

    public int? Loja { get; set; }

    public string? SerieEcf { get; set; }

    public string? SerieMfd { get; set; }
}
