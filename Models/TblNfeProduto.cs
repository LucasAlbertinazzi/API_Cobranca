using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblNfeProduto
{
    public int Codigo { get; set; }

    public string? Codpedido { get; set; }

    public string? CodsubpedidoOld { get; set; }

    public long? DocFiscal { get; set; }

    /// <summary>
    /// tipo 1 = nota fiscal consumidor eletronica
    /// tipo 2 = nota fiscal eletronica
    /// </summary>
    public short? TipoDoc { get; set; }

    public string? Codproseq { get; set; }

    public string? Ncm { get; set; }

    public string? Codprodutonota { get; set; }

    public string? Descricao { get; set; }

    public string? Codean { get; set; }

    public decimal? Composicao { get; set; }

    public string? Cstvenda { get; set; }

    public string? Cstpiscofins { get; set; }

    public char? St { get; set; }

    public string? Ucom { get; set; }

    public decimal? IcmsSaida { get; set; }

    public decimal? Bcalculoicmsst { get; set; }

    public short? Quant { get; set; }

    public decimal? Vunit { get; set; }

    public float? Desconto { get; set; }

    public float? Acrescimo { get; set; }

    public decimal? Vvendaunit { get; set; }

    public decimal? Vvendatotal { get; set; }

    public decimal? PrecovendaT1 { get; set; }

    public string? Codeantrib { get; set; }

    public decimal? AliquotaPis { get; set; }

    public decimal? AliquotaCofins { get; set; }

    public int? QuantPedido { get; set; }

    public long? Codsubpedido { get; set; }

    public long? Nfe { get; set; }

    public long? Nfce { get; set; }

    public string? Imei { get; set; }

    public string? Cest { get; set; }

    public string? Imei2 { get; set; }

    public decimal? Vbcufdest { get; set; }

    public decimal? Pfcpufdest { get; set; }

    public decimal? Picmsufdest { get; set; }

    public decimal? Picmsinter { get; set; }

    public decimal? Picmsinterpart { get; set; }

    public decimal? Vfcpufdest { get; set; }

    public decimal? Vicmsufdest { get; set; }

    public decimal? Vicmsufremet { get; set; }

    public decimal? RedBc { get; set; }

    public decimal? RedBcDifal { get; set; }
}
