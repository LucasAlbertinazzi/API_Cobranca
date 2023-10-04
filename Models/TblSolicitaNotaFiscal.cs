using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSolicitaNotaFiscal
{
    public int Id { get; set; }

    public int NfeId { get; set; }

    public int Usuario { get; set; }

    public string? Descricao { get; set; }

    public DateTime Data { get; set; }
}
