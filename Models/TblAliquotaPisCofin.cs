using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: INCLUSÃO e FISCAL
/// Contém a alíquota de PIS e do COFINS, utilizada no cadastro de produtos, na composição de preço, também utilizado na impressão de nota fiscal (nfe)
/// 
/// </summary>
public partial class TblAliquotaPisCofin
{
    public int Codigo { get; set; }

    public decimal? Pis { get; set; }

    public decimal? Cofins { get; set; }

    public DateTime? Data { get; set; }

    public int? Codusuario { get; set; }
}
