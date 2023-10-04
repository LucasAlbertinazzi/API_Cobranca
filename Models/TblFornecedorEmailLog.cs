using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// tabela com os registros de envio de email para fornecedores
/// </summary>
public partial class TblFornecedorEmailLog
{
    public int Codigo { get; set; }

    public string? Pedido { get; set; }

    public DateTime? Data { get; set; }

    public string? Fornecedor { get; set; }

    public string? Tipo { get; set; }

    public string? Obs { get; set; }
}
