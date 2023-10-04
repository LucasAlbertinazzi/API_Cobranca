using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSolicitaNotaFiscalProduto
{
    public int Id { get; set; }

    public int SolicitaId { get; set; }

    public string Codproduto { get; set; } = null!;

    public int Quantidade { get; set; }
}
