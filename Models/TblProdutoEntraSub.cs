using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: INCLUSÃO, PRODUTOS
/// Novos registros desta tabela são inseridos através da tela FrmRecebePedidoComXml, quando se recebe uma nova nota fiscal no formato XML e a abastecemos em nosso sistema. Tratam-se de registros com dados como número da nota fiscal, código do produto na nota, quantidade, NCM, EAN, EAN tributário, alíquotas de impostos,  data da inclusão, código do fornecedor, código do usuário que fez a inclusão, créditos tributários.
/// --codrecebimento da tbl_produto_entra é codentrada da tbl_produto_entra_sub
/// 
/// </summary>
public partial class TblProdutoEntraSub
{
    public int Id { get; set; }

    public int? Codentrada { get; set; }

    public int? Nfeentrada { get; set; }

    public string? Codproduto { get; set; }

    public short? Seq { get; set; }

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

    public string? Cstpiscofins { get; set; }

    public char? St { get; set; }

    public string? Ucom { get; set; }

    public decimal? Vunit { get; set; }

    public decimal? Bcalculoicms { get; set; }

    public decimal? Alicms { get; set; }

    public decimal? Vicms { get; set; }

    public decimal? Aliva { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Vst { get; set; }

    public decimal? Alipi { get; set; }

    public decimal? Vipi { get; set; }

    public decimal? Vfrete { get; set; }

    public decimal? Pfrete { get; set; }

    public decimal? Totalsemcredito { get; set; }

    public decimal? Alcredicms { get; set; }

    public decimal? Credicms { get; set; }

    public decimal? Alcredpis { get; set; }

    public decimal? Credpis { get; set; }

    public decimal? Alcredcofins { get; set; }

    public decimal? Credcofins { get; set; }

    public decimal? Totalcomcredito { get; set; }

    public decimal? Va { get; set; }

    public decimal? Custovenda { get; set; }

    public decimal? Vendor { get; set; }

    public decimal? Icmssaida { get; set; }

    public char? Ultimainclusao { get; set; }

    public DateTime? Datainclusao { get; set; }

    public int? Codusuario { get; set; }

    public int? Codfornecedor { get; set; }

    public decimal? Custodiversos { get; set; }

    public decimal? Bcalculoicmsst { get; set; }

    public decimal? IcmsNota { get; set; }

    public decimal? IcmsstNota { get; set; }

    public decimal? IpiNota { get; set; }

    public decimal? PisNota { get; set; }

    public decimal? CofinsNota { get; set; }

    public decimal? FreteNota { get; set; }

    public int? CodFornecedorPedido { get; set; }

    public decimal? IcmsRecuperar { get; set; }

    public decimal? StRecuperar { get; set; }

    public decimal? Vp { get; set; }

    public string? DescricaoXmlentrada { get; set; }

    public decimal QuantidadeOpTriangular { get; set; }

    public virtual TblProdutoEntra? CodentradaNavigation { get; set; }
}
