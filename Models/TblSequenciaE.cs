using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSequenciaE
{
    public string? Codigo { get; set; }

    public string? Arquivo { get; set; }

    public int? Sequencia { get; set; }

    public DateTime? Dataenvio { get; set; }

    public DateTime? Atualizado { get; set; }

    public string? Status { get; set; }

    public bool? Erro { get; set; }

    public long Id { get; set; }
}
