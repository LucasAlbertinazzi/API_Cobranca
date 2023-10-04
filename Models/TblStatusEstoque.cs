using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Correlacionada com a tbl_prod_mov, abastecida na tela FrmStatusEstoque
/// </summary>
public partial class TblStatusEstoque
{
    public int Codigo { get; set; }

    public DateOnly? Data { get; set; }

    public string? Divisao { get; set; }

    public decimal? Valorcusto { get; set; }

    public decimal? Porc { get; set; }

    public decimal? Valorvendido { get; set; }
}
