using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// agendamento de datas de promoção, retirando a necessidade de alterar o código.
/// </summary>
public partial class TblVendasPromocaoAgendadum
{
    public int Codigo { get; set; }

    public string? Promocao { get; set; }

    public DateOnly? Data { get; set; }

    public bool PermitidoVenda1 { get; set; }

    public bool OcorrenciasAplicadas { get; set; }
}
