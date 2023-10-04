using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblCadastroramai
{
    public int Id { get; set; }

    public string Loja { get; set; } = null!;

    public string Departamento { get; set; } = null!;

    public string? Nome { get; set; }

    public int? Ramal { get; set; }

    public string? Email { get; set; }

    public DateTime? Data { get; set; }

    public string? Usuario { get; set; }
}
