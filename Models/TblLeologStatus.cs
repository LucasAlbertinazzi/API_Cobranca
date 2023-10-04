using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblLeologStatus
{
    public int Id { get; set; }

    public int Tipo { get; set; }

    public string Situacao { get; set; } = null!;

    public string? SituacaoDescricao { get; set; }

    public DateTime Data { get; set; }

    public int TipoId { get; set; }

    public int Codusuario { get; set; }
}
