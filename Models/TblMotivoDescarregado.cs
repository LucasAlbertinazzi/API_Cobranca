using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblMotivoDescarregado
{
    public int Codigo { get; set; }

    public int? Idromaneio { get; set; }

    public DateTime? Data { get; set; }

    public int? Codusuario { get; set; }

    public string? Motivo { get; set; }
}
