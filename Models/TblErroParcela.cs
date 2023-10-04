using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblErroParcela
{
    public int Codigo { get; set; }

    public long? Codigoparcela { get; set; }

    public string? Usuario { get; set; }

    public DateTime? Data { get; set; }

    public int? Codprepedido { get; set; }
}
