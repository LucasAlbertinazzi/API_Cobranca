using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Quando uma célula do dgParcelas da tela FrmAgendaFinanceiroParc é editada, um novo registro é inserido nesta tabela. [Previsões de caixa por divisão de gastos]
/// 
/// </summary>
public partial class TblPrevisaoCaixaDet
{
    public int Codigo { get; set; }

    public DateOnly? Data { get; set; }

    public short? Subdivisao { get; set; }

    public short? Filtro { get; set; }

    public decimal? Valor { get; set; }
}
