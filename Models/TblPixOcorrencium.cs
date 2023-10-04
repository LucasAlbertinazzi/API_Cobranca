using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblPixOcorrencium
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Versao { get; set; }

    public string? Mensagem { get; set; }

    public string? Ocorrencia { get; set; }

    public string Usuario { get; set; } = null!;

    public string Caminho { get; set; } = null!;

    public DateTime Data { get; set; }
}
