using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblCloneCaixaMov
{
    public long? Codigo { get; set; }

    public DateOnly? Datacaixa { get; set; }

    public TimeOnly? Horacaixa { get; set; }

    public decimal? Cxinicial { get; set; }

    public decimal? RecContadi { get; set; }

    public decimal? EstContadi { get; set; }

    public decimal? RecContachpre { get; set; }

    public decimal? EstContachpre { get; set; }

    public decimal? RecPedidodi { get; set; }

    public decimal? EstPedidodi { get; set; }

    public decimal? RecPedidochpre { get; set; }

    public decimal? EstPedidochpre { get; set; }

    public decimal? CreditoDi { get; set; }

    public decimal? DebitoDi { get; set; }

    public decimal? CreditoChpre { get; set; }

    public decimal? DebitoChpre { get; set; }

    public decimal? CredDiversosdi { get; set; }

    public decimal? DebDiversosdi { get; set; }

    public decimal? CredDiversoschpre { get; set; }

    public decimal? DebDiversoschpre { get; set; }

    public decimal? TotalCreditos { get; set; }

    public decimal? TotalDebitos { get; set; }

    public decimal? SaldoCaixa { get; set; }

    public int? Codusuario { get; set; }

    public string? Letracaixa { get; set; }

    public int? Codloja { get; set; }

    public char? Situacao { get; set; }

    public decimal? TotalCaixadi { get; set; }

    public decimal? FaltaCaixadi { get; set; }

    public decimal? TotalCaixachpre { get; set; }

    public decimal? FaltaCaixachpre { get; set; }

    public decimal? FaltaTotalcaixa { get; set; }

    public DateOnly? Datafecha { get; set; }

    public TimeOnly? Horafecha { get; set; }

    public string? Obs { get; set; }
}
