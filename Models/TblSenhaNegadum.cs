using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSenhaNegadum
{
    public int Codigo { get; set; }

    public int? Codcliente { get; set; }

    public string? Usuario { get; set; }

    public string? Motivo { get; set; }

    public DateTime? Data { get; set; }

    public int? Senha { get; set; }
}
