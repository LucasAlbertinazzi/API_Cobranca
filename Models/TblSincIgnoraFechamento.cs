using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSincIgnoraFechamento
{
    public int Id { get; set; }

    public int Codusuario { get; set; }

    public DateTime Data { get; set; }

    public string ChaveNf { get; set; } = null!;

    public DateTime DataRecepcao { get; set; }

    public DateTime DataFechamento { get; set; }
}
