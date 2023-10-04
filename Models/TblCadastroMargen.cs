using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblCadastroMargen
{
    public int Id { get; set; }

    public int? Coddivisao { get; set; }

    public int? Coddepartamento { get; set; }

    public int? Codmarca { get; set; }

    public decimal? Margem { get; set; }

    public decimal? Markup { get; set; }

    public DateTime? Datahora { get; set; }

    public int? Codusuario { get; set; }
}
