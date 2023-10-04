using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class EcTblConsultaProdutoItemAnymarket
{
    public int Id { get; set; }

    public int ConsultaProdutoId { get; set; }

    public string Codproduto { get; set; } = null!;

    public decimal Price { get; set; }

    public int Crossdocking { get; set; }

    public decimal Weight { get; set; }

    public decimal Width { get; set; }

    public decimal Length { get; set; }

    public int Qnt { get; set; }

    public decimal Height { get; set; }

    public virtual EcTblConsultaProdutoAnymarket ConsultaProduto { get; set; } = null!;
}
