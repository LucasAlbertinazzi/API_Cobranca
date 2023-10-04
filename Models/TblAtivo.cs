using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: TI/ FINANCEIRO
/// Contém o registro de ativos de informática, como: Câmeras, equipamentos de backup, impressoras, monitores, switchs, baterias, nobreaks, bem como os seus IPs, senhas, configurações detalhadas de cada acesso.
/// O número de patrímônio, coluna desta tabela, são as etiquetas coladas nos ativos. Esta tela é gerenciada através da tela FrmListaAtivos, acessada a partir de cadastro &gt; cadastro de ativos.
/// A chave primária desta tabela tem o nome de &quot;&quot;codigo&quot;&quot;, mas é chamada de &quot;&quot;codativo&quot;&quot; em outras tabelas.
/// 
/// </summary>
public partial class TblAtivo
{
    public int Codigo { get; set; }

    public int Patrimonio { get; set; }

    public int? Coddeparta { get; set; }

    public int? Codtipo { get; set; }

    public int? Codmarca { get; set; }

    public int? Codloja { get; set; }

    public int? Codlocal { get; set; }

    public string? Descricao { get; set; }

    public string? Modelo { get; set; }

    public string? Nserie { get; set; }

    public DateOnly? Datacompra { get; set; }

    public DateTime? Datacadastro { get; set; }

    public int? Codusuario { get; set; }

    public string? Hostname { get; set; }

    public decimal? Valor { get; set; }

    public bool? Ativo { get; set; }

    public virtual TblAtivoDepartamento? CoddepartaNavigation { get; set; }

    public virtual TblAtivoLocal? CodlocalNavigation { get; set; }

    public virtual TblLoja? CodlojaNavigation { get; set; }

    public virtual TblAtivoMarca? CodmarcaNavigation { get; set; }

    public virtual TblAtivoTipo? CodtipoNavigation { get; set; }

    public virtual TblUsuario? CodusuarioNavigation { get; set; }

    public virtual ICollection<TblAtivoHistorico> TblAtivoHistoricos { get; set; } = new List<TblAtivoHistorico>();

    public virtual ICollection<TblAtivoIp> TblAtivoIps { get; set; } = new List<TblAtivoIp>();

    public virtual ICollection<TblAtivoPropSub> TblAtivoPropSubs { get; set; } = new List<TblAtivoPropSub>();
}
