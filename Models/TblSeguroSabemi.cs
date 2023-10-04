using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSeguroSabemi
{
    public int Id { get; set; }

    public int Codcliente { get; set; }

    public string? Apolice { get; set; }

    public string? NumSorte { get; set; }

    public string Arquivo { get; set; } = null!;

    public DateTime Data { get; set; }

    public int CodusuarioVendedor { get; set; }

    public int? CodusuarioCaixa { get; set; }

    public string? MensagemRetorno { get; set; }

    public int? CodigoCancelado { get; set; }

    public int Codloja { get; set; }

    public string? Contrato { get; set; }

    public bool Conjuge { get; set; }

    public DateTime? DataEnvio { get; set; }

    public DateTime? DataRetorno { get; set; }
}
