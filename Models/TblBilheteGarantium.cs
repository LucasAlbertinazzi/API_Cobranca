using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblBilheteGarantium
{
    public short Codloja { get; set; }

    public int Sequencia { get; set; }

    public string? Bilhete { get; set; }

    public string? Codpedido { get; set; }

    public long? Codsubpedido { get; set; }

    public DateTime? ConfBilhete { get; set; }

    public int? UserBilhete { get; set; }

    /// <summary>
    /// conferencia da autorização de cobrança
    /// </summary>
    public DateTime? ConfAut { get; set; }

    public int? UserAut { get; set; }

    public int? Codenvio { get; set; }

    public int? CodenvioCancelamento { get; set; }

    public string? StatusEnvio { get; set; }

    public string? StatusCancelamento { get; set; }

    public string? CoderroEnvio { get; set; }

    public string? CoderroCancelamento { get; set; }

    public char? CorrigidoComCancel { get; set; }
}
