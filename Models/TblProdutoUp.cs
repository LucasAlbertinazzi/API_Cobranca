using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblProdutoUp
{
    public int Codigo { get; set; }

    public string? Codproduto { get; set; }

    public double? Custo { get; set; }

    public double? Markup { get; set; }

    public double? Venda { get; set; }

    public char? Promocao { get; set; }

    public char? Bfora { get; set; }

    public char? Juroespec { get; set; }

    public int? Tvista { get; set; }

    public decimal? Cartazvista { get; set; }

    public int? Tprazo { get; set; }

    public int? Parcprazo { get; set; }

    public decimal? Cartazprazo { get; set; }

    public char? Jornal { get; set; }

    public char? Comprar { get; set; }

    public int? Minimo { get; set; }

    public DateTime? Data { get; set; }

    public string? Usuario { get; set; }

    public char? Ativo { get; set; }

    public int? Grupo { get; set; }

    public string? Codprodgarantia { get; set; }

    public short? Garantia { get; set; }

    public decimal? MarkupNormal { get; set; }

    public decimal? Margem { get; set; }
}
