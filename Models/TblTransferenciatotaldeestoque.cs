using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblTransferenciatotaldeestoque
{
    public int Id { get; set; }

    public string? Codproduto { get; set; }

    public string? Observacao { get; set; }

    public int? Idnfe { get; set; }

    public DateTime? Data { get; set; }

    public int? CodTransferencia { get; set; }

    public int? Numnota { get; set; }

    public int? Codusuario { get; set; }
}
