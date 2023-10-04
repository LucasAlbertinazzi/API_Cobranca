using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblNfeDespesa
{
    public int Id { get; set; }

    public int Categoria { get; set; }

    public int Nota { get; set; }

    public string? Cnpj { get; set; }

    public DateTime? Data { get; set; }

    public int? Codusuario { get; set; }

    public string? Xml { get; set; }

    public string? Serie { get; set; }

    public string? Chave { get; set; }
}
