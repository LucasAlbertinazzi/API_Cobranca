using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Armazena os Endereços de Entrega Gerado na Skyhub e E-commerce
/// </summary>
public partial class EcTblPedidoEndEntrega
{
    public int IdPedido { get; set; }

    public string? Nome { get; set; }

    public string? Endereco { get; set; }

    public string? Numero { get; set; }

    public string? Complemento { get; set; }

    public string? Bairro { get; set; }

    public string? Cidade { get; set; }

    public string? Estado { get; set; }

    public string? Pais { get; set; }

    public string? Cep { get; set; }

    public virtual EcTblPedido IdPedidoNavigation { get; set; } = null!;
}
