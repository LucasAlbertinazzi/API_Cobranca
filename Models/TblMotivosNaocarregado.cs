using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblMotivosNaocarregado
{
    public int Codigo { get; set; }

    public string? Motivo { get; set; }

    public char? Ativo { get; set; }
}
