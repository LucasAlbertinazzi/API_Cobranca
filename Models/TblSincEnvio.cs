using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSincEnvio
{
    public int Id { get; set; }

    public string Numnota { get; set; } = null!;

    public string Serie { get; set; } = null!;

    public string Emitente { get; set; } = null!;

    public int Tipo { get; set; }

    public DateTime Data { get; set; }

    public int Codusuario { get; set; }

    public string? MensagemErro { get; set; }

    public bool Teste { get; set; }

    public string? Chave { get; set; }
}
