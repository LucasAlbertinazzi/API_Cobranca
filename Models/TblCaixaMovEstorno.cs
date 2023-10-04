using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblCaixaMovEstorno
{
    public int Id { get; set; }

    public int? IdCaixa { get; set; }

    public string? Codpedido { get; set; }

    public int? Codparcela { get; set; }

    public string? TipoEstorno { get; set; }

    public decimal? Valor { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Data { get; set; }
}
