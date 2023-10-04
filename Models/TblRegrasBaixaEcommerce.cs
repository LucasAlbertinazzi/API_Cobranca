using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblRegrasBaixaEcommerce
{
    public int Id { get; set; }

    public string? Marketplace { get; set; }

    public string? Regras { get; set; }

    public bool? Status { get; set; }

    public string? Criadopor { get; set; }

    public DateTime? Data { get; set; }
}
