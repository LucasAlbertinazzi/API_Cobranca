using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblAuditoriaLog
{
    public int Id { get; set; }

    public string? NomeTabela { get; set; }

    public string? Acao { get; set; }

    public DateTime? DataHora { get; set; }

    public string? Dados { get; set; }
}
