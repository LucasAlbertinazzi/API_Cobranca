using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: Fiscal
/// Esta tabela é utilizada no cálculo do difal.
/// reducao_bc = reducao alíquota interestadual para cálculo do difal
/// recucao_bc_difal = reducao alíquota destino para cálculo do difal.
/// 
/// os valores estao em porcentagem.
/// 
/// Contém dados referentes ao NCM, CFOP, FCP e alíquota de impostos internam, interestadual e destino, utilizados no pagamento do Diferencial de Alíquotas (DIFAL) e ICMS; se o produto tem redução na base de cálculo, e ao CST dos produtos.
/// 
/// O NCMs (Nomenclatura Comum do Mercosul): Convenção entre os países membros do Mercosul para reconhecer facilmente os bens, serviços e fatores produtivos negociados entre si. Com o alinhamento da obrigatoriedade de emissão de NF-e (Nota Fiscal eletrônica) e a possível validação de dados pelas SEFAZ, não demorou para o governo obrigar essa nomenclatura nos cadastros de produtos.
/// O NCM é composto de 8 dígitos:
/// -Os dois primeiros dígitos ditam a característica de cada produto
/// -O terceiro e o quarto dígito dita um desdobramento da característica de um produto
/// -O quinto e sexto dígitos ditam mais uma subcategoria de produto
/// -O sétimo dígito dita uma classificação do produto
/// -O oitavo dígito dita o subitem, com a descrição mais detalhada de uma mercadoria
/// 
/// CFOP - Código Fiscal de Operações e prestações. Descrição detalhada no site https://www.sitecontabil.com.br/tabelas/cfop/pag_um.html
/// 
/// FCP - Fundo de combate à pobreza.
/// 
/// CST - Código de Situação Tributária: É um código de três dígitos que determina a tributação referente ao ICMS do produto, onde são classificados, unindo 1 dígito da tabela A com 2 dígitos da tabela B. 
/// TABELA A: 0-Nacional, 1-Importação Direta, 2-Estrangeira Adquirida no Mercado Interno.
/// TABELA B: 00 Tributada integralmente, 10 Tributada e com cobrança do ICMS por substituição tributária, 20 Com redução de base de cálculo, 30 Isenta ou não tributada e com cobrança do ICMS por substituição tributária, 40 Isenta, 41 Não tributada, 50 Suspensão, 51 Diferimento, 60 ICMS cobrado anteriormente por substituição tributária, 70 Com redução de base de cálculo e cobrança do ICMS por substituição tributária, 90 Outras.&quot;
/// 
/// </summary>
public partial class TblProdutoAlqNcm
{
    public int Id { get; set; }

    public string? Ncm { get; set; }

    public int? CodUf { get; set; }

    public string? Cfop { get; set; }

    public decimal? Fcp { get; set; }

    public decimal? AliqIcmsInterna { get; set; }

    public decimal? AliqIcmsInter { get; set; }

    public decimal? AliqIcmsDestino { get; set; }

    public decimal? ReducaoBc { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Data { get; set; }

    public string? Obs { get; set; }

    public decimal? ReducaoBcDifal { get; set; }

    public string? Codproduto { get; set; }

    public string? Cst { get; set; }

    public virtual TblUf? CodUfNavigation { get; set; }
}
