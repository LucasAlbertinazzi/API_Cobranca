using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Romaneio dos produtos que o cliente leva na hora da compra
/// </summary>
public partial class TblRomaneioLoja
{
    public long Codigo { get; set; }

    public string? Pedido { get; set; }

    public DateTime? Datapedido { get; set; }

    public string? Codproduto { get; set; }

    public string? Codfabrica { get; set; }

    public string? Descricao { get; set; }

    public int? Quantidade { get; set; }

    public int? Codcliente { get; set; }

    public int? Origem { get; set; }

    public int? Estoqueanterior { get; set; }

    public int? Codusuario { get; set; }

    public string? Cliente { get; set; }

    public char? Confirmado { get; set; }

    public DateTime? Dataentrega { get; set; }

    public string? Retiradopor { get; set; }

    public string? Entreguepor { get; set; }

    public char? Entregue { get; set; }

    /// <summary>
    /// se pedido foi cancelado
    /// </summary>
    public char? Cancelado { get; set; }

    public int? Codveiculo { get; set; }

    public string? Veiculo { get; set; }

    public string? Cidade { get; set; }

    public string? Bairro { get; set; }

    public string? Endereco { get; set; }

    public string? Fone { get; set; }

    public string? Obs { get; set; }

    public char? Entregar { get; set; }

    public int? Conferido { get; set; }

    public DateTime? Dataconferido { get; set; }

    public char? Reagendou { get; set; }
}
