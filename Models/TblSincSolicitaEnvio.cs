using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSincSolicitaEnvio
{
    public int Id { get; set; }

    public int Codusuario { get; set; }

    public string Operacoes { get; set; } = null!;

    public DateTime SolicitaProcessoInicio { get; set; }

    public DateTime? SolicitaProcessoFim { get; set; }

    public string? Mensagem { get; set; }

    public int? CodusuarioCancelou { get; set; }

    public DateTime IntervaloInicio { get; set; }

    public DateTime IntervaloFim { get; set; }

    public DateTime? IniciadoEm { get; set; }

    public bool Teste { get; set; }

    public int? RepetirEm { get; set; }

    public DateTime? Recepcao { get; set; }
}
