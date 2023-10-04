using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Armazena os Clientes Gerado na Skyhub e E-commerce
/// </summary>
public partial class EcTblPedidoCliente
{
    public int IdPedido { get; set; }

    public string? Nome { get; set; }

    public string? Email { get; set; }

    public DateOnly? Nascimento { get; set; }

    public string? Documento { get; set; }

    public string? Genero { get; set; }

    public string[]? Fone { get; set; }
}
