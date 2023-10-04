using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblCaixa
{
    public long Codigo { get; set; }

    /// <summary>
    /// Letra do Caixa
    /// </summary>
    public string Letracaixa { get; set; } = null!;

    public int Codloja { get; set; }

    public string? Descricao { get; set; }

    public short? Indice { get; set; }

    public int? CodContaDominio { get; set; }

    public virtual TblLoja CodlojaNavigation { get; set; } = null!;
}
