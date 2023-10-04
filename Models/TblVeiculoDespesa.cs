using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// despesas por veiculo para entrega
/// </summary>
public partial class TblVeiculoDespesa
{
    public int Codigo { get; set; }

    public int? Codveiculo { get; set; }

    public decimal? KmL { get; set; }

    public decimal? Pneu { get; set; }

    public decimal? Revisao { get; set; }

    public decimal? Lavagem { get; set; }

    public decimal? Ipva { get; set; }

    public decimal? Seguro { get; set; }

    public decimal? Manutencao { get; set; }

    public decimal? Licenca { get; set; }
}
