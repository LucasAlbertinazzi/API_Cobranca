using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblTarefa
{
    public int Codigo { get; set; }

    public int? Proprietario { get; set; }

    public int? Execucao { get; set; }

    public DateTime? Datasolicitado { get; set; }

    public DateTime? Dataexecucao { get; set; }

    public string? Assunto { get; set; }

    public decimal? Concluido { get; set; }

    public char? Aceita { get; set; }

    public string? Usercompartilhada { get; set; }

    public string? Tarefa { get; set; }

    public string? Obs { get; set; }

    public int? Tarefapai { get; set; }

    public char? Pai { get; set; }

    public int? Tarefamaster { get; set; }

    public char? Master { get; set; }

    public char? Finalizada { get; set; }

    public DateTime? Dataantiga { get; set; }

    public int? Ocorrencia { get; set; }

    public DateTime? Datafim { get; set; }

    public DateTime? Dataciente { get; set; }

    public int? Ocorretarefa { get; set; }

    public string? Usercriou { get; set; }
}
