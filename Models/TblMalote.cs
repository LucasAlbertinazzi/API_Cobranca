using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblMalote
{
    public int Id { get; set; }

    public DateTime? Datacria { get; set; }

    public string? Statusmalote { get; set; }

    public string? Lojareme { get; set; }

    public string? Lojadest { get; set; }

    public DateTime? Dataenviomalote { get; set; }

    public string? Transporte { get; set; }

    public DateTime? Datarecebemalote { get; set; }

    public string? Userrecebemalote { get; set; }

    public DateTime? Dataabremalote { get; set; }

    public string? Numlacre { get; set; }

    public DateTime? Dataprevi { get; set; }

    public string? Userenviamalote { get; set; }

    public int? Coduserenvia { get; set; }

    public string? Delete { get; set; }

    public int? Coduserrecebe { get; set; }
}
