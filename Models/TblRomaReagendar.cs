using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblRomaReagendar
{
    public long Codigo { get; set; }

    /// <summary>
    /// codigo de identificação do romaneio
    /// </summary>
    public long? Codidromaneio { get; set; }

    /// <summary>
    /// Data que estava agendada a entrega
    /// </summary>
    public DateOnly? Dataentrega { get; set; }

    /// <summary>
    /// Agendou para essa data
    /// </summary>
    public DateOnly? Agendoupara { get; set; }

    public string? Motivo { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Atualizado { get; set; }

    public string? Obs { get; set; }

    /// <summary>
    /// Tipo de reagendamento, entrega ou montagem
    /// </summary>
    public char? Tipo { get; set; }

    public int? Codmotivo { get; set; }
}
