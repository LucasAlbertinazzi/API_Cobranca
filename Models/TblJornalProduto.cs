using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblJornalProduto
{
    public int Codigo { get; set; }

    public int? Codjornal { get; set; }

    public string? Codproduto { get; set; }

    public int? Grupo { get; set; }

    public string? Descricaojornal { get; set; }

    public int? Codprodutojornal { get; set; }

    public int? Agrupamento { get; set; }

    public decimal? Vendavista { get; set; }

    public decimal? Margemantiga { get; set; }

    /// <summary>
    /// taxa e juro especial
    /// </summary>
    public string? Taxaejuro { get; set; }

    public int? Quantinicio { get; set; }

    public int? Quantfinal { get; set; }

    public int? Chegou { get; set; }

    public decimal? Margemjornal { get; set; }

    /// <summary>
    /// quantidade a chegar usado resultado parcial
    /// </summary>
    public decimal? Chegar { get; set; }

    public short? TaxaDoDepartamento { get; set; }

    public decimal? MargemLucroJornal { get; set; }

    /// <summary>
    /// coluna para deixar gravado o usuário que inseriu o produto no jornal
    /// </summary>
    public string? Usuario { get; set; }

    public DateTime? Datainclusao { get; set; }

    public bool? ProdutoSeparado { get; set; }

    public bool? Produtodestaque { get; set; }

    /// <summary>
    /// usuario que editou o preço do jornal
    /// </summary>
    public string? UsuarioEditou { get; set; }

    public DateTime? Dataedicao { get; set; }
}
