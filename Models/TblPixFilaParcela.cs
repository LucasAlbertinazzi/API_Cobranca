using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblPixFilaParcela
{
    public int Id { get; set; }

    public int CodigoParcelaPrazo { get; set; }

    public DateTime DataSolicitado { get; set; }

    public DateTime? DataProcessado { get; set; }

    public decimal? ValorParcela { get; set; }

    public int? DiasAtraso { get; set; }

    public decimal? ValorPagar { get; set; }

    public decimal? ValorPago { get; set; }

    public int Codusuario { get; set; }

    public char? Classe { get; set; }

    public decimal? ValorRecebido { get; set; }

    public decimal? ValorRecebido1 { get; set; }

    public int? Codcliente { get; set; }
}
