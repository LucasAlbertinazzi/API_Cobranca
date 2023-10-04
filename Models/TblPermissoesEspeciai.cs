using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// nesta tabela encontram-se permissões especiais que fogem do padrão negar, ler e gravar.
/// </summary>
public partial class TblPermissoesEspeciai
{
    public int Codigo { get; set; }

    public string? Descricao { get; set; }

    public string? Usuarios { get; set; }

    public string? Frm { get; set; }

    public string? Departamentos { get; set; }
}
