using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// tabela com variáveis importantes utilizadas no WpfSugestaoCompras
/// </summary>
public partial class TblSugestaoCompra
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public decimal? Valor { get; set; }

    public string? Justificativa { get; set; }
}
