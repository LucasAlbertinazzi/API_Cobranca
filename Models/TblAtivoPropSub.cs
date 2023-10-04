using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: TI
/// Nesta tabela há as subdivisões da tbl_ativo_prop, como tbl_ativo_prop.codigo = 1, temos aqui na tbl_ativo_prop_sub.codigo = 1 os tipos LED, TUBO e LCD.
/// 
/// </summary>
public partial class TblAtivoPropSub
{
    public int Codigo { get; set; }

    public int? Codativo { get; set; }

    public int? Codprop { get; set; }

    public string? Descricao { get; set; }

    public virtual TblAtivo? CodativoNavigation { get; set; }

    public virtual TblAtivoProp? CodpropNavigation { get; set; }
}
