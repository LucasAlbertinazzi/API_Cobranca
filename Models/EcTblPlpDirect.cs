using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class EcTblPlpDirect
{
    public int Id { get; set; }

    public string Codpedido { get; set; } = null!;

    public string Codigoawb { get; set; } = null!;

    public int Volume { get; set; }

    public string Dtprometida { get; set; } = null!;

    public string Rota { get; set; } = null!;

    public string Megarota { get; set; } = null!;

    public string Plp { get; set; } = null!;

    public DateTime Data { get; set; }
}
