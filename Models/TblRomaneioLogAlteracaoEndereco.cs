using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblRomaneioLogAlteracaoEndereco
{
    public int Id { get; set; }

    public long? Numeroromaneio { get; set; }

    public long? Idcliente { get; set; }

    public string? Bairroold { get; set; }

    public string? Ruaold { get; set; }

    public string? Bairronovo { get; set; }

    public string? Ruanova { get; set; }

    public string? Observacao { get; set; }

    public long? Codbairronovo { get; set; }

    public DateTime? Datahora { get; set; }

    public string? Codloja { get; set; }

    public string? Login { get; set; }
}
