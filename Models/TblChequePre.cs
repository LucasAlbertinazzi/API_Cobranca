using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblChequePre
{
    public DateOnly? Emissao { get; set; }

    public string? Banco { get; set; }

    public string? Agencia { get; set; }

    public string? Conta { get; set; }

    public string? Cheque { get; set; }

    public string? Nome { get; set; }

    public string? Cpf { get; set; }

    public DateOnly? Vencimento { get; set; }

    public double? Valor { get; set; }

    public string? Bancotroca { get; set; }

    public string? Pedido { get; set; }

    /// <summary>
    /// Pago ou deve
    /// </summary>
    public string? Situacao { get; set; }

    public DateTime? Datapassou { get; set; }

    public string? Tipo { get; set; }

    public int Codigo { get; set; }

    /// <summary>
    /// usario que cadastrou o cheque
    /// </summary>
    public string? Cadastrado { get; set; }

    public DateTime? Datacadastro { get; set; }

    /// <summary>
    /// usuario que enviou o cheque
    /// </summary>
    public string? Enviadopor { get; set; }

    public long? Codfornecedor { get; set; }

    public string? Fornecedor { get; set; }

    public int? Codloja { get; set; }
}
