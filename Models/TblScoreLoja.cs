using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblScoreLoja
{
    public string? Residencia { get; set; }

    public string? Emprego { get; set; }

    public string? EstadoCivil { get; set; }

    public string? Spc { get; set; }

    public int? Qtd { get; set; }

    public int? EntrouP { get; set; }

    public float? Risco { get; set; }

    public string? Outlier { get; set; }

    public float? Ajustado { get; set; }

    public int Id { get; set; }

    /// <summary>
    /// classificação do score por cor
    /// </summary>
    public string? Cor { get; set; }
}
