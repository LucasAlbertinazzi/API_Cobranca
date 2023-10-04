using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: TI
/// Contém o local dos ativos. Os locais agrupam-se em determinadas áreas descritas nesta tabela.
/// 
/// </summary>
public partial class TblAtivoLocal
{
    public int Codigo { get; set; }

    public string? Descricao { get; set; }

    public virtual ICollection<TblAtivo> TblAtivos { get; set; } = new List<TblAtivo>();
}
