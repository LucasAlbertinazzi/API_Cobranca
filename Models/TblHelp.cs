using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblHelp
{
    public decimal Id { get; set; }

    public string? Descricao { get; set; }

    public string? Caminho { get; set; }

    public DateTime? Data { get; set; }

    public string? Login { get; set; }

    public string? Formulario { get; set; }
}
