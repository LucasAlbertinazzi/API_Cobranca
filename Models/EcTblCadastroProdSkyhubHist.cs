using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class EcTblCadastroProdSkyhubHist
{
    public int Id { get; set; }

    public long? Codusuario { get; set; }

    public DateTime Data { get; set; }

    public int? QtdSkyhub { get; set; }

    public string? Sku { get; set; }

    public string? Ean { get; set; }

    public string? NomeProduto { get; set; }

    public string? Cor { get; set; }

    public string? Voltagem { get; set; }

    public string? DescEc { get; set; }

    public decimal? PrecoDe { get; set; }

    public decimal? PrecoPor { get; set; }

    public string? Status { get; set; }

    public int? Crossdocking { get; set; }

    public string? Tamanho { get; set; }

    public string? Marca { get; set; }

    public string? DescricaoItem { get; set; }

    public string? ProcedenciaItem { get; set; }

    public string? Departamento { get; set; }

    public string? Setor { get; set; }

    public string? Familia { get; set; }

    public string? SubFamilia { get; set; }

    public string? IdItemPai { get; set; }

    public string? NomeItemPai { get; set; }

    public decimal? Peso { get; set; }

    public decimal? Altura { get; set; }

    public decimal? Largura { get; set; }

    public decimal? Profundidade { get; set; }

    public string? ImagemItem1 { get; set; }

    public string? ImagemItem2 { get; set; }

    public string? ImagemItem3 { get; set; }

    public string? ImagemItem4 { get; set; }

    public string? ImagemItem5 { get; set; }

    public string? ImagemItem6 { get; set; }

    public string? ImagemItem7 { get; set; }

    public string? ImagemItem8 { get; set; }

    public string? ImagemItem9 { get; set; }

    public string? ImagemItem10 { get; set; }

    public string? ImagemItem11 { get; set; }

    public string? ImagemItem12 { get; set; }
}
