using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblErro
{
    public long Id { get; set; }

    public string? Erro { get; set; }

    public DateTime? Data { get; set; }

    public string? Usuario { get; set; }
}
