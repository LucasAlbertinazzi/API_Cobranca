using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblExtratoBancarioConta
{
    public int IdBanco { get; set; }

    public string Conta { get; set; } = null!;

    public string? Descricao { get; set; }

    public int Id { get; set; }
}
