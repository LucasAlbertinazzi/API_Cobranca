using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: TI
/// Contém o IP de ativos que possuem IPs, como computadores de usuário, switchs e servidores.
/// 
/// </summary>
public partial class TblAtivoIp
{
    public int Codigo { get; set; }

    public int? Codativo { get; set; }

    public string? Interface { get; set; }

    public string? Ip { get; set; }

    public string? Mascara { get; set; }

    public string? Gw { get; set; }

    public string? Dns1 { get; set; }

    public string? Dns2 { get; set; }

    public bool? Ipprincipal { get; set; }

    public virtual TblAtivo? CodativoNavigation { get; set; }
}
