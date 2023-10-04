using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblHistoricoassist
{
    public int Codigo { get; set; }

    public int Codassistencia { get; set; }

    public DateTime? Data { get; set; }

    public string? Informante { get; set; }

    public string? Situacao { get; set; }

    public int Codusuario { get; set; }

    /// <summary>
    /// tipo &apos;C&apos; Cliente ou &apos;A&apos; Assistencia
    /// </summary>
    public char? Tipo { get; set; }

    public string? Telefone { get; set; }
}
