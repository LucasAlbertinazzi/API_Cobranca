using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblIpDe
{
    public int Id { get; set; }

    public string? Ip { get; set; }

    public string? Local { get; set; }

    public DateTime? Data { get; set; }

    public string? Usuario { get; set; }

    public int? Codloja { get; set; }

    public int IdAtivoTipo { get; set; }
}
