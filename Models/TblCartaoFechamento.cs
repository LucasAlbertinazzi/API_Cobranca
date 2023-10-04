using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblCartaoFechamento
{
    public int Codigo { get; set; }

    public DateOnly? DataMovimento { get; set; }

    public short? Codloja { get; set; }

    public string? ValorResumo { get; set; }

    public string? Obs { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? DataFechamento { get; set; }

    public int? CodusuarioLoja { get; set; }

    public DateTime? DataConfLoja { get; set; }
}
