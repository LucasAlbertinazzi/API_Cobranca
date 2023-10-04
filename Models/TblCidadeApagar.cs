using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblCidadeApagar
{
    public long Codcidade { get; set; }

    public string? Cidade { get; set; }

    /// <summary>
    /// Codigo da rota do romaneio a qual pertence a cidade.
    /// </summary>
    public long? Codrota { get; set; }

    public string? Usuario { get; set; }
}
