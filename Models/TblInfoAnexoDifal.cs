using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblInfoAnexoDifal
{
    public int Id { get; set; }

    public string? Uf { get; set; }

    public int? Codloja { get; set; }

    public int? NumeroNfe { get; set; }

    public string? Documento { get; set; }

    public string? Chave { get; set; }

    public string? UsuarioAnexo { get; set; }

    public DateTime? DataUsuarioAnexo { get; set; }

    public string? UsuarioComprovante { get; set; }

    public DateTime? DataUsuarioComprovante { get; set; }

    public string? UsuarioGrav { get; set; }

    public DateTime? DataGrav { get; set; }

    public bool? XmlBaixado { get; set; }

    public bool? DifalAnexado { get; set; }

    public bool? ComprovanteAnexado { get; set; }

    public bool? Finalizado { get; set; }
}
