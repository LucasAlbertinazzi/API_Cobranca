using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblDepartamentoUsuario
{
    public int Id { get; set; }

    public string? NomeDep { get; set; }

    public TimeOnly Data { get; set; }
}
