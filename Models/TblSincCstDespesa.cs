using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSincCstDespesa
{
    public int Id { get; set; }

    public int Cfop { get; set; }

    public int Cst { get; set; }

    public string? CstsOriginal { get; set; }
}
