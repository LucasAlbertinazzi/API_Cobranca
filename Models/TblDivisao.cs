using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Codigo da Divisao
/// </summary>
public partial class TblDivisao
{
    /// <summary>
    /// Codigo da Divisao
    /// </summary>
    public long Coddivisao { get; set; }

    /// <summary>
    /// Divisao do Estoque
    /// </summary>
    public string? Divisao { get; set; }

    /// <summary>
    /// Quantidade de Departamentos
    /// 
    /// </summary>
    public long? Quantdeparta { get; set; }

    /// <summary>
    /// Area Ocupada
    /// </summary>
    public decimal? Areaocupada { get; set; }

    /// <summary>
    /// Valor da Area Ocupada
    /// </summary>
    public decimal? Valorarea { get; set; }

    /// <summary>
    /// Quantidade de Pessoas Alocadas
    /// </summary>
    public short? Pessoasaloca { get; set; }

    /// <summary>
    /// Valor da Mão de Obra
    /// </summary>
    public double? Valormaoobra { get; set; }

    /// <summary>
    /// Potencial Eletrico
    /// </summary>
    public float? Poteletrico { get; set; }

    /// <summary>
    /// Valor da Apreciação dos Bens
    /// </summary>
    public float? Valorbens { get; set; }

    /// <summary>
    /// Codigo do usuario que cadastrou ou atualizou a divisao
    /// </summary>
    public short? Codusuario { get; set; }

    /// <summary>
    /// Data e hora da Ultima Atualização
    /// </summary>
    public DateTime? Ultaltera { get; set; }

    /// <summary>
    /// Campo para teste
    /// </summary>
    public decimal? Valor { get; set; }

    public string? Iddivisao { get; set; }

    public bool? Listar { get; set; }

    public virtual ICollection<TblDepartamento> TblDepartamentos { get; set; } = new List<TblDepartamento>();
}
