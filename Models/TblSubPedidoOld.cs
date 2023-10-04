using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSubPedidoOld
{
    public long Codigo { get; set; }

    public string? Codpedido { get; set; }

    public string? Codproduto { get; set; }

    public string? Descricao { get; set; }

    public short? Quantvendido { get; set; }

    public decimal? Valorvenda { get; set; }

    public decimal? Valortotal { get; set; }

    public short? Taxa { get; set; }

    public string? Coddeposito { get; set; }

    public string? Promocao { get; set; }

    public string? Codfabrica { get; set; }

    public int? Garantia { get; set; }
}
