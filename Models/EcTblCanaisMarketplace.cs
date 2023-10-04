using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class EcTblCanaisMarketplace
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? Cnpj { get; set; }

    public DateTime? Data { get; set; }

    public string? RazaoSocial { get; set; }

    public string? Tag { get; set; }
}
