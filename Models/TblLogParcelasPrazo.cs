using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblLogParcelasPrazo
{
    public DateTime? Datahora { get; set; }

    public int Id { get; set; }

    public string? Login { get; set; }

    public string? Codpedido { get; set; }
}
