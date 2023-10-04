using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSubContagem
{
    public int Codigo { get; set; }

    public int? Codcontagem { get; set; }

    public short? Estoqueinicio { get; set; }

    public short? Assistenciainicio { get; set; }

    public short? Entregainicio { get; set; }

    public string? Codproduto { get; set; }

    public short? Estoquefim { get; set; }

    public short? Assistenciafim { get; set; }

    public short? Entregafim { get; set; }

    public decimal? Custo { get; set; }

    public char? Fechaparcial { get; set; }
}
