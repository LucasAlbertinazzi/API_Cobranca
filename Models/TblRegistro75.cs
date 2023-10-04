using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblRegistro75
{
    public int Codigo { get; set; }

    public DateOnly? Datainicio { get; set; }

    public DateOnly? Datafim { get; set; }

    public string? Codproduto { get; set; }

    public int? Codigonbm { get; set; }

    public string? Descricao { get; set; }

    public string? Un { get; set; }

    public int? Situacaotributaria { get; set; }

    public int? Aliquotaicms { get; set; }

    public int? Reducaobaseicms { get; set; }

    public int? Basecalculoicms { get; set; }

    public int? Codloja { get; set; }

    public int? Serie { get; set; }

    public int? Numero { get; set; }

    public char? Cancelada { get; set; }

    public DateTime? Datacancelada { get; set; }

    public int? Usercancelou { get; set; }
}
