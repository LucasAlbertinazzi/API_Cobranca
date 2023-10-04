using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: Fiscal
/// Log de registros excluídos da tbl_produto_alq_ncm
/// </summary>
public partial class TblProdutoAlqNcmLogDel
{
    public int Id { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Data { get; set; }

    public string? Codproduto { get; set; }

    public string? Ncm { get; set; }
}
