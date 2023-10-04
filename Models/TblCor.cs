using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblCor
{
    public long Codcor { get; set; }

    public string? Cor { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Atualizado { get; set; }

    public int? CodusuarioWeb { get; set; }

    public DateTime? AtualizadoWeb { get; set; }
}
