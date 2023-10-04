using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSitefBaixa
{
    public int Id { get; set; }

    public long Nsu { get; set; }

    public DateOnly Data { get; set; }

    public decimal Bruto { get; set; }

    public decimal Liquido { get; set; }

    public int Caixa { get; set; }
}
