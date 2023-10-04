using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblJornalPronto
{
    public int Codigo { get; set; }

    public string? Nomeproduto { get; set; }

    public string? Descricao { get; set; }

    public string? Cordisponivel { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Data { get; set; }

    public decimal? Avista { get; set; }

    public string? Parc1 { get; set; }

    public decimal? Valorparc1 { get; set; }

    public decimal? Totalparc1 { get; set; }

    public string? Parc2 { get; set; }

    public decimal? Valorparc2 { get; set; }

    public decimal? Totalparc2 { get; set; }

    public string? Obsgeral { get; set; }

    public int? Codjornal { get; set; }

    public string? Precosistema { get; set; }

    /// <summary>
    /// exibir parcelas da financeira? S/N
    /// </summary>
    public char? Financeira { get; set; }

    /// <summary>
    /// Aplicar juro em todas as condições? s/n
    /// </summary>
    public char? Juroemtodas { get; set; }

    public int? Divisao { get; set; }

    public decimal? Custo { get; set; }

    public decimal? Margem { get; set; }

    public decimal? Vendat1 { get; set; }

    public decimal? Juro { get; set; }

    public char? Jurotodas { get; set; }

    public decimal? Margemnormal { get; set; }

    public int? Pagina { get; set; }

    public int? Foto { get; set; }

    public char? Semjuros { get; set; }

    public char? Semjuroscartao { get; set; }

    public int? Taxa { get; set; }

    public short? TaxaDoDepartamento { get; set; }
}
