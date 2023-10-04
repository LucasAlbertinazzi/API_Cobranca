using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblUsuarioCaixa
{
    public long Codigo { get; set; }

    public int Codusuario { get; set; }

    public long Codcaixa { get; set; }

    public virtual TblUsuario CodusuarioNavigation { get; set; } = null!;
}
