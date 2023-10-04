using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblUsuario
{
    public int Codusuario { get; set; }

    public string? Usuario { get; set; }

    /// <summary>
    /// Codigo da Filial que pertence o usuario
    /// </summary>
    public int? Codloja { get; set; }

    /// <summary>
    /// Alterar senha
    /// </summary>
    public char? Alterasenha { get; set; }

    /// <summary>
    /// Data da criação do usuario
    /// </summary>
    public DateTime? Datacadastro { get; set; }

    public char? Ativo { get; set; }

    public string? Login { get; set; }

    public string? Cpf { get; set; }

    public char? Admin { get; set; }

    /// <summary>
    /// nivel do usurio para acessar sistema
    /// </summary>
    public int? NivelsistemaOld { get; set; }

    /// <summary>
    /// ultima alteração senha
    /// </summary>
    public DateOnly? Ultimasenha { get; set; }

    /// <summary>
    /// Nivel de senha da assistencia tecnica
    /// valor 1 administrador
    /// valor 2 restrito
    /// </summary>
    public int? Nivelassistencia { get; set; }

    public int? Codfuncao { get; set; }

    public DateTime? Ultimologin { get; set; }

    public string? Password { get; set; }

    public char? Bloqueado { get; set; }

    public DateOnly? LiberadoAte { get; set; }

    public char? Contagem { get; set; }

    public int? Ramal { get; set; }

    public string? Email { get; set; }

    public string? Skin { get; set; }

    public decimal? VersaoSistema { get; set; }

    public short? Nivelsist { get; set; }

    public string? Apelido { get; set; }

    public string? EMail1 { get; set; }

    public int? CriadoPor { get; set; }

    public int Coddep { get; set; }

    public int? Perfilcopy { get; set; }

    public DateOnly? Nascimentouser { get; set; }

    public virtual TblFuncao? CodfuncaoNavigation { get; set; }

    public virtual TblLoja? CodlojaNavigation { get; set; }

    public virtual ICollection<TblAgendaEspecf> TblAgendaEspecfs { get; set; } = new List<TblAgendaEspecf>();

    public virtual ICollection<TblAssistencium> TblAssistencia { get; set; } = new List<TblAssistencium>();

    public virtual ICollection<TblAtivoHistorico> TblAtivoHistoricos { get; set; } = new List<TblAtivoHistorico>();

    public virtual ICollection<TblAtivo> TblAtivos { get; set; } = new List<TblAtivo>();

    public virtual ICollection<TblClasseHist> TblClasseHists { get; set; } = new List<TblClasseHist>();

    public virtual ICollection<TblFornecedor> TblFornecedors { get; set; } = new List<TblFornecedor>();

    public virtual ICollection<TblHistoricoreneg> TblHistoricorenegs { get; set; } = new List<TblHistoricoreneg>();

    public virtual ICollection<TblHistoricospc> TblHistoricospcs { get; set; } = new List<TblHistoricospc>();

    public virtual ICollection<TblHistprotesto> TblHistprotestos { get; set; } = new List<TblHistprotesto>();

    public virtual ICollection<TblInformacao> TblInformacaos { get; set; } = new List<TblInformacao>();

    public virtual ICollection<TblMensagemArquivadum> TblMensagemArquivadumCoddestNavigations { get; set; } = new List<TblMensagemArquivadum>();

    public virtual ICollection<TblMensagemArquivadum> TblMensagemArquivadumCodremeNavigations { get; set; } = new List<TblMensagemArquivadum>();

    public virtual ICollection<TblMensagemDel> TblMensagemDelCoddestNavigations { get; set; } = new List<TblMensagemDel>();

    public virtual ICollection<TblMensagemDel> TblMensagemDelCodremeNavigations { get; set; } = new List<TblMensagemDel>();

    public virtual ICollection<TblMensagemEnviadum> TblMensagemEnviadumCoddestNavigations { get; set; } = new List<TblMensagemEnviadum>();

    public virtual ICollection<TblMensagemEnviadum> TblMensagemEnviadumCodremeNavigations { get; set; } = new List<TblMensagemEnviadum>();

    public virtual TblOcorreSenha? TblOcorreSenha { get; set; }

    public virtual ICollection<TblPedidoCompra> TblPedidoCompras { get; set; } = new List<TblPedidoCompra>();

    public virtual ICollection<TblPedido> TblPedidos { get; set; } = new List<TblPedido>();

    public virtual ICollection<TblPermisso> TblPermissos { get; set; } = new List<TblPermisso>();

    public virtual ICollection<TblPrePedido> TblPrePedidos { get; set; } = new List<TblPrePedido>();

    public virtual ICollection<TblProdutoBaixa> TblProdutoBaixas { get; set; } = new List<TblProdutoBaixa>();

    public virtual TblUserAssistencium? TblUserAssistencium { get; set; }

    public virtual ICollection<TblUsuarioCaixa> TblUsuarioCaixas { get; set; } = new List<TblUsuarioCaixa>();

    public virtual ICollection<TblVeiculoAbastecimento> TblVeiculoAbastecimentoAdicionadoPorNavigations { get; set; } = new List<TblVeiculoAbastecimento>();

    public virtual ICollection<TblVeiculoAbastecimento> TblVeiculoAbastecimentoExcluidoPorNavigations { get; set; } = new List<TblVeiculoAbastecimento>();

    public virtual ICollection<TblVeiculoHistCarregamento> TblVeiculoHistCarregamentos { get; set; } = new List<TblVeiculoHistCarregamento>();
}
