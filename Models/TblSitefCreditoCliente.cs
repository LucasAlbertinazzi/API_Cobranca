using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSitefCreditoCliente
{
    public int CupomFiscal { get; set; }

    public DateTime? Finalizado { get; set; }
}
