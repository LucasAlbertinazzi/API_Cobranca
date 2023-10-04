using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: TI
/// Tabela que contém o texto da frmAdesivo, acessado a partir da tecla de atalho &quot;A&quot; na tela inicial do sistema.
/// 
/// </summary>
public partial class TblAdesivo
{
    public int Codigo { get; set; }

    public int? Codusuario { get; set; }

    public string? Anotacoes { get; set; }

    public string? Login { get; set; }
}
