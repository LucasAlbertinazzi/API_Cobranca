using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: Fiscal e Pedido
/// Contém os dados das notas fiscais eletrônicas emitidas, inclusive a chave da nota.
/// situação L = liberada
/// situação E = emitida
/// TR+ a coluna código não está correlacionada com o documento da tbl_nfe, que também tem um TR+ um código. Este código da tbl_nfe é a ID da transferência.
/// A correlação entre uma transferência e sua nota está na coluna NFE da tbl_romaneio.
/// 
/// </summary>
public partial class TblNfe
{
    public int Id { get; set; }

    public int Codloja { get; set; }

    public int Numnota { get; set; }

    public char? Situacao { get; set; }

    public string? RetornoEnvio { get; set; }

    public string? CstatEnvio { get; set; }

    public string? ProtEnvio { get; set; }

    public string? NfeXmlEnvio { get; set; }

    public string? Documento { get; set; }

    public string? CstatRetorno { get; set; }

    public string? Xmotivo { get; set; }

    public int? UserEnvio { get; set; }

    public int? UserRetorno { get; set; }

    public int? ImpDanfe { get; set; }

    public DateTime? DhEnvio { get; set; }

    public DateTime? DhRetorno { get; set; }

    public string? NfeXml { get; set; }

    public string? Chave { get; set; }

    public string? CodTransferencia { get; set; }

    public int? Serie { get; set; }

    public string? TipoOperacao { get; set; }

    public virtual TblLoja CodlojaNavigation { get; set; } = null!;
}
