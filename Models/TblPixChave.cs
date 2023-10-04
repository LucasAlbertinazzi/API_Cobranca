using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblPixChave
{
    public string Chave { get; set; } = null!;

    public int Codloja { get; set; }

    public string Secret { get; set; } = null!;
}
