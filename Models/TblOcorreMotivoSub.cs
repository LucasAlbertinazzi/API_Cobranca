using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblOcorreMotivoSub
{
    public int Codigo { get; set; }

    public int? Codocorrencia { get; set; }

    public int? Codloja { get; set; }

    public bool? Senha1 { get; set; }

    public bool? Senha2 { get; set; }

    public bool? Senha3 { get; set; }

    public bool? Bloqueio { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Data { get; set; }

    public char? Ativo { get; set; }
}
