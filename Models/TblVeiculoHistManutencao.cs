using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblVeiculoHistManutencao
{
    public int Codigo { get; set; }

    public int? Codveiculo { get; set; }

    public long? Codpedidocompra { get; set; }

    public DateTime? Data { get; set; }

    public virtual TblPedidoCompra? CodpedidocompraNavigation { get; set; }

    public virtual TblVeiculo? CodveiculoNavigation { get; set; }
}
