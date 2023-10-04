using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: COMPRAS, INCLUSÃO
/// Histórico de prorrogação de entrega (recebimento)
/// </summary>
public partial class TblPedidoCompraProrr
{
    public int Codigo { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Data { get; set; }

    public DateOnly? PrevAnterior { get; set; }

    public DateOnly? PrevAtual { get; set; }

    public long? Codpedidocompra { get; set; }
}
