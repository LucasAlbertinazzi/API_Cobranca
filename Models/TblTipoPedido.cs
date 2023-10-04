using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Esta tabela está correlacionada com a tbl_pedido_compra em tbl_tipo_pedido.codigo = tbl_pedido_compra.tipo_pedido
/// </summary>
public partial class TblTipoPedido
{
    public short Codigo { get; set; }

    public string? Tipo { get; set; }
}
