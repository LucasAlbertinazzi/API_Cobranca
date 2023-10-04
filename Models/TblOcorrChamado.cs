using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblOcorrChamado
{
    public int Codigo { get; set; }

    public short? Coddepartamento { get; set; }

    public short? Codtiposervico { get; set; }

    public int? Patrimonio { get; set; }

    public int? Userchamado { get; set; }

    public int? Useracompanha { get; set; }

    public short? Ramal { get; set; }

    public DateTime? Datachamado { get; set; }

    public DateTime? Dataencerrado { get; set; }

    public DateOnly? Dataexecucao { get; set; }

    public string? Obs { get; set; }

    public bool? Recebido { get; set; }

    public DateTime? Previsao { get; set; }

    public short? Userexecuta { get; set; }

    public string? Obsfechamento { get; set; }

    /// <summary>
    /// Codigo da Assistencia aberta.
    /// </summary>
    public long? Codassistencia { get; set; }

    /// <summary>
    /// Data de retorno da assistencia
    /// </summary>
    public DateTime? Retornoassistencia { get; set; }

    public long? UserPrioridade { get; set; }

    public short? Prioridade { get; set; }

    public bool? Planejamento { get; set; }

    public string? MetodoReferencia { get; set; }

    public string? Anotacao { get; set; }

    public string? Origem { get; set; }
}
