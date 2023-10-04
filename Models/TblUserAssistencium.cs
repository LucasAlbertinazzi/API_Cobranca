using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblUserAssistencium
{
    public int Codigo { get; set; }

    public int? Codusuario { get; set; }

    /// <summary>
    /// local de onde o usuario pode retirar os produtos
    /// </summary>
    public int? Retira { get; set; }

    /// <summary>
    /// local para onde o usuario pode lançar os produtos
    /// </summary>
    public int? Inclui { get; set; }

    public int? Senhapedido { get; set; }

    public virtual TblUsuario? CodusuarioNavigation { get; set; }
}
