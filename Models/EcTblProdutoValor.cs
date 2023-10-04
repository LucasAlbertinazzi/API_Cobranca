using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Valor dos Produtos  e  em quantas parcelas na Skyhub
/// </summary>
public partial class EcTblProdutoValor
{
    public long Codigo { get; set; }

    public long? Codproduto { get; set; }

    public DateTime? Datainicio { get; set; }

    public decimal? ValorDe { get; set; }

    public decimal? ValorPor { get; set; }

    public string? ValorEm { get; set; }

    public decimal? ValorAvista { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Atualizado { get; set; }

    public int? CodusuarioWeb { get; set; }

    public DateTime? AtualizadoWeb { get; set; }

    public int IdFrete { get; set; }
}
