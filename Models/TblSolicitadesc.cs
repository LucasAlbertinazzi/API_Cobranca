using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Solicita aos Gerentes Autorização de desconto acima do permitido
/// </summary>
public partial class TblSolicitadesc
{
    /// <summary>
    /// Codigo da solicitação
    /// </summary>
    public long Codigo { get; set; }

    public long? Codcliente { get; set; }

    /// <summary>
    /// valor das parcelas sem juro e sem desconto
    /// </summary>
    public decimal? Vlrparcelas { get; set; }

    /// <summary>
    /// Valor a pagar com acrescimo
    /// </summary>
    public decimal? Vlrapagar { get; set; }

    /// <summary>
    /// Desconto permitido
    /// </summary>
    public decimal? Descpermitido { get; set; }

    /// <summary>
    /// Desconto solicitado
    /// </summary>
    public decimal? Descsolicitado { get; set; }

    /// <summary>
    /// valor do desconto autorizado
    /// </summary>
    public decimal? Descconcedido { get; set; }

    /// <summary>
    /// Codigo do Solicitante
    /// </summary>
    public int? Codsolicitante { get; set; }

    /// <summary>
    /// Codigo de quem autorizou o desconto.
    /// </summary>
    public int? Codautoriza { get; set; }

    /// <summary>
    /// Valor do desconto autorizado
    /// </summary>
    public decimal? Vlrdescautorizado { get; set; }

    /// <summary>
    /// Se o desconto ja foi utilizado
    /// </summary>
    public char? Utilizado { get; set; }

    public string? Caixa { get; set; }

    public int? Codlojacaixa { get; set; }

    public DateTime? Datasolicita { get; set; }

    public DateTime? Dataautoriza { get; set; }

    public DateTime? Validade { get; set; }

    public string? Motivo { get; set; }

    /// <summary>
    /// Motivo dado pelo gerente para o desconto
    /// </summary>
    public string? MotivoGer { get; set; }
}
