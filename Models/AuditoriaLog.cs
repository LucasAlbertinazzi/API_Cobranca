using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class AuditoriaLog
{
    public int Id { get; set; }

    public DateTime? DataHora { get; set; }

    public string? Tabela { get; set; }

    public string? Acao { get; set; }

    public string? DadosAntigos { get; set; }

    public string? DadosNovos { get; set; }

    public string? Ip { get; set; }
}
