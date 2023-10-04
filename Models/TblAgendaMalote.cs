using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblAgendaMalote
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public string? Remetente { get; set; }

    public DateTime? DataAgendamento { get; set; }

    public DateTime? DataRecebimento { get; set; }

    public bool? Recebido { get; set; }

    public string? Destinatario { get; set; }

    public string? LoginRecebimento { get; set; }

    public string? Login { get; set; }

    public string? LojaDestino { get; set; }

    public long? Codloja { get; set; }

    public bool? Entregue { get; set; }

    public string? Obs { get; set; }

    public long? Lacre { get; set; }

    public string? LoginEntregue { get; set; }

    public DateTime? DataEntregue { get; set; }

    public string? LoginLacre { get; set; }

    public long? LojaRemetente { get; set; }
}
