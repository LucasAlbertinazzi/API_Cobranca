using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// utilizado na composição do preço de venda ecommerce
/// </summary>
public partial class EcTblTransportadoraAliqComissaoFrete
{
    public int Id { get; set; }

    public string? Canal { get; set; }

    public decimal? AliqComissao { get; set; }

    public decimal? AliqComissaoFrete { get; set; }

    public DateTime? Data { get; set; }
}
