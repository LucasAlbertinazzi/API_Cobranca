using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblFornecedor
{
    public int Codfornecedor { get; set; }

    /// <summary>
    /// Razao Social da Empresa
    /// </summary>
    public string? Fornecedor { get; set; }

    /// <summary>
    /// Nome Fantasia da Empresa
    /// </summary>
    public string? Nomefantasia { get; set; }

    /// <summary>
    /// Endereço
    /// </summary>
    public string? Endereco { get; set; }

    public string? Bairro { get; set; }

    public string? Municipio { get; set; }

    /// <summary>
    /// Numero do Fax
    /// </summary>
    public string? Fax { get; set; }

    public string? Email { get; set; }

    /// <summary>
    /// Home Page da Empresa
    /// </summary>
    public string? Site { get; set; }

    /// <summary>
    /// Pessoa de Contato
    /// </summary>
    public string? Contato { get; set; }

    public string? Cnpj { get; set; }

    /// <summary>
    /// Inscrição Estadual
    /// </summary>
    public string? Inscest { get; set; }

    /// <summary>
    /// Inscrição Municipal
    /// </summary>
    public string? Inscmunic { get; set; }

    /// <summary>
    /// Nome da Agencia Bancaria
    /// </summary>
    public string? Agencia { get; set; }

    /// <summary>
    /// Numero do Banco
    /// </summary>
    public string? Nbanco { get; set; }

    /// <summary>
    /// Numero da Agencia
    /// </summary>
    public string? Nagencia { get; set; }

    /// <summary>
    /// Numero da Conta 
    /// </summary>
    public string? Nconta { get; set; }

    /// <summary>
    /// Nome do Banco
    /// </summary>
    public string? Agencia1 { get; set; }

    /// <summary>
    /// Numero do Banco
    /// </summary>
    public string? Nbanco1 { get; set; }

    /// <summary>
    /// Numero da Agencia
    /// </summary>
    public string? Nagencia1 { get; set; }

    /// <summary>
    /// Numero da Conta Bancaria
    /// </summary>
    public string? Nconta1 { get; set; }

    public string? Uf { get; set; }

    public string? Pais { get; set; }

    public string? Fone { get; set; }

    /// <summary>
    /// Observações Complementares
    /// </summary>
    public string? Obs { get; set; }

    /// <summary>
    /// Data do Cadastro
    /// </summary>
    public DateTime? Datacadastro { get; set; }

    /// <summary>
    /// Data Atualização
    /// </summary>
    public DateTime? Atualizado { get; set; }

    /// <summary>
    /// Codigo do Usuario
    /// </summary>
    public int? Codusuario { get; set; }

    public string? Cep { get; set; }

    public decimal? Codmunicipio { get; set; }

    public string? Complemento { get; set; }

    public decimal? Codpais { get; set; }

    public string? Cnae { get; set; }

    public string? Crt { get; set; }

    public string? Endnumero { get; set; }

    public char? Ativo { get; set; }

    public int? Idgrupo { get; set; }

    public long? CodContaDominio { get; set; }

    public long EmitIeSt { get; set; }

    public virtual TblUsuario? CodusuarioNavigation { get; set; }

    public virtual ICollection<TblPedidoCompra> TblPedidoCompras { get; set; } = new List<TblPedidoCompra>();

    public virtual ICollection<TblSubPedidoCompraR> TblSubPedidoCompraRs { get; set; } = new List<TblSubPedidoCompraR>();
}
