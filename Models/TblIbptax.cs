using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblIbptax
{
    /// <summary>
    /// NCM
    /// </summary>
    public string Codigo { get; set; } = null!;

    public short? Ex { get; set; }

    public char? Tabela { get; set; }

    public string? Descricao { get; set; }

    public decimal? Aliqnac { get; set; }

    public decimal? Aliqimp { get; set; }

    public string? Versao { get; set; }

    public decimal? AliqEstadual { get; set; }

    public decimal? AliqMunicipal { get; set; }

    public DateOnly? Vigenciainicio { get; set; }

    public DateOnly? Vigenciafim { get; set; }

    public string? Chave { get; set; }

    public string? Fonte { get; set; }
}
