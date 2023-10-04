using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblScoreTabela
{
    public int Classe { get; set; }

    public char? Grupo { get; set; }

    public int? FaixaMin { get; set; }

    public int? FaixaMax { get; set; }

    public int? Probabilidade { get; set; }

    public string? Caracteristica { get; set; }

    public string? Cor { get; set; }

    /// <summary>
    /// se é score 6 meses, 12 ou 18
    /// 
    /// </summary>
    public int? Tipo { get; set; }

    public int CodScore { get; set; }
}
