using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: TI/FINANCEIRO
/// Tabela com o registro de alterações da tbl_ativo, como quando um equipamento muda de cidade, as alterações da localidade do ativo são registradas aqui.
/// 
/// </summary>
public partial class TblAtivoHistorico
{
    public int Codigo { get; set; }

    public int? Codativo { get; set; }

    public int? Codusuario { get; set; }

    public string? AlterouDe { get; set; }

    public string? AlterouPara { get; set; }

    public string? Obs { get; set; }

    public DateTime? Data { get; set; }

    public virtual TblAtivo? CodativoNavigation { get; set; }

    public virtual TblUsuario? CodusuarioNavigation { get; set; }
}
