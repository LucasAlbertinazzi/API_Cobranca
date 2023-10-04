using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblClienteEmp
{
    public int Id { get; set; }

    public long? Codcliente { get; set; }

    public string? RegiaoVenda { get; set; }

    public string? ListaPreco { get; set; }

    public string? GrupoPreco { get; set; }
}
