using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblForneassist
{
    public int Codfornecedor { get; set; }

    public string? Razaosocial { get; set; }

    public string? Nomefantasia { get; set; }

    public string? Endereco { get; set; }

    public string? Bairro { get; set; }

    public string? Cep { get; set; }

    public string? Municipio { get; set; }

    public string? Contato { get; set; }

    public string? Cnpj { get; set; }

    public string? Inscest { get; set; }

    public string? Fone { get; set; }

    public string? Autorizada { get; set; }

    public string? Obs { get; set; }

    public string? Uf { get; set; }

    public string? Pais { get; set; }

    public string? Fax { get; set; }

    public string? Inscmunic { get; set; }

    public DateTime? Datacadastro { get; set; }

    public DateTime? Atualizado { get; set; }

    public decimal? Codusuario { get; set; }

    public bool? Ativo { get; set; }
}
