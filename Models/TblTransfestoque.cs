using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// transferencia de Mercadoria ente lojas
/// TR+ a coluna código não está correlacionada com o documento da tbl_nfe, que também tem um TR+ um código. Este código da tbl_nfe é a ID da transferência.
/// A correlação entre uma transferência e sua nota está na coluna NFE da tbl_romaneio.
/// </summary>
public partial class TblTransfestoque
{
    public long Codigo { get; set; }

    /// <summary>
    /// data da solicitação
    /// </summary>
    public DateTime? Datasolicita { get; set; }

    public int? Codusuario { get; set; }

    public int? Origem { get; set; }

    public int? Destino { get; set; }

    public int? Quantidade { get; set; }

    public DateOnly? Datatransf { get; set; }

    /// <summary>
    /// estoque anterior a transferencia da origem
    /// </summary>
    public int? Estoqueorigem { get; set; }

    public string? Confirmadopor { get; set; }

    public DateTime? Dataconfirmado { get; set; }

    /// <summary>
    /// confirmação da entrada no estoque
    /// </summary>
    public char? Confirmado { get; set; }

    /// <summary>
    /// estoque anterior atransferencia do destino
    /// </summary>
    public int? Estoquedestino { get; set; }

    public string? Codproduto { get; set; }

    public char? Romaneio { get; set; }

    public string? Obs { get; set; }

    public char? Cancelado { get; set; }

    public int? Osassistencia { get; set; }

    public long? Codprepedido22Para1 { get; set; }
}
