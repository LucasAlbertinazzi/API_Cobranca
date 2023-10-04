using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblPesquisaUser
{
    public int Codigo { get; set; }

    public string? Pesquisa { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Datainicio { get; set; }

    public DateTime? Datafim { get; set; }

    public int? Codpesquisa { get; set; }

    public int? Useravaliado { get; set; }
}
