using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Tipo de vendas e Financeiras
/// </summary>
public partial class TblTipoVendum
{
    public int Codigo { get; set; }

    public string? Tipovenda { get; set; }

    public virtual ICollection<TblParcelasPrazoOrc> TblParcelasPrazoOrcs { get; set; } = new List<TblParcelasPrazoOrc>();

    public virtual ICollection<TblParcelasPrazo> TblParcelasPrazos { get; set; } = new List<TblParcelasPrazo>();

    public virtual ICollection<TblPrePedido> TblPrePedidos { get; set; } = new List<TblPrePedido>();
}
