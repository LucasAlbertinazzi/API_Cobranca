using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblPesquisaResp
{
    public int Codigo { get; set; }

    public int? Codpesquisa { get; set; }

    public int? Codusuario { get; set; }

    public int? Questao { get; set; }

    public string? Resposta { get; set; }

    public int? Ponto { get; set; }

    public DateTime? Data { get; set; }

    public int? Codigopesquisa { get; set; }
}
