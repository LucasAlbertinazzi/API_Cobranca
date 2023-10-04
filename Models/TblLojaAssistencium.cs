using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblLojaAssistencium
{
    public int? Codusuario { get; set; }

    public string? Loja { get; set; }

    public DateOnly? Data { get; set; }

    public int Id { get; set; }
}
