using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblProjeto
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descricao { get; set; }

    public int Classificacao { get; set; }

    public DateTime? Data { get; set; }
}
