using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Normas e procedimentos da empresa e manual do sistema
/// 
/// </summary>
public partial class TblNorma
{
    public int Codigo { get; set; }

    public string? Descricao { get; set; }

    public string? Detalhe { get; set; }

    /// <summary>
    /// N para normas e procedimentos
    /// 
    /// M para manual do sistema
    /// </summary>
    public char? Tipo { get; set; }

    public string? Criadopor { get; set; }

    public string? Alteradopor { get; set; }
}
