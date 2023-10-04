using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSubPedidoOrc
{
    public long? Codprepedido { get; set; }

    public string? Codpedido { get; set; }

    public string? Codproduto { get; set; }

    public short? Estoqueanterior { get; set; }

    public short? Quantvendido { get; set; }

    public decimal? Valorcusto { get; set; }

    public decimal? Valorvenda { get; set; }

    public decimal? Valortotal { get; set; }

    public decimal? Desconto { get; set; }

    public decimal? Totaldesconto { get; set; }

    public short? Taxa { get; set; }

    public int? Coddeposito { get; set; }

    public char? Juroespec { get; set; }

    public char? Promocao { get; set; }

    public char? Botafora { get; set; }

    public decimal? PrecovendaT1 { get; set; }

    public string? Codfabrica { get; set; }

    /// <summary>
    /// Tempo de entrega dos produtos
    /// </summary>
    public int? Tempoentrega { get; set; }

    /// <summary>
    /// Tempo nescessario para montar o produto
    /// </summary>
    public int? Tempomontagem { get; set; }

    /// <summary>
    /// se é nescessario montar o produto no cliente
    /// </summary>
    public char? Montar { get; set; }

    public decimal? Acrescimo { get; set; }

    public decimal? Vlrvendaproduto { get; set; }

    public DateOnly? Datavenda { get; set; }

    public int Codigo { get; set; }

    public virtual TblDepositoSeraApagada31102019? CoddepositoNavigation { get; set; }

    public virtual TblProduto? CodprodutoNavigation { get; set; }
}
