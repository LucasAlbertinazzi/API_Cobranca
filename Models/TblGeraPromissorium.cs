using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblGeraPromissorium
{
    public string? Prvalorparcela { get; set; }

    public int? Prqtdparcela { get; set; }

    public int? Printervalo { get; set; }

    public DateOnly? Prvencimento { get; set; }

    public int Id { get; set; }

    public int? Codcliente { get; set; }

    public int? Codavalista { get; set; }

    public int? Ncontrato { get; set; }

    public long? Codloja { get; set; }

    public DateTime? Avdata { get; set; }

    public string? Usuario { get; set; }

    public char? Tipoav { get; set; }
}
