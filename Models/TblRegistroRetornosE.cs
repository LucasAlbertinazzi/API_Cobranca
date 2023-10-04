using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblRegistroRetornosE
{
    public string? Codigo { get; set; }

    public string? Mensagem { get; set; }

    public string? Arquivo { get; set; }

    public long Id { get; set; }
}
