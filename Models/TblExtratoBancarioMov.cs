using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblExtratoBancarioMov
{
    public int Id { get; set; }

    public int? IdBanco { get; set; }

    /// <summary>
    /// TRNTYPE
    /// </summary>
    public string? Tipo { get; set; }

    /// <summary>
    /// DTPOSTED
    /// </summary>
    public DateOnly? Data { get; set; }

    /// <summary>
    /// TRNAMT
    /// </summary>
    public decimal? Valor { get; set; }

    /// <summary>
    /// FITID
    /// </summary>
    public string? Documento { get; set; }

    /// <summary>
    /// CHECKNUM
    /// </summary>
    public string? Numero { get; set; }

    /// <summary>
    /// MEMO
    /// </summary>
    public string? Descricao { get; set; }
}
