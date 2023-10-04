using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblHistoricoPedidosEcommerce
{
    public int Id { get; set; }

    public string? Codpedido { get; set; }

    public int? Coddepartamento { get; set; }

    public string? Obs { get; set; }

    public DateTime? Data { get; set; }

    public long? Codigo { get; set; }

    public DateTime? DataComentario { get; set; }
}
