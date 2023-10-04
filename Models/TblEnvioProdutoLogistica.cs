using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblEnvioProdutoLogistica
{
    public int Id { get; set; }

    public string CodProduto { get; set; } = null!;

    public int Empresa { get; set; }

    public DateTime DataEnvio { get; set; }

    public int CodUsuarioEnvio { get; set; }

    public bool Entrou { get; set; }

    public string? Retorno { get; set; }
}
