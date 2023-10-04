using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSincFecha
{
    public int Id { get; set; }

    public int Emitente { get; set; }

    public DateTime DataFechamento { get; set; }

    public DateTime Data { get; set; }
}
