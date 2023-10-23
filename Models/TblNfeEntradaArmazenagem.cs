using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblNfeEntradaArmazenagem
{
    public int Codigo { get; set; }

    /// <summary>
    /// codigo na tbl_nfe_entrada referente a nota de compra do fornecedor
    /// </summary>
    public int CodNfeVenda { get; set; }

    /// <summary>
    /// codigo na tbl_nfe_entrada referente a nota de armazem do fornecedor
    /// </summary>
    public int CodNfeArmazem { get; set; }

    public int Codlogistica { get; set; }

    public int Codusuario { get; set; }

    public DateTime Data { get; set; }

    /// <summary>
    /// codigo na tbl_nfe referente a nfe de armazem emitida pela AppEmpresarialMultFuncional
    /// </summary>
    public int? IdNfeArmazemMarcius { get; set; }
}
