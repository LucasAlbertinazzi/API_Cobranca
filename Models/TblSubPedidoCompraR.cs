using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Produtos Recebidos 
/// </summary>
public partial class TblSubPedidoCompraR
{
    /// <summary>
    /// Codigo da Operação
    /// </summary>
    public long Codigo { get; set; }

    /// <summary>
    /// Codigo do Prduto Recebido
    /// </summary>
    public string? Codproduto { get; set; }

    /// <summary>
    /// Quantidade de Produtos Entregue
    /// </summary>
    public long? Quantidade { get; set; }

    /// <summary>
    /// Valor unitario
    /// </summary>
    public double? Vlrunitario { get; set; }

    /// <summary>
    /// Valor Total do Produto
    /// </summary>
    public double? Vlrtotal { get; set; }

    /// <summary>
    /// Codigo do Recebimento
    /// </summary>
    public long? Codrecebimento { get; set; }

    public long? Coddelete { get; set; }

    /// <summary>
    /// Produto ja incluso no estoque
    /// </summary>
    public char? Situacao { get; set; }

    /// <summary>
    /// frete do Produto
    /// </summary>
    public double? Fretecif { get; set; }

    /// <summary>
    /// Frete do Produto
    /// </summary>
    public double? Fretefob { get; set; }

    /// <summary>
    /// IPI da mercadoria recebida
    /// </summary>
    public double? Ipi { get; set; }

    /// <summary>
    /// Valor da mercadoria sem ipi
    /// </summary>
    public double? VlrSemIpi { get; set; }

    /// <summary>
    /// Incluso no sistema ?
    /// </summary>
    public char? Incluso { get; set; }

    public DateTime? Datainclusao { get; set; }

    /// <summary>
    /// Codigo do usuario
    /// </summary>
    public long? Codusuario { get; set; }

    public long? Codpedidocompra { get; set; }

    public string? Documento { get; set; }

    public string? FornecedorExcluirColuna { get; set; }

    public decimal? Margemlucro { get; set; }

    public int? Estoqueanterior { get; set; }

    public int? Grupo { get; set; }

    /// <summary>
    /// Despesa de assistencia tecnica
    /// </summary>
    public decimal? Despesaassist { get; set; }

    public decimal? Verbaassist { get; set; }

    public int? Fornecedor { get; set; }

    public string? Descricao { get; set; }

    public int? Codentrada { get; set; }

    public virtual TblFornecedor? FornecedorNavigation { get; set; }
}
