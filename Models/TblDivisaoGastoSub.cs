using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblDivisaoGastoSub
{
    public int Codigo { get; set; }

    public string? Descricao { get; set; }

    public int? Coddivisao { get; set; }
}
