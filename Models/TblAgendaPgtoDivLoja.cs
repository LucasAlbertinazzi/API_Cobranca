using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: FINANCEIRO
/// Contém a divisão do pagamento ou vale, em porcentagem, entre as lojas. Esta tabela é gerenciada através da tela FrmEditarParcAgenda, na aba &quot;Divisão por Loja&quot;.
/// 
/// </summary>
public partial class TblAgendaPgtoDivLoja
{
    public int Codigo { get; set; }

    public int? Codpedidocompra { get; set; }

    public int? Codloja { get; set; }

    public decimal? Porcent { get; set; }
}
