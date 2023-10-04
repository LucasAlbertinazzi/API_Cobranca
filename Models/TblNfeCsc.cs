using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblNfeCsc
{
    public int Codigo { get; set; }

    public string? IdCodSeg { get; set; }

    public string? CodSeguranca { get; set; }

    public bool? Ativo { get; set; }

    public bool? Producao { get; set; }

    public string? UrlQrcode { get; set; }
}
