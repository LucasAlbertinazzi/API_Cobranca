using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: COBRANÇA
/// Tipos de análise de crédito disponíveis na tbl_analise_credito
/// </summary>
public partial class TblAnaliseCreditoTipo
{
    public int Codsenha { get; set; }

    public string? Tipo { get; set; }

    public bool? Ativo { get; set; }
}
