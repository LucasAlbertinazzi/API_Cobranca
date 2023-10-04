using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSincBlackList
{
    public int Id { get; set; }

    public string Chave { get; set; } = null!;

    public int Codusuario { get; set; }

    public DateTime Data { get; set; }

    public bool PermiteIncluir { get; set; }

    public string Mensagem { get; set; } = null!;
}
