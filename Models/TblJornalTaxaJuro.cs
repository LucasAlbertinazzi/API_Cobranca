using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblJornalTaxaJuro
{
    public int Codjornal { get; set; }

    public short Coddep { get; set; }

    public short? Coddiv { get; set; }

    public short QuantParc { get; set; }

    public decimal? Taxa { get; set; }

    public short? Codusuario { get; set; }

    public DateTime? Data { get; set; }

    public char? Individual { get; set; }

    public decimal TaxaCartao { get; set; }
}
