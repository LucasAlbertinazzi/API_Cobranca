using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblNfeDestinada
{
    public int Codigo { get; set; }

    public string? Chave { get; set; }

    public string? CnpjEmit { get; set; }

    public string? CnpjDest { get; set; }

    public DateOnly? DEmissao { get; set; }

    public DateTime? DhRecebimento { get; set; }

    public decimal? Valor { get; set; }

    public string? Nsu { get; set; }

    public string? Xnome { get; set; }
}
