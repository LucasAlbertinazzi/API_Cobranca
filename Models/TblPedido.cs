using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: PEDIDO
/// Contém todos os dados de pedidos finalizados, como datas, valores, codcliente, codprepedido, codpedido, loja, vendedor(usuário), parcelas, horário do fechamento do pedido, se o pedido foi cancelado ou não, caso sim, dados referente ao cancelamento, caixa que finalizou o pedido, quantidade de produtos.
/// 
/// 
/// </summary>
public partial class TblPedido
{
    public long? Codigo { get; set; }

    public long? Codprepedido { get; set; }

    public char Letracaixa { get; set; }

    public short Codloja { get; set; }

    public string Pedido { get; set; } = null!;

    public int? Codcliente { get; set; }

    public DateOnly? Datavenda { get; set; }

    public TimeOnly? Hora { get; set; }

    public string? Comprador { get; set; }

    public decimal? Totalproduto { get; set; }

    public decimal? Desconto { get; set; }

    public decimal? Acrescimo { get; set; }

    public decimal? Totalvenda { get; set; }

    public decimal? Acrescimopmedio { get; set; }

    public decimal? Totalpagar { get; set; }

    public int? Codusuario { get; set; }

    public short? Taxa { get; set; }

    public int? Parcelas { get; set; }

    public short? Tipovenda { get; set; }

    /// <summary>
    /// Quando esse campo recebe valor &apos;S&apos; dispara o codigo do pedido para as tbl_parcelas_prazo e tbl_sub_pedido.
    /// </summary>
    public char? Pedfechado { get; set; }

    public DateTime? Horafecha { get; set; }

    /// <summary>
    /// Codigo do Pedido Pronto
    /// </summary>
    public string? Codpedido { get; set; }

    public char? Cancelado { get; set; }

    /// <summary>
    /// data que foi cancelado
    /// </summary>
    public DateTime? Datacancelado { get; set; }

    /// <summary>
    /// Motivo do cancelamento
    /// </summary>
    public string? Motivocancel { get; set; }

    /// <summary>
    /// usuario que cancelou pedido
    /// </summary>
    public string? Usuariocancel { get; set; }

    /// <summary>
    /// Codigo do novo pedido se esse pedido for cancelado
    /// </summary>
    public string? Novopedido { get; set; }

    /// <summary>
    /// Codigo do pedido que foi cancelado e gerou esse pedido
    /// </summary>
    public string? Codpedidocancelado { get; set; }

    public string? Usuario { get; set; }

    public char? Imp { get; set; }

    public DateTime? Dataimp { get; set; }

    public string? Usuarioimp { get; set; }

    public long? Idcaixa { get; set; }

    public int? Produtos { get; set; }

    public int? ProdutosImp { get; set; }

    public char? ImpDep { get; set; }

    public string? UserImpDep { get; set; }

    public char? EntrouP { get; set; }

    public DateOnly? EntrouPData { get; set; }

    /// <summary>
    /// campo gerado apenas para gerar produtos da nota de cancelanento dos pedido antigos que for cancelado.
    /// 
    /// quando o campo for &apos;N&apos; e receber o valor &apos;S&apos; gera os produtos da nota fiscal
    /// </summary>
    public char? ProdNotaCancel { get; set; }

    public decimal? ValorFrete { get; set; }

    public virtual TblUsuario? CodusuarioNavigation { get; set; }
}
