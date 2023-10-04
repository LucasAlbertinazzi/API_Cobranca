using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Armazena os Produtos da Skyhub e Visualizar se foi gerado na Skyhub
/// </summary>
public partial class EcTblProduto
{
    public int Codigo { get; set; }

    public int? Coddep { get; set; }

    public string? Codproduto { get; set; }

    public string? Descricao { get; set; }

    public int? Grupo { get; set; }

    public int? Codcor { get; set; }

    public int? Codvoltagem { get; set; }

    public string? Tamanho { get; set; }

    public int? Codmarca { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Atualizado { get; set; }

    public int? CodusuarioWeb { get; set; }

    public DateTime? AtualizadoWeb { get; set; }

    public string? CodprodutoGarantia { get; set; }

    public short? Volume { get; set; }

    public char? Ativo { get; set; }

    public bool? CadastroSkyhub { get; set; }

    public string? LinkB2w { get; set; }

    public string? CodB2w { get; set; }

    public bool? CustoAlterado { get; set; }

    public int? UsuarioCiente { get; set; }

    public DateTime? DataCiente { get; set; }

    /// <summary>
    /// observações da tela FrmCalculoPrecoMarketPlace
    /// </summary>
    public string? Observacao { get; set; }
}
