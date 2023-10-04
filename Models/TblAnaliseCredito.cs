using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: COBRANÇA
/// Esta tabela é utilizada na FrmAnaliseCredito e pelas telas onde há um sininho, feito para acionar o departamento de liberação de crédito para analisar cadastros, pedidos, cancelamentos e renegociações.
/// </summary>
public partial class TblAnaliseCredito
{
    public int Codsolicitacao { get; set; }

    public long? Codloja { get; set; }

    public int? Codcliente { get; set; }

    public short? Tiposenha { get; set; }

    public DateTime? Datasolicitacao { get; set; }

    public DateTime? Datasenha { get; set; }

    public int? Analista { get; set; }

    public int? Solicitante { get; set; }

    public bool? Cancelado { get; set; }

    public bool? Finalizado { get; set; }

    public string? Obs { get; set; }

    public string? Codigo { get; set; }
}
