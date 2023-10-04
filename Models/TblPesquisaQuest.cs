using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblPesquisaQuest
{
    public int Codigo { get; set; }

    public string? Questao { get; set; }

    public string? Detalhe { get; set; }

    public char? Ativo { get; set; }

    /// <summary>
    /// P = pessoal
    /// E = empresa
    /// </summary>
    public char? Tipo { get; set; }

    /// <summary>
    /// M = Multipla escolha
    /// D = Disertativa
    /// </summary>
    public char? Resposta { get; set; }
}
