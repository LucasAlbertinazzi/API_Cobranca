using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblPixCobranca
{
    public int Status { get; set; }

    public string CpfCnpjDevedor { get; set; } = null!;

    public decimal Valor { get; set; }

    public DateTime Criacao { get; set; }

    public string Qrcode { get; set; } = null!;

    public string Id { get; set; } = null!;

    public int Codloja { get; set; }

    public int Sequencia { get; set; }
}
