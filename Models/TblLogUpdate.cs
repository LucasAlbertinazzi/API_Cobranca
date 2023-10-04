using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblLogUpdate
{
    public string? Command { get; set; }

    public int? Userid { get; set; }

    public DateTime? Date { get; set; }

    public string? Tabela { get; set; }

    public string? RefTabela { get; set; }

    public int Id { get; set; }
}
