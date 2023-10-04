using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblMarketingCliente
{
    public int Id { get; set; }

    public long? Codcliente { get; set; }

    public long? Codpedido { get; set; }

    public DateTime? Data { get; set; }

    public string? Login { get; set; }

    public long? IdPromo { get; set; }

    public string? Pesquisa { get; set; }

    public long? Codloja { get; set; }
}
