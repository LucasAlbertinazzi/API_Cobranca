using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSitefVendaParcial
{
    public int IdParcial { get; set; }

    public int CupomFiscal { get; set; }

    public decimal TotalVenda { get; set; }
}
