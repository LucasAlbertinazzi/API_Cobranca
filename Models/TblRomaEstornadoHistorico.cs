using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblRomaEstornadoHistorico
{
    public int Codigo { get; set; }

    public DateTime? Data { get; set; }

    public long? Codromaneio { get; set; }

    public long? Codusuario { get; set; }
}
