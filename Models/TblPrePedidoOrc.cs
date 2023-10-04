using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblPrePedidoOrc
{
    /// <summary>
    /// Codigo do Pré Pedido
    /// </summary>
    public long Codprepedido { get; set; }

    public int? Codcliente { get; set; }

    public DateOnly? Datavenda { get; set; }

    public string? Comprador { get; set; }

    public decimal? Totalproduto { get; set; }

    public decimal? Desconto { get; set; }

    public decimal? Acrescimo { get; set; }

    public decimal? Totalvenda { get; set; }

    public char? Pedidofechado { get; set; }

    public int? Codusuario { get; set; }

    public int? Codloja { get; set; }

    public DateTimeOffset? Hora { get; set; }

    public short? Taxa { get; set; }

    /// <summary>
    /// Quantidade de Parcelas
    /// </summary>
    public short? Parcelas { get; set; }

    public short? Ocorrencia { get; set; }

    /// <summary>
    /// Acrescimo Prazo medio
    /// </summary>
    public decimal? Acrescimopmedio { get; set; }

    public decimal? Totalpagar { get; set; }

    /// <summary>
    /// Tipo de Venda - Crediario Loja Cartão ou Financeira
    /// </summary>
    public int? Tipovenda { get; set; }

    /// <summary>
    /// Pedido confirmado ou não
    /// </summary>
    public char? Impresso { get; set; }

    /// <summary>
    /// Letra do Caixa que imprimiu
    /// </summary>
    public char? Letracaixa { get; set; }

    public int? Codusuariocaixa { get; set; }

    /// <summary>
    /// Se cadastro estiver negado e pedido não for a vista
    /// </summary>
    public char? Negado { get; set; }

    /// <summary>
    /// Se desconto for maior do que o permitido
    /// </summary>
    public short? OcorrDesc { get; set; }

    /// <summary>
    /// Quem forneceu senha 1
    /// </summary>
    public string? Senha1 { get; set; }

    public DateTime? Horasenha1 { get; set; }

    public string? Senha2 { get; set; }

    public DateTime? Horasenha2 { get; set; }

    public string? Senha3 { get; set; }

    public DateTime? Horasenha3 { get; set; }

    public string? Senha1obs { get; set; }

    public string? Senha2obs { get; set; }

    public string? Senha3obs { get; set; }

    /// <summary>
    /// se o cadastro esta aprovado ou não
    /// </summary>
    public char? Aprovado { get; set; }

    /// <summary>
    /// codigo do pedido cancelado que gerou esse novo pedido
    /// </summary>
    public string? Codpedidocancelado { get; set; }

    public int Prepedido { get; set; }

    public virtual TblCliente? CodclienteNavigation { get; set; }

    public virtual TblLoja? CodlojaNavigation { get; set; }

    public virtual TblUsuario? CodusuarioNavigation { get; set; }

    public virtual TblTipoVendum? TipovendaNavigation { get; set; }
}
