using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Usuario que podem liberar produtos que estão bloqueados na agenda de entrega
/// </summary>
public partial class TblRomaneioAutoriza
{
    public int Codusuario { get; set; }
}
