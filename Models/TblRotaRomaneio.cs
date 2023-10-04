using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblRotaRomaneio
{
    public long Codigo { get; set; }

    /// <summary>
    /// Rota do Romaneio
    /// </summary>
    public string? Rota { get; set; }

    /// <summary>
    /// Tempo para bloqueio do romaneio
    /// </summary>
    public int? Tempo { get; set; }

    /// <summary>
    /// Quantidade de produtos para bloquear romaneio
    /// </summary>
    public int? Quantidade { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Atualizado { get; set; }

    public string? Endereco { get; set; }

    public decimal? Frete { get; set; }

    public bool? Ativo { get; set; }
}
