using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Contém o XML que foram gerados os Objetos da PLP dos Corrêios
/// </summary>
public partial class EcTblCorreioPlp
{
    public string Codpedido { get; set; } = null!;

    public string Codpostagem { get; set; } = null!;

    public string? PlpXml { get; set; }

    public int? CodFechaPlp { get; set; }

    public DateTime? DataPlp { get; set; }

    public string? CodpostagemSemDigito { get; set; }

    public int CodigoPlp { get; set; }

    public DateTime? Data { get; set; }

    public bool? Seguro { get; set; }

    public decimal? VSeguro { get; set; }

    public string? Status { get; set; }

    public int? Codusuario { get; set; }
}
