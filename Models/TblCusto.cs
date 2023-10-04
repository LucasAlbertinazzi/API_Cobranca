using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: VENDAS, FINANCEIRO, FISCAL, CONTÁBIL
/// Nesta tabela encontra-se uma série de alíquotas utilizadas na comercialização de produtos, parcelamento, caixa e descontos.
/// Também estão inseridas a comissão de cada divisão, com o nome iniciado em &quot;comi_&quot;
/// </summary>
public partial class TblCusto
{
    public long Codigo { get; set; }

    /// <summary>
    /// Despesa administrativa e Deposito
    /// </summary>
    public float? Despesaadm { get; set; }

    /// <summary>
    /// ICMS
    /// </summary>
    public float? Impostoe { get; set; }

    /// <summary>
    /// PIS E FINSOCIAL
    /// </summary>
    public float? Impostof { get; set; }

    /// <summary>
    /// Desconto Preço a Vista
    /// </summary>
    public float? Desconto { get; set; }

    /// <summary>
    /// Taxa Juro ao Mes
    /// </summary>
    public float? Juromes { get; set; }

    /// <summary>
    /// Comissao Vendedores
    /// </summary>
    public float? Comissaovenda { get; set; }

    /// <summary>
    /// Custo da Frota (Frete Entrega)
    /// </summary>
    public float? Custofrota { get; set; }

    /// <summary>
    /// Inflaçao mensal
    /// </summary>
    public float? Inflacao { get; set; }

    /// <summary>
    /// Juro Cobrado no Financiamento loja
    /// </summary>
    public double? Jurofinanciamento { get; set; }

    /// <summary>
    /// Desconto Maximo Permitido no juro espceial
    /// </summary>
    public double? DescMaxJuroespec { get; set; }

    /// <summary>
    /// Desconto Maximo Permitido para produtos em promoção
    /// </summary>
    public double? DescMaxPromocao { get; set; }

    /// <summary>
    /// Desconto Maximo Permitodo em Produtos no Bota Fora
    /// </summary>
    public double? DescMaxBotafora { get; set; }

    /// <summary>
    /// Desconto Maximo Permitido em Produtos normais 
    /// </summary>
    public double? DescMaxNormal { get; set; }

    /// <summary>
    /// numero maximo de parcelas para finarciamento pela loja
    /// </summary>
    public long? Maxparcela { get; set; }

    /// <summary>
    /// Validade da senha em dias
    /// </summary>
    public short? Validadesenha { get; set; }

    /// <summary>
    /// Carencia permitida no prazo medio 
    /// </summary>
    public short? Carenciapmedio { get; set; }

    /// <summary>
    /// Juro cobrado ao dia quando excede prazo medio da compra
    /// </summary>
    public decimal? Jurodiapmedio { get; set; }

    /// <summary>
    /// Quantidade de dias para conceder desconto no pagamento de conta.
    /// </summary>
    public short? Diasdesconto { get; set; }

    /// <summary>
    /// Quantidade de dias para cobrar
    /// juro, apos ultrapassar esse valor sera cobrado juro nas parcelas.
    /// </summary>
    public short? Diasacrescimo { get; set; }

    /// <summary>
    /// Taxa de juro cobrado no desconto de parcelas quanto pagas com antecedencia
    /// </summary>
    public decimal? Jurodesconto { get; set; }

    /// <summary>
    /// Taxa de juro cobrado quando a atraso do pagamento de parcelas.
    /// </summary>
    public decimal? Juroacrescimo { get; set; }

    /// <summary>
    /// Desconto Permitido em cima do juro cobrado na parcela
    /// </summary>
    public decimal? DescDoacrescimo { get; set; }

    public decimal? ComiEletro { get; set; }

    public decimal? ComiMoveis { get; set; }

    public decimal? ComiPresente { get; set; }

    public decimal? ComiBrinquedo { get; set; }

    /// <summary>
    /// porcentagem de assistencia tecnica
    /// </summary>
    public decimal? Despesaassist { get; set; }

    public decimal? DescDoacrescimoGerente { get; set; }

    public decimal? ComiSeguroGarantia { get; set; }

    public decimal? ComiConstrucao { get; set; }

    public decimal? ComiEcommerce { get; set; }

    public decimal? ComiSeguroAp { get; set; }
}
