using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblRegistro10
{
    public string? Cnpj { get; set; }

    public string? Inscestadual { get; set; }

    public string? Contribuinte { get; set; }

    public string? Municipio { get; set; }

    public string? Uf { get; set; }

    public string? Fax { get; set; }

    public char? Codarquivo { get; set; }

    public char? Codoperacao { get; set; }

    public char? Codfinalidade { get; set; }

    public int Codloja { get; set; }

    public string? Endereco { get; set; }

    public string? Bairro { get; set; }

    public string? Cep { get; set; }

    public string? CnpjLigacao { get; set; }
}
