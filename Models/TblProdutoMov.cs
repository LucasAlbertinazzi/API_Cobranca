using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: PRODUTOS, PEDIDO
/// Movimentação de produtos. As telas FrmExtratoProdLoja e FrmExtratoProduto contém os registros desta tabela para um determinado produto e determinada loja. A FrmEntradaPedidoEcommerce exclui registros desta tabela quando um pedido não tem o pagamento confirmado ou é cancelado. Quando um pedido é cancelado pela FrmCancelarPedido, são gravados novos registros, assim como na geração de pedido, venda para cliente e entrada de fornecedor.
/// 
/// 
/// </summary>
public partial class TblProdutoMov
{
    public int Codigo { get; set; }

    public string? Codproduto { get; set; }

    /// <summary>
    /// Data do movimento
    /// </summary>
    public DateTime? Data { get; set; }

    public string? Descricao { get; set; }

    public string? Documento { get; set; }

    /// <summary>
    /// local da entrada ou saida do produto
    /// </summary>
    public int? Local { get; set; }

    /// <summary>
    /// valor de compra ou de venda
    /// </summary>
    public decimal? Valor { get; set; }

    public int? Entrada { get; set; }

    public int? Saida { get; set; }

    /// <summary>
    /// custo medio mercadoria
    /// </summary>
    public decimal? Customedio { get; set; }

    /// <summary>
    /// Valor da entrada
    /// </summary>
    public decimal? Ventrada { get; set; }

    /// <summary>
    /// Valor da saida
    /// </summary>
    public decimal? Vsaida { get; set; }

    public int? Saldo { get; set; }

    public char? Venda { get; set; }

    public int? Saldolocal { get; set; }

    public string? Coddivisao { get; set; }

    public string? Coddepartamento { get; set; }

    public int? Estoqueantes { get; set; }

    /// <summary>
    /// estoque que restou no local da baixa
    /// </summary>
    public int? RestouLocal { get; set; }
}
