using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Valor das Parcelas na Skyhub
/// </summary>
public partial class EcTblProdutoValorParc
{
    public int Codvalor { get; set; }

    public short Quantparc { get; set; }

    public decimal? Taxa { get; set; }

    public decimal? Valor { get; set; }

    public string? Detalhe { get; set; }

    public bool? Exibir { get; set; }
}
