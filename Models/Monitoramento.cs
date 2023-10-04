using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class Monitoramento
{
    public int Id { get; set; }

    public string Tabela { get; set; } = null!;

    public string Operacao { get; set; } = null!;

    public DateTime DataHora { get; set; }

    public string? Informacoes { get; set; }
}
