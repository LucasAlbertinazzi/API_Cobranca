using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Histórico de Atualização dos Produtos na Skyhub e E-commerce
/// </summary>
public partial class EcTblProdutoDescHist
{
    public int? Codproduto { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Atualizado { get; set; }

    public int? CodusuarioWeb { get; set; }

    public DateTime? AtualizadoWeb { get; set; }
}
