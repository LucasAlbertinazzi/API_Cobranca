using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Armazena a Expedição do E-commerce das Coletoras
/// </summary>
public partial class EcTblExpedicao
{
    public int Codigo { get; set; }

    public int? Nota { get; set; }

    public string? Volume { get; set; }

    public int? UserEmbarque { get; set; }

    public bool? Embarque { get; set; }

    public DateTime? DataEmbarque { get; set; }

    public int? UserDesembarque { get; set; }

    public bool? Desembarque { get; set; }

    public DateTime? DataDesembarque { get; set; }

    public int? CodVeiculo { get; set; }

    public int? UserNota { get; set; }

    public DateTime? DataNota { get; set; }

    public bool? BaixaRomaneio { get; set; }

    public DateTime? DataBaixaRoma { get; set; }
}
