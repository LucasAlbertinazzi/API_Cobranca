using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblNfeIndenizacao
{
    public int Id { get; set; }

    public int? NumNota { get; set; }

    public int? CodLoja { get; set; }

    public string? Xml { get; set; }

    public string? CodPedido { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? Data { get; set; }
}
