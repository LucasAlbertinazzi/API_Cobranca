using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblRegistro11
{
    public string? Logradouro { get; set; }

    public int? Numero { get; set; }

    public string? Complemento { get; set; }

    public string? Bairro { get; set; }

    public int? Cep { get; set; }

    public string? Nomecontato { get; set; }

    public string? Fone { get; set; }

    public int Codloja { get; set; }
}
