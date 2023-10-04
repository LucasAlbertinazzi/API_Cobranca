using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Tabela que gera DataGrid de Parcelas
/// </summary>
public partial class TblParcela
{
    public decimal? Valor { get; set; }

    public DateOnly Vencimento { get; set; }

    public long? Prazo { get; set; }
}
