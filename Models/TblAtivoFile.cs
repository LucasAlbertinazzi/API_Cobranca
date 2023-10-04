using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// INATIVA
/// Contém apenas 9 registros com a descrição de arquivos de configuração.
/// 
/// </summary>
public partial class TblAtivoFile
{
    public int Codigo { get; set; }

    public int? Codativo { get; set; }

    public string? Descricao { get; set; }

    public string? Extensionfile { get; set; }

    public DateTime? Data { get; set; }
}
