using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Armazena os Departamentos  do Site E-commerce
/// </summary>
public partial class EcTblDepartamento
{
    public int Codigo { get; set; }

    public string? Departamento { get; set; }

    public short? Codusuario { get; set; }

    public DateTime? Atualizado { get; set; }

    public int? CodusuarioWeb { get; set; }

    public DateTime? AtualizadoWeb { get; set; }

    public string? TagTitle { get; set; }

    public string? TagDescription { get; set; }
}
