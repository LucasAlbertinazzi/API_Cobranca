using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblFeriado
{
    public DateOnly Data { get; set; }

    public string? Descricao { get; set; }
}
