using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblFiscalSincConf
{
    public int Id { get; set; }

    public int? Danfe { get; set; }

    public int? Codpedidocompra { get; set; }

    public string? UsuarioSintegra { get; set; }

    public DateOnly? DataSint { get; set; }

    public bool? ConferenciaSintegra { get; set; }

    public string? UsuarioTributacao { get; set; }

    public DateOnly? DataTrib { get; set; }

    public bool? ConferenciaTributacao { get; set; }

    public string? UsuarioFinanceiro { get; set; }

    public DateOnly? DataFin { get; set; }

    public bool? ConferenciaFinanceiro { get; set; }

    public DateTime? DataEmissaoDanfe { get; set; }

    public string? Comentario { get; set; }

    public char? StatusConferencia { get; set; }

    public DateTime? DataPrimeiraConf { get; set; }

    public string? ChaveAcesso { get; set; }
}
