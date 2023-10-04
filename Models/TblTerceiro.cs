using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblTerceiro
{
    public int Codigo { get; set; }

    public string? Nome { get; set; }

    public string? Cpf { get; set; }

    public int? Codcliente { get; set; }

    /// <summary>
    /// Grau de parentesco do cliente
    /// </summary>
    public string? Parentesco { get; set; }

    public string? Rg { get; set; }

    public virtual TblCliente? CodclienteNavigation { get; set; }
}
