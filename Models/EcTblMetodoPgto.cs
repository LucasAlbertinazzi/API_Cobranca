using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Armazena os Meios de Pagamento  da Skyhub
/// </summary>
public partial class EcTblMetodoPgto
{
    public int Id { get; set; }

    public string? Metodo { get; set; }
}
