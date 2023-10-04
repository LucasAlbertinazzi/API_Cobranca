using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// tabela que indica o status do romaneio para determinado dia
/// </summary>
public partial class TblRomaneioStatus
{
    /// <summary>
    /// codigo da operação
    /// </summary>
    public long Codigo { get; set; }

    /// <summary>
    /// Data do romaneio
    /// </summary>
    public DateOnly? Data { get; set; }

    /// <summary>
    /// Rota do romaneio
    /// </summary>
    public int? Rota { get; set; }

    /// <summary>
    /// Observações de entrega
    /// </summary>
    public string? Obs { get; set; }

    public DateTime? Atualizado { get; set; }

    public string? Usuario { get; set; }

    public short? Situacao { get; set; }
}
