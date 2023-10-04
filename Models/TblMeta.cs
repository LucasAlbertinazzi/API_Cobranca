using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: VENDAS
/// Registro das metas mensais dos vendedores das lojas, por divisão.
/// 
/// Obs.:As colunas PLAN1, ATE1, PLAN2, ATE2 são obsoletas. Elas eram utilizadas na época em que vendíamos móveis planejados, quando as comissões eram variáveis por total vendido.
/// </summary>
public partial class TblMeta
{
    public int Codigo { get; set; }

    public decimal? Eletro { get; set; }

    public decimal? Moveis { get; set; }

    public decimal? Presentes { get; set; }

    public decimal? Brinquedos { get; set; }

    public decimal? Cartao { get; set; }

    public decimal? Financeira { get; set; }

    public decimal? Deppresentes { get; set; }

    public DateOnly? Mes { get; set; }

    public int? Codloja { get; set; }

    public decimal? Premioeletro { get; set; }

    public decimal? Premiomoveis { get; set; }

    public decimal? Premiobrinquedos { get; set; }

    public decimal? Premiofinanceira { get; set; }

    public decimal? Premiopresente { get; set; }

    public decimal? Celular { get; set; }

    public decimal? Premiocelular { get; set; }

    public decimal? Ate1 { get; set; }

    public decimal? Plan2 { get; set; }

    public decimal? Ate2 { get; set; }

    public decimal? Plan3 { get; set; }

    public decimal? Ate3 { get; set; }

    public decimal? Plan4 { get; set; }

    public decimal? Ate4 { get; set; }

    public decimal? Cancelar { get; set; }

    public decimal? Multacancel { get; set; }

    public string? Usercelular { get; set; }

    public string? Userplanejado { get; set; }

    public decimal? Notarotina { get; set; }

    public decimal? PremioSeguroGarantia { get; set; }

    public decimal? SeguroGarantia { get; set; }

    public decimal? MetaVendas { get; set; }

    public decimal? ConstrucaoCivil { get; set; }

    public decimal? PremioconstrucaoCivil { get; set; }

    public decimal? Plan1 { get; set; }

    public decimal? SeguroSabemi { get; set; }

    public decimal? PremioSeguroSabemi { get; set; }
}
