using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblPrePedido
{
    /// <summary>
    /// Codigo do Pré Pedido
    /// </summary>
    public int Codprepedido { get; set; }

    public int? Codcliente { get; set; }

    public DateOnly? Datavenda { get; set; }

    public string? Comprador { get; set; }

    public decimal? Totalproduto { get; set; }

    public decimal? Desconto { get; set; }

    public decimal? Acrescimo { get; set; }

    public decimal? Totalvenda { get; set; }

    public char? Pedidofechado { get; set; }

    public int? Codusuario { get; set; }

    public int? Codloja { get; set; }

    public TimeOnly? Hora { get; set; }

    public short? Taxa { get; set; }

    /// <summary>
    /// Quantidade de Parcelas
    /// </summary>
    public short? Parcelas { get; set; }

    public short? Ocorrencia { get; set; }

    /// <summary>
    /// Acrescimo Prazo medio
    /// </summary>
    public decimal? Acrescimopmedio { get; set; }

    public decimal? Totalpagar { get; set; }

    /// <summary>
    /// Tipo de Venda - Crediario Loja Cartão ou Financeira
    /// </summary>
    public int? Tipovenda { get; set; }

    /// <summary>
    /// Pedido confirmado ou não
    /// </summary>
    public char? Impresso { get; set; }

    /// <summary>
    /// Letra do Caixa que imprimiu
    /// </summary>
    public char? Letracaixa { get; set; }

    public int? Codusuariocaixa { get; set; }

    /// <summary>
    /// Se cadastro estiver negado e pedido não for a vista
    /// </summary>
    public char? Negado { get; set; }

    /// <summary>
    /// Se desconto for maior do que o permitido
    /// </summary>
    public short? OcorrDesc { get; set; }

    /// <summary>
    /// Quem forneceu senha 1
    /// </summary>
    public string? Senha1 { get; set; }

    public DateTime? Horasenha1 { get; set; }

    public string? Senha2 { get; set; }

    public DateTime? Horasenha2 { get; set; }

    public string? Senha3 { get; set; }

    public DateTime? Horasenha3 { get; set; }

    public string? Senha1obs { get; set; }

    public string? Senha2obs { get; set; }

    public string? Senha3obs { get; set; }

    /// <summary>
    /// se o cadastro esta aprovado ou não
    /// </summary>
    public char? Aprovado { get; set; }

    /// <summary>
    /// codigo do pedido cancelado que gerou esse novo pedido
    /// </summary>
    public string? Codpedidocancelado { get; set; }

    public int? Senhamaster { get; set; }

    /// <summary>
    /// ganho obtido a mais no pedido entre diferenças de taxas
    /// </summary>
    public decimal? Ganho { get; set; }

    public decimal? Descmax { get; set; }

    public decimal? Descnormal { get; set; }

    public decimal? Descprazomedio { get; set; }

    public int? Prazopermitido { get; set; }

    public int? Diasexcedido { get; set; }

    public decimal? Valorcorreto { get; set; }

    public string? Cliente { get; set; }

    public string? Cpf { get; set; }

    public string? Rg { get; set; }

    public string? Fone { get; set; }

    public string? Endereco { get; set; }

    public string? Cidade { get; set; }

    public string? Bairro { get; set; }

    /// <summary>
    /// T = TITULAR
    /// C = CONJUGE
    /// </summary>
    public char? Tipocomprador { get; set; }

    public char? Cancelamento { get; set; }

    public int? Tipocancelamento { get; set; }

    public int? Senhacancel { get; set; }

    public string? Usersenhacancel { get; set; }

    public string? Obssenhacancel { get; set; }

    public DateTime? Dataabertura { get; set; }

    public char? Utilizarcheque { get; set; }

    public int? UsuarioCancel { get; set; }

    public int? Codbairro { get; set; }

    public int? Codcidade { get; set; }

    public string? Numero { get; set; }

    public string? Uf { get; set; }

    public string? Email { get; set; }

    public string? Cep { get; set; }

    public char? Tipocadastro { get; set; }

    public string? InfAddNfe { get; set; }

    public int? Senhacancelassit { get; set; }

    public string? Obssenhacancelassit { get; set; }

    public int? Usersenhacancelassit { get; set; }

    public short? BandeiraCartao { get; set; }

    /// <summary>
    /// solicitar contrato de venda
    /// 
    /// N - não nescessario.
    /// S - solicitar contrato
    /// I - contrato ja impresso.
    /// </summary>
    public char? SolContrato { get; set; }

    public long? NContrato { get; set; }

    public long? NContratoDigitado { get; set; }

    public decimal? ValorFrete { get; set; }

    public string? PesquisaPublicidadecliente { get; set; }

    /// <summary>
    /// boolean para verificar se o prepedido é de uma venda e-commerce realizada manualmente.
    /// </summary>
    public bool VendaEcManual { get; set; }

    public bool? Indenizacao { get; set; }

    public virtual TblCliente? CodclienteNavigation { get; set; }

    public virtual TblLoja? CodlojaNavigation { get; set; }

    public virtual TblUsuario? CodusuarioNavigation { get; set; }

    public virtual ICollection<TblOcorrencium> TblOcorrencia { get; set; } = new List<TblOcorrencium>();

    public virtual ICollection<TblPedidoPrazoApagar> TblPedidoPrazoApagars { get; set; } = new List<TblPedidoPrazoApagar>();

    public virtual TblTipoVendum? TipovendaNavigation { get; set; }
}
