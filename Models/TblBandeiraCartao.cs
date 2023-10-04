using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblBandeiraCartao
{
    public short Codigo { get; set; }

    public string? Bandeira { get; set; }
}
