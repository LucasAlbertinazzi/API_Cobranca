using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// posições disponíveis no depósito
/// a composição do código é 
/// DIGITO         DESCRIÇÃO
/// 1 e 2               RUA
/// 3                     LADO
/// 4                    COLUNA
/// 5                    ALTURA
/// 6                    PALETE(com um ponto antes)
/// </summary>
public partial class TblLogisticaPosico
{
    public string Posicao { get; set; } = null!;

    public string? Rua { get; set; }

    public char? Lado { get; set; }

    public string? Coluna { get; set; }

    public string? Altura { get; set; }

    public string? Palete { get; set; }

    public decimal? Alt { get; set; }

    public decimal? Lar { get; set; }

    public decimal? Pro { get; set; }

    public bool? Disponivel { get; set; }
}
