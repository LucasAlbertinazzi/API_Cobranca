using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: Inclusão
/// Grava os registros de baixas ou inclusões de estoque, com os respectivos motivos, quantidade baixada, estoque anterior, codproduto, local (loja) da baixa e usuário que fez a alteração. Esta tabela é gerenciada pela tela FrmProdutoBaixa, alcançada através da tela FrmManutProdutoNew, após se pressionar a tecla CTRL+&quot;F9&quot;.
/// 
/// </summary>
public partial class TblProdutoBaixa
{
    public int Codigo { get; set; }

    public string? Codproduto { get; set; }

    public int? Quantidade { get; set; }

    public int? Localbaixa { get; set; }

    public int? Estoqueante { get; set; }

    public DateTime? Data { get; set; }

    public int? Codusuario { get; set; }

    public string? Motivo { get; set; }

    public char? Tipo { get; set; }

    public virtual TblProduto? CodprodutoNavigation { get; set; }

    public virtual TblUsuario? CodusuarioNavigation { get; set; }
}
