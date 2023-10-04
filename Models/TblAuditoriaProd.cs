using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblAuditoriaProd
{
    public int Codigo { get; set; }

    public int? Lojaorigem { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Dataentrada { get; set; }

    public int? Quantidade { get; set; }

    public string? Codproduto { get; set; }

    /// <summary>
    /// A = Automatico
    /// M = Manual
    /// </summary>
    public char? Tipo { get; set; }

    public int? Idromaneio { get; set; }

    public DateTime? Dataretorno { get; set; }

    public int? Usuarioretorno { get; set; }

    public string? Obs { get; set; }

    /// <summary>
    /// 1 = verdadeiro
    /// 0 = falso
    /// </summary>
    public int? Problema { get; set; }
}
