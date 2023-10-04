using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblNfeProdutosDevol
{
    public int Codigo { get; set; }

    public string? Codpedido { get; set; }

    public long? Nfedev { get; set; }

    public short? Localsaida { get; set; }

    public int? Quant { get; set; }

    public string? Codproduto { get; set; }

    public decimal? Vunit { get; set; }

    public long? CupomVenda { get; set; }

    public long? NfeVenda { get; set; }

    public long? NfceVenda { get; set; }

    public char? NfedevAutorizada { get; set; }

    public long? Codsubpedido { get; set; }

    public short? NumeroEcf { get; set; }

    public DateTime? Data { get; set; }
}
