using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblInformacao
{
    public int Codinformacao { get; set; }

    public int? Codcliente { get; set; }

    public string? Tipo { get; set; }

    public string? Referencia { get; set; }

    public string? Informante { get; set; }

    public string? Posicao { get; set; }

    public string? Foneinfo { get; set; }

    public DateTime? Dataconsulta { get; set; }

    public int? Codusuario { get; set; }

    public virtual TblUsuario? CodusuarioNavigation { get; set; }
}
