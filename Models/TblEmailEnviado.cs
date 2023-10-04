using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblEmailEnviado
{
    public int Id { get; set; }

    public string Usuario { get; set; } = null!;

    public string Erro { get; set; } = null!;

    public DateTime Data { get; set; }

    public string? Pedido { get; set; }

    public string? Transportadora { get; set; }
}
