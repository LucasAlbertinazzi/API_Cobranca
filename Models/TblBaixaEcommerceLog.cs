using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblBaixaEcommerceLog
{
    public int Id { get; set; }

    public DateTime? Data { get; set; }

    public int? Usuario { get; set; }

    public string? Json { get; set; }
}
