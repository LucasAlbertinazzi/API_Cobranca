using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblEmissaoFiscal
{
    public int Id { get; set; }

    public DateOnly? Data { get; set; }

    public decimal? Valor { get; set; }

    public char? Tipo { get; set; }
}
