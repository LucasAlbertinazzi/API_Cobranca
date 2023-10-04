using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblDepartamentoTaxa
{
    public short Coddep { get; set; }

    public short QuantParc { get; set; }

    public decimal? Taxa { get; set; }

    public decimal? TaxaEc { get; set; }

    public decimal? TaxaCartao { get; set; }
}
