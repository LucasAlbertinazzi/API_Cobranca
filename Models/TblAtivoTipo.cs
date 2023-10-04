using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: TI
/// São os tipos de ativo, exemplo: Tipo 1= MONITOR, Tipo 2 = COMPUTADOR, Tipo 3 = ROUTER...
/// 
/// </summary>
public partial class TblAtivoTipo
{
    public int Codigo { get; set; }

    public string? Descricao { get; set; }

    public int Coddep { get; set; }

    public virtual ICollection<TblAtivo> TblAtivos { get; set; } = new List<TblAtivo>();
}
