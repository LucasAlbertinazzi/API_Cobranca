using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: FINANCEIRO
/// Uma agenda com os débitos e créditos de contas contábeis, incluindo as letras do caixa que efetuou o pagamento.
/// 
/// </summary>
public partial class TblAgendaPgtoContabil
{
    public long Codparcela { get; set; }

    public DateOnly? Pagamento { get; set; }

    public int? ContaDebito { get; set; }

    public int? ContaCredito { get; set; }

    public decimal? Valor { get; set; }

    public string? Historico { get; set; }

    public char? Credito { get; set; }

    public string? Letracaixa { get; set; }
}
