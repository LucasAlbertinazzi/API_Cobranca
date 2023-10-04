using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: Produtos
/// Tabela utilizada na tela FrmStatusEstoque. [Registros inseridos automaticamente pelo banco de dados quando tem movimentação de estoque]
/// Abastecido pelos triggers Apos_Update e Apos_Insert na tbl_produto_quant
/// 
/// </summary>
public partial class TblProdMov
{
    public int Codigo { get; set; }

    public string? Codproduto { get; set; }

    public string? Coddivisao { get; set; }

    public string? Coddepartamento { get; set; }

    public int? Saldo { get; set; }

    public DateOnly? Data { get; set; }

    public TimeOnly? Hora { get; set; }

    public decimal? Custo { get; set; }

    public decimal? CustoSemCredito { get; set; }
}
