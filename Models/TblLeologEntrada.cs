using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblLeologEntrada
{
    public int Id { get; set; }

    public string NumeroNota { get; set; } = null!;

    public string SerieNota { get; set; } = null!;

    public string Arquivo { get; set; } = null!;

    public int Codusuario { get; set; }

    public string? ArquivoConferencia { get; set; }

    public int TipoNota { get; set; }

    public DateTime? Previsao { get; set; }
}
