using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblCaixaMov
{
    public long Codigo { get; set; }

    /// <summary>
    /// Data de abertura do caixa
    /// </summary>
    public DateOnly? Datacaixa { get; set; }

    /// <summary>
    /// Hora de abertura do caixa
    /// </summary>
    public TimeOnly? Horacaixa { get; set; }

    /// <summary>
    /// Valor do Caixa Inicial
    /// </summary>
    public decimal? Cxinicial { get; set; }

    /// <summary>
    /// Recebimento de Conta DI
    /// </summary>
    public decimal? RecContadi { get; set; }

    /// <summary>
    /// Estorno de Conta DI
    /// </summary>
    public decimal? EstContadi { get; set; }

    /// <summary>
    /// Recebimento de Conta Cheque Pre
    /// </summary>
    public decimal? RecContachpre { get; set; }

    /// <summary>
    /// Estorno de Conta Cheque Pre
    /// </summary>
    public decimal? EstContachpre { get; set; }

    /// <summary>
    /// Recebimento de Pedido DI
    /// </summary>
    public decimal? RecPedidodi { get; set; }

    /// <summary>
    /// Estorno Pedido DI
    /// </summary>
    public decimal? EstPedidodi { get; set; }

    /// <summary>
    /// Recebimento Pedido Cheque Pre
    /// </summary>
    public decimal? RecPedidochpre { get; set; }

    /// <summary>
    /// Estorno Pedido Cheque Pre
    /// </summary>
    public decimal? EstPedidochpre { get; set; }

    /// <summary>
    /// Credito DI Transferencia
    /// </summary>
    public decimal? CreditoDi { get; set; }

    /// <summary>
    /// Debito DI Transferencia
    /// </summary>
    public decimal? DebitoDi { get; set; }

    /// <summary>
    /// Credito Cheque Pre Transferencia
    /// </summary>
    public decimal? CreditoChpre { get; set; }

    /// <summary>
    /// Debito Cheque Pre Transferencia
    /// </summary>
    public decimal? DebitoChpre { get; set; }

    /// <summary>
    /// Credito Diversos DI
    /// </summary>
    public decimal? CredDiversosdi { get; set; }

    /// <summary>
    /// Debito Diversos DI
    /// </summary>
    public decimal? DebDiversosdi { get; set; }

    /// <summary>
    /// Credido Diversos Cheque Pre
    /// </summary>
    public decimal? CredDiversoschpre { get; set; }

    /// <summary>
    /// Debito Diversos Cheque Pre
    /// </summary>
    public decimal? DebDiversoschpre { get; set; }

    /// <summary>
    /// Total em Creditos no Caixa
    /// </summary>
    public decimal? TotalCreditos { get; set; }

    /// <summary>
    /// Total de Debitos no Caixa
    /// </summary>
    public decimal? TotalDebitos { get; set; }

    /// <summary>
    /// Saldo do caixa
    /// </summary>
    public decimal? SaldoCaixa { get; set; }

    /// <summary>
    /// Codigo do Usuario que abriu esse caixa
    /// </summary>
    public int? Codusuario { get; set; }

    /// <summary>
    /// Letra do Caixa
    /// </summary>
    public string? Letracaixa { get; set; }

    /// <summary>
    /// Codigo da loja que o caixa pertence
    /// </summary>
    public int? Codloja { get; set; }

    /// <summary>
    /// &apos;A&apos; Caixa aberto &apos;F&apos; Caixa fechado  
    /// &apos;N&apos; Caixa no aguardo
    /// </summary>
    public char? Situacao { get; set; }

    /// <summary>
    /// Total em Caixa DI
    /// </summary>
    public decimal? TotalCaixadi { get; set; }

    /// <summary>
    /// Falta Caixa DI
    /// </summary>
    public decimal? FaltaCaixadi { get; set; }

    /// <summary>
    /// Total Caixa Cheque Pre
    /// </summary>
    public decimal? TotalCaixachpre { get; set; }

    /// <summary>
    /// Falta Caixa Cheque Pre
    /// </summary>
    public decimal? FaltaCaixachpre { get; set; }

    /// <summary>
    /// Falta em caixa
    /// </summary>
    public decimal? FaltaTotalcaixa { get; set; }

    /// <summary>
    /// Data fechamento do caixa
    /// </summary>
    public DateOnly? Datafecha { get; set; }

    /// <summary>
    /// Hora do fechamento do caixa
    /// </summary>
    public TimeOnly? Horafecha { get; set; }

    public string? Obs { get; set; }
}
