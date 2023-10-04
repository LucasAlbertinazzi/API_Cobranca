using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSitefRefVendum
{
    public string Codigo { get; set; } = null!;

    public int CupomFiscal { get; set; }
}
