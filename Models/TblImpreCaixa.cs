using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblImpreCaixa
{
    public string Localip { get; set; } = null!;

    public string? Localhostname { get; set; }

    public string? Printerip { get; set; }

    public short? Usuario { get; set; }

    public DateTime? Data { get; set; }
}
