using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblStefRefVendum
{
    public string Codigo { get; set; } = null!;

    public int CupomFiscal { get; set; }
}
