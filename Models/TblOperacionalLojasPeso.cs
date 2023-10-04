using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// fatia com que cada loja pega do operacional da loja 1.
/// </summary>
public partial class TblOperacionalLojasPeso
{
    public int Id { get; set; }

    public int? Codloja { get; set; }

    public decimal? Percent { get; set; }
}
