using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblDepartamento
{
    public long Coddepartamento { get; set; }

    public string? Departamento { get; set; }

    public long? Coddivisao { get; set; }

    public double? Juropadrao { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Data { get; set; }

    public int? Cartaz { get; set; }

    public int? Display { get; set; }

    public int? Saco { get; set; }

    /// <summary>
    /// dupla face
    /// </summary>
    public int? Df { get; set; }

    /// <summary>
    /// barbante
    /// </summary>
    public int? Ba { get; set; }

    /// <summary>
    /// durex
    /// </summary>
    public int? Du { get; set; }

    public int? Padraoetiqueta { get; set; }

    public int? Quantideal { get; set; }

    public char? Transferir { get; set; }

    public short? TaxaAvista { get; set; }

    public short? ParcCartao { get; set; }

    public bool? Imei { get; set; }

    public virtual TblDivisao? CoddivisaoNavigation { get; set; }
}
