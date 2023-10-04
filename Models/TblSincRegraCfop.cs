using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSincRegraCfop
{
    public int Id { get; set; }

    public int? TipoNota { get; set; }

    public string? CstNotaDeveTer { get; set; }

    public string? CsosnNotaDeveTer { get; set; }

    public int? CfopNotaDeveTer { get; set; }

    public int? CfopResultado { get; set; }

    public int GrupoRegra { get; set; }
}
