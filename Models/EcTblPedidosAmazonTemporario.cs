using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class EcTblPedidosAmazonTemporario
{
    public int Id { get; set; }

    public string? CodigoSkyhub { get; set; }

    public string? Codpedido { get; set; }

    public string? Json { get; set; }

    public DateTime? Data { get; set; }
}
