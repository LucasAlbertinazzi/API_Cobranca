using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblMotivoNaocarregado
{
    public int? Idromaneio { get; set; }

    public int? Motivo { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Data { get; set; }

    public int Id { get; set; }
}
