using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API_AppCobranca.Models;

public partial class DbContextApp : DbContext
{
    // Definição de funções escalares
    [DbFunction("get_bairro", Schema = "public")]
    public string GetBairro(int codbairro) => throw new NotSupportedException();

    [DbFunction("get_cidade", Schema = "public")]
    public string GetCidade(int codcidade) => throw new NotSupportedException();

    public DbContextApp()
    {
    }

    public DbContextApp(DbContextOptions<DbContextApp> options)
        : base(options)
    {
    }

    public virtual DbSet<ATempInventario> ATempInventarios { get; set; }

    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<AuditoriaLog> AuditoriaLogs { get; set; }

    public virtual DbSet<Auditorium> Auditoria { get; set; }

    public virtual DbSet<EcTblBloqueioPedido> EcTblBloqueioPedidos { get; set; }

    public virtual DbSet<EcTblCadastroProdSkyhubHist> EcTblCadastroProdSkyhubHists { get; set; }

    public virtual DbSet<EcTblCanaisMarketplace> EcTblCanaisMarketplaces { get; set; }

    public virtual DbSet<EcTblConciliadorAutenticacao> EcTblConciliadorAutenticacaos { get; set; }

    public virtual DbSet<EcTblConsultaProdutoAnymarket> EcTblConsultaProdutoAnymarkets { get; set; }

    public virtual DbSet<EcTblConsultaProdutoItemAnymarket> EcTblConsultaProdutoItemAnymarkets { get; set; }

    public virtual DbSet<EcTblCorreio> EcTblCorreios { get; set; }

    public virtual DbSet<EcTblCorreioPlp> EcTblCorreioPlps { get; set; }

    public virtual DbSet<EcTblDepartamento> EcTblDepartamentos { get; set; }

    public virtual DbSet<EcTblDepartamentoDiv> EcTblDepartamentoDivs { get; set; }

    public virtual DbSet<EcTblDivisao> EcTblDivisaos { get; set; }

    public virtual DbSet<EcTblEstoqueSkyhubLog> EcTblEstoqueSkyhubLogs { get; set; }

    public virtual DbSet<EcTblEtiquetaMercadoLivre> EcTblEtiquetaMercadoLivres { get; set; }

    public virtual DbSet<EcTblExpedicao> EcTblExpedicaos { get; set; }

    public virtual DbSet<EcTblFreteGratisCidade> EcTblFreteGratisCidades { get; set; }

    public virtual DbSet<EcTblFreteGratisUf> EcTblFreteGratisUfs { get; set; }

    public virtual DbSet<EcTblFreteTemplate> EcTblFreteTemplates { get; set; }

    public virtual DbSet<EcTblFreteUf> EcTblFreteUfs { get; set; }

    public virtual DbSet<EcTblHeadersSkyhub> EcTblHeadersSkyhubs { get; set; }

    public virtual DbSet<EcTblItensDescDep> EcTblItensDescDeps { get; set; }

    public virtual DbSet<EcTblLog> EcTblLogs { get; set; }

    public virtual DbSet<EcTblMetodoPgto> EcTblMetodoPgtos { get; set; }

    public virtual DbSet<EcTblPedido> EcTblPedidos { get; set; }

    public virtual DbSet<EcTblPedidoCliente> EcTblPedidoClientes { get; set; }

    public virtual DbSet<EcTblPedidoEndCobranca> EcTblPedidoEndCobrancas { get; set; }

    public virtual DbSet<EcTblPedidoEndEntrega> EcTblPedidoEndEntregas { get; set; }

    public virtual DbSet<EcTblPedidoEntradum> EcTblPedidoEntrada { get; set; }

    public virtual DbSet<EcTblPedidoIten> EcTblPedidoItens { get; set; }

    public virtual DbSet<EcTblPedidoManual> EcTblPedidoManuals { get; set; }

    public virtual DbSet<EcTblPedidoPagamento> EcTblPedidoPagamentos { get; set; }

    public virtual DbSet<EcTblPedidoRastreio> EcTblPedidoRastreios { get; set; }

    public virtual DbSet<EcTblPedidoStatus> EcTblPedidoStatuses { get; set; }

    public virtual DbSet<EcTblPedidoTranspNotum> EcTblPedidoTranspNota { get; set; }

    public virtual DbSet<EcTblPedidosAmazonTemporario> EcTblPedidosAmazonTemporarios { get; set; }

    public virtual DbSet<EcTblPlpDirect> EcTblPlpDirects { get; set; }

    public virtual DbSet<EcTblProduto> EcTblProdutos { get; set; }

    public virtual DbSet<EcTblProdutoDesc> EcTblProdutoDescs { get; set; }

    public virtual DbSet<EcTblProdutoDescComp> EcTblProdutoDescComps { get; set; }

    public virtual DbSet<EcTblProdutoDescHist> EcTblProdutoDescHists { get; set; }

    public virtual DbSet<EcTblProdutoMedida> EcTblProdutoMedidas { get; set; }

    public virtual DbSet<EcTblProdutoMk> EcTblProdutoMks { get; set; }

    public virtual DbSet<EcTblProdutoMkBybox> EcTblProdutoMkByboxes { get; set; }

    public virtual DbSet<EcTblProdutoPagInicio> EcTblProdutoPagInicios { get; set; }

    public virtual DbSet<EcTblProdutoPrecoB2w> EcTblProdutoPrecoB2ws { get; set; }

    public virtual DbSet<EcTblProdutoValor> EcTblProdutoValors { get; set; }

    public virtual DbSet<EcTblProdutoValorParc> EcTblProdutoValorParcs { get; set; }

    public virtual DbSet<EcTblProdutoVariacaoSkyhub> EcTblProdutoVariacaoSkyhubs { get; set; }

    public virtual DbSet<EcTblProdutosUrl> EcTblProdutosUrls { get; set; }

    public virtual DbSet<EcTblProtocolo> EcTblProtocolos { get; set; }

    public virtual DbSet<EcTblTransportadora> EcTblTransportadoras { get; set; }

    public virtual DbSet<EcTblTransportadoraAliqComissaoFrete> EcTblTransportadoraAliqComissaoFretes { get; set; }

    public virtual DbSet<EcTblTransportadoraDirect> EcTblTransportadoraDirects { get; set; }

    public virtual DbSet<EcTblTransportadoraSellerIndex> EcTblTransportadoraSellerIndices { get; set; }

    public virtual DbSet<EcTblVoltagem> EcTblVoltagems { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<LogAlteraco> LogAlteracoes { get; set; }

    public virtual DbSet<Monitoramento> Monitoramentos { get; set; }

    public virtual DbSet<TabelaLog> TabelaLogs { get; set; }

    public virtual DbSet<TblAdesivo> TblAdesivos { get; set; }

    public virtual DbSet<TblAgendaCob> TblAgendaCobs { get; set; }

    public virtual DbSet<TblAgendaEspecf> TblAgendaEspecfs { get; set; }

    public virtual DbSet<TblAgendaMalote> TblAgendaMalotes { get; set; }

    public virtual DbSet<TblAgendaPgto> TblAgendaPgtos { get; set; }

    public virtual DbSet<TblAgendaPgtoContabil> TblAgendaPgtoContabils { get; set; }

    public virtual DbSet<TblAgendaPgtoDivLoja> TblAgendaPgtoDivLojas { get; set; }

    public virtual DbSet<TblAgendafornecedor> TblAgendafornecedors { get; set; }

    public virtual DbSet<TblAgendafornecedorFornec> TblAgendafornecedorFornecs { get; set; }

    public virtual DbSet<TblAliquotaPisCofin> TblAliquotaPisCofins { get; set; }

    public virtual DbSet<TblAlteraPedido> TblAlteraPedidos { get; set; }

    public virtual DbSet<TblAnaliseCredito> TblAnaliseCreditos { get; set; }

    public virtual DbSet<TblAnaliseCreditoAnalista> TblAnaliseCreditoAnalistas { get; set; }

    public virtual DbSet<TblAnaliseCreditoTipo> TblAnaliseCreditoTipos { get; set; }

    public virtual DbSet<TblAniversario> TblAniversarios { get; set; }

    public virtual DbSet<TblApiRodonavesToken> TblApiRodonavesTokens { get; set; }

    public virtual DbSet<TblApiTransportadora> TblApiTransportadoras { get; set; }

    public virtual DbSet<TblAppMarciusLog> TblAppMarciusLogs { get; set; }

    public virtual DbSet<TblAppMarciusMenuPrincipal> TblAppMarciusMenuPrincipals { get; set; }

    public virtual DbSet<TblAppMarciusVersao> TblAppMarciusVersaos { get; set; }

    public virtual DbSet<TblArquivoPedido> TblArquivoPedidos { get; set; }

    public virtual DbSet<TblArquivoPedidoItem> TblArquivoPedidoItems { get; set; }

    public virtual DbSet<TblAssistencium> TblAssistencia { get; set; }

    public virtual DbSet<TblAtivo> TblAtivos { get; set; }

    public virtual DbSet<TblAtivoDepartamento> TblAtivoDepartamentos { get; set; }

    public virtual DbSet<TblAtivoFile> TblAtivoFiles { get; set; }

    public virtual DbSet<TblAtivoHistorico> TblAtivoHistoricos { get; set; }

    public virtual DbSet<TblAtivoIp> TblAtivoIps { get; set; }

    public virtual DbSet<TblAtivoLocal> TblAtivoLocals { get; set; }

    public virtual DbSet<TblAtivoMarca> TblAtivoMarcas { get; set; }

    public virtual DbSet<TblAtivoNotafiscal> TblAtivoNotafiscals { get; set; }

    public virtual DbSet<TblAtivoProp> TblAtivoProps { get; set; }

    public virtual DbSet<TblAtivoPropSub> TblAtivoPropSubs { get; set; }

    public virtual DbSet<TblAtivoTipo> TblAtivoTipos { get; set; }

    public virtual DbSet<TblAtualizacaoSistema> TblAtualizacaoSistemas { get; set; }

    public virtual DbSet<TblAuditoriaLog> TblAuditoriaLogs { get; set; }

    public virtual DbSet<TblAuditoriaProd> TblAuditoriaProds { get; set; }

    public virtual DbSet<TblAutenticacaoEmailLog> TblAutenticacaoEmailLogs { get; set; }

    public virtual DbSet<TblBairro> TblBairros { get; set; }

    public virtual DbSet<TblBaixaCartao> TblBaixaCartaos { get; set; }

    public virtual DbSet<TblBaixaEcommerceLog> TblBaixaEcommerceLogs { get; set; }

    public virtual DbSet<TblBanco> TblBancos { get; set; }

    public virtual DbSet<TblBancoCliente> TblBancoClientes { get; set; }

    public virtual DbSet<TblBandeiraCartao> TblBandeiraCartaos { get; set; }

    public virtual DbSet<TblBaseicmsTransferencium> TblBaseicmsTransferencia { get; set; }

    public virtual DbSet<TblBilheteGarantiaEnvio> TblBilheteGarantiaEnvios { get; set; }

    public virtual DbSet<TblBilheteGarantiaErro> TblBilheteGarantiaErros { get; set; }

    public virtual DbSet<TblBilheteGarantiaRetorno> TblBilheteGarantiaRetornos { get; set; }

    public virtual DbSet<TblBilheteGarantium> TblBilheteGarantia { get; set; }

    public virtual DbSet<TblBoasVinda> TblBoasVindas { get; set; }

    public virtual DbSet<TblCadastroMargen> TblCadastroMargens { get; set; }

    public virtual DbSet<TblCadastroSenha> TblCadastroSenhas { get; set; }

    public virtual DbSet<TblCadastroramai> TblCadastroramais { get; set; }

    public virtual DbSet<TblCaixa> TblCaixas { get; set; }

    public virtual DbSet<TblCaixaCreditoDiv> TblCaixaCreditoDivs { get; set; }

    public virtual DbSet<TblCaixaDebito> TblCaixaDebitos { get; set; }

    public virtual DbSet<TblCaixaMov> TblCaixaMovs { get; set; }

    public virtual DbSet<TblCaixaMovEstorno> TblCaixaMovEstornos { get; set; }

    public virtual DbSet<TblCaixaPrev> TblCaixaPrevs { get; set; }

    public virtual DbSet<TblCaixaPrevDesc> TblCaixaPrevDescs { get; set; }

    public virtual DbSet<TblCaixaPrevOb> TblCaixaPrevObs { get; set; }

    public virtual DbSet<TblCaixaTransferencium> TblCaixaTransferencia { get; set; }

    public virtual DbSet<TblCaixaVale> TblCaixaVales { get; set; }

    public virtual DbSet<TblCartaoFechamento> TblCartaoFechamentos { get; set; }

    public virtual DbSet<TblCartazPreco> TblCartazPrecos { get; set; }

    public virtual DbSet<TblChecklistAtividade> TblChecklistAtividades { get; set; }

    public virtual DbSet<TblChecklistAtividadeFinalizado> TblChecklistAtividadeFinalizados { get; set; }

    public virtual DbSet<TblChequePre> TblChequePres { get; set; }

    public virtual DbSet<TblCidade> TblCidades { get; set; }

    public virtual DbSet<TblCidadeApagar> TblCidadeApagars { get; set; }

    public virtual DbSet<TblClasseHist> TblClasseHists { get; set; }

    public virtual DbSet<TblCliente> TblClientes { get; set; }

    public virtual DbSet<TblClienteContatoCquitado> TblClienteContatoCquitados { get; set; }

    public virtual DbSet<TblClienteEmp> TblClienteEmps { get; set; }

    public virtual DbSet<TblClienteEntroup> TblClienteEntroups { get; set; }

    public virtual DbSet<TblClienteJuridica> TblClienteJuridicas { get; set; }

    public virtual DbSet<TblCloneCaixaMov> TblCloneCaixaMovs { get; set; }

    public virtual DbSet<TblCobrancaCont> TblCobrancaConts { get; set; }

    public virtual DbSet<TblComprasCota> TblComprasCotas { get; set; }

    public virtual DbSet<TblConfBloquearEmissaoNfeNfce> TblConfBloquearEmissaoNfeNfces { get; set; }

    public virtual DbSet<TblContaEstoque> TblContaEstoques { get; set; }

    public virtual DbSet<TblContaEstoquerotativo> TblContaEstoquerotativos { get; set; }

    public virtual DbSet<TblContaEstoquerotativoSub> TblContaEstoquerotativoSubs { get; set; }

    public virtual DbSet<TblContrato> TblContratos { get; set; }

    public virtual DbSet<TblCor> TblCors { get; set; }

    public virtual DbSet<TblCusto> TblCustos { get; set; }

    public virtual DbSet<TblCustoFinan> TblCustoFinans { get; set; }

    public virtual DbSet<TblDatasComemorativa> TblDatasComemorativas { get; set; }

    public virtual DbSet<TblDepartamento> TblDepartamentos { get; set; }

    public virtual DbSet<TblDepartamentoTaxa> TblDepartamentoTaxas { get; set; }

    public virtual DbSet<TblDepartamentoUsuario> TblDepartamentoUsuarios { get; set; }

    public virtual DbSet<TblDepositoSeraApagada31102019> TblDepositoSeraApagada31102019s { get; set; }

    public virtual DbSet<TblDescricaoProduto> TblDescricaoProdutos { get; set; }

    public virtual DbSet<TblDev> TblDevs { get; set; }

    public virtual DbSet<TblDevWork> TblDevWorks { get; set; }

    public virtual DbSet<TblDivisao> TblDivisaos { get; set; }

    public virtual DbSet<TblDivisaoGasto> TblDivisaoGastos { get; set; }

    public virtual DbSet<TblDivisaoGastoPrinc> TblDivisaoGastoPrincs { get; set; }

    public virtual DbSet<TblDivisaoGastoSub> TblDivisaoGastoSubs { get; set; }

    public virtual DbSet<TblEcf> TblEcfs { get; set; }

    public virtual DbSet<TblEmailAssist> TblEmailAssists { get; set; }

    public virtual DbSet<TblEmailEnviado> TblEmailEnviados { get; set; }

    public virtual DbSet<TblEmissaoFiscal> TblEmissaoFiscals { get; set; }

    public virtual DbSet<TblEnvioCupomFiscal> TblEnvioCupomFiscals { get; set; }

    public virtual DbSet<TblEnvioProdutoLogistica> TblEnvioProdutoLogisticas { get; set; }

    public virtual DbSet<TblErro> TblErros { get; set; }

    public virtual DbSet<TblErroParcela> TblErroParcelas { get; set; }

    public virtual DbSet<TblEspelhoParcelasPrazo> TblEspelhoParcelasPrazos { get; set; }

    public virtual DbSet<TblEtiquetaIdent> TblEtiquetaIdents { get; set; }

    public virtual DbSet<TblEtiquetaPreco> TblEtiquetaPrecos { get; set; }

    public virtual DbSet<TblExtratoBancarioConta> TblExtratoBancarioContas { get; set; }

    public virtual DbSet<TblExtratoBancarioMov> TblExtratoBancarioMovs { get; set; }

    public virtual DbSet<TblFeriado> TblFeriados { get; set; }

    public virtual DbSet<TblFinanceira> TblFinanceiras { get; set; }

    public virtual DbSet<TblFiscalSincConf> TblFiscalSincConfs { get; set; }

    public virtual DbSet<TblFluxo1> TblFluxo1s { get; set; }

    public virtual DbSet<TblFolgaVeiculo> TblFolgaVeiculos { get; set; }

    public virtual DbSet<TblFormulario> TblFormularios { get; set; }

    public virtual DbSet<TblFormularioDono> TblFormularioDonos { get; set; }

    public virtual DbSet<TblForneContaDominio> TblForneContaDominios { get; set; }

    public virtual DbSet<TblForneassist> TblForneassists { get; set; }

    public virtual DbSet<TblFornecedor> TblFornecedors { get; set; }

    public virtual DbSet<TblFornecedorEmailLog> TblFornecedorEmailLogs { get; set; }

    public virtual DbSet<TblFornecedorGrupo> TblFornecedorGrupos { get; set; }

    public virtual DbSet<TblFuncao> TblFuncaos { get; set; }

    public virtual DbSet<TblGastoveiculo> TblGastoveiculos { get; set; }

    public virtual DbSet<TblGeraPromissorium> TblGeraPromissoria { get; set; }

    public virtual DbSet<TblGeraRomaneio> TblGeraRomaneios { get; set; }

    public virtual DbSet<TblHelp> TblHelps { get; set; }

    public virtual DbSet<TblHistoricoPedidosEcommerce> TblHistoricoPedidosEcommerces { get; set; }

    public virtual DbSet<TblHistoricoassist> TblHistoricoassists { get; set; }

    public virtual DbSet<TblHistoricoreneg> TblHistoricorenegs { get; set; }

    public virtual DbSet<TblHistoricospc> TblHistoricospcs { get; set; }

    public virtual DbSet<TblHistprotesto> TblHistprotestos { get; set; }

    public virtual DbSet<TblHistvencimento> TblHistvencimentos { get; set; }

    public virtual DbSet<TblHost> TblHosts { get; set; }

    public virtual DbSet<TblIbptax> TblIbptaxes { get; set; }

    public virtual DbSet<TblImei> TblImeis { get; set; }

    public virtual DbSet<TblImpCarneQuitado> TblImpCarneQuitados { get; set; }

    public virtual DbSet<TblImpcartum> TblImpcarta { get; set; }

    public virtual DbSet<TblImpreCaixa> TblImpreCaixas { get; set; }

    public virtual DbSet<TblInfoAnexoDifal> TblInfoAnexoDifals { get; set; }

    public virtual DbSet<TblInformacao> TblInformacaos { get; set; }

    public virtual DbSet<TblIpDe> TblIpDes { get; set; }

    public virtual DbSet<TblJornal> TblJornals { get; set; }

    public virtual DbSet<TblJornalProduto> TblJornalProdutos { get; set; }

    public virtual DbSet<TblJornalPronto> TblJornalProntos { get; set; }

    public virtual DbSet<TblJornalTaxaJuro> TblJornalTaxaJuros { get; set; }

    public virtual DbSet<TblJuroespecialOld> TblJuroespecialOlds { get; set; }

    public virtual DbSet<TblLeologEntrada> TblLeologEntradas { get; set; }

    public virtual DbSet<TblLeologManutencao> TblLeologManutencaos { get; set; }

    public virtual DbSet<TblLeologSaida> TblLeologSaidas { get; set; }

    public virtual DbSet<TblLeologStatus> TblLeologStatuses { get; set; }

    public virtual DbSet<TblLinkteste> TblLinktestes { get; set; }

    public virtual DbSet<TblLogAnexo> TblLogAnexos { get; set; }

    public virtual DbSet<TblLogAtualizaRomaneio> TblLogAtualizaRomaneios { get; set; }

    public virtual DbSet<TblLogDiParaDp> TblLogDiParaDps { get; set; }

    public virtual DbSet<TblLogEstornoParcela> TblLogEstornoParcelas { get; set; }

    public virtual DbSet<TblLogImpSegviaCarne> TblLogImpSegviaCarnes { get; set; }

    public virtual DbSet<TblLogParcelasPaga> TblLogParcelasPagas { get; set; }

    public virtual DbSet<TblLogParcelasPrazo> TblLogParcelasPrazos { get; set; }

    public virtual DbSet<TblLogParciaisGerada> TblLogParciaisGeradas { get; set; }

    public virtual DbSet<TblLogUpdate> TblLogUpdates { get; set; }

    public virtual DbSet<TblLogisticaPosico> TblLogisticaPosicoes { get; set; }

    public virtual DbSet<TblLogisticaProdPo> TblLogisticaProdPos { get; set; }

    public virtual DbSet<TblLoja> TblLojas { get; set; }

    public virtual DbSet<TblLojaAssistencium> TblLojaAssistencia { get; set; }

    public virtual DbSet<TblMalote> TblMalotes { get; set; }

    public virtual DbSet<TblMaloteIten> TblMaloteItens { get; set; }

    public virtual DbSet<TblMaloteItensOb> TblMaloteItensObs { get; set; }

    public virtual DbSet<TblMarca> TblMarcas { get; set; }

    public virtual DbSet<TblMarcaAssistencium> TblMarcaAssistencia { get; set; }

    public virtual DbSet<TblMarketing> TblMarketings { get; set; }

    public virtual DbSet<TblMarketingCliente> TblMarketingClientes { get; set; }

    public virtual DbSet<TblMarketplaceRepasse> TblMarketplaceRepasses { get; set; }

    public virtual DbSet<TblMensagem> TblMensagems { get; set; }

    public virtual DbSet<TblMensagemArquivadaPastum> TblMensagemArquivadaPasta { get; set; }

    public virtual DbSet<TblMensagemArquivadum> TblMensagemArquivada { get; set; }

    public virtual DbSet<TblMensagemDel> TblMensagemDels { get; set; }

    public virtual DbSet<TblMensagemEnviadum> TblMensagemEnviada { get; set; }

    public virtual DbSet<TblMensagemGrupo> TblMensagemGrupos { get; set; }

    public virtual DbSet<TblMensagemassist> TblMensagemassists { get; set; }

    public virtual DbSet<TblMenu> TblMenus { get; set; }

    public virtual DbSet<TblMenuSistema> TblMenuSistemas { get; set; }

    public virtual DbSet<TblMenuSistemaNew> TblMenuSistemaNews { get; set; }

    public virtual DbSet<TblMeta> TblMetas { get; set; }

    public virtual DbSet<TblMotivoDescarregado> TblMotivoDescarregados { get; set; }

    public virtual DbSet<TblMotivoNaocarregado> TblMotivoNaocarregados { get; set; }

    public virtual DbSet<TblMotivoReagendar> TblMotivoReagendars { get; set; }

    public virtual DbSet<TblMotivosNaocarregado> TblMotivosNaocarregados { get; set; }

    public virtual DbSet<TblNfce> TblNfces { get; set; }

    public virtual DbSet<TblNfe> TblNves { get; set; }

    public virtual DbSet<TblNfeCsc> TblNfeCscs { get; set; }

    public virtual DbSet<TblNfeDespesa> TblNfeDespesas { get; set; }

    public virtual DbSet<TblNfeDestinada> TblNfeDestinadas { get; set; }

    public virtual DbSet<TblNfeEmissao> TblNfeEmissaos { get; set; }

    public virtual DbSet<TblNfeEntradaArmazenagem> TblNfeEntradaArmazenagems { get; set; }

    public virtual DbSet<TblNfeEntradum> TblNfeEntrada { get; set; }

    public virtual DbSet<TblNfeErro> TblNfeErros { get; set; }

    public virtual DbSet<TblNfeIndenizacao> TblNfeIndenizacaos { get; set; }

    public virtual DbSet<TblNfeProduto> TblNfeProdutos { get; set; }

    public virtual DbSet<TblNfeProdutosDevol> TblNfeProdutosDevols { get; set; }

    public virtual DbSet<TblNfeVendaDevolucaoArmazenagem> TblNfeVendaDevolucaoArmazenagems { get; set; }

    public virtual DbSet<TblNorma> TblNormas { get; set; }

    public virtual DbSet<TblNotaSub> TblNotaSubs { get; set; }

    public virtual DbSet<TblNotum> TblNota { get; set; }

    public virtual DbSet<TblObsAgendaFinanc> TblObsAgendaFinancs { get; set; }

    public virtual DbSet<TblOcorrChamado> TblOcorrChamados { get; set; }

    public virtual DbSet<TblOcorrChamadosReag> TblOcorrChamadosReags { get; set; }

    public virtual DbSet<TblOcorrPrioridade> TblOcorrPrioridades { get; set; }

    public virtual DbSet<TblOcorrServico> TblOcorrServicos { get; set; }

    public virtual DbSet<TblOcorrUsuario> TblOcorrUsuarios { get; set; }

    public virtual DbSet<TblOcorreMotivo> TblOcorreMotivos { get; set; }

    public virtual DbSet<TblOcorreMotivoSub> TblOcorreMotivoSubs { get; set; }

    public virtual DbSet<TblOcorreSenha> TblOcorreSenhas { get; set; }

    public virtual DbSet<TblOcorrencium> TblOcorrencia { get; set; }

    public virtual DbSet<TblOperacional> TblOperacionals { get; set; }

    public virtual DbSet<TblOperacionalLojasPeso> TblOperacionalLojasPesos { get; set; }

    public virtual DbSet<TblParcela> TblParcelas { get; set; }

    public virtual DbSet<TblParcelasFinan> TblParcelasFinans { get; set; }

    public virtual DbSet<TblParcelasPrazo> TblParcelasPrazos { get; set; }

    public virtual DbSet<TblParcelasPrazoOrc> TblParcelasPrazoOrcs { get; set; }

    public virtual DbSet<TblPartilhaIcm> TblPartilhaIcms { get; set; }

    public virtual DbSet<TblPedTrocauser> TblPedTrocausers { get; set; }

    public virtual DbSet<TblPedido> TblPedidos { get; set; }

    public virtual DbSet<TblPedidoCompra> TblPedidoCompras { get; set; }

    public virtual DbSet<TblPedidoCompraParc> TblPedidoCompraParcs { get; set; }

    public virtual DbSet<TblPedidoCompraProrr> TblPedidoCompraProrrs { get; set; }

    public virtual DbSet<TblPedidoCompraR> TblPedidoCompraRs { get; set; }

    public virtual DbSet<TblPedidoEx> TblPedidoExes { get; set; }

    public virtual DbSet<TblPedidoGarantium> TblPedidoGarantia { get; set; }

    public virtual DbSet<TblPedidoPrazoApagar> TblPedidoPrazoApagars { get; set; }

    public virtual DbSet<TblPermisso> TblPermissoes { get; set; }

    public virtual DbSet<TblPermissoesEspeciai> TblPermissoesEspeciais { get; set; }

    public virtual DbSet<TblPesquisa> TblPesquisas { get; set; }

    public virtual DbSet<TblPesquisaQuest> TblPesquisaQuests { get; set; }

    public virtual DbSet<TblPesquisaResp> TblPesquisaResps { get; set; }

    public virtual DbSet<TblPesquisaUser> TblPesquisaUsers { get; set; }

    public virtual DbSet<TblPixChave> TblPixChaves { get; set; }

    public virtual DbSet<TblPixCobranca> TblPixCobrancas { get; set; }

    public virtual DbSet<TblPixDevolucao> TblPixDevolucaos { get; set; }

    public virtual DbSet<TblPixFilaParcela> TblPixFilaParcelas { get; set; }

    public virtual DbSet<TblPixOcorrencium> TblPixOcorrencia { get; set; }

    public virtual DbSet<TblPosicao> TblPosicaos { get; set; }

    public virtual DbSet<TblPosicaoProd> TblPosicaoProds { get; set; }

    public virtual DbSet<TblPrePedido> TblPrePedidos { get; set; }

    public virtual DbSet<TblPrePedidoOrc> TblPrePedidoOrcs { get; set; }

    public virtual DbSet<TblPrevisaoCaixa> TblPrevisaoCaixas { get; set; }

    public virtual DbSet<TblPrevisaoCaixaDet> TblPrevisaoCaixaDets { get; set; }

    public virtual DbSet<TblProdMov> TblProdMovs { get; set; }

    public virtual DbSet<TblProduto> TblProdutos { get; set; }

    public virtual DbSet<TblProdutoAjusteManual> TblProdutoAjusteManuals { get; set; }

    public virtual DbSet<TblProdutoAlqNcm> TblProdutoAlqNcms { get; set; }

    public virtual DbSet<TblProdutoAlqNcmLogDel> TblProdutoAlqNcmLogDels { get; set; }

    public virtual DbSet<TblProdutoBaixa> TblProdutoBaixas { get; set; }

    public virtual DbSet<TblProdutoEntra> TblProdutoEntras { get; set; }

    public virtual DbSet<TblProdutoEntraSub> TblProdutoEntraSubs { get; set; }

    public virtual DbSet<TblProdutoGrupo> TblProdutoGrupos { get; set; }

    public virtual DbSet<TblProdutoHistAltMargem> TblProdutoHistAltMargems { get; set; }

    public virtual DbSet<TblProdutoMov> TblProdutoMovs { get; set; }

    public virtual DbSet<TblProdutoQuant> TblProdutoQuants { get; set; }

    public virtual DbSet<TblProdutoQuantUp> TblProdutoQuantUps { get; set; }

    public virtual DbSet<TblProdutoServico> TblProdutoServicos { get; set; }

    public virtual DbSet<TblProdutoSub> TblProdutoSubs { get; set; }

    public virtual DbSet<TblProdutoUp> TblProdutoUps { get; set; }

    public virtual DbSet<TblProjeto> TblProjetos { get; set; }

    public virtual DbSet<TblProjetoExecucao> TblProjetoExecucaos { get; set; }

    public virtual DbSet<TblProjetoVp> TblProjetoVps { get; set; }

    public virtual DbSet<TblPromessa> TblPromessas { get; set; }

    public virtual DbSet<TblRecebimentoContabil> TblRecebimentoContabils { get; set; }

    public virtual DbSet<TblRegistro10> TblRegistro10s { get; set; }

    public virtual DbSet<TblRegistro11> TblRegistro11s { get; set; }

    public virtual DbSet<TblRegistro50> TblRegistro50s { get; set; }

    public virtual DbSet<TblRegistro54> TblRegistro54s { get; set; }

    public virtual DbSet<TblRegistro75> TblRegistro75s { get; set; }

    public virtual DbSet<TblRegistroRetornosE> TblRegistroRetornosEs { get; set; }

    public virtual DbSet<TblRegrasBaixaEcommerce> TblRegrasBaixaEcommerces { get; set; }

    public virtual DbSet<TblRegrasBaixaEcommerceMarketplace> TblRegrasBaixaEcommerceMarketplaces { get; set; }

    public virtual DbSet<TblRegrasBaixaEcommerceTpl> TblRegrasBaixaEcommerceTpls { get; set; }

    public virtual DbSet<TblRenegRemovidum> TblRenegRemovida { get; set; }

    public virtual DbSet<TblRenegociar> TblRenegociars { get; set; }

    public virtual DbSet<TblRenegociarGerou> TblRenegociarGerous { get; set; }

    public virtual DbSet<TblRenegociarOcorre> TblRenegociarOcorres { get; set; }

    public virtual DbSet<TblRenegociarOcorrencium> TblRenegociarOcorrencia { get; set; }

    public virtual DbSet<TblRenegociarPago> TblRenegociarPagos { get; set; }

    public virtual DbSet<TblRenegociarSenha> TblRenegociarSenhas { get; set; }

    public virtual DbSet<TblRomaEstornadoHistorico> TblRomaEstornadoHistoricos { get; set; }

    public virtual DbSet<TblRomaPermissao> TblRomaPermissaos { get; set; }

    public virtual DbSet<TblRomaReagendar> TblRomaReagendars { get; set; }

    public virtual DbSet<TblRomaneio> TblRomaneios { get; set; }

    public virtual DbSet<TblRomaneioAutoriza> TblRomaneioAutorizas { get; set; }

    public virtual DbSet<TblRomaneioLogAlteracaoEndereco> TblRomaneioLogAlteracaoEnderecos { get; set; }

    public virtual DbSet<TblRomaneioLoja> TblRomaneioLojas { get; set; }

    public virtual DbSet<TblRomaneioStatus> TblRomaneioStatuses { get; set; }

    public virtual DbSet<TblRotaRomaneio> TblRotaRomaneios { get; set; }

    public virtual DbSet<TblRotina> TblRotinas { get; set; }

    public virtual DbSet<TblRotinaIten> TblRotinaItens { get; set; }

    public virtual DbSet<TblRotinaItensAval> TblRotinaItensAvals { get; set; }

    public virtual DbSet<TblScoreBv> TblScoreBvs { get; set; }

    public virtual DbSet<TblScoreLoja> TblScoreLojas { get; set; }

    public virtual DbSet<TblScoreLojaHist> TblScoreLojaHists { get; set; }

    public virtual DbSet<TblScoreLojaResult> TblScoreLojaResults { get; set; }

    public virtual DbSet<TblScoreLojaSenha> TblScoreLojaSenhas { get; set; }

    public virtual DbSet<TblScoreTabela> TblScoreTabelas { get; set; }

    public virtual DbSet<TblSeguroSabemi> TblSeguroSabemis { get; set; }

    public virtual DbSet<TblSenhaNegadum> TblSenhaNegada { get; set; }

    public virtual DbSet<TblSequenciaE> TblSequenciaEs { get; set; }

    public virtual DbSet<TblServSistema> TblServSistemas { get; set; }

    public virtual DbSet<TblSincBlackList> TblSincBlackLists { get; set; }

    public virtual DbSet<TblSincConfig> TblSincConfigs { get; set; }

    public virtual DbSet<TblSincCstDespesa> TblSincCstDespesas { get; set; }

    public virtual DbSet<TblSincEnvio> TblSincEnvios { get; set; }

    public virtual DbSet<TblSincFecha> TblSincFechas { get; set; }

    public virtual DbSet<TblSincFechamento> TblSincFechamentos { get; set; }

    public virtual DbSet<TblSincIgnoraFechamento> TblSincIgnoraFechamentos { get; set; }

    public virtual DbSet<TblSincNotimp> TblSincNotimps { get; set; }

    public virtual DbSet<TblSincRegraCfop> TblSincRegraCfops { get; set; }

    public virtual DbSet<TblSincRegraDespesa> TblSincRegraDespesas { get; set; }

    public virtual DbSet<TblSincSolicitaEnvio> TblSincSolicitaEnvios { get; set; }

    public virtual DbSet<TblSitefBaixa> TblSitefBaixas { get; set; }

    public virtual DbSet<TblSitefCancelamento> TblSitefCancelamentos { get; set; }

    public virtual DbSet<TblSitefCreditoCliente> TblSitefCreditoClientes { get; set; }

    public virtual DbSet<TblSitefRefVendum> TblSitefRefVenda { get; set; }

    public virtual DbSet<TblSitefTransacao> TblSitefTransacaos { get; set; }

    public virtual DbSet<TblSitefVendaParcial> TblSitefVendaParcials { get; set; }

    public virtual DbSet<TblSitefVendum> TblSitefVenda { get; set; }

    public virtual DbSet<TblSolicitaNotaFiscal> TblSolicitaNotaFiscals { get; set; }

    public virtual DbSet<TblSolicitaNotaFiscalProduto> TblSolicitaNotaFiscalProdutos { get; set; }

    public virtual DbSet<TblSolicitadesc> TblSolicitadescs { get; set; }

    public virtual DbSet<TblSolicitatransf> TblSolicitatransfs { get; set; }

    public virtual DbSet<TblSpcSerasa> TblSpcSerasas { get; set; }

    public virtual DbSet<TblStatusEstoque> TblStatusEstoques { get; set; }

    public virtual DbSet<TblStatusEstoqueDep> TblStatusEstoqueDeps { get; set; }

    public virtual DbSet<TblStefRefVendum> TblStefRefVenda { get; set; }

    public virtual DbSet<TblSubContagem> TblSubContagems { get; set; }

    public virtual DbSet<TblSubContagem1> TblSubContagem1s { get; set; }

    public virtual DbSet<TblSubContagemManu> TblSubContagemManus { get; set; }

    public virtual DbSet<TblSubPedido> TblSubPedidos { get; set; }

    public virtual DbSet<TblSubPedidoCompra> TblSubPedidoCompras { get; set; }

    public virtual DbSet<TblSubPedidoCompraHistVincNotum> TblSubPedidoCompraHistVincNota { get; set; }

    public virtual DbSet<TblSubPedidoCompraR> TblSubPedidoCompraRs { get; set; }

    public virtual DbSet<TblSubPedidoOld> TblSubPedidoOlds { get; set; }

    public virtual DbSet<TblSubPedidoOrc> TblSubPedidoOrcs { get; set; }

    public virtual DbSet<TblSubSolicitadesc> TblSubSolicitadescs { get; set; }

    public virtual DbSet<TblSugestaoCompra> TblSugestaoCompras { get; set; }

    public virtual DbSet<TblTarefa> TblTarefas { get; set; }

    public virtual DbSet<TblTaxaJuro> TblTaxaJuros { get; set; }

    public virtual DbSet<TblTefConfig> TblTefConfigs { get; set; }

    public virtual DbSet<TblTerceiro> TblTerceiros { get; set; }

    public virtual DbSet<TblTeste1> TblTeste1s { get; set; }

    public virtual DbSet<TblTipoEntrega> TblTipoEntregas { get; set; }

    public virtual DbSet<TblTipoParcela> TblTipoParcelas { get; set; }

    public virtual DbSet<TblTipoPedido> TblTipoPedidos { get; set; }

    public virtual DbSet<TblTipoPgto> TblTipoPgtos { get; set; }

    public virtual DbSet<TblTipoVendum> TblTipoVenda { get; set; }

    public virtual DbSet<TblTransferenciatotaldeestoque> TblTransferenciatotaldeestoques { get; set; }

    public virtual DbSet<TblTransfestoque> TblTransfestoques { get; set; }

    public virtual DbSet<TblTransportadora> TblTransportadoras { get; set; }

    public virtual DbSet<TblUf> TblUfs { get; set; }

    public virtual DbSet<TblUserAssistencium> TblUserAssistencia { get; set; }

    public virtual DbSet<TblUsuario> TblUsuarios { get; set; }

    public virtual DbSet<TblUsuarioCaixa> TblUsuarioCaixas { get; set; }

    public virtual DbSet<TblUsuarioassist> TblUsuarioassists { get; set; }

    public virtual DbSet<TblVeiculo> TblVeiculos { get; set; }

    public virtual DbSet<TblVeiculoAbastecimento> TblVeiculoAbastecimentos { get; set; }

    public virtual DbSet<TblVeiculoDespesa> TblVeiculoDespesas { get; set; }

    public virtual DbSet<TblVeiculoHistCarregamento> TblVeiculoHistCarregamentos { get; set; }

    public virtual DbSet<TblVeiculoHistManutencao> TblVeiculoHistManutencaos { get; set; }

    public virtual DbSet<TblVeiculoMotorista> TblVeiculoMotoristas { get; set; }

    public virtual DbSet<TblVenda> TblVendas { get; set; }

    public virtual DbSet<TblVendasPromocaoAgendadum> TblVendasPromocaoAgendada { get; set; }

    public virtual DbSet<TblVendasfornecedor> TblVendasfornecedors { get; set; }

    public virtual DbSet<TblVersaoSistema> TblVersaoSistemas { get; set; }

    public virtual DbSet<VTblPedido> VTblPedidos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("C")
            .HasPostgresExtension("pg_stat_statements");

        modelBuilder.Entity<ATempInventario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("a_temp_inventario_pkey");

            entity.ToTable("a_temp_inventario");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(15)
                .HasColumnName("codproduto");
            entity.Property(e => e.Custo)
                .HasPrecision(12, 6)
                .HasColumnName("custo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(120)
                .HasColumnName("descricao");
            entity.Property(e => e.Quant)
                .HasPrecision(12, 4)
                .HasColumnName("quant");
            entity.Property(e => e.Total)
                .HasPrecision(12, 4)
                .HasColumnName("total");
        });

        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("audit_logs_pkey");

            entity.ToTable("audit_logs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IpAddress).HasColumnName("ip_address");
            entity.Property(e => e.NewData)
                .HasColumnType("jsonb")
                .HasColumnName("new_data");
            entity.Property(e => e.OldData)
                .HasColumnType("jsonb")
                .HasColumnName("old_data");
            entity.Property(e => e.Operation).HasColumnName("operation");
            entity.Property(e => e.TableName).HasColumnName("table_name");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("timestamp");
        });

        modelBuilder.Entity<AuditoriaLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auditoria_logs_pkey");

            entity.ToTable("auditoria_logs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acao).HasColumnName("acao");
            entity.Property(e => e.DadosAntigos)
                .HasColumnType("jsonb")
                .HasColumnName("dados_antigos");
            entity.Property(e => e.DadosNovos)
                .HasColumnType("jsonb")
                .HasColumnName("dados_novos");
            entity.Property(e => e.DataHora)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_hora");
            entity.Property(e => e.Ip).HasColumnName("ip");
            entity.Property(e => e.Tabela).HasColumnName("tabela");
        });

        modelBuilder.Entity<Auditorium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auditoria_pkey");

            entity.ToTable("auditoria");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataHora)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_hora");
            entity.Property(e => e.Informacoes)
                .HasColumnType("jsonb")
                .HasColumnName("informacoes");
            entity.Property(e => e.Operacao).HasColumnName("operacao");
            entity.Property(e => e.Tabela).HasColumnName("tabela");
        });

        modelBuilder.Entity<EcTblBloqueioPedido>(entity =>
        {
            entity.HasKey(e => new { e.Codpedido, e.Id }).HasName("ec_tbl_bloqueio_pedido_pkey");

            entity.ToTable("ec_tbl_bloqueio_pedido", tb => tb.HasComment("Bloqueio dos Pedidos Antes que seja despachado"));

            entity.Property(e => e.Codpedido)
                .HasColumnType("character varying")
                .HasColumnName("codpedido");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Bloqueado).HasColumnName("bloqueado");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Codusuariobloqueou).HasColumnName("codusuariobloqueou");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Motivo)
                .HasColumnType("character varying")
                .HasColumnName("motivo");
        });

        modelBuilder.Entity<EcTblCadastroProdSkyhubHist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_cadastro_prod_skyhub_hist_pkey");

            entity.ToTable("ec_tbl_cadastro_prod_skyhub_hist");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Altura)
                .HasPrecision(6, 2)
                .HasColumnName("altura");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Cor)
                .HasMaxLength(20)
                .HasColumnName("cor");
            entity.Property(e => e.Crossdocking).HasColumnName("crossdocking");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Departamento)
                .HasMaxLength(30)
                .HasColumnName("departamento");
            entity.Property(e => e.DescEc).HasColumnName("desc_ec");
            entity.Property(e => e.DescricaoItem).HasColumnName("descricao_item");
            entity.Property(e => e.Ean)
                .HasMaxLength(14)
                .HasColumnName("ean");
            entity.Property(e => e.Familia)
                .HasMaxLength(30)
                .HasColumnName("familia");
            entity.Property(e => e.IdItemPai)
                .HasMaxLength(30)
                .HasColumnName("id_item_pai");
            entity.Property(e => e.ImagemItem1)
                .HasMaxLength(250)
                .HasColumnName("imagem_item1");
            entity.Property(e => e.ImagemItem10)
                .HasMaxLength(250)
                .HasColumnName("imagem_item10");
            entity.Property(e => e.ImagemItem11)
                .HasMaxLength(250)
                .HasColumnName("imagem_item11");
            entity.Property(e => e.ImagemItem12)
                .HasMaxLength(250)
                .HasColumnName("imagem_item12");
            entity.Property(e => e.ImagemItem2)
                .HasMaxLength(250)
                .HasColumnName("imagem_item2");
            entity.Property(e => e.ImagemItem3)
                .HasMaxLength(250)
                .HasColumnName("imagem_item3");
            entity.Property(e => e.ImagemItem4)
                .HasMaxLength(250)
                .HasColumnName("imagem_item4");
            entity.Property(e => e.ImagemItem5)
                .HasMaxLength(250)
                .HasColumnName("imagem_item5");
            entity.Property(e => e.ImagemItem6)
                .HasMaxLength(250)
                .HasColumnName("imagem_item6");
            entity.Property(e => e.ImagemItem7)
                .HasMaxLength(250)
                .HasColumnName("imagem_item7");
            entity.Property(e => e.ImagemItem8)
                .HasMaxLength(250)
                .HasColumnName("imagem_item8");
            entity.Property(e => e.ImagemItem9)
                .HasMaxLength(250)
                .HasColumnName("imagem_item9");
            entity.Property(e => e.Largura)
                .HasPrecision(6, 2)
                .HasColumnName("largura");
            entity.Property(e => e.Marca)
                .HasMaxLength(30)
                .HasColumnName("marca");
            entity.Property(e => e.NomeItemPai)
                .HasMaxLength(150)
                .HasColumnName("nome_item_pai");
            entity.Property(e => e.NomeProduto)
                .HasMaxLength(150)
                .HasColumnName("nome_produto");
            entity.Property(e => e.Peso)
                .HasPrecision(8, 4)
                .HasColumnName("peso");
            entity.Property(e => e.PrecoDe)
                .HasPrecision(7, 2)
                .HasColumnName("preco_de");
            entity.Property(e => e.PrecoPor)
                .HasPrecision(7, 2)
                .HasColumnName("preco_por");
            entity.Property(e => e.ProcedenciaItem)
                .HasMaxLength(30)
                .HasColumnName("procedencia_item");
            entity.Property(e => e.Profundidade)
                .HasPrecision(6, 2)
                .HasColumnName("profundidade");
            entity.Property(e => e.QtdSkyhub).HasColumnName("qtd_skyhub");
            entity.Property(e => e.Setor)
                .HasMaxLength(30)
                .HasColumnName("setor");
            entity.Property(e => e.Sku)
                .HasMaxLength(13)
                .HasColumnName("sku");
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .HasColumnName("status");
            entity.Property(e => e.SubFamilia)
                .HasMaxLength(30)
                .HasColumnName("sub_familia");
            entity.Property(e => e.Tamanho)
                .HasMaxLength(20)
                .HasColumnName("tamanho");
            entity.Property(e => e.Voltagem)
                .HasMaxLength(7)
                .HasColumnName("voltagem");
        });

        modelBuilder.Entity<EcTblCanaisMarketplace>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_canais_marketplace_pkey");

            entity.ToTable("ec_tbl_canais_marketplace");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(14)
                .HasColumnName("cnpj");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("now()")
                .HasColumnName("data");
            entity.Property(e => e.Nome)
                .HasMaxLength(120)
                .HasColumnName("nome");
            entity.Property(e => e.RazaoSocial)
                .HasMaxLength(50)
                .HasColumnName("razao_social");
            entity.Property(e => e.Tag)
                .HasMaxLength(200)
                .HasColumnName("tag");
        });

        modelBuilder.Entity<EcTblConciliadorAutenticacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_conciliador_autenticacao_pkey");

            entity.ToTable("ec_tbl_conciliador_autenticacao");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TempExp).HasColumnName("temp_exp");
            entity.Property(e => e.Token).HasColumnName("token");
        });

        modelBuilder.Entity<EcTblConsultaProdutoAnymarket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_consulta_produto_anymarket_pkey");

            entity.ToTable("ec_tbl_consulta_produto_anymarket");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Datafim)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datafim");
            entity.Property(e => e.Datainicio)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datainicio");
        });

        modelBuilder.Entity<EcTblConsultaProdutoItemAnymarket>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ec_tbl_consulta_produto_item_anymarket");

            entity.Property(e => e.Codproduto)
                .HasMaxLength(14)
                .HasColumnName("codproduto");
            entity.Property(e => e.ConsultaProdutoId).HasColumnName("consulta_produto_id");
            entity.Property(e => e.Crossdocking).HasColumnName("crossdocking");
            entity.Property(e => e.Height)
                .HasPrecision(10, 2)
                .HasColumnName("height");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Length)
                .HasPrecision(10, 2)
                .HasColumnName("length");
            entity.Property(e => e.Price)
                .HasPrecision(10, 2)
                .HasColumnName("price");
            entity.Property(e => e.Qnt).HasColumnName("qnt");
            entity.Property(e => e.Weight)
                .HasPrecision(10, 2)
                .HasColumnName("weight");
            entity.Property(e => e.Width)
                .HasPrecision(10, 2)
                .HasColumnName("width");

            entity.HasOne(d => d.ConsultaProduto).WithMany()
                .HasForeignKey(d => d.ConsultaProdutoId)
                .HasConstraintName("fk_ec_tbl_consulta_produto_anymarket");
        });

        modelBuilder.Entity<EcTblCorreio>(entity =>
        {
            entity.HasKey(e => e.Cnpj).HasName("ec_tbl_correio_pkey");

            entity.ToTable("ec_tbl_correio", tb => tb.HasComment("Contém informações de Acesso para Consumir o WebService dos Corrêios"));

            entity.Property(e => e.Cnpj)
                .HasMaxLength(15)
                .HasColumnName("cnpj");
            entity.Property(e => e.BairroRemetente)
                .HasMaxLength(25)
                .HasColumnName("bairro_remetente");
            entity.Property(e => e.CepRemetente)
                .HasMaxLength(8)
                .HasColumnName("cep_remetente");
            entity.Property(e => e.CidadeRemetente)
                .HasMaxLength(15)
                .HasColumnName("cidade_remetente");
            entity.Property(e => e.CodigoAdministrativo)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("codigo_administrativo");
            entity.Property(e => e.ComplementoRemetente)
                .HasMaxLength(60)
                .HasColumnName("complemento_remetente");
            entity.Property(e => e.EmailRemetente)
                .HasMaxLength(45)
                .HasColumnName("email_remetente");
            entity.Property(e => e.FoneRemetente)
                .HasMaxLength(10)
                .HasColumnName("fone_remetente");
            entity.Property(e => e.IdCartaoPostagem)
                .HasMaxLength(30)
                .HasColumnName("id_cartao_postagem");
            entity.Property(e => e.IdContrato)
                .HasMaxLength(15)
                .HasColumnName("id_contrato");
            entity.Property(e => e.Identificador)
                .HasMaxLength(30)
                .HasColumnName("identificador");
            entity.Property(e => e.LogradouroRemetente)
                .HasMaxLength(60)
                .HasColumnName("logradouro_remetente");
            entity.Property(e => e.NomeRemetente)
                .HasMaxLength(60)
                .HasColumnName("nome_remetente");
            entity.Property(e => e.NumeroDiretoria)
                .HasMaxLength(5)
                .HasColumnName("numero_diretoria");
            entity.Property(e => e.NumeroRemetente)
                .HasMaxLength(10)
                .HasColumnName("numero_remetente");
            entity.Property(e => e.Senha)
                .HasMaxLength(20)
                .HasColumnName("senha");
            entity.Property(e => e.TipoDestinatario)
                .HasMaxLength(1)
                .HasColumnName("tipo_destinatario");
            entity.Property(e => e.UfRemetente)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("uf_remetente");
            entity.Property(e => e.Usuario)
                .HasMaxLength(15)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<EcTblCorreioPlp>(entity =>
        {
            entity.HasKey(e => e.Codpostagem).HasName("ec_tbl_correio_plp_pkey");

            entity.ToTable("ec_tbl_correio_plp", tb => tb.HasComment("Contém o XML que foram gerados os Objetos da PLP dos Corrêios"));

            entity.Property(e => e.Codpostagem)
                .HasMaxLength(13)
                .HasColumnName("codpostagem");
            entity.Property(e => e.CodFechaPlp).HasColumnName("cod_fecha_plp");
            entity.Property(e => e.CodigoPlp)
                .ValueGeneratedOnAdd()
                .HasColumnName("codigo_plp");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(12)
                .HasColumnName("codpedido");
            entity.Property(e => e.CodpostagemSemDigito)
                .HasMaxLength(13)
                .HasColumnName("codpostagem_sem_digito");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data");
            entity.Property(e => e.DataPlp)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data_plp");
            entity.Property(e => e.PlpXml)
                .HasColumnType("xml")
                .HasColumnName("plp_xml");
            entity.Property(e => e.Seguro).HasColumnName("seguro");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");
            entity.Property(e => e.VSeguro)
                .HasPrecision(10, 2)
                .HasColumnName("v_seguro");
        });

        modelBuilder.Entity<EcTblDepartamento>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("ec_tbl_departamento_pkey");

            entity.ToTable("ec_tbl_departamento", tb => tb.HasComment("Armazena os Departamentos  do Site E-commerce"));

            entity.HasIndex(e => e.Departamento, "ec_tbl_departamento_departamento_key").IsUnique();

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Atualizado)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("atualizado");
            entity.Property(e => e.AtualizadoWeb)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("atualizado_web");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.CodusuarioWeb).HasColumnName("codusuario_web");
            entity.Property(e => e.Departamento)
                .HasMaxLength(40)
                .HasColumnName("departamento");
            entity.Property(e => e.TagDescription)
                .HasMaxLength(160)
                .HasColumnName("tag_description");
            entity.Property(e => e.TagTitle)
                .HasMaxLength(80)
                .HasColumnName("tag_title");
        });

        modelBuilder.Entity<EcTblDepartamentoDiv>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_departamento_div_pkey");

            entity.ToTable("ec_tbl_departamento_div", tb => tb.HasComment("Armazena o ID da Divisão e do Departamento do E-commerce"));

            entity.HasIndex(e => new { e.Coddep, e.Coddiv }, "ec_tbl_departamento_div_coddep_coddiv_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Atualizado)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("atualizado");
            entity.Property(e => e.AtualizadoWeb)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("atualizado_web");
            entity.Property(e => e.Coddep).HasColumnName("coddep");
            entity.Property(e => e.Coddiv).HasColumnName("coddiv");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.CodusuarioWeb).HasColumnName("codusuario_web");
            entity.Property(e => e.Ordenacao)
                .HasDefaultValueSql("0")
                .HasColumnName("ordenacao");
        });

        modelBuilder.Entity<EcTblDivisao>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("ec_tbl_divisao_pkey");

            entity.ToTable("ec_tbl_divisao", tb => tb.HasComment("Armazena a Divisão do E-commerce"));

            entity.HasIndex(e => e.Divisao, "ec_tbl_divisao_divisao_key").IsUnique();

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Atualizado)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("atualizado");
            entity.Property(e => e.AtualizadoWeb)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("atualizado_web");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.CodusuarioWeb).HasColumnName("codusuario_web");
            entity.Property(e => e.Divisao)
                .HasMaxLength(60)
                .HasColumnName("divisao");
            entity.Property(e => e.Ordenacao)
                .HasDefaultValueSql("0")
                .HasColumnName("ordenacao");
            entity.Property(e => e.TagDescription)
                .HasMaxLength(160)
                .HasColumnName("tag_description");
            entity.Property(e => e.TagTitle)
                .HasMaxLength(80)
                .HasColumnName("tag_title");
        });

        modelBuilder.Entity<EcTblEstoqueSkyhubLog>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("ec_tbl_estoque_skyhub_log_pkey");

            entity.ToTable("ec_tbl_estoque_skyhub_log", tb => tb.HasComment("Log de alterações no estoque skyhub enviado pelo nosso ERP.\n\nJunior 29/04/2020"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Descricao)
                .HasMaxLength(200)
                .HasColumnName("descricao");
            entity.Property(e => e.Sucesso).HasColumnName("sucesso");
        });

        modelBuilder.Entity<EcTblEtiquetaMercadoLivre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_etiqueta_mercado_livre_pkey");

            entity.ToTable("ec_tbl_etiqueta_mercado_livre");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(15)
                .HasColumnName("codpedido");
            entity.Property(e => e.Etiqueta).HasColumnName("etiqueta");
            entity.Property(e => e.Rastreio)
                .HasMaxLength(40)
                .HasColumnName("rastreio");
        });

        modelBuilder.Entity<EcTblExpedicao>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("ec_tbl_expedicao_pkey");

            entity.ToTable("ec_tbl_expedicao", tb => tb.HasComment("Armazena a Expedição do E-commerce das Coletoras"));

            entity.Property(e => e.Codigo)
                .ValueGeneratedNever()
                .HasColumnName("codigo");
            entity.Property(e => e.BaixaRomaneio)
                .HasDefaultValueSql("false")
                .HasColumnName("baixa_romaneio");
            entity.Property(e => e.CodVeiculo).HasColumnName("cod_veiculo");
            entity.Property(e => e.DataBaixaRoma)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data_baixa_roma");
            entity.Property(e => e.DataDesembarque)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data_desembarque");
            entity.Property(e => e.DataEmbarque)
                .HasDefaultValueSql("('now'::text)::timestamp without time zone")
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data_embarque");
            entity.Property(e => e.DataNota)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data_nota");
            entity.Property(e => e.Desembarque)
                .HasDefaultValueSql("false")
                .HasColumnName("desembarque");
            entity.Property(e => e.Embarque)
                .HasDefaultValueSql("true")
                .HasColumnName("embarque");
            entity.Property(e => e.Nota).HasColumnName("nota");
            entity.Property(e => e.UserDesembarque).HasColumnName("user_desembarque");
            entity.Property(e => e.UserEmbarque).HasColumnName("user_embarque");
            entity.Property(e => e.UserNota).HasColumnName("user_nota");
            entity.Property(e => e.Volume)
                .HasMaxLength(7)
                .HasColumnName("volume");
        });

        modelBuilder.Entity<EcTblFreteGratisCidade>(entity =>
        {
            entity.HasKey(e => new { e.IdFrete, e.CodMunicipio }).HasName("ec_tbl_frete_gratis_cidade_pkey");

            entity.ToTable("ec_tbl_frete_gratis_cidade", tb => tb.HasComment("Não Esta Sendo Utilizada"));

            entity.Property(e => e.IdFrete).HasColumnName("id_frete");
            entity.Property(e => e.CodMunicipio).HasColumnName("cod_municipio");
        });

        modelBuilder.Entity<EcTblFreteGratisUf>(entity =>
        {
            entity.HasKey(e => new { e.IdFrete, e.CodUf }).HasName("ec_tbl_frete_gratis_uf_pkey");

            entity.ToTable("ec_tbl_frete_gratis_uf", tb => tb.HasComment("Não Esta Sendo Utilizada"));

            entity.Property(e => e.IdFrete).HasColumnName("id_frete");
            entity.Property(e => e.CodUf).HasColumnName("cod_uf");
        });

        modelBuilder.Entity<EcTblFreteTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_frete_template_pkey");

            entity.ToTable("ec_tbl_frete_template", tb => tb.HasComment("Não Esta Sendo Utilizada"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Atualizado)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("atualizado");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Datacriacao)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("datacriacao");
            entity.Property(e => e.Descricao)
                .HasMaxLength(30)
                .HasColumnName("descricao");
            entity.Property(e => e.Obs).HasColumnName("obs");
        });

        modelBuilder.Entity<EcTblFreteUf>(entity =>
        {
            entity.HasKey(e => new { e.IdFrete, e.CodUf }).HasName("ec_tbl_frete_uf_pkey");

            entity.ToTable("ec_tbl_frete_uf", tb => tb.HasComment("Não Esta Sendo Utilizada"));

            entity.Property(e => e.IdFrete).HasColumnName("id_frete");
            entity.Property(e => e.CodUf).HasColumnName("cod_uf");
        });

        modelBuilder.Entity<EcTblHeadersSkyhub>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("ec_tbl_headers_skyhub_pkey");

            entity.ToTable("ec_tbl_headers_skyhub", tb => tb.HasComment("Armazena a Chave de Acesso para a Skyhub.\nA coluna API contém os nomes de cada api na skyhub, estes nomes são utilizados numa série de métodos internos em nosso sistema.\nUtilizado na classe Marketplaces.cs"));

            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .HasColumnName("email");
            entity.Property(e => e.AccountmanagerKey)
                .HasMaxLength(100)
                .HasColumnName("accountmanager_key");
            entity.Property(e => e.Api)
                .HasMaxLength(10)
                .HasColumnName("api");
            entity.Property(e => e.ApiKey)
                .HasMaxLength(100)
                .HasColumnName("api_key");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Url)
                .HasMaxLength(100)
                .HasColumnName("url");
        });

        modelBuilder.Entity<EcTblItensDescDep>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("ec_tbl_itens_desc_dep_pkey");

            entity.ToTable("ec_tbl_itens_desc_dep", tb => tb.HasComment("Itens da descrição dos produtos por departamento"));

            entity.HasIndex(e => new { e.Coddep, e.Item }, "ec_tbl_itens_desc_dep_coddep_item_key").IsUnique();

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Coddep).HasColumnName("coddep");
            entity.Property(e => e.Item)
                .HasMaxLength(100)
                .HasColumnName("item");
            entity.Property(e => e.Ordenacao)
                .HasDefaultValueSql("9999")
                .HasColumnName("ordenacao");
        });

        modelBuilder.Entity<EcTblLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_log_pkey");

            entity.ToTable("ec_tbl_log", tb => tb.HasComment("Armazena os Logs de movimentação da Skyhub"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Descricao)
                .HasMaxLength(60)
                .HasColumnName("descricao");
            entity.Property(e => e.Log).HasColumnName("log");
            entity.Property(e => e.Tipo)
                .HasMaxLength(40)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<EcTblMetodoPgto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_metodo_pgto_pkey");

            entity.ToTable("ec_tbl_metodo_pgto", tb => tb.HasComment("Armazena os Meios de Pagamento  da Skyhub"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Metodo)
                .HasMaxLength(50)
                .HasColumnName("metodo");
        });

        modelBuilder.Entity<EcTblPedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_pedido_pkey");

            entity.ToTable("ec_tbl_pedido", tb => tb.HasComment("Armazena os Pedidos Gerado na Skyhub e E-commerce"));

            entity.HasIndex(e => new { e.Canal, e.Codigo }, "ec_tbl_pedido_canal_codigo_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Canal)
                .HasMaxLength(40)
                .HasColumnName("canal");
            entity.Property(e => e.ChaveEnviada)
                .HasDefaultValueSql("false")
                .HasColumnName("chave_enviada");
            entity.Property(e => e.ChaveEnviadaData)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("chave_enviada_data");
            entity.Property(e => e.CodPedidoCancelado)
                .HasMaxLength(12)
                .HasColumnName("cod_pedido_cancelado");
            entity.Property(e => e.CodPedidoNovo)
                .HasMaxLength(12)
                .HasColumnName("cod_pedido_novo");
            entity.Property(e => e.CodRastreio)
                .HasMaxLength(50)
                .HasColumnName("cod_rastreio");
            entity.Property(e => e.Codigo)
                .HasMaxLength(40)
                .HasColumnName("codigo");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(12)
                .HasColumnName("codpedido");
            entity.Property(e => e.Codprepedido)
                .HasDefaultValueSql("0")
                .HasColumnName("codprepedido");
            entity.Property(e => e.Confirmado)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("confirmado");
            entity.Property(e => e.CustoEntrega)
                .HasPrecision(6, 2)
                .HasColumnName("custo_entrega");
            entity.Property(e => e.DataAtualizado)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_atualizado");
            entity.Property(e => e.DataPedido)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_pedido");
            entity.Property(e => e.DataPedidoInterno)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data_pedido_interno");
            entity.Property(e => e.DataPrepedido)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data_prepedido");
            entity.Property(e => e.EntregaEstimada)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("entrega_estimada");
            entity.Property(e => e.EventoCodigo)
                .HasMaxLength(3)
                .HasColumnName("evento_codigo");
            entity.Property(e => e.EventoDetalhe)
                .HasMaxLength(100)
                .HasColumnName("evento_detalhe");
            entity.Property(e => e.EventoHora).HasColumnName("evento_hora");
            entity.Property(e => e.EventoLocal)
                .HasMaxLength(100)
                .HasColumnName("evento_local");
            entity.Property(e => e.EventoUf)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("evento_uf");
            entity.Property(e => e.EvntoData).HasColumnName("evnto_data");
            entity.Property(e => e.Excluido)
                .HasDefaultValueSql("false")
                .HasColumnName("excluido");
            entity.Property(e => e.IdMarketplace)
                .HasMaxLength(40)
                .HasColumnName("id_marketplace");
            entity.Property(e => e.Marketplace)
                .HasMaxLength(40)
                .HasColumnName("marketplace");
            entity.Property(e => e.MetodoEntrega)
                .HasMaxLength(300)
                .HasColumnName("metodo_entrega");
            entity.Property(e => e.ObjetoEntregue)
                .HasDefaultValueSql("false")
                .HasColumnName("objeto_entregue");
            entity.Property(e => e.ObjetoEntregueData)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("objeto_entregue_data");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.RastreioEnviado)
                .HasDefaultValueSql("false")
                .HasColumnName("rastreio_enviado");
            entity.Property(e => e.RastreioEnviadoData)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("rastreio_enviado_data");
            entity.Property(e => e.ValorDesconto)
                .HasPrecision(9, 2)
                .HasColumnName("valor_desconto");
            entity.Property(e => e.ValorJuro)
                .HasPrecision(9, 2)
                .HasColumnName("valor_juro");
            entity.Property(e => e.ValorTotal)
                .HasPrecision(10, 2)
                .HasColumnName("valor_total");
            entity.Property(e => e.VendedorVinculado).HasColumnName("vendedor_vinculado");
        });

        modelBuilder.Entity<EcTblPedidoCliente>(entity =>
        {
            entity.HasKey(e => e.IdPedido).HasName("ec_tbl_pedido_cliente_pkey");

            entity.ToTable("ec_tbl_pedido_cliente", tb => tb.HasComment("Armazena os Clientes Gerado na Skyhub e E-commerce"));

            entity.Property(e => e.IdPedido)
                .ValueGeneratedNever()
                .HasColumnName("id_pedido");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .HasColumnName("documento");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasColumnName("email");
            entity.Property(e => e.Fone)
                .HasColumnType("character varying(20)[]")
                .HasColumnName("fone");
            entity.Property(e => e.Genero)
                .HasMaxLength(15)
                .HasColumnName("genero");
            entity.Property(e => e.Nascimento).HasColumnName("nascimento");
            entity.Property(e => e.Nome)
                .HasMaxLength(120)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<EcTblPedidoEndCobranca>(entity =>
        {
            entity.HasKey(e => e.IdPedido).HasName("ec_tbl_pedido_end_cobranca_pkey");

            entity.ToTable("ec_tbl_pedido_end_cobranca", tb => tb.HasComment("Armazena os Endereços de Cobranca Gerado na Skyhub e E-commerce"));

            entity.Property(e => e.IdPedido)
                .ValueGeneratedNever()
                .HasColumnName("id_pedido");
            entity.Property(e => e.Bairro)
                .HasMaxLength(150)
                .HasColumnName("bairro");
            entity.Property(e => e.Cep)
                .HasMaxLength(15)
                .HasColumnName("cep");
            entity.Property(e => e.Cidade)
                .HasMaxLength(120)
                .HasColumnName("cidade");
            entity.Property(e => e.Complemento)
                .HasMaxLength(250)
                .HasColumnName("complemento");
            entity.Property(e => e.Endereco)
                .HasMaxLength(150)
                .HasColumnName("endereco");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
            entity.Property(e => e.Numero)
                .HasMaxLength(100)
                .HasColumnName("numero");
            entity.Property(e => e.Pais)
                .HasMaxLength(5)
                .HasColumnName("pais");

            entity.HasOne(d => d.IdPedidoNavigation).WithOne(p => p.EcTblPedidoEndCobranca)
                .HasForeignKey<EcTblPedidoEndCobranca>(d => d.IdPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ec_tbl_pedido_end_cobranca_id_pedido_fkey");
        });

        modelBuilder.Entity<EcTblPedidoEndEntrega>(entity =>
        {
            entity.HasKey(e => e.IdPedido).HasName("ec_tbl_pedido_end_entrega_pkey");

            entity.ToTable("ec_tbl_pedido_end_entrega", tb => tb.HasComment("Armazena os Endereços de Entrega Gerado na Skyhub e E-commerce"));

            entity.Property(e => e.IdPedido)
                .ValueGeneratedNever()
                .HasColumnName("id_pedido");
            entity.Property(e => e.Bairro)
                .HasMaxLength(150)
                .HasColumnName("bairro");
            entity.Property(e => e.Cep)
                .HasMaxLength(15)
                .HasColumnName("cep");
            entity.Property(e => e.Cidade)
                .HasMaxLength(120)
                .HasColumnName("cidade");
            entity.Property(e => e.Complemento)
                .HasMaxLength(250)
                .HasColumnName("complemento");
            entity.Property(e => e.Endereco)
                .HasMaxLength(150)
                .HasColumnName("endereco");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
            entity.Property(e => e.Numero)
                .HasMaxLength(60)
                .HasColumnName("numero");
            entity.Property(e => e.Pais)
                .HasMaxLength(5)
                .HasColumnName("pais");

            entity.HasOne(d => d.IdPedidoNavigation).WithOne(p => p.EcTblPedidoEndEntrega)
                .HasForeignKey<EcTblPedidoEndEntrega>(d => d.IdPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ec_tbl_pedido_end_entrega_id_pedido_fkey");
        });

        modelBuilder.Entity<EcTblPedidoEntradum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_pedido_entrada_pkey");

            entity.ToTable("ec_tbl_pedido_entrada", tb => tb.HasComment("Armazena o Json do Status do Pedido na Skyhub"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Arquivo).HasColumnName("arquivo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(150)
                .HasColumnName("codigo");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data");
        });

        modelBuilder.Entity<EcTblPedidoIten>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_pedido_itens_pkey");

            entity.ToTable("ec_tbl_pedido_itens", tb => tb.HasComment("Armazena os Itens Gerado  no  Pedido da  Skyhub e E-commerce"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodItem)
                .HasMaxLength(16)
                .HasColumnName("cod_item");
            entity.Property(e => e.CodProduto)
                .HasMaxLength(16)
                .HasColumnName("cod_produto");
            entity.Property(e => e.IdPedido).HasColumnName("id_pedido");
            entity.Property(e => e.Montagem)
                .HasPrecision(9, 2)
                .HasColumnName("montagem");
            entity.Property(e => e.Nome)
                .HasMaxLength(160)
                .HasColumnName("nome");
            entity.Property(e => e.Quant).HasColumnName("quant");
            entity.Property(e => e.Valor)
                .HasPrecision(9, 2)
                .HasColumnName("valor");
            entity.Property(e => e.ValorPromo)
                .HasPrecision(9, 2)
                .HasColumnName("valor_promo");
        });

        modelBuilder.Entity<EcTblPedidoManual>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_pedido_manual_pkey");

            entity.ToTable("ec_tbl_pedido_manual", tb => tb.HasComment("tabela provisória para guardar os códigos de pedido dos marketplaces, gerados manualmente.\n\nJunior - 24/06/2020"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodEc)
                .HasMaxLength(30)
                .HasColumnName("cod_ec");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(15)
                .HasColumnName("codpedido");
            entity.Property(e => e.Codprepedido).HasColumnName("codprepedido");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
        });

        modelBuilder.Entity<EcTblPedidoPagamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_pedido_pagamento_pkey");

            entity.ToTable("ec_tbl_pedido_pagamento", tb => tb.HasComment("Armazena as Parcelas e Forma de Pagamento Gerado na Skyhub e E-commerce"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodigoPagamento)
                .HasMaxLength(100)
                .HasColumnName("codigo_pagamento");
            entity.Property(e => e.Descricao).HasColumnName("descricao");
            entity.Property(e => e.IdPedido).HasColumnName("id_pedido");
            entity.Property(e => e.Metodo)
                .HasMaxLength(90)
                .HasColumnName("metodo");
            entity.Property(e => e.Parcelas).HasColumnName("parcelas");
            entity.Property(e => e.Valor)
                .HasPrecision(9, 2)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<EcTblPedidoRastreio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_pedido_rastreio_pkey");

            entity.ToTable("ec_tbl_pedido_rastreio", tb => tb.HasComment("Armazena o Status do Rastreio dos Produtos na Skyhub e no E-commerce"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cidade)
                .HasMaxLength(80)
                .HasColumnName("cidade");
            entity.Property(e => e.CodRastreio)
                .HasMaxLength(20)
                .HasColumnName("cod_rastreio");
            entity.Property(e => e.Codigo)
                .HasMaxLength(12)
                .HasColumnName("codigo");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(12)
                .HasColumnName("codpedido");
            entity.Property(e => e.DataConsulta)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data_consulta");
            entity.Property(e => e.DataCorreio).HasColumnName("data_correio");
            entity.Property(e => e.Descricao)
                .HasMaxLength(255)
                .HasColumnName("descricao");
            entity.Property(e => e.HoraCorreio).HasColumnName("hora_correio");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Tipo)
                .HasMaxLength(3)
                .HasColumnName("tipo");
            entity.Property(e => e.UsuarioConsulta).HasColumnName("usuario_consulta");
        });

        modelBuilder.Entity<EcTblPedidoStatus>(entity =>
        {
            entity.HasKey(e => e.IdPedido).HasName("ec_tbl_pedido_status_pkey");

            entity.ToTable("ec_tbl_pedido_status", tb => tb.HasComment("Armazena o Statudos do Pedido na Skyhub e E-commerce"));

            entity.Property(e => e.IdPedido)
                .ValueGeneratedNever()
                .HasColumnName("id_pedido");
            entity.Property(e => e.Codigo)
                .HasMaxLength(35)
                .HasColumnName("codigo");
            entity.Property(e => e.Label)
                .HasMaxLength(80)
                .HasColumnName("label");
            entity.Property(e => e.Tipo)
                .HasMaxLength(30)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<EcTblPedidoTranspNotum>(entity =>
        {
            entity.HasKey(e => e.Codpedido).HasName("ec_tbl_pedido_transp_nota_pkey");

            entity.ToTable("ec_tbl_pedido_transp_nota", tb => tb.HasComment("Armazena a Informação da Nota de cada Pedido"));

            entity.Property(e => e.Codpedido)
                .HasMaxLength(12)
                .HasColumnName("codpedido");
            entity.Property(e => e.EspecieVolume)
                .HasMaxLength(50)
                .HasColumnName("especie_volume");
            entity.Property(e => e.IdTransportadora).HasColumnName("id_transportadora");
            entity.Property(e => e.PesoBruto)
                .HasPrecision(8, 4)
                .HasColumnName("peso_bruto");
            entity.Property(e => e.PesoLiq)
                .HasPrecision(8, 4)
                .HasColumnName("peso_liq");
            entity.Property(e => e.QuantVol).HasColumnName("quant_vol");
        });

        modelBuilder.Entity<EcTblPedidosAmazonTemporario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_pedidos_amazon_temporario_pkey");

            entity.ToTable("ec_tbl_pedidos_amazon_temporario");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodigoSkyhub)
                .HasColumnType("character varying")
                .HasColumnName("codigo_skyhub");
            entity.Property(e => e.Codpedido)
                .HasColumnType("character varying")
                .HasColumnName("codpedido");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Json).HasColumnName("json");
        });

        modelBuilder.Entity<EcTblPlpDirect>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_plp_direct_pkey");

            entity.ToTable("ec_tbl_plp_direct");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codigoawb)
                .HasMaxLength(40)
                .HasColumnName("codigoawb");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(12)
                .HasColumnName("codpedido");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("'2022-08-01 08:46:28.164675'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Dtprometida)
                .HasMaxLength(8)
                .HasColumnName("dtprometida");
            entity.Property(e => e.Megarota)
                .HasMaxLength(30)
                .HasColumnName("megarota");
            entity.Property(e => e.Plp)
                .HasMaxLength(30)
                .HasColumnName("plp");
            entity.Property(e => e.Rota)
                .HasMaxLength(20)
                .HasColumnName("rota");
            entity.Property(e => e.Volume).HasColumnName("volume");
        });

        modelBuilder.Entity<EcTblProduto>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("ec_tbl_produto_pkey");

            entity.ToTable("ec_tbl_produto", tb => tb.HasComment("Armazena os Produtos da Skyhub e Visualizar se foi gerado na Skyhub"));

            entity.HasIndex(e => e.Codproduto, "ec_tbl_produto_codproduto_key").IsUnique();

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("ativo");
            entity.Property(e => e.Atualizado)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("atualizado");
            entity.Property(e => e.AtualizadoWeb)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("atualizado_web");
            entity.Property(e => e.CadastroSkyhub)
                .HasDefaultValueSql("false")
                .HasColumnName("cadastro_skyhub");
            entity.Property(e => e.CodB2w)
                .HasMaxLength(70)
                .HasColumnName("cod_b2w");
            entity.Property(e => e.Codcor).HasColumnName("codcor");
            entity.Property(e => e.Coddep).HasColumnName("coddep");
            entity.Property(e => e.Codmarca).HasColumnName("codmarca");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.CodprodutoGarantia)
                .HasMaxLength(12)
                .HasColumnName("codproduto_garantia");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.CodusuarioWeb).HasColumnName("codusuario_web");
            entity.Property(e => e.Codvoltagem)
                .HasDefaultValueSql("0")
                .HasColumnName("codvoltagem");
            entity.Property(e => e.CustoAlterado)
                .HasDefaultValueSql("false")
                .HasColumnName("custo_alterado");
            entity.Property(e => e.DataCiente)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data_ciente");
            entity.Property(e => e.Descricao)
                .HasMaxLength(150)
                .HasColumnName("descricao");
            entity.Property(e => e.Grupo)
                .HasDefaultValueSql("0")
                .HasColumnName("grupo");
            entity.Property(e => e.LinkB2w).HasColumnName("link_b2w");
            entity.Property(e => e.Observacao)
                .HasComment("observações da tela FrmCalculoPrecoMarketPlace")
                .HasColumnName("observacao");
            entity.Property(e => e.Tamanho)
                .HasMaxLength(12)
                .HasColumnName("tamanho");
            entity.Property(e => e.UsuarioCiente).HasColumnName("usuario_ciente");
            entity.Property(e => e.Volume)
                .HasDefaultValueSql("0")
                .HasColumnName("volume");
        });

        modelBuilder.Entity<EcTblProdutoDesc>(entity =>
        {
            entity.HasKey(e => e.Codproduto).HasName("ec_tbl_produto_desc_pkey1");

            entity.ToTable("ec_tbl_produto_desc", tb => tb.HasComment("Descrição dos Produtos  na Skyhub e E-commerce"));

            entity.Property(e => e.Codproduto)
                .ValueGeneratedNever()
                .HasColumnName("codproduto");
            entity.Property(e => e.Descricao).HasColumnName("descricao");
        });

        modelBuilder.Entity<EcTblProdutoDescComp>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("ec_tbl_produto_desc_pkey");

            entity.ToTable("ec_tbl_produto_desc_comp", tb => tb.HasComment("Tabela de descrição completa do produto"));

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('ec_tbl_produto_desc_codigo_seq'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Codproduto).HasColumnName("codproduto");
            entity.Property(e => e.Descricao).HasColumnName("descricao");
            entity.Property(e => e.Item).HasColumnName("item");
            entity.Property(e => e.Ordenacao).HasColumnName("ordenacao");
        });

        modelBuilder.Entity<EcTblProdutoDescHist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ec_tbl_produto_desc_hist", tb => tb.HasComment("Histórico de Atualização dos Produtos na Skyhub e E-commerce"));

            entity.Property(e => e.Atualizado)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("atualizado");
            entity.Property(e => e.AtualizadoWeb)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("atualizado_web");
            entity.Property(e => e.Codproduto).HasColumnName("codproduto");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.CodusuarioWeb).HasColumnName("codusuario_web");
        });

        modelBuilder.Entity<EcTblProdutoMedida>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_produto_medidas_pkey");

            entity.ToTable("ec_tbl_produto_medidas", tb => tb.HasComment("Armazena as Medidas dos Produtos Gerado na Skyhub e E-commerce"));

            entity.HasIndex(e => new { e.Codproduto, e.Vol }, "ec_tbl_produto_medidas_codproduto_vol_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alt)
                .HasPrecision(6, 2)
                .HasColumnName("alt");
            entity.Property(e => e.Atualizado)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("atualizado");
            entity.Property(e => e.AtualizadoWeb)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("atualizado_web");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.CodusuarioWeb).HasColumnName("codusuario_web");
            entity.Property(e => e.Lar)
                .HasPrecision(6, 2)
                .HasColumnName("lar");
            entity.Property(e => e.Mc)
                .HasPrecision(8, 4)
                .HasColumnName("mc");
            entity.Property(e => e.Peso)
                .HasPrecision(8, 4)
                .HasColumnName("peso");
            entity.Property(e => e.PesoCubado)
                .HasPrecision(8, 4)
                .HasColumnName("peso_cubado");
            entity.Property(e => e.Pro)
                .HasPrecision(6, 2)
                .HasColumnName("pro");
            entity.Property(e => e.Total)
                .HasDefaultValueSql("false")
                .HasColumnName("total");
            entity.Property(e => e.Vol).HasColumnName("vol");
        });

        modelBuilder.Entity<EcTblProdutoMk>(entity =>
        {
            entity.HasKey(e => e.Codproduto).HasName("ec_tbl_produto_mk_pkey");

            entity.ToTable("ec_tbl_produto_mk", tb => tb.HasComment("Armazena os Produtos na Skyhub "));

            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Descricao)
                .HasMaxLength(150)
                .HasColumnName("descricao");
            entity.Property(e => e.Ean)
                .HasMaxLength(15)
                .HasColumnName("ean");
            entity.Property(e => e.SkuSky)
                .HasMaxLength(15)
                .HasColumnName("sku_sky");
        });

        modelBuilder.Entity<EcTblProdutoMkBybox>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_produto_mk_bybox_pkey");

            entity.ToTable("ec_tbl_produto_mk_bybox", tb => tb.HasComment("Não esta sendo utilizada"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.DataConsulta)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data_consulta");
            entity.Property(e => e.Ultima)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("ultima");
            entity.Property(e => e.Valor)
                .HasPrecision(12, 2)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<EcTblProdutoPagInicio>(entity =>
        {
            entity.HasKey(e => e.Codproduto).HasName("ec_tbl_produto_pag_inicio_pkey");

            entity.ToTable("ec_tbl_produto_pag_inicio", tb => tb.HasComment("Produtos para ser exibido na página inicial do e-commerce"));

            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Index).HasColumnName("index");
        });

        modelBuilder.Entity<EcTblProdutoPrecoB2w>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_produto_preco_b2w_pkey");

            entity.ToTable("ec_tbl_produto_preco_b2w", tb => tb.HasComment("Preço dos Produtos na Skyhub"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.CodusuarioEnviou).HasColumnName("codusuario_enviou");
            entity.Property(e => e.Cofins)
                .HasPrecision(4, 2)
                .HasColumnName("cofins");
            entity.Property(e => e.Comissaomkp)
                .HasPrecision(4, 2)
                .HasColumnName("comissaomkp");
            entity.Property(e => e.Custo)
                .HasPrecision(7, 2)
                .HasColumnName("custo");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data");
            entity.Property(e => e.DataEnvio)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data_envio");
            entity.Property(e => e.DespEnvio)
                .HasPrecision(7, 2)
                .HasColumnName("desp_envio");
            entity.Property(e => e.Difal)
                .HasPrecision(4, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("difal");
            entity.Property(e => e.Icms)
                .HasPrecision(4, 2)
                .HasColumnName("icms");
            entity.Property(e => e.MargemLucro)
                .HasPrecision(7, 4)
                .HasColumnName("margem_lucro");
            entity.Property(e => e.Markup)
                .HasPrecision(7, 4)
                .HasColumnName("markup");
            entity.Property(e => e.OpLogistico)
                .HasPrecision(4, 2)
                .HasColumnName("op_logistico");
            entity.Property(e => e.Outros)
                .HasPrecision(4, 2)
                .HasColumnName("outros");
            entity.Property(e => e.Pis)
                .HasPrecision(4, 2)
                .HasColumnName("pis");
            entity.Property(e => e.PrevDev)
                .HasPrecision(4, 2)
                .HasColumnName("prev_dev");
            entity.Property(e => e.PrevEntrada)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("prev_entrada");
            entity.Property(e => e.TaxaAntecipa)
                .HasPrecision(4, 2)
                .HasColumnName("taxa_antecipa");
            entity.Property(e => e.Venda)
                .HasPrecision(7, 2)
                .HasColumnName("venda");
        });

        modelBuilder.Entity<EcTblProdutoValor>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("ec_tbl_produto_valor_pkey");

            entity.ToTable("ec_tbl_produto_valor", tb => tb.HasComment("Valor dos Produtos  e  em quantas parcelas na Skyhub"));

            entity.HasIndex(e => new { e.Codproduto, e.Datainicio }, "ec_tbl_produto_valor_codproduto_datainicio_key").IsUnique();

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('tbl_produto_valor_codigo_seq'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Atualizado)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("atualizado");
            entity.Property(e => e.AtualizadoWeb)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("atualizado_web");
            entity.Property(e => e.Codproduto).HasColumnName("codproduto");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.CodusuarioWeb).HasColumnName("codusuario_web");
            entity.Property(e => e.Datainicio)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("datainicio");
            entity.Property(e => e.IdFrete)
                .HasDefaultValueSql("1")
                .HasColumnName("id_frete");
            entity.Property(e => e.ValorAvista)
                .HasPrecision(8, 2)
                .HasColumnName("valor_avista");
            entity.Property(e => e.ValorDe)
                .HasPrecision(8, 2)
                .HasColumnName("valor_de");
            entity.Property(e => e.ValorEm)
                .HasMaxLength(60)
                .HasColumnName("valor_em");
            entity.Property(e => e.ValorPor)
                .HasPrecision(8, 2)
                .HasColumnName("valor_por");
        });

        modelBuilder.Entity<EcTblProdutoValorParc>(entity =>
        {
            entity.HasKey(e => new { e.Codvalor, e.Quantparc }).HasName("ec_tbl_produto_valor_parc_pkey");

            entity.ToTable("ec_tbl_produto_valor_parc", tb => tb.HasComment("Valor das Parcelas na Skyhub"));

            entity.Property(e => e.Codvalor).HasColumnName("codvalor");
            entity.Property(e => e.Quantparc).HasColumnName("quantparc");
            entity.Property(e => e.Detalhe)
                .HasMaxLength(30)
                .HasColumnName("detalhe");
            entity.Property(e => e.Exibir).HasColumnName("exibir");
            entity.Property(e => e.Taxa)
                .HasPrecision(4, 2)
                .HasColumnName("taxa");
            entity.Property(e => e.Valor)
                .HasPrecision(8, 2)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<EcTblProdutoVariacaoSkyhub>(entity =>
        {
            entity.HasKey(e => e.CodprodutoPai).HasName("ec_tbl_produto_variacao_skyhub_pkey");

            entity.ToTable("ec_tbl_produto_variacao_skyhub", tb => tb.HasComment("Armazena os produtos da skyhub e coloca no campo variação, quanod este mesmo produto é agrupado por cores ou voltagem, quer dizer que existe varios produtos agrupados."));

            entity.Property(e => e.CodprodutoPai)
                .HasMaxLength(16)
                .HasColumnName("codproduto_pai");
            entity.Property(e => e.Descricao)
                .HasMaxLength(150)
                .HasColumnName("descricao");
            entity.Property(e => e.Variacao).HasColumnName("variacao");
        });

        modelBuilder.Entity<EcTblProdutosUrl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_produtos_urls_pkey");

            entity.ToTable("ec_tbl_produtos_urls", tb => tb.HasComment("Link dos produtos na skyhub - Americanas ou Submarino"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Canal)
                .HasMaxLength(30)
                .HasColumnName("canal");
            entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");
            entity.Property(e => e.Datetime)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("datetime");
            entity.Property(e => e.Href).HasColumnName("href");
            entity.Property(e => e.Sku)
                .HasMaxLength(12)
                .HasColumnName("sku");
        });

        modelBuilder.Entity<EcTblProtocolo>(entity =>
        {
            entity.HasKey(e => e.Numeroprotocolo).HasName("ec_tbl_protocolos_pkey");

            entity.ToTable("ec_tbl_protocolos");

            entity.Property(e => e.Numeroprotocolo).HasColumnName("numeroprotocolo");
            entity.Property(e => e.Clienteatendidopor)
                .HasMaxLength(50)
                .HasColumnName("clienteatendidopor");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codoperador)
                .HasMaxLength(50)
                .HasColumnName("codoperador");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(12)
                .HasColumnName("codpedido");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .IsFixedLength()
                .HasColumnName("codproduto");
            entity.Property(e => e.Codproduto21)
                .HasMaxLength(12)
                .IsFixedLength()
                .HasColumnName("codproduto21");
            entity.Property(e => e.Codproduto22)
                .HasMaxLength(12)
                .IsFixedLength()
                .HasColumnName("codproduto22");
            entity.Property(e => e.Codromaneio).HasColumnName("codromaneio");
            entity.Property(e => e.Dataidusuario).HasColumnName("dataidusuario");
            entity.Property(e => e.Dataidusuarioassist).HasColumnName("dataidusuarioassist");
            entity.Property(e => e.Dataidusuariocatenf).HasColumnName("dataidusuariocatenf");
            entity.Property(e => e.Dataidusuarioconf).HasColumnName("dataidusuarioconf");
            entity.Property(e => e.Dataidusuariodep).HasColumnName("dataidusuariodep");
            entity.Property(e => e.Dataidusuarioex).HasColumnName("dataidusuarioex");
            entity.Property(e => e.Dataidusuariofiscal).HasColumnName("dataidusuariofiscal");
            entity.Property(e => e.Dataidusuarioinc).HasColumnName("dataidusuarioinc");
            entity.Property(e => e.Dataliberacao).HasColumnName("dataliberacao");
            entity.Property(e => e.Dataprotocolo).HasColumnName("dataprotocolo");
            entity.Property(e => e.Datarecebimento).HasColumnName("datarecebimento");
            entity.Property(e => e.Datarecebimento1).HasColumnName("datarecebimento1");
            entity.Property(e => e.Datarecebimento2).HasColumnName("datarecebimento2");
            entity.Property(e => e.Datarecebimento3).HasColumnName("datarecebimento3");
            entity.Property(e => e.Datarecebimento4).HasColumnName("datarecebimento4");
            entity.Property(e => e.Datarecebimento5).HasColumnName("datarecebimento5");
            entity.Property(e => e.Idusuario)
                .HasMaxLength(50)
                .HasColumnName("idusuario");
            entity.Property(e => e.Idusuarioassist)
                .HasMaxLength(50)
                .HasColumnName("idusuarioassist");
            entity.Property(e => e.Idusuariocatenf)
                .HasMaxLength(50)
                .HasColumnName("idusuariocatenf");
            entity.Property(e => e.Idusuarioconf)
                .HasMaxLength(50)
                .HasColumnName("idusuarioconf");
            entity.Property(e => e.Idusuariodep)
                .HasMaxLength(50)
                .HasColumnName("idusuariodep");
            entity.Property(e => e.Idusuarioex)
                .HasMaxLength(50)
                .HasColumnName("idusuarioex");
            entity.Property(e => e.Idusuariofiscal)
                .HasMaxLength(50)
                .HasColumnName("idusuariofiscal");
            entity.Property(e => e.Idusuarioinc)
                .HasMaxLength(50)
                .HasColumnName("idusuarioinc");
            entity.Property(e => e.Loja)
                .HasMaxLength(15)
                .HasColumnName("loja");
            entity.Property(e => e.Metodoentrega)
                .HasMaxLength(50)
                .HasColumnName("metodoentrega");
            entity.Property(e => e.Motivocancelamento)
                .HasMaxLength(100)
                .HasColumnName("motivocancelamento");
            entity.Property(e => e.Nome)
                .HasMaxLength(200)
                .HasColumnName("nome");
            entity.Property(e => e.Notadevolucao).HasColumnName("notadevolucao");
            entity.Property(e => e.Notafiscal).HasColumnName("notafiscal");
            entity.Property(e => e.Numos)
                .HasMaxLength(100)
                .HasColumnName("numos");
            entity.Property(e => e.Obs)
                .HasMaxLength(200)
                .HasColumnName("obs");
            entity.Property(e => e.Obsassist)
                .HasMaxLength(200)
                .HasColumnName("obsassist");
            entity.Property(e => e.Obsconf)
                .HasMaxLength(200)
                .HasColumnName("obsconf");
            entity.Property(e => e.Obsdep)
                .HasMaxLength(200)
                .HasColumnName("obsdep");
            entity.Property(e => e.Obsexp)
                .HasMaxLength(200)
                .HasColumnName("obsexp");
            entity.Property(e => e.Obsfiscal)
                .HasMaxLength(200)
                .HasColumnName("obsfiscal");
            entity.Property(e => e.Obsinclusao)
                .HasMaxLength(200)
                .HasColumnName("obsinclusao");
            entity.Property(e => e.Pesocubado)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("pesocubado");
            entity.Property(e => e.Produtovai)
                .HasMaxLength(50)
                .HasColumnName("produtovai");
            entity.Property(e => e.Situacaoproduto)
                .HasMaxLength(50)
                .HasColumnName("situacaoproduto");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .HasColumnName("status");
            entity.Property(e => e.Tipoatendimento)
                .HasMaxLength(200)
                .HasColumnName("tipoatendimento");
            entity.Property(e => e.Tipoprotocolo)
                .HasMaxLength(200)
                .HasColumnName("tipoprotocolo");
            entity.Property(e => e.Transfavaria)
                .HasMaxLength(50)
                .HasColumnName("transfavaria");
            entity.Property(e => e.Transpretorno)
                .HasMaxLength(50)
                .HasColumnName("transpretorno");
            entity.Property(e => e.Usuarioec)
                .HasMaxLength(50)
                .HasColumnName("usuarioec");
            entity.Property(e => e.Usuarioexp)
                .HasMaxLength(50)
                .HasColumnName("usuarioexp");
        });

        modelBuilder.Entity<EcTblTransportadora>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_transportadora_pkey");

            entity.ToTable("ec_tbl_transportadora", tb => tb.HasComment("Transportadoras Cadastradas na Intelepost"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ativo).HasColumnName("ativo");
            entity.Property(e => e.Bairro)
                .HasMaxLength(60)
                .HasColumnName("bairro");
            entity.Property(e => e.Cep)
                .HasMaxLength(9)
                .HasColumnName("cep");
            entity.Property(e => e.Cidade)
                .HasMaxLength(60)
                .HasColumnName("cidade");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(18)
                .HasColumnName("cnpj");
            entity.Property(e => e.CodigoServicoPostagem)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("codigo_servico_postagem");
            entity.Property(e => e.DataCadastro).HasColumnName("data_cadastro");
            entity.Property(e => e.EmailEnvioNfexml)
                .HasMaxLength(150)
                .HasColumnName("email_envio_nfexml");
            entity.Property(e => e.Endereco)
                .HasMaxLength(80)
                .HasColumnName("endereco");
            entity.Property(e => e.Fone)
                .HasMaxLength(14)
                .HasColumnName("fone");
            entity.Property(e => e.IdServicoCorreios)
                .HasMaxLength(20)
                .HasColumnName("id_servico_correios");
            entity.Property(e => e.Ie)
                .HasMaxLength(15)
                .HasColumnName("ie");
            entity.Property(e => e.Login)
                .HasColumnType("character varying")
                .HasColumnName("login");
            entity.Property(e => e.Metodo)
                .HasMaxLength(30)
                .HasColumnName("metodo");
            entity.Property(e => e.NomeEcommerce)
                .HasMaxLength(80)
                .HasColumnName("nome_ecommerce");
            entity.Property(e => e.Rsocial)
                .HasMaxLength(80)
                .HasColumnName("rsocial");
            entity.Property(e => e.Transportadora)
                .HasMaxLength(50)
                .HasColumnName("transportadora");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("uf");
            entity.Property(e => e.Url)
                .HasMaxLength(100)
                .HasColumnName("url");
        });

        modelBuilder.Entity<EcTblTransportadoraAliqComissaoFrete>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_transportadora_aliq_comissao_frete_pkey");

            entity.ToTable("ec_tbl_transportadora_aliq_comissao_frete", tb => tb.HasComment("utilizado na composição do preço de venda ecommerce"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AliqComissao).HasColumnName("aliq_comissao");
            entity.Property(e => e.AliqComissaoFrete).HasColumnName("aliq_comissao_frete");
            entity.Property(e => e.Canal)
                .HasMaxLength(10)
                .HasColumnName("canal");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
        });

        modelBuilder.Entity<EcTblTransportadoraDirect>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("ec_tbl_transportadora_direct_pkey");

            entity.ToTable("ec_tbl_transportadora_direct", tb => tb.HasComment("[nao mais utilizado a partir de 25/02/2021] "));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.AteKg).HasColumnName("ate_kg");
            entity.Property(e => e.DeKg).HasColumnName("de_kg");
            entity.Property(e => e.Grupo1Integral).HasColumnName("grupo1_integral");
            entity.Property(e => e.Grupo240Perc).HasColumnName("grupo2_40_perc");
            entity.Property(e => e.Grupo350Perc).HasColumnName("grupo3_50_perc");
            entity.Property(e => e.Grupo460Perc).HasColumnName("grupo4_60_perc");
        });

        modelBuilder.Entity<EcTblTransportadoraSellerIndex>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ec_tbl_transportadora_seller_index_pkey");

            entity.ToTable("ec_tbl_transportadora_seller_index", tb => tb.HasComment("[nao mais utilizado a partir de 25/02/2021] contém a nota atual da empresa na b2w"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.SellerIndex).HasColumnName("seller_index");
        });

        modelBuilder.Entity<EcTblVoltagem>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("ec_tbl_voltagem_pkey");

            entity.ToTable("ec_tbl_voltagem", tb => tb.HasComment("Voltagem dos Produtos no E-commerce"));

            entity.Property(e => e.Codigo)
                .ValueGeneratedNever()
                .HasColumnName("codigo");
            entity.Property(e => e.Voltagem)
                .HasMaxLength(7)
                .HasColumnName("voltagem");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("logs_pkey");

            entity.ToTable("logs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acao).HasColumnName("acao");
            entity.Property(e => e.DadosAntigos)
                .HasColumnType("jsonb")
                .HasColumnName("dados_antigos");
            entity.Property(e => e.DadosNovos)
                .HasColumnType("jsonb")
                .HasColumnName("dados_novos");
            entity.Property(e => e.DataHora)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_hora");
            entity.Property(e => e.Ip).HasColumnName("ip");
            entity.Property(e => e.Tabela).HasColumnName("tabela");
        });

        modelBuilder.Entity<LogAlteraco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("log_alteracoes_pkey");

            entity.ToTable("log_alteracoes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acao).HasColumnName("acao");
            entity.Property(e => e.DadosAntigos)
                .HasColumnType("jsonb")
                .HasColumnName("dados_antigos");
            entity.Property(e => e.DadosNovos)
                .HasColumnType("jsonb")
                .HasColumnName("dados_novos");
            entity.Property(e => e.DataHora)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_hora");
            entity.Property(e => e.IdRegistro).HasColumnName("id_registro");
            entity.Property(e => e.Ip).HasColumnName("ip");
            entity.Property(e => e.Tabela).HasColumnName("tabela");
        });

        modelBuilder.Entity<Monitoramento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("monitoramento_pkey");

            entity.ToTable("monitoramento");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataHora)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_hora");
            entity.Property(e => e.Informacoes)
                .HasColumnType("jsonb")
                .HasColumnName("informacoes");
            entity.Property(e => e.Operacao).HasColumnName("operacao");
            entity.Property(e => e.Tabela).HasColumnName("tabela");
        });

        modelBuilder.Entity<TabelaLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tabela_log_pkey");

            entity.ToTable("tabela_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acao).HasColumnName("acao");
            entity.Property(e => e.Dados)
                .HasColumnType("jsonb")
                .HasColumnName("dados");
            entity.Property(e => e.DataHora)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_hora");
            entity.Property(e => e.NomeTabela).HasColumnName("nome_tabela");
        });

        modelBuilder.Entity<TblAdesivo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_adesivo", tb => tb.HasComment("SETOR: TI\nTabela que contém o texto da frmAdesivo, acessado a partir da tecla de atalho \"A\" na tela inicial do sistema.\n"));

            entity.Property(e => e.Anotacoes)
                .HasMaxLength(250)
                .HasColumnName("anotacoes");
            entity.Property(e => e.Codigo)
                .ValueGeneratedOnAdd()
                .HasColumnName("codigo");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Login)
                .HasMaxLength(35)
                .HasColumnName("login");
        });

        modelBuilder.Entity<TblAgendaCob>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_agenda_cob_pkey");

            entity.ToTable("tbl_agenda_cob", tb => tb.HasComment("SETOR: COBRANÇA\nTabela que contém o agendamento de cobrança, com o código do cliente, data para se cobrar, data que foi realizado o agendamento e por qual usuário. Histórico da agenda de cobrança.\n"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Dataagendamento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataagendamento");
            entity.Property(e => e.Datacobrar).HasColumnName("datacobrar");
        });

        modelBuilder.Entity<TblAgendaEspecf>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_agenda_especf_pkey");

            entity.ToTable("tbl_agenda_especf", tb => tb.HasComment("SETOR: COBRANÇA\nEsta tabela é gerenciada através da tela FrmCriarAgCobranca, onde são inseridos uma cidade para determinada data. Os últimos registros desta tabela são de 2016, era utilizado pela Silmara. Agenda de cobrança específica para uma cidade.\n"));

            entity.HasIndex(e => e.Data, "tbl_agenda_especf_data_key").IsUnique();

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Cidade1)
                .HasMaxLength(50)
                .HasColumnName("cidade1");
            entity.Property(e => e.Cidade2)
                .HasMaxLength(50)
                .HasColumnName("cidade2");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Datacriacao)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datacriacao");

            entity.HasOne(d => d.CodusuarioNavigation).WithMany(p => p.TblAgendaEspecfs)
                .HasForeignKey(d => d.Codusuario)
                .HasConstraintName("tbl_agenda_especf_codusuario_fkey");
        });

        modelBuilder.Entity<TblAgendaMalote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_agenda_malote_pkey");

            entity.ToTable("tbl_agenda_malote");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.DataAgendamento)
                .HasColumnType("timestamp(4) without time zone")
                .HasColumnName("data_agendamento");
            entity.Property(e => e.DataEntregue)
                .HasColumnType("timestamp(4) without time zone")
                .HasColumnName("data_entregue");
            entity.Property(e => e.DataRecebimento)
                .HasColumnType("timestamp(4) without time zone")
                .HasColumnName("data_recebimento");
            entity.Property(e => e.Descricao)
                .HasMaxLength(200)
                .HasColumnName("descricao");
            entity.Property(e => e.Destinatario)
                .HasMaxLength(50)
                .HasColumnName("destinatario");
            entity.Property(e => e.Entregue).HasColumnName("entregue");
            entity.Property(e => e.Lacre).HasColumnName("lacre");
            entity.Property(e => e.Login)
                .HasMaxLength(20)
                .HasColumnName("login");
            entity.Property(e => e.LoginEntregue)
                .HasMaxLength(20)
                .HasColumnName("login_entregue");
            entity.Property(e => e.LoginLacre)
                .HasColumnType("character varying")
                .HasColumnName("login_lacre");
            entity.Property(e => e.LoginRecebimento)
                .HasMaxLength(20)
                .HasColumnName("login_recebimento");
            entity.Property(e => e.LojaDestino)
                .HasMaxLength(30)
                .HasColumnName("loja_destino");
            entity.Property(e => e.LojaRemetente).HasColumnName("loja_remetente");
            entity.Property(e => e.Obs)
                .HasMaxLength(100)
                .HasColumnName("obs");
            entity.Property(e => e.Recebido).HasColumnName("recebido");
            entity.Property(e => e.Remetente)
                .HasMaxLength(50)
                .HasColumnName("remetente");
        });

        modelBuilder.Entity<TblAgendaPgto>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_agenda_pgto_pkey");

            entity.ToTable("tbl_agenda_pgto", tb => tb.HasComment("SETOR: FINANCEIRO\nUma agenda com os pagamentos para os fornecedores, movimentação de caixa.\n"));

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tbl_agenda_pgto'::regclass)")
                .HasComment("Codigo da Operação")
                .HasColumnName("codigo");
            entity.Property(e => e.Agencia)
                .HasMaxLength(10)
                .HasColumnName("agencia");
            entity.Property(e => e.AnexoNotaServ)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("anexo_nota_serv");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("ativo");
            entity.Property(e => e.Atualiza)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("atualiza");
            entity.Property(e => e.CaixaPgto).HasColumnName("caixa_pgto");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(18)
                .HasColumnName("cnpj");
            entity.Property(e => e.Coddivdetalhe).HasColumnName("coddivdetalhe");
            entity.Property(e => e.Coddivisao)
                .HasComment("Codigo da Divisao os Produtos")
                .HasColumnName("coddivisao");
            entity.Property(e => e.Codfornecedor)
                .HasComment("Codigo do Fornecedor")
                .HasColumnName("codfornecedor");
            entity.Property(e => e.Codpedidocompra)
                .HasComment("Codigo do Pedido de Compra")
                .HasColumnName("codpedidocompra");
            entity.Property(e => e.Codrecebimento)
                .HasComment("Codigo do Pedido de Recebimento")
                .HasColumnName("codrecebimento");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Codvale)
                .HasDefaultValueSql("0")
                .HasColumnName("codvale");
            entity.Property(e => e.Comprovante)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("comprovante");
            entity.Property(e => e.Conferida)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("conferida");
            entity.Property(e => e.Conta)
                .HasMaxLength(20)
                .HasColumnName("conta");
            entity.Property(e => e.DataDebito)
                .HasComment("Data em que ocorreu o debito na conta")
                .HasColumnName("data_debito");
            entity.Property(e => e.DataLiquidacao).HasColumnName("data_liquidacao");
            entity.Property(e => e.Destacar)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("destacar");
            entity.Property(e => e.Excluir)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("excluir");
            entity.Property(e => e.Favorecido)
                .HasMaxLength(60)
                .HasColumnName("favorecido");
            entity.Property(e => e.Grupo)
                .HasDefaultValueSql("0")
                .HasColumnName("grupo");
            entity.Property(e => e.Ident)
                .HasMaxLength(20)
                .HasColumnName("ident");
            entity.Property(e => e.Lancada)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("lancada");
            entity.Property(e => e.Nbanco).HasColumnName("nbanco");
            entity.Property(e => e.Ncheque).HasColumnName("ncheque");
            entity.Property(e => e.Ndocumento)
                .HasMaxLength(999)
                .HasComment("Numero do Documento da mercadoria")
                .HasColumnName("ndocumento");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.Parcela)
                .HasMaxLength(7)
                .HasComment("quantidade de parcelas")
                .HasColumnName("parcela");
            entity.Property(e => e.Prazo)
                .HasComment("Prazo de pagamento")
                .HasColumnName("prazo");
            entity.Property(e => e.Tipo)
                .HasDefaultValueSql("1")
                .HasColumnName("tipo");
            entity.Property(e => e.Tipopgto).HasColumnName("tipopgto");
            entity.Property(e => e.Vencimento).HasColumnName("vencimento");
            entity.Property(e => e.Vlrpagar)
                .HasComment("Valor a pagar")
                .HasColumnName("vlrpagar");
        });

        modelBuilder.Entity<TblAgendaPgtoContabil>(entity =>
        {
            entity.HasKey(e => e.Codparcela).HasName("tbl_agenda_pgto_contabil_pkey");

            entity.ToTable("tbl_agenda_pgto_contabil", tb => tb.HasComment("SETOR: FINANCEIRO\nUma agenda com os débitos e créditos de contas contábeis, incluindo as letras do caixa que efetuou o pagamento.\n"));

            entity.Property(e => e.Codparcela)
                .ValueGeneratedNever()
                .HasColumnName("codparcela");
            entity.Property(e => e.ContaCredito).HasColumnName("conta_credito");
            entity.Property(e => e.ContaDebito).HasColumnName("conta_debito");
            entity.Property(e => e.Credito)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("credito");
            entity.Property(e => e.Historico).HasColumnName("historico");
            entity.Property(e => e.Letracaixa)
                .HasMaxLength(3)
                .HasColumnName("letracaixa");
            entity.Property(e => e.Pagamento).HasColumnName("pagamento");
            entity.Property(e => e.Valor)
                .HasPrecision(10, 2)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<TblAgendaPgtoDivLoja>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_agenda_pgto_div_loja_pkey");

            entity.ToTable("tbl_agenda_pgto_div_loja", tb => tb.HasComment("SETOR: FINANCEIRO\nContém a divisão do pagamento ou vale, em porcentagem, entre as lojas. Esta tabela é gerenciada através da tela FrmEditarParcAgenda, na aba \"Divisão por Loja\".\n"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codpedidocompra).HasColumnName("codpedidocompra");
            entity.Property(e => e.Porcent).HasColumnName("porcent");
        });

        modelBuilder.Entity<TblAgendafornecedor>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_agendafornecedor_pkey");

            entity.ToTable("tbl_agendafornecedor", tb => tb.HasComment("SETOR: DEPÓSITO: RECEBIMENTO\nEsta tabela agenda o recebimento de mercadorias. Detalha o fornecedor e o veículo, com o nome do motorista, placa, nome da transportadora, quantidade de volumes e o horário agendado, entrada e saída. Esta tabela é gerenciada através da tela Frm_ConsAgendaFornecedor."));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Ajudante)
                .HasMaxLength(30)
                .HasColumnName("ajudante");
            entity.Property(e => e.Ajudante1)
                .HasMaxLength(30)
                .HasColumnName("ajudante1");
            entity.Property(e => e.Ajudante3)
                .HasMaxLength(30)
                .HasColumnName("ajudante3");
            entity.Property(e => e.Cpfajudante)
                .HasMaxLength(11)
                .HasColumnName("cpfajudante");
            entity.Property(e => e.Cpfajudante1)
                .HasMaxLength(11)
                .HasColumnName("cpfajudante1");
            entity.Property(e => e.Cpfajudante3)
                .HasMaxLength(11)
                .HasColumnName("cpfajudante3");
            entity.Property(e => e.Cpfmotorista)
                .HasMaxLength(11)
                .HasColumnName("cpfmotorista");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Entrada).HasColumnName("entrada");
            entity.Property(e => e.Excluido)
                .HasMaxLength(1)
                .HasColumnName("excluido");
            entity.Property(e => e.Fornecedor)
                .HasMaxLength(500)
                .HasColumnName("fornecedor");
            entity.Property(e => e.Motorista)
                .HasMaxLength(30)
                .HasColumnName("motorista");
            entity.Property(e => e.Notafiscal)
                .HasMaxLength(60)
                .HasColumnName("notafiscal");
            entity.Property(e => e.Placa)
                .HasMaxLength(7)
                .HasColumnName("placa");
            entity.Property(e => e.Preventrada).HasColumnName("preventrada");
            entity.Property(e => e.Prevsaida).HasColumnName("prevsaida");
            entity.Property(e => e.Recebexml)
                .HasMaxLength(1)
                .HasColumnName("recebexml");
            entity.Property(e => e.Saida).HasColumnName("saida");
            entity.Property(e => e.Transportadora)
                .HasMaxLength(40)
                .HasColumnName("transportadora");
            entity.Property(e => e.Usuario)
                .HasMaxLength(15)
                .HasColumnName("usuario");
            entity.Property(e => e.Usuarioentrada)
                .HasMaxLength(15)
                .HasColumnName("usuarioentrada");
            entity.Property(e => e.Usuariosaida)
                .HasMaxLength(15)
                .HasColumnName("usuariosaida");
            entity.Property(e => e.Usurecebimento)
                .HasMaxLength(20)
                .HasColumnName("usurecebimento");
            entity.Property(e => e.Volume)
                .HasMaxLength(20)
                .HasColumnName("volume");
        });

        modelBuilder.Entity<TblAgendafornecedorFornec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_agendafornecedor_fornec", tb => tb.HasComment("DEPÓSITO: RECEBIMENTO\nContém o código da agenda e o código do fornecedor. Esta tabela é gerenciada através da tela Frm_ConsAgendaFornecedor.\n\n"));

            entity.Property(e => e.Codagenda).HasColumnName("codagenda");
            entity.Property(e => e.Codfornecedor).HasColumnName("codfornecedor");
            entity.Property(e => e.Codigo)
                .ValueGeneratedOnAdd()
                .HasColumnName("codigo");
        });

        modelBuilder.Entity<TblAliquotaPisCofin>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_aliquota_pis_cofins_pkey");

            entity.ToTable("tbl_aliquota_pis_cofins", tb => tb.HasComment("SETOR: INCLUSÃO e FISCAL\nContém a alíquota de PIS e do COFINS, utilizada no cadastro de produtos, na composição de preço, também utilizado na impressão de nota fiscal (nfe)\n"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Cofins)
                .HasPrecision(4, 2)
                .HasColumnName("cofins");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Pis)
                .HasPrecision(4, 2)
                .HasColumnName("pis");
        });

        modelBuilder.Entity<TblAlteraPedido>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_altera_pedido", tb => tb.HasComment("SETOR: FINANCEIRO\nAparentemente continha um registro dos pedidos que foram alterados e os usuários que os alteraram.\n"));

            entity.Property(e => e.Codigo)
                .ValueGeneratedOnAdd()
                .HasColumnName("codigo");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(9)
                .HasColumnName("codpedido");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Motivo).HasColumnName("motivo");
            entity.Property(e => e.Usuario)
                .HasMaxLength(40)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<TblAnaliseCredito>(entity =>
        {
            entity.HasKey(e => e.Codsolicitacao).HasName("tbl_analise_credito_pkey");

            entity.ToTable("tbl_analise_credito", tb => tb.HasComment("SETOR: COBRANÇA\nEsta tabela é utilizada na FrmAnaliseCredito e pelas telas onde há um sininho, feito para acionar o departamento de liberação de crédito para analisar cadastros, pedidos, cancelamentos e renegociações."));

            entity.Property(e => e.Codsolicitacao).HasColumnName("codsolicitacao");
            entity.Property(e => e.Analista).HasColumnName("analista");
            entity.Property(e => e.Cancelado)
                .HasDefaultValueSql("false")
                .HasColumnName("cancelado");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Datasenha)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datasenha");
            entity.Property(e => e.Datasolicitacao)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datasolicitacao");
            entity.Property(e => e.Finalizado)
                .HasDefaultValueSql("false")
                .HasColumnName("finalizado");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.Solicitante).HasColumnName("solicitante");
            entity.Property(e => e.Tiposenha).HasColumnName("tiposenha");
        });

        modelBuilder.Entity<TblAnaliseCreditoAnalista>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_analise_credito_analistas_pkey");

            entity.ToTable("tbl_analise_credito_analistas", tb => tb.HasComment("SETOR: COBRANÇA\nCadastro de analistas de crédito com suas datas de férias e onde podem ser encontrados."));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.AlmocoFim).HasColumnName("almoco_fim");
            entity.Property(e => e.AlmocoInicio).HasColumnName("almoco_inicio");
            entity.Property(e => e.Ativo)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("ativo");
            entity.Property(e => e.Celular)
                .HasMaxLength(15)
                .HasColumnName("celular");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Disponivel)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("disponivel");
            entity.Property(e => e.FeriasFim)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("ferias_fim");
            entity.Property(e => e.FeriasInicio)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("ferias_inicio");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("nome");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.Ramal).HasColumnName("ramal");
            entity.Property(e => e.Whatsapp)
                .HasMaxLength(15)
                .HasColumnName("whatsapp");
        });

        modelBuilder.Entity<TblAnaliseCreditoTipo>(entity =>
        {
            entity.HasKey(e => e.Codsenha).HasName("cod");

            entity.ToTable("tbl_analise_credito_tipo", tb => tb.HasComment("SETOR: COBRANÇA\nTipos de análise de crédito disponíveis na tbl_analise_credito"));

            entity.Property(e => e.Codsenha)
                .ValueGeneratedNever()
                .HasColumnName("codsenha");
            entity.Property(e => e.Ativo)
                .HasDefaultValueSql("true")
                .HasColumnName("ativo");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TblAniversario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_aniversario_pkey");

            entity.ToTable("tbl_aniversario");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.ContactDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("contact_date");
            entity.Property(e => e.ContactType)
                .HasMaxLength(20)
                .HasColumnName("contact_type");
            entity.Property(e => e.Message)
                .HasMaxLength(500)
                .HasColumnName("message");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<TblApiRodonavesToken>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_api_rodonaves_token_pkey");

            entity.ToTable("tbl_api_rodonaves_token", tb => tb.HasComment("SETOR: E-COMMERCE\nDados conexão com a API Rodonaves, Token de acesso e sua validade."));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Emissao)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("emissao");
            entity.Property(e => e.Expira)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("expira");
            entity.Property(e => e.Json).HasColumnName("json");
            entity.Property(e => e.Token).HasColumnName("token");
        });

        modelBuilder.Entity<TblApiTransportadora>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_api_transportadoras_pkey");

            entity.ToTable("tbl_api_transportadoras", tb => tb.HasComment("SETOR: E-COMMERCE\ndados API transportadoras para integração de pedidos entregues."));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .HasColumnName("descricao");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .HasColumnName("password");
            entity.Property(e => e.Rest)
                .HasMaxLength(10)
                .HasColumnName("rest");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .HasColumnName("tipo");
            entity.Property(e => e.Transportadora)
                .HasMaxLength(50)
                .HasColumnName("transportadora");
            entity.Property(e => e.Url)
                .HasMaxLength(100)
                .HasColumnName("url");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .HasColumnName("username");
        });

        modelBuilder.Entity<TblAppMarciusLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_app_marcius_log_pkey");

            entity.ToTable("tbl_app_marcius_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Dispositivo)
                .HasColumnType("character varying")
                .HasColumnName("dispositivo");
            entity.Property(e => e.Erro).HasColumnName("erro");
            entity.Property(e => e.Metodo)
                .HasColumnType("character varying")
                .HasColumnName("metodo");
            entity.Property(e => e.Plataforma)
                .HasColumnType("character varying")
                .HasColumnName("plataforma");
            entity.Property(e => e.TelaClasse)
                .HasColumnType("character varying")
                .HasColumnName("tela_classe");
            entity.Property(e => e.Versao)
                .HasColumnType("character varying")
                .HasColumnName("versao");
        });

        modelBuilder.Entity<TblAppMarciusMenuPrincipal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_app_marcius_menu_principal_pkey");

            entity.ToTable("tbl_app_marcius_menu_principal");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BtnAtivo)
                .HasDefaultValueSql("false")
                .HasColumnName("btn_ativo");
            entity.Property(e => e.CodIcone).HasColumnName("cod_icone");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.DepPermitidos).HasColumnName("dep_permitidos");
            entity.Property(e => e.NomeMetodo).HasColumnName("nome_metodo");
            entity.Property(e => e.TextoBtn).HasColumnName("texto_btn");
        });

        modelBuilder.Entity<TblAppMarciusVersao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_app_marcius_versao_pkey");

            entity.ToTable("tbl_app_marcius_versao");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Versao).HasColumnName("versao");
        });

        modelBuilder.Entity<TblArquivoPedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_arquivo_pedido_pkey");

            entity.ToTable("tbl_arquivo_pedido");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(15)
                .HasColumnName("codpedido");
            entity.Property(e => e.Completo).HasColumnName("completo");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Logistica).HasColumnName("logistica");
            entity.Property(e => e.MarciusBusca).HasColumnName("marcius_busca");
            entity.Property(e => e.Refpedido)
                .HasMaxLength(20)
                .HasColumnName("refpedido");
        });

        modelBuilder.Entity<TblArquivoPedidoItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_arquivo_pedido_item_pkey");

            entity.ToTable("tbl_arquivo_pedido_item");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Arquivo).HasColumnName("arquivo");
            entity.Property(e => e.Arquivopedidoid).HasColumnName("arquivopedidoid");
            entity.Property(e => e.Arquivopedidotipo).HasColumnName("arquivopedidotipo");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Dataenvio).HasColumnName("dataenvio");
            entity.Property(e => e.Mensagemretorno)
                .HasMaxLength(150)
                .HasColumnName("mensagemretorno");
        });

        modelBuilder.Entity<TblAssistencium>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_assistencia_pkey");

            entity.ToTable("tbl_assistencia", tb => tb.HasComment("SETOR: ASSISTÊNCIA\nTabela com os registros das assistências abertas, tanto de clientes como as de loja.\n"));

            entity.HasIndex(e => e.Codproduto, "index_tbl_assistencia.codproduto");

            entity.HasIndex(e => e.Pedido, "index_tbl_assistencia_codpedido");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Acessorios).HasColumnName("acessorios");
            entity.Property(e => e.Bairro)
                .HasMaxLength(60)
                .HasColumnName("bairro");
            entity.Property(e => e.Baixaestoque)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("baixaestoque");
            entity.Property(e => e.Baixaparcial)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("baixaparcial");
            entity.Property(e => e.Cabo)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("cabo");
            entity.Property(e => e.Caixa)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("caixa");
            entity.Property(e => e.Cidade)
                .HasMaxLength(30)
                .HasColumnName("cidade");
            entity.Property(e => e.Cliente)
                .HasMaxLength(60)
                .HasColumnName("cliente");
            entity.Property(e => e.CodResponsavel).HasColumnName("cod_responsavel");
            entity.Property(e => e.Codassistencia).HasColumnName("codassistencia");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codlojaentrega)
                .HasDefaultValueSql("0")
                .HasColumnName("codlojaentrega");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(60)
                .HasColumnName("codproduto");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Contatoassist).HasColumnName("contatoassist");
            entity.Property(e => e.Contatocliente).HasColumnName("contatocliente");
            entity.Property(e => e.Controle)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("controle");
            entity.Property(e => e.Datacompra)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datacompra");
            entity.Property(e => e.Dataromaneio)
                .HasComment("data que foi solicitado o romaneio")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataromaneio");
            entity.Property(e => e.Defeito).HasColumnName("defeito");
            entity.Property(e => e.Endereco)
                .HasMaxLength(60)
                .HasColumnName("endereco");
            entity.Property(e => e.Entrada)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("entrada");
            entity.Property(e => e.Entrega)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("entrega");
            entity.Property(e => e.Entregue)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("entregue");
            entity.Property(e => e.Entreguepor)
                .HasMaxLength(80)
                .HasColumnName("entreguepor");
            entity.Property(e => e.Enviado)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("enviado");
            entity.Property(e => e.EnviadoDevolucao)
                .HasDefaultValueSql("false")
                .HasColumnName("enviado_devolucao");
            entity.Property(e => e.Enviadopor)
                .HasMaxLength(80)
                .HasColumnName("enviadopor");
            entity.Property(e => e.EnvioDep)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("envio_dep");
            entity.Property(e => e.Estavarias)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("estavarias");
            entity.Property(e => e.Estoquedeposito).HasColumnName("estoquedeposito");
            entity.Property(e => e.Estoqueloja).HasColumnName("estoqueloja");
            entity.Property(e => e.Estperfeito)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("estperfeito");
            entity.Property(e => e.Estregular)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("estregular");
            entity.Property(e => e.Fone)
                .HasMaxLength(60)
                .HasColumnName("fone");
            entity.Property(e => e.Fonte)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("fonte");
            entity.Property(e => e.Idromaneio).HasColumnName("idromaneio");
            entity.Property(e => e.Isopor)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("isopor");
            entity.Property(e => e.Localbaixa).HasColumnName("localbaixa");
            entity.Property(e => e.Localproduto)
                .HasMaxLength(80)
                .HasColumnName("localproduto");
            entity.Property(e => e.Manual)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("manual");
            entity.Property(e => e.Modelo)
                .HasMaxLength(80)
                .HasColumnName("modelo");
            entity.Property(e => e.Nchamado)
                .HasDefaultValueSql("0")
                .HasComment("Numero do chamado aberto no gerenciador de ocorrencia")
                .HasColumnName("nchamado");
            entity.Property(e => e.Nfe).HasColumnName("nfe");
            entity.Property(e => e.Notaremessa)
                .HasMaxLength(20)
                .HasColumnName("notaremessa");
            entity.Property(e => e.Notaretorno)
                .HasMaxLength(15)
                .HasColumnName("notaretorno");
            entity.Property(e => e.Nserie)
                .HasMaxLength(80)
                .HasColumnName("nserie");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.OsAssistencia)
                .HasMaxLength(20)
                .HasColumnName("os_assistencia");
            entity.Property(e => e.Pedido)
                .HasMaxLength(10)
                .HasColumnName("pedido");
            entity.Property(e => e.Previsao)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("previsao");
            entity.Property(e => e.Produto)
                .HasMaxLength(90)
                .HasColumnName("produto");
            entity.Property(e => e.Retiradopor)
                .HasMaxLength(80)
                .HasColumnName("retiradopor");
            entity.Property(e => e.Retornadoloja)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("retornadoloja");
            entity.Property(e => e.Retornadopor)
                .HasMaxLength(80)
                .HasColumnName("retornadopor");
            entity.Property(e => e.Retorno)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("retorno");
            entity.Property(e => e.Romaneio).HasColumnName("romaneio");
            entity.Property(e => e.Solucionado)
                .HasMaxLength(3)
                .HasColumnName("solucionado");
            entity.Property(e => e.Tipo)
                .HasMaxLength(15)
                .HasColumnName("tipo");
            entity.Property(e => e.Usuario)
                .HasMaxLength(80)
                .HasColumnName("usuario");
            entity.Property(e => e.XmlNfe)
                .HasColumnType("xml")
                .HasColumnName("xml_nfe");

            entity.HasOne(d => d.CodResponsavelNavigation).WithMany(p => p.TblAssistencia)
                .HasForeignKey(d => d.CodResponsavel)
                .HasConstraintName("tbl_assistencia_cod_responsavel_fkey");
        });

        modelBuilder.Entity<TblAtivo>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_ativo_pkey");

            entity.ToTable("tbl_ativo", tb => tb.HasComment("SETOR: TI/ FINANCEIRO\nContém o registro de ativos de informática, como: Câmeras, equipamentos de backup, impressoras, monitores, switchs, baterias, nobreaks, bem como os seus IPs, senhas, configurações detalhadas de cada acesso.\nO número de patrímônio, coluna desta tabela, são as etiquetas coladas nos ativos. Esta tela é gerenciada através da tela FrmListaAtivos, acessada a partir de cadastro > cadastro de ativos.\nA chave primária desta tabela tem o nome de \"\"codigo\"\", mas é chamada de \"\"codativo\"\" em outras tabelas.\n"));

            entity.HasIndex(e => e.Patrimonio, "tbl_ativo_patrimonio_key").IsUnique();

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Ativo)
                .HasDefaultValueSql("true")
                .HasColumnName("ativo");
            entity.Property(e => e.Coddeparta).HasColumnName("coddeparta");
            entity.Property(e => e.Codlocal).HasColumnName("codlocal");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codmarca).HasColumnName("codmarca");
            entity.Property(e => e.Codtipo).HasColumnName("codtipo");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Datacadastro)
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("datacadastro");
            entity.Property(e => e.Datacompra).HasColumnName("datacompra");
            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .HasColumnName("descricao");
            entity.Property(e => e.Hostname)
                .HasMaxLength(40)
                .HasColumnName("hostname");
            entity.Property(e => e.Modelo)
                .HasMaxLength(100)
                .HasColumnName("modelo");
            entity.Property(e => e.Nserie)
                .HasMaxLength(60)
                .HasColumnName("nserie");
            entity.Property(e => e.Patrimonio)
                .ValueGeneratedOnAdd()
                .HasColumnName("patrimonio");
            entity.Property(e => e.Valor)
                .HasPrecision(8, 2)
                .HasColumnName("valor");

            entity.HasOne(d => d.CoddepartaNavigation).WithMany(p => p.TblAtivos)
                .HasForeignKey(d => d.Coddeparta)
                .HasConstraintName("tbl_ativo_coddeparta_fkey");

            entity.HasOne(d => d.CodlocalNavigation).WithMany(p => p.TblAtivos)
                .HasForeignKey(d => d.Codlocal)
                .HasConstraintName("tbl_ativo_codlocal_fkey");

            entity.HasOne(d => d.CodlojaNavigation).WithMany(p => p.TblAtivos)
                .HasForeignKey(d => d.Codloja)
                .HasConstraintName("tbl_ativo_codloja_fkey");

            entity.HasOne(d => d.CodmarcaNavigation).WithMany(p => p.TblAtivos)
                .HasForeignKey(d => d.Codmarca)
                .HasConstraintName("tbl_ativo_codmarca_fkey");

            entity.HasOne(d => d.CodtipoNavigation).WithMany(p => p.TblAtivos)
                .HasForeignKey(d => d.Codtipo)
                .HasConstraintName("tbl_ativo_codtipo_fkey");

            entity.HasOne(d => d.CodusuarioNavigation).WithMany(p => p.TblAtivos)
                .HasForeignKey(d => d.Codusuario)
                .HasConstraintName("tbl_ativo_codusuario_fkey");
        });

        modelBuilder.Entity<TblAtivoDepartamento>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_ativo_departamento_pkey");

            entity.ToTable("tbl_ativo_departamento", tb => tb.HasComment("SETOR: TI/FINANCEIRO\nDepartamentos da tbl_ativo"));

            entity.HasIndex(e => e.Descricao, "tbl_ativo_departamento_departamento_key").IsUnique();

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(60)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<TblAtivoFile>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_ativo_file_pkey");

            entity.ToTable("tbl_ativo_file", tb => tb.HasComment("INATIVA\nContém apenas 9 registros com a descrição de arquivos de configuração.\n"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codativo).HasColumnName("codativo");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .HasColumnName("descricao");
            entity.Property(e => e.Extensionfile)
                .HasMaxLength(5)
                .HasColumnName("extensionfile");
        });

        modelBuilder.Entity<TblAtivoHistorico>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_ativo_historico_pkey");

            entity.ToTable("tbl_ativo_historico", tb => tb.HasComment("SETOR: TI/FINANCEIRO\nTabela com o registro de alterações da tbl_ativo, como quando um equipamento muda de cidade, as alterações da localidade do ativo são registradas aqui.\n"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.AlterouDe)
                .HasMaxLength(100)
                .HasColumnName("alterou_de");
            entity.Property(e => e.AlterouPara)
                .HasMaxLength(100)
                .HasColumnName("alterou_para");
            entity.Property(e => e.Codativo).HasColumnName("codativo");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Obs).HasColumnName("obs");

            entity.HasOne(d => d.CodativoNavigation).WithMany(p => p.TblAtivoHistoricos)
                .HasForeignKey(d => d.Codativo)
                .HasConstraintName("tbl_ativo_historico_codativo_fkey");

            entity.HasOne(d => d.CodusuarioNavigation).WithMany(p => p.TblAtivoHistoricos)
                .HasForeignKey(d => d.Codusuario)
                .HasConstraintName("tbl_ativo_historico_codusurio_fkey");
        });

        modelBuilder.Entity<TblAtivoIp>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_ativo_ip_pkey");

            entity.ToTable("tbl_ativo_ip", tb => tb.HasComment("SETOR: TI\nContém o IP de ativos que possuem IPs, como computadores de usuário, switchs e servidores.\n"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codativo).HasColumnName("codativo");
            entity.Property(e => e.Dns1)
                .HasMaxLength(15)
                .HasColumnName("dns1");
            entity.Property(e => e.Dns2)
                .HasMaxLength(15)
                .HasColumnName("dns2");
            entity.Property(e => e.Gw)
                .HasMaxLength(15)
                .HasColumnName("gw");
            entity.Property(e => e.Interface)
                .HasMaxLength(50)
                .HasColumnName("interface");
            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .HasColumnName("ip");
            entity.Property(e => e.Ipprincipal).HasColumnName("ipprincipal");
            entity.Property(e => e.Mascara)
                .HasMaxLength(15)
                .HasColumnName("mascara");

            entity.HasOne(d => d.CodativoNavigation).WithMany(p => p.TblAtivoIps)
                .HasForeignKey(d => d.Codativo)
                .HasConstraintName("tbl_ativo_ip_codativo_fkey");
        });

        modelBuilder.Entity<TblAtivoLocal>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_ativo_local_pkey");

            entity.ToTable("tbl_ativo_local", tb => tb.HasComment("SETOR: TI\nContém o local dos ativos. Os locais agrupam-se em determinadas áreas descritas nesta tabela.\n"));

            entity.HasIndex(e => e.Descricao, "tbl_ativo_local_local_key").IsUnique();

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(60)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<TblAtivoMarca>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_ativo_marca_pkey");

            entity.ToTable("tbl_ativo_marca", tb => tb.HasComment("SETOR: TI\nContém uma lista de marcas fabricantes dos ativos, como LG, Intel, Cisco, HP, etc.\n"));

            entity.HasIndex(e => e.Descricao, "tbl_ativo_marca_descricao_key").IsUnique();

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(60)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<TblAtivoNotafiscal>(entity =>
        {
            entity.HasKey(e => new { e.Codativo, e.Codnota }).HasName("tbl_ativo_notafiscal_pkey");

            entity.ToTable("tbl_ativo_notafiscal", tb => tb.HasComment("SETOR: TI\nEsta tabela relaciona o código do ativo com um código de nota.\n"));

            entity.Property(e => e.Codativo).HasColumnName("codativo");
            entity.Property(e => e.Codnota).HasColumnName("codnota");
        });

        modelBuilder.Entity<TblAtivoProp>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_ativo_prop_pkey");

            entity.ToTable("tbl_ativo_prop", tb => tb.HasComment("SETOR: TI\nLista de tipos de ativos correlacionadas com propriedades. Ex.: na tbl_ativo_tipo temos o codigo 1, MONITOR, na tbl_ativo_prop temos o tipo de tela (LCD, LED) e tamanho de tela.\n"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codtipo).HasColumnName("codtipo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(60)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<TblAtivoPropSub>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_ativos_prop_sub_pkey");

            entity.ToTable("tbl_ativo_prop_sub", tb => tb.HasComment("SETOR: TI\nNesta tabela há as subdivisões da tbl_ativo_prop, como tbl_ativo_prop.codigo = 1, temos aqui na tbl_ativo_prop_sub.codigo = 1 os tipos LED, TUBO e LCD.\n"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codativo).HasColumnName("codativo");
            entity.Property(e => e.Codprop).HasColumnName("codprop");
            entity.Property(e => e.Descricao)
                .HasMaxLength(60)
                .HasColumnName("descricao");

            entity.HasOne(d => d.CodativoNavigation).WithMany(p => p.TblAtivoPropSubs)
                .HasForeignKey(d => d.Codativo)
                .HasConstraintName("tbl_ativo_prop_sub_codativo_fkey");

            entity.HasOne(d => d.CodpropNavigation).WithMany(p => p.TblAtivoPropSubs)
                .HasForeignKey(d => d.Codprop)
                .HasConstraintName("tbl_ativo_prop_sub_codprop_fkey");
        });

        modelBuilder.Entity<TblAtivoTipo>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_ativo_tipo_pkey");

            entity.ToTable("tbl_ativo_tipo", tb => tb.HasComment("SETOR: TI\nSão os tipos de ativo, exemplo: Tipo 1= MONITOR, Tipo 2 = COMPUTADOR, Tipo 3 = ROUTER...\n"));

            entity.HasIndex(e => e.Descricao, "tbl_ativo_tipo_descricao_key").IsUnique();

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Coddep)
                .HasDefaultValueSql("1")
                .HasColumnName("coddep");
            entity.Property(e => e.Descricao)
                .HasMaxLength(60)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<TblAtualizacaoSistema>(entity =>
        {
            entity.HasKey(e => e.IdAtualizacao).HasName("tbl_atualizacao_sistema_pkey");

            entity.ToTable("tbl_atualizacao_sistema");

            entity.Property(e => e.IdAtualizacao).HasColumnName("id_atualizacao");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.DataHora)
                .HasColumnType("timestamp(4) without time zone")
                .HasColumnName("data_hora");
            entity.Property(e => e.Tempo)
                .HasDefaultValueSql("'00:01:00'::time without time zone")
                .HasColumnName("tempo");
        });

        modelBuilder.Entity<TblAuditoriaLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_auditoria_log_pkey");

            entity.ToTable("tbl_auditoria_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acao).HasColumnName("acao");
            entity.Property(e => e.Dados)
                .HasColumnType("jsonb")
                .HasColumnName("dados");
            entity.Property(e => e.DataHora)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_hora");
            entity.Property(e => e.NomeTabela).HasColumnName("nome_tabela");
        });

        modelBuilder.Entity<TblAuditoriaProd>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_auditoria_prod_pkey");

            entity.ToTable("tbl_auditoria_prod");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Dataentrada)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataentrada");
            entity.Property(e => e.Dataretorno)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataretorno");
            entity.Property(e => e.Idromaneio).HasColumnName("idromaneio");
            entity.Property(e => e.Lojaorigem).HasColumnName("lojaorigem");
            entity.Property(e => e.Obs)
                .HasMaxLength(100)
                .HasColumnName("obs");
            entity.Property(e => e.Problema)
                .HasComment("1 = verdadeiro\n0 = falso")
                .HasColumnName("problema");
            entity.Property(e => e.Quantidade).HasColumnName("quantidade");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'A'::bpchar")
                .HasComment("A = Automatico\nM = Manual")
                .HasColumnName("tipo");
            entity.Property(e => e.Usuarioretorno).HasColumnName("usuarioretorno");
        });

        modelBuilder.Entity<TblAutenticacaoEmailLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_autenticacao_email_log_pkey");

            entity.ToTable("tbl_autenticacao_email_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codigogerado).HasColumnName("codigogerado");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Emailuser).HasColumnName("emailuser");
            entity.Property(e => e.Idusuario).HasColumnName("idusuario");
            entity.Property(e => e.Text).HasColumnName("text");
        });

        modelBuilder.Entity<TblBairro>(entity =>
        {
            entity.HasKey(e => e.Codbairro).HasName("tbl_bairro_pkey");

            entity.ToTable("tbl_bairro");

            entity.Property(e => e.Codbairro)
                .HasDefaultValueSql("nextval('seq_tblbairro'::regclass)")
                .HasColumnName("codbairro");
            entity.Property(e => e.Bairro)
                .HasMaxLength(80)
                .HasColumnName("bairro");
            entity.Property(e => e.User)
                .HasMaxLength(35)
                .HasDefaultValueSql("\"current_user\"()")
                .HasColumnName("user");
        });

        modelBuilder.Entity<TblBaixaCartao>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_baixa_cartao_pkey");

            entity.ToTable("tbl_baixa_cartao");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Databaixa)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("databaixa");
            entity.Property(e => e.Datacredito).HasColumnName("datacredito");
            entity.Property(e => e.Datadeposito).HasColumnName("datadeposito");
            entity.Property(e => e.Descricao)
                .HasMaxLength(20)
                .HasColumnName("descricao");
            entity.Property(e => e.Excluir).HasColumnName("excluir");
            entity.Property(e => e.Ncomprovante).HasColumnName("ncomprovante");
            entity.Property(e => e.Nestabelecimento)
                .HasMaxLength(12)
                .HasColumnName("nestabelecimento");
            entity.Property(e => e.Nresumo)
                .HasMaxLength(10)
                .HasColumnName("nresumo");
            entity.Property(e => e.Valorbruto).HasColumnName("valorbruto");
            entity.Property(e => e.Valorliquido).HasColumnName("valorliquido");
        });

        modelBuilder.Entity<TblBaixaEcommerceLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_baixa_ecommerce_log_pkey");

            entity.ToTable("tbl_baixa_ecommerce_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Json).HasColumnName("json");
            entity.Property(e => e.Usuario).HasColumnName("usuario");
        });

        modelBuilder.Entity<TblBanco>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_banco_pkey");

            entity.ToTable("tbl_banco");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Banco)
                .HasMaxLength(80)
                .HasColumnName("banco");
            entity.Property(e => e.Numero)
                .HasMaxLength(5)
                .HasComment("Nunero do banco")
                .HasColumnName("numero");
            entity.Property(e => e.Site)
                .HasMaxLength(80)
                .HasColumnName("site");
        });

        modelBuilder.Entity<TblBancoCliente>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_banco_cliente_pkey");

            entity.ToTable("tbl_banco_cliente");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Abertura)
                .HasMaxLength(7)
                .HasColumnName("abertura");
            entity.Property(e => e.Agencia)
                .HasMaxLength(15)
                .HasColumnName("agencia");
            entity.Property(e => e.Banco)
                .HasMaxLength(60)
                .HasColumnName("banco");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Contacorrente)
                .HasMaxLength(20)
                .HasColumnName("contacorrente");
        });

        modelBuilder.Entity<TblBandeiraCartao>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_bandeira_cartao_pkey");

            entity.ToTable("tbl_bandeira_cartao");

            entity.Property(e => e.Codigo)
                .ValueGeneratedNever()
                .HasColumnName("codigo");
            entity.Property(e => e.Bandeira)
                .HasMaxLength(30)
                .HasColumnName("bandeira");
        });

        modelBuilder.Entity<TblBaseicmsTransferencium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_baseicms_transferencia_pkey");

            entity.ToTable("tbl_baseicms_transferencia");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AliquotaSuportadaPeloConsumidorFinal)
                .HasPrecision(12, 2)
                .HasColumnName("aliquota_suportada_pelo_consumidor_final");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(15)
                .HasColumnName("codproduto");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.NumeroNfeEntrada)
                .HasMaxLength(20)
                .HasColumnName("numero_nfe_entrada");
            entity.Property(e => e.QuantidadeAtual).HasColumnName("quantidade_atual");
            entity.Property(e => e.QuantidadeEntrada).HasColumnName("quantidade_entrada");
            entity.Property(e => e.ValorDoIcmsProprioDoSubstituto)
                .HasPrecision(12, 2)
                .HasColumnName("valor_do_icms_proprio_do_substituto");
            entity.Property(e => e.ValorDoIcmsStRetido)
                .HasPrecision(12, 2)
                .HasColumnName("valor_do_icms_st_retido");
            entity.Property(e => e.ValordaBcIcmsStRetido)
                .HasPrecision(12, 2)
                .HasColumnName("valorda_bc_icms_st_retido");
        });

        modelBuilder.Entity<TblBilheteGarantiaEnvio>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_bilhete_garantia_envio_pkey");

            entity.ToTable("tbl_bilhete_garantia_envio");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Arquivo).HasColumnName("arquivo");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data");
            entity.Property(e => e.NomeArquivo)
                .HasMaxLength(27)
                .HasColumnName("nome_arquivo");
        });

        modelBuilder.Entity<TblBilheteGarantiaErro>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_bilhete_garantia_erro_pkey");

            entity.ToTable("tbl_bilhete_garantia_erro");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(200)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<TblBilheteGarantiaRetorno>(entity =>
        {
            entity.HasKey(e => e.Arquivo).HasName("tbl_bilhete_garantia_retorno_pkey");

            entity.ToTable("tbl_bilhete_garantia_retorno");

            entity.Property(e => e.Arquivo)
                .HasMaxLength(40)
                .HasColumnName("arquivo");
            entity.Property(e => e.DataRetorno)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data_retorno");
        });

        modelBuilder.Entity<TblBilheteGarantium>(entity =>
        {
            entity.HasKey(e => new { e.Codloja, e.Sequencia }).HasName("tbl_bilhete_garantia_pkey");

            entity.ToTable("tbl_bilhete_garantia");

            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Sequencia).HasColumnName("sequencia");
            entity.Property(e => e.Bilhete)
                .HasMaxLength(22)
                .HasColumnName("bilhete");
            entity.Property(e => e.Codenvio)
                .HasDefaultValueSql("0")
                .HasColumnName("codenvio");
            entity.Property(e => e.CodenvioCancelamento)
                .HasDefaultValueSql("0")
                .HasColumnName("codenvio_cancelamento");
            entity.Property(e => e.CoderroCancelamento)
                .HasMaxLength(60)
                .HasColumnName("coderro_cancelamento");
            entity.Property(e => e.CoderroEnvio)
                .HasMaxLength(60)
                .HasColumnName("coderro_envio");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(11)
                .HasColumnName("codpedido");
            entity.Property(e => e.Codsubpedido).HasColumnName("codsubpedido");
            entity.Property(e => e.ConfAut)
                .HasComment("conferencia da autorização de cobrança")
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("conf_aut");
            entity.Property(e => e.ConfBilhete)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("conf_bilhete");
            entity.Property(e => e.CorrigidoComCancel)
                .HasMaxLength(1)
                .HasColumnName("corrigido_com_cancel");
            entity.Property(e => e.StatusCancelamento)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("status_cancelamento");
            entity.Property(e => e.StatusEnvio)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("status_envio");
            entity.Property(e => e.UserAut).HasColumnName("user_aut");
            entity.Property(e => e.UserBilhete).HasColumnName("user_bilhete");
        });

        modelBuilder.Entity<TblBoasVinda>(entity =>
        {
            entity.HasKey(e => e.CodMensagem).HasName("tbl_boas_vindas_pkey");

            entity.ToTable("tbl_boas_vindas");

            entity.Property(e => e.CodMensagem).HasColumnName("cod_mensagem");
            entity.Property(e => e.DataFim).HasColumnName("data_fim");
            entity.Property(e => e.DataInicio).HasColumnName("data_inicio");
            entity.Property(e => e.Mensagem).HasColumnName("mensagem");
        });

        modelBuilder.Entity<TblCadastroMargen>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_cadastro_margens_pkey");

            entity.ToTable("tbl_cadastro_margens");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Coddepartamento).HasColumnName("coddepartamento");
            entity.Property(e => e.Coddivisao).HasColumnName("coddivisao");
            entity.Property(e => e.Codmarca).HasColumnName("codmarca");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Datahora)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datahora");
            entity.Property(e => e.Margem)
                .HasPrecision(6, 2)
                .HasColumnName("margem");
            entity.Property(e => e.Markup)
                .HasPrecision(6, 2)
                .HasColumnName("markup");
        });

        modelBuilder.Entity<TblCadastroSenha>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_cadastro_senhas_pkey");

            entity.ToTable("tbl_cadastro_senhas");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasColumnName("ativo");
            entity.Property(e => e.CodDep)
                .HasDefaultValueSql("1")
                .HasColumnName("cod_dep");
            entity.Property(e => e.DataInsercao).HasColumnName("data_insercao");
            entity.Property(e => e.Descricao)
                .HasMaxLength(150)
                .HasColumnName("descricao");
            entity.Property(e => e.Ip)
                .HasMaxLength(120)
                .HasColumnName("ip");
            entity.Property(e => e.Loja)
                .HasMaxLength(100)
                .HasColumnName("loja");
            entity.Property(e => e.Objeto)
                .HasMaxLength(100)
                .HasColumnName("objeto");
            entity.Property(e => e.Observacao)
                .HasMaxLength(150)
                .HasColumnName("observacao");
            entity.Property(e => e.Senha)
                .HasMaxLength(120)
                .HasColumnName("senha");
            entity.Property(e => e.Url).HasColumnName("url");
            entity.Property(e => e.Usuario)
                .HasMaxLength(150)
                .HasColumnName("usuario");
            entity.Property(e => e.Usuariosenha)
                .HasMaxLength(120)
                .HasColumnName("usuariosenha");
        });

        modelBuilder.Entity<TblCadastroramai>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_cadastroramais_pkey");

            entity.ToTable("tbl_cadastroramais");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Departamento)
                .HasMaxLength(30)
                .HasColumnName("departamento");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Loja)
                .HasMaxLength(30)
                .HasColumnName("loja");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .HasColumnName("nome");
            entity.Property(e => e.Ramal).HasColumnName("ramal");
            entity.Property(e => e.Usuario)
                .HasMaxLength(15)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<TblCaixa>(entity =>
        {
            entity.HasKey(e => new { e.Letracaixa, e.Codloja }).HasName("tbl_caixas_pkey");

            entity.ToTable("tbl_caixas");

            entity.Property(e => e.Letracaixa)
                .HasMaxLength(4)
                .HasComment("Letra do Caixa")
                .HasColumnName("letracaixa");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.CodContaDominio).HasColumnName("cod_conta_dominio");
            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblcaixa'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .HasColumnName("descricao");
            entity.Property(e => e.Indice)
                .HasDefaultValueSql("0")
                .HasColumnName("indice");

            entity.HasOne(d => d.CodlojaNavigation).WithMany(p => p.TblCaixas)
                .HasForeignKey(d => d.Codloja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tbllojas");
        });

        modelBuilder.Entity<TblCaixaCreditoDiv>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_caixa_credito_div_pkey");

            entity.ToTable("tbl_caixa_credito_div", tb => tb.HasComment("Creditos deversos no caixa"));

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblcaixacreditodiv'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Codcaixamov).HasColumnName("codcaixamov");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Descricao).HasColumnName("descricao");
            entity.Property(e => e.Tipo)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasComment("Tipo de Credito DI ou CH")
                .HasColumnName("tipo");
            entity.Property(e => e.Valor)
                .HasPrecision(12, 2)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<TblCaixaDebito>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_caixa_debito_pkey");

            entity.ToTable("tbl_caixa_debito", tb => tb.HasComment("Registros de Débito da conta caixa em nosso sistema. Saídas de dinheiro.\n"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Caixa)
                .HasMaxLength(4)
                .HasColumnName("caixa");
            entity.Property(e => e.Caixaloja).HasColumnName("caixaloja");
            entity.Property(e => e.Coddivisao).HasColumnName("coddivisao");
            entity.Property(e => e.Coddivisaosub)
                .HasDefaultValueSql("1")
                .HasColumnName("coddivisaosub");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codparcelaagenda).HasColumnName("codparcelaagenda");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Datahora)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datahora");
            entity.Property(e => e.Estornado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("estornado");
            entity.Property(e => e.Estorno)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("estorno");
            entity.Property(e => e.Excluir)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("excluir");
            entity.Property(e => e.Fornecedor)
                .HasMaxLength(65)
                .HasColumnName("fornecedor");
            entity.Property(e => e.Idcaixa)
                .HasDefaultValueSql("1")
                .HasColumnName("idcaixa");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.Operacao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'D'::bpchar")
                .HasColumnName("operacao");
            entity.Property(e => e.Tipo)
                .HasMaxLength(2)
                .HasColumnName("tipo");
            entity.Property(e => e.Valor)
                .HasPrecision(12, 2)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<TblCaixaMov>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_caixa_mov_pkey");

            entity.ToTable("tbl_caixa_mov");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblmovcaixa'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Codloja)
                .HasComment("Codigo da loja que o caixa pertence")
                .HasColumnName("codloja");
            entity.Property(e => e.Codusuario)
                .HasComment("Codigo do Usuario que abriu esse caixa")
                .HasColumnName("codusuario");
            entity.Property(e => e.CredDiversoschpre)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Credido Diversos Cheque Pre")
                .HasColumnName("cred_diversoschpre");
            entity.Property(e => e.CredDiversosdi)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Credito Diversos DI")
                .HasColumnName("cred_diversosdi");
            entity.Property(e => e.CreditoChpre)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Credito Cheque Pre Transferencia")
                .HasColumnName("credito_chpre");
            entity.Property(e => e.CreditoDi)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Credito DI Transferencia")
                .HasColumnName("credito_di");
            entity.Property(e => e.Cxinicial)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Valor do Caixa Inicial")
                .HasColumnName("cxinicial");
            entity.Property(e => e.Datacaixa)
                .HasComment("Data de abertura do caixa")
                .HasColumnName("datacaixa");
            entity.Property(e => e.Datafecha)
                .HasComment("Data fechamento do caixa")
                .HasColumnName("datafecha");
            entity.Property(e => e.DebDiversoschpre)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Debito Diversos Cheque Pre")
                .HasColumnName("deb_diversoschpre");
            entity.Property(e => e.DebDiversosdi)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Debito Diversos DI")
                .HasColumnName("deb_diversosdi");
            entity.Property(e => e.DebitoChpre)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Debito Cheque Pre Transferencia")
                .HasColumnName("debito_chpre");
            entity.Property(e => e.DebitoDi)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Debito DI Transferencia")
                .HasColumnName("debito_di");
            entity.Property(e => e.EstContachpre)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Estorno de Conta Cheque Pre")
                .HasColumnName("est_contachpre");
            entity.Property(e => e.EstContadi)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Estorno de Conta DI")
                .HasColumnName("est_contadi");
            entity.Property(e => e.EstPedidochpre)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Estorno Pedido Cheque Pre")
                .HasColumnName("est_pedidochpre");
            entity.Property(e => e.EstPedidodi)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Estorno Pedido DI")
                .HasColumnName("est_pedidodi");
            entity.Property(e => e.FaltaCaixachpre)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Falta Caixa Cheque Pre")
                .HasColumnName("falta_caixachpre");
            entity.Property(e => e.FaltaCaixadi)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Falta Caixa DI")
                .HasColumnName("falta_caixadi");
            entity.Property(e => e.FaltaTotalcaixa)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Falta em caixa")
                .HasColumnName("falta_totalcaixa");
            entity.Property(e => e.Horacaixa)
                .HasComment("Hora de abertura do caixa")
                .HasColumnName("horacaixa");
            entity.Property(e => e.Horafecha)
                .HasPrecision(5)
                .HasComment("Hora do fechamento do caixa")
                .HasColumnName("horafecha");
            entity.Property(e => e.Letracaixa)
                .HasMaxLength(4)
                .HasComment("Letra do Caixa")
                .HasColumnName("letracaixa");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.RecContachpre)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Recebimento de Conta Cheque Pre")
                .HasColumnName("rec_contachpre");
            entity.Property(e => e.RecContadi)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Recebimento de Conta DI")
                .HasColumnName("rec_contadi");
            entity.Property(e => e.RecPedidochpre)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Recebimento Pedido Cheque Pre")
                .HasColumnName("rec_pedidochpre");
            entity.Property(e => e.RecPedidodi)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Recebimento de Pedido DI")
                .HasColumnName("rec_pedidodi");
            entity.Property(e => e.SaldoCaixa)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Saldo do caixa")
                .HasColumnName("saldo_caixa");
            entity.Property(e => e.Situacao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("'A' Caixa aberto 'F' Caixa fechado  \n'N' Caixa no aguardo")
                .HasColumnName("situacao");
            entity.Property(e => e.TotalCaixachpre)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Total Caixa Cheque Pre")
                .HasColumnName("total_caixachpre");
            entity.Property(e => e.TotalCaixadi)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Total em Caixa DI")
                .HasColumnName("total_caixadi");
            entity.Property(e => e.TotalCreditos)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Total em Creditos no Caixa")
                .HasColumnName("total_creditos");
            entity.Property(e => e.TotalDebitos)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Total de Debitos no Caixa")
                .HasColumnName("total_debitos");
        });

        modelBuilder.Entity<TblCaixaMovEstorno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_caixa_mov_estorno_pkey");

            entity.ToTable("tbl_caixa_mov_estorno");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codparcela).HasColumnName("codparcela");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(15)
                .HasColumnName("codpedido");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("now()")
                .HasColumnName("data");
            entity.Property(e => e.IdCaixa).HasColumnName("id_caixa");
            entity.Property(e => e.TipoEstorno)
                .HasMaxLength(15)
                .HasColumnName("tipo_estorno");
            entity.Property(e => e.Valor)
                .HasPrecision(9, 2)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<TblCaixaPrev>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_caixa_prev_pkey");

            entity.ToTable("tbl_caixa_prev");

            entity.HasIndex(e => e.Data, "tbl_caixa_prev_data_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Caixa)
                .HasMaxLength(4)
                .HasColumnName("caixa");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.IdDescricao).HasColumnName("id_descricao");
            entity.Property(e => e.Indice).HasColumnName("indice");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<TblCaixaPrevDesc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_caixa_prev_desc_pkey");

            entity.ToTable("tbl_caixa_prev_desc");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(30)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<TblCaixaPrevOb>(entity =>
        {
            entity.HasKey(e => e.Data).HasName("tbl_caixa_prev_obs_pkey");

            entity.ToTable("tbl_caixa_prev_obs");

            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Obs).HasColumnName("obs");
        });

        modelBuilder.Entity<TblCaixaTransferencium>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_caixa_transferencia_pkey");

            entity.ToTable("tbl_caixa_transferencia", tb => tb.HasComment("Valores que sao transferidos entre caixa."));

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblcaixatransferencia'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.BaixadoContabilidade)
                .HasDefaultValueSql("false")
                .HasColumnName("baixado_contabilidade");
            entity.Property(e => e.Caixacredito)
                .HasComment("Caixa de credito")
                .HasColumnName("caixacredito");
            entity.Property(e => e.Caixadebito)
                .HasComment("Caixa de Debito")
                .HasColumnName("caixadebito");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Confirma)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("Confirma entrada S ou N")
                .HasColumnName("confirma");
            entity.Property(e => e.Data)
                .HasComment("Data da transferencia")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Dataconfirma)
                .HasComment("Data da confirmação")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataconfirma");
            entity.Property(e => e.Estorno)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("estorno");
            entity.Property(e => e.Nsu)
                .HasColumnType("character varying")
                .HasColumnName("nsu");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.Tipo)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasComment("Tipo de transferencia DI ou DP")
                .HasColumnName("tipo");
            entity.Property(e => e.Valor)
                .HasPrecision(12, 2)
                .HasComment("Valor transferido")
                .HasColumnName("valor");
            entity.Property(e => e.Valorcreditado)
                .HasPrecision(12, 2)
                .HasComment("Valor que foi Creditado no caixa")
                .HasColumnName("valorcreditado");
        });

        modelBuilder.Entity<TblCaixaVale>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_caixa_vale_pkey");

            entity.ToTable("tbl_caixa_vale", tb => tb.HasComment("Vales retirado dos caixas quando a falta de dinheiro"));

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblcaixavale'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Codcaixamov)
                .HasComment("Codigo do movimento do caixa")
                .HasColumnName("codcaixamov");
            entity.Property(e => e.Codusuario)
                .HasComment("Codigo do usuario do caixa")
                .HasColumnName("codusuario");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Pago)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("pago");
            entity.Property(e => e.Valor)
                .HasPrecision(12, 2)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<TblCartaoFechamento>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_cartao_fechamento_pkey");

            entity.ToTable("tbl_cartao_fechamento");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.CodusuarioLoja).HasColumnName("codusuario_loja");
            entity.Property(e => e.DataConfLoja)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data_conf_loja");
            entity.Property(e => e.DataFechamento)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data_fechamento");
            entity.Property(e => e.DataMovimento).HasColumnName("data_movimento");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.ValorResumo).HasColumnName("valor_resumo");
        });

        modelBuilder.Entity<TblCartazPreco>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_cartaz_preco_pkey");

            entity.ToTable("tbl_cartaz_preco", tb => tb.HasComment("Imprime cartaz de preço\ncoluna fixar\nC1,C2,C3,C4,C5 - cartazes de preço\nD2,D3,D4 - display \nS2,S3,S4 - tipos de saquinho\nBA - Barbante\nDF - Dupla face\nDU - Durex\n"));

            entity.HasIndex(e => e.Codloja, "index_tblcartazimpre_codloja");

            entity.HasIndex(e => e.Dataimpre, "index_tblcartazpreco_dataimpre");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Avista)
                .HasPrecision(12, 2)
                .HasColumnName("avista");
            entity.Property(e => e.Cartao)
                .HasMaxLength(40)
                .HasColumnName("cartao");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Confirmado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("confirmado");
            entity.Property(e => e.Dataimpre)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataimpre");
            entity.Property(e => e.Datarecebido)
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("datarecebido");
            entity.Property(e => e.Etiqueta)
                .HasDefaultValueSql("0")
                .HasColumnName("etiqueta");
            entity.Property(e => e.Fixar)
                .HasMaxLength(20)
                .HasColumnName("fixar");
            entity.Property(e => e.Forma)
                .HasMaxLength(5)
                .HasColumnName("forma");
            entity.Property(e => e.Geradoem)
                .HasDefaultValueSql("('now'::text)::timestamp without time zone")
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("geradoem");
            entity.Property(e => e.Geradopor).HasColumnName("geradopor");
            entity.Property(e => e.Grupo)
                .HasDefaultValueSql("0")
                .HasColumnName("grupo");
            entity.Property(e => e.Impressopor)
                .HasDefaultValueSql("0")
                .HasColumnName("impressopor");
            entity.Property(e => e.Juro)
                .HasMaxLength(20)
                .HasColumnName("juro");
            entity.Property(e => e.Obs)
                .HasMaxLength(15)
                .HasColumnName("obs");
            entity.Property(e => e.PrazoReceber).HasColumnName("prazo_receber");
            entity.Property(e => e.Quantproduto).HasColumnName("quantproduto");
            entity.Property(e => e.Recebidopor)
                .HasDefaultValueSql("0")
                .HasColumnName("recebidopor");
            entity.Property(e => e.SemJuros).HasColumnName("sem_juros");
            entity.Property(e => e.Tamanho)
                .HasMaxLength(1)
                .HasColumnName("tamanho");
            entity.Property(e => e.Usuario)
                .HasMaxLength(30)
                .HasDefaultValueSql("\"current_user\"()")
                .HasColumnName("usuario");
            entity.Property(e => e.Valorcartao)
                .HasMaxLength(15)
                .HasColumnName("valorcartao");
            entity.Property(e => e.Valorparcelas)
                .HasPrecision(12, 2)
                .HasColumnName("valorparcelas");
        });

        modelBuilder.Entity<TblChecklistAtividade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_checklist_atividade_pkey");

            entity.ToTable("tbl_checklist_atividade");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ativa).HasColumnName("ativa");
            entity.Property(e => e.Atividade).HasColumnName("atividade");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.IdUserResponsavel).HasColumnName("id_user_responsavel");
            entity.Property(e => e.Obs).HasColumnName("obs");
        });

        modelBuilder.Entity<TblChecklistAtividadeFinalizado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_checklist_atividade_finalizado_pkey");

            entity.ToTable("tbl_checklist_atividade_finalizado");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.IdChecklistatividade).HasColumnName("id_checklistatividade");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
        });

        modelBuilder.Entity<TblChequePre>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_cheque_pre_pkey");

            entity.ToTable("tbl_cheque_pre");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Agencia)
                .HasMaxLength(10)
                .HasColumnName("agencia");
            entity.Property(e => e.Banco)
                .HasMaxLength(35)
                .HasColumnName("banco");
            entity.Property(e => e.Bancotroca)
                .HasMaxLength(15)
                .HasColumnName("bancotroca");
            entity.Property(e => e.Cadastrado)
                .HasMaxLength(50)
                .HasComment("usario que cadastrou o cheque")
                .HasColumnName("cadastrado");
            entity.Property(e => e.Cheque)
                .HasMaxLength(15)
                .HasColumnName("cheque");
            entity.Property(e => e.Codfornecedor)
                .HasDefaultValueSql("0")
                .HasColumnName("codfornecedor");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Conta)
                .HasMaxLength(15)
                .HasColumnName("conta");
            entity.Property(e => e.Cpf)
                .HasMaxLength(18)
                .HasColumnName("cpf");
            entity.Property(e => e.Datacadastro)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datacadastro");
            entity.Property(e => e.Datapassou)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datapassou");
            entity.Property(e => e.Emissao).HasColumnName("emissao");
            entity.Property(e => e.Enviadopor)
                .HasMaxLength(35)
                .HasComment("usuario que enviou o cheque")
                .HasColumnName("enviadopor");
            entity.Property(e => e.Fornecedor)
                .HasMaxLength(45)
                .HasColumnName("fornecedor");
            entity.Property(e => e.Nome)
                .HasMaxLength(40)
                .HasColumnName("nome");
            entity.Property(e => e.Pedido)
                .HasMaxLength(33)
                .HasColumnName("pedido");
            entity.Property(e => e.Situacao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'D'::character varying")
                .HasComment("Pago ou deve")
                .HasColumnName("situacao");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasColumnName("tipo");
            entity.Property(e => e.Valor).HasColumnName("valor");
            entity.Property(e => e.Vencimento).HasColumnName("vencimento");
        });

        modelBuilder.Entity<TblCidade>(entity =>
        {
            entity.HasKey(e => e.Codcidade).HasName("tbl_cidade_pkey1");

            entity.ToTable("tbl_cidade", tb => tb.HasComment("CÓDIGOS DAS CIDADES É DA LISTA DO IBGE\nhttps://www.ibge.gov.br/explica/codigos-dos-municipios.php\n\nidcidade é a coluna Município da tabela de códigos do IBGE,\ncodcidade é a coluna Código Município Completo"));

            entity.Property(e => e.Codcidade)
                .ValueGeneratedNever()
                .HasColumnName("codcidade");
            entity.Property(e => e.Cidade)
                .HasMaxLength(35)
                .HasColumnName("cidade");
            entity.Property(e => e.Codrota)
                .HasDefaultValueSql("1")
                .HasColumnName("codrota");
            entity.Property(e => e.Coduf).HasColumnName("coduf");
            entity.Property(e => e.Idcidade)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("idcidade");

            entity.HasOne(d => d.CodufNavigation).WithMany(p => p.TblCidades)
                .HasForeignKey(d => d.Coduf)
                .HasConstraintName("tbl_cidade_ibge_coduf_fkey");
        });

        modelBuilder.Entity<TblCidadeApagar>(entity =>
        {
            entity.HasKey(e => e.Codcidade).HasName("tbl_cidade_pkey");

            entity.ToTable("tbl_cidade_apagar");

            entity.HasIndex(e => e.Cidade, "tbl_cidade_cidade_key").IsUnique();

            entity.Property(e => e.Codcidade)
                .HasDefaultValueSql("nextval('seq_tblcidade'::regclass)")
                .HasColumnName("codcidade");
            entity.Property(e => e.Cidade)
                .HasDefaultValueSql("50")
                .HasColumnName("cidade");
            entity.Property(e => e.Codrota)
                .HasDefaultValueSql("1")
                .HasComment("Codigo da rota do romaneio a qual pertence a cidade.")
                .HasColumnName("codrota");
            entity.Property(e => e.Usuario)
                .HasMaxLength(35)
                .HasDefaultValueSql("\"current_user\"()")
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<TblClasseHist>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_classe_hist_pkey");

            entity.ToTable("tbl_classe_hist");

            entity.HasIndex(e => e.Atual, "index_tbl_classe_hist_atual");

            entity.HasIndex(e => e.Atualizado, "index_tbl_classe_hist_atualizado");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblclassehist'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Anterior)
                .HasMaxLength(1)
                .HasColumnName("anterior");
            entity.Property(e => e.Atual)
                .HasMaxLength(1)
                .HasColumnName("atual");
            entity.Property(e => e.Atualizado).HasColumnName("atualizado");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");

            entity.HasOne(d => d.CodclienteNavigation).WithMany(p => p.TblClasseHists)
                .HasForeignKey(d => d.Codcliente)
                .HasConstraintName("tbl_classe_hist_codcliente_fkey");

            entity.HasOne(d => d.CodusuarioNavigation).WithMany(p => p.TblClasseHists)
                .HasForeignKey(d => d.Codusuario)
                .HasConstraintName("tbl_classe_hist_codusuario_fkey");
        });

        modelBuilder.Entity<TblCliente>(entity =>
        {
            entity.HasKey(e => e.Codcliente).HasName("codigo");

            entity.ToTable("tbl_cliente");

            entity.HasIndex(e => e.Classe, "index_classe");

            entity.HasIndex(e => e.Pricontato, "index_pricontato");

            entity.HasIndex(e => e.Segcontato, "index_segcontato");

            entity.Property(e => e.Codcliente)
                .HasDefaultValueSql("nextval('seq_tblcliente'::regclass)")
                .HasColumnName("codcliente");
            entity.Property(e => e.Admissao).HasColumnName("admissao");
            entity.Property(e => e.Agendacobranca).HasColumnName("agendacobranca");
            entity.Property(e => e.Aprovadopor)
                .HasMaxLength(35)
                .HasComment("quem aprovou o cadastro")
                .HasColumnName("aprovadopor");
            entity.Property(e => e.Atualizado).HasColumnName("atualizado");
            entity.Property(e => e.Bairro)
                .HasMaxLength(120)
                .HasColumnName("bairro");
            entity.Property(e => e.BairroC)
                .HasMaxLength(30)
                .HasColumnName("bairro_c");
            entity.Property(e => e.Beneficio)
                .HasMaxLength(25)
                .HasColumnName("beneficio");
            entity.Property(e => e.CadEmp)
                .HasDefaultValueSql("false")
                .HasColumnName("cad_emp");
            entity.Property(e => e.Cadassinado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("cadassinado");
            entity.Property(e => e.Cargo)
                .HasMaxLength(30)
                .HasColumnName("cargo");
            entity.Property(e => e.Carta1)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("Carta 1")
                .HasColumnName("carta1");
            entity.Property(e => e.Carta2)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("Carta 2")
                .HasColumnName("carta2");
            entity.Property(e => e.Carta22)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("carta2_2");
            entity.Property(e => e.Carta23)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("carta2_3");
            entity.Property(e => e.Carta3)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("carta 3")
                .HasColumnName("carta3");
            entity.Property(e => e.Carta4)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("Carta 4")
                .HasColumnName("carta4");
            entity.Property(e => e.Carta5)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("carta 5")
                .HasColumnName("carta5");
            entity.Property(e => e.Celular)
                .HasMaxLength(15)
                .HasColumnName("celular");
            entity.Property(e => e.Cep)
                .HasMaxLength(10)
                .HasColumnName("cep");
            entity.Property(e => e.CepC)
                .HasMaxLength(10)
                .HasColumnName("cep_c");
            entity.Property(e => e.Cidade)
                .HasMaxLength(120)
                .HasColumnName("cidade");
            entity.Property(e => e.CidadeC)
                .HasMaxLength(30)
                .HasColumnName("cidade_c");
            entity.Property(e => e.Classe)
                .HasMaxLength(1)
                .HasDefaultValueSql("'D'::character varying")
                .HasColumnName("classe");
            entity.Property(e => e.ClienteSpc)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("SE O TITULAR FOI NEGATIVADO")
                .HasColumnName("cliente_spc");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(18)
                .HasColumnName("cnpj");
            entity.Property(e => e.Codbairro).HasColumnName("codbairro");
            entity.Property(e => e.CodbairroC).HasColumnName("codbairro_c");
            entity.Property(e => e.CodbairroEmpConj).HasColumnName("codbairro_emp_conj");
            entity.Property(e => e.Codcidade).HasColumnName("codcidade");
            entity.Property(e => e.CodcidadeC).HasColumnName("codcidade_c");
            entity.Property(e => e.CodcidadeEmpConj).HasColumnName("codcidade_emp_conj");
            entity.Property(e => e.Codfiador).HasColumnName("codfiador");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.ComplemEnd)
                .HasMaxLength(50)
                .HasColumnName("complem_end");
            entity.Property(e => e.Confirmadocom)
                .HasMaxLength(35)
                .HasColumnName("confirmadocom");
            entity.Property(e => e.Confreaprovacao)
                .HasMaxLength(120)
                .HasComment("dados da conferencia da reaprovação do cadastro")
                .HasColumnName("confreaprovacao");
            entity.Property(e => e.ConjAdmissao).HasColumnName("conj_admissao");
            entity.Property(e => e.ConjBeneficio)
                .HasMaxLength(25)
                .HasColumnName("conj_beneficio");
            entity.Property(e => e.ConjCargo)
                .HasMaxLength(30)
                .HasColumnName("conj_cargo");
            entity.Property(e => e.ConjCelular)
                .HasMaxLength(15)
                .HasColumnName("conj_celular");
            entity.Property(e => e.ConjConfirmadocom)
                .HasMaxLength(35)
                .HasColumnName("conj_confirmadocom");
            entity.Property(e => e.ConjConsspc)
                .HasComment("ultima consulta spc conjuge")
                .HasColumnName("conj_consspc");
            entity.Property(e => e.ConjCpf)
                .HasMaxLength(14)
                .HasColumnName("conj_cpf");
            entity.Property(e => e.ConjEmpBairro)
                .HasMaxLength(30)
                .HasColumnName("conj_emp_bairro");
            entity.Property(e => e.ConjEmpCep)
                .HasMaxLength(10)
                .HasColumnName("conj_emp_cep");
            entity.Property(e => e.ConjEmpCidade)
                .HasMaxLength(30)
                .HasColumnName("conj_emp_cidade");
            entity.Property(e => e.ConjEmpEndereco)
                .HasMaxLength(45)
                .HasColumnName("conj_emp_endereco");
            entity.Property(e => e.ConjEmpFone)
                .HasMaxLength(30)
                .HasColumnName("conj_emp_fone");
            entity.Property(e => e.ConjEmpUf)
                .HasMaxLength(2)
                .HasColumnName("conj_emp_uf");
            entity.Property(e => e.ConjEmpresa)
                .HasMaxLength(45)
                .HasColumnName("conj_empresa");
            entity.Property(e => e.ConjMae)
                .HasMaxLength(35)
                .HasColumnName("conj_mae");
            entity.Property(e => e.ConjNascimento).HasColumnName("conj_nascimento");
            entity.Property(e => e.ConjNaturalidade)
                .HasMaxLength(30)
                .HasColumnName("conj_naturalidade");
            entity.Property(e => e.ConjNegativado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("se conjuge esta negativado spc serasa")
                .HasColumnName("conj_negativado");
            entity.Property(e => e.ConjOe)
                .HasMaxLength(7)
                .HasColumnName("conj_oe");
            entity.Property(e => e.ConjPai)
                .HasMaxLength(35)
                .HasColumnName("conj_pai");
            entity.Property(e => e.ConjRendaliquida)
                .HasDefaultValueSql("0")
                .HasColumnName("conj_rendaliquida");
            entity.Property(e => e.ConjRg)
                .HasMaxLength(15)
                .HasColumnName("conj_rg");
            entity.Property(e => e.Conjuge)
                .HasMaxLength(40)
                .HasColumnName("conjuge");
            entity.Property(e => e.ConjugeSpc)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("conjuge_spc");
            entity.Property(e => e.Consspc)
                .HasComment("data da ultima consulta ao SPC Serara")
                .HasColumnName("consspc");
            entity.Property(e => e.ContatoQuitado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasComment("contato apos quitada as parcelas\ns/n")
                .HasColumnName("contato_quitado");
            entity.Property(e => e.Contatoniver).HasColumnName("contatoniver");
            entity.Property(e => e.Cpf)
                .HasMaxLength(20)
                .HasColumnName("cpf");
            entity.Property(e => e.Ctps)
                .HasMaxLength(10)
                .HasColumnName("ctps");
            entity.Property(e => e.Dataaprovacao).HasColumnName("dataaprovacao");
            entity.Property(e => e.Datacadastro).HasColumnName("datacadastro");
            entity.Property(e => e.DatacontatoQuitado)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datacontato_quitado");
            entity.Property(e => e.Datacontatoniver)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("datacontatoniver");
            entity.Property(e => e.Email)
                .HasMaxLength(120)
                .HasColumnName("email");
            entity.Property(e => e.EmpBairro)
                .HasMaxLength(30)
                .HasColumnName("emp_bairro");
            entity.Property(e => e.EmpCep)
                .HasMaxLength(10)
                .HasColumnName("emp_cep");
            entity.Property(e => e.EmpCidade)
                .HasMaxLength(30)
                .HasColumnName("emp_cidade");
            entity.Property(e => e.EmpEndereco)
                .HasMaxLength(45)
                .HasColumnName("emp_endereco");
            entity.Property(e => e.EmpFone)
                .HasMaxLength(30)
                .HasColumnName("emp_fone");
            entity.Property(e => e.EmpUf)
                .HasMaxLength(2)
                .HasColumnName("emp_uf");
            entity.Property(e => e.EmpreCodbairro).HasColumnName("empre_codbairro");
            entity.Property(e => e.EmpreCodcidade)
                .HasComment("\n")
                .HasColumnName("empre_codcidade");
            entity.Property(e => e.EmpreEnderecoNum)
                .HasMaxLength(15)
                .HasColumnName("empre_endereco_num");
            entity.Property(e => e.Empresa)
                .HasMaxLength(45)
                .HasColumnName("empresa");
            entity.Property(e => e.Endereco)
                .HasMaxLength(120)
                .HasColumnName("endereco");
            entity.Property(e => e.EnderecoC)
                .HasMaxLength(45)
                .HasColumnName("endereco_c");
            entity.Property(e => e.EnderecoNum)
                .HasMaxLength(15)
                .HasColumnName("endereco_num");
            entity.Property(e => e.EnderecoNumC)
                .HasMaxLength(15)
                .HasColumnName("endereco_num_c");
            entity.Property(e => e.EnderecoNumEmpConj)
                .HasMaxLength(15)
                .HasColumnName("endereco_num_emp_conj");
            entity.Property(e => e.Estadocivil)
                .HasMaxLength(10)
                .HasColumnName("estadocivil");
            entity.Property(e => e.Expedicaorg).HasColumnName("expedicaorg");
            entity.Property(e => e.Fone)
                .HasMaxLength(30)
                .HasColumnName("fone");
            entity.Property(e => e.Genero)
                .HasMaxLength(20)
                .HasColumnName("genero");
            entity.Property(e => e.Inscest)
                .HasMaxLength(17)
                .HasColumnName("inscest");
            entity.Property(e => e.Limitecredito)
                .HasDefaultValueSql("0")
                .HasColumnName("limitecredito");
            entity.Property(e => e.Mae)
                .HasMaxLength(35)
                .HasColumnName("mae");
            entity.Property(e => e.MesmoEnd)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("mesmo_end");
            entity.Property(e => e.Nascimento).HasColumnName("nascimento");
            entity.Property(e => e.Naturalidade)
                .HasMaxLength(30)
                .HasColumnName("naturalidade");
            entity.Property(e => e.Negativado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("se titular esta negativado spc serasa")
                .HasColumnName("negativado");
            entity.Property(e => e.Nome)
                .HasMaxLength(120)
                .HasColumnName("nome");
            entity.Property(e => e.Obs2).HasColumnName("obs2");
            entity.Property(e => e.ObsQuitado)
                .HasComment("observações do contato apos quitado as parcelas")
                .HasColumnName("obs_quitado");
            entity.Property(e => e.Observacao).HasColumnName("observacao");
            entity.Property(e => e.Obsreaprovar).HasColumnName("obsreaprovar");
            entity.Property(e => e.Oe)
                .HasMaxLength(10)
                .HasColumnName("oe");
            entity.Property(e => e.Origemrendaadd)
                .HasComment("Origem da renda Add")
                .HasColumnName("origemrendaadd");
            entity.Property(e => e.Pai)
                .HasMaxLength(35)
                .HasColumnName("pai");
            entity.Property(e => e.Pgtopara)
                .HasComment("Promessa de pagamento")
                .HasColumnName("pgtopara");
            entity.Property(e => e.PriAprovacao)
                .HasComment("primeira data de aprovação do clietne")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("pri_aprovacao");
            entity.Property(e => e.PriSituacao)
                .HasMaxLength(10)
                .HasComment("primeira situação do cliente se ele foi aprovado ou negado")
                .HasColumnName("pri_situacao");
            entity.Property(e => e.PriUsuario)
                .HasMaxLength(40)
                .HasComment("usuario que aprovou o cadastro pela primeira vez")
                .HasColumnName("pri_usuario");
            entity.Property(e => e.Pricontato)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("pricontato");
            entity.Property(e => e.Protesto)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("protesto");
            entity.Property(e => e.Reaprovar)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("reaprovar");
            entity.Property(e => e.RecadoCom)
                .HasMaxLength(50)
                .HasColumnName("recado_com");
            entity.Property(e => e.Rendaadd)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("rendaadd");
            entity.Property(e => e.RendaaddAutor)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Renda Adicional autorizada")
                .HasColumnName("rendaadd_autor");
            entity.Property(e => e.Rendaliquida)
                .HasDefaultValueSql("0")
                .HasColumnName("rendaliquida");
            entity.Property(e => e.Rg)
                .HasMaxLength(20)
                .HasColumnName("rg");
            entity.Property(e => e.Rotacobranca)
                .HasComment("Rota de cobrança")
                .HasColumnName("rotacobranca");
            entity.Property(e => e.Segcontato)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("segcontato");
            entity.Property(e => e.Serie)
                .HasMaxLength(10)
                .HasColumnName("serie");
            entity.Property(e => e.Situacao)
                .HasMaxLength(20)
                .HasDefaultValueSql("'ANALISE'::character varying")
                .HasColumnName("situacao");
            entity.Property(e => e.Temporesid)
                .HasMaxLength(12)
                .HasColumnName("temporesid");
            entity.Property(e => e.Temporeside).HasColumnName("temporeside");
            entity.Property(e => e.Tipocadastro)
                .HasMaxLength(1)
                .HasDefaultValueSql("'F'::bpchar")
                .HasComment("Tipo de cadastro pessoua Fisica ou Juridica")
                .HasColumnName("tipocadastro");
            entity.Property(e => e.Tipoemprego)
                .HasMaxLength(25)
                .HasComment("tipo de profissao do titular")
                .HasColumnName("tipoemprego");
            entity.Property(e => e.Tipoempregoconj)
                .HasMaxLength(25)
                .HasComment("tipo de profissao do conjuge\n")
                .HasColumnName("tipoempregoconj");
            entity.Property(e => e.Tipofone)
                .HasMaxLength(10)
                .HasColumnName("tipofone");
            entity.Property(e => e.Tiporendaadd)
                .HasMaxLength(20)
                .HasColumnName("tiporendaadd");
            entity.Property(e => e.Tiporesid)
                .HasMaxLength(20)
                .HasColumnName("tiporesid");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
            entity.Property(e => e.UfC)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("uf_c");
            entity.Property(e => e.Userrendaadd)
                .HasMaxLength(35)
                .HasComment("usuario que autorizou renda adicional")
                .HasColumnName("userrendaadd");
            entity.Property(e => e.Vip)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("vip");
        });

        modelBuilder.Entity<TblClienteContatoCquitado>(entity =>
        {
            entity.HasKey(e => e.IdCquitado).HasName("tbl_cliente_contato_cquitado_pkey");

            entity.ToTable("tbl_cliente_contato_cquitado", tb => tb.HasComment("tabela com o histórico de contatos de ligação de carnê quitado"));

            entity.Property(e => e.IdCquitado).HasColumnName("id_cquitado");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.DatacontatoQuitado)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datacontato_quitado");
            entity.Property(e => e.ObsQuitado).HasColumnName("obs_quitado");
        });

        modelBuilder.Entity<TblClienteEmp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_cliente_emp_pkey");

            entity.ToTable("tbl_cliente_emp");

            entity.HasIndex(e => e.Codcliente, "tbl_cliente_emp_codcliente_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.GrupoPreco)
                .HasMaxLength(60)
                .HasColumnName("grupo_preco");
            entity.Property(e => e.ListaPreco)
                .HasMaxLength(60)
                .HasColumnName("lista_preco");
            entity.Property(e => e.RegiaoVenda)
                .HasMaxLength(60)
                .HasColumnName("regiao_venda");
        });

        modelBuilder.Entity<TblClienteEntroup>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_cliente_entroup_pkey");

            entity.ToTable("tbl_cliente_entroup");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<TblClienteJuridica>(entity =>
        {
            entity.HasKey(e => e.Codcliente).HasName("tbl_cliente_juridica_pkey");

            entity.ToTable("tbl_cliente_juridica");

            entity.Property(e => e.Codcliente)
                .ValueGeneratedNever()
                .HasColumnName("codcliente");
            entity.Property(e => e.Celular)
                .HasMaxLength(20)
                .HasColumnName("celular");
            entity.Property(e => e.Cep)
                .HasMaxLength(10)
                .HasColumnName("cep");
            entity.Property(e => e.Codbairro).HasColumnName("codbairro");
            entity.Property(e => e.Codcidade).HasColumnName("codcidade");
            entity.Property(e => e.Complemento)
                .HasMaxLength(50)
                .HasColumnName("complemento");
            entity.Property(e => e.Cpf)
                .HasMaxLength(15)
                .HasColumnName("cpf");
            entity.Property(e => e.Email)
                .HasMaxLength(40)
                .HasColumnName("email");
            entity.Property(e => e.Endereco)
                .HasMaxLength(45)
                .HasColumnName("endereco");
            entity.Property(e => e.Estadocivil)
                .HasMaxLength(10)
                .HasColumnName("estadocivil");
            entity.Property(e => e.Fone)
                .HasMaxLength(20)
                .HasColumnName("fone");
            entity.Property(e => e.Mae)
                .HasMaxLength(40)
                .HasColumnName("mae");
            entity.Property(e => e.Nascimento).HasColumnName("nascimento");
            entity.Property(e => e.Naturalidade)
                .HasMaxLength(30)
                .HasColumnName("naturalidade");
            entity.Property(e => e.Nome)
                .HasMaxLength(40)
                .HasColumnName("nome");
            entity.Property(e => e.Numero)
                .HasMaxLength(15)
                .HasColumnName("numero");
            entity.Property(e => e.Pai)
                .HasMaxLength(40)
                .HasColumnName("pai");
            entity.Property(e => e.Residedesde).HasColumnName("residedesde");
            entity.Property(e => e.Rg)
                .HasMaxLength(15)
                .HasColumnName("rg");
            entity.Property(e => e.Tiporesid)
                .HasMaxLength(20)
                .HasColumnName("tiporesid");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("uf");
        });

        modelBuilder.Entity<TblCloneCaixaMov>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_clone_caixa_mov");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.CredDiversoschpre)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("cred_diversoschpre");
            entity.Property(e => e.CredDiversosdi)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("cred_diversosdi");
            entity.Property(e => e.CreditoChpre)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("credito_chpre");
            entity.Property(e => e.CreditoDi)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("credito_di");
            entity.Property(e => e.Cxinicial)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("cxinicial");
            entity.Property(e => e.Datacaixa).HasColumnName("datacaixa");
            entity.Property(e => e.Datafecha).HasColumnName("datafecha");
            entity.Property(e => e.DebDiversoschpre)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("deb_diversoschpre");
            entity.Property(e => e.DebDiversosdi)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("deb_diversosdi");
            entity.Property(e => e.DebitoChpre)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("debito_chpre");
            entity.Property(e => e.DebitoDi)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("debito_di");
            entity.Property(e => e.EstContachpre)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("est_contachpre");
            entity.Property(e => e.EstContadi)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("est_contadi");
            entity.Property(e => e.EstPedidochpre)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("est_pedidochpre");
            entity.Property(e => e.EstPedidodi)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("est_pedidodi");
            entity.Property(e => e.FaltaCaixachpre)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("falta_caixachpre");
            entity.Property(e => e.FaltaCaixadi)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("falta_caixadi");
            entity.Property(e => e.FaltaTotalcaixa)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("falta_totalcaixa");
            entity.Property(e => e.Horacaixa).HasColumnName("horacaixa");
            entity.Property(e => e.Horafecha)
                .HasPrecision(5)
                .HasColumnName("horafecha");
            entity.Property(e => e.Letracaixa)
                .HasMaxLength(4)
                .HasColumnName("letracaixa");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.RecContachpre)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("rec_contachpre");
            entity.Property(e => e.RecContadi)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("rec_contadi");
            entity.Property(e => e.RecPedidochpre)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("rec_pedidochpre");
            entity.Property(e => e.RecPedidodi)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("rec_pedidodi");
            entity.Property(e => e.SaldoCaixa)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("saldo_caixa");
            entity.Property(e => e.Situacao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("situacao");
            entity.Property(e => e.TotalCaixachpre)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("total_caixachpre");
            entity.Property(e => e.TotalCaixadi)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("total_caixadi");
            entity.Property(e => e.TotalCreditos)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("total_creditos");
            entity.Property(e => e.TotalDebitos)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("total_debitos");
        });

        modelBuilder.Entity<TblCobrancaCont>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_cobranca_cont_pkey");

            entity.ToTable("tbl_cobranca_cont", tb => tb.HasComment("Contatos realizados pela cobrança"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.ClienteProcessado).HasColumnName("cliente_processado");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Datacontato)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datacontato");
            entity.Property(e => e.Descricao).HasColumnName("descricao");
        });

        modelBuilder.Entity<TblComprasCota>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_compras_cotas_pkey");

            entity.ToTable("tbl_compras_cotas");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Cota)
                .HasPrecision(8)
                .HasColumnName("cota");
            entity.Property(e => e.Divisao)
                .HasMaxLength(35)
                .HasColumnName("divisao");
            entity.Property(e => e.Mes)
                .HasMaxLength(15)
                .HasColumnName("mes");
            entity.Property(e => e.Porc).HasColumnName("porc");
        });

        modelBuilder.Entity<TblConfBloquearEmissaoNfeNfce>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_conf_bloquear_emissao_nfe_pkey");

            entity.ToTable("tbl_conf_bloquear_emissao_nfe_nfce");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('tbl_conf_bloquear_emissao_nfe_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Bloqueado)
                .HasDefaultValueSql("false")
                .HasColumnName("bloqueado");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Loja)
                .HasDefaultValueSql("0")
                .HasColumnType("character varying")
                .HasColumnName("loja");
            entity.Property(e => e.Tipo)
                .HasColumnType("character varying")
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TblContaEstoque>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_conta_estoque_pkey");

            entity.ToTable("tbl_conta_estoque");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Datafim)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datafim");
            entity.Property(e => e.Datainicio)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datainicio");
            entity.Property(e => e.Departamento).HasColumnName("departamento");
            entity.Property(e => e.Divisao)
                .HasMaxLength(30)
                .HasColumnName("divisao");
            entity.Property(e => e.Fechada)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("fechada");
            entity.Property(e => e.Fechadapor)
                .HasMaxLength(35)
                .HasColumnName("fechadapor");
            entity.Property(e => e.Loja)
                .HasMaxLength(50)
                .HasColumnName("loja");
        });

        modelBuilder.Entity<TblContaEstoquerotativo>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_conta_estoquerotativo_pkey");

            entity.ToTable("tbl_conta_estoquerotativo");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Codusuariofechou).HasColumnName("codusuariofechou");
            entity.Property(e => e.Datafim)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("datafim");
            entity.Property(e => e.Datainicio)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("datainicio");
            entity.Property(e => e.Datamovimento).HasColumnName("datamovimento");
            entity.Property(e => e.Datasenha)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("datasenha");
            entity.Property(e => e.Obssenha).HasColumnName("obssenha");
            entity.Property(e => e.Prazo).HasColumnName("prazo");
            entity.Property(e => e.Senha)
                .HasDefaultValueSql("0")
                .HasColumnName("senha");
        });

        modelBuilder.Entity<TblContaEstoquerotativoSub>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_conta_estoquerotativo_sub_pkey");

            entity.ToTable("tbl_conta_estoquerotativo_sub");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codcontagem).HasColumnName("codcontagem");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Contado)
                .HasDefaultValueSql("0")
                .HasColumnName("contado");
            entity.Property(e => e.Custo)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("custo");
            entity.Property(e => e.Entregafim)
                .HasDefaultValueSql("0")
                .HasColumnName("entregafim");
            entity.Property(e => e.Entregainicio)
                .HasDefaultValueSql("0")
                .HasColumnName("entregainicio");
            entity.Property(e => e.Estoquefim)
                .HasDefaultValueSql("0")
                .HasColumnName("estoquefim");
            entity.Property(e => e.Estoqueinicio)
                .HasDefaultValueSql("0")
                .HasColumnName("estoqueinicio");
            entity.Property(e => e.Prepedido)
                .HasDefaultValueSql("0")
                .HasColumnName("prepedido");
            entity.Property(e => e.Saldo)
                .HasDefaultValueSql("0")
                .HasColumnName("saldo");
            entity.Property(e => e.Transentrando)
                .HasDefaultValueSql("0")
                .HasColumnName("transentrando");
            entity.Property(e => e.Transsaindo)
                .HasDefaultValueSql("0")
                .HasColumnName("transsaindo");
        });

        modelBuilder.Entity<TblContrato>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_contratos_pkey");

            entity.ToTable("tbl_contratos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Coddep)
                .HasDefaultValueSql("1")
                .HasColumnName("coddep");
            entity.Property(e => e.Contrato)
                .HasMaxLength(100)
                .HasColumnName("contrato");
            entity.Property(e => e.Datavisualizou).HasColumnName("datavisualizou");
            entity.Property(e => e.DtFinal).HasColumnName("dt_final");
            entity.Property(e => e.DtInicio).HasColumnName("dt_inicio");
            entity.Property(e => e.DtResolvido).HasColumnName("dt_resolvido");
            entity.Property(e => e.EnvioF4).HasColumnName("envio_f4");
            entity.Property(e => e.NContrato)
                .HasMaxLength(50)
                .HasColumnName("n_contrato");
            entity.Property(e => e.Resolvido).HasColumnName("resolvido");
            entity.Property(e => e.Ultimoacesso).HasColumnName("ultimoacesso");
            entity.Property(e => e.Usuarioresolveu).HasColumnName("usuarioresolveu");
        });

        modelBuilder.Entity<TblCor>(entity =>
        {
            entity.HasKey(e => e.Codcor).HasName("tblcor_pkey");

            entity.ToTable("tbl_cor");

            entity.Property(e => e.Codcor)
                .HasDefaultValueSql("nextval('seq_tblcor'::regclass)")
                .HasColumnName("codcor");
            entity.Property(e => e.Atualizado)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("atualizado");
            entity.Property(e => e.AtualizadoWeb)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("atualizado_web");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.CodusuarioWeb).HasColumnName("codusuario_web");
            entity.Property(e => e.Cor)
                .HasMaxLength(20)
                .HasColumnName("cor");
        });

        modelBuilder.Entity<TblCusto>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cp_tblcusto");

            entity.ToTable("tbl_custo", tb => tb.HasComment("SETOR: VENDAS, FINANCEIRO, FISCAL, CONTÁBIL\nNesta tabela encontra-se uma série de alíquotas utilizadas na comercialização de produtos, parcelamento, caixa e descontos.\nTambém estão inseridas a comissão de cada divisão, com o nome iniciado em \"comi_\""));

            entity.Property(e => e.Codigo)
                .ValueGeneratedNever()
                .HasColumnName("codigo");
            entity.Property(e => e.Carenciapmedio)
                .HasComment("Carencia permitida no prazo medio ")
                .HasColumnName("carenciapmedio");
            entity.Property(e => e.ComiBrinquedo)
                .HasPrecision(6, 2)
                .HasColumnName("comi_brinquedo");
            entity.Property(e => e.ComiConstrucao)
                .HasPrecision(6, 2)
                .HasColumnName("comi_construcao");
            entity.Property(e => e.ComiEcommerce)
                .HasPrecision(6, 2)
                .HasColumnName("comi_ecommerce");
            entity.Property(e => e.ComiEletro)
                .HasPrecision(6, 2)
                .HasColumnName("comi_eletro");
            entity.Property(e => e.ComiMoveis)
                .HasPrecision(6, 2)
                .HasColumnName("comi_moveis");
            entity.Property(e => e.ComiPresente)
                .HasPrecision(6, 2)
                .HasColumnName("comi_presente");
            entity.Property(e => e.ComiSeguroAp)
                .HasPrecision(6, 2)
                .HasColumnName("comi_seguro_ap");
            entity.Property(e => e.ComiSeguroGarantia)
                .HasPrecision(4, 2)
                .HasColumnName("comi_seguro_garantia");
            entity.Property(e => e.Comissaovenda)
                .HasComment("Comissao Vendedores")
                .HasColumnName("comissaovenda");
            entity.Property(e => e.Custofrota)
                .HasComment("Custo da Frota (Frete Entrega)")
                .HasColumnName("custofrota");
            entity.Property(e => e.DescDoacrescimo)
                .HasPrecision(4, 2)
                .HasComment("Desconto Permitido em cima do juro cobrado na parcela")
                .HasColumnName("desc_doacrescimo");
            entity.Property(e => e.DescDoacrescimoGerente)
                .HasPrecision(4, 2)
                .HasColumnName("desc_doacrescimo_gerente");
            entity.Property(e => e.DescMaxBotafora)
                .HasComment("Desconto Maximo Permitodo em Produtos no Bota Fora")
                .HasColumnName("desc_max_botafora");
            entity.Property(e => e.DescMaxJuroespec)
                .HasComment("Desconto Maximo Permitido no juro espceial")
                .HasColumnName("desc_max_juroespec");
            entity.Property(e => e.DescMaxNormal)
                .HasComment("Desconto Maximo Permitido em Produtos normais ")
                .HasColumnName("desc_max_normal");
            entity.Property(e => e.DescMaxPromocao)
                .HasComment("Desconto Maximo Permitido para produtos em promoção")
                .HasColumnName("desc_max_promocao");
            entity.Property(e => e.Desconto)
                .HasComment("Desconto Preço a Vista")
                .HasColumnName("desconto");
            entity.Property(e => e.Despesaadm)
                .HasComment("Despesa administrativa e Deposito")
                .HasColumnName("despesaadm");
            entity.Property(e => e.Despesaassist)
                .HasPrecision(4, 2)
                .HasComment("porcentagem de assistencia tecnica")
                .HasColumnName("despesaassist");
            entity.Property(e => e.Diasacrescimo)
                .HasDefaultValueSql("0")
                .HasComment("Quantidade de dias para cobrar\njuro, apos ultrapassar esse valor sera cobrado juro nas parcelas.")
                .HasColumnName("diasacrescimo");
            entity.Property(e => e.Diasdesconto)
                .HasDefaultValueSql("0")
                .HasComment("Quantidade de dias para conceder desconto no pagamento de conta.")
                .HasColumnName("diasdesconto");
            entity.Property(e => e.Impostoe)
                .HasComment("ICMS")
                .HasColumnName("impostoe");
            entity.Property(e => e.Impostof)
                .HasComment("PIS E FINSOCIAL")
                .HasColumnName("impostof");
            entity.Property(e => e.Inflacao)
                .HasComment("Inflaçao mensal")
                .HasColumnName("inflacao");
            entity.Property(e => e.Juroacrescimo)
                .HasPrecision(4, 2)
                .HasDefaultValueSql("0")
                .HasComment("Taxa de juro cobrado quando a atraso do pagamento de parcelas.")
                .HasColumnName("juroacrescimo");
            entity.Property(e => e.Jurodesconto)
                .HasPrecision(4, 2)
                .HasDefaultValueSql("0")
                .HasComment("Taxa de juro cobrado no desconto de parcelas quanto pagas com antecedencia")
                .HasColumnName("jurodesconto");
            entity.Property(e => e.Jurodiapmedio)
                .HasPrecision(9, 6)
                .HasComment("Juro cobrado ao dia quando excede prazo medio da compra")
                .HasColumnName("jurodiapmedio");
            entity.Property(e => e.Jurofinanciamento)
                .HasComment("Juro Cobrado no Financiamento loja")
                .HasColumnName("jurofinanciamento");
            entity.Property(e => e.Juromes)
                .HasComment("Taxa Juro ao Mes")
                .HasColumnName("juromes");
            entity.Property(e => e.Maxparcela)
                .HasComment("numero maximo de parcelas para finarciamento pela loja")
                .HasColumnName("maxparcela");
            entity.Property(e => e.Validadesenha)
                .HasComment("Validade da senha em dias")
                .HasColumnName("validadesenha");
        });

        modelBuilder.Entity<TblCustoFinan>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_custo_finan_pkey");

            entity.ToTable("tbl_custo_finan");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('tbl_custo_dinheiro_codigo_seq'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Mes)
                .HasMaxLength(7)
                .HasColumnName("mes");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasComment("custo operacional ou custo dinheiro")
                .HasColumnName("tipo");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<TblDatasComemorativa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_datas_comemorativas");

            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Evento).HasColumnName("evento");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Imagem).HasColumnName("imagem");
            entity.Property(e => e.Mensagem).HasColumnName("mensagem");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<TblDepartamento>(entity =>
        {
            entity.HasKey(e => e.Coddepartamento).HasName("cp_codfabrica");

            entity.ToTable("tbl_departamento");

            entity.Property(e => e.Coddepartamento)
                .HasDefaultValueSql("nextval('seq_tblfabrica'::regclass)")
                .HasColumnName("coddepartamento");
            entity.Property(e => e.Ba)
                .HasDefaultValueSql("0")
                .HasComment("barbante")
                .HasColumnName("ba");
            entity.Property(e => e.Cartaz)
                .HasDefaultValueSql("0")
                .HasColumnName("cartaz");
            entity.Property(e => e.Coddivisao).HasColumnName("coddivisao");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Departamento)
                .HasMaxLength(30)
                .HasColumnName("departamento");
            entity.Property(e => e.Df)
                .HasDefaultValueSql("0")
                .HasComment("dupla face")
                .HasColumnName("df");
            entity.Property(e => e.Display)
                .HasDefaultValueSql("0")
                .HasColumnName("display");
            entity.Property(e => e.Du)
                .HasDefaultValueSql("0")
                .HasComment("durex")
                .HasColumnName("du");
            entity.Property(e => e.Imei)
                .HasDefaultValueSql("false")
                .HasColumnName("imei");
            entity.Property(e => e.Juropadrao).HasColumnName("juropadrao");
            entity.Property(e => e.Padraoetiqueta)
                .HasDefaultValueSql("0")
                .HasColumnName("padraoetiqueta");
            entity.Property(e => e.ParcCartao)
                .HasDefaultValueSql("10")
                .HasColumnName("parc_cartao");
            entity.Property(e => e.Quantideal)
                .HasDefaultValueSql("0")
                .HasColumnName("quantideal");
            entity.Property(e => e.Saco)
                .HasDefaultValueSql("0")
                .HasColumnName("saco");
            entity.Property(e => e.TaxaAvista)
                .HasDefaultValueSql("10")
                .HasColumnName("taxa_avista");
            entity.Property(e => e.Transferir)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("transferir");

            entity.HasOne(d => d.CoddivisaoNavigation).WithMany(p => p.TblDepartamentos)
                .HasForeignKey(d => d.Coddivisao)
                .HasConstraintName("fk_tbldivisao");
        });

        modelBuilder.Entity<TblDepartamentoTaxa>(entity =>
        {
            entity.HasKey(e => new { e.Coddep, e.QuantParc }).HasName("tbl_departamento_taxa_pkey");

            entity.ToTable("tbl_departamento_taxa");

            entity.Property(e => e.Coddep).HasColumnName("coddep");
            entity.Property(e => e.QuantParc).HasColumnName("quant_parc");
            entity.Property(e => e.Taxa)
                .HasPrecision(8, 4)
                .HasColumnName("taxa");
            entity.Property(e => e.TaxaCartao)
                .HasPrecision(8, 4)
                .HasColumnName("taxa_cartao");
            entity.Property(e => e.TaxaEc)
                .HasPrecision(8, 4)
                .HasDefaultValueSql("6")
                .HasColumnName("taxa_ec");
        });

        modelBuilder.Entity<TblDepartamentoUsuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_departamento_usuarios_pkey");

            entity.ToTable("tbl_departamento_usuarios");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("data");
            entity.Property(e => e.NomeDep)
                .HasMaxLength(50)
                .HasColumnName("nome_dep");
        });

        modelBuilder.Entity<TblDepositoSeraApagada31102019>(entity =>
        {
            entity.HasKey(e => e.Coddeposito).HasName("cp_tbldeposito");

            entity.ToTable("tbl_deposito_SERA_APAGADA_31-10-2019");

            entity.Property(e => e.Coddeposito)
                .HasDefaultValueSql("nextval('seq_tbldeposito'::regclass)")
                .HasComment("Codigo do Deposito")
                .HasColumnName("coddeposito");
            entity.Property(e => e.Areaocupada)
                .HasComment("Area Ocupada em m2\n")
                .HasColumnName("areaocupada");
            entity.Property(e => e.Bairro)
                .HasMaxLength(20)
                .HasComment("Bairro do Deposito")
                .HasColumnName("bairro");
            entity.Property(e => e.Cep)
                .HasMaxLength(15)
                .HasColumnName("cep");
            entity.Property(e => e.Cidade)
                .HasMaxLength(20)
                .HasColumnName("cidade");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(20)
                .HasColumnName("cnpj");
            entity.Property(e => e.Deposito)
                .HasMaxLength(50)
                .HasComment("Descrição do Deposito")
                .HasColumnName("deposito");
            entity.Property(e => e.Endereco)
                .HasMaxLength(50)
                .HasComment("Endereço de Localização do Deposito")
                .HasColumnName("endereco");
            entity.Property(e => e.Fone)
                .HasMaxLength(20)
                .HasColumnName("fone");
            entity.Property(e => e.ImpPreco)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasComment("Seleciona se imprime os cartazes de preço ou etiquetas.")
                .HasColumnName("imp_preco");
            entity.Property(e => e.Insc)
                .HasMaxLength(20)
                .HasColumnName("insc");
            entity.Property(e => e.Observacao).HasColumnName("observacao");
            entity.Property(e => e.Pessalocada)
                .HasComment("Quantidade de Pessoas Alocadas")
                .HasColumnName("pessalocada");
            entity.Property(e => e.Somarestoque)
                .HasMaxLength(1)
                .HasDefaultValueSql("'n'::bpchar")
                .HasComment("Somar produto ao estoque total")
                .HasColumnName("somarestoque");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
            entity.Property(e => e.Vlrarea)
                .HasComment("Valor da Area Ocupada")
                .HasColumnName("vlrarea");
            entity.Property(e => e.Vlrbens)
                .HasComment("Valor da Apreciação mensal dos bens\n")
                .HasColumnName("vlrbens");
            entity.Property(e => e.Vlrenergia)
                .HasComment("Valor da Energia Eletrica")
                .HasColumnName("vlrenergia");
            entity.Property(e => e.Vlrmaoobra)
                .HasComment("Valor da Mão de Obra")
                .HasColumnName("vlrmaoobra");
        });

        modelBuilder.Entity<TblDescricaoProduto>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_descricao_produto_pkey");

            entity.ToTable("tbl_descricao_produto");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tbldescricaoproduto'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .IsFixedLength()
                .HasColumnName("codproduto");
            entity.Property(e => e.Descricao)
                .HasMaxLength(30)
                .HasColumnName("descricao");

            entity.HasOne(d => d.CodprodutoNavigation).WithMany(p => p.TblDescricaoProdutos)
                .HasForeignKey(d => d.Codproduto)
                .HasConstraintName("tbl_descricao_produto_codproduto_fkey");
        });

        modelBuilder.Entity<TblDev>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_dev");

            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.DevFinalizado).HasColumnName("dev_finalizado");
            entity.Property(e => e.Finalizado)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("finalizado");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Numerochamado).HasColumnName("numerochamado");
            entity.Property(e => e.Prioridade).HasColumnName("prioridade");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Tempo).HasColumnName("tempo");
            entity.Property(e => e.Usuario)
                .HasColumnType("character varying")
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<TblDevWork>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_dev_work_pkey");

            entity.ToTable("tbl_dev_work", tb => tb.HasComment("tempo gasto por desenvolvedor num determinado chamado."));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.DataDev)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_dev");
            entity.Property(e => e.Numerochamado).HasColumnName("numerochamado");
            entity.Property(e => e.TempoDev).HasColumnName("tempo_dev");
        });

        modelBuilder.Entity<TblDivisao>(entity =>
        {
            entity.HasKey(e => e.Coddivisao).HasName("cp_coddivisao");

            entity.ToTable("tbl_divisao", tb => tb.HasComment("Codigo da Divisao"));

            entity.Property(e => e.Coddivisao)
                .HasDefaultValueSql("nextval('seq_tbldivisao'::regclass)")
                .HasComment("Codigo da Divisao")
                .HasColumnName("coddivisao");
            entity.Property(e => e.Areaocupada)
                .HasComment("Area Ocupada")
                .HasColumnName("areaocupada");
            entity.Property(e => e.Codusuario)
                .HasComment("Codigo do usuario que cadastrou ou atualizou a divisao")
                .HasColumnName("codusuario");
            entity.Property(e => e.Divisao)
                .HasMaxLength(25)
                .HasComment("Divisao do Estoque")
                .HasColumnName("divisao");
            entity.Property(e => e.Iddivisao)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("iddivisao");
            entity.Property(e => e.Listar)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("listar");
            entity.Property(e => e.Pessoasaloca)
                .HasComment("Quantidade de Pessoas Alocadas")
                .HasColumnName("pessoasaloca");
            entity.Property(e => e.Poteletrico)
                .HasComment("Potencial Eletrico")
                .HasColumnName("poteletrico");
            entity.Property(e => e.Quantdeparta)
                .HasComment("Quantidade de Departamentos\n")
                .HasColumnName("quantdeparta");
            entity.Property(e => e.Ultaltera)
                .HasComment("Data e hora da Ultima Atualização")
                .HasColumnName("ultaltera");
            entity.Property(e => e.Valor)
                .HasPrecision(15, 2)
                .HasComment("Campo para teste")
                .HasColumnName("valor");
            entity.Property(e => e.Valorarea)
                .HasComment("Valor da Area Ocupada")
                .HasColumnName("valorarea");
            entity.Property(e => e.Valorbens)
                .HasComment("Valor da Apreciação dos Bens")
                .HasColumnName("valorbens");
            entity.Property(e => e.Valormaoobra)
                .HasComment("Valor da Mão de Obra")
                .HasColumnName("valormaoobra");
        });

        modelBuilder.Entity<TblDivisaoGasto>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_divisao_gasto_pkey");

            entity.ToTable("tbl_divisao_gasto");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Ativo)
                .HasDefaultValueSql("1")
                .HasColumnName("ativo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(40)
                .HasColumnName("descricao");
            entity.Property(e => e.Divisao)
                .HasComment("1 = Operacional\n2 = Estoque\n3 = Investimento")
                .HasColumnName("divisao");
        });

        modelBuilder.Entity<TblDivisaoGastoPrinc>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_divisao_gasto_princ_pkey");

            entity.ToTable("tbl_divisao_gasto_princ", tb => tb.HasComment("divisao de gasto principal"));

            entity.Property(e => e.Codigo)
                .ValueGeneratedNever()
                .HasColumnName("codigo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(30)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<TblDivisaoGastoSub>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_divisao_gasto_sub_pkey");

            entity.ToTable("tbl_divisao_gasto_sub");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Coddivisao).HasColumnName("coddivisao");
            entity.Property(e => e.Descricao)
                .HasMaxLength(40)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<TblEcf>(entity =>
        {
            entity.HasKey(e => e.Codfabrica).HasName("tbl_ecf_pkey");

            entity.ToTable("tbl_ecf");

            entity.Property(e => e.Codfabrica)
                .ValueGeneratedNever()
                .HasColumnName("codfabrica");
            entity.Property(e => e.Ecf).HasColumnName("ecf");
            entity.Property(e => e.Loja).HasColumnName("loja");
            entity.Property(e => e.SerieEcf)
                .HasMaxLength(21)
                .HasColumnName("serie_ecf");
            entity.Property(e => e.SerieMfd)
                .HasMaxLength(35)
                .HasColumnName("serie_mfd");
        });

        modelBuilder.Entity<TblEmailAssist>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_email_assist_pkey");

            entity.ToTable("tbl_email_assist");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codfornecedor).HasColumnName("codfornecedor");
            entity.Property(e => e.Contato)
                .HasMaxLength(50)
                .HasColumnName("contato");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
        });

        modelBuilder.Entity<TblEmailEnviado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_email_enviado_pkey");

            entity.ToTable("tbl_email_enviado");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Erro)
                .HasMaxLength(100)
                .HasColumnName("erro");
            entity.Property(e => e.Pedido)
                .HasColumnType("character varying")
                .HasColumnName("pedido");
            entity.Property(e => e.Transportadora)
                .HasColumnType("character varying")
                .HasColumnName("transportadora");
            entity.Property(e => e.Usuario)
                .HasMaxLength(30)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<TblEmissaoFiscal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_emissao_fiscal_pkey");

            entity.ToTable("tbl_emissao_fiscal");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasColumnName("tipo");
            entity.Property(e => e.Valor)
                .HasPrecision(12, 2)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<TblEnvioCupomFiscal>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_envio_old_pkey");

            entity.ToTable("tbl_envio_cupom_fiscal");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblenviacupomfiscal'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Arquivo)
                .HasMaxLength(50)
                .HasColumnName("arquivo");
            entity.Property(e => e.Codempresa).HasColumnName("codempresa");
            entity.Property(e => e.Codfabrica).HasColumnName("codfabrica");
            entity.Property(e => e.Codstatus).HasColumnName("codstatus");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Conteudo).HasColumnName("conteudo");
            entity.Property(e => e.Dataarquivo).HasColumnName("dataarquivo");
            entity.Property(e => e.Dataenvio)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataenvio");
            entity.Property(e => e.Ecf).HasColumnName("ecf");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.Protocolo)
                .HasMaxLength(50)
                .HasColumnName("protocolo");
            entity.Property(e => e.Remetente)
                .HasMaxLength(50)
                .HasColumnName("remetente");
            entity.Property(e => e.Status)
                .HasMaxLength(70)
                .HasColumnName("status");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TblEnvioProdutoLogistica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_envio_produto_logistica_pkey");

            entity.ToTable("tbl_envio_produto_logistica");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodProduto)
                .HasMaxLength(20)
                .HasColumnName("cod_produto");
            entity.Property(e => e.CodUsuarioEnvio).HasColumnName("cod_usuario_envio");
            entity.Property(e => e.DataEnvio).HasColumnName("data_envio");
            entity.Property(e => e.Empresa).HasColumnName("empresa");
            entity.Property(e => e.Entrou).HasColumnName("entrou");
            entity.Property(e => e.Retorno)
                .HasMaxLength(500)
                .HasColumnName("retorno");
        });

        modelBuilder.Entity<TblErro>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_erro");

            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Erro).HasColumnName("erro");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('seq_tblbairro'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Usuario)
                .HasMaxLength(40)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<TblErroParcela>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_erro_parcela_pkey");

            entity.ToTable("tbl_erro_parcela");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codigoparcela).HasColumnName("codigoparcela");
            entity.Property(e => e.Codprepedido).HasColumnName("codprepedido");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Usuario)
                .HasMaxLength(40)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<TblEspelhoParcelasPrazo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_espelho_parcelas_prazo");

            entity.Property(e => e.Baixaparcial)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("baixaparcial");
            entity.Property(e => e.Caixa)
                .HasMaxLength(1)
                .HasColumnName("caixa");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("cancelado");
            entity.Property(e => e.Chequepre).HasColumnName("chequepre");
            entity.Property(e => e.Classe)
                .HasMaxLength(1)
                .HasColumnName("classe");
            entity.Property(e => e.ClasseAlterada)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("classe_alterada");
            entity.Property(e => e.CodReneg).HasColumnName("cod_reneg");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codfinanceira).HasColumnName("codfinanceira");
            entity.Property(e => e.Codigo)
                .ValueGeneratedOnAdd()
                .HasColumnName("codigo");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codlojapedido)
                .HasDefaultValueSql("0")
                .HasColumnName("codlojapedido");
            entity.Property(e => e.Codpagamento)
                .HasMaxLength(35)
                .HasColumnName("codpagamento");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(11)
                .HasColumnName("codpedido");
            entity.Property(e => e.Codprepedido)
                .HasDefaultValueSql("0")
                .HasColumnName("codprepedido");
            entity.Property(e => e.Codusuario)
                .HasDefaultValueSql("0")
                .HasColumnName("codusuario");
            entity.Property(e => e.ConfCartao)
                .HasDefaultValueSql("false")
                .HasColumnName("conf_cartao");
            entity.Property(e => e.Contratofinan)
                .HasMaxLength(15)
                .HasColumnName("contratofinan");
            entity.Property(e => e.Datapedido).HasColumnName("datapedido");
            entity.Property(e => e.Datapgto)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datapgto");
            entity.Property(e => e.Descautorizado)
                .HasMaxLength(35)
                .HasColumnName("descautorizado");
            entity.Property(e => e.Desconto)
                .HasPrecision(9, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("desconto");
            entity.Property(e => e.Diasatraso)
                .HasDefaultValueSql("0")
                .HasColumnName("diasatraso");
            entity.Property(e => e.Documento)
                .HasMaxLength(15)
                .HasColumnName("documento");
            entity.Property(e => e.Estornada)
                .HasMaxLength(65)
                .HasColumnName("estornada");
            entity.Property(e => e.Forma)
                .HasMaxLength(20)
                .HasColumnName("forma");
            entity.Property(e => e.IdMetodoPgto).HasColumnName("id_metodo_pgto");
            entity.Property(e => e.Idcaixa).HasColumnName("idcaixa");
            entity.Property(e => e.Inclusaospc)
                .HasMaxLength(12)
                .HasColumnName("inclusaospc");
            entity.Property(e => e.Jurodia)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("jurodia");
            entity.Property(e => e.MetodoPgto)
                .HasMaxLength(20)
                .HasColumnName("metodo_pgto");
            entity.Property(e => e.Motdesc).HasColumnName("motdesc");
            entity.Property(e => e.Motdescger).HasColumnName("motdescger");
            entity.Property(e => e.Motivoestorno)
                .HasMaxLength(100)
                .HasColumnName("motivoestorno");
            entity.Property(e => e.Pago)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("pago");
            entity.Property(e => e.Pagoparcial)
                .HasMaxLength(20)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("pagoparcial");
            entity.Property(e => e.Parcela).HasColumnName("parcela");
            entity.Property(e => e.Pgtocheque)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("pgtocheque");
            entity.Property(e => e.Quantparcela).HasColumnName("quantparcela");
            entity.Property(e => e.Tipoparcela)
                .HasMaxLength(1)
                .HasDefaultValueSql("'I'::bpchar")
                .HasColumnName("tipoparcela");
            entity.Property(e => e.Tipovenda)
                .HasDefaultValueSql("2")
                .HasColumnName("tipovenda");
            entity.Property(e => e.Valor)
                .HasPrecision(9, 2)
                .HasColumnName("valor");
            entity.Property(e => e.Valorjuro)
                .HasPrecision(8, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("valorjuro");
            entity.Property(e => e.Valorpagar)
                .HasPrecision(9, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("valorpagar");
            entity.Property(e => e.Valorpago)
                .HasPrecision(9, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("valorpago");
            entity.Property(e => e.Vencimento).HasColumnName("vencimento");
        });

        modelBuilder.Entity<TblEtiquetaIdent>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_etiquete_ident_pkey");

            entity.ToTable("tbl_etiqueta_ident", tb => tb.HasComment("Etiquete de identificação do produto com codigo de barra"));

            entity.HasIndex(e => new { e.Codproduto, e.Idetiqueta }, "tbl_etiqueta_ident_codproduto_idetiqueta_key").IsUnique();

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tbletiquetaident'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .IsFixedLength()
                .HasComment("Codigo do produto")
                .HasColumnName("codproduto");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Idetiqueta).HasColumnName("idetiqueta");
            entity.Property(e => e.Impresso)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("impresso");
            entity.Property(e => e.Sigla)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("sigla");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasDefaultValueSql("\"current_user\"()")
                .HasColumnName("usuario");
            entity.Property(e => e.Volume).HasColumnName("volume");

            entity.HasOne(d => d.CodlojaNavigation).WithMany(p => p.TblEtiquetaIdents)
                .HasForeignKey(d => d.Codloja)
                .HasConstraintName("tbl_etiquete_ident_codloja_fkey");

            entity.HasOne(d => d.CodprodutoNavigation).WithMany(p => p.TblEtiquetaIdents)
                .HasForeignKey(d => d.Codproduto)
                .HasConstraintName("tbl_etiquete_ident_codproduto_fkey");
        });

        modelBuilder.Entity<TblEtiquetaPreco>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_etiquete_preco_pkey");

            entity.ToTable("tbl_etiqueta_preco");

            entity.HasIndex(e => e.Codloja, "index_tbletiquetapreco_codloja");

            entity.HasIndex(e => e.Dataimpre, "index_tbletiquetapreco_data");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tbletiquetapeco'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Avista)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("avista");
            entity.Property(e => e.Codloja)
                .HasComment("Codigo da loja que sera imprssa a etiqueta")
                .HasColumnName("codloja");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .IsFixedLength()
                .HasComment("Codigo do produto")
                .HasColumnName("codproduto");
            entity.Property(e => e.Dataimpre)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataimpre");
            entity.Property(e => e.Juro)
                .HasMaxLength(8)
                .HasColumnName("juro");
            entity.Property(e => e.Parcelas)
                .HasDefaultValueSql("0")
                .HasColumnName("parcelas");
            entity.Property(e => e.Valorparcela)
                .HasPrecision(12, 2)
                .HasColumnName("valorparcela");

            entity.HasOne(d => d.CodlojaNavigation).WithMany(p => p.TblEtiquetaPrecos)
                .HasForeignKey(d => d.Codloja)
                .HasConstraintName("tbl_etiqueta_preco_codloja_fkey");

            entity.HasOne(d => d.CodprodutoNavigation).WithMany(p => p.TblEtiquetaPrecos)
                .HasForeignKey(d => d.Codproduto)
                .HasConstraintName("tbl_etiquete_preco_codproduto_fkey");
        });

        modelBuilder.Entity<TblExtratoBancarioConta>(entity =>
        {
            entity.HasKey(e => new { e.IdBanco, e.Conta }).HasName("tbl_extrato_bancario_contas_pkey");

            entity.ToTable("tbl_extrato_bancario_contas");

            entity.Property(e => e.IdBanco).HasColumnName("id_banco");
            entity.Property(e => e.Conta)
                .HasMaxLength(30)
                .HasColumnName("conta");
            entity.Property(e => e.Descricao)
                .HasMaxLength(60)
                .HasColumnName("descricao");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<TblExtratoBancarioMov>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_extrato_bancario_mov_pkey");

            entity.ToTable("tbl_extrato_bancario_mov");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data)
                .HasComment("DTPOSTED")
                .HasColumnName("data");
            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .HasComment("MEMO")
                .HasColumnName("descricao");
            entity.Property(e => e.Documento)
                .HasMaxLength(40)
                .HasComment("FITID")
                .HasColumnName("documento");
            entity.Property(e => e.IdBanco).HasColumnName("idBanco");
            entity.Property(e => e.Numero)
                .HasMaxLength(40)
                .HasComment("CHECKNUM")
                .HasColumnName("numero");
            entity.Property(e => e.Tipo)
                .HasMaxLength(6)
                .HasComment("TRNTYPE")
                .HasColumnName("tipo");
            entity.Property(e => e.Valor)
                .HasPrecision(12, 2)
                .HasComment("TRNAMT")
                .HasColumnName("valor");
        });

        modelBuilder.Entity<TblFeriado>(entity =>
        {
            entity.HasKey(e => e.Data).HasName("tbl_feriado_pkey");

            entity.ToTable("tbl_feriado");

            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Descricao)
                .HasMaxLength(30)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<TblFinanceira>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_financeira_pkey");

            entity.ToTable("tbl_financeira");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Financeira)
                .HasMaxLength(50)
                .HasColumnName("financeira");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasComment("tipo convenio ou financeira")
                .HasColumnName("tipo");
            entity.Property(e => e.User)
                .HasMaxLength(35)
                .HasDefaultValueSql("\"current_user\"()")
                .HasColumnName("user");
        });

        modelBuilder.Entity<TblFiscalSincConf>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_fiscal_sinc_conf_pkey");

            entity.ToTable("tbl_fiscal_sinc_conf");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChaveAcesso)
                .HasMaxLength(44)
                .HasColumnName("chave_acesso");
            entity.Property(e => e.Codpedidocompra).HasColumnName("codpedidocompra");
            entity.Property(e => e.Comentario)
                .HasMaxLength(500)
                .HasColumnName("comentario");
            entity.Property(e => e.ConferenciaFinanceiro)
                .HasDefaultValueSql("false")
                .HasColumnName("conferencia_financeiro");
            entity.Property(e => e.ConferenciaSintegra)
                .HasDefaultValueSql("false")
                .HasColumnName("conferencia_sintegra");
            entity.Property(e => e.ConferenciaTributacao)
                .HasDefaultValueSql("false")
                .HasColumnName("conferencia_tributacao");
            entity.Property(e => e.Danfe).HasColumnName("danfe");
            entity.Property(e => e.DataEmissaoDanfe)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_emissao_danfe");
            entity.Property(e => e.DataFin).HasColumnName("data_fin");
            entity.Property(e => e.DataPrimeiraConf)
                .HasDefaultValueSql("now()")
                .HasColumnName("data_primeira_conf");
            entity.Property(e => e.DataSint).HasColumnName("data_sint");
            entity.Property(e => e.DataTrib).HasColumnName("data_trib");
            entity.Property(e => e.StatusConferencia)
                .HasMaxLength(1)
                .HasDefaultValueSql("'n'::bpchar")
                .HasColumnName("status_conferencia");
            entity.Property(e => e.UsuarioFinanceiro)
                .HasMaxLength(50)
                .HasColumnName("usuario_financeiro");
            entity.Property(e => e.UsuarioSintegra)
                .HasMaxLength(50)
                .HasColumnName("usuario_sintegra");
            entity.Property(e => e.UsuarioTributacao)
                .HasMaxLength(50)
                .HasColumnName("usuario_tributacao");
        });

        modelBuilder.Entity<TblFluxo1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_fluxo1");

            entity.Property(e => e.Chepre).HasColumnName("CHEPRE");
            entity.Property(e => e.Data).HasColumnName("DATA");
            entity.Property(e => e.Estorn).HasColumnName("ESTORN");
            entity.Property(e => e.Recebi).HasColumnName("RECEBI");
            entity.Property(e => e.Total).HasColumnName("TOTAL");
            entity.Property(e => e.Vendas).HasColumnName("VENDAS");
        });

        modelBuilder.Entity<TblFolgaVeiculo>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_folga_veiculo_pkey");

            entity.ToTable("tbl_folga_veiculo");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("ativo");
            entity.Property(e => e.Atualizado)
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("atualizado");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Diasemana)
                .HasMaxLength(15)
                .HasColumnName("diasemana");
        });

        modelBuilder.Entity<TblFormulario>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cp_tblformularios");

            entity.ToTable("tbl_formularios");

            entity.HasIndex(e => e.FormularioExcluir, "indx_formulario").IsUnique();

            entity.HasIndex(e => e.Frm, "tbl_formularios_frm_key").IsUnique();

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblformularios'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Bloqueio)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("bloqueio");
            entity.Property(e => e.ContadorAbertura).HasColumnName("contador_abertura");
            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .HasColumnName("descricao");
            entity.Property(e => e.FormularioExcluir)
                .HasMaxLength(30)
                .HasColumnName("formulario_excluir");
            entity.Property(e => e.Frm)
                .HasMaxLength(150)
                .HasColumnName("frm");
            entity.Property(e => e.UltimoAcesso)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("ultimo_acesso");
        });

        modelBuilder.Entity<TblFormularioDono>(entity =>
        {
            entity.HasKey(e => new { e.Codformulario, e.Codusuario }).HasName("tbl_formulario_dono_pkey");

            entity.ToTable("tbl_formulario_dono");

            entity.Property(e => e.Codformulario).HasColumnName("codformulario");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
        });

        modelBuilder.Entity<TblForneContaDominio>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_forne_conta_dominio_pkey");

            entity.ToTable("tbl_forne_conta_dominio");

            entity.Property(e => e.Codigo)
                .ValueGeneratedNever()
                .HasColumnName("codigo");
            entity.Property(e => e.ClassificacaoContabil)
                .HasDefaultValueSql("false")
                .HasColumnType("character varying")
                .HasColumnName("classificacao_contabil");
            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<TblForneassist>(entity =>
        {
            entity.HasKey(e => e.Codfornecedor).HasName("tbl_forneassist_pkey");

            entity.ToTable("tbl_forneassist");

            entity.Property(e => e.Codfornecedor).HasColumnName("codfornecedor");
            entity.Property(e => e.Ativo).HasColumnName("ativo");
            entity.Property(e => e.Atualizado).HasColumnName("atualizado");
            entity.Property(e => e.Autorizada).HasColumnName("autorizada");
            entity.Property(e => e.Bairro)
                .HasMaxLength(50)
                .HasColumnName("bairro");
            entity.Property(e => e.Cep)
                .HasMaxLength(15)
                .HasColumnName("cep");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(22)
                .HasColumnName("cnpj");
            entity.Property(e => e.Codusuario)
                .HasPrecision(19)
                .HasColumnName("codusuario");
            entity.Property(e => e.Contato).HasColumnName("contato");
            entity.Property(e => e.Datacadastro).HasColumnName("datacadastro");
            entity.Property(e => e.Endereco)
                .HasMaxLength(50)
                .HasColumnName("endereco");
            entity.Property(e => e.Fax)
                .HasMaxLength(15)
                .HasColumnName("fax");
            entity.Property(e => e.Fone)
                .HasMaxLength(50)
                .HasColumnName("fone");
            entity.Property(e => e.Inscest)
                .HasMaxLength(22)
                .HasColumnName("inscest");
            entity.Property(e => e.Inscmunic)
                .HasMaxLength(18)
                .HasColumnName("inscmunic");
            entity.Property(e => e.Municipio)
                .HasMaxLength(40)
                .HasColumnName("municipio");
            entity.Property(e => e.Nomefantasia)
                .HasMaxLength(50)
                .HasColumnName("nomefantasia");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.Pais)
                .HasMaxLength(20)
                .HasColumnName("pais");
            entity.Property(e => e.Razaosocial)
                .HasMaxLength(50)
                .HasColumnName("razaosocial");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
        });

        modelBuilder.Entity<TblFornecedor>(entity =>
        {
            entity.HasKey(e => e.Codfornecedor).HasName("cp_tblfornecedor");

            entity.ToTable("tbl_fornecedor");

            entity.Property(e => e.Codfornecedor)
                .HasDefaultValueSql("nextval('seq_tblfornecedor'::regclass)")
                .HasColumnName("codfornecedor");
            entity.Property(e => e.Agencia)
                .HasMaxLength(20)
                .HasComment("Nome da Agencia Bancaria")
                .HasColumnName("agencia");
            entity.Property(e => e.Agencia1)
                .HasMaxLength(25)
                .HasComment("Nome do Banco")
                .HasColumnName("agencia_1");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("ativo");
            entity.Property(e => e.Atualizado)
                .HasComment("Data Atualização")
                .HasColumnName("atualizado");
            entity.Property(e => e.Bairro)
                .HasMaxLength(60)
                .HasColumnName("bairro");
            entity.Property(e => e.Cep)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("cep");
            entity.Property(e => e.Cnae)
                .HasMaxLength(10)
                .HasColumnName("cnae");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(19)
                .HasColumnName("cnpj");
            entity.Property(e => e.CodContaDominio).HasColumnName("cod_conta_dominio");
            entity.Property(e => e.Codmunicipio).HasColumnName("codmunicipio");
            entity.Property(e => e.Codpais).HasColumnName("codpais");
            entity.Property(e => e.Codusuario)
                .HasComment("Codigo do Usuario")
                .HasColumnName("codusuario");
            entity.Property(e => e.Complemento)
                .HasMaxLength(60)
                .HasColumnName("complemento");
            entity.Property(e => e.Contato)
                .HasMaxLength(20)
                .HasComment("Pessoa de Contato")
                .HasColumnName("contato");
            entity.Property(e => e.Crt)
                .HasMaxLength(1)
                .HasColumnName("crt");
            entity.Property(e => e.Datacadastro)
                .HasComment("Data do Cadastro")
                .HasColumnName("datacadastro");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .HasColumnName("email");
            entity.Property(e => e.EmitIeSt).HasColumnName("emitIeSt");
            entity.Property(e => e.Endereco)
                .HasMaxLength(60)
                .HasComment("Endereço")
                .HasColumnName("endereco");
            entity.Property(e => e.Endnumero)
                .HasMaxLength(60)
                .HasColumnName("endnumero");
            entity.Property(e => e.Fax)
                .HasMaxLength(60)
                .HasComment("Numero do Fax")
                .HasColumnName("fax");
            entity.Property(e => e.Fone)
                .HasMaxLength(35)
                .HasColumnName("fone");
            entity.Property(e => e.Fornecedor)
                .HasMaxLength(60)
                .HasComment("Razao Social da Empresa")
                .HasColumnName("fornecedor");
            entity.Property(e => e.Idgrupo)
                .HasDefaultValueSql("0")
                .HasColumnName("idgrupo");
            entity.Property(e => e.Inscest)
                .HasMaxLength(18)
                .HasComment("Inscrição Estadual")
                .HasColumnName("inscest");
            entity.Property(e => e.Inscmunic)
                .HasMaxLength(18)
                .HasComment("Inscrição Municipal")
                .HasColumnName("inscmunic");
            entity.Property(e => e.Municipio)
                .HasMaxLength(60)
                .HasColumnName("municipio");
            entity.Property(e => e.Nagencia)
                .HasMaxLength(15)
                .HasComment("Numero da Agencia")
                .HasColumnName("nagencia");
            entity.Property(e => e.Nagencia1)
                .HasMaxLength(25)
                .HasComment("Numero da Agencia")
                .HasColumnName("nagencia_1");
            entity.Property(e => e.Nbanco)
                .HasMaxLength(5)
                .HasComment("Numero do Banco")
                .HasColumnName("nbanco");
            entity.Property(e => e.Nbanco1)
                .HasMaxLength(5)
                .HasComment("Numero do Banco")
                .HasColumnName("nbanco_1");
            entity.Property(e => e.Nconta)
                .HasMaxLength(15)
                .HasComment("Numero da Conta ")
                .HasColumnName("nconta");
            entity.Property(e => e.Nconta1)
                .HasMaxLength(15)
                .HasComment("Numero da Conta Bancaria")
                .HasColumnName("nconta_1");
            entity.Property(e => e.Nomefantasia)
                .HasMaxLength(60)
                .HasComment("Nome Fantasia da Empresa")
                .HasColumnName("nomefantasia");
            entity.Property(e => e.Obs)
                .HasComment("Observações Complementares")
                .HasColumnName("obs");
            entity.Property(e => e.Pais)
                .HasMaxLength(60)
                .HasColumnName("pais");
            entity.Property(e => e.Site)
                .HasMaxLength(60)
                .HasComment("Home Page da Empresa")
                .HasColumnName("site");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("uf");

            entity.HasOne(d => d.CodusuarioNavigation).WithMany(p => p.TblFornecedors)
                .HasForeignKey(d => d.Codusuario)
                .HasConstraintName("fk_usuario");
        });

        modelBuilder.Entity<TblFornecedorEmailLog>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_fornecedor_email_log_pkey");

            entity.ToTable("tbl_fornecedor_email_log", tb => tb.HasComment("tabela com os registros de envio de email para fornecedores"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Fornecedor)
                .HasMaxLength(50)
                .HasColumnName("fornecedor");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.Pedido)
                .HasMaxLength(30)
                .HasColumnName("pedido");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TblFornecedorGrupo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_fornecedor_grupo_pkey");

            entity.ToTable("tbl_fornecedor_grupo");

            entity.HasIndex(e => e.Grupo, "tbl_fornecedor_grupo_grupo_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Grupo)
                .HasMaxLength(100)
                .HasColumnName("grupo");
        });

        modelBuilder.Entity<TblFuncao>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_funcao_pkey");

            entity.ToTable("tbl_funcao");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Funcao)
                .HasMaxLength(35)
                .HasColumnName("funcao");
        });

        modelBuilder.Entity<TblGastoveiculo>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_gastoveiculos_pkey");

            entity.ToTable("tbl_gastoveiculos");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codveiculo).HasColumnName("codveiculo");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Km).HasColumnName("km");
            entity.Property(e => e.Quantidade).HasColumnName("quantidade");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<TblGeraPromissorium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_gera_promissoria");

            entity.Property(e => e.Avdata).HasColumnName("avdata");
            entity.Property(e => e.Codavalista).HasColumnName("codavalista");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Ncontrato).HasColumnName("ncontrato");
            entity.Property(e => e.Printervalo).HasColumnName("printervalo");
            entity.Property(e => e.Prqtdparcela).HasColumnName("prqtdparcela");
            entity.Property(e => e.Prvalorparcela)
                .HasMaxLength(15)
                .HasColumnName("prvalorparcela");
            entity.Property(e => e.Prvencimento).HasColumnName("prvencimento");
            entity.Property(e => e.Tipoav)
                .HasColumnType("char")
                .HasColumnName("tipoav");
            entity.Property(e => e.Usuario)
                .HasMaxLength(120)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<TblGeraRomaneio>(entity =>
        {
            entity.HasKey(e => e.Codromaneio).HasName("tbl_gera_romaneio_pkey");

            entity.ToTable("tbl_gera_romaneio");

            entity.Property(e => e.Codromaneio)
                .HasDefaultValueSql("nextval('seq_tblgeraromaneio'::regclass)")
                .HasColumnName("codromaneio");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .HasColumnName("documento");
            entity.Property(e => e.EntregaAssist)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("entrega_assist");
            entity.Property(e => e.Tipo)
                .HasMaxLength(25)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TblHelp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_help_pkey");

            entity.ToTable("tbl_help");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Caminho)
                .HasMaxLength(500)
                .HasColumnName("caminho");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Descricao)
                .HasMaxLength(300)
                .HasColumnName("descricao");
            entity.Property(e => e.Formulario)
                .HasMaxLength(100)
                .HasColumnName("formulario");
            entity.Property(e => e.Login)
                .HasMaxLength(30)
                .HasColumnName("login");
        });

        modelBuilder.Entity<TblHistoricoPedidosEcommerce>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_historico_pedidos_ecommerce_pkey");

            entity.ToTable("tbl_historico_pedidos_ecommerce");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Coddepartamento).HasColumnName("coddepartamento");
            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(15)
                .HasColumnName("codpedido");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.DataComentario)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("data_comentario");
            entity.Property(e => e.Obs).HasColumnName("obs");
        });

        modelBuilder.Entity<TblHistoricoassist>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_historicoassist_pkey");

            entity.ToTable("tbl_historicoassist");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codassistencia).HasColumnName("codassistencia");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Informante)
                .HasMaxLength(50)
                .HasColumnName("informante");
            entity.Property(e => e.Situacao).HasColumnName("situacao");
            entity.Property(e => e.Telefone)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("telefone");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'A'::bpchar")
                .HasComment("tipo 'C' Cliente ou 'A' Assistencia")
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TblHistoricoreneg>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_historicoreneg_pkey");

            entity.ToTable("tbl_historicoreneg");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");

            entity.HasOne(d => d.CodclienteNavigation).WithMany(p => p.TblHistoricorenegs)
                .HasForeignKey(d => d.Codcliente)
                .HasConstraintName("tbl_historicoreneg_codcliente_fkey");

            entity.HasOne(d => d.CodusuarioNavigation).WithMany(p => p.TblHistoricorenegs)
                .HasForeignKey(d => d.Codusuario)
                .HasConstraintName("tbl_historicoreneg_codusuario_fkey");
        });

        modelBuilder.Entity<TblHistoricospc>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_historicospc_pkey");

            entity.ToTable("tbl_historicospc");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codigospc)
                .HasMaxLength(25)
                .HasColumnName("codigospc");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasComment("se entrou ou saiu do SPC")
                .HasColumnName("tipo");
            entity.Property(e => e.TitularConjuge)
                .HasMaxLength(1)
                .HasDefaultValueSql("'T'::bpchar")
                .HasColumnName("titular_conjuge");
            entity.Property(e => e.Valor)
                .HasPrecision(12, 2)
                .HasColumnName("valor");

            entity.HasOne(d => d.CodclienteNavigation).WithMany(p => p.TblHistoricospcs)
                .HasForeignKey(d => d.Codcliente)
                .HasConstraintName("tbl_historicospc_codcliente_fkey");

            entity.HasOne(d => d.CodusuarioNavigation).WithMany(p => p.TblHistoricospcs)
                .HasForeignKey(d => d.Codusuario)
                .HasConstraintName("tbl_historicospc_codusuario_fkey");
        });

        modelBuilder.Entity<TblHistprotesto>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_histprotesto_pkey");

            entity.ToTable("tbl_histprotesto");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codigoprotesto)
                .HasMaxLength(25)
                .HasColumnName("codigoprotesto");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasComment("se entrou ou saiu do SPC")
                .HasColumnName("tipo");
            entity.Property(e => e.Valor)
                .HasPrecision(12, 2)
                .HasColumnName("valor");

            entity.HasOne(d => d.CodclienteNavigation).WithMany(p => p.TblHistprotestos)
                .HasForeignKey(d => d.Codcliente)
                .HasConstraintName("tbl_histprotesto_codcliente_fkey");

            entity.HasOne(d => d.CodusuarioNavigation).WithMany(p => p.TblHistprotestos)
                .HasForeignKey(d => d.Codusuario)
                .HasConstraintName("tbl_histprotesto_codusuario_fkey");
        });

        modelBuilder.Entity<TblHistvencimento>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_histvencimento_pkey");

            entity.ToTable("tbl_histvencimento");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(14)
                .HasColumnName("codpedido");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Dataanterior).HasColumnName("dataanterior");
            entity.Property(e => e.Dataatual).HasColumnName("dataatual");
            entity.Property(e => e.Valor)
                .HasPrecision(12, 2)
                .HasColumnName("valor");

            entity.HasOne(d => d.CodclienteNavigation).WithMany(p => p.TblHistvencimentos)
                .HasForeignKey(d => d.Codcliente)
                .HasConstraintName("tbl_histvencimento_codcliente_fkey");
        });

        modelBuilder.Entity<TblHost>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_host_pkey");

            entity.ToTable("tbl_host");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Acessou)
                .HasMaxLength(20)
                .HasColumnName("acessou");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Ip)
                .HasMaxLength(16)
                .HasColumnName("ip");
            entity.Property(e => e.Mac)
                .HasMaxLength(16)
                .HasColumnName("mac");
            entity.Property(e => e.Nome)
                .HasMaxLength(30)
                .HasColumnName("nome");
            entity.Property(e => e.Usuario).HasColumnName("usuario");
            entity.Property(e => e.Versao)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("versao");
        });

        modelBuilder.Entity<TblIbptax>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_ibptax_pkey");

            entity.ToTable("tbl_ibptax");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .HasComment("NCM")
                .HasColumnName("codigo");
            entity.Property(e => e.AliqEstadual)
                .HasPrecision(5, 2)
                .HasColumnName("aliq_estadual");
            entity.Property(e => e.AliqMunicipal)
                .HasPrecision(5, 2)
                .HasColumnName("aliq_municipal");
            entity.Property(e => e.Aliqimp)
                .HasPrecision(5, 2)
                .HasColumnName("aliqimp");
            entity.Property(e => e.Aliqnac)
                .HasPrecision(5, 2)
                .HasColumnName("aliqnac");
            entity.Property(e => e.Chave)
                .HasMaxLength(50)
                .HasColumnName("chave");
            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .HasColumnName("descricao");
            entity.Property(e => e.Ex).HasColumnName("ex");
            entity.Property(e => e.Fonte)
                .HasMaxLength(100)
                .HasColumnName("fonte");
            entity.Property(e => e.Tabela)
                .HasMaxLength(1)
                .HasColumnName("tabela");
            entity.Property(e => e.Versao)
                .HasMaxLength(10)
                .HasColumnName("versao");
            entity.Property(e => e.Vigenciafim).HasColumnName("vigenciafim");
            entity.Property(e => e.Vigenciainicio).HasColumnName("vigenciainicio");
        });

        modelBuilder.Entity<TblImei>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_imei_pkey");

            entity.ToTable("tbl_imei");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codigodebarra).HasColumnName("codigodebarra");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(13)
                .HasColumnName("codproduto");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Datarecebido).HasColumnName("datarecebido");
            entity.Property(e => e.Datatransf).HasColumnName("datatransf");
            entity.Property(e => e.Identificatr).HasColumnName("identificatr");
            entity.Property(e => e.Imei)
                .HasMaxLength(100)
                .HasColumnName("imei");
            entity.Property(e => e.Imei2)
                .HasMaxLength(100)
                .HasColumnName("imei2");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.Transferidopara).HasColumnName("transferidopara");
            entity.Property(e => e.Userrecebido).HasColumnName("userrecebido");
            entity.Property(e => e.Usertransf).HasColumnName("usertransf");
            entity.Property(e => e.Utilizado).HasColumnName("utilizado");
        });

        modelBuilder.Entity<TblImpCarneQuitado>(entity =>
        {
            entity.HasKey(e => new { e.Codcliente, e.Data }).HasName("tbl_imp_carne_quitado_pkey");

            entity.ToTable("tbl_imp_carne_quitado");

            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Caixa)
                .HasMaxLength(45)
                .HasColumnName("caixa");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
        });

        modelBuilder.Entity<TblImpcartum>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_impcarta_pkey");

            entity.ToTable("tbl_impcarta", tb => tb.HasComment("impressao de carta de cobrança"));

            entity.HasIndex(e => e.Codcliente, "index_tbl_impcarta_codcliente");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Carta)
                .HasComment("numero de identificação da carta que foi impressa")
                .HasColumnName("carta");
            entity.Property(e => e.Codcliente)
                .HasComment("codigo do cliente")
                .HasColumnName("codcliente");
            entity.Property(e => e.Codusuario)
                .HasComment("codigo do usuario")
                .HasColumnName("codusuario");
            entity.Property(e => e.Dataimpressao)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataimpressao");
        });

        modelBuilder.Entity<TblImpreCaixa>(entity =>
        {
            entity.HasKey(e => e.Localip).HasName("tbl_impre_caixas_pkey");

            entity.ToTable("tbl_impre_caixas");

            entity.Property(e => e.Localip)
                .HasMaxLength(15)
                .HasColumnName("localip");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Localhostname)
                .HasMaxLength(60)
                .HasColumnName("localhostname");
            entity.Property(e => e.Printerip)
                .HasMaxLength(15)
                .HasColumnName("printerip");
            entity.Property(e => e.Usuario).HasColumnName("usuario");
        });

        modelBuilder.Entity<TblInfoAnexoDifal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_info_anexo_difal_pkey");

            entity.ToTable("tbl_info_anexo_difal");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Chave)
                .HasMaxLength(44)
                .HasColumnName("chave");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.ComprovanteAnexado)
                .HasDefaultValueSql("false")
                .HasColumnName("comprovante_anexado");
            entity.Property(e => e.DataGrav)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_grav");
            entity.Property(e => e.DataUsuarioAnexo)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_usuario_anexo");
            entity.Property(e => e.DataUsuarioComprovante)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_usuario_comprovante");
            entity.Property(e => e.DifalAnexado)
                .HasDefaultValueSql("false")
                .HasColumnName("difal_anexado");
            entity.Property(e => e.Documento)
                .HasMaxLength(40)
                .HasColumnName("documento");
            entity.Property(e => e.Finalizado)
                .HasDefaultValueSql("false")
                .HasColumnName("finalizado");
            entity.Property(e => e.NumeroNfe).HasColumnName("numero_nfe");
            entity.Property(e => e.Uf)
                .HasColumnType("character varying")
                .HasColumnName("uf");
            entity.Property(e => e.UsuarioAnexo)
                .HasDefaultValueSql("'não anexado'::character varying")
                .HasColumnType("character varying")
                .HasColumnName("usuario_anexo");
            entity.Property(e => e.UsuarioComprovante)
                .HasDefaultValueSql("'não anexado'::character varying")
                .HasColumnType("character varying")
                .HasColumnName("usuario_comprovante");
            entity.Property(e => e.UsuarioGrav)
                .HasMaxLength(35)
                .HasColumnName("usuario_grav");
            entity.Property(e => e.XmlBaixado)
                .HasDefaultValueSql("false")
                .HasColumnName("xml_baixado");
        });

        modelBuilder.Entity<TblInformacao>(entity =>
        {
            entity.HasKey(e => e.Codinformacao).HasName("cpinformacao");

            entity.ToTable("tbl_informacao");

            entity.HasIndex(e => e.Codcliente, "index_tbl_informacao_codcliente");

            entity.Property(e => e.Codinformacao)
                .HasDefaultValueSql("nextval('seq_tblinfor'::regclass)")
                .HasColumnName("codinformacao");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Dataconsulta)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataconsulta");
            entity.Property(e => e.Foneinfo)
                .HasMaxLength(15)
                .HasColumnName("foneinfo");
            entity.Property(e => e.Informante)
                .HasMaxLength(35)
                .HasColumnName("informante");
            entity.Property(e => e.Posicao).HasColumnName("posicao");
            entity.Property(e => e.Referencia)
                .HasMaxLength(35)
                .HasColumnName("referencia");
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .HasColumnName("tipo");

            entity.HasOne(d => d.CodusuarioNavigation).WithMany(p => p.TblInformacaos)
                .HasForeignKey(d => d.Codusuario)
                .HasConstraintName("fk_tblusuario");
        });

        modelBuilder.Entity<TblIpDe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_ip_des_pkey");

            entity.ToTable("tbl_ip_des");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.IdAtivoTipo).HasColumnName("id_ativo_tipo");
            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .HasColumnName("ip");
            entity.Property(e => e.Local)
                .HasMaxLength(50)
                .HasColumnName("local");
            entity.Property(e => e.Usuario)
                .HasMaxLength(30)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<TblJornal>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_jornal_pkey");

            entity.ToTable("tbl_jornal");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Botafora)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("botafora");
            entity.Property(e => e.Coeficiente)
                .HasDefaultValueSql("0")
                .HasColumnName("coeficiente");
            entity.Property(e => e.Dataentrada)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataentrada");
            entity.Property(e => e.Datasaida)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datasaida");
            entity.Property(e => e.Juro)
                .HasDefaultValueSql("0")
                .HasColumnName("juro");
            entity.Property(e => e.Juronocartao)
                .HasDefaultValueSql("0")
                .HasColumnName("juronocartao");
            entity.Property(e => e.Nomejornal)
                .HasMaxLength(40)
                .HasColumnName("nomejornal");
            entity.Property(e => e.Tac)
                .HasDefaultValueSql("0")
                .HasColumnName("tac");
        });

        modelBuilder.Entity<TblJornalProduto>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_jornal_produtos_pkey");

            entity.ToTable("tbl_jornal_produtos");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Agrupamento)
                .HasDefaultValueSql("0")
                .HasColumnName("agrupamento");
            entity.Property(e => e.Chegar)
                .HasComment("quantidade a chegar usado resultado parcial")
                .HasColumnName("chegar");
            entity.Property(e => e.Chegou).HasColumnName("chegou");
            entity.Property(e => e.Codjornal).HasColumnName("codjornal");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(14)
                .HasColumnName("codproduto");
            entity.Property(e => e.Codprodutojornal).HasColumnName("codprodutojornal");
            entity.Property(e => e.Dataedicao)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("dataedicao");
            entity.Property(e => e.Datainclusao)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("datainclusao");
            entity.Property(e => e.Descricaojornal)
                .HasMaxLength(100)
                .HasColumnName("descricaojornal");
            entity.Property(e => e.Grupo).HasColumnName("grupo");
            entity.Property(e => e.MargemLucroJornal)
                .HasPrecision(9, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("margem_lucro_jornal");
            entity.Property(e => e.Margemantiga).HasColumnName("margemantiga");
            entity.Property(e => e.Margemjornal).HasColumnName("margemjornal");
            entity.Property(e => e.ProdutoSeparado).HasColumnName("produto_separado");
            entity.Property(e => e.Produtodestaque).HasColumnName("produtodestaque");
            entity.Property(e => e.Quantfinal).HasColumnName("quantfinal");
            entity.Property(e => e.Quantinicio).HasColumnName("quantinicio");
            entity.Property(e => e.TaxaDoDepartamento).HasColumnName("taxa_do_departamento");
            entity.Property(e => e.Taxaejuro)
                .HasMaxLength(10)
                .HasComment("taxa e juro especial")
                .HasColumnName("taxaejuro");
            entity.Property(e => e.Usuario)
                .HasMaxLength(60)
                .HasComment("coluna para deixar gravado o usuário que inseriu o produto no jornal")
                .HasColumnName("usuario");
            entity.Property(e => e.UsuarioEditou)
                .HasMaxLength(60)
                .HasComment("usuario que editou o preço do jornal")
                .HasColumnName("usuario_editou");
            entity.Property(e => e.Vendavista).HasColumnName("vendavista");
        });

        modelBuilder.Entity<TblJornalPronto>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_jornal_pronto_pkey");

            entity.ToTable("tbl_jornal_pronto");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Avista).HasColumnName("avista");
            entity.Property(e => e.Codjornal).HasColumnName("codjornal");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Cordisponivel).HasColumnName("cordisponivel");
            entity.Property(e => e.Custo).HasColumnName("custo");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Descricao).HasColumnName("descricao");
            entity.Property(e => e.Divisao).HasColumnName("divisao");
            entity.Property(e => e.Financeira)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasComment("exibir parcelas da financeira? S/N")
                .HasColumnName("financeira");
            entity.Property(e => e.Foto)
                .HasDefaultValueSql("0")
                .HasColumnName("foto");
            entity.Property(e => e.Juro).HasColumnName("juro");
            entity.Property(e => e.Juroemtodas)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("Aplicar juro em todas as condições? s/n")
                .HasColumnName("juroemtodas");
            entity.Property(e => e.Jurotodas)
                .HasMaxLength(1)
                .HasColumnName("jurotodas");
            entity.Property(e => e.Margem).HasColumnName("margem");
            entity.Property(e => e.Margemnormal).HasColumnName("margemnormal");
            entity.Property(e => e.Nomeproduto)
                .HasMaxLength(100)
                .HasColumnName("nomeproduto");
            entity.Property(e => e.Obsgeral).HasColumnName("obsgeral");
            entity.Property(e => e.Pagina)
                .HasDefaultValueSql("0")
                .HasColumnName("pagina");
            entity.Property(e => e.Parc1)
                .HasMaxLength(20)
                .HasColumnName("parc1");
            entity.Property(e => e.Parc2)
                .HasMaxLength(20)
                .HasColumnName("parc2");
            entity.Property(e => e.Precosistema)
                .HasMaxLength(120)
                .HasColumnName("precosistema");
            entity.Property(e => e.Semjuros)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("semjuros");
            entity.Property(e => e.Semjuroscartao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("semjuroscartao");
            entity.Property(e => e.Taxa).HasColumnName("taxa");
            entity.Property(e => e.TaxaDoDepartamento).HasColumnName("taxa_do_departamento");
            entity.Property(e => e.Totalparc1).HasColumnName("totalparc1");
            entity.Property(e => e.Totalparc2).HasColumnName("totalparc2");
            entity.Property(e => e.Valorparc1).HasColumnName("valorparc1");
            entity.Property(e => e.Valorparc2).HasColumnName("valorparc2");
            entity.Property(e => e.Vendat1).HasColumnName("vendat1");
        });

        modelBuilder.Entity<TblJornalTaxaJuro>(entity =>
        {
            entity.HasKey(e => new { e.Codjornal, e.Coddep, e.QuantParc }).HasName("tbl_jornal_taxa_juro_pkey");

            entity.ToTable("tbl_jornal_taxa_juro");

            entity.Property(e => e.Codjornal).HasColumnName("codjornal");
            entity.Property(e => e.Coddep).HasColumnName("coddep");
            entity.Property(e => e.QuantParc).HasColumnName("quant_parc");
            entity.Property(e => e.Coddiv).HasColumnName("coddiv");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasPrecision(0)
                .HasColumnName("data");
            entity.Property(e => e.Individual)
                .HasMaxLength(1)
                .HasColumnName("individual");
            entity.Property(e => e.Taxa)
                .HasPrecision(7, 4)
                .HasColumnName("taxa");
            entity.Property(e => e.TaxaCartao)
                .HasPrecision(7, 4)
                .HasColumnName("taxa_cartao");
        });

        modelBuilder.Entity<TblJuroespecialOld>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cp_codigo");

            entity.ToTable("tbl_juroespecial_old");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tbljuroespecial'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Condicao)
                .HasComment("Condição de pagamento")
                .HasColumnName("condicao");
            entity.Property(e => e.Juro)
                .HasComment("Taxa de juro")
                .HasColumnName("juro");
        });

        modelBuilder.Entity<TblLeologEntrada>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_leolog_entradas_pkey");

            entity.ToTable("tbl_leolog_entradas");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Arquivo)
                .HasColumnType("json")
                .HasColumnName("arquivo");
            entity.Property(e => e.ArquivoConferencia)
                .HasColumnType("json")
                .HasColumnName("arquivo_conferencia");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.NumeroNota)
                .HasMaxLength(10)
                .HasColumnName("numero_nota");
            entity.Property(e => e.Previsao)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("previsao");
            entity.Property(e => e.SerieNota)
                .HasMaxLength(10)
                .HasColumnName("serie_nota");
            entity.Property(e => e.TipoNota).HasColumnName("tipo_nota");
        });

        modelBuilder.Entity<TblLeologManutencao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_leolog_manutencao_pkey");

            entity.ToTable("tbl_leolog_manutencao");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Fim)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fim");
            entity.Property(e => e.Inicio)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("inicio");
        });

        modelBuilder.Entity<TblLeologSaida>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_leolog_saidas_pkey");

            entity.ToTable("tbl_leolog_saidas");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArquivoConferencia)
                .HasColumnType("json")
                .HasColumnName("arquivo_conferencia");
            entity.Property(e => e.ArquivoSolicitado)
                .HasColumnType("json")
                .HasColumnName("arquivo_solicitado");
            entity.Property(e => e.Codusuario)
                .HasDefaultValueSql("144")
                .HasColumnName("codusuario");
            entity.Property(e => e.Pedido)
                .HasMaxLength(15)
                .HasColumnName("pedido");
        });

        modelBuilder.Entity<TblLeologStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_leolog_status_pkey");

            entity.ToTable("tbl_leolog_status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codusuario)
                .HasDefaultValueSql("144")
                .HasColumnName("codusuario");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Situacao)
                .HasMaxLength(1)
                .HasColumnName("situacao");
            entity.Property(e => e.SituacaoDescricao)
                .HasMaxLength(500)
                .HasColumnName("situacao_descricao");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
            entity.Property(e => e.TipoId).HasColumnName("tipo_id");
        });

        modelBuilder.Entity<TblLinkteste>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_linkteste_pkey");

            entity.ToTable("tbl_linkteste");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .HasColumnName("ip");
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<TblLogAnexo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_log_anexos_pkey");

            entity.ToTable("tbl_log_anexos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alteracao).HasColumnName("alteracao");
            entity.Property(e => e.Categoria)
                .HasColumnType("character varying")
                .HasColumnName("categoria");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Datahora)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datahora");
        });

        modelBuilder.Entity<TblLogAtualizaRomaneio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_log_atualiza_romaneio_pkey");

            entity.ToTable("tbl_log_atualiza_romaneio");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .HasColumnName("documento");
            entity.Property(e => e.LoginUser).HasColumnName("login_user");
        });

        modelBuilder.Entity<TblLogDiParaDp>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_log_di_para_dp_pkey");

            entity.ToTable("tbl_log_di_para_dp", tb => tb.HasComment("logs inseridos na mudança de DI para DP, ou vice-versa, na FrmConsultaPedido"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(50)
                .HasColumnName("codpedido");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Para)
                .HasMaxLength(20)
                .HasColumnName("para");
        });

        modelBuilder.Entity<TblLogEstornoParcela>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_log_estorno_parcela_pkey");

            entity.ToTable("tbl_log_estorno_parcela");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Datahora).HasColumnName("datahora");
            entity.Property(e => e.Justificativa).HasColumnName("justificativa");
        });

        modelBuilder.Entity<TblLogImpSegviaCarne>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_log_imp_segvia_carne_pkey");

            entity.ToTable("tbl_log_imp_segvia_carne", tb => tb.HasComment("log impressão segunda via carnê parcelas pagas"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Ip)
                .HasMaxLength(60)
                .HasColumnName("ip");
            entity.Property(e => e.Nomemaquina)
                .HasMaxLength(50)
                .HasColumnName("nomemaquina");
        });

        modelBuilder.Entity<TblLogParcelasPaga>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_log_parcelas_pagas_pkey");

            entity.ToTable("tbl_log_parcelas_pagas");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Datahora).HasColumnName("datahora");
            entity.Property(e => e.Informacoes).HasColumnName("informacoes");
            entity.Property(e => e.Justificativa).HasColumnName("justificativa");
        });

        modelBuilder.Entity<TblLogParcelasPrazo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_log_parcelas_prazo_pkey");

            entity.ToTable("tbl_log_parcelas_prazo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(60)
                .HasColumnName("codpedido");
            entity.Property(e => e.Datahora).HasColumnName("datahora");
            entity.Property(e => e.Login)
                .HasMaxLength(250)
                .HasColumnName("login");
        });

        modelBuilder.Entity<TblLogParciaisGerada>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_log_parciais_geradas");

            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Datahora).HasColumnName("datahora");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Justificativa).HasColumnName("justificativa");
        });

        modelBuilder.Entity<TblLogUpdate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_log_update");

            entity.Property(e => e.Command).HasColumnName("command");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.RefTabela)
                .HasMaxLength(50)
                .HasColumnName("ref_tabela");
            entity.Property(e => e.Tabela).HasColumnName("tabela");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<TblLogisticaPosico>(entity =>
        {
            entity.HasKey(e => e.Posicao).HasName("tbl_logistica_posicoes_pkey");

            entity.ToTable("tbl_logistica_posicoes", tb => tb.HasComment("posições disponíveis no depósito\na composição do código é \nDIGITO         DESCRIÇÃO\n1 e 2               RUA\n3                     LADO\n4                    COLUNA\n5                    ALTURA\n6                    PALETE(com um ponto antes)"));

            entity.Property(e => e.Posicao)
                .HasMaxLength(30)
                .HasColumnName("posicao");
            entity.Property(e => e.Alt).HasColumnName("alt");
            entity.Property(e => e.Altura)
                .HasMaxLength(2)
                .HasColumnName("altura");
            entity.Property(e => e.Coluna)
                .HasMaxLength(2)
                .HasColumnName("coluna");
            entity.Property(e => e.Disponivel).HasColumnName("disponivel");
            entity.Property(e => e.Lado)
                .HasMaxLength(1)
                .HasColumnName("lado");
            entity.Property(e => e.Lar).HasColumnName("lar");
            entity.Property(e => e.Palete)
                .HasMaxLength(2)
                .HasColumnName("palete");
            entity.Property(e => e.Pro).HasColumnName("pro");
            entity.Property(e => e.Rua)
                .HasMaxLength(2)
                .HasColumnName("rua");
        });

        modelBuilder.Entity<TblLogisticaProdPo>(entity =>
        {
            entity.HasKey(e => e.Codproduto).HasName("tbl_logistica_posicao_pkey");

            entity.ToTable("tbl_logistica_prod_pos", tb => tb.HasComment("codproduto e suas posições em nosso centro de distribuição\n\nDIGITO         DESCRIÇÃO\n1 e 2               RUA\n3                     LADO\n4                    COLUNA\n5                    ALTURA\n6                    PALETE(com um ponto antes)"));

            entity.Property(e => e.Codproduto)
                .HasMaxLength(13)
                .HasColumnName("codproduto");
            entity.Property(e => e.Posicao)
                .HasMaxLength(20)
                .HasColumnName("posicao");
        });

        modelBuilder.Entity<TblLoja>(entity =>
        {
            entity.HasKey(e => e.Codloja).HasName("tbl_lojas_pkey");

            entity.ToTable("tbl_lojas");

            entity.Property(e => e.Codloja)
                .HasDefaultValueSql("nextval('seq_tbllojas'::regclass)")
                .HasColumnName("codloja");
            entity.Property(e => e.Bairro)
                .HasMaxLength(30)
                .HasColumnName("bairro");
            entity.Property(e => e.Cep)
                .HasMaxLength(15)
                .HasColumnName("cep");
            entity.Property(e => e.Cidade)
                .HasMaxLength(20)
                .HasColumnName("cidade");
            entity.Property(e => e.Cnae)
                .HasMaxLength(7)
                .HasColumnName("cnae");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(14)
                .HasColumnName("cnpj");
            entity.Property(e => e.Codcidade).HasColumnName("codcidade");
            entity.Property(e => e.Codrota).HasColumnName("codrota");
            entity.Property(e => e.Coduf).HasColumnName("coduf");
            entity.Property(e => e.Complemento)
                .HasColumnType("character varying")
                .HasColumnName("complemento");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Endereco)
                .HasMaxLength(50)
                .HasColumnName("endereco");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(60)
                .HasColumnName("fantasia");
            entity.Property(e => e.Fone)
                .HasMaxLength(30)
                .HasColumnName("fone");
            entity.Property(e => e.Im)
                .HasMaxLength(15)
                .HasColumnName("im");
            entity.Property(e => e.Insc)
                .HasMaxLength(14)
                .HasColumnName("insc");
            entity.Property(e => e.Loja)
                .HasMaxLength(50)
                .HasColumnName("loja");
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .HasColumnName("numero");
            entity.Property(e => e.Rsocial)
                .HasMaxLength(60)
                .HasColumnName("rsocial");
            entity.Property(e => e.Tipoloja)
                .HasMaxLength(10)
                .HasDefaultValueSql("0")
                .HasColumnName("tipoloja");
            entity.Property(e => e.TituloEtiqueta)
                .HasMaxLength(100)
                .HasColumnName("titulo_etiqueta");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");

            entity.HasOne(d => d.CodufNavigation).WithMany(p => p.TblLojas)
                .HasForeignKey(d => d.Coduf)
                .HasConstraintName("tbl_lojas_coduf_fkey");
        });

        modelBuilder.Entity<TblLojaAssistencium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_loja_assistencia_pkey");

            entity.ToTable("tbl_loja_assistencia");

            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Loja).HasColumnType("character varying");
        });

        modelBuilder.Entity<TblMalote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_malote_pkey");

            entity.ToTable("tbl_malote");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Coduserenvia).HasColumnName("coduserenvia");
            entity.Property(e => e.Coduserrecebe).HasColumnName("coduserrecebe");
            entity.Property(e => e.Dataabremalote)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataabremalote");
            entity.Property(e => e.Datacria)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datacria");
            entity.Property(e => e.Dataenviomalote)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataenviomalote");
            entity.Property(e => e.Dataprevi)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataprevi");
            entity.Property(e => e.Datarecebemalote)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datarecebemalote");
            entity.Property(e => e.Delete)
                .HasMaxLength(1)
                .HasColumnName("delete");
            entity.Property(e => e.Lojadest)
                .HasMaxLength(4)
                .HasColumnName("lojadest");
            entity.Property(e => e.Lojareme)
                .HasMaxLength(4)
                .HasColumnName("lojareme");
            entity.Property(e => e.Numlacre)
                .HasMaxLength(11)
                .HasColumnName("numlacre");
            entity.Property(e => e.Statusmalote)
                .HasMaxLength(10)
                .HasColumnName("statusmalote");
            entity.Property(e => e.Transporte)
                .HasMaxLength(12)
                .HasColumnName("transporte");
            entity.Property(e => e.Userenviamalote)
                .HasMaxLength(200)
                .HasColumnName("userenviamalote");
            entity.Property(e => e.Userrecebemalote)
                .HasMaxLength(150)
                .HasColumnName("userrecebemalote");
        });

        modelBuilder.Entity<TblMaloteIten>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_malote_itens_pkey");

            entity.ToTable("tbl_malote_itens");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Coduserdest).HasColumnName("coduserdest");
            entity.Property(e => e.Coduserrecebe).HasColumnName("coduserrecebe");
            entity.Property(e => e.Coduserreme).HasColumnName("coduserreme");
            entity.Property(e => e.Datacria)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datacria");
            entity.Property(e => e.Dataretiraitem)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataretiraitem");
            entity.Property(e => e.Deleteitem)
                .HasMaxLength(1)
                .HasColumnName("deleteitem");
            entity.Property(e => e.Deletemalote)
                .HasMaxLength(1)
                .HasColumnName("deletemalote");
            entity.Property(e => e.Dep).HasColumnName("dep");
            entity.Property(e => e.Descricao).HasColumnName("descricao");
            entity.Property(e => e.Destloja)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("destloja");
            entity.Property(e => e.Lacrenum)
                .HasMaxLength(15)
                .HasColumnName("lacrenum");
            entity.Property(e => e.Nomeuserdest)
                .HasMaxLength(160)
                .HasColumnName("nomeuserdest");
            entity.Property(e => e.Prevdata)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("prevdata");
            entity.Property(e => e.Remeloja)
                .HasMaxLength(15)
                .HasColumnName("remeloja");
            entity.Property(e => e.Statusentrega)
                .HasMaxLength(20)
                .HasColumnName("statusentrega");
        });

        modelBuilder.Entity<TblMaloteItensOb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_malote_itens_obs_pkey");

            entity.ToTable("tbl_malote_itens_obs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Iditem).HasColumnName("iditem");
            entity.Property(e => e.Obsitem)
                .HasColumnType("character varying")
                .HasColumnName("obsitem");
        });

        modelBuilder.Entity<TblMarca>(entity =>
        {
            entity.HasKey(e => e.Codmarca).HasName("cp_tblmarca");

            entity.ToTable("tbl_marca");

            entity.HasIndex(e => e.Marca, "tbl_marca_marca_key").IsUnique();

            entity.Property(e => e.Codmarca)
                .HasDefaultValueSql("nextval('seq_tblmarca'::regclass)")
                .HasColumnName("codmarca");
            entity.Property(e => e.Atualizado)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("atualizado");
            entity.Property(e => e.AtualizadoWeb)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("atualizado_web");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.CodusuarioWeb).HasColumnName("codusuario_web");
            entity.Property(e => e.Marca)
                .HasMaxLength(30)
                .HasColumnName("marca");
        });

        modelBuilder.Entity<TblMarcaAssistencium>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_marca_assistencia_pkey");

            entity.ToTable("tbl_marca_assistencia");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasColumnName("ativo");
            entity.Property(e => e.Codmarca).HasColumnName("codmarca");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Datainicio)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datainicio");
        });

        modelBuilder.Entity<TblMarketing>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_marketing_pkey");

            entity.ToTable("tbl_marketing");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataFim)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_fim");
            entity.Property(e => e.DataInicio)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_inicio");
            entity.Property(e => e.Login)
                .HasMaxLength(20)
                .HasColumnName("login");
            entity.Property(e => e.Promocao)
                .HasMaxLength(50)
                .HasColumnName("promocao");
        });

        modelBuilder.Entity<TblMarketingCliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_marketing_cliente_pkey");

            entity.ToTable("tbl_marketing_cliente");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codpedido).HasColumnName("codpedido");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.IdPromo).HasColumnName("id_promo");
            entity.Property(e => e.Login)
                .HasMaxLength(20)
                .HasColumnName("login");
            entity.Property(e => e.Pesquisa)
                .HasMaxLength(25)
                .HasColumnName("pesquisa");
        });

        modelBuilder.Entity<TblMarketplaceRepasse>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Codigo }).HasName("tbl_marketplace_repasse_pkey");

            entity.ToTable("tbl_marketplace_repasse");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Codigo)
                .HasMaxLength(40)
                .HasColumnName("codigo");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Json).HasColumnName("json");
        });

        modelBuilder.Entity<TblMensagem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_mensagem");

            entity.HasIndex(e => e.Coddest, "index_tblmensagem_coddest");

            entity.HasIndex(e => e.Lida, "index_tblmensagem_lida");

            entity.Property(e => e.Arquivar)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("arquivar");
            entity.Property(e => e.Assunto)
                .HasMaxLength(50)
                .HasColumnName("assunto");
            entity.Property(e => e.Codanexo).HasColumnName("codanexo");
            entity.Property(e => e.Coddest).HasColumnName("coddest");
            entity.Property(e => e.Codigo)
                .ValueGeneratedOnAdd()
                .HasColumnName("codigo");
            entity.Property(e => e.Codmensagemenviada).HasColumnName("codmensagemenviada");
            entity.Property(e => e.Codreme).HasColumnName("codreme");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Destinatarios).HasColumnName("destinatarios");
            entity.Property(e => e.Lida)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("lida");
            entity.Property(e => e.Mensagem).HasColumnName("mensagem");

            entity.HasOne(d => d.CoddestNavigation).WithMany()
                .HasForeignKey(d => d.Coddest)
                .HasConstraintName("tbl_mensagem_coddest_fkey");

            entity.HasOne(d => d.CodremeNavigation).WithMany()
                .HasForeignKey(d => d.Codreme)
                .HasConstraintName("tbl_mensagem_codreme_fkey");
        });

        modelBuilder.Entity<TblMensagemArquivadaPastum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_mensagem_arquivada_pasta_pkey");

            entity.ToTable("tbl_mensagem_arquivada_pasta");

            entity.HasIndex(e => new { e.Codusuario, e.Nome }, "tbl_mensagem_arquivada_pasta_codusuario_nome_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<TblMensagemArquivadum>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_mensagem_recebida_pkey");

            entity.ToTable("tbl_mensagem_arquivada");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('tbl_mensagem_recebida_codigo_seq'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Assunto)
                .HasMaxLength(50)
                .HasColumnName("assunto");
            entity.Property(e => e.Codanexo)
                .HasDefaultValueSql("0")
                .HasColumnName("codanexo");
            entity.Property(e => e.Coddest).HasColumnName("coddest");
            entity.Property(e => e.Codentrada).HasColumnName("codentrada");
            entity.Property(e => e.Codreme).HasColumnName("codreme");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Destinatarios).HasColumnName("destinatarios");
            entity.Property(e => e.Lida)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("lida");
            entity.Property(e => e.Mensagem).HasColumnName("mensagem");
            entity.Property(e => e.Pasta)
                .HasDefaultValueSql("0")
                .HasColumnName("pasta");

            entity.HasOne(d => d.CoddestNavigation).WithMany(p => p.TblMensagemArquivadumCoddestNavigations)
                .HasForeignKey(d => d.Coddest)
                .HasConstraintName("tbl_mensagem_coddest_fkey");

            entity.HasOne(d => d.CodremeNavigation).WithMany(p => p.TblMensagemArquivadumCodremeNavigations)
                .HasForeignKey(d => d.Codreme)
                .HasConstraintName("tbl_mensagem_codreme_fkey");
        });

        modelBuilder.Entity<TblMensagemDel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_mensagem_del_pkey");

            entity.ToTable("tbl_mensagem_del");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Assunto)
                .HasMaxLength(51)
                .HasColumnName("assunto");
            entity.Property(e => e.Coddest).HasColumnName("coddest");
            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codreme).HasColumnName("codreme");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Destinatarios).HasColumnName("destinatarios");
            entity.Property(e => e.Lida)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("lida");
            entity.Property(e => e.Mensagem).HasColumnName("mensagem");

            entity.HasOne(d => d.CoddestNavigation).WithMany(p => p.TblMensagemDelCoddestNavigations)
                .HasForeignKey(d => d.Coddest)
                .HasConstraintName("tbl_mensagem_coddest_fkey");

            entity.HasOne(d => d.CodremeNavigation).WithMany(p => p.TblMensagemDelCodremeNavigations)
                .HasForeignKey(d => d.Codreme)
                .HasConstraintName("tbl_mensagem_codreme_fkey");
        });

        modelBuilder.Entity<TblMensagemEnviadum>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_mensagem_enviada_pkey");

            entity.ToTable("tbl_mensagem_enviada");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Assunto)
                .HasMaxLength(51)
                .HasColumnName("assunto");
            entity.Property(e => e.Codanexo).HasColumnName("codanexo");
            entity.Property(e => e.Coddest).HasColumnName("coddest");
            entity.Property(e => e.Codreme).HasColumnName("codreme");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Destinatarios).HasColumnName("destinatarios");
            entity.Property(e => e.Lida)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("lida");
            entity.Property(e => e.Mensagem).HasColumnName("mensagem");

            entity.HasOne(d => d.CoddestNavigation).WithMany(p => p.TblMensagemEnviadumCoddestNavigations)
                .HasForeignKey(d => d.Coddest)
                .HasConstraintName("tbl_mensagem_coddest_fkey");

            entity.HasOne(d => d.CodremeNavigation).WithMany(p => p.TblMensagemEnviadumCodremeNavigations)
                .HasForeignKey(d => d.Codreme)
                .HasConstraintName("tbl_mensagem_codreme_fkey");
        });

        modelBuilder.Entity<TblMensagemGrupo>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_mensagem_grupo_pkey");

            entity.ToTable("tbl_mensagem_grupo");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Descricao).HasColumnName("descricao");
            entity.Property(e => e.Loja).HasColumnName("loja");
            entity.Property(e => e.Msn).HasColumnName("msn");
            entity.Property(e => e.Usuarios).HasColumnName("usuarios");
        });

        modelBuilder.Entity<TblMensagemassist>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_mensagemassist_pkey");

            entity.ToTable("tbl_mensagemassist");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Mensagem).HasColumnName("mensagem");
        });

        modelBuilder.Entity<TblMenu>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_menu_pkey");

            entity.ToTable("tbl_menu");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Botao).HasColumnName("botao");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Formulario)
                .HasMaxLength(60)
                .HasColumnName("formulario");
            entity.Property(e => e.Legenda)
                .HasMaxLength(40)
                .HasColumnName("legenda");
        });

        modelBuilder.Entity<TblMenuSistema>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_menu_sistema_pkey");

            entity.ToTable("tbl_menu_sistema");

            entity.HasIndex(e => e.Nome, "tbl_menu_sistema_nome_key").IsUnique();

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.AbreOld)
                .HasMaxLength(50)
                .HasColumnName("abre_OLD");
            entity.Property(e => e.Abrir)
                .HasMaxLength(50)
                .HasColumnName("abrir");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<TblMenuSistemaNew>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_menu_sistema_new_pkey");

            entity.ToTable("tbl_menu_sistema_new");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Abrir)
                .HasMaxLength(100)
                .HasColumnName("abrir");
            entity.Property(e => e.Abrirsubmenu)
                .HasMaxLength(60)
                .HasColumnName("abrirsubmenu");
            entity.Property(e => e.Index)
                .HasDefaultValueSql("1")
                .HasColumnName("index");
            entity.Property(e => e.Item)
                .HasMaxLength(60)
                .HasColumnName("item");
            entity.Property(e => e.Menu)
                .HasMaxLength(60)
                .HasColumnName("menu");
            entity.Property(e => e.Submenu)
                .HasMaxLength(60)
                .HasColumnName("submenu");
        });

        modelBuilder.Entity<TblMeta>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_metas_pkey");

            entity.ToTable("tbl_metas", tb => tb.HasComment("SETOR: VENDAS\nRegistro das metas mensais dos vendedores das lojas, por divisão.\n\nObs.:As colunas PLAN1, ATE1, PLAN2, ATE2 são obsoletas. Elas eram utilizadas na época em que vendíamos móveis planejados, quando as comissões eram variáveis por total vendido."));

            entity.HasIndex(e => new { e.Mes, e.Codloja }, "tbl_metas_mes_key").IsUnique();

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Ate1)
                .HasDefaultValueSql("0")
                .HasColumnName("ate1");
            entity.Property(e => e.Ate2)
                .HasDefaultValueSql("0")
                .HasColumnName("ate2");
            entity.Property(e => e.Ate3)
                .HasDefaultValueSql("0")
                .HasColumnName("ate3");
            entity.Property(e => e.Ate4)
                .HasDefaultValueSql("0")
                .HasColumnName("ate4");
            entity.Property(e => e.Brinquedos).HasColumnName("brinquedos");
            entity.Property(e => e.Cancelar)
                .HasPrecision(4, 2)
                .HasColumnName("cancelar");
            entity.Property(e => e.Cartao)
                .HasDefaultValueSql("0.00")
                .HasColumnName("cartao");
            entity.Property(e => e.Celular).HasColumnName("celular");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.ConstrucaoCivil)
                .HasDefaultValueSql("0")
                .HasColumnName("construcao_civil");
            entity.Property(e => e.Deppresentes).HasColumnName("deppresentes");
            entity.Property(e => e.Eletro).HasColumnName("eletro");
            entity.Property(e => e.Financeira).HasColumnName("financeira");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.MetaVendas).HasColumnName("meta_vendas");
            entity.Property(e => e.Moveis).HasColumnName("moveis");
            entity.Property(e => e.Multacancel)
                .HasPrecision(5, 2)
                .HasColumnName("multacancel");
            entity.Property(e => e.Notarotina).HasColumnName("notarotina");
            entity.Property(e => e.Plan1)
                .HasDefaultValueSql("0")
                .HasColumnName("plan1");
            entity.Property(e => e.Plan2)
                .HasDefaultValueSql("0")
                .HasColumnName("plan2");
            entity.Property(e => e.Plan3)
                .HasDefaultValueSql("0")
                .HasColumnName("plan3");
            entity.Property(e => e.Plan4)
                .HasDefaultValueSql("0")
                .HasColumnName("plan4");
            entity.Property(e => e.PremioSeguroGarantia)
                .HasPrecision(4, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("premio_seguro_garantia");
            entity.Property(e => e.PremioSeguroSabemi)
                .HasDefaultValueSql("0")
                .HasColumnName("premio_seguro_sabemi");
            entity.Property(e => e.Premiobrinquedos).HasColumnName("premiobrinquedos");
            entity.Property(e => e.Premiocelular).HasColumnName("premiocelular");
            entity.Property(e => e.PremioconstrucaoCivil)
                .HasDefaultValueSql("0")
                .HasColumnName("premioconstrucao_civil");
            entity.Property(e => e.Premioeletro).HasColumnName("premioeletro");
            entity.Property(e => e.Premiofinanceira).HasColumnName("premiofinanceira");
            entity.Property(e => e.Premiomoveis).HasColumnName("premiomoveis");
            entity.Property(e => e.Premiopresente).HasColumnName("premiopresente");
            entity.Property(e => e.Presentes).HasColumnName("presentes");
            entity.Property(e => e.SeguroGarantia)
                .HasPrecision(9, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("seguro_garantia");
            entity.Property(e => e.SeguroSabemi)
                .HasDefaultValueSql("0")
                .HasColumnName("seguro_sabemi");
            entity.Property(e => e.Usercelular)
                .HasMaxLength(15)
                .HasColumnName("usercelular");
            entity.Property(e => e.Userplanejado)
                .HasMaxLength(15)
                .HasColumnName("userplanejado");
        });

        modelBuilder.Entity<TblMotivoDescarregado>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_motivo_descarregado_pkey");

            entity.ToTable("tbl_motivo_descarregado");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Idromaneio).HasColumnName("idromaneio");
            entity.Property(e => e.Motivo).HasColumnName("motivo");
        });

        modelBuilder.Entity<TblMotivoNaocarregado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_motivo_naocarregado_pkey");

            entity.ToTable("tbl_motivo_naocarregado");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Idromaneio).HasColumnName("idromaneio");
            entity.Property(e => e.Motivo).HasColumnName("motivo");
        });

        modelBuilder.Entity<TblMotivoReagendar>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_motivo_reagendar_pkey");

            entity.ToTable("tbl_motivo_reagendar", tb => tb.HasComment("Motivos de Reagendar entrega do Romaneio"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Motivo)
                .HasMaxLength(50)
                .HasComment("motivo do reagendamento")
                .HasColumnName("motivo");
        });

        modelBuilder.Entity<TblMotivosNaocarregado>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_motivos_naocarregado_pkey");

            entity.ToTable("tbl_motivos_naocarregado");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("ativo");
            entity.Property(e => e.Motivo)
                .HasMaxLength(30)
                .HasColumnName("motivo");
        });

        modelBuilder.Entity<TblNfce>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_nfce_pkey");

            entity.ToTable("tbl_nfce", tb => tb.HasComment("SETOR: Fiscal e Pedido\nContém os dados dos cupons fiscais emitidos durante o processo de emissão de pedido.\n"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Chave)
                .HasMaxLength(44)
                .HasColumnName("chave");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codnota).HasColumnName("codnota");
            entity.Property(e => e.CstatEnvio)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("cstat_envio");
            entity.Property(e => e.CstatRetorno)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("cstat_retorno");
            entity.Property(e => e.DhEnvio)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("dh_envio");
            entity.Property(e => e.DhRetorno)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("dh_retorno");
            entity.Property(e => e.Documento)
                .HasMaxLength(15)
                .HasColumnName("documento");
            entity.Property(e => e.ImpDanfe).HasColumnName("imp_danfe");
            entity.Property(e => e.NfceXml)
                .HasColumnType("xml")
                .HasColumnName("nfce_xml");
            entity.Property(e => e.Numnota).HasColumnName("numnota");
            entity.Property(e => e.ProtEnvio)
                .HasMaxLength(15)
                .HasColumnName("prot_envio");
            entity.Property(e => e.Serie)
                .HasDefaultValueSql("1")
                .HasColumnName("serie");
            entity.Property(e => e.Situacao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'E'::bpchar")
                .HasColumnName("situacao");
            entity.Property(e => e.UserEnvio).HasColumnName("user_envio");
            entity.Property(e => e.UserRetorno).HasColumnName("user_retorno");
            entity.Property(e => e.Xmotivo).HasColumnName("xmotivo");
        });

        modelBuilder.Entity<TblNfe>(entity =>
        {
            entity.HasKey(e => new { e.Codloja, e.Numnota }).HasName("tbl_numnfe_pkey");

            entity.ToTable("tbl_nfe", tb => tb.HasComment("SETOR: Fiscal e Pedido\nContém os dados das notas fiscais eletrônicas emitidas, inclusive a chave da nota.\nsituação L = liberada\nsituação E = emitida\nTR+ a coluna código não está correlacionada com o documento da tbl_nfe, que também tem um TR+ um código. Este código da tbl_nfe é a ID da transferência.\nA correlação entre uma transferência e sua nota está na coluna NFE da tbl_romaneio.\n"));

            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Numnota).HasColumnName("numnota");
            entity.Property(e => e.Chave)
                .HasMaxLength(44)
                .HasColumnName("chave");
            entity.Property(e => e.CodTransferencia)
                .HasMaxLength(20)
                .HasColumnName("cod_transferencia");
            entity.Property(e => e.CstatEnvio)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("cstat_envio");
            entity.Property(e => e.CstatRetorno)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("cstat_retorno");
            entity.Property(e => e.DhEnvio)
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("dh_envio");
            entity.Property(e => e.DhRetorno)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dh_retorno");
            entity.Property(e => e.Documento)
                .HasMaxLength(40)
                .HasColumnName("documento");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('tbl_nfe_id_seq1'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.ImpDanfe)
                .HasDefaultValueSql("0")
                .HasColumnName("imp_danfe");
            entity.Property(e => e.NfeXml)
                .HasColumnType("xml")
                .HasColumnName("nfe_xml");
            entity.Property(e => e.NfeXmlEnvio).HasColumnName("nfe_xml_envio");
            entity.Property(e => e.ProtEnvio)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("prot_envio");
            entity.Property(e => e.RetornoEnvio)
                .HasColumnType("xml")
                .HasColumnName("retorno_envio");
            entity.Property(e => e.Serie)
                .HasDefaultValueSql("1")
                .HasColumnName("serie");
            entity.Property(e => e.Situacao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'E'::bpchar")
                .HasColumnName("situacao");
            entity.Property(e => e.TipoOperacao)
                .HasMaxLength(30)
                .HasColumnName("tipo_operacao");
            entity.Property(e => e.UserEnvio).HasColumnName("user_envio");
            entity.Property(e => e.UserRetorno).HasColumnName("user_retorno");
            entity.Property(e => e.Xmotivo).HasColumnName("xmotivo");

            entity.HasOne(d => d.CodlojaNavigation).WithMany(p => p.TblNves)
                .HasForeignKey(d => d.Codloja)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tbl_numnfe_codloja_fkey");
        });

        modelBuilder.Entity<TblNfeCsc>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_nfe_csc_pkey");

            entity.ToTable("tbl_nfe_csc");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Ativo)
                .HasDefaultValueSql("true")
                .HasColumnName("ativo");
            entity.Property(e => e.CodSeguranca)
                .HasMaxLength(36)
                .HasColumnName("cod_seguranca");
            entity.Property(e => e.IdCodSeg)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("id_cod_seg");
            entity.Property(e => e.Producao)
                .HasDefaultValueSql("true")
                .HasColumnName("producao");
            entity.Property(e => e.UrlQrcode)
                .HasMaxLength(250)
                .HasColumnName("url_qrcode");
        });

        modelBuilder.Entity<TblNfeDespesa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_nfe_despesas");

            entity.Property(e => e.Categoria).HasColumnName("categoria");
            entity.Property(e => e.Chave)
                .HasMaxLength(44)
                .HasColumnName("chave");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(17)
                .HasColumnName("cnpj");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Nota).HasColumnName("nota");
            entity.Property(e => e.Serie)
                .HasMaxLength(10)
                .HasColumnName("serie");
            entity.Property(e => e.Xml)
                .HasColumnType("xml")
                .HasColumnName("xml");
        });

        modelBuilder.Entity<TblNfeDestinada>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_nfe_destinadas_pkey");

            entity.ToTable("tbl_nfe_destinadas");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Chave)
                .HasMaxLength(44)
                .HasColumnName("chave");
            entity.Property(e => e.CnpjDest)
                .HasMaxLength(18)
                .HasColumnName("cnpj_dest");
            entity.Property(e => e.CnpjEmit)
                .HasMaxLength(18)
                .HasColumnName("cnpj_emit");
            entity.Property(e => e.DEmissao).HasColumnName("d_emissao");
            entity.Property(e => e.DhRecebimento)
                .HasColumnType("timestamp(4) without time zone")
                .HasColumnName("dh_recebimento");
            entity.Property(e => e.Nsu)
                .HasMaxLength(15)
                .HasColumnName("nsu");
            entity.Property(e => e.Valor)
                .HasPrecision(12, 2)
                .HasColumnName("valor");
            entity.Property(e => e.Xnome)
                .HasMaxLength(120)
                .HasColumnName("xnome");
        });

        modelBuilder.Entity<TblNfeEmissao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_nfe_emissao_pkey");

            entity.ToTable("tbl_nfe_emissao");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bloqueada).HasColumnName("bloqueada");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Loja).HasColumnName("loja");
            entity.Property(e => e.Numnota).HasColumnName("numnota");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Tipo)
                .HasColumnType("character varying")
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TblNfeEntradaArmazenagem>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_nfe_entrada_armazenagem_pkey");

            entity.ToTable("tbl_nfe_entrada_armazenagem");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.CodNfeArmazem)
                .HasComment("codigo na tbl_nfe_entrada referente a nota de armazem do fornecedor")
                .HasColumnName("cod_nfe_armazem");
            entity.Property(e => e.CodNfeVenda)
                .HasComment("codigo na tbl_nfe_entrada referente a nota de compra do fornecedor")
                .HasColumnName("cod_nfe_venda");
            entity.Property(e => e.Codlogistica).HasColumnName("codlogistica");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasPrecision(2)
                .HasColumnName("data");
            entity.Property(e => e.IdNfeArmazemMarcius)
                .HasComment("codigo na tbl_nfe referente a nfe de armazem emitida pela AppEmpresarialMultFuncional")
                .HasColumnName("id_nfe_armazem_marcius");
        });

        modelBuilder.Entity<TblNfeEntradum>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_nfe_entrada_pkey");

            entity.ToTable("tbl_nfe_entrada");

            entity.HasIndex(e => e.Chaveacesso, "tbl_nfe_entrada_chaveacesso_key").IsUnique();

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Chaveacesso)
                .HasMaxLength(44)
                .HasColumnName("chaveacesso");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.DataCadastro)
                .HasDefaultValueSql("now()")
                .HasColumnName("data_cadastro");
            entity.Property(e => e.Ecnpj)
                .HasMaxLength(18)
                .HasColumnName("ecnpj");
            entity.Property(e => e.Emissao).HasColumnName("emissao");
            entity.Property(e => e.Emitente)
                .HasMaxLength(60)
                .HasColumnName("emitente");
            entity.Property(e => e.Lancamento)
                .HasMaxLength(7)
                .HasColumnName("lancamento");
            entity.Property(e => e.Nfe).HasColumnName("nfe");
            entity.Property(e => e.Recebimento)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("recebimento");
            entity.Property(e => e.Userlanc).HasColumnName("userlanc");
            entity.Property(e => e.Userrec).HasColumnName("userrec");
            entity.Property(e => e.UsuarioIncXml).HasColumnName("usuario_inc_xml");
            entity.Property(e => e.Xml).HasColumnName("xml");
        });

        modelBuilder.Entity<TblNfeErro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_nfe_erro_pkey");

            entity.ToTable("tbl_nfe_erro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Pedido)
                .HasMaxLength(11)
                .HasColumnName("pedido");
            entity.Property(e => e.Usuario)
                .HasMaxLength(60)
                .HasColumnName("usuario");
            entity.Property(e => e.Xmotivo).HasColumnName("xmotivo");
        });

        modelBuilder.Entity<TblNfeIndenizacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_nfe_indenizacao_pkey");

            entity.ToTable("tbl_nfe_indenizacao");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodLoja).HasColumnName("cod_loja");
            entity.Property(e => e.CodPedido)
                .HasColumnType("character varying")
                .HasColumnName("cod_pedido");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.NumNota).HasColumnName("num_nota");
            entity.Property(e => e.Xml).HasColumnName("xml");
        });

        modelBuilder.Entity<TblNfeProduto>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_nfe_produtos_pkey");

            entity.ToTable("tbl_nfe_produtos");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Acrescimo).HasColumnName("acrescimo");
            entity.Property(e => e.AliquotaCofins)
                .HasPrecision(5, 2)
                .HasColumnName("aliquota_cofins");
            entity.Property(e => e.AliquotaPis)
                .HasPrecision(5, 2)
                .HasColumnName("aliquota_pis");
            entity.Property(e => e.Bcalculoicmsst)
                .HasPrecision(10, 3)
                .HasColumnName("bcalculoicmsst");
            entity.Property(e => e.Cest)
                .HasMaxLength(7)
                .HasColumnName("cest");
            entity.Property(e => e.Codean)
                .HasMaxLength(14)
                .HasColumnName("codean");
            entity.Property(e => e.Codeantrib)
                .HasMaxLength(14)
                .HasColumnName("codeantrib");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(11)
                .HasColumnName("codpedido");
            entity.Property(e => e.Codprodutonota)
                .HasMaxLength(60)
                .HasColumnName("codprodutonota");
            entity.Property(e => e.Codproseq)
                .HasMaxLength(16)
                .HasColumnName("codproseq");
            entity.Property(e => e.Codsubpedido).HasColumnName("codsubpedido");
            entity.Property(e => e.CodsubpedidoOld)
                .HasColumnType("character varying")
                .HasColumnName("codsubpedido_old");
            entity.Property(e => e.Composicao)
                .HasPrecision(9, 6)
                .HasColumnName("composicao");
            entity.Property(e => e.Cstpiscofins)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("cstpiscofins");
            entity.Property(e => e.Cstvenda)
                .HasMaxLength(3)
                .HasColumnName("cstvenda");
            entity.Property(e => e.Desconto).HasColumnName("desconto");
            entity.Property(e => e.Descricao)
                .HasMaxLength(180)
                .HasColumnName("descricao");
            entity.Property(e => e.DocFiscal).HasColumnName("doc_fiscal");
            entity.Property(e => e.IcmsSaida)
                .HasPrecision(5, 2)
                .HasColumnName("icms_saida");
            entity.Property(e => e.Imei)
                .HasMaxLength(15)
                .HasColumnName("imei");
            entity.Property(e => e.Imei2)
                .HasMaxLength(15)
                .HasColumnName("imei2");
            entity.Property(e => e.Ncm)
                .HasMaxLength(8)
                .HasColumnName("ncm");
            entity.Property(e => e.Nfce)
                .HasDefaultValueSql("0")
                .HasColumnName("nfce");
            entity.Property(e => e.Nfe)
                .HasDefaultValueSql("0")
                .HasColumnName("nfe");
            entity.Property(e => e.Pfcpufdest)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("pfcpufdest");
            entity.Property(e => e.Picmsinter)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("picmsinter");
            entity.Property(e => e.Picmsinterpart)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("picmsinterpart");
            entity.Property(e => e.Picmsufdest)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("picmsufdest");
            entity.Property(e => e.PrecovendaT1)
                .HasPrecision(9, 2)
                .HasColumnName("precovenda_t1");
            entity.Property(e => e.Quant).HasColumnName("quant");
            entity.Property(e => e.QuantPedido).HasColumnName("quant_pedido");
            entity.Property(e => e.RedBc)
                .HasPrecision(6, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("red_bc");
            entity.Property(e => e.RedBcDifal)
                .HasPrecision(6, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("red_bc_difal");
            entity.Property(e => e.St)
                .HasMaxLength(1)
                .HasColumnName("st");
            entity.Property(e => e.TipoDoc)
                .HasComment("tipo 1 = nota fiscal consumidor eletronica\ntipo 2 = nota fiscal eletronica")
                .HasColumnName("tipo_doc");
            entity.Property(e => e.Ucom)
                .HasMaxLength(6)
                .HasColumnName("ucom");
            entity.Property(e => e.Vbcufdest)
                .HasPrecision(9, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vbcufdest");
            entity.Property(e => e.Vfcpufdest)
                .HasPrecision(7, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vfcpufdest");
            entity.Property(e => e.Vicmsufdest)
                .HasPrecision(7, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vicmsufdest");
            entity.Property(e => e.Vicmsufremet)
                .HasPrecision(7, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vicmsufremet");
            entity.Property(e => e.Vunit)
                .HasPrecision(10, 4)
                .HasColumnName("vunit");
            entity.Property(e => e.Vvendatotal)
                .HasPrecision(10, 4)
                .HasColumnName("vvendatotal");
            entity.Property(e => e.Vvendaunit)
                .HasPrecision(10, 4)
                .HasColumnName("vvendaunit");
        });

        modelBuilder.Entity<TblNfeProdutosDevol>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_nfe_prosutos_devol_pkey");

            entity.ToTable("tbl_nfe_produtos_devol");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('tbl_nfe_prosutos_devol_codigo_seq'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(11)
                .HasColumnName("codpedido");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Codsubpedido).HasColumnName("codsubpedido");
            entity.Property(e => e.CupomVenda)
                .HasDefaultValueSql("0")
                .HasColumnName("cupom_venda");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Localsaida).HasColumnName("localsaida");
            entity.Property(e => e.NfceVenda)
                .HasDefaultValueSql("0")
                .HasColumnName("nfce_venda");
            entity.Property(e => e.NfeVenda)
                .HasDefaultValueSql("0")
                .HasColumnName("nfe_venda");
            entity.Property(e => e.Nfedev)
                .HasDefaultValueSql("0")
                .HasColumnName("nfedev");
            entity.Property(e => e.NfedevAutorizada)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("nfedev_autorizada");
            entity.Property(e => e.NumeroEcf).HasColumnName("numero_ecf");
            entity.Property(e => e.Quant).HasColumnName("quant");
            entity.Property(e => e.Vunit)
                .HasPrecision(10, 4)
                .HasColumnName("vunit");
        });

        modelBuilder.Entity<TblNfeVendaDevolucaoArmazenagem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_nfe_venda_devolucao_armazenagem_pkey");

            entity.ToTable("tbl_nfe_venda_devolucao_armazenagem");

            entity.HasIndex(e => e.Documento, "documento_unique").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Documento)
                .HasMaxLength(12)
                .HasColumnName("documento");
            entity.Property(e => e.IdNfeDevRetorno).HasColumnName("id_nfe_dev_retorno");
            entity.Property(e => e.IdNfeDevVenda).HasColumnName("id_nfe_dev_venda");
            entity.Property(e => e.IdNfeRetorno).HasColumnName("id_nfe_retorno");
            entity.Property(e => e.IdNfeVenda).HasColumnName("id_nfe_venda");
        });

        modelBuilder.Entity<TblNorma>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_normas_pkey");

            entity.ToTable("tbl_normas", tb => tb.HasComment("Normas e procedimentos da empresa e manual do sistema\n"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Alteradopor)
                .HasMaxLength(100)
                .HasColumnName("alteradopor");
            entity.Property(e => e.Criadopor)
                .HasMaxLength(100)
                .HasColumnName("criadopor");
            entity.Property(e => e.Descricao)
                .HasDefaultValueSql("50")
                .HasColumnName("descricao");
            entity.Property(e => e.Detalhe)
                .HasDefaultValueSql("100")
                .HasColumnName("detalhe");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("N para normas e procedimentos\n\nM para manual do sistema")
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TblNotaSub>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_nota_sub_pkey");

            entity.ToTable("tbl_nota_sub");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Aliquota)
                .HasPrecision(4, 2)
                .HasColumnName("aliquota");
            entity.Property(e => e.Classfiscal)
                .HasMaxLength(5)
                .HasColumnName("classfiscal");
            entity.Property(e => e.Codnota).HasColumnName("codnota");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .HasColumnName("descricao");
            entity.Property(e => e.Quantidade).HasColumnName("quantidade");
            entity.Property(e => e.Sittributaria).HasColumnName("sittributaria");
            entity.Property(e => e.Un)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("un");
            entity.Property(e => e.Valoricms).HasColumnName("valoricms");
            entity.Property(e => e.Valortotal).HasColumnName("valortotal");
            entity.Property(e => e.Valorunit).HasColumnName("valorunit");

            entity.HasOne(d => d.CodnotaNavigation).WithMany(p => p.TblNotaSubs)
                .HasForeignKey(d => d.Codnota)
                .HasConstraintName("tbl_nota_sub_codnota_fkey");
        });

        modelBuilder.Entity<TblNotum>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_nota_pkey");

            entity.ToTable("tbl_nota");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Bairro)
                .HasMaxLength(30)
                .HasColumnName("bairro");
            entity.Property(e => e.Baseicms).HasColumnName("baseicms");
            entity.Property(e => e.BaseicmsSubst).HasColumnName("baseicms_subst");
            entity.Property(e => e.Cancelada)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("cancelada");
            entity.Property(e => e.Canceladapor).HasColumnName("canceladapor");
            entity.Property(e => e.Cep)
                .HasMaxLength(10)
                .HasColumnName("cep");
            entity.Property(e => e.Cfop).HasColumnName("cfop");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Cpf)
                .HasMaxLength(20)
                .HasColumnName("cpf");
            entity.Property(e => e.Dadosadd).HasColumnName("dadosadd");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Datacancelada)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("datacancelada");
            entity.Property(e => e.Dataemissao)
                .HasDefaultValueSql("('now'::text)::timestamp(0) without time zone")
                .HasColumnName("dataemissao");
            entity.Property(e => e.Endereco)
                .HasMaxLength(50)
                .HasColumnName("endereco");
            entity.Property(e => e.Especie)
                .HasMaxLength(20)
                .HasColumnName("especie");
            entity.Property(e => e.Fone)
                .HasMaxLength(20)
                .HasColumnName("fone");
            entity.Property(e => e.FretePorconta)
                .HasDefaultValueSql("1")
                .HasComment("1-EMITENTE\n2-DESTINATARIO")
                .HasColumnName("frete_porconta");
            entity.Property(e => e.Marca)
                .HasMaxLength(20)
                .HasColumnName("marca");
            entity.Property(e => e.Municipio)
                .HasMaxLength(40)
                .HasColumnName("municipio");
            entity.Property(e => e.Natureza)
                .HasMaxLength(30)
                .HasColumnName("natureza");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("nome");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Outrasdespesas).HasColumnName("outrasdespesas");
            entity.Property(e => e.Pesobruto).HasColumnName("pesobruto");
            entity.Property(e => e.Pesoliquido).HasColumnName("pesoliquido");
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .HasColumnName("placa");
            entity.Property(e => e.Quantidade)
                .HasDefaultValueSql("0")
                .HasColumnName("quantidade");
            entity.Property(e => e.Rg)
                .HasMaxLength(20)
                .HasColumnName("rg");
            entity.Property(e => e.Serie).HasColumnName("serie");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'E'::bpchar")
                .HasColumnName("tipo");
            entity.Property(e => e.TranspCpf)
                .HasMaxLength(20)
                .HasColumnName("transp_cpf");
            entity.Property(e => e.TranspEndereco)
                .HasMaxLength(50)
                .HasColumnName("transp_endereco");
            entity.Property(e => e.TranspInsc)
                .HasMaxLength(20)
                .HasColumnName("transp_insc");
            entity.Property(e => e.TranspMunicipio)
                .HasMaxLength(30)
                .HasColumnName("transp_municipio");
            entity.Property(e => e.TranspNome)
                .HasMaxLength(50)
                .HasColumnName("transp_nome");
            entity.Property(e => e.TranspNumero).HasColumnName("transp_numero");
            entity.Property(e => e.TranspUf)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("transp_uf");
            entity.Property(e => e.TranspUf2)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("transp_uf2");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("uf");
            entity.Property(e => e.Valorfrete).HasColumnName("valorfrete");
            entity.Property(e => e.Valoricms)
                .HasPrecision(12, 2)
                .HasColumnName("valoricms");
            entity.Property(e => e.ValoricmsSubst).HasColumnName("valoricms_subst");
            entity.Property(e => e.Valoripi).HasColumnName("valoripi");
            entity.Property(e => e.Valornota).HasColumnName("valornota");
            entity.Property(e => e.Valorprodutos).HasColumnName("valorprodutos");
            entity.Property(e => e.Valorseguro).HasColumnName("valorseguro");
        });

        modelBuilder.Entity<TblObsAgendaFinanc>(entity =>
        {
            entity.HasKey(e => e.Mes).HasName("tbl_obs_agenda_financ_pkey");

            entity.ToTable("tbl_obs_agenda_financ");

            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.Obs).HasColumnName("obs");
        });

        modelBuilder.Entity<TblOcorrChamado>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_ocorr_chamados_pkey");

            entity.ToTable("tbl_ocorr_chamados");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Anotacao).HasColumnName("anotacao");
            entity.Property(e => e.Codassistencia)
                .HasDefaultValueSql("0")
                .HasComment("Codigo da Assistencia aberta.")
                .HasColumnName("codassistencia");
            entity.Property(e => e.Coddepartamento).HasColumnName("coddepartamento");
            entity.Property(e => e.Codtiposervico).HasColumnName("codtiposervico");
            entity.Property(e => e.Datachamado)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("datachamado");
            entity.Property(e => e.Dataencerrado)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("dataencerrado");
            entity.Property(e => e.Dataexecucao).HasColumnName("dataexecucao");
            entity.Property(e => e.MetodoReferencia)
                .HasColumnType("character varying")
                .HasColumnName("metodo_referencia");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.Obsfechamento).HasColumnName("obsfechamento");
            entity.Property(e => e.Origem)
                .HasMaxLength(1)
                .HasColumnName("origem");
            entity.Property(e => e.Patrimonio).HasColumnName("patrimonio");
            entity.Property(e => e.Planejamento)
                .HasDefaultValueSql("false")
                .HasColumnName("planejamento");
            entity.Property(e => e.Previsao)
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("previsao");
            entity.Property(e => e.Prioridade)
                .HasDefaultValueSql("3")
                .HasColumnName("prioridade");
            entity.Property(e => e.Ramal).HasColumnName("ramal");
            entity.Property(e => e.Recebido)
                .HasDefaultValueSql("false")
                .HasColumnName("recebido");
            entity.Property(e => e.Retornoassistencia)
                .HasComment("Data de retorno da assistencia")
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("retornoassistencia");
            entity.Property(e => e.UserPrioridade).HasColumnName("user_prioridade");
            entity.Property(e => e.Useracompanha).HasColumnName("useracompanha");
            entity.Property(e => e.Userchamado).HasColumnName("userchamado");
            entity.Property(e => e.Userexecuta).HasColumnName("userexecuta");
        });

        modelBuilder.Entity<TblOcorrChamadosReag>(entity =>
        {
            entity.HasKey(e => e.CodReag).HasName("tbl_ocorr_chamados_reag_pkey");

            entity.ToTable("tbl_ocorr_chamados_reag");

            entity.Property(e => e.CodReag).HasColumnName("cod_reag");
            entity.Property(e => e.Codigo)
                .ValueGeneratedOnAdd()
                .HasColumnName("codigo");
            entity.Property(e => e.DataAntiga)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data_antiga");
            entity.Property(e => e.DataNova)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data_nova");
            entity.Property(e => e.DataReag)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data_reag");
            entity.Property(e => e.Reaberto).HasColumnName("reaberto");
            entity.Property(e => e.Usuario).HasColumnName("usuario");
        });

        modelBuilder.Entity<TblOcorrPrioridade>(entity =>
        {
            entity.HasKey(e => e.IdPrioridade).HasName("tbl_ocorr_prioridade_pkey");

            entity.ToTable("tbl_ocorr_prioridade");

            entity.Property(e => e.IdPrioridade).HasColumnName("id_prioridade");
            entity.Property(e => e.Prioridade)
                .HasColumnType("character varying")
                .HasColumnName("prioridade");
        });

        modelBuilder.Entity<TblOcorrServico>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_ocorr_servico_pkey");

            entity.ToTable("tbl_ocorr_servico");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Ativo).HasColumnName("ativo");
            entity.Property(e => e.Coddep).HasColumnName("coddep");
            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<TblOcorrUsuario>(entity =>
        {
            entity.HasKey(e => e.Codusuario).HasName("tbl_ocorr_usuarios_pkey");

            entity.ToTable("tbl_ocorr_usuarios");

            entity.Property(e => e.Codusuario)
                .ValueGeneratedNever()
                .HasColumnName("codusuario");
        });

        modelBuilder.Entity<TblOcorreMotivo>(entity =>
        {
            entity.HasKey(e => e.Codocorrencia).HasName("tbl_ocorre_motivo_pkey");

            entity.ToTable("tbl_ocorre_motivo", tb => tb.HasComment("Motivos das ocorrencias"));

            entity.Property(e => e.Codocorrencia)
                .ValueGeneratedNever()
                .HasColumnName("codocorrencia");
            entity.Property(e => e.Motivo)
                .HasMaxLength(50)
                .HasColumnName("motivo");
        });

        modelBuilder.Entity<TblOcorreMotivoSub>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_ocorre_motivo_sub_pkey");

            entity.ToTable("tbl_ocorre_motivo_sub");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("ativo");
            entity.Property(e => e.Bloqueio)
                .HasDefaultValueSql("false")
                .HasColumnName("bloqueio");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codocorrencia).HasColumnName("codocorrencia");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Senha1)
                .HasDefaultValueSql("false")
                .HasColumnName("senha1");
            entity.Property(e => e.Senha2)
                .HasDefaultValueSql("false")
                .HasColumnName("senha2");
            entity.Property(e => e.Senha3)
                .HasDefaultValueSql("false")
                .HasColumnName("senha3");
        });

        modelBuilder.Entity<TblOcorreSenha>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_ocorre_senha_pkey");

            entity.ToTable("tbl_ocorre_senha");

            entity.HasIndex(e => e.Codusuario, "tbl_ocorre_senha_codusuario_key").IsUnique();

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblocorresenha'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Nivelsenha)
                .HasDefaultValueSql("0")
                .HasColumnName("nivelsenha");

            entity.HasOne(d => d.CodusuarioNavigation).WithOne(p => p.TblOcorreSenha)
                .HasForeignKey<TblOcorreSenha>(d => d.Codusuario)
                .HasConstraintName("tbl_ocorre_senha_codusuario_fkey");
        });

        modelBuilder.Entity<TblOcorrencium>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cp_tbl_ocorrencia");

            entity.ToTable("tbl_ocorrencia");

            entity.HasIndex(e => e.Codprepedido, "index_tbl_ocorrencia_codprepedido");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblocorrencia'::regclass)")
                .HasComment("codigo da ocorrencia")
                .HasColumnName("codigo");
            entity.Property(e => e.Codocorrencia).HasColumnName("codocorrencia");
            entity.Property(e => e.Codprepedido).HasColumnName("codprepedido");
            entity.Property(e => e.Detalhe)
                .HasMaxLength(150)
                .HasComment("Detalhe da ocorrencia")
                .HasColumnName("detalhe");

            entity.HasOne(d => d.CodprepedidoNavigation).WithMany(p => p.TblOcorrencia)
                .HasForeignKey(d => d.Codprepedido)
                .HasConstraintName("fk_codprepedido");
        });

        modelBuilder.Entity<TblOperacional>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_operacional_pkey");

            entity.ToTable("tbl_operacional");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Loja).HasColumnName("loja");
            entity.Property(e => e.Mes)
                .HasMaxLength(7)
                .HasColumnName("mes");
            entity.Property(e => e.Valorloja).HasColumnName("valorloja");
            entity.Property(e => e.Valorlojadep).HasColumnName("valorlojadep");
        });

        modelBuilder.Entity<TblOperacionalLojasPeso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_operacional_lojas_peso_pkey");

            entity.ToTable("tbl_operacional_lojas_peso", tb => tb.HasComment("fatia com que cada loja pega do operacional da loja 1."));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Percent).HasColumnName("percent");
        });

        modelBuilder.Entity<TblParcela>(entity =>
        {
            entity.HasKey(e => e.Vencimento).HasName("tbl_parcelas_pkey");

            entity.ToTable("tbl_parcelas", tb => tb.HasComment("Tabela que gera DataGrid de Parcelas"));

            entity.Property(e => e.Vencimento).HasColumnName("vencimento");
            entity.Property(e => e.Prazo).HasColumnName("prazo");
            entity.Property(e => e.Valor)
                .HasPrecision(12, 2)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<TblParcelasFinan>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_parcelas_finan_pkey");

            entity.ToTable("tbl_parcelas_finan");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(15)
                .HasColumnName("codpedido");
            entity.Property(e => e.Financeira).HasColumnName("financeira");
            entity.Property(e => e.Parcela)
                .HasMaxLength(15)
                .HasColumnName("parcela");
            entity.Property(e => e.Valor)
                .HasDefaultValueSql("0")
                .HasColumnName("valor");
            entity.Property(e => e.Vencimento).HasColumnName("vencimento");
        });

        modelBuilder.Entity<TblParcelasPrazo>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_parcelas_prazo_pkey");

            entity.ToTable("tbl_parcelas_prazo");

            entity.HasIndex(e => e.Codcliente, "index_codcliente");

            entity.HasIndex(e => e.Codpedido, "index_codpedido");

            entity.HasIndex(e => e.Codprepedido, "index_codprepedido");

            entity.HasIndex(e => e.Codusuario, "index_codusuario");

            entity.HasIndex(e => e.Pago, "index_pago");

            entity.HasIndex(e => e.Tipovenda, "index_tipovenda");

            entity.HasIndex(e => e.Vencimento, "index_vencimento");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblparcelasprazo'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Baixaparcial)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("se foi feita baixa parcial ou total")
                .HasColumnName("baixaparcial");
            entity.Property(e => e.Caixa)
                .HasMaxLength(1)
                .HasComment("Caixa que recebeu a parcela")
                .HasColumnName("caixa");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("se o pedido foi cancelado")
                .HasColumnName("cancelado");
            entity.Property(e => e.Chequepre)
                .HasComment("data do cheque pre Se pagamento for efetuado com cheque pre")
                .HasColumnName("chequepre");
            entity.Property(e => e.Classe)
                .HasMaxLength(1)
                .HasComment("qual era a classe do cliente no ato do pagamento")
                .HasColumnName("classe");
            entity.Property(e => e.ClasseAlterada)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("classe_alterada");
            entity.Property(e => e.CodReneg).HasColumnName("cod_reneg");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codfinanceira).HasColumnName("codfinanceira");
            entity.Property(e => e.Codloja)
                .HasComment("Codigo da loja que recebeu a parcela. (codigo que o caixa esta indentificado)")
                .HasColumnName("codloja");
            entity.Property(e => e.Codlojapedido)
                .HasDefaultValueSql("0")
                .HasComment("codigo da loja que efetuou o pedido")
                .HasColumnName("codlojapedido");
            entity.Property(e => e.Codpagamento)
                .HasMaxLength(35)
                .HasComment("codigo do pagamento da parcela")
                .HasColumnName("codpagamento");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(11)
                .HasColumnName("codpedido");
            entity.Property(e => e.Codprepedido)
                .HasDefaultValueSql("0")
                .HasColumnName("codprepedido");
            entity.Property(e => e.Codusuario)
                .HasDefaultValueSql("0")
                .HasComment("Codigo do Usuario que Recebeu a Parcela")
                .HasColumnName("codusuario");
            entity.Property(e => e.CodusuarioEstornado).HasColumnName("codusuario_estornado");
            entity.Property(e => e.ConfCartao)
                .HasDefaultValueSql("false")
                .HasColumnName("conf_cartao");
            entity.Property(e => e.Contratofinan)
                .HasMaxLength(15)
                .HasColumnName("contratofinan");
            entity.Property(e => e.CupomTef).HasColumnName("cupom_tef");
            entity.Property(e => e.DataEstornado).HasColumnName("data_estornado");
            entity.Property(e => e.Datapedido)
                .HasComment("Data do Pedido")
                .HasColumnName("datapedido");
            entity.Property(e => e.Datapgto)
                .HasComment("Data que foi efetuado o pagamento.")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datapgto");
            entity.Property(e => e.Descautorizado)
                .HasMaxLength(35)
                .HasColumnName("descautorizado");
            entity.Property(e => e.Desconto)
                .HasPrecision(9, 2)
                .HasDefaultValueSql("0")
                .HasComment("Valor do desconto")
                .HasColumnName("desconto");
            entity.Property(e => e.Diasatraso)
                .HasDefaultValueSql("0")
                .HasComment("Dias de atrazo ")
                .HasColumnName("diasatraso");
            entity.Property(e => e.Documento)
                .HasMaxLength(15)
                .HasColumnName("documento");
            entity.Property(e => e.Estornada)
                .HasMaxLength(65)
                .HasColumnName("estornada");
            entity.Property(e => e.Forma)
                .HasMaxLength(40)
                .HasComment("Forma pagamento")
                .HasColumnName("forma");
            entity.Property(e => e.FormaRecebido)
                .HasMaxLength(20)
                .HasColumnName("forma_recebido");
            entity.Property(e => e.IdCaixaEstorno).HasColumnName("id_caixa_estorno");
            entity.Property(e => e.IdMetodoPgto).HasColumnName("id_metodo_pgto");
            entity.Property(e => e.IdPix)
                .HasMaxLength(35)
                .HasColumnName("id_pix");
            entity.Property(e => e.Idcaixa)
                .HasComment("Codigo identificador do caixa")
                .HasColumnName("idcaixa");
            entity.Property(e => e.Inclusaospc)
                .HasMaxLength(12)
                .HasColumnName("inclusaospc");
            entity.Property(e => e.Jurodia)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasComment("Juro cobrado ao dia")
                .HasColumnName("jurodia");
            entity.Property(e => e.MetodoPgto)
                .HasMaxLength(20)
                .HasColumnName("metodo_pgto");
            entity.Property(e => e.Motdesc)
                .HasComment("Motivo de desconto solicitado pelo caixa")
                .HasColumnName("motdesc");
            entity.Property(e => e.Motdescger)
                .HasComment("motivo do desconto dado pelo gerente")
                .HasColumnName("motdescger");
            entity.Property(e => e.Motivoestorno)
                .HasMaxLength(100)
                .HasColumnName("motivoestorno");
            entity.Property(e => e.Pago)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("Pago S ou N")
                .HasColumnName("pago");
            entity.Property(e => e.Pagoparcial)
                .HasMaxLength(20)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("pagoparcial");
            entity.Property(e => e.Parcela).HasColumnName("parcela");
            entity.Property(e => e.Pgtocheque)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("pgtocheque");
            entity.Property(e => e.Protesto)
                .HasDefaultValueSql("false")
                .HasColumnName("protesto");
            entity.Property(e => e.Quantparcela)
                .HasComment("Quantidade de parcelas")
                .HasColumnName("quantparcela");
            entity.Property(e => e.Tipoparcela)
                .HasMaxLength(1)
                .HasDefaultValueSql("'I'::bpchar")
                .HasComment("se a parcela é integral ou parcial\n\nvalores I ou P")
                .HasColumnName("tipoparcela");
            entity.Property(e => e.Tipovenda)
                .HasDefaultValueSql("2")
                .HasComment("Tipo de Venda Crediario Proprio Financeira ou Cartão")
                .HasColumnName("tipovenda");
            entity.Property(e => e.TriggerClasseAlterada).HasColumnName("trigger_classe_alterada");
            entity.Property(e => e.Valor)
                .HasPrecision(9, 2)
                .HasColumnName("valor");
            entity.Property(e => e.ValorEstornado)
                .HasPrecision(9, 2)
                .HasColumnName("valor_estornado");
            entity.Property(e => e.ValorLiquidoEstorno)
                .HasPrecision(9, 2)
                .HasColumnName("valor_liquido_estorno");
            entity.Property(e => e.Valorjuro)
                .HasPrecision(8, 2)
                .HasDefaultValueSql("0")
                .HasComment("Valor do juro cobrado")
                .HasColumnName("valorjuro");
            entity.Property(e => e.Valorpagar)
                .HasPrecision(9, 2)
                .HasDefaultValueSql("0")
                .HasComment("Valor a pagar com o juro")
                .HasColumnName("valorpagar");
            entity.Property(e => e.Valorpago)
                .HasPrecision(9, 2)
                .HasDefaultValueSql("0")
                .HasComment("Valor pago com juro e desconto")
                .HasColumnName("valorpago");
            entity.Property(e => e.Vencimento).HasColumnName("vencimento");

            entity.HasOne(d => d.TipovendaNavigation).WithMany(p => p.TblParcelasPrazos)
                .HasForeignKey(d => d.Tipovenda)
                .HasConstraintName("tbltipovenda");
        });

        modelBuilder.Entity<TblParcelasPrazoOrc>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_parcelas_prazo_orc_pkey");

            entity.ToTable("tbl_parcelas_prazo_orc", tb => tb.HasComment("Parcelas dos pedidos"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Baixaparcial)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("se foi feita baixa parcial ou total")
                .HasColumnName("baixaparcial");
            entity.Property(e => e.Caixa)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasComment("Caixa que recebeu a parcela")
                .HasColumnName("caixa");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("se o pedido foi cancelado")
                .HasColumnName("cancelado");
            entity.Property(e => e.Chequepre)
                .HasComment("data do cheque pre Se pagamento for efetuado com cheque pre")
                .HasColumnName("chequepre");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codloja)
                .HasComment("Codigo da loja que recebeu a parcela. (codigo que o caixa esta indentificado)")
                .HasColumnName("codloja");
            entity.Property(e => e.Codpagamento)
                .HasMaxLength(30)
                .HasComment("codigo do pagamento da parcela")
                .HasColumnName("codpagamento");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(9)
                .HasColumnName("codpedido");
            entity.Property(e => e.Codprepedido).HasColumnName("codprepedido");
            entity.Property(e => e.Codusuario)
                .HasDefaultValueSql("0")
                .HasComment("Codigo do Usuario que Recebeu a Parcela")
                .HasColumnName("codusuario");
            entity.Property(e => e.Datapedido)
                .HasComment("Data do Pedido")
                .HasColumnName("datapedido");
            entity.Property(e => e.Datapgto)
                .HasComment("Data que foi efetuado o pagamento.")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datapgto");
            entity.Property(e => e.Descautorizado)
                .HasMaxLength(35)
                .HasColumnName("descautorizado");
            entity.Property(e => e.Desconto)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Valor do desconto")
                .HasColumnName("desconto");
            entity.Property(e => e.Diasatraso)
                .HasDefaultValueSql("0")
                .HasComment("Dias de atrazo ")
                .HasColumnName("diasatraso");
            entity.Property(e => e.Documento)
                .HasMaxLength(10)
                .HasColumnName("documento");
            entity.Property(e => e.Forma)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasComment("Forma pagamento")
                .HasColumnName("forma");
            entity.Property(e => e.Idcaixa)
                .HasComment("Codigo identificador do caixa")
                .HasColumnName("idcaixa");
            entity.Property(e => e.Jurodia)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasComment("Juro cobrado ao dia")
                .HasColumnName("jurodia");
            entity.Property(e => e.Motdesc)
                .HasComment("Motivo de desconto solicitado pelo caixa")
                .HasColumnName("motdesc");
            entity.Property(e => e.Motdescger)
                .HasComment("motivo do desconto dado pelo gerente")
                .HasColumnName("motdescger");
            entity.Property(e => e.Pago)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("Pago S ou N")
                .HasColumnName("pago");
            entity.Property(e => e.Pagoparcial)
                .HasMaxLength(20)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("pagoparcial");
            entity.Property(e => e.Parcela).HasColumnName("parcela");
            entity.Property(e => e.Pgtocheque)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("pgtocheque");
            entity.Property(e => e.Quantparcela)
                .HasComment("Quantidade de parcelas")
                .HasColumnName("quantparcela");
            entity.Property(e => e.Tipoparcela)
                .HasMaxLength(1)
                .HasDefaultValueSql("'I'::bpchar")
                .HasComment("se a parcela é integral ou parcial\n\nvalores I ou P")
                .HasColumnName("tipoparcela");
            entity.Property(e => e.Tipovenda)
                .HasComment("Tipo de Venda Crediario Proprio Financeira ou Cartão")
                .HasColumnName("tipovenda");
            entity.Property(e => e.Valor)
                .HasPrecision(12, 2)
                .HasColumnName("valor");
            entity.Property(e => e.Valorjuro)
                .HasPrecision(8, 2)
                .HasDefaultValueSql("0")
                .HasComment("Valor do juro cobrado")
                .HasColumnName("valorjuro");
            entity.Property(e => e.Valorpagar)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Valor a pagar com o juro")
                .HasColumnName("valorpagar");
            entity.Property(e => e.Valorpago)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Valor pago com juro e desconto")
                .HasColumnName("valorpago");
            entity.Property(e => e.Vencimento).HasColumnName("vencimento");

            entity.HasOne(d => d.TipovendaNavigation).WithMany(p => p.TblParcelasPrazoOrcs)
                .HasForeignKey(d => d.Tipovenda)
                .HasConstraintName("fk_tbltipovenda");
        });

        modelBuilder.Entity<TblPartilhaIcm>(entity =>
        {
            entity.HasKey(e => e.Ano).HasName("tbl_partilha_icms_pkey");

            entity.ToTable("tbl_partilha_icms");

            entity.Property(e => e.Ano)
                .ValueGeneratedNever()
                .HasColumnName("ano");
            entity.Property(e => e.UfDestino).HasColumnName("uf_destino");
        });

        modelBuilder.Entity<TblPedTrocauser>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_ped_trocauser_pkey");

            entity.ToTable("tbl_ped_trocauser");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Antes).HasColumnName("antes");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(10)
                .HasColumnName("codpedido");
            entity.Property(e => e.Datatroca)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datatroca");
            entity.Property(e => e.Depois).HasColumnName("depois");
            entity.Property(e => e.Trocadopor).HasColumnName("trocadopor");
        });

        modelBuilder.Entity<TblPedido>(entity =>
        {
            entity.HasKey(e => new { e.Codloja, e.Pedido }).HasName("tbl_pedido_pkey");

            entity.ToTable("tbl_pedido", tb => tb.HasComment("SETOR: PEDIDO\nContém todos os dados de pedidos finalizados, como datas, valores, codcliente, codprepedido, codpedido, loja, vendedor(usuário), parcelas, horário do fechamento do pedido, se o pedido foi cancelado ou não, caso sim, dados referente ao cancelamento, caixa que finalizou o pedido, quantidade de produtos.\n\n"));

            entity.HasIndex(e => e.Cancelado, "index_cancelado_tblpedido");

            entity.HasIndex(e => e.Codcliente, "index_codcliente_tblpedido");

            entity.HasIndex(e => e.Codloja, "index_codloja_tblpedido");

            entity.HasIndex(e => e.Codusuario, "index_codusuario_tblpedido");

            entity.HasIndex(e => e.Datavenda, "index_datavenda_tblpedido");

            entity.HasIndex(e => e.Letracaixa, "index_letracaixa_tblpedido");

            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Pedido)
                .HasMaxLength(11)
                .HasColumnName("pedido");
            entity.Property(e => e.Acrescimo)
                .HasPrecision(13, 2)
                .HasColumnName("acrescimo");
            entity.Property(e => e.Acrescimopmedio)
                .HasPrecision(12, 2)
                .HasColumnName("acrescimopmedio");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("cancelado");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblpedido'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(11)
                .HasComment("Codigo do Pedido Pronto")
                .HasColumnName("codpedido");
            entity.Property(e => e.Codpedidocancelado)
                .HasMaxLength(12)
                .HasComment("Codigo do pedido que foi cancelado e gerou esse pedido")
                .HasColumnName("codpedidocancelado");
            entity.Property(e => e.Codprepedido).HasColumnName("codprepedido");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Comprador)
                .HasMaxLength(60)
                .HasColumnName("comprador");
            entity.Property(e => e.Datacancelado)
                .HasComment("data que foi cancelado")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datacancelado");
            entity.Property(e => e.Dataimp)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataimp");
            entity.Property(e => e.Datavenda).HasColumnName("datavenda");
            entity.Property(e => e.Desconto)
                .HasPrecision(13, 2)
                .HasColumnName("desconto");
            entity.Property(e => e.EntrouP)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("entrou_p");
            entity.Property(e => e.EntrouPData).HasColumnName("entrou_p_data");
            entity.Property(e => e.Hora).HasColumnName("hora");
            entity.Property(e => e.Horafecha)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("horafecha");
            entity.Property(e => e.Idcaixa).HasColumnName("idcaixa");
            entity.Property(e => e.Imp)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("imp");
            entity.Property(e => e.ImpDep)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("imp_dep");
            entity.Property(e => e.Letracaixa)
                .HasMaxLength(1)
                .HasColumnName("letracaixa");
            entity.Property(e => e.Motivocancel)
                .HasComment("Motivo do cancelamento")
                .HasColumnName("motivocancel");
            entity.Property(e => e.Novopedido)
                .HasMaxLength(9)
                .HasComment("Codigo do novo pedido se esse pedido for cancelado")
                .HasColumnName("novopedido");
            entity.Property(e => e.Parcelas).HasColumnName("parcelas");
            entity.Property(e => e.Pedfechado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("Quando esse campo recebe valor 'S' dispara o codigo do pedido para as tbl_parcelas_prazo e tbl_sub_pedido.")
                .HasColumnName("pedfechado");
            entity.Property(e => e.ProdNotaCancel)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasComment("campo gerado apenas para gerar produtos da nota de cancelanento dos pedido antigos que for cancelado.\n\nquando o campo for 'N' e receber o valor 'S' gera os produtos da nota fiscal")
                .HasColumnName("prod_nota_cancel");
            entity.Property(e => e.Produtos)
                .HasDefaultValueSql("0")
                .HasColumnName("produtos");
            entity.Property(e => e.ProdutosImp)
                .HasDefaultValueSql("0")
                .HasColumnName("produtos_imp");
            entity.Property(e => e.Taxa).HasColumnName("taxa");
            entity.Property(e => e.Tipovenda).HasColumnName("tipovenda");
            entity.Property(e => e.Totalpagar)
                .HasPrecision(12, 2)
                .HasColumnName("totalpagar");
            entity.Property(e => e.Totalproduto)
                .HasPrecision(13, 2)
                .HasColumnName("totalproduto");
            entity.Property(e => e.Totalvenda)
                .HasPrecision(13, 2)
                .HasColumnName("totalvenda");
            entity.Property(e => e.UserImpDep)
                .HasMaxLength(150)
                .HasColumnName("user_imp_dep");
            entity.Property(e => e.Usuario)
                .HasMaxLength(30)
                .HasColumnName("usuario");
            entity.Property(e => e.Usuariocancel)
                .HasMaxLength(55)
                .HasComment("usuario que cancelou pedido")
                .HasColumnName("usuariocancel");
            entity.Property(e => e.Usuarioimp)
                .HasMaxLength(40)
                .HasColumnName("usuarioimp");
            entity.Property(e => e.ValorFrete)
                .HasPrecision(9, 2)
                .HasColumnName("valor_frete");

            entity.HasOne(d => d.CodusuarioNavigation).WithMany(p => p.TblPedidos)
                .HasForeignKey(d => d.Codusuario)
                .HasConstraintName("tbl_pedido_codusuario_fkey");
        });

        modelBuilder.Entity<TblPedidoCompra>(entity =>
        {
            entity.HasKey(e => e.Codpedidocompra).HasName("pk_tblpedidocompra");

            entity.ToTable("tbl_pedido_compra", tb => tb.HasComment("SETOR: COMPRAS, INCLUSÃO\nDados referentes ao pedido de compra, com o codfornecedor, valor do pedido, data do pedido, database, faturamento, número de parcelas, intervalo entre as parcelas, codusuario que lançou o pedido, previsão de entrega (utilizado no setor de inclusão e recebimento do depósito), se o pedido já foi entregue ou não, quem foi o comprador e observações e detalhes adicionais.\n"));

            entity.Property(e => e.Codpedidocompra)
                .HasDefaultValueSql("nextval('seq_tblpedidocompra'::regclass)")
                .HasColumnName("codpedidocompra");
            entity.Property(e => e.Alterou)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("alterou");
            entity.Property(e => e.CodProjetoVp)
                .HasDefaultValueSql("0")
                .HasColumnName("cod_projeto_vp");
            entity.Property(e => e.Coddivdetalhe).HasColumnName("coddivdetalhe");
            entity.Property(e => e.Coddivisao)
                .HasComment("Codigo da Divisão do Pedido")
                .HasColumnName("coddivisao");
            entity.Property(e => e.Codfornecedor)
                .HasComment("Codigo Fornecedor")
                .HasColumnName("codfornecedor");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.CodpedidoAnterior)
                .HasDefaultValueSql("0")
                .HasColumnName("codpedido_anterior");
            entity.Property(e => e.Codtransportadora).HasColumnName("codtransportadora");
            entity.Property(e => e.Codusuario)
                .HasComment("Codigo do Usuario")
                .HasColumnName("codusuario");
            entity.Property(e => e.Codusuariofechou)
                .HasComment("Codigo do usuario que fechou o recebimento")
                .HasColumnName("codusuariofechou");
            entity.Property(e => e.ComentarioDesconto)
                .HasMaxLength(500)
                .HasColumnName("comentario_desconto");
            entity.Property(e => e.ComentarioDevolucao)
                .HasMaxLength(500)
                .HasColumnName("comentario_devolucao");
            entity.Property(e => e.Comprador)
                .HasMaxLength(20)
                .HasComment("Comprador ")
                .HasColumnName("comprador");
            entity.Property(e => e.Database)
                .HasComment("Data Base para Vencimento")
                .HasColumnName("database");
            entity.Property(e => e.Datafechamento)
                .HasComment("Data do Fechamento do Recebimento")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datafechamento");
            entity.Property(e => e.Datapedido)
                .HasComment("Data do fechamento do Pedido")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datapedido");
            entity.Property(e => e.Desconto).HasColumnName("desconto");
            entity.Property(e => e.Devolucao).HasColumnName("devolucao");
            entity.Property(e => e.Documento)
                .HasMaxLength(999)
                .HasColumnName("documento");
            entity.Property(e => e.Entregue)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("entregue");
            entity.Property(e => e.Faturamento)
                .HasComment("Data de Previsao de Faturamento")
                .HasColumnName("faturamento");
            entity.Property(e => e.IdChamado).HasColumnName("id_chamado");
            entity.Property(e => e.IdPedidoDebito)
                .HasDefaultValueSql("0")
                .HasColumnName("id_pedido_debito");
            entity.Property(e => e.Intervalo)
                .HasComment("Dias entre as parcelas")
                .HasColumnName("intervalo");
            entity.Property(e => e.Nparcelas)
                .HasComment("Numero de Parcelas par Pagamento")
                .HasColumnName("nparcelas");
            entity.Property(e => e.Obs)
                .HasComment("Observações")
                .HasColumnName("obs");
            entity.Property(e => e.Pedcompleto)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("Pedido completo")
                .HasColumnName("pedcompleto");
            entity.Property(e => e.PedidoFornecedor)
                .HasMaxLength(50)
                .HasColumnName("pedido_fornecedor");
            entity.Property(e => e.Pedidocredito)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("pedidocredito");
            entity.Property(e => e.Prazomedio)
                .HasComment("Prazo medio de Pagamento")
                .HasColumnName("prazomedio");
            entity.Property(e => e.Preventrega)
                .HasComment("Previsao de Entrega Data")
                .HasColumnName("preventrega");
            entity.Property(e => e.Preventregadias)
                .HasComment("Previsao de Entrega em Dias")
                .HasColumnName("preventregadias");
            entity.Property(e => e.Protocolo).HasColumnName("protocolo");
            entity.Property(e => e.Situacao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("Situação do Pedido, Aberto ou Fechado.")
                .HasColumnName("situacao");
            entity.Property(e => e.Status)
                .HasMaxLength(8)
                .HasColumnName("status");
            entity.Property(e => e.TipoPedido).HasColumnName("tipo_pedido");
            entity.Property(e => e.Transportadora)
                .HasMaxLength(50)
                .HasColumnName("transportadora");
            entity.Property(e => e.UfDestino)
                .HasMaxLength(2)
                .HasColumnName("uf_destino");
            entity.Property(e => e.Vlrpedido)
                .HasComment("Valor Total do Pedido")
                .HasColumnName("vlrpedido");
            entity.Property(e => e.Vlrrecebido)
                .HasDefaultValueSql("0")
                .HasComment("Valor das mercadorias Recebidas")
                .HasColumnName("vlrrecebido");
            entity.Property(e => e.Vp)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("vp");

            entity.HasOne(d => d.CodfornecedorNavigation).WithMany(p => p.TblPedidoCompras)
                .HasForeignKey(d => d.Codfornecedor)
                .HasConstraintName("fk_fornecedor");

            entity.HasOne(d => d.CodusuarioNavigation).WithMany(p => p.TblPedidoCompras)
                .HasForeignKey(d => d.Codusuario)
                .HasConstraintName("fk_usuario");
        });

        modelBuilder.Entity<TblPedidoCompraParc>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cp_tblpedidocompraparc");

            entity.ToTable("tbl_pedido_compra_parc", tb => tb.HasComment("SETOR: COMPRAS, INCLUSÃO\nContém as parcelas dos pedidos de compra e seus respectivos detalhes, como valor e vencimento. Esta tabela está relacionada com a tbl_pedido_compra. \n"));

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblpedidocompraparc'::regclass)")
                .HasComment("Codigo Operacao")
                .HasColumnName("codigo");
            entity.Property(e => e.Codpedidocompra)
                .HasComment("Codigo do Pedido de Compra")
                .HasColumnName("codpedidocompra");
            entity.Property(e => e.Entregue)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("entregue");
            entity.Property(e => e.Parcela)
                .HasMaxLength(7)
                .HasColumnName("parcela");
            entity.Property(e => e.Prazo)
                .HasComment("Prazo de Pagamento")
                .HasColumnName("prazo");
            entity.Property(e => e.Tipo)
                .HasDefaultValueSql("1")
                .HasColumnName("tipo");
            entity.Property(e => e.Valorparcela)
                .HasComment("Valor da Parcela")
                .HasColumnName("valorparcela");
            entity.Property(e => e.Vencimento)
                .HasComment("Data do Vencimento")
                .HasColumnName("vencimento");
        });

        modelBuilder.Entity<TblPedidoCompraProrr>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_pedido_compra_obs_pkey");

            entity.ToTable("tbl_pedido_compra_prorr", tb => tb.HasComment("SETOR: COMPRAS, INCLUSÃO\nHistórico de prorrogação de entrega (recebimento)"));

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('tbl_pedido_compra_obs_codigo_seq'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Codpedidocompra).HasColumnName("codpedidocompra");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.PrevAnterior).HasColumnName("prev_anterior");
            entity.Property(e => e.PrevAtual).HasColumnName("prev_atual");
        });

        modelBuilder.Entity<TblPedidoCompraR>(entity =>
        {
            entity.HasKey(e => e.Codrecebimento).HasName("cp_tblpedidocompra_r");

            entity.ToTable("tbl_pedido_compra_r", tb => tb.HasComment("SETOR: COMPRAS, INCLUSÃO\nContém informações de pedidos de compra que tiveram o recebimento fechado pelo setor de inclusão. Possui data e hora do fechamento do recebimento, data do faturamento, data da entrega, valor do pedido e código do pedido de compra.\n"));

            entity.HasIndex(e => e.Situacao, "index_situacao");

            entity.Property(e => e.Codrecebimento)
                .HasDefaultValueSql("nextval('seq_tblpedidocompra_r'::regclass)")
                .HasComment("Codigo Da Operação")
                .HasColumnName("codrecebimento");
            entity.Property(e => e.Codpedidocompra)
                .HasComment("Codigo do Pedido de Compra")
                .HasColumnName("codpedidocompra");
            entity.Property(e => e.Codusuario)
                .HasComment("Codigo do Usuario da Operação")
                .HasColumnName("codusuario");
            entity.Property(e => e.Dataentrega)
                .HasComment("Data da Entrega")
                .HasColumnName("dataentrega");
            entity.Property(e => e.Datafechareceb)
                .HasComment("Data do fechamento do Recebimento")
                .HasColumnName("datafechareceb");
            entity.Property(e => e.Faturamento)
                .HasComment("Data do Faturamento")
                .HasColumnName("faturamento");
            entity.Property(e => e.PrazoMedio)
                .HasComment("Prazo medio do Pedido Entregue")
                .HasColumnName("Prazo medio");
            entity.Property(e => e.Situacao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("situacao");
            entity.Property(e => e.Vlrpedido)
                .HasComment("Valor do Pedido Entregue")
                .HasColumnName("vlrpedido");

            entity.HasOne(d => d.CodpedidocompraNavigation).WithMany(p => p.TblPedidoCompraRs)
                .HasForeignKey(d => d.Codpedidocompra)
                .HasConstraintName("fk_codpedidocompra");
        });

        modelBuilder.Entity<TblPedidoEx>(entity =>
        {
            entity.HasKey(e => e.Codpedido).HasName("tbl_pedido_ex_pkey");

            entity.ToTable("tbl_pedido_ex", tb => tb.HasComment("SETOR: FINANCEIRO, PEDIDO\nContém valores de crédito de estornos de pedidos cancelados. \n"));

            entity.Property(e => e.Codpedido)
                .HasMaxLength(9)
                .IsFixedLength()
                .HasComment("codigo do pedido estornado")
                .HasColumnName("codpedido");
            entity.Property(e => e.Utilizado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("Se o credito do cliente ja foi utilizado")
                .HasColumnName("utilizado");
            entity.Property(e => e.Valorcredito)
                .HasPrecision(12, 2)
                .HasComment("Valor do credito do cliente")
                .HasColumnName("valorcredito");
        });

        modelBuilder.Entity<TblPedidoGarantium>(entity =>
        {
            entity.HasKey(e => e.Codpedido).HasName("tbl_pedido_garantia_pkey");

            entity.ToTable("tbl_pedido_garantia");

            entity.Property(e => e.Codpedido)
                .HasMaxLength(12)
                .HasColumnName("codpedido");
            entity.Property(e => e.Bairro)
                .HasMaxLength(40)
                .HasColumnName("bairro");
            entity.Property(e => e.Cep)
                .HasMaxLength(10)
                .HasColumnName("cep");
            entity.Property(e => e.Cidade)
                .HasMaxLength(60)
                .HasColumnName("cidade");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Complemento)
                .HasMaxLength(30)
                .HasColumnName("complemento");
            entity.Property(e => e.Cpf)
                .HasMaxLength(15)
                .HasColumnName("cpf");
            entity.Property(e => e.Datacompra)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("datacompra");
            entity.Property(e => e.Dataimp)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataimp");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .HasColumnName("email");
            entity.Property(e => e.EmissaoSeguro)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("emissao_seguro");
            entity.Property(e => e.Endereco)
                .HasMaxLength(50)
                .HasColumnName("endereco");
            entity.Property(e => e.Fone)
                .HasMaxLength(16)
                .HasColumnName("fone");
            entity.Property(e => e.Numero)
                .HasMaxLength(15)
                .HasColumnName("numero");
            entity.Property(e => e.Segurado)
                .HasMaxLength(60)
                .HasColumnName("segurado");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("uf");
            entity.Property(e => e.Userimp)
                .HasMaxLength(100)
                .HasDefaultValueSql("\"current_user\"()")
                .HasColumnName("userimp");
        });

        modelBuilder.Entity<TblPedidoPrazoApagar>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cp_tbl_pedido_prazo");

            entity.ToTable("tbl_pedido_prazo_APAGAR");

            entity.Property(e => e.Codigo)
                .ValueGeneratedNever()
                .HasColumnName("codigo");
            entity.Property(e => e.Ativa)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("ativa");
            entity.Property(e => e.Codpedido)
                .HasComment("Codigo do Pedido")
                .HasColumnName("codpedido");
            entity.Property(e => e.Codprepedido).HasColumnName("codprepedido");
            entity.Property(e => e.Formapagamento)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasComment("Forma de pagamento DI DP CH EX")
                .HasColumnName("formapagamento");
            entity.Property(e => e.Valor)
                .HasPrecision(11, 2)
                .HasComment("Valor da duplicata")
                .HasColumnName("valor");
            entity.Property(e => e.Vencimento)
                .HasComment("Vencimento da duplicata")
                .HasColumnName("vencimento");

            entity.HasOne(d => d.CodprepedidoNavigation).WithMany(p => p.TblPedidoPrazoApagars)
                .HasForeignKey(d => d.Codprepedido)
                .HasConstraintName("fk_codprepedido");
        });

        modelBuilder.Entity<TblPermisso>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cp_tblpermissoes");

            entity.ToTable("tbl_permissoes");

            entity.HasIndex(e => e.Codusuario, "index_tbl_permissao_codusuario");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblpermissoes'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Codformulario).HasColumnName("codformulario");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("('now'::text)::timestamp(6) without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Especial)
                .HasDefaultValueSql("false")
                .HasColumnName("especial");
            entity.Property(e => e.Gravar)
                .HasDefaultValueSql("false")
                .HasColumnName("gravar");
            entity.Property(e => e.Ler)
                .HasDefaultValueSql("false")
                .HasColumnName("ler");
            entity.Property(e => e.Negar)
                .HasDefaultValueSql("true")
                .HasColumnName("negar");
            entity.Property(e => e.Usuario)
                .HasMaxLength(40)
                .HasDefaultValueSql("\"current_user\"()")
                .HasColumnName("usuario");

            entity.HasOne(d => d.CodformularioNavigation).WithMany(p => p.TblPermissos)
                .HasForeignKey(d => d.Codformulario)
                .HasConstraintName("fk_codformulario");

            entity.HasOne(d => d.CodusuarioNavigation).WithMany(p => p.TblPermissos)
                .HasForeignKey(d => d.Codusuario)
                .HasConstraintName("fk_codusuario");
        });

        modelBuilder.Entity<TblPermissoesEspeciai>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_permissoes_especiais_pkey");

            entity.ToTable("tbl_permissoes_especiais", tb => tb.HasComment("nesta tabela encontram-se permissões especiais que fogem do padrão negar, ler e gravar."));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Departamentos).HasColumnName("departamentos");
            entity.Property(e => e.Descricao).HasColumnName("descricao");
            entity.Property(e => e.Frm)
                .HasMaxLength(50)
                .HasColumnName("frm");
            entity.Property(e => e.Usuarios).HasColumnName("usuarios");
        });

        modelBuilder.Entity<TblPesquisa>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_pesquisa_pkey1");

            entity.ToTable("tbl_pesquisa");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('tbl_pesquisa_codigo_seq1'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Pesquisa)
                .HasMaxLength(50)
                .HasColumnName("pesquisa");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'O'::bpchar")
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TblPesquisaQuest>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_pesquisa_quest_pkey");

            entity.ToTable("tbl_pesquisa_quest");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("ativo");
            entity.Property(e => e.Detalhe).HasColumnName("detalhe");
            entity.Property(e => e.Questao)
                .HasMaxLength(70)
                .HasColumnName("questao");
            entity.Property(e => e.Resposta)
                .HasMaxLength(1)
                .HasDefaultValueSql("'M'::bpchar")
                .HasComment("M = Multipla escolha\nD = Disertativa")
                .HasColumnName("resposta");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'P'::bpchar")
                .HasComment("P = pessoal\nE = empresa")
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TblPesquisaResp>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_pesquisa_resp_pkey");

            entity.ToTable("tbl_pesquisa_resp");

            entity.HasIndex(e => e.Resposta, "index_resposta_tbl_pesquisa_resp");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codigopesquisa).HasColumnName("codigopesquisa");
            entity.Property(e => e.Codpesquisa).HasColumnName("codpesquisa");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Ponto).HasColumnName("ponto");
            entity.Property(e => e.Questao).HasColumnName("questao");
            entity.Property(e => e.Resposta).HasColumnName("resposta");
        });

        modelBuilder.Entity<TblPesquisaUser>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_pesquisa_pkey");

            entity.ToTable("tbl_pesquisa_user");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('tbl_pesquisa_codigo_seq'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Codpesquisa).HasColumnName("codpesquisa");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Datafim)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datafim");
            entity.Property(e => e.Datainicio)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datainicio");
            entity.Property(e => e.Pesquisa)
                .HasMaxLength(50)
                .HasColumnName("pesquisa");
            entity.Property(e => e.Useravaliado).HasColumnName("useravaliado");
        });

        modelBuilder.Entity<TblPixChave>(entity =>
        {
            entity.HasKey(e => e.Codloja).HasName("tbl_chave_pix_pkey");

            entity.ToTable("tbl_pix_chave");

            entity.Property(e => e.Codloja)
                .ValueGeneratedNever()
                .HasColumnName("codloja");
            entity.Property(e => e.Chave)
                .HasMaxLength(77)
                .HasColumnName("chave");
            entity.Property(e => e.Secret)
                .HasMaxLength(64)
                .HasColumnName("secret");
        });

        modelBuilder.Entity<TblPixCobranca>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_pix_cobranca_pkey");

            entity.ToTable("tbl_pix_cobranca");

            entity.Property(e => e.Id)
                .HasMaxLength(35)
                .HasColumnName("id");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.CpfCnpjDevedor)
                .HasMaxLength(14)
                .HasColumnName("cpf_cnpj_devedor");
            entity.Property(e => e.Criacao).HasColumnName("criacao");
            entity.Property(e => e.Qrcode).HasColumnName("qrcode");
            entity.Property(e => e.Sequencia)
                .ValueGeneratedOnAdd()
                .HasColumnName("sequencia");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Valor)
                .HasPrecision(10, 2)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<TblPixDevolucao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_pix_devolucao_pkey");

            entity.ToTable("tbl_pix_devolucao");

            entity.Property(e => e.Id)
                .HasMaxLength(35)
                .HasColumnName("id");
            entity.Property(e => e.DataSolicitacao)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_solicitacao");
            entity.Property(e => e.EndToEndId)
                .HasMaxLength(35)
                .HasColumnName("end_to_end_id");
            entity.Property(e => e.IdCobranca)
                .HasMaxLength(35)
                .HasColumnName("id_cobranca");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .HasColumnName("usuario");
            entity.Property(e => e.Valor)
                .HasPrecision(9, 2)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<TblPixFilaParcela>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_baixa_parcela_pix_pkey");

            entity.ToTable("tbl_pix_fila_parcela");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Classe)
                .HasMaxLength(1)
                .HasColumnName("classe");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.CodigoParcelaPrazo).HasColumnName("codigo_parcela_prazo");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.DataProcessado)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_processado");
            entity.Property(e => e.DataSolicitado)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_solicitado");
            entity.Property(e => e.DiasAtraso).HasColumnName("dias_atraso");
            entity.Property(e => e.ValorPagar)
                .HasPrecision(9, 2)
                .HasColumnName("valor_pagar");
            entity.Property(e => e.ValorPago)
                .HasPrecision(9, 2)
                .HasColumnName("valor_pago");
            entity.Property(e => e.ValorParcela)
                .HasPrecision(9, 2)
                .HasColumnName("valor_parcela");
            entity.Property(e => e.ValorRecebido)
                .HasPrecision(9, 2)
                .HasColumnName("valor_recebido");
            entity.Property(e => e.ValorRecebido1)
                .HasPrecision(9, 2)
                .HasColumnName("valor_recebido1");
        });

        modelBuilder.Entity<TblPixOcorrencium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_pix_ocorrencia_pkey");

            entity.ToTable("tbl_pix_ocorrencia");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Caminho)
                .HasMaxLength(200)
                .HasColumnName("caminho");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .HasColumnName("codigo");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Mensagem).HasColumnName("mensagem");
            entity.Property(e => e.Ocorrencia)
                .HasMaxLength(30)
                .HasColumnName("ocorrencia");
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .HasColumnName("usuario");
            entity.Property(e => e.Versao)
                .HasMaxLength(10)
                .HasColumnName("versao");
        });

        modelBuilder.Entity<TblPosicao>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_posicao_pkey");

            entity.ToTable("tbl_posicao");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Coluna).HasColumnName("coluna");
            entity.Property(e => e.DataHora).HasColumnName("data_hora");
            entity.Property(e => e.Deposito).HasColumnName("deposito");
            entity.Property(e => e.Lado)
                .HasMaxLength(1)
                .HasColumnName("lado");
            entity.Property(e => e.Linha)
                .HasMaxLength(1)
                .HasColumnName("linha");
            entity.Property(e => e.Rua)
                .HasMaxLength(1)
                .HasColumnName("rua");
            entity.Property(e => e.Tamanho).HasColumnName("tamanho");
            entity.Property(e => e.Usuario).HasColumnName("usuario");
        });

        modelBuilder.Entity<TblPosicaoProd>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_posicao_prod_pkey");

            entity.ToTable("tbl_posicao_prod");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.CodPosicao).HasColumnName("cod_posicao");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(20)
                .HasColumnName("codproduto");
            entity.Property(e => e.DataHora).HasColumnName("data_hora");
            entity.Property(e => e.Usuario).HasColumnName("usuario");

            entity.HasOne(d => d.CodPosicaoNavigation).WithMany(p => p.TblPosicaoProds)
                .HasForeignKey(d => d.CodPosicao)
                .HasConstraintName("tbl_posicao_prod_cod_posicao_fkey");
        });

        modelBuilder.Entity<TblPrePedido>(entity =>
        {
            entity.HasKey(e => e.Codprepedido).HasName("cp_pedido");

            entity.ToTable("tbl_pre_pedido");

            entity.HasIndex(e => e.Impresso, "indes_impresso");

            entity.HasIndex(e => e.Datavenda, "index_data");

            entity.HasIndex(e => e.Pedidofechado, "index_fechamento");

            entity.HasIndex(e => e.Codcliente, "index_tblprepedido_codcliente");

            entity.Property(e => e.Codprepedido)
                .HasDefaultValueSql("nextval('seq_tblprepedido'::regclass)")
                .HasComment("Codigo do Pré Pedido")
                .HasColumnName("codprepedido");
            entity.Property(e => e.Acrescimo)
                .HasPrecision(13, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("acrescimo");
            entity.Property(e => e.Acrescimopmedio)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("Acrescimo Prazo medio")
                .HasColumnName("acrescimopmedio");
            entity.Property(e => e.Aprovado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasComment("se o cadastro esta aprovado ou não")
                .HasColumnName("aprovado");
            entity.Property(e => e.Bairro)
                .HasMaxLength(100)
                .HasColumnName("bairro");
            entity.Property(e => e.BandeiraCartao).HasColumnName("bandeira_cartao");
            entity.Property(e => e.Cancelamento)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("cancelamento");
            entity.Property(e => e.Cep)
                .HasMaxLength(20)
                .HasColumnName("cep");
            entity.Property(e => e.Cidade)
                .HasMaxLength(100)
                .HasColumnName("cidade");
            entity.Property(e => e.Cliente)
                .HasMaxLength(80)
                .HasColumnName("cliente");
            entity.Property(e => e.Codbairro).HasColumnName("codbairro");
            entity.Property(e => e.Codcidade).HasColumnName("codcidade");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codpedidocancelado)
                .HasMaxLength(11)
                .HasComment("codigo do pedido cancelado que gerou esse novo pedido")
                .HasColumnName("codpedidocancelado");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Codusuariocaixa).HasColumnName("codusuariocaixa");
            entity.Property(e => e.Comprador)
                .HasMaxLength(100)
                .HasColumnName("comprador");
            entity.Property(e => e.Cpf)
                .HasMaxLength(20)
                .HasColumnName("cpf");
            entity.Property(e => e.Dataabertura)
                .HasDefaultValueSql("('now'::text)::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataabertura");
            entity.Property(e => e.Datavenda).HasColumnName("datavenda");
            entity.Property(e => e.Descmax).HasColumnName("descmax");
            entity.Property(e => e.Descnormal).HasColumnName("descnormal");
            entity.Property(e => e.Desconto)
                .HasPrecision(13, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("desconto");
            entity.Property(e => e.Descprazomedio).HasColumnName("descprazomedio");
            entity.Property(e => e.Diasexcedido).HasColumnName("diasexcedido");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Endereco)
                .HasMaxLength(100)
                .HasColumnName("endereco");
            entity.Property(e => e.Fone)
                .HasMaxLength(30)
                .HasColumnName("fone");
            entity.Property(e => e.Ganho)
                .HasDefaultValueSql("0")
                .HasComment("ganho obtido a mais no pedido entre diferenças de taxas")
                .HasColumnName("ganho");
            entity.Property(e => e.Hora).HasColumnName("hora");
            entity.Property(e => e.Horasenha1)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("horasenha1");
            entity.Property(e => e.Horasenha2)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("horasenha2");
            entity.Property(e => e.Horasenha3)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("horasenha3");
            entity.Property(e => e.Impresso)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("Pedido confirmado ou não")
                .HasColumnName("impresso");
            entity.Property(e => e.Indenizacao).HasColumnName("indenizacao");
            entity.Property(e => e.InfAddNfe)
                .HasMaxLength(250)
                .HasColumnName("inf_add_nfe");
            entity.Property(e => e.Letracaixa)
                .HasMaxLength(1)
                .HasComment("Letra do Caixa que imprimiu")
                .HasColumnName("letracaixa");
            entity.Property(e => e.NContrato).HasColumnName("n_contrato");
            entity.Property(e => e.NContratoDigitado).HasColumnName("n_contrato_digitado");
            entity.Property(e => e.Negado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("Se cadastro estiver negado e pedido não for a vista")
                .HasColumnName("negado");
            entity.Property(e => e.Numero)
                .HasMaxLength(45)
                .HasColumnName("numero");
            entity.Property(e => e.Obssenhacancel).HasColumnName("obssenhacancel");
            entity.Property(e => e.Obssenhacancelassit).HasColumnName("obssenhacancelassit");
            entity.Property(e => e.OcorrDesc)
                .HasDefaultValueSql("0")
                .HasComment("Se desconto for maior do que o permitido")
                .HasColumnName("ocorr_desc");
            entity.Property(e => e.Ocorrencia)
                .HasDefaultValueSql("0")
                .HasColumnName("ocorrencia");
            entity.Property(e => e.Parcelas)
                .HasComment("Quantidade de Parcelas")
                .HasColumnName("parcelas");
            entity.Property(e => e.Pedidofechado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("pedidofechado");
            entity.Property(e => e.PesquisaPublicidadecliente)
                .HasMaxLength(100)
                .HasColumnName("pesquisa_publicidadecliente");
            entity.Property(e => e.Prazopermitido).HasColumnName("prazopermitido");
            entity.Property(e => e.Rg)
                .HasMaxLength(20)
                .HasColumnName("rg");
            entity.Property(e => e.Senha1)
                .HasMaxLength(35)
                .HasComment("Quem forneceu senha 1")
                .HasColumnName("senha1");
            entity.Property(e => e.Senha1obs).HasColumnName("senha1obs");
            entity.Property(e => e.Senha2)
                .HasMaxLength(35)
                .HasColumnName("senha2");
            entity.Property(e => e.Senha2obs).HasColumnName("senha2obs");
            entity.Property(e => e.Senha3)
                .HasMaxLength(35)
                .HasColumnName("senha3");
            entity.Property(e => e.Senha3obs).HasColumnName("senha3obs");
            entity.Property(e => e.Senhacancel)
                .HasDefaultValueSql("0")
                .HasColumnName("senhacancel");
            entity.Property(e => e.Senhacancelassit)
                .HasDefaultValueSql("0")
                .HasColumnName("senhacancelassit");
            entity.Property(e => e.Senhamaster)
                .HasDefaultValueSql("0")
                .HasColumnName("senhamaster");
            entity.Property(e => e.SolContrato)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("solicitar contrato de venda\n\nN - não nescessario.\nS - solicitar contrato\nI - contrato ja impresso.")
                .HasColumnName("sol_contrato");
            entity.Property(e => e.Taxa).HasColumnName("taxa");
            entity.Property(e => e.Tipocadastro)
                .HasMaxLength(1)
                .HasDefaultValueSql("'F'::bpchar")
                .HasColumnName("tipocadastro");
            entity.Property(e => e.Tipocancelamento)
                .HasDefaultValueSql("0")
                .HasColumnName("tipocancelamento");
            entity.Property(e => e.Tipocomprador)
                .HasMaxLength(1)
                .HasComment("T = TITULAR\nC = CONJUGE")
                .HasColumnName("tipocomprador");
            entity.Property(e => e.Tipovenda)
                .HasDefaultValueSql("0")
                .HasComment("Tipo de Venda - Crediario Loja Cartão ou Financeira")
                .HasColumnName("tipovenda");
            entity.Property(e => e.Totalpagar)
                .HasPrecision(12, 2)
                .HasColumnName("totalpagar");
            entity.Property(e => e.Totalproduto)
                .HasPrecision(13, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("totalproduto");
            entity.Property(e => e.Totalvenda)
                .HasPrecision(13, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("totalvenda");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
            entity.Property(e => e.Usersenhacancel)
                .HasMaxLength(35)
                .HasColumnName("usersenhacancel");
            entity.Property(e => e.Usersenhacancelassit).HasColumnName("usersenhacancelassit");
            entity.Property(e => e.UsuarioCancel)
                .HasDefaultValueSql("0")
                .HasColumnName("usuario_cancel");
            entity.Property(e => e.Utilizarcheque)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("utilizarcheque");
            entity.Property(e => e.ValorFrete)
                .HasPrecision(9, 2)
                .HasColumnName("valor_frete");
            entity.Property(e => e.Valorcorreto).HasColumnName("valorcorreto");
            entity.Property(e => e.VendaEcManual)
                .HasComment("boolean para verificar se o prepedido é de uma venda e-commerce realizada manualmente.")
                .HasColumnName("venda_ec_manual");

            entity.HasOne(d => d.CodclienteNavigation).WithMany(p => p.TblPrePedidos)
                .HasForeignKey(d => d.Codcliente)
                .HasConstraintName("fk_tblcliente");

            entity.HasOne(d => d.CodlojaNavigation).WithMany(p => p.TblPrePedidos)
                .HasForeignKey(d => d.Codloja)
                .HasConstraintName("fk_tblloja");

            entity.HasOne(d => d.CodusuarioNavigation).WithMany(p => p.TblPrePedidos)
                .HasForeignKey(d => d.Codusuario)
                .HasConstraintName("fk_tblusuario");

            entity.HasOne(d => d.TipovendaNavigation).WithMany(p => p.TblPrePedidos)
                .HasForeignKey(d => d.Tipovenda)
                .HasConstraintName("fk_tbltipovenda");
        });

        modelBuilder.Entity<TblPrePedidoOrc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_pre_pedido_orc");

            entity.Property(e => e.Acrescimo)
                .HasPrecision(13, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("acrescimo");
            entity.Property(e => e.Acrescimopmedio)
                .HasPrecision(12, 2)
                .HasComment("Acrescimo Prazo medio")
                .HasColumnName("acrescimopmedio");
            entity.Property(e => e.Aprovado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasComment("se o cadastro esta aprovado ou não")
                .HasColumnName("aprovado");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codpedidocancelado)
                .HasMaxLength(9)
                .IsFixedLength()
                .HasComment("codigo do pedido cancelado que gerou esse novo pedido")
                .HasColumnName("codpedidocancelado");
            entity.Property(e => e.Codprepedido)
                .HasDefaultValueSql("nextval('tbl_pre_pedido_orc_prepedido_seq'::regclass)")
                .HasComment("Codigo do Pré Pedido")
                .HasColumnName("codprepedido");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Codusuariocaixa).HasColumnName("codusuariocaixa");
            entity.Property(e => e.Comprador)
                .HasMaxLength(40)
                .HasColumnName("comprador");
            entity.Property(e => e.Datavenda).HasColumnName("datavenda");
            entity.Property(e => e.Desconto)
                .HasPrecision(13, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("desconto");
            entity.Property(e => e.Hora)
                .HasColumnType("time with time zone")
                .HasColumnName("hora");
            entity.Property(e => e.Horasenha1).HasColumnName("horasenha1");
            entity.Property(e => e.Horasenha2).HasColumnName("horasenha2");
            entity.Property(e => e.Horasenha3).HasColumnName("horasenha3");
            entity.Property(e => e.Impresso)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("Pedido confirmado ou não")
                .HasColumnName("impresso");
            entity.Property(e => e.Letracaixa)
                .HasMaxLength(1)
                .HasComment("Letra do Caixa que imprimiu")
                .HasColumnName("letracaixa");
            entity.Property(e => e.Negado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("Se cadastro estiver negado e pedido não for a vista")
                .HasColumnName("negado");
            entity.Property(e => e.OcorrDesc)
                .HasDefaultValueSql("0")
                .HasComment("Se desconto for maior do que o permitido")
                .HasColumnName("ocorr_desc");
            entity.Property(e => e.Ocorrencia)
                .HasDefaultValueSql("0")
                .HasColumnName("ocorrencia");
            entity.Property(e => e.Parcelas)
                .HasComment("Quantidade de Parcelas")
                .HasColumnName("parcelas");
            entity.Property(e => e.Pedidofechado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("pedidofechado");
            entity.Property(e => e.Prepedido)
                .ValueGeneratedOnAdd()
                .HasColumnName("prepedido");
            entity.Property(e => e.Senha1)
                .HasMaxLength(25)
                .HasComment("Quem forneceu senha 1")
                .HasColumnName("senha1");
            entity.Property(e => e.Senha1obs)
                .HasMaxLength(70)
                .HasColumnName("senha1obs");
            entity.Property(e => e.Senha2)
                .HasMaxLength(25)
                .HasColumnName("senha2");
            entity.Property(e => e.Senha2obs)
                .HasMaxLength(70)
                .HasColumnName("senha2obs");
            entity.Property(e => e.Senha3)
                .HasMaxLength(25)
                .HasColumnName("senha3");
            entity.Property(e => e.Senha3obs)
                .HasMaxLength(70)
                .HasColumnName("senha3obs");
            entity.Property(e => e.Taxa).HasColumnName("taxa");
            entity.Property(e => e.Tipovenda)
                .HasComment("Tipo de Venda - Crediario Loja Cartão ou Financeira")
                .HasColumnName("tipovenda");
            entity.Property(e => e.Totalpagar)
                .HasPrecision(12, 2)
                .HasColumnName("totalpagar");
            entity.Property(e => e.Totalproduto)
                .HasPrecision(13, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("totalproduto");
            entity.Property(e => e.Totalvenda)
                .HasPrecision(13, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("totalvenda");

            entity.HasOne(d => d.CodclienteNavigation).WithMany()
                .HasForeignKey(d => d.Codcliente)
                .HasConstraintName("fk_tblcliente");

            entity.HasOne(d => d.CodlojaNavigation).WithMany()
                .HasForeignKey(d => d.Codloja)
                .HasConstraintName("fk_tblloja");

            entity.HasOne(d => d.CodusuarioNavigation).WithMany()
                .HasForeignKey(d => d.Codusuario)
                .HasConstraintName("fk_tblusuario");

            entity.HasOne(d => d.TipovendaNavigation).WithMany()
                .HasForeignKey(d => d.Tipovenda)
                .HasConstraintName("fk_tbltipovenda");
        });

        modelBuilder.Entity<TblPrevisaoCaixa>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_previsao_caixa_pkey");

            entity.ToTable("tbl_previsao_caixa", tb => tb.HasComment("Contém os valores  estimados da previsão de caixa, com suas respectivas divisões e subdivisões, conforme os códigos das tabelas tbl_divisao_gasto, tbl_divisao_gasto_princ e tbl_divisao_gasto_sub."));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Coddiv).HasColumnName("coddiv");
            entity.Property(e => e.Codsubdiv).HasColumnName("codsubdiv");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Indice)
                .HasDefaultValueSql("1000")
                .HasColumnName("indice");
            entity.Property(e => e.Texto)
                .HasMaxLength(20)
                .HasColumnName("texto");
            entity.Property(e => e.Total)
                .HasDefaultValueSql("false")
                .HasColumnName("total");
            entity.Property(e => e.Vlrestimado).HasColumnName("vlrestimado");
        });

        modelBuilder.Entity<TblPrevisaoCaixaDet>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_previsao_caixa_det_pkey");

            entity.ToTable("tbl_previsao_caixa_det", tb => tb.HasComment("Quando uma célula do dgParcelas da tela FrmAgendaFinanceiroParc é editada, um novo registro é inserido nesta tabela. [Previsões de caixa por divisão de gastos]\n"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Filtro).HasColumnName("filtro");
            entity.Property(e => e.Subdivisao).HasColumnName("subdivisao");
            entity.Property(e => e.Valor)
                .HasPrecision(12, 2)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<TblProdMov>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_prod_mov_pkey");

            entity.ToTable("tbl_prod_mov", tb => tb.HasComment("SETOR: Produtos\nTabela utilizada na tela FrmStatusEstoque. [Registros inseridos automaticamente pelo banco de dados quando tem movimentação de estoque]\nAbastecido pelos triggers Apos_Update e Apos_Insert na tbl_produto_quant\n"));

            entity.HasIndex(e => e.Codproduto, "index_prod_mov_codproduto");

            entity.HasIndex(e => e.Data, "index_prod_mov_data");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Coddepartamento)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("coddepartamento");
            entity.Property(e => e.Coddivisao)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("coddivisao");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Custo).HasColumnName("custo");
            entity.Property(e => e.CustoSemCredito)
                .HasPrecision(13, 2)
                .HasColumnName("custo_sem_credito");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Hora).HasColumnName("hora");
            entity.Property(e => e.Saldo).HasColumnName("saldo");
        });

        modelBuilder.Entity<TblProduto>(entity =>
        {
            entity.HasKey(e => e.Codproduto).HasName("cp_tblproduto");

            entity.ToTable("tbl_produto", tb => tb.HasComment("SETOR: Produtos, Pedido\nContém as informações e detalhes referentes aos produtos (SKUs) de nosso estoque, devidamente subdivididos em divisões, departamentos e dígitos. Possui o código de fábrica, descrição, custo, margem, valor de venda, se o produto está na promoção, bota-fora, possui juros especiais ou custo de aquisição, custo médio, margem de lucro, volumes, código da cor, se o produto está ativo, código da marca da tbl_marca, quantidade que está na assistência, se é necessário montagem, grupo, caso produto tenha agrupamento; tempo de garantia em dias, despesa para abastecer o caixa da assistência, se o produto está com imagem, margem normal do produto, data do cadastramento, taxa do preço a vista, preço do cartaz a vista, taxa a prazo e preço do cartaz a prazo, se o parcelamente tem ou não entrada, tamanho do cartaz, se o produto está no jornal, se é necessário comprar mais, estoque mínimo, impostos (ICMS, IPI, PIS, COFINS), frete, VA, IVA, alíquotas do imposto, último custo, código da garantia estendida deste produto, margem de lucro normal."));

            entity.HasIndex(e => e.Coddepartamento, "index_tbl_produto_coddepart");

            entity.HasIndex(e => e.Coddivisao, "index_tbl_produto_coddivisao");

            entity.HasIndex(e => e.Ativo, "tbl_produto_ativo_idx");

            entity.Property(e => e.Codproduto)
                .HasMaxLength(13)
                .HasColumnName("codproduto");
            entity.Property(e => e.Aliquota)
                .HasDefaultValueSql("0")
                .HasColumnName("aliquota");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("ativo");
            entity.Property(e => e.Atualizado)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("atualizado");
            entity.Property(e => e.Bcalculoicms)
                .HasPrecision(9, 2)
                .HasColumnName("bcalculoicms");
            entity.Property(e => e.Bcalculoicmsst)
                .HasPrecision(10, 3)
                .HasDefaultValueSql("0")
                .HasColumnName("bcalculoicmsst");
            entity.Property(e => e.Bfora)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("bfora");
            entity.Property(e => e.Cartazprazo).HasColumnName("cartazprazo");
            entity.Property(e => e.Cartaztamanho)
                .HasMaxLength(1)
                .HasDefaultValueSql("'G'::bpchar")
                .HasColumnName("cartaztamanho");
            entity.Property(e => e.Cartazvista).HasColumnName("cartazvista");
            entity.Property(e => e.Cest)
                .HasMaxLength(7)
                .HasColumnName("cest");
            entity.Property(e => e.ClassFiscal)
                .HasDefaultValueSql("0")
                .HasColumnName("class_fiscal");
            entity.Property(e => e.ClassificacaoEnergetica)
                .HasMaxLength(5)
                .HasColumnName("classificacao_energetica");
            entity.Property(e => e.Codcor)
                .HasDefaultValueSql("1")
                .HasColumnName("codcor");
            entity.Property(e => e.Coddepartamento).HasColumnName("coddepartamento");
            entity.Property(e => e.Coddigito).HasColumnName("coddigito");
            entity.Property(e => e.Coddivisao)
                .HasMaxLength(4)
                .HasColumnName("coddivisao");
            entity.Property(e => e.Codfabrica)
                .HasMaxLength(25)
                .HasColumnName("codfabrica");
            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblproduto'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Codmarca)
                .HasDefaultValueSql("0")
                .HasColumnName("codmarca");
            entity.Property(e => e.Codprodgarantia)
                .HasMaxLength(12)
                .HasColumnName("codprodgarantia");
            entity.Property(e => e.Cofinssaida)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("cofinssaida");
            entity.Property(e => e.Comprar)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("comprar");
            entity.Property(e => e.Credcofins)
                .HasPrecision(9, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("credcofins");
            entity.Property(e => e.Credicms)
                .HasPrecision(9, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("credicms");
            entity.Property(e => e.Credpis)
                .HasPrecision(9, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("credpis");
            entity.Property(e => e.Custo)
                .HasDefaultValueSql("0")
                .HasColumnName("custo");
            entity.Property(e => e.Custodiversos)
                .HasDefaultValueSql("0")
                .HasColumnName("custodiversos");
            entity.Property(e => e.Datacadastro)
                .HasDefaultValueSql("('now'::text)::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datacadastro");
            entity.Property(e => e.Datapagamento)
                .HasComment("data do pagamento medio")
                .HasColumnName("datapagamento");
            entity.Property(e => e.Descricao)
                .HasMaxLength(90)
                .HasColumnName("descricao");
            entity.Property(e => e.Despesaassist)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasComment("Despesa de assistência tecnica")
                .HasColumnName("despesaassist");
            entity.Property(e => e.Difal)
                .HasPrecision(6, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("difal");
            entity.Property(e => e.Entrada)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("entrada");
            entity.Property(e => e.Exclusivo21)
                .HasDefaultValueSql("false")
                .HasColumnName("exclusivo_21");
            entity.Property(e => e.Exclusivo22)
                .HasDefaultValueSql("false")
                .HasColumnName("exclusivo_22");
            entity.Property(e => e.Exclusivo24)
                .HasDefaultValueSql("false")
                .HasColumnName("exclusivo_24");
            entity.Property(e => e.FreteTransf22)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("frete_transf22");
            entity.Property(e => e.Freteporc)
                .HasDefaultValueSql("0")
                .HasColumnName("freteporc");
            entity.Property(e => e.Garantia)
                .HasDefaultValueSql("0")
                .HasComment("tempo de garantia")
                .HasColumnName("garantia");
            entity.Property(e => e.Grupo)
                .HasDefaultValueSql("0")
                .HasComment("Grupo a qual o produto pertence")
                .HasColumnName("grupo");
            entity.Property(e => e.Icmssaida)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("icmssaida");
            entity.Property(e => e.Imagem)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("imagem");
            entity.Property(e => e.Iva)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("iva");
            entity.Property(e => e.Jornal)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("jornal");
            entity.Property(e => e.Juroespec)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("juroespec");
            entity.Property(e => e.ManualProduto).HasColumnName("manual_produto");
            entity.Property(e => e.Margem)
                .HasPrecision(8, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("margem");
            entity.Property(e => e.MargemLucroNormal)
                .HasPrecision(8, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("margem_lucro_normal");
            entity.Property(e => e.Margemlucro)
                .HasPrecision(8, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("margemlucro");
            entity.Property(e => e.Margemnormal)
                .HasDefaultValueSql("0")
                .HasComment("margem de lucro quando o produto não esta em promocao.")
                .HasColumnName("margemnormal");
            entity.Property(e => e.MarkupDescImposto)
                .HasPrecision(9, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("markup_desc_imposto");
            entity.Property(e => e.Material)
                .HasMaxLength(30)
                .HasColumnName("material");
            entity.Property(e => e.Medidas)
                .HasMaxLength(30)
                .HasColumnName("medidas");
            entity.Property(e => e.Minimo)
                .HasDefaultValueSql("1")
                .HasColumnName("minimo");
            entity.Property(e => e.Montar)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("Se o produto nescessita de montagem na casa do cliente S ou N")
                .HasColumnName("montar");
            entity.Property(e => e.Mostruario).HasColumnName("mostruario");
            entity.Property(e => e.NewImage).HasColumnName("new_image");
            entity.Property(e => e.ObservacaoTransf).HasColumnName("observacao_transf");
            entity.Property(e => e.Observacoes).HasColumnName("observacoes");
            entity.Property(e => e.OperLogistico)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("oper_logistico");
            entity.Property(e => e.Parcprazo)
                .HasDefaultValueSql("0")
                .HasColumnName("parcprazo");
            entity.Property(e => e.Pfrete)
                .HasPrecision(5, 2)
                .HasColumnName("pfrete");
            entity.Property(e => e.Pissaida)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("pissaida");
            entity.Property(e => e.Porccredcofins)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porccredcofins");
            entity.Property(e => e.Porccredicms)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porccredicms");
            entity.Property(e => e.Porccredpis)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porccredpis");
            entity.Property(e => e.Porcfrete)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porcfrete");
            entity.Property(e => e.Porcicms)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porcicms");
            entity.Property(e => e.Porcipi)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porcipi");
            entity.Property(e => e.Porcvp)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porcvp");
            entity.Property(e => e.Promocao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("promocao");
            entity.Property(e => e.Quantassistencia)
                .HasDefaultValueSql("0")
                .HasComment("Quantidade de produtos em Assistencia")
                .HasColumnName("quantassistencia");
            entity.Property(e => e.Tempoentrega)
                .HasDefaultValueSql("0")
                .HasColumnName("tempoentrega");
            entity.Property(e => e.Tempomontagem)
                .HasDefaultValueSql("0")
                .HasColumnName("tempomontagem");
            entity.Property(e => e.Totalcomcredito)
                .HasPrecision(9, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("totalcomcredito");
            entity.Property(e => e.Totalsemcredito)
                .HasPrecision(9, 2)
                .HasColumnName("totalsemcredito");
            entity.Property(e => e.TotalsemcreditoMedia)
                .HasPrecision(9, 2)
                .HasColumnName("totalsemcredito_media");
            entity.Property(e => e.Tprazo)
                .HasDefaultValueSql("0")
                .HasColumnName("tprazo");
            entity.Property(e => e.Tvista)
                .HasDefaultValueSql("0")
                .HasColumnName("tvista");
            entity.Property(e => e.Ultimocusto)
                .HasPrecision(9, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("ultimocusto");
            entity.Property(e => e.Useratualizado)
                .HasMaxLength(35)
                .HasColumnName("useratualizado");
            entity.Property(e => e.Va)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("va");
            entity.Property(e => e.Valorpago)
                .HasDefaultValueSql("0")
                .HasColumnName("valorpago");
            entity.Property(e => e.Valorvista)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("valorvista");
            entity.Property(e => e.Venda)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("venda");
            entity.Property(e => e.Vendor)
                .HasPrecision(9, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vendor");
            entity.Property(e => e.Vfrete)
                .HasPrecision(9, 2)
                .HasColumnName("vfrete");
            entity.Property(e => e.Vicms)
                .HasPrecision(9, 2)
                .HasColumnName("vicms");
            entity.Property(e => e.Vipi)
                .HasPrecision(9, 2)
                .HasColumnName("vipi");
            entity.Property(e => e.Volume)
                .HasDefaultValueSql("1")
                .HasColumnName("volume");
            entity.Property(e => e.Vp)
                .HasPrecision(9, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vp");
            entity.Property(e => e.Vst)
                .HasPrecision(9, 2)
                .HasColumnName("vst");
            entity.Property(e => e.Vunit)
                .HasPrecision(9, 2)
                .HasColumnName("vunit");
        });

        modelBuilder.Entity<TblProdutoAjusteManual>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_produto_ajuste_manual_pkey");

            entity.ToTable("tbl_produto_ajuste_manual", tb => tb.HasComment("SETOR: Auditoria\nTabela que mantém os registros de alterações de estoque manualmente."));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Motivo).HasColumnName("motivo");
            entity.Property(e => e.Saldoajustado).HasColumnName("saldoajustado");
            entity.Property(e => e.Saldoanterior).HasColumnName("saldoanterior");
        });

        modelBuilder.Entity<TblProdutoAlqNcm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_produto_alq_ncm_pkey");

            entity.ToTable("tbl_produto_alq_ncm", tb => tb.HasComment("SETOR: Fiscal\nEsta tabela é utilizada no cálculo do difal.\nreducao_bc = reducao alíquota interestadual para cálculo do difal\nrecucao_bc_difal = reducao alíquota destino para cálculo do difal.\n\nos valores estao em porcentagem.\n\nContém dados referentes ao NCM, CFOP, FCP e alíquota de impostos internam, interestadual e destino, utilizados no pagamento do Diferencial de Alíquotas (DIFAL) e ICMS; se o produto tem redução na base de cálculo, e ao CST dos produtos.\n\nO NCMs (Nomenclatura Comum do Mercosul): Convenção entre os países membros do Mercosul para reconhecer facilmente os bens, serviços e fatores produtivos negociados entre si. Com o alinhamento da obrigatoriedade de emissão de NF-e (Nota Fiscal eletrônica) e a possível validação de dados pelas SEFAZ, não demorou para o governo obrigar essa nomenclatura nos cadastros de produtos.\nO NCM é composto de 8 dígitos:\n-Os dois primeiros dígitos ditam a característica de cada produto\n-O terceiro e o quarto dígito dita um desdobramento da característica de um produto\n-O quinto e sexto dígitos ditam mais uma subcategoria de produto\n-O sétimo dígito dita uma classificação do produto\n-O oitavo dígito dita o subitem, com a descrição mais detalhada de uma mercadoria\n\nCFOP - Código Fiscal de Operações e prestações. Descrição detalhada no site https://www.sitecontabil.com.br/tabelas/cfop/pag_um.html\n\nFCP - Fundo de combate à pobreza.\n\nCST - Código de Situação Tributária: É um código de três dígitos que determina a tributação referente ao ICMS do produto, onde são classificados, unindo 1 dígito da tabela A com 2 dígitos da tabela B. \nTABELA A: 0-Nacional, 1-Importação Direta, 2-Estrangeira Adquirida no Mercado Interno.\nTABELA B: 00 Tributada integralmente, 10 Tributada e com cobrança do ICMS por substituição tributária, 20 Com redução de base de cálculo, 30 Isenta ou não tributada e com cobrança do ICMS por substituição tributária, 40 Isenta, 41 Não tributada, 50 Suspensão, 51 Diferimento, 60 ICMS cobrado anteriormente por substituição tributária, 70 Com redução de base de cálculo e cobrança do ICMS por substituição tributária, 90 Outras.\"\n"));

            entity.HasIndex(e => new { e.CodUf, e.Codproduto }, "tbl_produto_alq_ncm_cod_uf_codproduto_key").IsUnique();

            entity.HasIndex(e => new { e.Ncm, e.CodUf }, "tbl_produto_alq_ncm_ncm_cod_uf_key").IsUnique();

            entity.HasIndex(e => new { e.Ncm, e.CodUf }, "tbl_produto_alq_ncm_ncm_cod_uf_key1").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AliqIcmsDestino)
                .HasPrecision(4, 2)
                .HasColumnName("aliq_icms_destino");
            entity.Property(e => e.AliqIcmsInter)
                .HasPrecision(4, 2)
                .HasColumnName("aliq_icms_inter");
            entity.Property(e => e.AliqIcmsInterna)
                .HasPrecision(4, 2)
                .HasColumnName("aliq_icms_interna");
            entity.Property(e => e.Cfop)
                .HasMaxLength(4)
                .HasColumnName("cfop");
            entity.Property(e => e.CodUf).HasColumnName("cod_uf");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(15)
                .HasColumnName("codproduto");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Cst)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("cst");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Fcp)
                .HasPrecision(4, 2)
                .HasColumnName("fcp");
            entity.Property(e => e.Ncm)
                .HasMaxLength(9)
                .HasColumnName("ncm");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.ReducaoBc)
                .HasPrecision(4, 2)
                .HasColumnName("reducao_bc");
            entity.Property(e => e.ReducaoBcDifal)
                .HasPrecision(4, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("reducao_bc_difal");

            entity.HasOne(d => d.CodUfNavigation).WithMany(p => p.TblProdutoAlqNcms)
                .HasForeignKey(d => d.CodUf)
                .HasConstraintName("tbl_produto_alq_ncm_cod_uf_fkey");
        });

        modelBuilder.Entity<TblProdutoAlqNcmLogDel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_produto_alq_ncm_log_del_pkey");

            entity.ToTable("tbl_produto_alq_ncm_log_del", tb => tb.HasComment("SETOR: Fiscal\nLog de registros excluídos da tbl_produto_alq_ncm"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(15)
                .HasColumnName("codproduto");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Ncm)
                .HasMaxLength(9)
                .HasColumnName("ncm");
        });

        modelBuilder.Entity<TblProdutoBaixa>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_produto_baixa_pkey");

            entity.ToTable("tbl_produto_baixa", tb => tb.HasComment("SETOR: Inclusão\nGrava os registros de baixas ou inclusões de estoque, com os respectivos motivos, quantidade baixada, estoque anterior, codproduto, local (loja) da baixa e usuário que fez a alteração. Esta tabela é gerenciada pela tela FrmProdutoBaixa, alcançada através da tela FrmManutProdutoNew, após se pressionar a tecla CTRL+\"F9\".\n"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Estoqueante).HasColumnName("estoqueante");
            entity.Property(e => e.Localbaixa).HasColumnName("localbaixa");
            entity.Property(e => e.Motivo).HasColumnName("motivo");
            entity.Property(e => e.Quantidade)
                .HasDefaultValueSql("0")
                .HasColumnName("quantidade");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'B'::bpchar")
                .HasColumnName("tipo");

            entity.HasOne(d => d.CodprodutoNavigation).WithMany(p => p.TblProdutoBaixas)
                .HasForeignKey(d => d.Codproduto)
                .HasConstraintName("tbl_produto_baixa_codproduto_fkey");

            entity.HasOne(d => d.CodusuarioNavigation).WithMany(p => p.TblProdutoBaixas)
                .HasForeignKey(d => d.Codusuario)
                .HasConstraintName("tbl_produto_baixa_codusuario_fkey");
        });

        modelBuilder.Entity<TblProdutoEntra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_produto_entra_pkey");

            entity.ToTable("tbl_produto_entra", tb => tb.HasComment("SETOR: INCLUSÃO, PRODUTOS\nContém os registros de inclusões de produtos no estoque, com os respectivos valores de custo, impostos, frete, VA, quantidade, codrecebimento, data em que entrou no estoque, se foi incluso, se é a última inclusão ou não, usuário que incluiu.\n--codrecebimento da tbl_produto_entra é codentrada da tbl_produto_entra_sub\n"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bcalculoicms)
                .HasPrecision(9, 2)
                .HasColumnName("bcalculoicms");
            entity.Property(e => e.Bcalculoicmsst)
                .HasPrecision(10, 3)
                .HasDefaultValueSql("0")
                .HasColumnName("bcalculoicmsst");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Codrecebimento).HasColumnName("codrecebimento");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Credcofins)
                .HasPrecision(9, 2)
                .HasColumnName("credcofins");
            entity.Property(e => e.Credicms)
                .HasPrecision(9, 2)
                .HasColumnName("credicms");
            entity.Property(e => e.Credpis)
                .HasPrecision(9, 2)
                .HasColumnName("credpis");
            entity.Property(e => e.Custodiversos)
                .HasPrecision(7, 2)
                .HasColumnName("custodiversos");
            entity.Property(e => e.Custovenda)
                .HasPrecision(9, 2)
                .HasColumnName("custovenda");
            entity.Property(e => e.Datainclusao)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("datainclusao");
            entity.Property(e => e.Entrounoestoque)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("entrounoestoque");
            entity.Property(e => e.FreteTransf22)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("frete_transf22");
            entity.Property(e => e.Incluso)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("incluso");
            entity.Property(e => e.OperLogistico)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("oper_logistico");
            entity.Property(e => e.Quantidade).HasColumnName("quantidade");
            entity.Property(e => e.Totalcomcredito)
                .HasPrecision(9, 2)
                .HasColumnName("totalcomcredito");
            entity.Property(e => e.Totalsemcredito)
                .HasPrecision(9, 2)
                .HasColumnName("totalsemcredito");
            entity.Property(e => e.Ultimainclusao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("ultimainclusao");
            entity.Property(e => e.Va)
                .HasPrecision(5, 2)
                .HasColumnName("va");
            entity.Property(e => e.Vendor)
                .HasPrecision(9, 2)
                .HasColumnName("vendor");
            entity.Property(e => e.Vfrete)
                .HasPrecision(9, 2)
                .HasColumnName("vfrete");
            entity.Property(e => e.Vicms)
                .HasPrecision(9, 2)
                .HasColumnName("vicms");
            entity.Property(e => e.Vipi)
                .HasPrecision(9, 2)
                .HasColumnName("vipi");
            entity.Property(e => e.Vp)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vp");
            entity.Property(e => e.VpTipo)
                .HasMaxLength(21)
                .HasColumnName("vp_tipo");
            entity.Property(e => e.Vst)
                .HasPrecision(9, 2)
                .HasColumnName("vst");
            entity.Property(e => e.Vunit)
                .HasPrecision(9, 2)
                .HasColumnName("vunit");
        });

        modelBuilder.Entity<TblProdutoEntraSub>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_produto_entra_sub_pkey");

            entity.ToTable("tbl_produto_entra_sub", tb => tb.HasComment("SETOR: INCLUSÃO, PRODUTOS\nNovos registros desta tabela são inseridos através da tela FrmRecebePedidoComXml, quando se recebe uma nova nota fiscal no formato XML e a abastecemos em nosso sistema. Tratam-se de registros com dados como número da nota fiscal, código do produto na nota, quantidade, NCM, EAN, EAN tributário, alíquotas de impostos,  data da inclusão, código do fornecedor, código do usuário que fez a inclusão, créditos tributários.\n--codrecebimento da tbl_produto_entra é codentrada da tbl_produto_entra_sub\n"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alcredcofins)
                .HasPrecision(5, 2)
                .HasColumnName("alcredcofins");
            entity.Property(e => e.Alcredicms)
                .HasPrecision(5, 2)
                .HasColumnName("alcredicms");
            entity.Property(e => e.Alcredpis)
                .HasPrecision(5, 2)
                .HasColumnName("alcredpis");
            entity.Property(e => e.Alicms)
                .HasPrecision(5, 2)
                .HasColumnName("alicms");
            entity.Property(e => e.Alipi)
                .HasPrecision(5, 2)
                .HasColumnName("alipi");
            entity.Property(e => e.Aliva)
                .HasPrecision(5, 2)
                .HasColumnName("aliva");
            entity.Property(e => e.Bcalculoicms)
                .HasPrecision(9, 2)
                .HasColumnName("bcalculoicms");
            entity.Property(e => e.Bcalculoicmsst)
                .HasPrecision(10, 3)
                .HasDefaultValueSql("0")
                .HasColumnName("bcalculoicmsst");
            entity.Property(e => e.CodFornecedorPedido).HasColumnName("cod_fornecedor_pedido");
            entity.Property(e => e.Codean)
                .HasMaxLength(14)
                .HasColumnName("codean");
            entity.Property(e => e.Codeantrib)
                .HasMaxLength(14)
                .HasColumnName("codeantrib");
            entity.Property(e => e.Codentrada).HasColumnName("codentrada");
            entity.Property(e => e.Codfornecedor).HasColumnName("codfornecedor");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Codprodutonota)
                .HasMaxLength(60)
                .HasColumnName("codprodutonota");
            entity.Property(e => e.Codproseq)
                .HasMaxLength(16)
                .HasColumnName("codproseq");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.CofinsNota)
                .HasPrecision(9, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("cofins_nota");
            entity.Property(e => e.Composicao)
                .HasPrecision(9, 6)
                .HasColumnName("composicao");
            entity.Property(e => e.Credcofins)
                .HasPrecision(9, 2)
                .HasColumnName("credcofins");
            entity.Property(e => e.Credicms)
                .HasPrecision(9, 2)
                .HasColumnName("credicms");
            entity.Property(e => e.Credpis)
                .HasPrecision(9, 2)
                .HasColumnName("credpis");
            entity.Property(e => e.Cstcompra)
                .HasMaxLength(4)
                .HasColumnName("cstcompra");
            entity.Property(e => e.Cstpiscofins)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("cstpiscofins");
            entity.Property(e => e.Cstvenda)
                .HasMaxLength(3)
                .HasColumnName("cstvenda");
            entity.Property(e => e.Custodiversos)
                .HasPrecision(7, 2)
                .HasColumnName("custodiversos");
            entity.Property(e => e.Custovenda)
                .HasPrecision(9, 2)
                .HasColumnName("custovenda");
            entity.Property(e => e.Datainclusao)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("datainclusao");
            entity.Property(e => e.Descricao)
                .HasMaxLength(120)
                .HasColumnName("descricao");
            entity.Property(e => e.DescricaoXmlentrada)
                .HasMaxLength(300)
                .HasColumnName("descricao_xmlentrada");
            entity.Property(e => e.FreteNota)
                .HasPrecision(9, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("frete_nota");
            entity.Property(e => e.IcmsNota)
                .HasPrecision(9, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("icms_nota");
            entity.Property(e => e.IcmsRecuperar)
                .HasPrecision(7, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("icms_recuperar");
            entity.Property(e => e.Icmssaida)
                .HasPrecision(5, 2)
                .HasColumnName("icmssaida");
            entity.Property(e => e.IcmsstNota)
                .HasPrecision(9, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("icmsst_nota");
            entity.Property(e => e.IpiNota)
                .HasPrecision(9, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("ipi_nota");
            entity.Property(e => e.Iva)
                .HasPrecision(5, 2)
                .HasColumnName("iva");
            entity.Property(e => e.Ncm)
                .HasMaxLength(8)
                .HasColumnName("ncm");
            entity.Property(e => e.Nfeentrada).HasColumnName("nfeentrada");
            entity.Property(e => e.Pfrete)
                .HasPrecision(5, 2)
                .HasColumnName("pfrete");
            entity.Property(e => e.PisNota)
                .HasPrecision(9, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("pis_nota");
            entity.Property(e => e.Quantidade)
                .HasPrecision(5, 2)
                .HasColumnName("quantidade");
            entity.Property(e => e.QuantidadeOpTriangular)
                .HasPrecision(5, 2)
                .HasColumnName("quantidade_op_triangular");
            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.St)
                .HasMaxLength(1)
                .HasColumnName("st");
            entity.Property(e => e.StRecuperar)
                .HasPrecision(7, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("st_recuperar");
            entity.Property(e => e.Totalcomcredito)
                .HasPrecision(9, 2)
                .HasColumnName("totalcomcredito");
            entity.Property(e => e.Totalsemcredito)
                .HasPrecision(9, 2)
                .HasColumnName("totalsemcredito");
            entity.Property(e => e.Ucom)
                .HasMaxLength(6)
                .HasColumnName("ucom");
            entity.Property(e => e.Ultimainclusao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("ultimainclusao");
            entity.Property(e => e.Va)
                .HasPrecision(5, 2)
                .HasColumnName("va");
            entity.Property(e => e.Vendor)
                .HasPrecision(9, 2)
                .HasColumnName("vendor");
            entity.Property(e => e.Vfrete)
                .HasPrecision(9, 2)
                .HasColumnName("vfrete");
            entity.Property(e => e.Vicms)
                .HasPrecision(9, 2)
                .HasColumnName("vicms");
            entity.Property(e => e.Vipi)
                .HasPrecision(9, 2)
                .HasColumnName("vipi");
            entity.Property(e => e.Vp)
                .HasPrecision(5, 2)
                .HasColumnName("vp");
            entity.Property(e => e.Vst)
                .HasPrecision(9, 2)
                .HasColumnName("vst");
            entity.Property(e => e.Vunit)
                .HasPrecision(9, 2)
                .HasColumnName("vunit");

            entity.HasOne(d => d.CodentradaNavigation).WithMany(p => p.TblProdutoEntraSubs)
                .HasForeignKey(d => d.Codentrada)
                .HasConstraintName("tbl_produto_entra_sub_codentrada_fkey");
        });

        modelBuilder.Entity<TblProdutoGrupo>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_produto_grupo_pkey");

            entity.ToTable("tbl_produto_grupo", tb => tb.HasComment("SETOR: Inclusão\nEsta tabela é gerenciada pela tela FrmCriaGrupoProd, acessada através do ContextMenuStrip da FrmListaProduto, no item \"Criar Novo Grupo\". Basicamente os produtos são agrupados para compartilhares características em comum, como o preço de venda e determinada descrição."));

            entity.HasIndex(e => e.Descricao, "tbl_produto_grupo_descricao_key").IsUnique();

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(90)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<TblProdutoHistAltMargem>(entity =>
        {
            entity.HasKey(e => e.IdHistAltMargem).HasName("tbl_produto_hist_alt_margem_pkey");

            entity.ToTable("tbl_produto_hist_alt_margem", tb => tb.HasComment("histórico de alteração de preços na FrmManutProdutoNew"));

            entity.Property(e => e.IdHistAltMargem).HasColumnName("id_hist_alt_margem");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(13)
                .HasColumnName("codproduto");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Margem).HasColumnName("margem");
            entity.Property(e => e.MargemAnterior).HasColumnName("margem_anterior");
        });

        modelBuilder.Entity<TblProdutoMov>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_produto_mov_pkey");

            entity.ToTable("tbl_produto_mov", tb => tb.HasComment("SETOR: PRODUTOS, PEDIDO\nMovimentação de produtos. As telas FrmExtratoProdLoja e FrmExtratoProduto contém os registros desta tabela para um determinado produto e determinada loja. A FrmEntradaPedidoEcommerce exclui registros desta tabela quando um pedido não tem o pagamento confirmado ou é cancelado. Quando um pedido é cancelado pela FrmCancelarPedido, são gravados novos registros, assim como na geração de pedido, venda para cliente e entrada de fornecedor.\n\n"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Coddepartamento)
                .HasMaxLength(3)
                .HasColumnName("coddepartamento");
            entity.Property(e => e.Coddivisao)
                .HasMaxLength(3)
                .HasColumnName("coddivisao");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Customedio)
                .HasPrecision(12, 2)
                .HasComment("custo medio mercadoria")
                .HasColumnName("customedio");
            entity.Property(e => e.Data)
                .HasComment("Data do movimento")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .HasColumnName("descricao");
            entity.Property(e => e.Documento)
                .HasMaxLength(25)
                .HasColumnName("documento");
            entity.Property(e => e.Entrada)
                .HasDefaultValueSql("0")
                .HasColumnName("entrada");
            entity.Property(e => e.Estoqueantes).HasColumnName("estoqueantes");
            entity.Property(e => e.Local)
                .HasComment("local da entrada ou saida do produto")
                .HasColumnName("local");
            entity.Property(e => e.RestouLocal)
                .HasComment("estoque que restou no local da baixa")
                .HasColumnName("restou_local");
            entity.Property(e => e.Saida)
                .HasDefaultValueSql("0")
                .HasColumnName("saida");
            entity.Property(e => e.Saldo).HasColumnName("saldo");
            entity.Property(e => e.Saldolocal).HasColumnName("saldolocal");
            entity.Property(e => e.Valor)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("valor de compra ou de venda")
                .HasColumnName("valor");
            entity.Property(e => e.Venda)
                .HasMaxLength(1)
                .HasColumnName("venda");
            entity.Property(e => e.Ventrada)
                .HasPrecision(12, 3)
                .HasDefaultValueSql("0")
                .HasComment("Valor da entrada")
                .HasColumnName("ventrada");
            entity.Property(e => e.Vsaida)
                .HasPrecision(12, 3)
                .HasDefaultValueSql("0")
                .HasComment("Valor da saida")
                .HasColumnName("vsaida");
        });

        modelBuilder.Entity<TblProdutoQuant>(entity =>
        {
            entity.HasKey(e => new { e.Codproduto, e.Coddeposito }).HasName("tbl_produto_quant_pkey");

            entity.ToTable("tbl_produto_quant", tb => tb.HasComment("SETOR: Pedido, Produto, Inclusão\nRelacionada a tabela tbl_produto. Esta tabela contém a quantidade de cada produto em cada loja"));

            entity.HasIndex(e => e.Coddeposito, "tbl_produto_quant_coddeposito_idx");

            entity.HasIndex(e => e.Codproduto, "tbl_produto_quant_codproduto_idx");

            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Coddeposito).HasColumnName("coddeposito");
            entity.Property(e => e.Adiarate).HasColumnName("adiarate");
            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblprodutoquantidade'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.CustoSemCredito)
                .HasPrecision(13, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("custo_sem_credito");
            entity.Property(e => e.DataMinimo)
                .HasComment("data que configurou o estoque minimo")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_minimo");
            entity.Property(e => e.MinimoTransf)
                .HasComment("Estoque minimo para transferencia")
                .HasColumnName("minimo_transf");
            entity.Property(e => e.Quantidade)
                .HasDefaultValueSql("0")
                .HasColumnName("quantidade");
            entity.Property(e => e.Somarestoque)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasComment("Somar produto ao estoque")
                .HasColumnName("somarestoque");
            entity.Property(e => e.UserMinimo)
                .HasComment("usuario que configurou estoque minimo")
                .HasColumnName("user_minimo");
            entity.Property(e => e.Valorcusto)
                .HasPrecision(13, 2)
                .HasComment("Valor de custo do produto")
                .HasColumnName("valorcusto");

            entity.HasOne(d => d.CoddepositoNavigation).WithMany(p => p.TblProdutoQuants)
                .HasForeignKey(d => d.Coddeposito)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tbl_produto_quant_coddeposito_fkey");
        });

        modelBuilder.Entity<TblProdutoQuantUp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_produto_quant_up", tb => tb.HasComment("SETOR: INCLUSÃO\nNão existem referências a esta tabela no projeto Sist_Controle. Novos registros inseridos pelo trigger no UPDATE ou INSERT na tbl_produto_quant\n"));

            entity.Property(e => e.Codigo)
                .ValueGeneratedOnAdd()
                .HasColumnName("codigo");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data");
            entity.Property(e => e.QuantNew).HasColumnName("quant_new");
            entity.Property(e => e.QuantOld).HasColumnName("quant_old");
            entity.Property(e => e.Usuario)
                .HasMaxLength(60)
                .HasDefaultValueSql("\"current_user\"()")
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<TblProdutoServico>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_produto_servico_pkey");

            entity.ToTable("tbl_produto_servico", tb => tb.HasComment("SETOR: Inclusão, Pedido, Produto\nContém as faixas de preço das garantias estendidas. Baseado no departamento do serviço, puxa-se o preço da garantia por esta tabela, sendo: 900-Eletrodomésticos, 901-Eletroportáteis, 902-Vídeo, 903-Audio, 904-Fotografia, 905-Telefones, 906-Informática, 907-Bicicleta/Fitness, 908-Ferramentas Elétricas e 909-Móveis"));

            entity.HasIndex(e => new { e.Codproduto, e.Valorinicio, e.Valorfim }, "tbl_produto_servico_codproduto_valorinicio_valorfim_key").IsUnique();

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Atualizado)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("atualizado");
            entity.Property(e => e.AtualizadoWeb)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("atualizado_web");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.CodusuarioWeb).HasColumnName("codusuario_web");
            entity.Property(e => e.Custo1)
                .HasPrecision(6, 2)
                .HasColumnName("custo1");
            entity.Property(e => e.Custo2)
                .HasPrecision(6, 2)
                .HasColumnName("custo2");
            entity.Property(e => e.Iof)
                .HasPrecision(4, 2)
                .HasColumnName("iof");
            entity.Property(e => e.Margempremio)
                .HasPrecision(4, 2)
                .HasColumnName("margempremio");
            entity.Property(e => e.PisCofins)
                .HasPrecision(4, 2)
                .HasColumnName("pis_cofins");
            entity.Property(e => e.Precounico)
                .HasDefaultValueSql("true")
                .HasColumnName("precounico");
            entity.Property(e => e.Premio1)
                .HasPrecision(7, 2)
                .HasColumnName("premio1");
            entity.Property(e => e.Premio2)
                .HasPrecision(7, 2)
                .HasColumnName("premio2");
            entity.Property(e => e.PremioLiq1)
                .HasPrecision(6, 2)
                .HasColumnName("premio_liq1");
            entity.Property(e => e.PremioLiq2)
                .HasPrecision(6, 2)
                .HasColumnName("premio_liq2");
            entity.Property(e => e.Valorfim)
                .HasPrecision(9, 2)
                .HasColumnName("valorfim");
            entity.Property(e => e.Valorinicio)
                .HasPrecision(9, 2)
                .HasColumnName("valorinicio");
        });

        modelBuilder.Entity<TblProdutoSub>(entity =>
        {
            entity.HasKey(e => new { e.Codproduto, e.Seq }).HasName("tbl_produto_sub_pkey1");

            entity.ToTable("tbl_produto_sub", tb => tb.HasComment("SETOR: Produtos, Inclusão\nContém a relação de produtos e seus respectivos códigos de garantia estendida, além de outros dados, como codprodnota, descrição do produto na nota fiscal de entrada, NCM, EAN, EAN tributário, alíquotas de imposto, base de cálculo ICMS, créditos de impostos. Uma série de dados desta tabela estão também na tabela tbl_produto_alq_ncm. [Porem tabela não tem nenhuma relação com codigo de garantia estendida, codigos da garantia estão na tbl_produto]\n"));

            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.Aliqiva)
                .HasPrecision(5, 2)
                .HasColumnName("aliqiva");
            entity.Property(e => e.Bcalculoicms)
                .HasPrecision(10, 3)
                .HasDefaultValueSql("0")
                .HasColumnName("bcalculoicms");
            entity.Property(e => e.Bcalculoicmsst)
                .HasPrecision(10, 3)
                .HasDefaultValueSql("0")
                .HasColumnName("bcalculoicmsst");
            entity.Property(e => e.Cest)
                .HasMaxLength(7)
                .HasColumnName("cest");
            entity.Property(e => e.Codean)
                .HasMaxLength(14)
                .HasColumnName("codean");
            entity.Property(e => e.Codeantrib)
                .HasMaxLength(14)
                .HasColumnName("codeantrib");
            entity.Property(e => e.Codigo)
                .ValueGeneratedOnAdd()
                .HasColumnName("codigo");
            entity.Property(e => e.Codprodutonota)
                .HasMaxLength(60)
                .HasColumnName("codprodutonota");
            entity.Property(e => e.Codproseq)
                .HasMaxLength(16)
                .HasColumnName("codproseq");
            entity.Property(e => e.Composicao)
                .HasPrecision(9, 6)
                .HasDefaultValueSql("100")
                .HasColumnName("composicao");
            entity.Property(e => e.Credcofins)
                .HasPrecision(8, 3)
                .HasDefaultValueSql("0")
                .HasColumnName("credcofins");
            entity.Property(e => e.Credicms)
                .HasPrecision(8, 3)
                .HasDefaultValueSql("0")
                .HasColumnName("credicms");
            entity.Property(e => e.Credpis)
                .HasPrecision(8, 3)
                .HasDefaultValueSql("0")
                .HasColumnName("credpis");
            entity.Property(e => e.Cstcompra)
                .HasMaxLength(4)
                .HasColumnName("cstcompra");
            entity.Property(e => e.Cstpiscofins)
                .HasMaxLength(2)
                .HasDefaultValueSql("'01'::bpchar")
                .IsFixedLength()
                .HasColumnName("cstpiscofins");
            entity.Property(e => e.Cstvenda)
                .HasMaxLength(3)
                .HasColumnName("cstvenda");
            entity.Property(e => e.Custovenda)
                .HasPrecision(10, 3)
                .HasDefaultValueSql("0")
                .HasColumnName("custovenda");
            entity.Property(e => e.Descricao)
                .HasMaxLength(120)
                .HasColumnName("descricao");
            entity.Property(e => e.Icms)
                .HasPrecision(5, 2)
                .HasColumnName("icms");
            entity.Property(e => e.IcmsRecuperar)
                .HasPrecision(6, 2)
                .HasColumnName("icms_recuperar");
            entity.Property(e => e.IcmsSaida)
                .HasPrecision(5, 2)
                .HasColumnName("icms_saida");
            entity.Property(e => e.Iva)
                .HasPrecision(5, 2)
                .HasColumnName("iva");
            entity.Property(e => e.Ncm)
                .HasMaxLength(8)
                .HasColumnName("ncm");
            entity.Property(e => e.Quantidade)
                .HasPrecision(5, 2)
                .HasColumnName("quantidade");
            entity.Property(e => e.St)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("st");
            entity.Property(e => e.StRecuperar)
                .HasPrecision(6, 2)
                .HasColumnName("st_recuperar");
            entity.Property(e => e.Totalcomcredito)
                .HasPrecision(10, 3)
                .HasDefaultValueSql("0")
                .HasColumnName("totalcomcredito");
            entity.Property(e => e.Totalsemcredito)
                .HasPrecision(10, 3)
                .HasDefaultValueSql("0")
                .HasColumnName("totalsemcredito");
            entity.Property(e => e.Ucom)
                .HasMaxLength(6)
                .HasColumnName("ucom");
            entity.Property(e => e.Va)
                .HasPrecision(7, 3)
                .HasDefaultValueSql("0")
                .HasColumnName("va");
            entity.Property(e => e.Vendor)
                .HasPrecision(7, 3)
                .HasDefaultValueSql("0")
                .HasColumnName("vendor");
            entity.Property(e => e.Vfrete)
                .HasPrecision(10, 3)
                .HasDefaultValueSql("0")
                .HasColumnName("vfrete");
            entity.Property(e => e.Vicms)
                .HasPrecision(10, 3)
                .HasDefaultValueSql("0")
                .HasColumnName("vicms");
            entity.Property(e => e.Vipi)
                .HasPrecision(10, 3)
                .HasDefaultValueSql("0")
                .HasColumnName("vipi");
            entity.Property(e => e.Vst)
                .HasPrecision(10, 3)
                .HasDefaultValueSql("0")
                .HasColumnName("vst");
            entity.Property(e => e.Vunit)
                .HasPrecision(10, 3)
                .HasDefaultValueSql("0")
                .HasColumnName("vunit");
        });

        modelBuilder.Entity<TblProdutoUp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_produto_up");

            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasColumnName("ativo");
            entity.Property(e => e.Bfora)
                .HasMaxLength(1)
                .HasColumnName("bfora");
            entity.Property(e => e.Cartazprazo).HasColumnName("cartazprazo");
            entity.Property(e => e.Cartazvista).HasColumnName("cartazvista");
            entity.Property(e => e.Codigo)
                .ValueGeneratedOnAdd()
                .HasColumnName("codigo");
            entity.Property(e => e.Codprodgarantia)
                .HasMaxLength(12)
                .HasColumnName("codprodgarantia");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(13)
                .HasColumnName("codproduto");
            entity.Property(e => e.Comprar)
                .HasMaxLength(1)
                .HasColumnName("comprar");
            entity.Property(e => e.Custo).HasColumnName("custo");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Garantia).HasColumnName("garantia");
            entity.Property(e => e.Grupo).HasColumnName("grupo");
            entity.Property(e => e.Jornal)
                .HasMaxLength(1)
                .HasColumnName("jornal");
            entity.Property(e => e.Juroespec)
                .HasMaxLength(1)
                .HasColumnName("juroespec");
            entity.Property(e => e.Margem)
                .HasPrecision(8, 2)
                .HasColumnName("margem");
            entity.Property(e => e.Markup).HasColumnName("markup");
            entity.Property(e => e.MarkupNormal)
                .HasPrecision(8, 4)
                .HasColumnName("markup_normal");
            entity.Property(e => e.Minimo).HasColumnName("minimo");
            entity.Property(e => e.Parcprazo).HasColumnName("parcprazo");
            entity.Property(e => e.Promocao)
                .HasMaxLength(1)
                .HasColumnName("promocao");
            entity.Property(e => e.Tprazo).HasColumnName("tprazo");
            entity.Property(e => e.Tvista).HasColumnName("tvista");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");
            entity.Property(e => e.Venda).HasColumnName("venda");
        });

        modelBuilder.Entity<TblProjeto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_projeto_pkey");

            entity.ToTable("tbl_projeto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Classificacao).HasColumnName("classificacao");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .HasColumnName("descricao");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<TblProjetoExecucao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_projeto_execucao_pkey");

            entity.ToTable("tbl_projeto_execucao");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodUsuario).HasColumnName("codUsuario");
            entity.Property(e => e.DataEntrada).HasColumnName("dataEntrada");
            entity.Property(e => e.DataSaida).HasColumnName("dataSaida");
            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .HasColumnName("ip");
            entity.Property(e => e.ProjetoId).HasColumnName("projetoID");
            entity.Property(e => e.UltimaAtualizacao).HasColumnName("ultimaAtualizacao");
        });

        modelBuilder.Entity<TblProjetoVp>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_projeto_vp_pkey");

            entity.ToTable("tbl_projeto_vp");

            entity.HasIndex(e => new { e.CodGrupoFornecedor, e.Ano }, "tbl_projeto_vp_cod_grupo_fornecedor_ano_key").IsUnique();

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.CodGrupoFornecedor).HasColumnName("cod_grupo_fornecedor");
            entity.Property(e => e.Porcentagem)
                .HasPrecision(5, 2)
                .HasColumnName("porcentagem");
            entity.Property(e => e.SomarImposto).HasColumnName("somar_imposto");
        });

        modelBuilder.Entity<TblPromessa>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_promessa_pkey");

            entity.ToTable("tbl_promessa");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Datapromessa)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datapromessa");
            entity.Property(e => e.Pgtopara).HasColumnName("pgtopara");
            entity.Property(e => e.Prometidopor).HasColumnName("prometidopor");
        });

        modelBuilder.Entity<TblRecebimentoContabil>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_recebimento_contabil_pkey");

            entity.ToTable("tbl_recebimento_contabil");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.ContaCredito)
                .HasMaxLength(12)
                .HasColumnName("conta_credito");
            entity.Property(e => e.ContaDebito)
                .HasMaxLength(12)
                .HasColumnName("conta_debito");
            entity.Property(e => e.DataExtrato)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_extrato");
            entity.Property(e => e.DataGrav)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_grav");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.Valor)
                .HasPrecision(12, 2)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<TblRegistro10>(entity =>
        {
            entity.HasKey(e => e.Codloja).HasName("tbl_registro_10_pkey");

            entity.ToTable("tbl_registro_10");

            entity.Property(e => e.Codloja)
                .ValueGeneratedNever()
                .HasColumnName("codloja");
            entity.Property(e => e.Bairro)
                .HasMaxLength(15)
                .HasColumnName("bairro");
            entity.Property(e => e.Cep)
                .HasMaxLength(10)
                .HasColumnName("cep");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(18)
                .HasColumnName("cnpj");
            entity.Property(e => e.CnpjLigacao)
                .HasMaxLength(18)
                .HasColumnName("cnpj_ligacao");
            entity.Property(e => e.Codarquivo)
                .HasMaxLength(1)
                .HasColumnName("codarquivo");
            entity.Property(e => e.Codfinalidade)
                .HasMaxLength(1)
                .HasColumnName("codfinalidade");
            entity.Property(e => e.Codoperacao)
                .HasMaxLength(1)
                .HasColumnName("codoperacao");
            entity.Property(e => e.Contribuinte)
                .HasMaxLength(45)
                .HasColumnName("contribuinte");
            entity.Property(e => e.Endereco)
                .HasMaxLength(34)
                .HasColumnName("endereco");
            entity.Property(e => e.Fax)
                .HasMaxLength(10)
                .HasColumnName("fax");
            entity.Property(e => e.Inscestadual)
                .HasMaxLength(14)
                .HasColumnName("inscestadual");
            entity.Property(e => e.Municipio)
                .HasMaxLength(30)
                .HasColumnName("municipio");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("uf");
        });

        modelBuilder.Entity<TblRegistro11>(entity =>
        {
            entity.HasKey(e => e.Codloja).HasName("tbl_registro_11_pkey");

            entity.ToTable("tbl_registro_11");

            entity.Property(e => e.Codloja)
                .ValueGeneratedNever()
                .HasColumnName("codloja");
            entity.Property(e => e.Bairro)
                .HasMaxLength(15)
                .HasColumnName("bairro");
            entity.Property(e => e.Cep).HasColumnName("cep");
            entity.Property(e => e.Complemento)
                .HasMaxLength(22)
                .HasColumnName("complemento");
            entity.Property(e => e.Fone)
                .HasMaxLength(12)
                .HasColumnName("fone");
            entity.Property(e => e.Logradouro)
                .HasMaxLength(34)
                .HasColumnName("logradouro");
            entity.Property(e => e.Nomecontato)
                .HasMaxLength(28)
                .HasColumnName("nomecontato");
            entity.Property(e => e.Numero).HasColumnName("numero");
        });

        modelBuilder.Entity<TblRegistro50>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_registro_50_pkey");

            entity.ToTable("tbl_registro_50");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Aliquota)
                .HasDefaultValueSql("0")
                .HasColumnName("aliquota");
            entity.Property(e => e.Basecalculoicms)
                .HasDefaultValueSql("0")
                .HasColumnName("basecalculoicms");
            entity.Property(e => e.Cancelada)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("cancelada");
            entity.Property(e => e.Cfop).HasColumnName("cfop");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(16)
                .HasColumnName("cnpj");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Datacancelada)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datacancelada");
            entity.Property(e => e.Dataemissao).HasColumnName("dataemissao");
            entity.Property(e => e.Emitente)
                .HasMaxLength(1)
                .HasColumnName("emitente");
            entity.Property(e => e.Excluir)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("excluir");
            entity.Property(e => e.Inscestadual)
                .HasMaxLength(14)
                .HasColumnName("inscestadual");
            entity.Property(e => e.Isentatributada)
                .HasDefaultValueSql("0")
                .HasColumnName("isentatributada");
            entity.Property(e => e.Modelo).HasColumnName("modelo");
            entity.Property(e => e.Novo)
                .HasDefaultValueSql("0")
                .HasColumnName("novo");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Outras)
                .HasDefaultValueSql("0")
                .HasColumnName("outras");
            entity.Property(e => e.Serie)
                .HasMaxLength(3)
                .HasColumnName("serie");
            entity.Property(e => e.Situacao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("situacao");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("uf");
            entity.Property(e => e.Usercancelou).HasColumnName("usercancelou");
            entity.Property(e => e.Valoricms)
                .HasDefaultValueSql("0")
                .HasColumnName("valoricms");
            entity.Property(e => e.Valortotal).HasColumnName("valortotal");
        });

        modelBuilder.Entity<TblRegistro54>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_registro_54_pkey");

            entity.ToTable("tbl_registro_54");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Aliquotaicms)
                .HasDefaultValueSql("0")
                .HasColumnName("aliquotaicms");
            entity.Property(e => e.Basecalculoicms)
                .HasDefaultValueSql("0")
                .HasColumnName("basecalculoicms");
            entity.Property(e => e.Basecalculoicmsst)
                .HasDefaultValueSql("0")
                .HasColumnName("basecalculoicmsst");
            entity.Property(e => e.Cancelada)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("cancelada");
            entity.Property(e => e.Cfop).HasColumnName("cfop");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(16)
                .HasColumnName("cnpj");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Cst)
                .HasDefaultValueSql("0")
                .HasColumnName("cst");
            entity.Property(e => e.Datacancelada)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datacancelada");
            entity.Property(e => e.Dataemissao).HasColumnName("dataemissao");
            entity.Property(e => e.Modelo).HasColumnName("modelo");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Numeroitem).HasColumnName("numeroitem");
            entity.Property(e => e.Quantidade).HasColumnName("quantidade");
            entity.Property(e => e.Serie)
                .HasMaxLength(3)
                .HasColumnName("serie");
            entity.Property(e => e.Usercancelou).HasColumnName("usercancelou");
            entity.Property(e => e.Valor).HasColumnName("valor");
            entity.Property(e => e.Valordesconto).HasColumnName("valordesconto");
            entity.Property(e => e.Valoripi)
                .HasDefaultValueSql("0")
                .HasColumnName("valoripi");
        });

        modelBuilder.Entity<TblRegistro75>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_registro_75_pkey");

            entity.ToTable("tbl_registro_75");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Aliquotaicms).HasColumnName("aliquotaicms");
            entity.Property(e => e.Basecalculoicms).HasColumnName("basecalculoicms");
            entity.Property(e => e.Cancelada)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("cancelada");
            entity.Property(e => e.Codigonbm)
                .HasDefaultValueSql("0")
                .HasColumnName("codigonbm");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Datacancelada)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datacancelada");
            entity.Property(e => e.Datafim).HasColumnName("datafim");
            entity.Property(e => e.Datainicio).HasColumnName("datainicio");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .HasColumnName("descricao");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Reducaobaseicms).HasColumnName("reducaobaseicms");
            entity.Property(e => e.Serie).HasColumnName("serie");
            entity.Property(e => e.Situacaotributaria).HasColumnName("situacaotributaria");
            entity.Property(e => e.Un)
                .HasMaxLength(6)
                .HasColumnName("un");
            entity.Property(e => e.Usercancelou).HasColumnName("usercancelou");
        });

        modelBuilder.Entity<TblRegistroRetornosE>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_registro_retornos_es_pkey");

            entity.ToTable("tbl_registro_retornos_es");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Arquivo)
                .HasMaxLength(3)
                .HasColumnName("arquivo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.Mensagem)
                .HasMaxLength(200)
                .HasColumnName("mensagem");
        });

        modelBuilder.Entity<TblRegrasBaixaEcommerce>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_regras_baixa_ecommerce_pkey");

            entity.ToTable("tbl_regras_baixa_ecommerce");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Criadopor)
                .HasColumnType("character varying")
                .HasColumnName("criadopor");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Marketplace)
                .HasColumnType("character varying")
                .HasColumnName("marketplace");
            entity.Property(e => e.Regras).HasColumnName("regras");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<TblRegrasBaixaEcommerceMarketplace>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_regras_baixa_ecommerce_marketplace_pkey");

            entity.ToTable("tbl_regras_baixa_ecommerce_marketplace");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Marketplace).HasColumnName("marketplace");
        });

        modelBuilder.Entity<TblRegrasBaixaEcommerceTpl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_regras_baixa_ecommerce_tpl_pkey");

            entity.ToTable("tbl_regras_baixa_ecommerce_tpl");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TpLancamentos).HasColumnName("tp_lancamentos");
        });

        modelBuilder.Entity<TblRenegRemovidum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_reneg_removida_pkey");

            entity.ToTable("tbl_reneg_removida");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codreneg).HasColumnName("codreneg");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.DataRenegCriada)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_reneg_criada");
            entity.Property(e => e.DataRenegRemovida)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_reneg_removida");
            entity.Property(e => e.Obs)
                .HasMaxLength(300)
                .HasColumnName("obs");
        });

        modelBuilder.Entity<TblRenegociar>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_renegociar_pkey");

            entity.ToTable("tbl_renegociar");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.ClasseCliente)
                .HasMaxLength(1)
                .HasColumnName("classe_cliente");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Datafim)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("datafim");
            entity.Property(e => e.Datainicio)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("datainicio");
            entity.Property(e => e.Descjuro).HasColumnName("descjuro");
            entity.Property(e => e.Descoriginal).HasColumnName("descoriginal");
            entity.Property(e => e.Ocorre1)
                .HasDefaultValueSql("1")
                .HasColumnName("ocorre1");
            entity.Property(e => e.Ocorre1Data)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("ocorre1_data");
            entity.Property(e => e.Ocorre1Obs).HasColumnName("ocorre1_obs");
            entity.Property(e => e.Ocorre1User)
                .HasDefaultValueSql("0")
                .HasColumnName("ocorre1_user");
            entity.Property(e => e.Ocorre2)
                .HasDefaultValueSql("0")
                .HasColumnName("ocorre2");
            entity.Property(e => e.Ocorre2Data)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("ocorre2_data");
            entity.Property(e => e.Ocorre2Obs).HasColumnName("ocorre2_obs");
            entity.Property(e => e.Ocorre2User)
                .HasDefaultValueSql("0")
                .HasColumnName("ocorre2_user");
            entity.Property(e => e.Ocorre3)
                .HasDefaultValueSql("0")
                .HasColumnName("ocorre3");
            entity.Property(e => e.Ocorre3Data)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("ocorre3_data");
            entity.Property(e => e.Ocorre3Obs).HasColumnName("ocorre3_obs");
            entity.Property(e => e.Ocorre3User)
                .HasDefaultValueSql("0")
                .HasColumnName("ocorre3_user");
            entity.Property(e => e.Taxajuro).HasColumnName("taxajuro");
            entity.Property(e => e.Taxajuroanterior)
                .HasPrecision(12, 2)
                .HasColumnName("taxajuroanterior");
            entity.Property(e => e.Vlratual).HasColumnName("vlratual");
            entity.Property(e => e.Vlrjuro).HasColumnName("vlrjuro");
            entity.Property(e => e.Vlroriginal).HasColumnName("vlroriginal");
        });

        modelBuilder.Entity<TblRenegociarGerou>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_renegociar_gerou_pkey");

            entity.ToTable("tbl_renegociar_gerou");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codreneg).HasColumnName("codreneg");
            entity.Property(e => e.Tipo)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("tipo");
            entity.Property(e => e.Valor)
                .HasPrecision(12, 2)
                .HasColumnName("valor");
            entity.Property(e => e.Vencimento).HasColumnName("vencimento");
        });

        modelBuilder.Entity<TblRenegociarOcorre>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_renegociar_ocorre_pkey");

            entity.ToTable("tbl_renegociar_ocorre");

            entity.Property(e => e.Codigo)
                .ValueGeneratedNever()
                .HasColumnName("codigo");
            entity.Property(e => e.Ocorrencia)
                .HasMaxLength(40)
                .HasColumnName("ocorrencia");
        });

        modelBuilder.Entity<TblRenegociarOcorrencium>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_renegociar_ocorrencia_pkey");

            entity.ToTable("tbl_renegociar_ocorrencia");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codocorrencia).HasColumnName("codocorrencia");
            entity.Property(e => e.Codreneg).HasColumnName("codreneg");
            entity.Property(e => e.Obs)
                .HasMaxLength(60)
                .HasColumnName("obs");
        });

        modelBuilder.Entity<TblRenegociarPago>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_renegociar_pago_pkey");

            entity.ToTable("tbl_renegociar_pago");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Atraso).HasColumnName("atraso");
            entity.Property(e => e.Codparcela).HasColumnName("codparcela");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(11)
                .HasColumnName("codpedido");
            entity.Property(e => e.Codreneg).HasColumnName("codreneg");
            entity.Property(e => e.Valor)
                .HasPrecision(12, 2)
                .HasColumnName("valor");
            entity.Property(e => e.Valoratual).HasColumnName("valoratual");
            entity.Property(e => e.Vencimento).HasColumnName("vencimento");
        });

        modelBuilder.Entity<TblRenegociarSenha>(entity =>
        {
            entity.HasKey(e => e.Codusuario).HasName("tbl_renegociar_senha_pkey");

            entity.ToTable("tbl_renegociar_senha");

            entity.Property(e => e.Codusuario)
                .ValueGeneratedNever()
                .HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Senha).HasColumnName("senha");
            entity.Property(e => e.Usuario).HasColumnName("usuario");
        });

        modelBuilder.Entity<TblRomaEstornadoHistorico>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_roma_estornado_historico_pkey");

            entity.ToTable("tbl_roma_estornado_historico");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codromaneio).HasColumnName("codromaneio");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
        });

        modelBuilder.Entity<TblRomaPermissao>(entity =>
        {
            entity.HasKey(e => e.Codusuario).HasName("tbl_roma_permissao_pkey");

            entity.ToTable("tbl_roma_permissao");

            entity.Property(e => e.Codusuario)
                .ValueGeneratedNever()
                .HasComment("Codigo do usuario")
                .HasColumnName("codusuario");
            entity.Property(e => e.Codrota).HasColumnName("codrota");
        });

        modelBuilder.Entity<TblRomaReagendar>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_roma_reagendar_pkey");

            entity.ToTable("tbl_roma_reagendar");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblromareagendar'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Agendoupara)
                .HasComment("Agendou para essa data")
                .HasColumnName("agendoupara");
            entity.Property(e => e.Atualizado)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("atualizado");
            entity.Property(e => e.Codidromaneio)
                .HasComment("codigo de identificação do romaneio")
                .HasColumnName("codidromaneio");
            entity.Property(e => e.Codmotivo).HasColumnName("codmotivo");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Dataentrega)
                .HasComment("Data que estava agendada a entrega")
                .HasColumnName("dataentrega");
            entity.Property(e => e.Motivo)
                .HasMaxLength(30)
                .HasColumnName("motivo");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'E'::bpchar")
                .HasComment("Tipo de reagendamento, entrega ou montagem")
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TblRomaneio>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_romaneio_pkey");

            entity.ToTable("tbl_romaneio", tb => tb.HasComment("codrota é o código da tbl_rota_romaneio\ncodveiculo e veiculo é da tbl_veiculo\nconfirmado = 'S' -  pedido foi impresso (finalizado)\nsituacao = 'S' - foi entregue\na coluna NFE contém a nota fiscal do romaneio na tbl_nfe.\nO documento das transferências tbl_transfestoque diverge do documento da tbl_nfe, não há correlação. As colunas correlacionadas são id da tbl_nfe e nfe da tbl_romaneio.\n"));

            entity.HasIndex(e => e.Codproduto, "tbl_romaneio_index_codproduto");

            entity.HasIndex(e => e.Dataentrega, "tbl_romaneio_index_dataentrega");

            entity.HasIndex(e => e.Documento, "tbl_romaneio_index_documento");

            entity.HasIndex(e => e.Origem, "tbl_romaneio_origem");

            entity.HasIndex(e => e.Situacao, "tbl_romaneio_situacao");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblpreromaneio'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Alterapor)
                .HasMaxLength(50)
                .HasColumnName("alterapor");
            entity.Property(e => e.Bairro)
                .HasMaxLength(80)
                .HasColumnName("bairro");
            entity.Property(e => e.Baixadopor)
                .HasMaxLength(35)
                .HasColumnName("baixadopor");
            entity.Property(e => e.Baixamontagem)
                .HasComment("data da baixa da montagem")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("baixamontagem");
            entity.Property(e => e.Baixamontagempor)
                .HasMaxLength(35)
                .HasComment("Baixa da montagem")
                .HasColumnName("baixamontagempor");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("se pedido for cancelado e produto for continuar no romaneio marcar como 'S'")
                .HasColumnName("cancelado");
            entity.Property(e => e.Carregado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("carregado");
            entity.Property(e => e.Carregadopor)
                .HasMaxLength(35)
                .HasColumnName("carregadopor");
            entity.Property(e => e.Cidade)
                .HasMaxLength(50)
                .HasColumnName("cidade");
            entity.Property(e => e.Cliente)
                .HasMaxLength(80)
                .HasColumnName("cliente");
            entity.Property(e => e.Codbairro).HasColumnName("codbairro");
            entity.Property(e => e.Codcidade).HasColumnName("codcidade");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Coddestino).HasColumnName("coddestino");
            entity.Property(e => e.Codfabrica)
                .HasMaxLength(25)
                .HasColumnName("codfabrica");
            entity.Property(e => e.Codnovopedido)
                .HasMaxLength(12)
                .HasComment("codigo do novo pedido quando o pedido for cancelado e sustituido por outro")
                .HasColumnName("codnovopedido");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(11)
                .HasColumnName("codpedido");
            entity.Property(e => e.Codpedidoantes)
                .HasMaxLength(12)
                .HasComment("codigo do pedido anterior se o pedido for um pedido de cancelamento")
                .HasColumnName("codpedidoantes");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(18)
                .HasColumnName("codproduto");
            entity.Property(e => e.Codromaneio)
                .HasComment("Codigo do romaneio")
                .HasColumnName("codromaneio");
            entity.Property(e => e.Codrota)
                .HasComment("Rota a qual a entrega Pertence")
                .HasColumnName("codrota");
            entity.Property(e => e.Codsubpedido).HasColumnName("codsubpedido");
            entity.Property(e => e.Codusuario)
                .HasComment("codigo do usuario que lançou o produto.")
                .HasColumnName("codusuario");
            entity.Property(e => e.Codveiculo).HasColumnName("codveiculo");
            entity.Property(e => e.Codveiculomonta).HasColumnName("codveiculomonta");
            entity.Property(e => e.Confirmado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("confirmado = 'S' é sinal que o pedido foi finalizado no caixa")
                .HasColumnName("confirmado");
            entity.Property(e => e.Dataaltera).HasColumnName("dataaltera");
            entity.Property(e => e.Datacarregamento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datacarregamento");
            entity.Property(e => e.Datacompra).HasColumnName("datacompra");
            entity.Property(e => e.Dataentrega).HasColumnName("dataentrega");
            entity.Property(e => e.Dataentregaloja)
                .HasComment("data entrega loja")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataentregaloja");
            entity.Property(e => e.Dataentregou).HasColumnName("dataentregou");
            entity.Property(e => e.DataimpCf)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataimp_cf");
            entity.Property(e => e.DataimpNt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataimp_nt");
            entity.Property(e => e.Datamontagem).HasColumnName("datamontagem");
            entity.Property(e => e.Datapedido)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datapedido");
            entity.Property(e => e.Descricao)
                .HasMaxLength(90)
                .HasColumnName("descricao");
            entity.Property(e => e.Destino)
                .HasMaxLength(50)
                .HasColumnName("destino");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .HasColumnName("documento");
            entity.Property(e => e.Endereco)
                .HasMaxLength(150)
                .HasColumnName("endereco");
            entity.Property(e => e.Entregaloja)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("se o produto ja foi retirado da loja para entrega")
                .HasColumnName("entregaloja");
            entity.Property(e => e.Entreguepor)
                .HasMaxLength(35)
                .HasComment("usuario que entregou produto da loja")
                .HasColumnName("entreguepor");
            entity.Property(e => e.Estoqueanterior)
                .HasDefaultValueSql("0")
                .HasComment("Estoque anterior ")
                .HasColumnName("estoqueanterior");
            entity.Property(e => e.Excluir)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("se pedido for cancelado marcar como 's' para excluir do romaneio")
                .HasColumnName("excluir");
            entity.Property(e => e.Fone)
                .HasMaxLength(45)
                .HasColumnName("fone");
            entity.Property(e => e.ImpCf)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("imp_cf");
            entity.Property(e => e.Impentrega)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("impressao do romaneio de entrega")
                .HasColumnName("impentrega");
            entity.Property(e => e.Impmontagem)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("impmontagem");
            entity.Property(e => e.Liberado)
                .HasMaxLength(20)
                .HasComment("Nome de quem liberou a entrega se a agenda estivesse bloqueada")
                .HasColumnName("liberado");
            entity.Property(e => e.LojaBaixaEstoque).HasColumnName("loja_baixa_estoque");
            entity.Property(e => e.Marcar).HasColumnName("marcar");
            entity.Property(e => e.Montado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("montado");
            entity.Property(e => e.Montar)
                .HasMaxLength(1)
                .HasColumnName("montar");
            entity.Property(e => e.MotivoNaocarregou)
                .HasDefaultValueSql("0")
                .HasColumnName("motivo_naocarregou");
            entity.Property(e => e.Nfce)
                .HasDefaultValueSql("0")
                .HasColumnName("nfce");
            entity.Property(e => e.Nfe)
                .HasDefaultValueSql("0")
                .HasColumnName("nfe");
            entity.Property(e => e.NumeroCf)
                .HasDefaultValueSql("0")
                .HasColumnName("numero_cf");
            entity.Property(e => e.NumeroNt)
                .HasMaxLength(10)
                .HasColumnName("numero_nt");
            entity.Property(e => e.Obsdaentrega).HasColumnName("obsdaentrega");
            entity.Property(e => e.ObservacaoEcommerce)
                .HasComment("campo abastecido na tela FrmEcRomaneiosCancelamento, de utilização da Karol (coordenadora EC) e Rafael (gerente de logística).\r\n\r\n")
                .HasColumnName("observacao_ecommerce");
            entity.Property(e => e.Obsmontagem)
                .HasComment("Observacoes da montagem")
                .HasColumnName("obsmontagem");
            entity.Property(e => e.Obsparaentrega)
                .HasComment("observações para entrega")
                .HasColumnName("obsparaentrega");
            entity.Property(e => e.Origem)
                .HasDefaultValueSql("0")
                .HasColumnName("origem");
            entity.Property(e => e.Osassistencia).HasColumnName("osassistencia");
            entity.Property(e => e.PedidoEc)
                .HasDefaultValueSql("false")
                .HasColumnName("pedido_ec");
            entity.Property(e => e.Periodoentrega)
                .HasMaxLength(8)
                .HasColumnName("periodoentrega");
            entity.Property(e => e.Quantidade).HasColumnName("quantidade");
            entity.Property(e => e.Quantimpremonta)
                .HasDefaultValueSql("0")
                .HasComment("quantidade que romaneio de montagem foi impresso")
                .HasColumnName("quantimpremonta");
            entity.Property(e => e.Quantimpresso)
                .HasDefaultValueSql("0")
                .HasComment("Quantidade de veses que foi impresso esse produto")
                .HasColumnName("quantimpresso");
            entity.Property(e => e.Recloja)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("se a transferencia foi aceita pela loja de destino")
                .HasColumnName("recloja");
            entity.Property(e => e.Romamontagem)
                .HasMaxLength(1)
                .HasComment("Gerar romaneio de montagem? S/N")
                .HasColumnName("romamontagem");
            entity.Property(e => e.Separado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("separado");
            entity.Property(e => e.SerieEcf)
                .HasMaxLength(20)
                .HasColumnName("serie_ecf");
            entity.Property(e => e.Situacao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("situacao");
            entity.Property(e => e.StatusCarregamento).HasColumnName("status_carregamento");
            entity.Property(e => e.Statusagenda)
                .HasDefaultValueSql("0")
                .HasComment("status da agenda na hora do lançamento do produto no romaneio")
                .HasColumnName("statusagenda");
            entity.Property(e => e.Tempoentrega)
                .HasDefaultValueSql("0")
                .HasComment("Tempo de entrega do produto")
                .HasColumnName("tempoentrega");
            entity.Property(e => e.Tempomontagem).HasColumnName("tempomontagem");
            entity.Property(e => e.Tipoassist)
                .HasMaxLength(10)
                .HasColumnName("tipoassist");
            entity.Property(e => e.Tiporomaneio)
                .HasMaxLength(50)
                .HasColumnName("tiporomaneio");
            entity.Property(e => e.TransfVinculada)
                .HasMaxLength(12)
                .HasColumnName("transf_vinculada");
            entity.Property(e => e.UserimpCf).HasColumnName("userimp_cf");
            entity.Property(e => e.UserimpNt).HasColumnName("userimp_nt");
            entity.Property(e => e.Veiculo)
                .HasMaxLength(50)
                .HasColumnName("veiculo");
            entity.Property(e => e.Veiculomonta)
                .HasMaxLength(25)
                .HasColumnName("veiculomonta");
            entity.Property(e => e.Vinculado)
                .HasDefaultValueSql("0")
                .HasColumnName("vinculado");
        });

        modelBuilder.Entity<TblRomaneioAutoriza>(entity =>
        {
            entity.HasKey(e => e.Codusuario).HasName("tbl_romaneio_autoriza_pkey");

            entity.ToTable("tbl_romaneio_autoriza", tb => tb.HasComment("Usuario que podem liberar produtos que estão bloqueados na agenda de entrega"));

            entity.Property(e => e.Codusuario)
                .ValueGeneratedNever()
                .HasColumnName("codusuario");
        });

        modelBuilder.Entity<TblRomaneioLogAlteracaoEndereco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_romaneio_log_alteracao_endereco_pkey");

            entity.ToTable("tbl_romaneio_log_alteracao_endereco");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bairronovo)
                .HasMaxLength(50)
                .HasColumnName("bairronovo");
            entity.Property(e => e.Bairroold)
                .HasMaxLength(50)
                .HasColumnName("bairroold");
            entity.Property(e => e.Codbairronovo).HasColumnName("codbairronovo");
            entity.Property(e => e.Codloja)
                .HasMaxLength(50)
                .HasColumnName("codloja");
            entity.Property(e => e.Datahora)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datahora");
            entity.Property(e => e.Idcliente).HasColumnName("idcliente");
            entity.Property(e => e.Login)
                .HasMaxLength(20)
                .HasColumnName("login");
            entity.Property(e => e.Numeroromaneio).HasColumnName("numeroromaneio");
            entity.Property(e => e.Observacao)
                .HasMaxLength(100)
                .HasColumnName("observacao");
            entity.Property(e => e.Ruanova)
                .HasMaxLength(50)
                .HasColumnName("ruanova");
            entity.Property(e => e.Ruaold)
                .HasMaxLength(50)
                .HasColumnName("ruaold");
        });

        modelBuilder.Entity<TblRomaneioLoja>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_romaneio_loja_pkey");

            entity.ToTable("tbl_romaneio_loja", tb => tb.HasComment("Romaneio dos produtos que o cliente leva na hora da compra"));

            entity.HasIndex(e => e.Codproduto, "tbl_romaneio_loja_index_codproduto");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblromaneioloja'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Bairro)
                .HasMaxLength(60)
                .HasColumnName("bairro");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("se pedido foi cancelado")
                .HasColumnName("cancelado");
            entity.Property(e => e.Cidade)
                .HasMaxLength(40)
                .HasColumnName("cidade");
            entity.Property(e => e.Cliente)
                .HasMaxLength(55)
                .HasColumnName("cliente");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codfabrica)
                .HasMaxLength(25)
                .HasColumnName("codfabrica");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Codveiculo).HasColumnName("codveiculo");
            entity.Property(e => e.Conferido).HasColumnName("conferido");
            entity.Property(e => e.Confirmado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("confirmado");
            entity.Property(e => e.Dataconferido)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataconferido");
            entity.Property(e => e.Dataentrega)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataentrega");
            entity.Property(e => e.Datapedido)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datapedido");
            entity.Property(e => e.Descricao)
                .HasMaxLength(90)
                .HasColumnName("descricao");
            entity.Property(e => e.Endereco)
                .HasMaxLength(55)
                .HasColumnName("endereco");
            entity.Property(e => e.Entregar)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("entregar");
            entity.Property(e => e.Entregue)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("entregue");
            entity.Property(e => e.Entreguepor)
                .HasMaxLength(35)
                .HasColumnName("entreguepor");
            entity.Property(e => e.Estoqueanterior).HasColumnName("estoqueanterior");
            entity.Property(e => e.Fone)
                .HasMaxLength(45)
                .HasColumnName("fone");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.Origem).HasColumnName("origem");
            entity.Property(e => e.Pedido)
                .HasMaxLength(12)
                .HasColumnName("pedido");
            entity.Property(e => e.Quantidade).HasColumnName("quantidade");
            entity.Property(e => e.Reagendou)
                .HasDefaultValueSql("'N'::\"char\"")
                .HasColumnType("char")
                .HasColumnName("reagendou");
            entity.Property(e => e.Retiradopor)
                .HasMaxLength(30)
                .HasColumnName("retiradopor");
            entity.Property(e => e.Veiculo)
                .HasMaxLength(35)
                .HasColumnName("veiculo");
        });

        modelBuilder.Entity<TblRomaneioStatus>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_romaneio_status_pkey");

            entity.ToTable("tbl_romaneio_status", tb => tb.HasComment("tabela que indica o status do romaneio para determinado dia"));

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblromaneiostatus'::regclass)")
                .HasComment("codigo da operação")
                .HasColumnName("codigo");
            entity.Property(e => e.Atualizado)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("atualizado");
            entity.Property(e => e.Data)
                .HasComment("Data do romaneio")
                .HasColumnName("data");
            entity.Property(e => e.Obs)
                .HasComment("Observações de entrega")
                .HasColumnName("obs");
            entity.Property(e => e.Rota)
                .HasComment("Rota do romaneio")
                .HasColumnName("rota");
            entity.Property(e => e.Situacao).HasColumnName("situacao");
            entity.Property(e => e.Usuario)
                .HasMaxLength(25)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<TblRotaRomaneio>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_rota_romaneio_pkey");

            entity.ToTable("tbl_rota_romaneio");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblrotaromaneio'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Ativo)
                .HasDefaultValueSql("true")
                .HasColumnName("ativo");
            entity.Property(e => e.Atualizado)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("atualizado");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Endereco)
                .HasMaxLength(55)
                .HasColumnName("endereco");
            entity.Property(e => e.Frete)
                .HasPrecision(6, 2)
                .HasColumnName("frete");
            entity.Property(e => e.Quantidade)
                .HasDefaultValueSql("0")
                .HasComment("Quantidade de produtos para bloquear romaneio")
                .HasColumnName("quantidade");
            entity.Property(e => e.Rota)
                .HasMaxLength(60)
                .HasComment("Rota do Romaneio")
                .HasColumnName("rota");
            entity.Property(e => e.Tempo)
                .HasDefaultValueSql("0")
                .HasComment("Tempo para bloqueio do romaneio")
                .HasColumnName("tempo");
        });

        modelBuilder.Entity<TblRotina>(entity =>
        {
            entity.HasKey(e => e.CodRotina).HasName("tbl_rotina_pkey");

            entity.ToTable("tbl_rotina");

            entity.Property(e => e.CodRotina).HasColumnName("cod_rotina");
            entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.DataAbertura).HasColumnName("data_abertura");
            entity.Property(e => e.DataFim).HasColumnName("data_fim");
            entity.Property(e => e.Fechado).HasColumnName("fechado");
            entity.Property(e => e.Nota)
                .HasPrecision(6, 2)
                .HasColumnName("nota");
        });

        modelBuilder.Entity<TblRotinaIten>(entity =>
        {
            entity.HasKey(e => e.CodItem).HasName("tbl_rotina_itens_pkey");

            entity.ToTable("tbl_rotina_itens");

            entity.Property(e => e.CodItem).HasColumnName("cod_item");
            entity.Property(e => e.Ativo).HasColumnName("ativo");
            entity.Property(e => e.Descricao).HasColumnName("descricao");
            entity.Property(e => e.Link)
                .HasMaxLength(60)
                .HasColumnName("link");
            entity.Property(e => e.Nome)
                .HasMaxLength(40)
                .HasColumnName("nome");
            entity.Property(e => e.Ordenacao)
                .HasDefaultValueSql("0")
                .HasColumnName("ordenacao");
            entity.Property(e => e.Peso).HasColumnName("peso");
            entity.Property(e => e.Tipo)
                .HasColumnType("char")
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TblRotinaItensAval>(entity =>
        {
            entity.HasKey(e => e.CodItemAval).HasName("cod_item_aval");

            entity.ToTable("tbl_rotina_itens_aval");

            entity.Property(e => e.CodItemAval).HasColumnName("cod_item_aval");
            entity.Property(e => e.CodItem).HasColumnName("cod_item");
            entity.Property(e => e.CodRotina).HasColumnName("cod_rotina");
            entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");
            entity.Property(e => e.Nota).HasColumnName("nota");
            entity.Property(e => e.Obs).HasColumnName("obs");
        });

        modelBuilder.Entity<TblScoreBv>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_score_bv_pkey");

            entity.ToTable("tbl_score_bv");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Dataconsulta)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataconsulta");
            entity.Property(e => e.Excluido)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("excluido");
            entity.Property(e => e.Informante)
                .HasMaxLength(20)
                .HasColumnName("informante");
            entity.Property(e => e.Instituicao)
                .HasMaxLength(45)
                .HasColumnName("instituicao");
            entity.Property(e => e.Situacao)
                .HasMaxLength(25)
                .HasColumnName("situacao");
            entity.Property(e => e.Stringcompleta).HasColumnName("stringcompleta");
            entity.Property(e => e.Tipo)
                .HasMaxLength(7)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TblScoreLoja>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_score_loja_pkey");

            entity.ToTable("tbl_score_loja");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ajustado).HasColumnName("ajustado");
            entity.Property(e => e.Cor)
                .HasMaxLength(12)
                .HasComment("classificação do score por cor")
                .HasColumnName("cor");
            entity.Property(e => e.Emprego)
                .HasMaxLength(40)
                .HasColumnName("emprego");
            entity.Property(e => e.EntrouP).HasColumnName("entrou_p");
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(40)
                .HasColumnName("estado_civil");
            entity.Property(e => e.Outlier)
                .HasMaxLength(15)
                .HasColumnName("outlier");
            entity.Property(e => e.Qtd).HasColumnName("qtd");
            entity.Property(e => e.Residencia)
                .HasMaxLength(40)
                .HasColumnName("residencia");
            entity.Property(e => e.Risco).HasColumnName("risco");
            entity.Property(e => e.Spc)
                .HasMaxLength(40)
                .HasColumnName("spc");
        });

        modelBuilder.Entity<TblScoreLojaHist>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_score_loja_hist_pkey");

            entity.ToTable("tbl_score_loja_hist");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Agravantes).HasColumnName("agravantes");
            entity.Property(e => e.Atenuantes).HasColumnName("atenuantes");
            entity.Property(e => e.Codprepedido).HasColumnName("codprepedido");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.InterpScore).HasColumnName("interp_score");
            entity.Property(e => e.Score)
                .HasMaxLength(15)
                .HasColumnName("score");
            entity.Property(e => e.SenhaCoordenador)
                .HasPrecision(6, 2)
                .HasColumnName("senha_coordenador");
            entity.Property(e => e.SenhaGerente)
                .HasPrecision(6, 2)
                .HasColumnName("senha_gerente");
            entity.Property(e => e.SenhaVendedor)
                .HasPrecision(6, 2)
                .HasColumnName("senha_vendedor");
        });

        modelBuilder.Entity<TblScoreLojaResult>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("serial");

            entity.ToTable("tbl_score_loja_result");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Cor)
                .HasMaxLength(12)
                .HasColumnName("cor");
            entity.Property(e => e.Interpretacao).HasColumnName("interpretacao");
        });

        modelBuilder.Entity<TblScoreLojaSenha>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_score_loja_senha_pkey");

            entity.ToTable("tbl_score_loja_senha");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codfuncao).HasColumnName("codfuncao");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Senha)
                .HasPrecision(6, 2)
                .HasColumnName("senha");
        });

        modelBuilder.Entity<TblScoreTabela>(entity =>
        {
            entity.HasKey(e => e.CodScore).HasName("tbl_score_tabela_pkey");

            entity.ToTable("tbl_score_tabela");

            entity.Property(e => e.CodScore).HasColumnName("cod_score");
            entity.Property(e => e.Caracteristica).HasColumnName("caracteristica");
            entity.Property(e => e.Classe)
                .HasDefaultValueSql("nextval('tbl_cons_score_boavista_classe_de_score_seq'::regclass)")
                .HasColumnName("classe");
            entity.Property(e => e.Cor)
                .HasColumnType("character varying")
                .HasColumnName("cor");
            entity.Property(e => e.FaixaMax).HasColumnName("faixa_max");
            entity.Property(e => e.FaixaMin).HasColumnName("faixa_min");
            entity.Property(e => e.Grupo)
                .HasColumnType("char")
                .HasColumnName("grupo");
            entity.Property(e => e.Probabilidade).HasColumnName("probabilidade");
            entity.Property(e => e.Tipo)
                .HasComment("se é score 6 meses, 12 ou 18\n")
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TblSeguroSabemi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_seguro_sabemi_pkey");

            entity.ToTable("tbl_seguro_sabemi");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apolice)
                .HasMaxLength(30)
                .HasColumnName("apolice");
            entity.Property(e => e.Arquivo).HasColumnName("arquivo");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.CodigoCancelado).HasColumnName("codigo_cancelado");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.CodusuarioCaixa).HasColumnName("codusuario_caixa");
            entity.Property(e => e.CodusuarioVendedor).HasColumnName("codusuario_vendedor");
            entity.Property(e => e.Conjuge).HasColumnName("conjuge");
            entity.Property(e => e.Contrato)
                .HasMaxLength(15)
                .HasColumnName("contrato");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("now()")
                .HasColumnName("data");
            entity.Property(e => e.DataEnvio).HasColumnName("data_envio");
            entity.Property(e => e.DataRetorno).HasColumnName("data_retorno");
            entity.Property(e => e.MensagemRetorno)
                .HasMaxLength(500)
                .HasColumnName("mensagem_retorno");
            entity.Property(e => e.NumSorte)
                .HasMaxLength(15)
                .HasColumnName("num_sorte");
        });

        modelBuilder.Entity<TblSenhaNegadum>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_senha_negada_pkey");

            entity.ToTable("tbl_senha_negada");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Motivo).HasColumnName("motivo");
            entity.Property(e => e.Senha).HasColumnName("senha");
            entity.Property(e => e.Usuario)
                .HasMaxLength(45)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<TblSequenciaE>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_sequencia_es_pkey");

            entity.ToTable("tbl_sequencia_es");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Arquivo)
                .HasMaxLength(3)
                .HasColumnName("arquivo");
            entity.Property(e => e.Atualizado).HasColumnName("atualizado");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.Dataenvio).HasColumnName("dataenvio");
            entity.Property(e => e.Erro).HasColumnName("erro");
            entity.Property(e => e.Sequencia).HasColumnName("sequencia");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
        });

        modelBuilder.Entity<TblServSistema>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_serv_sistema_pkey");

            entity.ToTable("tbl_serv_sistema", tb => tb.HasComment("serviços a serem executados no sistema\n"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Datapronto)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datapronto");
            entity.Property(e => e.Datasolicita)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datasolicita");
            entity.Property(e => e.Datateste)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datateste");
            entity.Property(e => e.Execucao)
                .HasDefaultValueSql("0")
                .HasComment("0 - JOAO\n1 - GUILHERME")
                .HasColumnName("execucao");
            entity.Property(e => e.Finalizar)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("finalizar");
            entity.Property(e => e.Novo)
                .HasDefaultValueSql("1")
                .HasColumnName("novo");
            entity.Property(e => e.Obspronto).HasColumnName("obspronto");
            entity.Property(e => e.Obsteste).HasColumnName("obsteste");
            entity.Property(e => e.Previsao).HasColumnName("previsao");
            entity.Property(e => e.Prioridade)
                .HasDefaultValueSql("0")
                .HasColumnName("prioridade");
            entity.Property(e => e.Pronto)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("pronto");
            entity.Property(e => e.Servico).HasColumnName("servico");
            entity.Property(e => e.Testado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("testado");
            entity.Property(e => e.Titulo)
                .HasMaxLength(40)
                .HasColumnName("titulo");
            entity.Property(e => e.Userexecutado).HasColumnName("userexecutado");
            entity.Property(e => e.Userteste).HasColumnName("userteste");
            entity.Property(e => e.Usuario).HasColumnName("usuario");
        });

        modelBuilder.Entity<TblSincBlackList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_sinc_black_list_pkey");

            entity.ToTable("tbl_sinc_black_list");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Chave)
                .HasMaxLength(44)
                .HasColumnName("chave");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Mensagem)
                .HasMaxLength(100)
                .HasColumnName("mensagem");
            entity.Property(e => e.PermiteIncluir).HasColumnName("permite_incluir");
        });

        modelBuilder.Entity<TblSincConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_sinc_config_pkey");

            entity.ToTable("tbl_sinc_config");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<TblSincCstDespesa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_sinc_cst_despesa_pkey");

            entity.ToTable("tbl_sinc_cst_despesa");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cfop).HasColumnName("cfop");
            entity.Property(e => e.Cst).HasColumnName("cst");
            entity.Property(e => e.CstsOriginal)
                .HasColumnType("character varying")
                .HasColumnName("csts_original");
        });

        modelBuilder.Entity<TblSincEnvio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_sinc_envio_pkey");

            entity.ToTable("tbl_sinc_envio");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Chave)
                .HasMaxLength(44)
                .HasColumnName("chave");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Emitente)
                .HasMaxLength(14)
                .HasColumnName("emitente");
            entity.Property(e => e.MensagemErro)
                .HasMaxLength(200)
                .HasColumnName("mensagem_erro");
            entity.Property(e => e.Numnota)
                .HasMaxLength(10)
                .HasColumnName("numnota");
            entity.Property(e => e.Serie)
                .HasMaxLength(5)
                .HasColumnName("serie");
            entity.Property(e => e.Teste).HasColumnName("teste");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
        });

        modelBuilder.Entity<TblSincFecha>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_sinc_fecha_pkey");

            entity.ToTable("tbl_sinc_fecha");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.DataFechamento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_fechamento");
            entity.Property(e => e.Emitente).HasColumnName("emitente");
        });

        modelBuilder.Entity<TblSincFechamento>(entity =>
        {
            entity.HasKey(e => e.DataFechamento).HasName("tbl_sinc_fechamento_pkey");

            entity.ToTable("tbl_sinc_fechamento");

            entity.Property(e => e.DataFechamento).HasColumnName("data_fechamento");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.DataCadastro)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_cadastro");
        });

        modelBuilder.Entity<TblSincIgnoraFechamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_sinc_ignora_fechamento_pkey");

            entity.ToTable("tbl_sinc_ignora_fechamento");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChaveNf)
                .HasMaxLength(44)
                .HasColumnName("chave_nf");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.DataFechamento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_fechamento");
            entity.Property(e => e.DataRecepcao)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_recepcao");
        });

        modelBuilder.Entity<TblSincNotimp>(entity =>
        {
            entity.HasKey(e => e.Identificador).HasName("tbl_sinc_notimp_pkey");

            entity.ToTable("tbl_sinc_notimp");

            entity.Property(e => e.Identificador)
                .ValueGeneratedNever()
                .HasColumnName("identificador");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
        });

        modelBuilder.Entity<TblSincRegraCfop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_sinc_regra_cfop_pkey");

            entity.ToTable("tbl_sinc_regra_cfop");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CfopNotaDeveTer).HasColumnName("cfop_nota_deve_ter");
            entity.Property(e => e.CfopResultado).HasColumnName("cfop_resultado");
            entity.Property(e => e.CsosnNotaDeveTer)
                .HasMaxLength(5)
                .HasColumnName("csosn_nota_deve_ter");
            entity.Property(e => e.CstNotaDeveTer)
                .HasMaxLength(5)
                .HasColumnName("cst_nota_deve_ter");
            entity.Property(e => e.GrupoRegra)
                .HasDefaultValueSql("1")
                .HasColumnName("grupo_regra");
            entity.Property(e => e.TipoNota).HasColumnName("tipo_nota");
        });

        modelBuilder.Entity<TblSincRegraDespesa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_sinc_regra_despesa_pkey");

            entity.ToTable("tbl_sinc_regra_despesa");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("'2022-10-27 12:30:52.773763'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.TipoNota).HasColumnName("tipo_nota");
        });

        modelBuilder.Entity<TblSincSolicitaEnvio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_sinc_solicita_envio_pkey");

            entity.ToTable("tbl_sinc_solicita_envio");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.CodusuarioCancelou).HasColumnName("codusuario_cancelou");
            entity.Property(e => e.IniciadoEm)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("iniciado_em");
            entity.Property(e => e.IntervaloFim)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("intervalo_fim");
            entity.Property(e => e.IntervaloInicio)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("intervalo_inicio");
            entity.Property(e => e.Mensagem)
                .HasMaxLength(500)
                .HasColumnName("mensagem");
            entity.Property(e => e.Operacoes)
                .HasMaxLength(20)
                .HasColumnName("operacoes");
            entity.Property(e => e.Recepcao)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("recepcao");
            entity.Property(e => e.RepetirEm).HasColumnName("repetir_em");
            entity.Property(e => e.SolicitaProcessoFim)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("solicita_processo_fim");
            entity.Property(e => e.SolicitaProcessoInicio)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("solicita_processo_inicio");
            entity.Property(e => e.Teste).HasColumnName("teste");
        });

        modelBuilder.Entity<TblSitefBaixa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_sitef_baixa_pkey");

            entity.ToTable("tbl_sitef_baixa");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bruto)
                .HasPrecision(10, 2)
                .HasColumnName("bruto");
            entity.Property(e => e.Caixa).HasColumnName("caixa");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Liquido)
                .HasPrecision(10, 2)
                .HasColumnName("liquido");
            entity.Property(e => e.Nsu).HasColumnName("nsu");
        });

        modelBuilder.Entity<TblSitefCancelamento>(entity =>
        {
            entity.HasKey(e => e.IdCancelamento).HasName("tbl_sitef_cancelamento_pkey");

            entity.ToTable("tbl_sitef_cancelamento");

            entity.Property(e => e.IdCancelamento).HasColumnName("id_cancelamento");
            entity.Property(e => e.CupomCancelamento).HasColumnName("cupom_cancelamento");
            entity.Property(e => e.CupomVenda).HasColumnName("cupom_venda");
        });

        modelBuilder.Entity<TblSitefCreditoCliente>(entity =>
        {
            entity.HasKey(e => e.CupomFiscal).HasName("tbl_sitef_parcial_pkey");

            entity.ToTable("tbl_sitef_credito_cliente");

            entity.Property(e => e.CupomFiscal)
                .ValueGeneratedNever()
                .HasColumnName("cupom_fiscal");
            entity.Property(e => e.Finalizado)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("finalizado");
        });

        modelBuilder.Entity<TblSitefRefVendum>(entity =>
        {
            entity.HasKey(e => new { e.Codigo, e.CupomFiscal }).HasName("tbl_sitef_ref_venda_pkey");

            entity.ToTable("tbl_sitef_ref_venda");

            entity.Property(e => e.Codigo)
                .HasMaxLength(36)
                .HasColumnName("codigo");
            entity.Property(e => e.CupomFiscal).HasColumnName("cupom_fiscal");
        });

        modelBuilder.Entity<TblSitefTransacao>(entity =>
        {
            entity.HasKey(e => e.Idtransacao).HasName("tbl_sitef_transacao_pkey");

            entity.ToTable("tbl_sitef_transacao");

            entity.Property(e => e.Idtransacao).HasColumnName("idtransacao");
            entity.Property(e => e.CupomCancelamento).HasColumnName("cupom_cancelamento");
            entity.Property(e => e.CupomFiscal).HasColumnName("cupom_fiscal");
            entity.Property(e => e.DataTransacao)
                .HasDefaultValueSql("now()")
                .HasColumnName("data_transacao");
            entity.Property(e => e.NsuHost).HasColumnName("nsu_host");
            entity.Property(e => e.NsuSitef).HasColumnName("nsu_sitef");
            entity.Property(e => e.Parcelas)
                .HasDefaultValueSql("1")
                .HasColumnName("parcelas");
            entity.Property(e => e.Retornos).HasColumnName("retornos");
            entity.Property(e => e.Valor)
                .HasPrecision(10, 2)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<TblSitefVendaParcial>(entity =>
        {
            entity.HasKey(e => e.IdParcial).HasName("tbl_sitef_venda_parcial_pkey");

            entity.ToTable("tbl_sitef_venda_parcial");

            entity.Property(e => e.IdParcial).HasColumnName("id_parcial");
            entity.Property(e => e.CupomFiscal).HasColumnName("cupom_fiscal");
            entity.Property(e => e.TotalVenda)
                .HasPrecision(10, 2)
                .HasColumnName("total_venda");
        });

        modelBuilder.Entity<TblSitefVendum>(entity =>
        {
            entity.HasKey(e => e.CupomFiscal).HasName("tbl_sitef_venda_pkey");

            entity.ToTable("tbl_sitef_venda");

            entity.Property(e => e.CupomFiscal).HasColumnName("cupom_fiscal");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.CodusuarioAnaliseCliente).HasColumnName("codusuario_analise_cliente");
            entity.Property(e => e.CupomCancelamento).HasColumnName("cupom_cancelamento");
            entity.Property(e => e.DataAnaliseCliente)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_analise_cliente");
            entity.Property(e => e.DataInicio)
                .HasDefaultValueSql("now()")
                .HasColumnName("data_inicio");
            entity.Property(e => e.DataTransacao).HasColumnName("data_transacao");
            entity.Property(e => e.Empresa).HasColumnName("empresa");
            entity.Property(e => e.Idtransacao)
                .HasMaxLength(36)
                .HasColumnName("idtransacao");
            entity.Property(e => e.NsuHost).HasColumnName("nsu_host");
            entity.Property(e => e.NsuSitef).HasColumnName("nsu_sitef");
            entity.Property(e => e.Parcelas).HasColumnName("parcelas");
            entity.Property(e => e.Pdv)
                .HasMaxLength(8)
                .HasColumnName("pdv");
            entity.Property(e => e.Retornos).HasColumnName("retornos");
            entity.Property(e => e.TipoOperacao).HasColumnName("tipo_operacao");
            entity.Property(e => e.Valor)
                .HasPrecision(10, 2)
                .HasColumnName("valor");
            entity.Property(e => e.ValorBaixa)
                .HasPrecision(10, 2)
                .HasColumnName("valor_baixa");
        });

        modelBuilder.Entity<TblSolicitaNotaFiscal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_solicita_nota_fiscal_pkey");

            entity.ToTable("tbl_solicita_nota_fiscal");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Descricao)
                .HasMaxLength(300)
                .HasColumnName("descricao");
            entity.Property(e => e.NfeId).HasColumnName("nfe_id");
            entity.Property(e => e.Usuario).HasColumnName("usuario");
        });

        modelBuilder.Entity<TblSolicitaNotaFiscalProduto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_solicita_nota_fiscal_produto_pkey");

            entity.ToTable("tbl_solicita_nota_fiscal_produto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Quantidade).HasColumnName("quantidade");
            entity.Property(e => e.SolicitaId).HasColumnName("solicita_id");
        });

        modelBuilder.Entity<TblSolicitadesc>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_solicitadesc_pkey");

            entity.ToTable("tbl_solicitadesc", tb => tb.HasComment("Solicita aos Gerentes Autorização de desconto acima do permitido"));

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblsolicitadesc'::regclass)")
                .HasComment("Codigo da solicitação")
                .HasColumnName("codigo");
            entity.Property(e => e.Caixa)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("caixa");
            entity.Property(e => e.Codautoriza)
                .HasComment("Codigo de quem autorizou o desconto.")
                .HasColumnName("codautoriza");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codlojacaixa).HasColumnName("codlojacaixa");
            entity.Property(e => e.Codsolicitante)
                .HasComment("Codigo do Solicitante")
                .HasColumnName("codsolicitante");
            entity.Property(e => e.Dataautoriza)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataautoriza");
            entity.Property(e => e.Datasolicita)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datasolicita");
            entity.Property(e => e.Descconcedido)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasComment("valor do desconto autorizado")
                .HasColumnName("descconcedido");
            entity.Property(e => e.Descpermitido)
                .HasPrecision(12, 2)
                .HasComment("Desconto permitido")
                .HasColumnName("descpermitido");
            entity.Property(e => e.Descsolicitado)
                .HasPrecision(12, 2)
                .HasComment("Desconto solicitado")
                .HasColumnName("descsolicitado");
            entity.Property(e => e.Motivo).HasColumnName("motivo");
            entity.Property(e => e.MotivoGer)
                .HasComment("Motivo dado pelo gerente para o desconto")
                .HasColumnName("motivo_ger");
            entity.Property(e => e.Utilizado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("Se o desconto ja foi utilizado")
                .HasColumnName("utilizado");
            entity.Property(e => e.Validade)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("validade");
            entity.Property(e => e.Vlrapagar)
                .HasPrecision(12, 2)
                .HasComment("Valor a pagar com acrescimo")
                .HasColumnName("vlrapagar");
            entity.Property(e => e.Vlrdescautorizado)
                .HasPrecision(12, 2)
                .HasComment("Valor do desconto autorizado")
                .HasColumnName("vlrdescautorizado");
            entity.Property(e => e.Vlrparcelas)
                .HasPrecision(12, 2)
                .HasComment("valor das parcelas sem juro e sem desconto")
                .HasColumnName("vlrparcelas");
        });

        modelBuilder.Entity<TblSolicitatransf>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_solicitatransf_pkey");

            entity.ToTable("tbl_solicitatransf");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Autoriza)
                .HasDefaultValueSql("0")
                .HasColumnName("autoriza");
            entity.Property(e => e.Autoriza1)
                .HasDefaultValueSql("0")
                .HasColumnName("autoriza1");
            entity.Property(e => e.Autoriza2)
                .HasDefaultValueSql("0")
                .HasColumnName("autoriza2");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(11)
                .HasColumnName("codpedido");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Concluida)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("concluida");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Data2).HasColumnName("data2");
            entity.Property(e => e.Datasolicitada)
                .HasDefaultValueSql("now()")
                .HasColumnName("datasolicitada");
            entity.Property(e => e.Destino).HasColumnName("destino");
            entity.Property(e => e.Destino2)
                .HasDefaultValueSql("0")
                .HasColumnName("destino2");
            entity.Property(e => e.IdRomaneioVenda).HasColumnName("id_romaneio_venda");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.Obs2).HasColumnName("obs2");
            entity.Property(e => e.Obsautoriza).HasColumnName("obsautoriza");
            entity.Property(e => e.Obsautoriza1).HasColumnName("obsautoriza1");
            entity.Property(e => e.Obsautoriza2).HasColumnName("obsautoriza2");
            entity.Property(e => e.Origem).HasColumnName("origem");
            entity.Property(e => e.Quant).HasColumnName("quant");
            entity.Property(e => e.Romaneio)
                .HasMaxLength(30)
                .HasColumnName("romaneio");
            entity.Property(e => e.Solicitadopor)
                .HasDefaultValueSql("0")
                .HasColumnName("solicitadopor");
        });

        modelBuilder.Entity<TblSpcSerasa>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cptblspcserasa");

            entity.ToTable("tbl_spc_serasa");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblspcserasa'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Codconsulta)
                .HasMaxLength(20)
                .HasColumnName("codconsulta");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Dataconsulta)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataconsulta");
            entity.Property(e => e.Excluido)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("excluido");
            entity.Property(e => e.Informacao).HasColumnName("informacao");
            entity.Property(e => e.Informante)
                .HasMaxLength(20)
                .HasColumnName("informante");
            entity.Property(e => e.Instituicao)
                .HasMaxLength(45)
                .HasColumnName("instituicao");
            entity.Property(e => e.Situacao)
                .HasMaxLength(25)
                .HasColumnName("situacao");
            entity.Property(e => e.Tipo)
                .HasMaxLength(7)
                .HasColumnName("tipo");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<TblStatusEstoque>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_status_estoque_pkey");

            entity.ToTable("tbl_status_estoque", tb => tb.HasComment("Correlacionada com a tbl_prod_mov, abastecida na tela FrmStatusEstoque"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Divisao)
                .HasMaxLength(20)
                .HasColumnName("divisao");
            entity.Property(e => e.Porc)
                .HasPrecision(9, 2)
                .HasColumnName("porc");
            entity.Property(e => e.Valorcusto).HasColumnName("valorcusto");
            entity.Property(e => e.Valorvendido).HasColumnName("valorvendido");
        });

        modelBuilder.Entity<TblStatusEstoqueDep>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_status_estoque_dep_pkey");

            entity.ToTable("tbl_status_estoque_dep", tb => tb.HasComment("estado de estoque por departamento"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Coddepartamento).HasColumnName("coddepartamento");
            entity.Property(e => e.Custo).HasColumnName("custo");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Departamento)
                .HasMaxLength(200)
                .HasColumnName("departamento");
            entity.Property(e => e.EstoqueMedio)
                .HasPrecision(10, 2)
                .HasColumnName("estoque_medio");
            entity.Property(e => e.Venda).HasColumnName("venda");
        });

        modelBuilder.Entity<TblStefRefVendum>(entity =>
        {
            entity.HasKey(e => new { e.Codigo, e.CupomFiscal }).HasName("tbl_stef_ref_venda_pkey");

            entity.ToTable("tbl_stef_ref_venda");

            entity.Property(e => e.Codigo)
                .HasMaxLength(36)
                .HasColumnName("codigo");
            entity.Property(e => e.CupomFiscal).HasColumnName("cupom_fiscal");
        });

        modelBuilder.Entity<TblSubContagem>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_sub_contagem_pkey");

            entity.ToTable("tbl_sub_contagem");

            entity.HasIndex(e => e.Codcontagem, "index_cod_contagem");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Assistenciafim).HasColumnName("assistenciafim");
            entity.Property(e => e.Assistenciainicio).HasColumnName("assistenciainicio");
            entity.Property(e => e.Codcontagem).HasColumnName("codcontagem");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Custo)
                .HasPrecision(8, 2)
                .HasColumnName("custo");
            entity.Property(e => e.Entregafim).HasColumnName("entregafim");
            entity.Property(e => e.Entregainicio).HasColumnName("entregainicio");
            entity.Property(e => e.Estoquefim).HasColumnName("estoquefim");
            entity.Property(e => e.Estoqueinicio).HasColumnName("estoqueinicio");
            entity.Property(e => e.Fechaparcial)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("fechaparcial");
        });

        modelBuilder.Entity<TblSubContagem1>(entity =>
        {
            entity.HasKey(e => new { e.Codproduto, e.Idetiqueta, e.Codcontagem }).HasName("tbl_sub_contagem1_pkey");

            entity.ToTable("tbl_sub_contagem1");

            entity.HasIndex(e => e.Codcontagem, "index_tbl_sub_contagem1_codcontagem");

            entity.HasIndex(e => e.Codproduto, "index_tbl_sub_contagem1_codproduto");

            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Idetiqueta).HasColumnName("idetiqueta");
            entity.Property(e => e.Codcontagem).HasColumnName("codcontagem");
            entity.Property(e => e.Codigo)
                .ValueGeneratedOnAdd()
                .HasColumnName("codigo");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Quant)
                .HasDefaultValueSql("1")
                .HasColumnName("quant");
            entity.Property(e => e.Volume)
                .HasMaxLength(4)
                .HasColumnName("volume");
        });

        modelBuilder.Entity<TblSubContagemManu>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_sub_contagem_manu_pkey");

            entity.ToTable("tbl_sub_contagem_manu");

            entity.HasIndex(e => e.Codcontagem, "index_tbl_sub_contagem_manu_codcontagem");

            entity.HasIndex(e => e.Codproduto, "index_tbl_sub_contagem_manu_codproduto");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codcontagem).HasColumnName("codcontagem");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .IsFixedLength()
                .HasColumnName("codproduto");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Quant).HasColumnName("quant");
            entity.Property(e => e.Volume)
                .HasMaxLength(4)
                .HasColumnName("volume");
        });

        modelBuilder.Entity<TblSubPedido>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_sub_pedido_pkey");

            entity.ToTable("tbl_sub_pedido", tb => tb.HasComment("SETOR: Pedido, Produto, Garantia Estendida, Fiscal\nContém os dados dos produtos de um determinado pedido ou pré-pedido, com seus respectivos códigos, valores, taxas, valor de desconto, código do romaneio por produto, código da NFC-e, IMEI (em caso de celular), garantia de fábrica, código do pedido da garantia, número do bilhete de garantia estendida, data da entrega, valor de frete (em caso do e-commerce).\n"));

            entity.HasIndex(e => e.Datavenda, "index_datavenda");

            entity.HasIndex(e => e.Codpedido, "index_tbl_sub_pedido_codpedido");

            entity.HasIndex(e => e.Codprepedido, "index_tbl_sub_pedido_codprepedido");

            entity.HasIndex(e => e.Codproduto, "index_tbl_sub_pedido_codpro");

            entity.HasIndex(e => e.Departamento, "index_tbl_sub_pedido_depart");

            entity.HasIndex(e => e.Divisao, "index_tbl_sub_pedido_divisao");

            entity.HasIndex(e => e.Numerobilhete, "tbl_sub_pedido_numerobilhete_idx");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblsubpedido'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Acrescimo)
                .HasPrecision(6, 2)
                .HasColumnName("acrescimo");
            entity.Property(e => e.BaixaEstoqueAuto)
                .HasDefaultValueSql("false")
                .HasColumnName("baixa_estoque_auto");
            entity.Property(e => e.Botafora)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("botafora");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("cancelado");
            entity.Property(e => e.Cf)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("cf");
            entity.Property(e => e.Coddeposito).HasColumnName("coddeposito");
            entity.Property(e => e.Codfabrica)
                .HasMaxLength(25)
                .HasColumnName("codfabrica");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(11)
                .HasColumnName("codpedido");
            entity.Property(e => e.Codprepedido).HasColumnName("codprepedido");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .IsFixedLength()
                .HasColumnName("codproduto");
            entity.Property(e => e.Codprodutoindex)
                .HasMaxLength(15)
                .HasColumnName("codprodutoindex");
            entity.Property(e => e.CodsubpedidoGarantia)
                .HasDefaultValueSql("0")
                .HasColumnName("codsubpedido_garantia");
            entity.Property(e => e.CustoSemCredito)
                .HasPrecision(9, 2)
                .HasColumnName("custo_sem_credito");
            entity.Property(e => e.Dataentrega).HasColumnName("dataentrega");
            entity.Property(e => e.Datavenda).HasColumnName("datavenda");
            entity.Property(e => e.Departamento)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("departamento");
            entity.Property(e => e.Desconto).HasColumnName("desconto");
            entity.Property(e => e.Divisao)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("divisao");
            entity.Property(e => e.Estoqueanterior)
                .HasDefaultValueSql("0")
                .HasColumnName("estoqueanterior");
            entity.Property(e => e.Ficou).HasColumnName("ficou");
            entity.Property(e => e.Garantiafabrica).HasColumnName("garantiafabrica");
            entity.Property(e => e.IdSeguroSabemi).HasColumnName("id_seguro_sabemi");
            entity.Property(e => e.Imei)
                .HasMaxLength(15)
                .HasColumnName("imei");
            entity.Property(e => e.Imei2)
                .HasMaxLength(15)
                .HasColumnName("imei2");
            entity.Property(e => e.Iofgarantia)
                .HasPrecision(3, 2)
                .HasColumnName("iofgarantia");
            entity.Property(e => e.Juroespec)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("juroespec");
            entity.Property(e => e.Liberacupom)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("liberacupom");
            entity.Property(e => e.Montar)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("se é nescessario montar o produto no cliente")
                .HasColumnName("montar");
            entity.Property(e => e.NF)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("n_f");
            entity.Property(e => e.Nfce)
                .HasDefaultValueSql("0")
                .HasColumnName("nfce");
            entity.Property(e => e.Nfe)
                .HasDefaultValueSql("0")
                .HasColumnName("nfe");
            entity.Property(e => e.NfeIndenizacao).HasColumnName("nfe_indenizacao");
            entity.Property(e => e.NumCf)
                .HasDefaultValueSql("0")
                .HasColumnName("num_cf");
            entity.Property(e => e.NumF)
                .HasMaxLength(9)
                .HasColumnName("num_f");
            entity.Property(e => e.Numerobilhete)
                .HasMaxLength(20)
                .HasColumnName("numerobilhete");
            entity.Property(e => e.PorcProdPedido).HasColumnName("porc_prod_pedido");
            entity.Property(e => e.PrecovendaT1)
                .HasPrecision(13, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("precovenda_t1");
            entity.Property(e => e.PremioLiqSeg)
                .HasPrecision(6, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("premio_liq_seg");
            entity.Property(e => e.Promocao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("promocao");
            entity.Property(e => e.Quantvendido).HasColumnName("quantvendido");
            entity.Property(e => e.Restou).HasColumnName("restou");
            entity.Property(e => e.Romaneio)
                .HasDefaultValueSql("0")
                .HasColumnName("romaneio");
            entity.Property(e => e.SerieEcf)
                .HasMaxLength(20)
                .HasColumnName("serie_ecf");
            entity.Property(e => e.Taxa).HasColumnName("taxa");
            entity.Property(e => e.Tempoentrega)
                .HasDefaultValueSql("0")
                .HasComment("Tempo de entrega dos produtos")
                .HasColumnName("tempoentrega");
            entity.Property(e => e.Tempogarantia).HasColumnName("tempogarantia");
            entity.Property(e => e.Tempomontagem)
                .HasDefaultValueSql("0")
                .HasComment("Tempo nescessario para montar o produto")
                .HasColumnName("tempomontagem");
            entity.Property(e => e.TipoEntrega).HasColumnName("tipo_entrega");
            entity.Property(e => e.Tipogarantia).HasColumnName("tipogarantia");
            entity.Property(e => e.Totaldesconto)
                .HasPrecision(13, 2)
                .HasColumnName("totaldesconto");
            entity.Property(e => e.UserCf).HasColumnName("user_cf");
            entity.Property(e => e.UserF).HasColumnName("user_f");
            entity.Property(e => e.ValorFrete)
                .HasPrecision(9, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("valor_frete");
            entity.Property(e => e.Valorcusto)
                .HasPrecision(13, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("valorcusto");
            entity.Property(e => e.Valortotal)
                .HasPrecision(13, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("valortotal");
            entity.Property(e => e.Valorvenda)
                .HasPrecision(13, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("valorvenda");
            entity.Property(e => e.Vlrvendaproduto)
                .HasPrecision(10, 2)
                .HasColumnName("vlrvendaproduto");

            entity.HasOne(d => d.CodprodutoNavigation).WithMany(p => p.TblSubPedidos)
                .HasForeignKey(d => d.Codproduto)
                .HasConstraintName("tbl_sub_pedido_codproduto_fkey");
        });

        modelBuilder.Entity<TblSubPedidoCompra>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cp_tblpedidocompra");

            entity.ToTable("tbl_sub_pedido_compra", tb => tb.HasComment("Armazena produtos do pedido de compra"));

            entity.HasIndex(e => e.Codproduto, "index_codproduto");

            entity.HasIndex(e => e.Entregue, "index_tbl_sub_pedcompra_entregue");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblpedidocompra_prod'::regclass)")
                .HasComment("Codigo do Pedido de Compra")
                .HasColumnName("codigo");
            entity.Property(e => e.Chaveacesso)
                .HasMaxLength(44)
                .HasColumnName("chaveacesso");
            entity.Property(e => e.Codfabrica)
                .HasMaxLength(25)
                .HasColumnName("codfabrica");
            entity.Property(e => e.Codpedidocompra).HasColumnName("codpedidocompra");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasComment("Codigo do Produto")
                .HasColumnName("codproduto");
            entity.Property(e => e.DataRecebimento).HasColumnName("data_recebimento");
            entity.Property(e => e.Descricao)
                .HasMaxLength(90)
                .HasComment("Descrição do Produto ")
                .HasColumnName("descricao");
            entity.Property(e => e.Entregue)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("entregue");
            entity.Property(e => e.NfeEntrada).HasColumnName("nfe_entrada");
            entity.Property(e => e.Previsaoentrega)
                .HasComment("previsao de entrega da mercadoria")
                .HasColumnName("previsaoentrega");
            entity.Property(e => e.Qtdefaturada).HasColumnName("qtdefaturada");
            entity.Property(e => e.Quantidade)
                .HasComment("Quantidade da compra")
                .HasColumnName("quantidade");
            entity.Property(e => e.Recebeu)
                .HasDefaultValueSql("0")
                .HasComment("Quantidade de Produtos Recebidos")
                .HasColumnName("recebeu");
            entity.Property(e => e.Vlrtotal)
                .HasComment("Valor total da Compra")
                .HasColumnName("vlrtotal");
            entity.Property(e => e.Vlrunitario)
                .HasComment("Valor unitario do Produto")
                .HasColumnName("vlrunitario");
        });

        modelBuilder.Entity<TblSubPedidoCompraHistVincNotum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_sub_pedido_compra_hist_vinc_nota_pkey");

            entity.ToTable("tbl_sub_pedido_compra_hist_vinc_nota");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Chaveacesso)
                .HasMaxLength(44)
                .HasColumnName("chaveacesso");
            entity.Property(e => e.Codfabrica)
                .HasMaxLength(25)
                .HasColumnName("codfabrica");
            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("0")
                .HasColumnName("codigo");
            entity.Property(e => e.Codpedidocompra).HasColumnName("codpedidocompra");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.CodprodutoXml)
                .HasMaxLength(30)
                .HasColumnName("codproduto_xml");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("now()")
                .HasColumnName("data");
            entity.Property(e => e.Descricao)
                .HasMaxLength(90)
                .HasColumnName("descricao");
            entity.Property(e => e.DescricaoXml)
                .HasMaxLength(120)
                .HasColumnName("descricao_xml");
            entity.Property(e => e.ModoVinc)
                .HasDefaultValueSql("false")
                .HasColumnName("modo_vinc");
            entity.Property(e => e.NVinc)
                .HasDefaultValueSql("0")
                .HasColumnName("n_vinc");
            entity.Property(e => e.NfeEntrada).HasColumnName("nfe_entrada");
            entity.Property(e => e.QtdefaturadaXml).HasColumnName("qtdefaturada_xml");
            entity.Property(e => e.Quantidade).HasColumnName("quantidade");
            entity.Property(e => e.UserVinc)
                .HasMaxLength(50)
                .HasColumnName("user_vinc");
        });

        modelBuilder.Entity<TblSubPedidoCompraR>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cp_tblsubpedidocompra_r");

            entity.ToTable("tbl_sub_pedido_compra_r", tb => tb.HasComment("Produtos Recebidos "));

            entity.HasIndex(e => e.Codproduto, "tbl_sub_pedido_compra_r_codproduto_idx");

            entity.HasIndex(e => e.Datainclusao, "tbl_sub_pedido_compra_r_datainclusao_idx");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblsubpedidocompra_r'::regclass)")
                .HasComment("Codigo da Operação")
                .HasColumnName("codigo");
            entity.Property(e => e.Coddelete).HasColumnName("coddelete");
            entity.Property(e => e.Codentrada).HasColumnName("codentrada");
            entity.Property(e => e.Codpedidocompra).HasColumnName("codpedidocompra");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasComment("Codigo do Prduto Recebido")
                .HasColumnName("codproduto");
            entity.Property(e => e.Codrecebimento)
                .HasComment("Codigo do Recebimento")
                .HasColumnName("codrecebimento");
            entity.Property(e => e.Codusuario)
                .HasComment("Codigo do usuario")
                .HasColumnName("codusuario");
            entity.Property(e => e.Datainclusao)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datainclusao");
            entity.Property(e => e.Descricao)
                .HasMaxLength(80)
                .HasColumnName("descricao");
            entity.Property(e => e.Despesaassist)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasComment("Despesa de assistencia tecnica")
                .HasColumnName("despesaassist");
            entity.Property(e => e.Documento)
                .HasMaxLength(25)
                .HasColumnName("documento");
            entity.Property(e => e.Estoqueanterior).HasColumnName("estoqueanterior");
            entity.Property(e => e.Fornecedor).HasColumnName("fornecedor");
            entity.Property(e => e.FornecedorExcluirColuna)
                .HasMaxLength(50)
                .HasColumnName("fornecedor_excluir_coluna");
            entity.Property(e => e.Fretecif)
                .HasDefaultValueSql("0")
                .HasComment("frete do Produto")
                .HasColumnName("fretecif");
            entity.Property(e => e.Fretefob)
                .HasDefaultValueSql("0")
                .HasComment("Frete do Produto")
                .HasColumnName("fretefob");
            entity.Property(e => e.Grupo).HasColumnName("grupo");
            entity.Property(e => e.Incluso)
                .HasMaxLength(1)
                .HasComment("Incluso no sistema ?")
                .HasColumnName("incluso");
            entity.Property(e => e.Ipi)
                .HasDefaultValueSql("0")
                .HasComment("IPI da mercadoria recebida")
                .HasColumnName("ipi");
            entity.Property(e => e.Margemlucro)
                .HasPrecision(6, 2)
                .HasColumnName("margemlucro");
            entity.Property(e => e.Quantidade)
                .HasComment("Quantidade de Produtos Entregue")
                .HasColumnName("quantidade");
            entity.Property(e => e.Situacao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("Produto ja incluso no estoque")
                .HasColumnName("situacao");
            entity.Property(e => e.Verbaassist)
                .HasPrecision(9, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("verbaassist");
            entity.Property(e => e.VlrSemIpi)
                .HasComment("Valor da mercadoria sem ipi")
                .HasColumnName("vlr_sem_ipi");
            entity.Property(e => e.Vlrtotal)
                .HasComment("Valor Total do Produto")
                .HasColumnName("vlrtotal");
            entity.Property(e => e.Vlrunitario)
                .HasComment("Valor unitario")
                .HasColumnName("vlrunitario");

            entity.HasOne(d => d.FornecedorNavigation).WithMany(p => p.TblSubPedidoCompraRs)
                .HasForeignKey(d => d.Fornecedor)
                .HasConstraintName("tbl_sub_pedido_compra_r_fornecedor_fkey");
        });

        modelBuilder.Entity<TblSubPedidoOld>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_sub_pedido_old_pkey");

            entity.ToTable("tbl_sub_pedido_old");

            entity.HasIndex(e => e.Codpedido, "index_codpedido_tblsubpedidoold");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tbl_sub_pedido_old'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Coddeposito)
                .HasMaxLength(3)
                .HasColumnName("coddeposito");
            entity.Property(e => e.Codfabrica)
                .HasMaxLength(20)
                .HasColumnName("codfabrica");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(10)
                .HasColumnName("codpedido");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .HasColumnName("descricao");
            entity.Property(e => e.Garantia)
                .HasDefaultValueSql("0")
                .HasColumnName("garantia");
            entity.Property(e => e.Promocao)
                .HasMaxLength(1)
                .HasColumnName("promocao");
            entity.Property(e => e.Quantvendido).HasColumnName("quantvendido");
            entity.Property(e => e.Taxa).HasColumnName("taxa");
            entity.Property(e => e.Valortotal)
                .HasPrecision(13, 2)
                .HasColumnName("valortotal");
            entity.Property(e => e.Valorvenda)
                .HasPrecision(13, 2)
                .HasColumnName("valorvenda");
        });

        modelBuilder.Entity<TblSubPedidoOrc>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_sub_pedido_orc_pkey");

            entity.ToTable("tbl_sub_pedido_orc");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Acrescimo)
                .HasPrecision(6, 2)
                .HasColumnName("acrescimo");
            entity.Property(e => e.Botafora)
                .HasMaxLength(1)
                .HasColumnName("botafora");
            entity.Property(e => e.Coddeposito).HasColumnName("coddeposito");
            entity.Property(e => e.Codfabrica)
                .HasMaxLength(20)
                .HasColumnName("codfabrica");
            entity.Property(e => e.Codpedido)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("codpedido");
            entity.Property(e => e.Codprepedido).HasColumnName("codprepedido");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .IsFixedLength()
                .HasColumnName("codproduto");
            entity.Property(e => e.Datavenda).HasColumnName("datavenda");
            entity.Property(e => e.Desconto)
                .HasPrecision(4, 2)
                .HasColumnName("desconto");
            entity.Property(e => e.Estoqueanterior).HasColumnName("estoqueanterior");
            entity.Property(e => e.Juroespec)
                .HasMaxLength(1)
                .HasColumnName("juroespec");
            entity.Property(e => e.Montar)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("se é nescessario montar o produto no cliente")
                .HasColumnName("montar");
            entity.Property(e => e.PrecovendaT1)
                .HasPrecision(13, 2)
                .HasColumnName("precovenda_t1");
            entity.Property(e => e.Promocao)
                .HasMaxLength(1)
                .HasColumnName("promocao");
            entity.Property(e => e.Quantvendido).HasColumnName("quantvendido");
            entity.Property(e => e.Taxa).HasColumnName("taxa");
            entity.Property(e => e.Tempoentrega)
                .HasDefaultValueSql("0")
                .HasComment("Tempo de entrega dos produtos")
                .HasColumnName("tempoentrega");
            entity.Property(e => e.Tempomontagem)
                .HasDefaultValueSql("0")
                .HasComment("Tempo nescessario para montar o produto")
                .HasColumnName("tempomontagem");
            entity.Property(e => e.Totaldesconto)
                .HasPrecision(13, 2)
                .HasColumnName("totaldesconto");
            entity.Property(e => e.Valorcusto)
                .HasPrecision(13, 2)
                .HasColumnName("valorcusto");
            entity.Property(e => e.Valortotal)
                .HasPrecision(13, 2)
                .HasColumnName("valortotal");
            entity.Property(e => e.Valorvenda)
                .HasPrecision(13, 2)
                .HasColumnName("valorvenda");
            entity.Property(e => e.Vlrvendaproduto)
                .HasPrecision(10, 2)
                .HasColumnName("vlrvendaproduto");

            entity.HasOne(d => d.CoddepositoNavigation).WithMany(p => p.TblSubPedidoOrcs)
                .HasForeignKey(d => d.Coddeposito)
                .HasConstraintName("tbl_sub_pedido_coddeposito_fkey");

            entity.HasOne(d => d.CodprodutoNavigation).WithMany(p => p.TblSubPedidoOrcs)
                .HasForeignKey(d => d.Codproduto)
                .HasConstraintName("tbl_sub_pedido_codproduto_fkey");
        });

        modelBuilder.Entity<TblSubSolicitadesc>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_sub_solicitadesc_pkey");

            entity.ToTable("tbl_sub_solicitadesc");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblsubsolicitadesc'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Atraso)
                .HasComment("dias de atrazo")
                .HasColumnName("atraso");
            entity.Property(e => e.Codsolicita)
                .HasComment("Codigo da solicitação")
                .HasColumnName("codsolicita");
            entity.Property(e => e.Pedido)
                .HasMaxLength(10)
                .HasComment("Codigo do pedido")
                .HasColumnName("pedido");
            entity.Property(e => e.Vencimento).HasColumnName("vencimento");
            entity.Property(e => e.Vlrpagar)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vlrpagar");
            entity.Property(e => e.Vlrparcela)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vlrparcela");
            entity.Property(e => e.Vlrreceber)
                .HasPrecision(12, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vlrreceber");
        });

        modelBuilder.Entity<TblSugestaoCompra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_sugestao_compras_pkey");

            entity.ToTable("tbl_sugestao_compras", tb => tb.HasComment("tabela com variáveis importantes utilizadas no WpfSugestaoCompras"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(200)
                .HasColumnName("descricao");
            entity.Property(e => e.Justificativa)
                .HasMaxLength(300)
                .HasColumnName("justificativa");
            entity.Property(e => e.Valor)
                .HasPrecision(10, 3)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<TblTarefa>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_tarefa_pkey");

            entity.ToTable("tbl_tarefa");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Aceita)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("aceita");
            entity.Property(e => e.Assunto)
                .HasMaxLength(40)
                .HasColumnName("assunto");
            entity.Property(e => e.Concluido)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("concluido");
            entity.Property(e => e.Dataantiga)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataantiga");
            entity.Property(e => e.Dataciente)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("dataciente");
            entity.Property(e => e.Dataexecucao)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataexecucao");
            entity.Property(e => e.Datafim)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("datafim");
            entity.Property(e => e.Datasolicitado)
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("datasolicitado");
            entity.Property(e => e.Execucao).HasColumnName("execucao");
            entity.Property(e => e.Finalizada)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("finalizada");
            entity.Property(e => e.Master)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("master");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.Ocorrencia)
                .HasDefaultValueSql("0")
                .HasColumnName("ocorrencia");
            entity.Property(e => e.Ocorretarefa)
                .HasDefaultValueSql("0")
                .HasColumnName("ocorretarefa");
            entity.Property(e => e.Pai)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("pai");
            entity.Property(e => e.Proprietario).HasColumnName("proprietario");
            entity.Property(e => e.Tarefa).HasColumnName("tarefa");
            entity.Property(e => e.Tarefamaster).HasColumnName("tarefamaster");
            entity.Property(e => e.Tarefapai)
                .HasDefaultValueSql("0")
                .HasColumnName("tarefapai");
            entity.Property(e => e.Usercompartilhada).HasColumnName("usercompartilhada");
            entity.Property(e => e.Usercriou)
                .HasMaxLength(30)
                .HasColumnName("usercriou");
        });

        modelBuilder.Entity<TblTaxaJuro>(entity =>
        {
            entity.HasKey(e => new { e.Codproduto, e.Cartaocredito }).HasName("tbl_taxa_juro_pkey");

            entity.ToTable("tbl_taxa_juro");

            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Cartaocredito).HasColumnName("cartaocredito");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp(2) without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e._01)
                .HasDefaultValueSql("0")
                .HasColumnName("01");
            entity.Property(e => e._02)
                .HasDefaultValueSql("0")
                .HasColumnName("02");
            entity.Property(e => e._03)
                .HasDefaultValueSql("0")
                .HasColumnName("03");
            entity.Property(e => e._04)
                .HasDefaultValueSql("0")
                .HasColumnName("04");
            entity.Property(e => e._05)
                .HasDefaultValueSql("0")
                .HasColumnName("05");
            entity.Property(e => e._06)
                .HasDefaultValueSql("0")
                .HasColumnName("06");
            entity.Property(e => e._07)
                .HasDefaultValueSql("0")
                .HasColumnName("07");
            entity.Property(e => e._08)
                .HasDefaultValueSql("0")
                .HasColumnName("08");
            entity.Property(e => e._09)
                .HasDefaultValueSql("0")
                .HasColumnName("09");
            entity.Property(e => e._10)
                .HasDefaultValueSql("0")
                .HasColumnName("10");
            entity.Property(e => e._11)
                .HasDefaultValueSql("0")
                .HasColumnName("11");
            entity.Property(e => e._12)
                .HasDefaultValueSql("0")
                .HasColumnName("12");
            entity.Property(e => e._13)
                .HasDefaultValueSql("0")
                .HasColumnName("13");
            entity.Property(e => e._14)
                .HasDefaultValueSql("0")
                .HasColumnName("14");
            entity.Property(e => e._15)
                .HasDefaultValueSql("0")
                .HasColumnName("15");
            entity.Property(e => e._16)
                .HasDefaultValueSql("0")
                .HasColumnName("16");
            entity.Property(e => e._17)
                .HasDefaultValueSql("0")
                .HasColumnName("17");
            entity.Property(e => e._18)
                .HasDefaultValueSql("0")
                .HasColumnName("18");
            entity.Property(e => e._19)
                .HasDefaultValueSql("0")
                .HasColumnName("19");
            entity.Property(e => e._20)
                .HasDefaultValueSql("0")
                .HasColumnName("20");
            entity.Property(e => e._21)
                .HasDefaultValueSql("0")
                .HasColumnName("21");
            entity.Property(e => e._22)
                .HasDefaultValueSql("0")
                .HasColumnName("22");
            entity.Property(e => e._23)
                .HasDefaultValueSql("0")
                .HasColumnName("23");
            entity.Property(e => e._24)
                .HasDefaultValueSql("0")
                .HasColumnName("24");
            entity.Property(e => e._25)
                .HasDefaultValueSql("0")
                .HasColumnName("25");
            entity.Property(e => e._26)
                .HasDefaultValueSql("0")
                .HasColumnName("26");
            entity.Property(e => e._27)
                .HasDefaultValueSql("0")
                .HasColumnName("27");
            entity.Property(e => e._28)
                .HasDefaultValueSql("0")
                .HasColumnName("28");
            entity.Property(e => e._29)
                .HasDefaultValueSql("0")
                .HasColumnName("29");
            entity.Property(e => e._30)
                .HasDefaultValueSql("0")
                .HasColumnName("30");
            entity.Property(e => e._31)
                .HasDefaultValueSql("0")
                .HasColumnName("31");
            entity.Property(e => e._32)
                .HasDefaultValueSql("0")
                .HasColumnName("32");
            entity.Property(e => e._33)
                .HasDefaultValueSql("0")
                .HasColumnName("33");
            entity.Property(e => e._34)
                .HasDefaultValueSql("0")
                .HasColumnName("34");
            entity.Property(e => e._35)
                .HasDefaultValueSql("0")
                .HasColumnName("35");
            entity.Property(e => e._36)
                .HasDefaultValueSql("0")
                .HasColumnName("36");
            entity.Property(e => e._37)
                .HasDefaultValueSql("0")
                .HasColumnName("37");
            entity.Property(e => e._38)
                .HasDefaultValueSql("0")
                .HasColumnName("38");
            entity.Property(e => e._39)
                .HasDefaultValueSql("0")
                .HasColumnName("39");
            entity.Property(e => e._40)
                .HasDefaultValueSql("0")
                .HasColumnName("40");
            entity.Property(e => e._41)
                .HasDefaultValueSql("0")
                .HasColumnName("41");
            entity.Property(e => e._42)
                .HasDefaultValueSql("0")
                .HasColumnName("42");
            entity.Property(e => e._43)
                .HasDefaultValueSql("0")
                .HasColumnName("43");
            entity.Property(e => e._44)
                .HasDefaultValueSql("0")
                .HasColumnName("44");
            entity.Property(e => e._45)
                .HasDefaultValueSql("0")
                .HasColumnName("45");
            entity.Property(e => e._46)
                .HasDefaultValueSql("0")
                .HasColumnName("46");
            entity.Property(e => e._47)
                .HasDefaultValueSql("0")
                .HasColumnName("47");
            entity.Property(e => e._48)
                .HasDefaultValueSql("0")
                .HasColumnName("48");
        });

        modelBuilder.Entity<TblTefConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_tef_config_pkey");

            entity.ToTable("tbl_tef_config");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodEmpresa).HasColumnName("cod_empresa");
            entity.Property(e => e.Codloja).HasColumnName("codloja");
            entity.Property(e => e.IpPdv1)
                .HasMaxLength(15)
                .HasColumnName("ip_pdv1");
            entity.Property(e => e.IpPdv2)
                .HasMaxLength(15)
                .HasColumnName("ip_pdv2");
            entity.Property(e => e.IpTef)
                .HasMaxLength(15)
                .HasColumnName("ip_tef");
            entity.Property(e => e.Senha)
                .HasMaxLength(30)
                .HasColumnName("senha");
        });

        modelBuilder.Entity<TblTerceiro>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_terceiros_pkey");

            entity.ToTable("tbl_terceiros");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codcliente).HasColumnName("codcliente");
            entity.Property(e => e.Cpf)
                .HasMaxLength(14)
                .HasColumnName("cpf");
            entity.Property(e => e.Nome)
                .HasMaxLength(45)
                .HasColumnName("nome");
            entity.Property(e => e.Parentesco)
                .HasMaxLength(15)
                .HasComment("Grau de parentesco do cliente")
                .HasColumnName("parentesco");
            entity.Property(e => e.Rg)
                .HasMaxLength(15)
                .HasColumnName("rg");

            entity.HasOne(d => d.CodclienteNavigation).WithMany(p => p.TblTerceiros)
                .HasForeignKey(d => d.Codcliente)
                .HasConstraintName("tbl_terceiros_codcliente_fkey");
        });

        modelBuilder.Entity<TblTeste1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_teste1");
        });

        modelBuilder.Entity<TblTipoEntrega>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_tipo_entrega_pkey");

            entity.ToTable("tbl_tipo_entrega");

            entity.Property(e => e.Codigo)
                .ValueGeneratedNever()
                .HasColumnName("codigo");
            entity.Property(e => e.Tipo)
                .HasMaxLength(35)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TblTipoParcela>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_tipo_parcela_pkey");

            entity.ToTable("tbl_tipo_parcela");

            entity.Property(e => e.Codigo)
                .ValueGeneratedNever()
                .HasColumnName("codigo");
            entity.Property(e => e.Tipo)
                .HasMaxLength(15)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TblTipoPedido>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_tipo_pedido_pkey");

            entity.ToTable("tbl_tipo_pedido", tb => tb.HasComment("Esta tabela está correlacionada com a tbl_pedido_compra em tbl_tipo_pedido.codigo = tbl_pedido_compra.tipo_pedido"));

            entity.Property(e => e.Codigo)
                .ValueGeneratedNever()
                .HasColumnName("codigo");
            entity.Property(e => e.Tipo)
                .HasMaxLength(30)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TblTipoPgto>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_tipo_pgto_pkey");

            entity.ToTable("tbl_tipo_pgto");

            entity.Property(e => e.Codigo)
                .ValueGeneratedNever()
                .HasColumnName("codigo");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TblTipoVendum>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cp_tbltipovenda");

            entity.ToTable("tbl_tipo_venda", tb => tb.HasComment("Tipo de vendas e Financeiras"));

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tbltipovenda'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Tipovenda)
                .HasMaxLength(20)
                .HasColumnName("tipovenda");
        });

        modelBuilder.Entity<TblTransferenciatotaldeestoque>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_transferenciatotaldeestoque_pkey");

            entity.ToTable("tbl_transferenciatotaldeestoque");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodTransferencia).HasColumnName("cod_transferencia");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(20)
                .HasColumnName("codproduto");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Idnfe).HasColumnName("idnfe");
            entity.Property(e => e.Numnota).HasColumnName("numnota");
            entity.Property(e => e.Observacao).HasColumnName("observacao");
        });

        modelBuilder.Entity<TblTransfestoque>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_transfestoque_pkey");

            entity.ToTable("tbl_transfestoque", tb => tb.HasComment("transferencia de Mercadoria ente lojas\nTR+ a coluna código não está correlacionada com o documento da tbl_nfe, que também tem um TR+ um código. Este código da tbl_nfe é a ID da transferência.\nA correlação entre uma transferência e sua nota está na coluna NFE da tbl_romaneio."));

            entity.HasIndex(e => e.Codproduto, "tbl_transfestoque_codproduto");

            entity.HasIndex(e => e.Destino, "tbl_transfestoque_destino");

            entity.HasIndex(e => e.Origem, "tbl_transfestoque_origem");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tbltransfestoque'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("cancelado");
            entity.Property(e => e.Codprepedido22Para1).HasColumnName("codprepedido_22_para_1");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(12)
                .HasColumnName("codproduto");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Confirmado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasComment("confirmação da entrada no estoque")
                .HasColumnName("confirmado");
            entity.Property(e => e.Confirmadopor)
                .HasMaxLength(50)
                .HasColumnName("confirmadopor");
            entity.Property(e => e.Dataconfirmado)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dataconfirmado");
            entity.Property(e => e.Datasolicita)
                .HasComment("data da solicitação")
                .HasColumnName("datasolicita");
            entity.Property(e => e.Datatransf).HasColumnName("datatransf");
            entity.Property(e => e.Destino).HasColumnName("destino");
            entity.Property(e => e.Estoquedestino)
                .HasComment("estoque anterior atransferencia do destino")
                .HasColumnName("estoquedestino");
            entity.Property(e => e.Estoqueorigem)
                .HasComment("estoque anterior a transferencia da origem")
                .HasColumnName("estoqueorigem");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.Origem).HasColumnName("origem");
            entity.Property(e => e.Osassistencia).HasColumnName("osassistencia");
            entity.Property(e => e.Quantidade).HasColumnName("quantidade");
            entity.Property(e => e.Romaneio)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("romaneio");
        });

        modelBuilder.Entity<TblTransportadora>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_transportadora_pkey");

            entity.ToTable("tbl_transportadora");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(20)
                .HasColumnName("cnpj");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Nomefantasia)
                .HasMaxLength(100)
                .HasColumnName("nomefantasia");
            entity.Property(e => e.Razaosocial)
                .HasMaxLength(100)
                .HasColumnName("razaosocial");
        });

        modelBuilder.Entity<TblUf>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_uf_pkey");

            entity.ToTable("tbl_uf");

            entity.Property(e => e.Codigo)
                .ValueGeneratedNever()
                .HasColumnName("codigo");
            entity.Property(e => e.CodDne).HasColumnName("cod_dne");
            entity.Property(e => e.Ie)
                .HasMaxLength(15)
                .HasColumnName("ie");
            entity.Property(e => e.IeEs).HasColumnName("ie_es");
            entity.Property(e => e.InfAddNfeEs).HasColumnName("inf_add_nfe_es");
            entity.Property(e => e.InfoAddNfe).HasColumnName("info_add_nfe");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("uf");
            entity.Property(e => e.Ufnome)
                .HasMaxLength(25)
                .HasColumnName("ufnome");
        });

        modelBuilder.Entity<TblUserAssistencium>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_user_assistencia_pkey");

            entity.ToTable("tbl_user_assistencia");

            entity.HasIndex(e => e.Codusuario, "tbl_user_assistencia_codusuario_key").IsUnique();

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Inclui)
                .HasComment("local para onde o usuario pode lançar os produtos")
                .HasColumnName("inclui");
            entity.Property(e => e.Retira)
                .HasComment("local de onde o usuario pode retirar os produtos")
                .HasColumnName("retira");
            entity.Property(e => e.Senhapedido)
                .HasDefaultValueSql("0")
                .HasColumnName("senhapedido");

            entity.HasOne(d => d.CodusuarioNavigation).WithOne(p => p.TblUserAssistencium)
                .HasForeignKey<TblUserAssistencium>(d => d.Codusuario)
                .HasConstraintName("tbl_user_assistencia_codusuario_fkey");
        });

        modelBuilder.Entity<TblUsuario>(entity =>
        {
            entity.HasKey(e => e.Codusuario).HasName("cp_tblususario");

            entity.ToTable("tbl_usuario");

            entity.HasIndex(e => e.Ativo, "indx_ativo");

            entity.Property(e => e.Codusuario)
                .HasDefaultValueSql("nextval('seq_tblusuario'::regclass)")
                .HasColumnName("codusuario");
            entity.Property(e => e.Admin)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("admin");
            entity.Property(e => e.Alterasenha)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasComment("Alterar senha")
                .HasColumnName("alterasenha");
            entity.Property(e => e.Apelido)
                .HasMaxLength(25)
                .HasColumnName("apelido");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("ativo");
            entity.Property(e => e.Bloqueado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("bloqueado");
            entity.Property(e => e.Coddep).HasColumnName("coddep");
            entity.Property(e => e.Codfuncao).HasColumnName("codfuncao");
            entity.Property(e => e.Codloja)
                .HasComment("Codigo da Filial que pertence o usuario")
                .HasColumnName("codloja");
            entity.Property(e => e.Contagem)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("contagem");
            entity.Property(e => e.Cpf)
                .HasMaxLength(14)
                .HasColumnName("cpf");
            entity.Property(e => e.CriadoPor).HasColumnName("criado_por");
            entity.Property(e => e.Datacadastro)
                .HasComment("Data da criação do usuario")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datacadastro");
            entity.Property(e => e.EMail1)
                .HasMaxLength(60)
                .HasColumnName("e_mail");
            entity.Property(e => e.Email)
                .HasMaxLength(55)
                .HasColumnName("email");
            entity.Property(e => e.LiberadoAte).HasColumnName("liberado_ate");
            entity.Property(e => e.Login)
                .HasMaxLength(35)
                .HasColumnName("login");
            entity.Property(e => e.Nascimentouser).HasColumnName("nascimentouser");
            entity.Property(e => e.Nivelassistencia)
                .HasDefaultValueSql("0")
                .HasComment("Nivel de senha da assistencia tecnica\nvalor 1 administrador\nvalor 2 restrito")
                .HasColumnName("nivelassistencia");
            entity.Property(e => e.Nivelsist)
                .HasDefaultValueSql("0")
                .HasColumnName("nivelsist");
            entity.Property(e => e.NivelsistemaOld)
                .HasDefaultValueSql("0")
                .HasComment("nivel do usurio para acessar sistema")
                .HasColumnName("nivelsistema_old");
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .HasColumnName("password");
            entity.Property(e => e.Perfilcopy).HasColumnName("perfilcopy");
            entity.Property(e => e.Ramal).HasColumnName("ramal");
            entity.Property(e => e.Skin)
                .HasMaxLength(20)
                .HasColumnName("skin");
            entity.Property(e => e.Ultimasenha)
                .HasComment("ultima alteração senha")
                .HasColumnName("ultimasenha");
            entity.Property(e => e.Ultimologin)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("ultimologin");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");
            entity.Property(e => e.VersaoSistema)
                .HasPrecision(3, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("versao_sistema");

            entity.HasOne(d => d.CodfuncaoNavigation).WithMany(p => p.TblUsuarios)
                .HasForeignKey(d => d.Codfuncao)
                .HasConstraintName("tbl_usuario_codfuncao_fkey");

            entity.HasOne(d => d.CodlojaNavigation).WithMany(p => p.TblUsuarios)
                .HasForeignKey(d => d.Codloja)
                .HasConstraintName("fk_codloja");
        });

        modelBuilder.Entity<TblUsuarioCaixa>(entity =>
        {
            entity.HasKey(e => new { e.Codusuario, e.Codcaixa }).HasName("cp_tblusuariocaixa");

            entity.ToTable("tbl_usuario_caixa");

            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Codcaixa).HasColumnName("codcaixa");
            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblusuariocaixa'::regclass)")
                .HasColumnName("codigo");

            entity.HasOne(d => d.CodusuarioNavigation).WithMany(p => p.TblUsuarioCaixas)
                .HasForeignKey(d => d.Codusuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_codusuario");
        });

        modelBuilder.Entity<TblUsuarioassist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_usuarioassist");

            entity.Property(e => e.Codusuario)
                .ValueGeneratedOnAdd()
                .HasColumnName("codusuario");
            entity.Property(e => e.Login)
                .HasMaxLength(20)
                .HasColumnName("login");
            entity.Property(e => e.Nivel).HasColumnName("nivel");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("nome");
            entity.Property(e => e.Senha)
                .HasMaxLength(50)
                .HasColumnName("senha");
        });

        modelBuilder.Entity<TblVeiculo>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_veiculo_pkey");

            entity.ToTable("tbl_veiculo");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('seq_tblveiculo'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::bpchar")
                .HasColumnName("ativo");
            entity.Property(e => e.CapacidadeM3).HasColumnName("capacidade_m3");
            entity.Property(e => e.CapacidadePeso).HasColumnName("capacidade_peso");
            entity.Property(e => e.Codloja)
                .HasMaxLength(50)
                .HasColumnName("codloja");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .HasColumnName("marca");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .HasColumnName("modelo");
            entity.Property(e => e.Montador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("montador");
            entity.Property(e => e.Obs).HasColumnName("obs");
            entity.Property(e => e.Placa)
                .HasMaxLength(20)
                .HasColumnName("placa");
            entity.Property(e => e.Tipo)
                .HasMaxLength(40)
                .HasColumnName("tipo");
            entity.Property(e => e.Veiculo)
                .HasMaxLength(50)
                .HasColumnName("veiculo");
        });

        modelBuilder.Entity<TblVeiculoAbastecimento>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_veiculo_abastecimentos_pkey");

            entity.ToTable("tbl_veiculo_abastecimentos");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.AbastecidoPor)
                .HasMaxLength(40)
                .HasColumnName("abastecido_por");
            entity.Property(e => e.AdicionadoPor).HasColumnName("adicionado_por");
            entity.Property(e => e.Arla).HasColumnName("arla");
            entity.Property(e => e.Codveiculo).HasColumnName("codveiculo");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Dataregistro).HasColumnName("dataregistro");
            entity.Property(e => e.Excluido)
                .HasDefaultValueSql("false")
                .HasColumnName("excluido");
            entity.Property(e => e.ExcluidoEm)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("excluido_em");
            entity.Property(e => e.ExcluidoPor).HasColumnName("excluido_por");
            entity.Property(e => e.FornecedorDiesel)
                .HasMaxLength(40)
                .HasColumnName("fornecedor_diesel");
            entity.Property(e => e.Km).HasColumnName("km");
            entity.Property(e => e.Litros).HasColumnName("litros");
            entity.Property(e => e.PrecoDiesel)
                .HasPrecision(5, 4)
                .HasColumnName("preco_diesel");

            entity.HasOne(d => d.AdicionadoPorNavigation).WithMany(p => p.TblVeiculoAbastecimentoAdicionadoPorNavigations)
                .HasForeignKey(d => d.AdicionadoPor)
                .HasConstraintName("codusuario");

            entity.HasOne(d => d.CodveiculoNavigation).WithMany(p => p.TblVeiculoAbastecimentos)
                .HasForeignKey(d => d.Codveiculo)
                .HasConstraintName("codveiculo");

            entity.HasOne(d => d.ExcluidoPorNavigation).WithMany(p => p.TblVeiculoAbastecimentoExcluidoPorNavigations)
                .HasForeignKey(d => d.ExcluidoPor)
                .HasConstraintName("excluido");
        });

        modelBuilder.Entity<TblVeiculoDespesa>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_veiculo_despesas_pkey");

            entity.ToTable("tbl_veiculo_despesas", tb => tb.HasComment("despesas por veiculo para entrega"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codveiculo).HasColumnName("codveiculo");
            entity.Property(e => e.Ipva)
                .HasPrecision(5, 2)
                .HasColumnName("ipva");
            entity.Property(e => e.KmL)
                .HasPrecision(5, 2)
                .HasColumnName("km_l");
            entity.Property(e => e.Lavagem)
                .HasPrecision(5, 2)
                .HasColumnName("lavagem");
            entity.Property(e => e.Licenca)
                .HasPrecision(5, 2)
                .HasColumnName("licenca");
            entity.Property(e => e.Manutencao)
                .HasPrecision(5, 2)
                .HasColumnName("manutencao");
            entity.Property(e => e.Pneu)
                .HasPrecision(5, 2)
                .HasColumnName("pneu");
            entity.Property(e => e.Revisao)
                .HasPrecision(5, 2)
                .HasColumnName("revisao");
            entity.Property(e => e.Seguro)
                .HasPrecision(5, 2)
                .HasColumnName("seguro");
        });

        modelBuilder.Entity<TblVeiculoHistCarregamento>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_veiculo_hist_carregamento_pkey");

            entity.ToTable("tbl_veiculo_hist_carregamento", tb => tb.HasComment("histórico de carregamento, por veículo"));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codusuario).HasColumnName("codusuario");
            entity.Property(e => e.Codveiculo).HasColumnName("codveiculo");
            entity.Property(e => e.DataExpedicao)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_expedicao");
            entity.Property(e => e.M3).HasColumnName("m3");
            entity.Property(e => e.Peso).HasColumnName("peso");
            entity.Property(e => e.Volumes).HasColumnName("volumes");

            entity.HasOne(d => d.CodusuarioNavigation).WithMany(p => p.TblVeiculoHistCarregamentos)
                .HasForeignKey(d => d.Codusuario)
                .HasConstraintName("usuario");

            entity.HasOne(d => d.CodveiculoNavigation).WithMany(p => p.TblVeiculoHistCarregamentos)
                .HasForeignKey(d => d.Codveiculo)
                .HasConstraintName("veiculo");
        });

        modelBuilder.Entity<TblVeiculoHistManutencao>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_veiculo_hist_manutencao_pkey");

            entity.ToTable("tbl_veiculo_hist_manutencao");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codpedidocompra).HasColumnName("codpedidocompra");
            entity.Property(e => e.Codveiculo).HasColumnName("codveiculo");
            entity.Property(e => e.Data)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");

            entity.HasOne(d => d.CodpedidocompraNavigation).WithMany(p => p.TblVeiculoHistManutencaos)
                .HasForeignKey(d => d.Codpedidocompra)
                .HasConstraintName("pedido_compra");

            entity.HasOne(d => d.CodveiculoNavigation).WithMany(p => p.TblVeiculoHistManutencaos)
                .HasForeignKey(d => d.Codveiculo)
                .HasConstraintName("veiculo");
        });

        modelBuilder.Entity<TblVeiculoMotorista>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_veiculo_motoristas_pkey");

            entity.ToTable("tbl_veiculo_motoristas");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Codveiculo).HasColumnName("codveiculo");
            entity.Property(e => e.Datafim)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datafim");
            entity.Property(e => e.Datainicio)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datainicio");
            entity.Property(e => e.Excluido).HasColumnName("excluido");
            entity.Property(e => e.ExcluidoEm)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("excluido_em");
            entity.Property(e => e.ExcluidoPor).HasColumnName("excluido_por");
            entity.Property(e => e.Motorista)
                .HasMaxLength(60)
                .HasColumnName("motorista");
        });

        modelBuilder.Entity<TblVenda>(entity =>
        {
            entity.HasKey(e => new { e.Data, e.Loja }).HasName("tbl_vendas_pkey");

            entity.ToTable("tbl_vendas");

            entity.Property(e => e.Data)
                .HasMaxLength(7)
                .HasColumnName("data");
            entity.Property(e => e.Loja).HasColumnName("loja");
            entity.Property(e => e.Cancelpresente)
                .HasPrecision(12, 2)
                .HasColumnName("cancelpresente");
            entity.Property(e => e.Pedidopresente)
                .HasPrecision(12, 2)
                .HasColumnName("pedidopresente");
            entity.Property(e => e.Saldopedido)
                .HasPrecision(12, 2)
                .HasColumnName("saldopedido");
            entity.Property(e => e.Totalcancelado)
                .HasPrecision(12, 2)
                .HasColumnName("totalcancelado");
            entity.Property(e => e.Totalpedido)
                .HasPrecision(12, 2)
                .HasColumnName("totalpedido");
            entity.Property(e => e.Totalpresente)
                .HasPrecision(12, 2)
                .HasColumnName("totalpresente");
        });

        modelBuilder.Entity<TblVendasPromocaoAgendadum>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tbl_vendas_promocao_agendada_pkey");

            entity.ToTable("tbl_vendas_promocao_agendada", tb => tb.HasComment("agendamento de datas de promoção, retirando a necessidade de alterar o código."));

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.OcorrenciasAplicadas).HasColumnName("ocorrencias_aplicadas");
            entity.Property(e => e.PermitidoVenda1).HasColumnName("permitido_venda_1");
            entity.Property(e => e.Promocao)
                .HasMaxLength(50)
                .HasColumnName("promocao");
        });

        modelBuilder.Entity<TblVendasfornecedor>(entity =>
        {
            entity.HasKey(e => e.IdVendasfornecedor).HasName("tbl_vendasfornecedor_pkey");

            entity.ToTable("tbl_vendasfornecedor");

            entity.Property(e => e.IdVendasfornecedor).HasColumnName("id_vendasfornecedor");
            entity.Property(e => e.Codproduto)
                .HasMaxLength(50)
                .HasColumnName("codproduto");
            entity.Property(e => e.Departamento)
                .HasMaxLength(6)
                .HasColumnName("departamento");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .HasColumnName("email");
            entity.Property(e => e.Fornecedor)
                .HasMaxLength(200)
                .HasColumnName("fornecedor");
        });

        modelBuilder.Entity<TblVersaoSistema>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbl_versao_sistema_pkey");

            entity.ToTable("tbl_versao_sistema");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.Hash)
                .HasMaxLength(64)
                .HasColumnName("hash");
        });

        modelBuilder.Entity<VTblPedido>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_tbl_pedido");

            entity.Property(e => e.Codpedido)
                .HasMaxLength(11)
                .HasColumnName("codpedido");
            entity.Property(e => e.Horafecha)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("horafecha");
        });
        modelBuilder.HasSequence("ec_tbl_cadastro_prod_skyhub_hist_id_seq").StartsAt(2500L);
        modelBuilder.HasSequence("ec_tbl_departamento_div_id_seq").StartsAt(400L);
        modelBuilder.HasSequence("ec_tbl_log_id_seq").StartsAt(22000000L);
        modelBuilder.HasSequence("ec_tbl_pedido_entrada_id_seq").StartsAt(93000L);
        modelBuilder.HasSequence("ec_tbl_pedido_id_seq").StartsAt(58000L);
        modelBuilder.HasSequence("ec_tbl_pedido_itens_id_seq").StartsAt(59000L);
        modelBuilder.HasSequence("ec_tbl_produto_preco_b2w_id_seq").StartsAt(13000L);
        modelBuilder.HasSequence("seq_categoria_skyhub");
        modelBuilder.HasSequence("seq_codigo_servico");
        modelBuilder.HasSequence("seq_tbl_agenda_pgto").StartsAt(280091L);
        modelBuilder.HasSequence("seq_tbl_sub_pedido_old");
        modelBuilder.HasSequence("seq_tblbairro");
        modelBuilder.HasSequence("seq_tblbanco");
        modelBuilder.HasSequence("seq_tblcaixa");
        modelBuilder.HasSequence("seq_tblcaixacreditodiv");
        modelBuilder.HasSequence("seq_tblcaixatransferencia");
        modelBuilder.HasSequence("seq_tblcaixavale");
        modelBuilder.HasSequence("seq_tblcidade");
        modelBuilder.HasSequence("seq_tblclassehist").StartsAt(300000L);
        modelBuilder.HasSequence("seq_tblcliente");
        modelBuilder.HasSequence("seq_tblcor");
        modelBuilder.HasSequence("seq_tbldeposito");
        modelBuilder.HasSequence("seq_tbldescricaoproduto");
        modelBuilder.HasSequence("seq_tbldivisao").StartsAt(4L);
        modelBuilder.HasSequence("seq_tblenviacupomfiscal");
        modelBuilder.HasSequence("seq_tbletiquetaident");
        modelBuilder.HasSequence("seq_tbletiquetapeco");
        modelBuilder.HasSequence("seq_tblfabrica");
        modelBuilder.HasSequence("seq_tblformularios");
        modelBuilder.HasSequence("seq_tblfornecedor").StartsAt(2715L);
        modelBuilder.HasSequence("seq_tblgeraromaneio");
        modelBuilder.HasSequence("seq_tblinfor");
        modelBuilder.HasSequence("seq_tbljuroespecial");
        modelBuilder.HasSequence("seq_tbllojas");
        modelBuilder.HasSequence("seq_tblmarca");
        modelBuilder.HasSequence("seq_tblmovcaixa").StartsAt(158096L);
        modelBuilder.HasSequence("seq_tblmovimento");
        modelBuilder.HasSequence("seq_tblocorrencia");
        modelBuilder.HasSequence("seq_tblocorresenha");
        modelBuilder.HasSequence("seq_tblparcelasprazo").StartsAt(4500000L);
        modelBuilder.HasSequence("seq_tblpedido");
        modelBuilder.HasSequence("seq_tblpedidocompra");
        modelBuilder.HasSequence("seq_tblpedidocompra_prod");
        modelBuilder.HasSequence("seq_tblpedidocompra_r");
        modelBuilder.HasSequence("seq_tblpedidocompraparc");
        modelBuilder.HasSequence("seq_tblpermissoes");
        modelBuilder.HasSequence("seq_tblprepedido");
        modelBuilder.HasSequence("seq_tblpreromaneio").StartsAt(98500L);
        modelBuilder.HasSequence("seq_tblproduto");
        modelBuilder.HasSequence("seq_tblprodutocancel");
        modelBuilder.HasSequence("seq_tblprodutoquantidade");
        modelBuilder.HasSequence("seq_tblromaneioloja");
        modelBuilder.HasSequence("seq_tblromaneiostatus");
        modelBuilder.HasSequence("seq_tblromareagendar");
        modelBuilder.HasSequence("seq_tblrotaromaneio");
        modelBuilder.HasSequence("seq_tblsolicitadesc");
        modelBuilder.HasSequence("seq_tblspcserasa");
        modelBuilder.HasSequence("seq_tblsubpedido");
        modelBuilder.HasSequence("seq_tblsubpedidocompra_r");
        modelBuilder.HasSequence("seq_tblsubsolicitadesc");
        modelBuilder.HasSequence("seq_tbltipovenda");
        modelBuilder.HasSequence("seq_tbltransfestoque");
        modelBuilder.HasSequence("seq_tbltransportadora");
        modelBuilder.HasSequence("seq_tblusuario");
        modelBuilder.HasSequence("seq_tblusuariocaixa");
        modelBuilder.HasSequence("seq_tblveiculo");
        modelBuilder.HasSequence("seq_tblvendas");
        modelBuilder.HasSequence("tbl_bilhete_garantia_envio_codigo_seq");
        modelBuilder.HasSequence("tbl_bilhete_garantia_erro_codigo_seq");
        modelBuilder.HasSequence("tbl_caixa_debito_codigo_seq").StartsAt(256746L);
        modelBuilder.HasSequence("tbl_nfe_prosutos_devol_codigo_seq").StartsAt(39L);
        modelBuilder.HasSequence("tbl_produto_mov_codigo_seq").StartsAt(1948129L);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
