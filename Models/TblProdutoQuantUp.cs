using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: INCLUSÃO
/// Não existem referências a esta tabela no projeto Sist_Controle. Novos registros inseridos pelo trigger no UPDATE ou INSERT na tbl_produto_quant
/// 
/// </summary>
public partial class TblProdutoQuantUp
{
    public string? Codproduto { get; set; }

    public int? QuantOld { get; set; }

    public int? QuantNew { get; set; }

    public int Codigo { get; set; }

    public DateTime? Data { get; set; }

    public string? Usuario { get; set; }

    public int? Codloja { get; set; }
}
