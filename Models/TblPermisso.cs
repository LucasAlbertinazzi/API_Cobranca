using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblPermisso
{
    public long Codigo { get; set; }

    public int? Codusuario { get; set; }

    public bool? Ler { get; set; }

    public bool? Gravar { get; set; }

    public bool? Negar { get; set; }

    public long? Codformulario { get; set; }

    public string? Usuario { get; set; }

    public DateTime? Data { get; set; }

    public bool? Especial { get; set; }

    public virtual TblFormulario? CodformularioNavigation { get; set; }

    public virtual TblUsuario? CodusuarioNavigation { get; set; }
}
