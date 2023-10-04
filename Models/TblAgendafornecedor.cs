using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: DEPÓSITO: RECEBIMENTO
/// Esta tabela agenda o recebimento de mercadorias. Detalha o fornecedor e o veículo, com o nome do motorista, placa, nome da transportadora, quantidade de volumes e o horário agendado, entrada e saída. Esta tabela é gerenciada através da tela Frm_ConsAgendaFornecedor.
/// </summary>
public partial class TblAgendafornecedor
{
    public int Codigo { get; set; }

    public string? Usuario { get; set; }

    public DateOnly? Data { get; set; }

    public TimeOnly? Preventrada { get; set; }

    public TimeOnly? Prevsaida { get; set; }

    public TimeOnly? Entrada { get; set; }

    public string? Usuarioentrada { get; set; }

    public TimeOnly? Saida { get; set; }

    public string? Usuariosaida { get; set; }

    public string? Fornecedor { get; set; }

    public string? Transportadora { get; set; }

    public char? Recebexml { get; set; }

    public string? Motorista { get; set; }

    public string? Cpfmotorista { get; set; }

    public string? Ajudante { get; set; }

    public string? Cpfajudante { get; set; }

    public string? Ajudante1 { get; set; }

    public string? Cpfajudante1 { get; set; }

    public string? Placa { get; set; }

    public string? Usurecebimento { get; set; }

    public string? Ajudante3 { get; set; }

    public string? Cpfajudante3 { get; set; }

    public string? Notafiscal { get; set; }

    public string? Volume { get; set; }

    public string? Excluido { get; set; }
}
