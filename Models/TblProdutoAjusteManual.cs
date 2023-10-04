using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: Auditoria
/// Tabela que mantém os registros de alterações de estoque manualmente.
/// </summary>
public partial class TblProdutoAjusteManual
{
    public int Codigo { get; set; }

    public DateTime? Data { get; set; }

    public short? Codloja { get; set; }

    public int? Saldoanterior { get; set; }

    public int? Saldoajustado { get; set; }

    public string? Codproduto { get; set; }

    public long? Codusuario { get; set; }

    public string? Motivo { get; set; }
}
