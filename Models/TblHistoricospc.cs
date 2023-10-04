using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblHistoricospc
{
    public int Codigo { get; set; }

    /// <summary>
    /// se entrou ou saiu do SPC
    /// </summary>
    public char? Tipo { get; set; }

    public DateTime? Data { get; set; }

    public int? Codusuario { get; set; }

    public int? Codcliente { get; set; }

    public string? Codigospc { get; set; }

    public decimal? Valor { get; set; }

    public string? Obs { get; set; }

    public char? TitularConjuge { get; set; }

    public virtual TblCliente? CodclienteNavigation { get; set; }

    public virtual TblUsuario? CodusuarioNavigation { get; set; }
}
