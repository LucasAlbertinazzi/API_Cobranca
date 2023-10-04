using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Armazena as Medidas dos Produtos Gerado na Skyhub e E-commerce
/// </summary>
public partial class EcTblProdutoMedida
{
    public int Id { get; set; }

    public string? Codproduto { get; set; }

    public short? Vol { get; set; }

    public decimal? Alt { get; set; }

    public decimal? Lar { get; set; }

    public decimal? Pro { get; set; }

    public decimal? Mc { get; set; }

    public decimal? Peso { get; set; }

    public bool? Total { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Atualizado { get; set; }

    public int? CodusuarioWeb { get; set; }

    public DateTime? AtualizadoWeb { get; set; }

    public decimal? PesoCubado { get; set; }
}
