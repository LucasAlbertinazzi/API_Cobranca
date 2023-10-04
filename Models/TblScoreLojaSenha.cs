using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblScoreLojaSenha
{
    public int Codigo { get; set; }

    public int? Codusuario { get; set; }

    public decimal? Senha { get; set; }

    public int? Codloja { get; set; }

    public int? Codfuncao { get; set; }

    public DateOnly? Data { get; set; }
}
