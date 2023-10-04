using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSincRegraDespesa
{
    public int Id { get; set; }

    public int TipoNota { get; set; }

    public DateTime Data { get; set; }
}
