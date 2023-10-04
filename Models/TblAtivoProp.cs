using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: TI
/// Lista de tipos de ativos correlacionadas com propriedades. Ex.: na tbl_ativo_tipo temos o codigo 1, MONITOR, na tbl_ativo_prop temos o tipo de tela (LCD, LED) e tamanho de tela.
/// 
/// </summary>
public partial class TblAtivoProp
{
    public int Codigo { get; set; }

    public short? Codtipo { get; set; }

    public string? Descricao { get; set; }

    public virtual ICollection<TblAtivoPropSub> TblAtivoPropSubs { get; set; } = new List<TblAtivoPropSub>();
}
