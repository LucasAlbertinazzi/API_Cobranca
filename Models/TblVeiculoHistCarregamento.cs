using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// histórico de carregamento, por veículo
/// </summary>
public partial class TblVeiculoHistCarregamento
{
    public int Codigo { get; set; }

    public int? Codveiculo { get; set; }

    public DateTime? DataExpedicao { get; set; }

    public int? Volumes { get; set; }

    public decimal? M3 { get; set; }

    public decimal? Peso { get; set; }

    public int? Codusuario { get; set; }

    public virtual TblUsuario? CodusuarioNavigation { get; set; }

    public virtual TblVeiculo? CodveiculoNavigation { get; set; }
}
