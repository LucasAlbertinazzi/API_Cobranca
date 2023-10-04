using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSincFechamento
{
    public DateOnly DataFechamento { get; set; }

    public DateTime DataCadastro { get; set; }

    public int Codusuario { get; set; }
}
