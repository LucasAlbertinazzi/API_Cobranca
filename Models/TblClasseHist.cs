using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblClasseHist
{
    public long Codigo { get; set; }

    public char? Anterior { get; set; }

    public char? Atual { get; set; }

    public DateTime? Atualizado { get; set; }

    public int? Codusuario { get; set; }

    public int? Codcliente { get; set; }

    public virtual TblCliente? CodclienteNavigation { get; set; }

    public virtual TblUsuario? CodusuarioNavigation { get; set; }
}
