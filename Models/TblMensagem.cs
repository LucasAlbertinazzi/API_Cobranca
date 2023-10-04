using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblMensagem
{
    public int Codigo { get; set; }

    public int? Codreme { get; set; }

    public int? Coddest { get; set; }

    public string? Assunto { get; set; }

    public string? Mensagem { get; set; }

    public DateTime? Data { get; set; }

    public char? Lida { get; set; }

    public char? Arquivar { get; set; }

    public string? Destinatarios { get; set; }

    public int? Codmensagemenviada { get; set; }

    public string? Codanexo { get; set; }

    public virtual TblUsuario? CoddestNavigation { get; set; }

    public virtual TblUsuario? CodremeNavigation { get; set; }
}
