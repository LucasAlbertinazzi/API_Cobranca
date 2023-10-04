using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblPedTrocauser
{
    public int Codigo { get; set; }

    public string? Codpedido { get; set; }

    public int? Antes { get; set; }

    public int? Depois { get; set; }

    public DateTime? Datatroca { get; set; }

    public int? Trocadopor { get; set; }
}
