using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblNotum
{
    public int Codigo { get; set; }

    public int? Serie { get; set; }

    public int? Numero { get; set; }

    public char? Tipo { get; set; }

    public string? Natureza { get; set; }

    public int? Cfop { get; set; }

    public int? Codloja { get; set; }

    public string? Nome { get; set; }

    public string? Cpf { get; set; }

    public string? Rg { get; set; }

    public string? Endereco { get; set; }

    public string? Bairro { get; set; }

    public string? Cep { get; set; }

    public string? Municipio { get; set; }

    public string? Fone { get; set; }

    public string? Uf { get; set; }

    public decimal? Baseicms { get; set; }

    public decimal? Valoricms { get; set; }

    public decimal? BaseicmsSubst { get; set; }

    public decimal? ValoricmsSubst { get; set; }

    public decimal? Valorfrete { get; set; }

    public decimal? Valorseguro { get; set; }

    public decimal? Outrasdespesas { get; set; }

    public decimal? Valoripi { get; set; }

    public decimal? Valorprodutos { get; set; }

    public decimal? Valornota { get; set; }

    public string? TranspNome { get; set; }

    /// <summary>
    /// 1-EMITENTE
    /// 2-DESTINATARIO
    /// </summary>
    public int? FretePorconta { get; set; }

    public string? Placa { get; set; }

    public string? TranspUf { get; set; }

    public string? TranspCpf { get; set; }

    public string? TranspEndereco { get; set; }

    public string? TranspMunicipio { get; set; }

    public string? TranspUf2 { get; set; }

    public string? TranspInsc { get; set; }

    public int? Quantidade { get; set; }

    public string? Especie { get; set; }

    public string? Marca { get; set; }

    public decimal? Pesobruto { get; set; }

    public decimal? Pesoliquido { get; set; }

    public string? Dadosadd { get; set; }

    public int? TranspNumero { get; set; }

    public DateOnly? Dataemissao { get; set; }

    public DateTime? Data { get; set; }

    public int? Codusuario { get; set; }

    public char? Cancelada { get; set; }

    public int? Canceladapor { get; set; }

    public DateTime? Datacancelada { get; set; }

    public virtual ICollection<TblNotaSub> TblNotaSubs { get; set; } = new List<TblNotaSub>();
}
