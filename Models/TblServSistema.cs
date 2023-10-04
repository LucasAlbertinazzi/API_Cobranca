using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// serviços a serem executados no sistema
/// 
/// </summary>
public partial class TblServSistema
{
    public int Codigo { get; set; }

    public string? Titulo { get; set; }

    public int? Prioridade { get; set; }

    public string? Servico { get; set; }

    public string? Obspronto { get; set; }

    public string? Obsteste { get; set; }

    public char? Pronto { get; set; }

    public char? Testado { get; set; }

    public DateTime? Datasolicita { get; set; }

    public int? Usuario { get; set; }

    public DateTime? Datapronto { get; set; }

    public int? Userexecutado { get; set; }

    public DateTime? Datateste { get; set; }

    public int? Userteste { get; set; }

    public DateOnly? Previsao { get; set; }

    public char? Finalizar { get; set; }

    /// <summary>
    /// 0 - JOAO
    /// 1 - GUILHERME
    /// </summary>
    public int? Execucao { get; set; }

    public int? Novo { get; set; }
}
