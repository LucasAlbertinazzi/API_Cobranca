using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// DEPÓSITO: RECEBIMENTO
/// Contém o código da agenda e o código do fornecedor. Esta tabela é gerenciada através da tela Frm_ConsAgendaFornecedor.
/// 
/// 
/// </summary>
public partial class TblAgendafornecedorFornec
{
    public int Codigo { get; set; }

    public int? Codagenda { get; set; }

    public int? Codfornecedor { get; set; }
}
