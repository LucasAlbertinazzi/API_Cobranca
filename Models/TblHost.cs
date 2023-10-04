using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblHost
{
    public int Codigo { get; set; }

    public string? Nome { get; set; }

    public string? Ip { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Data { get; set; }

    public string? Mac { get; set; }

    public string? Versao { get; set; }

    public string? Acessou { get; set; }

    public int? Usuario { get; set; }
}
