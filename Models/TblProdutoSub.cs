using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: Produtos, Inclusão
/// Contém a relação de produtos e seus respectivos códigos de garantia estendida, além de outros dados, como codprodnota, descrição do produto na nota fiscal de entrada, NCM, EAN, EAN tributário, alíquotas de imposto, base de cálculo ICMS, créditos de impostos. Uma série de dados desta tabela estão também na tabela tbl_produto_alq_ncm. [Porem tabela não tem nenhuma relação com codigo de garantia estendida, codigos da garantia estão na tbl_produto]
/// 
/// </summary>
public partial class TblProdutoSub
{
    public int Codigo { get; set; }

    public string Codproduto { get; set; } = null!;

    public int Seq { get; set; }

    public string? Codproseq { get; set; }

    public decimal? Quantidade { get; set; }

    public string? Codprodutonota { get; set; }

    public string? Descricao { get; set; }

    public string? Ncm { get; set; }

    public string? Codean { get; set; }

    public string? Codeantrib { get; set; }

    public decimal? Composicao { get; set; }

    public string? Cstcompra { get; set; }

    public string? Cstvenda { get; set; }

    public decimal? Icms { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Aliqiva { get; set; }

    public char? St { get; set; }

    public string? Cstpiscofins { get; set; }

    public string? Ucom { get; set; }

    public decimal? IcmsSaida { get; set; }

    public decimal? Vunit { get; set; }

    public decimal? Bcalculoicms { get; set; }

    public decimal? Vicms { get; set; }

    public decimal? Vst { get; set; }

    public decimal? Vipi { get; set; }

    public decimal? Vfrete { get; set; }

    public decimal? Va { get; set; }

    public decimal? Vendor { get; set; }

    public decimal? Credicms { get; set; }

    public decimal? Credpis { get; set; }

    public decimal? Credcofins { get; set; }

    public decimal? Custovenda { get; set; }

    public decimal? Totalsemcredito { get; set; }

    public decimal? Totalcomcredito { get; set; }

    public decimal? Bcalculoicmsst { get; set; }

    public string? Cest { get; set; }

    public decimal? IcmsRecuperar { get; set; }

    public decimal? StRecuperar { get; set; }
}
