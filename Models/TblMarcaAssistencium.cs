using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblMarcaAssistencium
{
    public int Codigo { get; set; }

    public int? Codmarca { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Datainicio { get; set; }

    public char? Ativo { get; set; }
}
