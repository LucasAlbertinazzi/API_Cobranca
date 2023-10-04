using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblNfeVendaDevolucaoArmazenagem
{
    public int Id { get; set; }

    public int IdNfeVenda { get; set; }

    public int IdNfeRetorno { get; set; }

    public int IdNfeDevVenda { get; set; }

    public int IdNfeDevRetorno { get; set; }

    public string Documento { get; set; } = null!;
}
