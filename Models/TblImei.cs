using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblImei
{
    public string Codproduto { get; set; } = null!;

    public int Id { get; set; }

    public string Imei { get; set; } = null!;

    public bool Utilizado { get; set; }

    public DateOnly Data { get; set; }

    public decimal Login { get; set; }

    public string? Imei2 { get; set; }

    public int? Codloja { get; set; }

    public string? Codigodebarra { get; set; }

    public int? Transferidopara { get; set; }

    public int? Usertransf { get; set; }

    public DateOnly? Datatransf { get; set; }

    public int? Userrecebido { get; set; }

    public DateOnly? Datarecebido { get; set; }

    public string? Obs { get; set; }

    public bool? Identificatr { get; set; }
}
