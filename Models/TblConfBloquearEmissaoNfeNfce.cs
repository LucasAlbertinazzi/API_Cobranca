using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblConfBloquearEmissaoNfeNfce
{
    public int Id { get; set; }

    public string Loja { get; set; } = null!;

    public int Codusuario { get; set; }

    public DateTime Data { get; set; }

    public string? Tipo { get; set; }

    public bool? Bloqueado { get; set; }
}
