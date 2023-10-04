using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblMensagemGrupo
{
    public int Codigo { get; set; }

    public string? Descricao { get; set; }

    public string? Usuarios { get; set; }

    public int? Msn { get; set; }

    public int? Loja { get; set; }
}
