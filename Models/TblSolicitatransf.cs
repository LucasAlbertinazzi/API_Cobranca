using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSolicitatransf
{
    public int Codigo { get; set; }

    public int? Origem { get; set; }

    public int? Destino { get; set; }

    public int? Destino2 { get; set; }

    public string? Obs { get; set; }

    public string? Obs2 { get; set; }

    public DateOnly? Data { get; set; }

    public DateOnly? Data2 { get; set; }

    public int? Quant { get; set; }

    public string? Codproduto { get; set; }

    public int? Codusuario { get; set; }

    public int? Autoriza { get; set; }

    public string? Obsautoriza { get; set; }

    public int? Autoriza1 { get; set; }

    public string? Obsautoriza1 { get; set; }

    public int? Autoriza2 { get; set; }

    public string? Obsautoriza2 { get; set; }

    public int? Solicitadopor { get; set; }

    public char? Concluida { get; set; }

    public DateOnly? Datasolicitada { get; set; }

    public string? Romaneio { get; set; }

    public string? Codpedido { get; set; }

    public long? IdRomaneioVenda { get; set; }
}
