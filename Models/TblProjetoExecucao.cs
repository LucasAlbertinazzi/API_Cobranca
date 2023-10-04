using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblProjetoExecucao
{
    public int Id { get; set; }

    public long CodUsuario { get; set; }

    public DateTime DataEntrada { get; set; }

    public DateTime? DataSaida { get; set; }

    public string? Ip { get; set; }

    public int ProjetoId { get; set; }

    public DateTime? UltimaAtualizacao { get; set; }
}
