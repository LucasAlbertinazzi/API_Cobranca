using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblArquivoPedido
{
    public int Id { get; set; }

    public string Codpedido { get; set; } = null!;

    public int Logistica { get; set; }

    public bool Completo { get; set; }

    public DateTime Data { get; set; }

    public string? Refpedido { get; set; }

    public bool MarciusBusca { get; set; }
}
