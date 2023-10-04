using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblDev
{
    public int Id { get; set; }

    public int? Numerochamado { get; set; }

    public bool? Status { get; set; }

    public int? Tempo { get; set; }

    public DateTime? Data { get; set; }

    public string? Usuario { get; set; }

    public DateTime? Finalizado { get; set; }

    public short? Prioridade { get; set; }

    public bool DevFinalizado { get; set; }

    public int? Codusuario { get; set; }
}
