using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: TI/FINANCEIRO
/// Departamentos da tbl_ativo
/// </summary>
public partial class TblAtivoDepartamento
{
    public int Codigo { get; set; }

    public string? Descricao { get; set; }

    public virtual ICollection<TblAtivo> TblAtivos { get; set; } = new List<TblAtivo>();
}
