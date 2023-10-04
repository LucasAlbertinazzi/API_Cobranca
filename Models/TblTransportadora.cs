using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblTransportadora
{
    public int Id { get; set; }

    public string? Cnpj { get; set; }

    public string? Razaosocial { get; set; }

    public string? Nomefantasia { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Data { get; set; }
}
