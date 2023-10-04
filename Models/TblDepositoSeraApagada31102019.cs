using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblDepositoSeraApagada31102019
{
    /// <summary>
    /// Codigo do Deposito
    /// </summary>
    public int Coddeposito { get; set; }

    /// <summary>
    /// Descrição do Deposito
    /// </summary>
    public string? Deposito { get; set; }

    /// <summary>
    /// Endereço de Localização do Deposito
    /// </summary>
    public string? Endereco { get; set; }

    /// <summary>
    /// Bairro do Deposito
    /// </summary>
    public string? Bairro { get; set; }

    public string? Cidade { get; set; }

    public string? Cep { get; set; }

    public string? Uf { get; set; }

    public string? Fone { get; set; }

    public string? Observacao { get; set; }

    /// <summary>
    /// Area Ocupada em m2
    /// 
    /// </summary>
    public short? Areaocupada { get; set; }

    /// <summary>
    /// Valor da Area Ocupada
    /// </summary>
    public float? Vlrarea { get; set; }

    /// <summary>
    /// Valor da Energia Eletrica
    /// </summary>
    public float? Vlrenergia { get; set; }

    /// <summary>
    /// Valor da Apreciação mensal dos bens
    /// 
    /// </summary>
    public float? Vlrbens { get; set; }

    /// <summary>
    /// Quantidade de Pessoas Alocadas
    /// </summary>
    public short? Pessalocada { get; set; }

    /// <summary>
    /// Valor da Mão de Obra
    /// </summary>
    public float? Vlrmaoobra { get; set; }

    /// <summary>
    /// Somar produto ao estoque total
    /// </summary>
    public char? Somarestoque { get; set; }

    /// <summary>
    /// Seleciona se imprime os cartazes de preço ou etiquetas.
    /// </summary>
    public char? ImpPreco { get; set; }

    public string? Cnpj { get; set; }

    public string? Insc { get; set; }

    public virtual ICollection<TblSubPedidoOrc> TblSubPedidoOrcs { get; set; } = new List<TblSubPedidoOrc>();
}
