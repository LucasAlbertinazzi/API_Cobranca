using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblHistoricoreneg
{
    public int Codigo { get; set; }

    public int? Codcliente { get; set; }

    public DateTime? Data { get; set; }

    public int? Codusuario { get; set; }

    public virtual TblCliente? CodclienteNavigation { get; set; }

    public virtual TblUsuario? CodusuarioNavigation { get; set; }
}
