using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblPedidoGarantium
{
    public string Codpedido { get; set; } = null!;

    public long? Codcliente { get; set; }

    public string? Segurado { get; set; }

    public string? Cpf { get; set; }

    public string? Fone { get; set; }

    public string? Endereco { get; set; }

    public string? Numero { get; set; }

    public string? Bairro { get; set; }

    public string? Complemento { get; set; }

    public string? Cidade { get; set; }

    public string? Cep { get; set; }

    public string? Uf { get; set; }

    public DateTime? EmissaoSeguro { get; set; }

    public DateTime? Datacompra { get; set; }

    public short? Codloja { get; set; }

    public string? Email { get; set; }

    public string? Userimp { get; set; }

    public DateTime? Dataimp { get; set; }
}
