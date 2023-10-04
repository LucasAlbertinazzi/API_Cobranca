using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblRenegociarSenha
{
    public int Codusuario { get; set; }

    public int? Senha { get; set; }

    public int? Usuario { get; set; }

    public DateTime? Data { get; set; }
}
