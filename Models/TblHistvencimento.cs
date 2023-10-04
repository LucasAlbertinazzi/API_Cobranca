using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblHistvencimento
{
    public int Codigo { get; set; }

    public string? Codpedido { get; set; }

    public DateOnly? Dataanterior { get; set; }

    public DateOnly? Dataatual { get; set; }

    public decimal? Valor { get; set; }

    public int? Codusuario { get; set; }

    public int? Codcliente { get; set; }

    public DateTime? Data { get; set; }

    public virtual TblCliente? CodclienteNavigation { get; set; }
}
