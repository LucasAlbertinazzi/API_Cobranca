using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblPosicao
{
    public int Codigo { get; set; }

    public int? Usuario { get; set; }

    public short? Deposito { get; set; }

    public char? Rua { get; set; }

    public char? Lado { get; set; }

    public short? Coluna { get; set; }

    public char? Linha { get; set; }

    public float? Tamanho { get; set; }

    public DateTime? DataHora { get; set; }

    public virtual ICollection<TblPosicaoProd> TblPosicaoProds { get; set; } = new List<TblPosicaoProd>();
}
