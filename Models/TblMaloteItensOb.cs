using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblMaloteItensOb
{
    public int Id { get; set; }

    public int Iditem { get; set; }

    public string? Obsitem { get; set; }

    public DateTime? Data { get; set; }
}
