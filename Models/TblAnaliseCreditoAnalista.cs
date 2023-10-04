using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: COBRANÇA
/// Cadastro de analistas de crédito com suas datas de férias e onde podem ser encontrados.
/// </summary>
public partial class TblAnaliseCreditoAnalista
{
    public long? Codusuario { get; set; }

    public string? Nome { get; set; }

    public int? Ramal { get; set; }

    public string? Celular { get; set; }

    public string? Whatsapp { get; set; }

    public DateTime? FeriasInicio { get; set; }

    public DateTime? FeriasFim { get; set; }

    public TimeOnly? AlmocoInicio { get; set; }

    public TimeOnly? AlmocoFim { get; set; }

    public string? Obs { get; set; }

    public bool? Disponivel { get; set; }

    public bool? Ativo { get; set; }

    public int Codigo { get; set; }
}
