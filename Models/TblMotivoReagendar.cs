using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Motivos de Reagendar entrega do Romaneio
/// </summary>
public partial class TblMotivoReagendar
{
    /// <summary>
    /// motivo do reagendamento
    /// </summary>
    public string? Motivo { get; set; }

    public int Codigo { get; set; }
}
