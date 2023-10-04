using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblFormulario
{
    public long Codigo { get; set; }

    public string? FormularioExcluir { get; set; }

    public string? Descricao { get; set; }

    public string? Frm { get; set; }

    public char? Bloqueio { get; set; }

    public int ContadorAbertura { get; set; }

    public DateTime UltimoAcesso { get; set; }

    public virtual ICollection<TblPermisso> TblPermissos { get; set; } = new List<TblPermisso>();
}
