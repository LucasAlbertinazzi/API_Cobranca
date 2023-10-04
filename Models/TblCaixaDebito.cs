using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Registros de Débito da conta caixa em nosso sistema. Saídas de dinheiro.
/// 
/// </summary>
public partial class TblCaixaDebito
{
    public int Codigo { get; set; }

    public int? Coddivisao { get; set; }

    public string? Fornecedor { get; set; }

    public decimal? Valor { get; set; }

    public string? Tipo { get; set; }

    public string? Obs { get; set; }

    public DateOnly? Data { get; set; }

    public string? Caixa { get; set; }

    public int? Idcaixa { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Datahora { get; set; }

    public char? Operacao { get; set; }

    public char? Estornado { get; set; }

    public int? Caixaloja { get; set; }

    public int? Codloja { get; set; }

    public char? Estorno { get; set; }

    public char? Excluir { get; set; }

    public int? Coddivisaosub { get; set; }

    public int? Codparcelaagenda { get; set; }
}
