using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSubPedidoCompraHistVincNotum
{
    public int Id { get; set; }

    public decimal? NfeEntrada { get; set; }

    public long? Codigo { get; set; }

    public long? Codpedidocompra { get; set; }

    public string? Codproduto { get; set; }

    public int? NVinc { get; set; }

    public string? Codfabrica { get; set; }

    public string? Descricao { get; set; }

    public string? DescricaoXml { get; set; }

    public long? Quantidade { get; set; }

    public long? QtdefaturadaXml { get; set; }

    public string? UserVinc { get; set; }

    public bool? ModoVinc { get; set; }

    public DateTime? Data { get; set; }

    public string? CodprodutoXml { get; set; }

    public string? Chaveacesso { get; set; }
}
