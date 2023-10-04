using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: TI
/// Contém uma lista de marcas fabricantes dos ativos, como LG, Intel, Cisco, HP, etc.
/// 
/// </summary>
public partial class TblAtivoMarca
{
    public int Codigo { get; set; }

    public string? Descricao { get; set; }

    public virtual ICollection<TblAtivo> TblAtivos { get; set; } = new List<TblAtivo>();
}
