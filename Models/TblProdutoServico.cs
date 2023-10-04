using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: Inclusão, Pedido, Produto
/// Contém as faixas de preço das garantias estendidas. Baseado no departamento do serviço, puxa-se o preço da garantia por esta tabela, sendo: 900-Eletrodomésticos, 901-Eletroportáteis, 902-Vídeo, 903-Audio, 904-Fotografia, 905-Telefones, 906-Informática, 907-Bicicleta/Fitness, 908-Ferramentas Elétricas e 909-Móveis
/// </summary>
public partial class TblProdutoServico
{
    public int Codigo { get; set; }

    public string? Codproduto { get; set; }

    public decimal? Valorinicio { get; set; }

    public decimal? Valorfim { get; set; }

    public decimal? Premio1 { get; set; }

    public decimal? Premio2 { get; set; }

    public bool? Precounico { get; set; }

    public decimal? Iof { get; set; }

    public decimal? Margempremio { get; set; }

    public decimal? Custo1 { get; set; }

    public decimal? Custo2 { get; set; }

    public decimal? PisCofins { get; set; }

    public decimal? PremioLiq1 { get; set; }

    public decimal? PremioLiq2 { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Atualizado { get; set; }

    public int? CodusuarioWeb { get; set; }

    public DateTime? AtualizadoWeb { get; set; }
}
