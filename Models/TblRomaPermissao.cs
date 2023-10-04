using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblRomaPermissao
{
    /// <summary>
    /// Codigo do usuario
    /// </summary>
    public int Codusuario { get; set; }

    public int? Codrota { get; set; }
}
