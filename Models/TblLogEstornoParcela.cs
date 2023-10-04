using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblLogEstornoParcela
{
    public int Id { get; set; }

    public DateTime? Datahora { get; set; }

    public long? Codusuario { get; set; }

    public long? Codcliente { get; set; }

    public string? Justificativa { get; set; }
}
