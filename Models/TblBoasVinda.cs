using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblBoasVinda
{
    public int CodMensagem { get; set; }

    public DateOnly? DataInicio { get; set; }

    public DateOnly? DataFim { get; set; }

    public string? Mensagem { get; set; }
}
