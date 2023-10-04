using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblOcorreSenha
{
    public int Codigo { get; set; }

    public int? Codusuario { get; set; }

    public int? Nivelsenha { get; set; }

    public virtual TblUsuario? CodusuarioNavigation { get; set; }
}
