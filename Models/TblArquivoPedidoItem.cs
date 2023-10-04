using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblArquivoPedidoItem
{
    public int Id { get; set; }

    public long Arquivopedidoid { get; set; }

    public int Arquivopedidotipo { get; set; }

    public string? Arquivo { get; set; }

    public DateTime? Dataenvio { get; set; }

    public string? Mensagemretorno { get; set; }

    public long Codusuario { get; set; }

    public DateTime Data { get; set; }
}
