using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// [nao mais utilizado a partir de 25/02/2021] contém a nota atual da empresa na b2w
/// </summary>
public partial class EcTblTransportadoraSellerIndex
{
    public long Id { get; set; }

    public int? SellerIndex { get; set; }

    public DateTime? Data { get; set; }

    public int? Codusuario { get; set; }

    public int? Codloja { get; set; }
}
