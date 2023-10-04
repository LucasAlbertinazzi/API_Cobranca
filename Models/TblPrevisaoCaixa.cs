using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Contém os valores  estimados da previsão de caixa, com suas respectivas divisões e subdivisões, conforme os códigos das tabelas tbl_divisao_gasto, tbl_divisao_gasto_princ e tbl_divisao_gasto_sub.
/// </summary>
public partial class TblPrevisaoCaixa
{
    public int Codigo { get; set; }

    public DateOnly? Data { get; set; }

    public short? Coddiv { get; set; }

    public short? Codsubdiv { get; set; }

    public decimal? Vlrestimado { get; set; }

    public string? Texto { get; set; }

    public bool? Total { get; set; }

    public short? Indice { get; set; }
}
