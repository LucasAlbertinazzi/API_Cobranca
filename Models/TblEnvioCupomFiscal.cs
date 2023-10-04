using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblEnvioCupomFiscal
{
    public int Codigo { get; set; }

    public int? Codempresa { get; set; }

    public string? Protocolo { get; set; }

    public string? Arquivo { get; set; }

    public string? Obs { get; set; }

    public string? Remetente { get; set; }

    public DateTime? Dataenvio { get; set; }

    public int? Codstatus { get; set; }

    public string? Status { get; set; }

    public DateOnly? Dataarquivo { get; set; }

    public string? Tipo { get; set; }

    public int? Codusuario { get; set; }

    public int? Codfabrica { get; set; }

    public int? Ecf { get; set; }

    public string? Conteudo { get; set; }
}
