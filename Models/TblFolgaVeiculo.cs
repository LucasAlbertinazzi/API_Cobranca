using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblFolgaVeiculo
{
    public int Codigo { get; set; }

    public int? Codloja { get; set; }

    public string? Diasemana { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Atualizado { get; set; }

    public char? Ativo { get; set; }
}
