using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblCliente
{
    public int Codcliente { get; set; }

    public string? Nome { get; set; }

    public DateTime? Datacadastro { get; set; }

    public string? Cpf { get; set; }

    public string? Rg { get; set; }

    public string? Inscest { get; set; }

    public string? Cnpj { get; set; }

    public string? Oe { get; set; }

    public string? Naturalidade { get; set; }

    public string? Pai { get; set; }

    public string? Mae { get; set; }

    public DateOnly? Nascimento { get; set; }

    public string? Ctps { get; set; }

    public string? Serie { get; set; }

    public string? Estadocivil { get; set; }

    public string? Endereco { get; set; }

    public string? Bairro { get; set; }

    public string? Cidade { get; set; }

    public string? Uf { get; set; }

    public string? Cep { get; set; }

    public string? Tiporesid { get; set; }

    public string? Temporesid { get; set; }

    public string? Fone { get; set; }

    public string? Tipofone { get; set; }

    public string? Email { get; set; }

    public string? Empresa { get; set; }

    public DateOnly? Admissao { get; set; }

    public string? EmpEndereco { get; set; }

    public string? EmpBairro { get; set; }

    public string? EmpCidade { get; set; }

    public string? EmpUf { get; set; }

    public string? EmpCep { get; set; }

    public string? Cargo { get; set; }

    public string? EmpFone { get; set; }

    public string? Confirmadocom { get; set; }

    public string? Celular { get; set; }

    public string? Conjuge { get; set; }

    public DateOnly? ConjNascimento { get; set; }

    public string? ConjCpf { get; set; }

    public string? ConjRg { get; set; }

    public string? ConjOe { get; set; }

    public string? ConjNaturalidade { get; set; }

    public string? ConjPai { get; set; }

    public string? ConjMae { get; set; }

    public string? ConjEmpresa { get; set; }

    public DateOnly? ConjAdmissao { get; set; }

    public string? ConjEmpEndereco { get; set; }

    public string? ConjEmpBairro { get; set; }

    public string? ConjEmpCidade { get; set; }

    public string? ConjEmpUf { get; set; }

    public string? ConjEmpCep { get; set; }

    public string? ConjCargo { get; set; }

    public decimal? ConjRendaliquida { get; set; }

    public string? ConjEmpFone { get; set; }

    public string? ConjConfirmadocom { get; set; }

    public string? ConjCelular { get; set; }

    public int? Codfiador { get; set; }

    public string? Classe { get; set; }

    public decimal? Limitecredito { get; set; }

    public DateTime? Atualizado { get; set; }

    public DateTime? Dataaprovacao { get; set; }

    public string? Observacao { get; set; }

    public string? Situacao { get; set; }

    public string? Vip { get; set; }

    public long Codusuario { get; set; }

    public decimal? Rendaliquida { get; set; }

    /// <summary>
    /// quem aprovou o cadastro
    /// </summary>
    public string? Aprovadopor { get; set; }

    /// <summary>
    /// Tipo de cadastro pessoua Fisica ou Juridica
    /// </summary>
    public char? Tipocadastro { get; set; }

    /// <summary>
    /// data da ultima consulta ao SPC Serara
    /// </summary>
    public DateTime? Consspc { get; set; }

    /// <summary>
    /// se titular esta negativado spc serasa
    /// </summary>
    public char? Negativado { get; set; }

    /// <summary>
    /// ultima consulta spc conjuge
    /// </summary>
    public DateTime? ConjConsspc { get; set; }

    /// <summary>
    /// se conjuge esta negativado spc serasa
    /// </summary>
    public char? ConjNegativado { get; set; }

    /// <summary>
    /// primeira data de aprovação do clietne
    /// </summary>
    public DateTime? PriAprovacao { get; set; }

    /// <summary>
    /// usuario que aprovou o cadastro pela primeira vez
    /// </summary>
    public string? PriUsuario { get; set; }

    /// <summary>
    /// primeira situação do cliente se ele foi aprovado ou negado
    /// </summary>
    public string? PriSituacao { get; set; }

    /// <summary>
    /// SE O TITULAR FOI NEGATIVADO
    /// </summary>
    public char? ClienteSpc { get; set; }

    /// <summary>
    /// Promessa de pagamento
    /// </summary>
    public DateOnly? Pgtopara { get; set; }

    public char? Pricontato { get; set; }

    public char? Segcontato { get; set; }

    public DateOnly? Agendacobranca { get; set; }

    /// <summary>
    /// Carta 1
    /// </summary>
    public char? Carta1 { get; set; }

    /// <summary>
    /// Carta 2
    /// </summary>
    public char? Carta2 { get; set; }

    /// <summary>
    /// carta 3
    /// </summary>
    public char? Carta3 { get; set; }

    /// <summary>
    /// Carta 4
    /// </summary>
    public char? Carta4 { get; set; }

    /// <summary>
    /// carta 5
    /// </summary>
    public char? Carta5 { get; set; }

    public char? Protesto { get; set; }

    public char? Cadassinado { get; set; }

    /// <summary>
    /// tipo de profissao do titular
    /// </summary>
    public string? Tipoemprego { get; set; }

    /// <summary>
    /// tipo de profissao do conjuge
    /// 
    /// </summary>
    public string? Tipoempregoconj { get; set; }

    public decimal? Rendaadd { get; set; }

    /// <summary>
    /// Renda Adicional autorizada
    /// </summary>
    public decimal? RendaaddAutor { get; set; }

    /// <summary>
    /// usuario que autorizou renda adicional
    /// </summary>
    public string? Userrendaadd { get; set; }

    /// <summary>
    /// Origem da renda Add
    /// </summary>
    public string? Origemrendaadd { get; set; }

    public string? Tiporendaadd { get; set; }

    /// <summary>
    /// Rota de cobrança
    /// </summary>
    public int? Rotacobranca { get; set; }

    public char? Reaprovar { get; set; }

    /// <summary>
    /// dados da conferencia da reaprovação do cadastro
    /// </summary>
    public string? Confreaprovacao { get; set; }

    public string? Obsreaprovar { get; set; }

    /// <summary>
    /// contato apos quitada as parcelas
    /// s/n
    /// </summary>
    public string? ContatoQuitado { get; set; }

    /// <summary>
    /// observações do contato apos quitado as parcelas
    /// </summary>
    public string? ObsQuitado { get; set; }

    public DateTime? DatacontatoQuitado { get; set; }

    public char? ConjugeSpc { get; set; }

    public string? EnderecoC { get; set; }

    public string? BairroC { get; set; }

    public string? CidadeC { get; set; }

    public string? UfC { get; set; }

    public string? CepC { get; set; }

    public char? MesmoEnd { get; set; }

    public string? Beneficio { get; set; }

    public DateOnly? Expedicaorg { get; set; }

    public DateOnly? Temporeside { get; set; }

    public string? Obs2 { get; set; }

    public int? Contatoniver { get; set; }

    public DateTime? Datacontatoniver { get; set; }

    public string? ConjBeneficio { get; set; }

    public int? Codbairro { get; set; }

    public int? EmpreCodbairro { get; set; }

    public int? CodbairroC { get; set; }

    public int? Codcidade { get; set; }

    /// <summary>
    /// 
    /// 
    /// </summary>
    public int? EmpreCodcidade { get; set; }

    public int? CodcidadeC { get; set; }

    public string? EnderecoNum { get; set; }

    public string? EmpreEnderecoNum { get; set; }

    public string? EnderecoNumC { get; set; }

    public string? EnderecoNumEmpConj { get; set; }

    public int? CodbairroEmpConj { get; set; }

    public int? CodcidadeEmpConj { get; set; }

    public string? ComplemEnd { get; set; }

    public string? RecadoCom { get; set; }

    public char? Carta22 { get; set; }

    public char? Carta23 { get; set; }

    public string? Genero { get; set; }

    public bool? CadEmp { get; set; }

    public virtual ICollection<TblClasseHist> TblClasseHists { get; set; } = new List<TblClasseHist>();

    public virtual ICollection<TblHistoricoreneg> TblHistoricorenegs { get; set; } = new List<TblHistoricoreneg>();

    public virtual ICollection<TblHistoricospc> TblHistoricospcs { get; set; } = new List<TblHistoricospc>();

    public virtual ICollection<TblHistprotesto> TblHistprotestos { get; set; } = new List<TblHistprotesto>();

    public virtual ICollection<TblHistvencimento> TblHistvencimentos { get; set; } = new List<TblHistvencimento>();

    public virtual ICollection<TblPrePedido> TblPrePedidos { get; set; } = new List<TblPrePedido>();

    public virtual ICollection<TblTerceiro> TblTerceiros { get; set; } = new List<TblTerceiro>();
}
