using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: E-COMMERCE
/// dados API transportadoras para integração de pedidos entregues.
/// </summary>
public partial class TblApiTransportadora
{
    public int Codigo { get; set; }

    public string Transportadora { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Rest { get; set; }

    public string? Descricao { get; set; }

    public string? Tipo { get; set; }
}
