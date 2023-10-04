using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: COBRANÇA
/// Tabela que contém o agendamento de cobrança, com o código do cliente, data para se cobrar, data que foi realizado o agendamento e por qual usuário. Histórico da agenda de cobrança.
/// 
/// </summary>
public partial class TblAgendaCob
{
    public int Codigo { get; set; }

    public int? Codcliente { get; set; }

    public DateOnly? Datacobrar { get; set; }

    public DateTime? Dataagendamento { get; set; }

    public int? Codusuario { get; set; }
}
