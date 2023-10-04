using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblClienteJuridica
{
    public int Codcliente { get; set; }

    public string? Nome { get; set; }

    public string? Cpf { get; set; }

    public string? Rg { get; set; }

    public DateOnly? Nascimento { get; set; }

    public string? Pai { get; set; }

    public string? Mae { get; set; }

    public string? Estadocivil { get; set; }

    public string? Naturalidade { get; set; }

    public string? Endereco { get; set; }

    public string? Numero { get; set; }

    public string? Complemento { get; set; }

    public int? Codbairro { get; set; }

    public int? Codcidade { get; set; }

    public string? Cep { get; set; }

    public string? Uf { get; set; }

    public string? Tiporesid { get; set; }

    public DateOnly? Residedesde { get; set; }

    public string? Celular { get; set; }

    public string? Fone { get; set; }

    public string? Email { get; set; }
}
