using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: TI
/// Esta tabela relaciona o código do ativo com um código de nota.
/// 
/// </summary>
public partial class TblAtivoNotafiscal
{
    public int Codativo { get; set; }

    public int Codnota { get; set; }
}
