using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblRenegRemovidum
{
    public int Id { get; set; }

    public int? Codreneg { get; set; }

    public int? Codcliente { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? DataRenegCriada { get; set; }

    public DateTime? DataRenegRemovida { get; set; }

    public string? Obs { get; set; }
}
