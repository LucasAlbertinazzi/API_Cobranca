using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// [nao mais utilizado a partir de 25/02/2021] 
/// </summary>
public partial class EcTblTransportadoraDirect
{
    public long Codigo { get; set; }

    public decimal? DeKg { get; set; }

    public decimal? AteKg { get; set; }

    public decimal? Grupo1Integral { get; set; }

    public decimal? Grupo240Perc { get; set; }

    public decimal? Grupo350Perc { get; set; }

    public decimal? Grupo460Perc { get; set; }
}
