using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblSitefVendum
{
    public int CupomFiscal { get; set; }

    public string Idtransacao { get; set; } = null!;

    public int Empresa { get; set; }

    public int Codcliente { get; set; }

    public long? NsuHost { get; set; }

    public long? NsuSitef { get; set; }

    public int TipoOperacao { get; set; }

    public int Codusuario { get; set; }

    public string? Retornos { get; set; }

    public decimal Valor { get; set; }

    public int Parcelas { get; set; }

    public string Pdv { get; set; } = null!;

    public DateTime DataInicio { get; set; }

    public DateTime? DataTransacao { get; set; }

    public decimal ValorBaixa { get; set; }

    public int? CupomCancelamento { get; set; }

    public int? CodusuarioAnaliseCliente { get; set; }

    public DateTime? DataAnaliseCliente { get; set; }
}
