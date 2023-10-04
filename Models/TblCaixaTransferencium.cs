using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Valores que sao transferidos entre caixa.
/// </summary>
public partial class TblCaixaTransferencium
{
    public long Codigo { get; set; }

    /// <summary>
    /// Caixa de Debito
    /// </summary>
    public long? Caixadebito { get; set; }

    /// <summary>
    /// Caixa de credito
    /// </summary>
    public long? Caixacredito { get; set; }

    /// <summary>
    /// Valor transferido
    /// </summary>
    public decimal? Valor { get; set; }

    /// <summary>
    /// Tipo de transferencia DI ou DP
    /// </summary>
    public string? Tipo { get; set; }

    /// <summary>
    /// Data da transferencia
    /// </summary>
    public DateTime? Data { get; set; }

    public int? Codusuario { get; set; }

    /// <summary>
    /// Confirma entrada S ou N
    /// </summary>
    public char? Confirma { get; set; }

    /// <summary>
    /// Valor que foi Creditado no caixa
    /// </summary>
    public decimal? Valorcreditado { get; set; }

    public char? Estorno { get; set; }

    /// <summary>
    /// Data da confirmação
    /// </summary>
    public DateTime? Dataconfirma { get; set; }

    public string? Obs { get; set; }

    public string? Nsu { get; set; }

    public bool? BaixadoContabilidade { get; set; }
}
