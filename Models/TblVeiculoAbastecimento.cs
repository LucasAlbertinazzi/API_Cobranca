using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblVeiculoAbastecimento
{
    public int Codigo { get; set; }

    public int? Codveiculo { get; set; }

    public decimal? Km { get; set; }

    public string? AbastecidoPor { get; set; }

    public DateTime? Data { get; set; }

    public int? AdicionadoPor { get; set; }

    public DateTime? Dataregistro { get; set; }

    public decimal? Litros { get; set; }

    public bool? Excluido { get; set; }

    public int? ExcluidoPor { get; set; }

    public DateTime? ExcluidoEm { get; set; }

    public decimal? Arla { get; set; }

    public decimal? PrecoDiesel { get; set; }

    public string? FornecedorDiesel { get; set; }

    public virtual TblUsuario? AdicionadoPorNavigation { get; set; }

    public virtual TblVeiculo? CodveiculoNavigation { get; set; }

    public virtual TblUsuario? ExcluidoPorNavigation { get; set; }
}
