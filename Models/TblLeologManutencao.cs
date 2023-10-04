using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblLeologManutencao
{
    public int Id { get; set; }

    public int Codusuario { get; set; }

    public DateTime Data { get; set; }

    public DateTime Inicio { get; set; }

    public DateTime Fim { get; set; }
}
