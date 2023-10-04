using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblObsAgendaFinanc
{
    public DateOnly Mes { get; set; }

    public string? Obs { get; set; }
}
