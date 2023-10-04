using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblCadastroSenha
{
    public int Id { get; set; }

    public string? Loja { get; set; }

    public string? Objeto { get; set; }

    public string? Descricao { get; set; }

    public string? Senha { get; set; }

    public string? Observacao { get; set; }

    public string? Usuario { get; set; }

    public DateTime? DataInsercao { get; set; }

    public string? Ip { get; set; }

    public string? Url { get; set; }

    public string? Usuariosenha { get; set; }

    public char? Ativo { get; set; }

    public int CodDep { get; set; }
}
