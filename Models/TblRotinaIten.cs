using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblRotinaIten
{
    public int CodItem { get; set; }

    public string? Nome { get; set; }

    public string? Descricao { get; set; }

    public int? Peso { get; set; }

    public string? Link { get; set; }

    public bool? Ativo { get; set; }

    public char? Tipo { get; set; }

    public short? Ordenacao { get; set; }
}
