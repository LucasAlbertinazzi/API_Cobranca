using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Transportadoras Cadastradas na Intelepost
/// </summary>
public partial class EcTblTransportadora
{
    public int Id { get; set; }

    public string? NomeEcommerce { get; set; }

    public string? Rsocial { get; set; }

    public string? Endereco { get; set; }

    public string? Cep { get; set; }

    public string? Cidade { get; set; }

    public string? Uf { get; set; }

    public string? Cnpj { get; set; }

    public string? Ie { get; set; }

    public string? Fone { get; set; }

    public string? Bairro { get; set; }

    public string? Transportadora { get; set; }

    public string? Metodo { get; set; }

    public string? Url { get; set; }

    public string? IdServicoCorreios { get; set; }

    public string? CodigoServicoPostagem { get; set; }

    public bool? Ativo { get; set; }

    public DateTime? DataCadastro { get; set; }

    public string? Login { get; set; }

    public string? EmailEnvioNfexml { get; set; }
}
