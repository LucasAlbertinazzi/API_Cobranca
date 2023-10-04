using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// codproduto e suas posições em nosso centro de distribuição
/// 
/// DIGITO         DESCRIÇÃO
/// 1 e 2               RUA
/// 3                     LADO
/// 4                    COLUNA
/// 5                    ALTURA
/// 6                    PALETE(com um ponto antes)
/// </summary>
public partial class TblLogisticaProdPo
{
    public string Codproduto { get; set; } = null!;

    public string? Posicao { get; set; }
}
