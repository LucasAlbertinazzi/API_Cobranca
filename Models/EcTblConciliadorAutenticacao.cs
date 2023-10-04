using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class EcTblConciliadorAutenticacao
{
    public int Id { get; set; }

    public string? Token { get; set; }

    public int? TempExp { get; set; }

    public DateTime? Date { get; set; }

    public bool? Status { get; set; }
}
