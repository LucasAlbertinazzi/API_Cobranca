using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: ASSISTÊNCIA
/// Tabela com os registros das assistências abertas, tanto de clientes como as de loja.
/// 
/// </summary>
public partial class TblAssistencium
{
    public int Codigo { get; set; }

    public string? Localproduto { get; set; }

    public int Codassistencia { get; set; }

    public string? Pedido { get; set; }

    public string? Tipo { get; set; }

    public DateTime? Datacompra { get; set; }

    public DateTime? Entrada { get; set; }

    public DateTime? Previsao { get; set; }

    public int? Codcliente { get; set; }

    public string? Cliente { get; set; }

    public string? Cidade { get; set; }

    public string? Endereco { get; set; }

    public string? Bairro { get; set; }

    public string? Fone { get; set; }

    public string? Codproduto { get; set; }

    public string? Produto { get; set; }

    public string? Modelo { get; set; }

    public string? Nserie { get; set; }

    public DateTime? Enviado { get; set; }

    public string? Enviadopor { get; set; }

    public string? Notaremessa { get; set; }

    public string? OsAssistencia { get; set; }

    public DateTime? Retorno { get; set; }

    public string? Retornadopor { get; set; }

    public string? Notaretorno { get; set; }

    public DateTime? Entrega { get; set; }

    public string? Entregue { get; set; }

    public string? Entreguepor { get; set; }

    public string? Solucionado { get; set; }

    public string? Acessorios { get; set; }

    public string? Defeito { get; set; }

    public string? Obs { get; set; }

    public int? Estoqueloja { get; set; }

    public int? Estoquedeposito { get; set; }

    public int? Codusuario { get; set; }

    public string? Usuario { get; set; }

    public string? Estperfeito { get; set; }

    public string? Estregular { get; set; }

    public string? Estavarias { get; set; }

    public string? Manual { get; set; }

    public string? Controle { get; set; }

    public string? Cabo { get; set; }

    public string? Fonte { get; set; }

    public string? Caixa { get; set; }

    public string? Isopor { get; set; }

    public string? Retiradopor { get; set; }

    public char? Baixaestoque { get; set; }

    public int? Codlojaentrega { get; set; }

    public char? Retornadoloja { get; set; }

    public int? Idromaneio { get; set; }

    public int? Romaneio { get; set; }

    /// <summary>
    /// data que foi solicitado o romaneio
    /// </summary>
    public DateTime? Dataromaneio { get; set; }

    public DateOnly? Contatoassist { get; set; }

    public DateOnly? Contatocliente { get; set; }

    public char? Baixaparcial { get; set; }

    public int? Localbaixa { get; set; }

    public int? Nfe { get; set; }

    public char? EnvioDep { get; set; }

    public int? CodResponsavel { get; set; }

    /// <summary>
    /// Numero do chamado aberto no gerenciador de ocorrencia
    /// </summary>
    public long? Nchamado { get; set; }

    public bool? EnviadoDevolucao { get; set; }

    public string? XmlNfe { get; set; }

    public virtual TblUsuario? CodResponsavelNavigation { get; set; }
}
