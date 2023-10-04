using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: Fiscal e Pedido
/// Contém os dados dos cupons fiscais emitidos durante o processo de emissão de pedido.
/// 
/// </summary>
public partial class TblNfce
{
    public long Id { get; set; }

    public short? Codloja { get; set; }

    public int? Numnota { get; set; }

    public int? Codnota { get; set; }

    public char? Situacao { get; set; }

    public string? CstatEnvio { get; set; }

    public string? ProtEnvio { get; set; }

    public string? Documento { get; set; }

    public string? CstatRetorno { get; set; }

    public string? Xmotivo { get; set; }

    public int? UserEnvio { get; set; }

    public int? UserRetorno { get; set; }

    public short? ImpDanfe { get; set; }

    public DateTime? DhEnvio { get; set; }

    public DateTime? DhRetorno { get; set; }

    public string? NfceXml { get; set; }

    public string? Chave { get; set; }

    public int? Serie { get; set; }
}
