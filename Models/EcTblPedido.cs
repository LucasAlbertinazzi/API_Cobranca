using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Armazena os Pedidos Gerado na Skyhub e E-commerce
/// </summary>
public partial class EcTblPedido
{
    public int Id { get; set; }

    public string? Canal { get; set; }

    public string? Codigo { get; set; }

    public DateTime? DataPedido { get; set; }

    public DateTime? DataAtualizado { get; set; }

    public decimal? ValorTotal { get; set; }

    public decimal? ValorDesconto { get; set; }

    public decimal? ValorJuro { get; set; }

    public decimal? CustoEntrega { get; set; }

    public string? MetodoEntrega { get; set; }

    public DateTime? EntregaEstimada { get; set; }

    public long? Codprepedido { get; set; }

    public DateTime? DataPrepedido { get; set; }

    public string? Codpedido { get; set; }

    public DateTime? DataPedidoInterno { get; set; }

    public bool? Excluido { get; set; }

    public bool? ChaveEnviada { get; set; }

    public string? CodRastreio { get; set; }

    public bool? RastreioEnviado { get; set; }

    public bool? ObjetoEntregue { get; set; }

    public string? EventoCodigo { get; set; }

    public DateOnly? EvntoData { get; set; }

    public string? EventoDetalhe { get; set; }

    public string? EventoLocal { get; set; }

    public string? EventoUf { get; set; }

    public TimeOnly? EventoHora { get; set; }

    public string? CodPedidoCancelado { get; set; }

    public string? CodPedidoNovo { get; set; }

    public string? Obs { get; set; }

    public DateTime? ChaveEnviadaData { get; set; }

    public DateTime? RastreioEnviadoData { get; set; }

    public DateTime? ObjetoEntregueData { get; set; }

    public string? Marketplace { get; set; }

    public bool? Confirmado { get; set; }

    public int? VendedorVinculado { get; set; }

    public string? IdMarketplace { get; set; }

    public virtual EcTblPedidoEndCobranca? EcTblPedidoEndCobranca { get; set; }

    public virtual EcTblPedidoEndEntrega? EcTblPedidoEndEntrega { get; set; }
}
