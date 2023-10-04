using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Armazena o ID da Divisão e do Departamento do E-commerce
/// </summary>
public partial class EcTblDepartamentoDiv
{
    public int Id { get; set; }

    public int? Coddep { get; set; }

    public int? Coddiv { get; set; }

    public short? Ordenacao { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Atualizado { get; set; }

    public int? CodusuarioWeb { get; set; }

    public DateTime? AtualizadoWeb { get; set; }
}
