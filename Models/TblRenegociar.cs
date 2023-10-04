using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblRenegociar
{
    public int Codigo { get; set; }

    public int? Codcliente { get; set; }

    public DateTime? Datainicio { get; set; }

    public DateTime? Datafim { get; set; }

    public int? Codusuario { get; set; }

    public decimal? Vlroriginal { get; set; }

    public decimal? Descoriginal { get; set; }

    public decimal? Vlrjuro { get; set; }

    public decimal? Descjuro { get; set; }

    public decimal? Vlratual { get; set; }

    public decimal? Taxajuro { get; set; }

    public int? Ocorre1 { get; set; }

    public int? Ocorre1User { get; set; }

    public string? Ocorre1Obs { get; set; }

    public DateTime? Ocorre1Data { get; set; }

    public int? Ocorre2 { get; set; }

    public int? Ocorre2User { get; set; }

    public string? Ocorre2Obs { get; set; }

    public DateTime? Ocorre2Data { get; set; }

    public int? Ocorre3 { get; set; }

    public int? Ocorre3User { get; set; }

    public string? Ocorre3Obs { get; set; }

    public DateTime? Ocorre3Data { get; set; }

    public int? Codloja { get; set; }

    public decimal? Taxajuroanterior { get; set; }

    public char? ClasseCliente { get; set; }
}
