using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Imprime cartaz de preço
/// coluna fixar
/// C1,C2,C3,C4,C5 - cartazes de preço
/// D2,D3,D4 - display 
/// S2,S3,S4 - tipos de saquinho
/// BA - Barbante
/// DF - Dupla face
/// DU - Durex
/// 
/// </summary>
public partial class TblCartazPreco
{
    public int Codigo { get; set; }

    public string? Codproduto { get; set; }

    public int? Codloja { get; set; }

    public decimal? Avista { get; set; }

    public string? Forma { get; set; }

    public decimal? Valorparcelas { get; set; }

    public string? Juro { get; set; }

    public DateTime? Dataimpre { get; set; }

    public char? Confirmado { get; set; }

    public int? Grupo { get; set; }

    public char? Tamanho { get; set; }

    public string? Fixar { get; set; }

    public int? Impressopor { get; set; }

    public int? Recebidopor { get; set; }

    public int? Etiqueta { get; set; }

    public DateTime? Datarecebido { get; set; }

    public DateTime? Geradoem { get; set; }

    public int? Geradopor { get; set; }

    public string? Usuario { get; set; }

    public int? Quantproduto { get; set; }

    public string? Obs { get; set; }

    public string? Cartao { get; set; }

    public string? Valorcartao { get; set; }

    public DateOnly? PrazoReceber { get; set; }

    public bool SemJuros { get; set; }
}
