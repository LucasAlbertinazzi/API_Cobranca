using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// CÓDIGOS DAS CIDADES É DA LISTA DO IBGE
/// https://www.ibge.gov.br/explica/codigos-dos-municipios.php
/// 
/// idcidade é a coluna Município da tabela de códigos do IBGE,
/// codcidade é a coluna Código Município Completo
/// </summary>
public partial class TblCidade
{
    public int Codcidade { get; set; }

    public int? Coduf { get; set; }

    public string? Idcidade { get; set; }

    public string Cidade { get; set; } = null!;

    public int? Codrota { get; set; }

    public virtual TblUf? CodufNavigation { get; set; }
}
