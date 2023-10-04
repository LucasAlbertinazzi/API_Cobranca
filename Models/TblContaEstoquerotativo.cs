using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblContaEstoquerotativo
{
    public int Codigo { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Datainicio { get; set; }

    public DateTime? Datafim { get; set; }

    public DateOnly? Datamovimento { get; set; }

    public int? Codusuariofechou { get; set; }

    public int? Codloja { get; set; }

    public int? Senha { get; set; }

    public string? Obssenha { get; set; }

    public DateTime? Datasenha { get; set; }

    public DateOnly? Prazo { get; set; }
}
