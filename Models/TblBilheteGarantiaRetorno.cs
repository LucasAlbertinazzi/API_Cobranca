using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblBilheteGarantiaRetorno
{
    public string Arquivo { get; set; } = null!;

    public DateTime? DataRetorno { get; set; }
}
