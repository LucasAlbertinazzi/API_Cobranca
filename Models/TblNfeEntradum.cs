using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblNfeEntradum
{
    public int Codigo { get; set; }

    public int? Codloja { get; set; }

    public string? Chaveacesso { get; set; }

    public string? Ecnpj { get; set; }

    public DateOnly? Emissao { get; set; }

    public DateTime? Recebimento { get; set; }

    public int? Userrec { get; set; }

    public string? Lancamento { get; set; }

    public int? Userlanc { get; set; }

    public string Xml { get; set; } = null!;

    public string? Emitente { get; set; }

    public long? Nfe { get; set; }

    public DateTime DataCadastro { get; set; }

    public int UsuarioIncXml { get; set; }
}
