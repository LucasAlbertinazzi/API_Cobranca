using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblMenuSistemaNew
{
    public int Codigo { get; set; }

    public string? Menu { get; set; }

    public string? Submenu { get; set; }

    public string? Item { get; set; }

    public string? Abrir { get; set; }

    public string? Abrirsubmenu { get; set; }

    public short? Index { get; set; }
}
