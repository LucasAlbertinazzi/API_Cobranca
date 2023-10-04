using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblOcorrencium
{
    /// <summary>
    /// codigo da ocorrencia
    /// </summary>
    public long Codigo { get; set; }

    public int? Codprepedido { get; set; }

    /// <summary>
    /// Detalhe da ocorrencia
    /// </summary>
    public string? Detalhe { get; set; }

    public int? Codocorrencia { get; set; }

    public virtual TblPrePedido? CodprepedidoNavigation { get; set; }
}
