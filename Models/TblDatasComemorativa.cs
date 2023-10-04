using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblDatasComemorativa
{
    public int Id { get; set; }

    public string? Evento { get; set; }

    public DateOnly? Data { get; set; }

    public string? Imagem { get; set; }

    public string? Mensagem { get; set; }

    public bool? Status { get; set; }
}
