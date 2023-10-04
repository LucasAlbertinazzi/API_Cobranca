using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// codrota é o código da tbl_rota_romaneio
/// codveiculo e veiculo é da tbl_veiculo
/// confirmado = &apos;S&apos; -  pedido foi impresso (finalizado)
/// situacao = &apos;S&apos; - foi entregue
/// a coluna NFE contém a nota fiscal do romaneio na tbl_nfe.
/// O documento das transferências tbl_transfestoque diverge do documento da tbl_nfe, não há correlação. As colunas correlacionadas são id da tbl_nfe e nfe da tbl_romaneio.
/// 
/// </summary>
public partial class TblRomaneio
{
    public long Codigo { get; set; }

    public string? Documento { get; set; }

    public DateTime? Datapedido { get; set; }

    public string? Codproduto { get; set; }

    public string? Codfabrica { get; set; }

    public string? Descricao { get; set; }

    public short? Quantidade { get; set; }

    public int? Codcliente { get; set; }

    public string? Cliente { get; set; }

    public string? Endereco { get; set; }

    public string? Bairro { get; set; }

    public string? Cidade { get; set; }

    public string? Fone { get; set; }

    public short? Codveiculo { get; set; }

    public string? Veiculo { get; set; }

    public DateOnly? Dataentrega { get; set; }

    public DateTime? Dataentregou { get; set; }

    public string? Situacao { get; set; }

    public string? Destino { get; set; }

    public string? Tiporomaneio { get; set; }

    public string? Carregado { get; set; }

    public DateTime? Datacarregamento { get; set; }

    public string? Carregadopor { get; set; }

    public int? Codbairro { get; set; }

    public int? Codcidade { get; set; }

    /// <summary>
    /// observações para entrega
    /// </summary>
    public string? Obsparaentrega { get; set; }

    /// <summary>
    /// Estoque anterior 
    /// </summary>
    public short? Estoqueanterior { get; set; }

    /// <summary>
    /// confirmado = &apos;S&apos; é sinal que o pedido foi finalizado no caixa
    /// </summary>
    public char? Confirmado { get; set; }

    public string? Periodoentrega { get; set; }

    /// <summary>
    /// Tempo de entrega do produto
    /// </summary>
    public short? Tempoentrega { get; set; }

    /// <summary>
    /// Rota a qual a entrega Pertence
    /// </summary>
    public short? Codrota { get; set; }

    /// <summary>
    /// status da agenda na hora do lançamento do produto no romaneio
    /// </summary>
    public short? Statusagenda { get; set; }

    /// <summary>
    /// codigo do usuario que lançou o produto.
    /// </summary>
    public short? Codusuario { get; set; }

    /// <summary>
    /// Nome de quem liberou a entrega se a agenda estivesse bloqueada
    /// </summary>
    public string? Liberado { get; set; }

    public short? Origem { get; set; }

    public bool? Marcar { get; set; }

    /// <summary>
    /// Codigo do romaneio
    /// </summary>
    public long? Codromaneio { get; set; }

    public short? Tempomontagem { get; set; }

    public char? Montar { get; set; }

    /// <summary>
    /// Gerar romaneio de montagem? S/N
    /// </summary>
    public char? Romamontagem { get; set; }

    public string? Obsdaentrega { get; set; }

    public string? Baixadopor { get; set; }

    public DateOnly? Datamontagem { get; set; }

    public char? Montado { get; set; }

    public short? Codveiculomonta { get; set; }

    public string? Veiculomonta { get; set; }

    /// <summary>
    /// data da baixa da montagem
    /// </summary>
    public DateTime? Baixamontagem { get; set; }

    /// <summary>
    /// Baixa da montagem
    /// </summary>
    public string? Baixamontagempor { get; set; }

    /// <summary>
    /// Observacoes da montagem
    /// </summary>
    public string? Obsmontagem { get; set; }

    /// <summary>
    /// impressao do romaneio de entrega
    /// </summary>
    public char? Impentrega { get; set; }

    public char? Impmontagem { get; set; }

    /// <summary>
    /// se pedido for cancelado marcar como &apos;s&apos; para excluir do romaneio
    /// </summary>
    public char? Excluir { get; set; }

    /// <summary>
    /// se pedido for cancelado e produto for continuar no romaneio marcar como &apos;S&apos;
    /// </summary>
    public char? Cancelado { get; set; }

    /// <summary>
    /// Quantidade de veses que foi impresso esse produto
    /// </summary>
    public short? Quantimpresso { get; set; }

    /// <summary>
    /// quantidade que romaneio de montagem foi impresso
    /// </summary>
    public short? Quantimpremonta { get; set; }

    /// <summary>
    /// se o produto ja foi retirado da loja para entrega
    /// </summary>
    public char? Entregaloja { get; set; }

    /// <summary>
    /// usuario que entregou produto da loja
    /// </summary>
    public string? Entreguepor { get; set; }

    /// <summary>
    /// data entrega loja
    /// </summary>
    public DateTime? Dataentregaloja { get; set; }

    /// <summary>
    /// se a transferencia foi aceita pela loja de destino
    /// </summary>
    public char? Recloja { get; set; }

    public short? Coddestino { get; set; }

    public string? Codpedido { get; set; }

    public DateOnly? Datacompra { get; set; }

    public string? Tipoassist { get; set; }

    public int? Osassistencia { get; set; }

    /// <summary>
    /// codigo do novo pedido quando o pedido for cancelado e sustituido por outro
    /// </summary>
    public string? Codnovopedido { get; set; }

    /// <summary>
    /// codigo do pedido anterior se o pedido for um pedido de cancelamento
    /// </summary>
    public string? Codpedidoantes { get; set; }

    public short? UserimpNt { get; set; }

    public DateTime? DataimpNt { get; set; }

    public string? NumeroNt { get; set; }

    public short? UserimpCf { get; set; }

    public DateTime? DataimpCf { get; set; }

    public int? NumeroCf { get; set; }

    public string? SerieEcf { get; set; }

    public char? ImpCf { get; set; }

    public short? MotivoNaocarregou { get; set; }

    public string? StatusCarregamento { get; set; }

    public long? Vinculado { get; set; }

    public char? Separado { get; set; }

    public int? Nfe { get; set; }

    public long? Codsubpedido { get; set; }

    public long? Nfce { get; set; }

    public string? TransfVinculada { get; set; }

    public int? LojaBaixaEstoque { get; set; }

    public bool? PedidoEc { get; set; }

    /// <summary>
    /// campo abastecido na tela FrmEcRomaneiosCancelamento, de utilização da Karol (coordenadora EC) e Rafael (gerente de logística).
    /// 
    /// 
    /// </summary>
    public string? ObservacaoEcommerce { get; set; }

    public string? Alterapor { get; set; }

    public DateTime? Dataaltera { get; set; }
}
