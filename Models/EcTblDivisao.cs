using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Armazena a Divisão do E-commerce
/// </summary>
public partial class EcTblDivisao
{
    public int Codigo { get; set; }

    public string? Divisao { get; set; }

    public short? Ordenacao { get; set; }

    public short? Codusuario { get; set; }

    public DateTime? Atualizado { get; set; }

    public short? CodusuarioWeb { get; set; }

    public DateTime? AtualizadoWeb { get; set; }

    public string? TagTitle { get; set; }

    public string? TagDescription { get; set; }
}
