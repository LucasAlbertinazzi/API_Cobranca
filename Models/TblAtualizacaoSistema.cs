using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblAtualizacaoSistema
{
    public int IdAtualizacao { get; set; }

    public DateTime? DataHora { get; set; }

    public long Codloja { get; set; }

    public TimeOnly Tempo { get; set; }
}
