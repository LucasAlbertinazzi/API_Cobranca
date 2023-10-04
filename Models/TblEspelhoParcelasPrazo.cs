using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblEspelhoParcelasPrazo
{
    public int Codigo { get; set; }

    public long? Codprepedido { get; set; }

    public string? Codpedido { get; set; }

    public DateOnly? Datapedido { get; set; }

    public long? Quantparcela { get; set; }

    public long? Parcela { get; set; }

    public DateOnly? Vencimento { get; set; }

    public decimal? Valor { get; set; }

    public string? Forma { get; set; }

    public string? Documento { get; set; }

    public long? Codcliente { get; set; }

    public short? Tipovenda { get; set; }

    public char? Pago { get; set; }

    public DateTime? Datapgto { get; set; }

    public short? Diasatraso { get; set; }

    public decimal? Jurodia { get; set; }

    public decimal? Valorjuro { get; set; }

    public decimal? Valorpagar { get; set; }

    public decimal? Desconto { get; set; }

    public decimal? Valorpago { get; set; }

    public short? Codusuario { get; set; }

    public char? Caixa { get; set; }

    public short? Codloja { get; set; }

    public int? Idcaixa { get; set; }

    public DateOnly? Chequepre { get; set; }

    public char? Baixaparcial { get; set; }

    public char? Tipoparcela { get; set; }

    public string? Codpagamento { get; set; }

    public char? Cancelado { get; set; }

    public string? Pagoparcial { get; set; }

    public char? Pgtocheque { get; set; }

    public string? Motdesc { get; set; }

    public string? Motdescger { get; set; }

    public string? Descautorizado { get; set; }

    public short? Codlojapedido { get; set; }

    public char? Classe { get; set; }

    public int? Codfinanceira { get; set; }

    public string? Contratofinan { get; set; }

    public string? Estornada { get; set; }

    public string? Inclusaospc { get; set; }

    public string? Motivoestorno { get; set; }

    public bool? ConfCartao { get; set; }

    public int? CodReneg { get; set; }

    public string? MetodoPgto { get; set; }

    public short? IdMetodoPgto { get; set; }

    public DateTime? ClasseAlterada { get; set; }
}
