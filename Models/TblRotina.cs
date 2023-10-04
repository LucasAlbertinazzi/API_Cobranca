using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblRotina
{
    public int CodRotina { get; set; }

    public int? Codloja { get; set; }

    public decimal? Nota { get; set; }

    public string? Data { get; set; }

    public DateOnly? DataAbertura { get; set; }

    public int? CodUsuario { get; set; }

    public DateOnly? DataFim { get; set; }

    public bool Fechado { get; set; }
}
