using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblPesquisa
{
    public int Codigo { get; set; }

    public string? Pesquisa { get; set; }

    public DateTime? Data { get; set; }

    public char? Tipo { get; set; }
}
