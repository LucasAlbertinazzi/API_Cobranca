using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// histórico de alteração de preços na FrmManutProdutoNew
/// </summary>
public partial class TblProdutoHistAltMargem
{
    public long IdHistAltMargem { get; set; }

    public string Codproduto { get; set; } = null!;

    public int Codusuario { get; set; }

    public DateTime Data { get; set; }

    public decimal? Margem { get; set; }

    public decimal? MargemAnterior { get; set; }
}
