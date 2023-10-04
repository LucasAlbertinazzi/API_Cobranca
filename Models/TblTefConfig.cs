using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblTefConfig
{
    public int Id { get; set; }

    public int Codloja { get; set; }

    public int? CodEmpresa { get; set; }

    public string? IpTef { get; set; }

    public string? IpPdv1 { get; set; }

    public string? IpPdv2 { get; set; }

    public string? Senha { get; set; }
}
