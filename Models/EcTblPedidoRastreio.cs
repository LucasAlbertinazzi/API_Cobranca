using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Armazena o Status do Rastreio dos Produtos na Skyhub e no E-commerce
/// </summary>
public partial class EcTblPedidoRastreio
{
    public int Id { get; set; }

    public string? Codpedido { get; set; }

    public string? CodRastreio { get; set; }

    public DateTime? DataConsulta { get; set; }

    public int? UsuarioConsulta { get; set; }

    public short? Status { get; set; }

    public string? Tipo { get; set; }

    public string? Descricao { get; set; }

    public string? Cidade { get; set; }

    public DateOnly? DataCorreio { get; set; }

    public TimeOnly? HoraCorreio { get; set; }

    public string? Codigo { get; set; }
}
