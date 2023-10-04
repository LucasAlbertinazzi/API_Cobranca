using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblUf
{
    public int Codigo { get; set; }

    public string? Uf { get; set; }

    public string? Ufnome { get; set; }

    public short? CodDne { get; set; }

    public string? InfoAddNfe { get; set; }

    public string? Ie { get; set; }

    public string? InfAddNfeEs { get; set; }

    public string? IeEs { get; set; }

    public virtual ICollection<TblCidade> TblCidades { get; set; } = new List<TblCidade>();

    public virtual ICollection<TblLoja> TblLojas { get; set; } = new List<TblLoja>();

    public virtual ICollection<TblProdutoAlqNcm> TblProdutoAlqNcms { get; set; } = new List<TblProdutoAlqNcm>();
}
