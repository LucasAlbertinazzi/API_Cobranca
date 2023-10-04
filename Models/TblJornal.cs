using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblJornal
{
    public int Codigo { get; set; }

    public string? Nomejornal { get; set; }

    public decimal? Tac { get; set; }

    public decimal? Coeficiente { get; set; }

    public decimal? Juro { get; set; }

    public DateTime? Dataentrada { get; set; }

    public DateTime? Datasaida { get; set; }

    public char? Botafora { get; set; }

    public decimal? Juronocartao { get; set; }
}
