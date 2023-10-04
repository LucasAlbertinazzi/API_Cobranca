using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblPixDevolucao
{
    public string Id { get; set; } = null!;

    public string EndToEndId { get; set; } = null!;

    public decimal Valor { get; set; }

    public int Status { get; set; }

    public DateTime DataSolicitacao { get; set; }

    public string Usuario { get; set; } = null!;

    public string IdCobranca { get; set; } = null!;
}
