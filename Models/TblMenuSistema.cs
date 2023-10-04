using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblMenuSistema
{
    public int Codigo { get; set; }

    public string? Nome { get; set; }

    public string? AbreOld { get; set; }

    public string? Abrir { get; set; }
}
