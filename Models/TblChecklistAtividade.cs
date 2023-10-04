using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblChecklistAtividade
{
    public int? IdUser { get; set; }

    public int? IdUserResponsavel { get; set; }

    public string? Atividade { get; set; }

    public DateTime? Data { get; set; }

    public string? Obs { get; set; }

    public int Id { get; set; }

    public bool? Ativa { get; set; }
}
