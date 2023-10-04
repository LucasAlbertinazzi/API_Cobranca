using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblNfeEmissao
{
    public int Id { get; set; }

    public int? Login { get; set; }

    public int? Loja { get; set; }

    public bool? Bloqueada { get; set; }

    public DateTime? Data { get; set; }

    public int? Numnota { get; set; }

    public string? Status { get; set; }

    public string? Tipo { get; set; }
}
