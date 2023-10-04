using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Armazena a Informação da Nota de cada Pedido
/// </summary>
public partial class EcTblPedidoTranspNotum
{
    public string Codpedido { get; set; } = null!;

    public int? IdTransportadora { get; set; }

    public short? QuantVol { get; set; }

    public string? EspecieVolume { get; set; }

    public decimal? PesoLiq { get; set; }

    public decimal? PesoBruto { get; set; }
}
