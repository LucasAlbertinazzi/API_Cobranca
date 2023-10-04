using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class EcTblProtocolo
{
    public int Numeroprotocolo { get; set; }

    public DateTime? Dataliberacao { get; set; }

    public DateTime? Datarecebimento { get; set; }

    public string? Status { get; set; }

    public string? Codpedido { get; set; }

    public DateTime? Dataprotocolo { get; set; }

    public string? Motivocancelamento { get; set; }

    public int? Notadevolucao { get; set; }

    public string? Metodoentrega { get; set; }

    public string? Situacaoproduto { get; set; }

    public string? Produtovai { get; set; }

    public string? Clienteatendidopor { get; set; }

    public string? Obs { get; set; }

    public string? Transpretorno { get; set; }

    public long? Codcliente { get; set; }

    public string? Codoperador { get; set; }

    public string? Idusuario { get; set; }

    public string? Idusuarioex { get; set; }

    public string? Idusuarioconf { get; set; }

    public string? Idusuariocatenf { get; set; }

    public long? Codromaneio { get; set; }

    public string? Loja { get; set; }

    public DateTime? Dataidusuario { get; set; }

    public DateTime? Dataidusuarioex { get; set; }

    public DateTime? Dataidusuarioconf { get; set; }

    public DateTime? Dataidusuariocatenf { get; set; }

    public string? Obsexp { get; set; }

    public string? Obsconf { get; set; }

    public string? Codproduto { get; set; }

    public string? Nome { get; set; }

    public string? Codproduto21 { get; set; }

    public string? Codproduto22 { get; set; }

    public string? Tipoatendimento { get; set; }

    public string? Usuarioec { get; set; }

    public string? Usuarioexp { get; set; }

    public DateTime? Datarecebimento1 { get; set; }

    public string? Tipoprotocolo { get; set; }

    public string? Idusuariofiscal { get; set; }

    public DateTime? Dataidusuariofiscal { get; set; }

    public DateTime? Datarecebimento2 { get; set; }

    public string? Pesocubado { get; set; }

    public int? Notafiscal { get; set; }

    public string? Obsfiscal { get; set; }

    public string? Idusuariodep { get; set; }

    public DateTime? Dataidusuariodep { get; set; }

    public DateTime? Datarecebimento3 { get; set; }

    public string? Obsdep { get; set; }

    public string? Idusuarioinc { get; set; }

    public DateTime? Dataidusuarioinc { get; set; }

    public DateTime? Datarecebimento4 { get; set; }

    public string? Obsinclusao { get; set; }

    public string? Idusuarioassist { get; set; }

    public DateTime? Dataidusuarioassist { get; set; }

    public DateTime? Datarecebimento5 { get; set; }

    public string? Obsassist { get; set; }

    public string? Transfavaria { get; set; }

    public string? Numos { get; set; }
}
