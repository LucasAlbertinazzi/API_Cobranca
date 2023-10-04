using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblVeiculoMotorista
{
    public int Codigo { get; set; }

    public int? Codveiculo { get; set; }

    public string? Motorista { get; set; }

    public DateTime? Datainicio { get; set; }

    public DateTime? Datafim { get; set; }

    public bool Excluido { get; set; }

    public int? ExcluidoPor { get; set; }

    public DateTime? ExcluidoEm { get; set; }
}
