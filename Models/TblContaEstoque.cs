using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblContaEstoque
{
    public int Codigo { get; set; }

    public string? Loja { get; set; }

    public string? Divisao { get; set; }

    public string? Departamento { get; set; }

    public DateTime? Datainicio { get; set; }

    public DateTime? Datafim { get; set; }

    public int? Codusuario { get; set; }

    public int? Codloja { get; set; }

    public string? Fechadapor { get; set; }

    public char? Fechada { get; set; }
}
