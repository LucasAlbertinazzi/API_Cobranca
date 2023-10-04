using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: INCLUSÃO, PRODUTOS
/// Contém os registros de inclusões de produtos no estoque, com os respectivos valores de custo, impostos, frete, VA, quantidade, codrecebimento, data em que entrou no estoque, se foi incluso, se é a última inclusão ou não, usuário que incluiu.
/// --codrecebimento da tbl_produto_entra é codentrada da tbl_produto_entra_sub
/// 
/// </summary>
public partial class TblProdutoEntra
{
    public int Id { get; set; }

    public int? Codrecebimento { get; set; }

    public string? Codproduto { get; set; }

    public short? Quantidade { get; set; }

    public decimal? Vunit { get; set; }

    public decimal? Bcalculoicms { get; set; }

    public decimal? Vicms { get; set; }

    public decimal? Vst { get; set; }

    public decimal? Vipi { get; set; }

    public decimal? Vfrete { get; set; }

    public decimal? Totalsemcredito { get; set; }

    public decimal? Credicms { get; set; }

    public decimal? Credpis { get; set; }

    public decimal? Credcofins { get; set; }

    public decimal? Totalcomcredito { get; set; }

    public decimal? Va { get; set; }

    public decimal? Custovenda { get; set; }

    public decimal? Vendor { get; set; }

    public char? Ultimainclusao { get; set; }

    public DateTime? Datainclusao { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Entrounoestoque { get; set; }

    public char? Incluso { get; set; }

    public decimal? Custodiversos { get; set; }

    public decimal? Bcalculoicmsst { get; set; }

    public decimal? Vp { get; set; }

    public string? VpTipo { get; set; }

    public decimal? OperLogistico { get; set; }

    public decimal? FreteTransf22 { get; set; }

    public virtual ICollection<TblProdutoEntraSub> TblProdutoEntraSubs { get; set; } = new List<TblProdutoEntraSub>();
}
