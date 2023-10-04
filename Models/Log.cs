using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class Log
{
    public int Id { get; set; }

    public string Tabela { get; set; } = null!;

    public string Acao { get; set; } = null!;

    public string? DadosAntigos { get; set; }

    public string? DadosNovos { get; set; }

    public DateTime DataHora { get; set; }

    public string Ip { get; set; } = null!;
}
