using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Log de alterações no estoque skyhub enviado pelo nosso ERP.
/// 
/// Junior 29/04/2020
/// </summary>
public partial class EcTblEstoqueSkyhubLog
{
    public int Codigo { get; set; }

    public string? Codproduto { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Data { get; set; }

    public string? Descricao { get; set; }

    public bool? Sucesso { get; set; }
}
