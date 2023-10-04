using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblMaloteIten
{
    public int Id { get; set; }

    public string? Lacrenum { get; set; }

    public string? Remeloja { get; set; }

    public int? Coduserreme { get; set; }

    public string? Destloja { get; set; }

    public int? Coduserdest { get; set; }

    public string? Descricao { get; set; }

    public DateTime? Prevdata { get; set; }

    public DateTime? Datacria { get; set; }

    public string? Statusentrega { get; set; }

    public string? Nomeuserdest { get; set; }

    public string? Deleteitem { get; set; }

    public string? Deletemalote { get; set; }

    public int? Coduserrecebe { get; set; }

    public int? Dep { get; set; }

    public DateTime? Dataretiraitem { get; set; }
}
