using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class EcTblEtiquetaMercadoLivre
{
    public int Id { get; set; }

    public string Rastreio { get; set; } = null!;

    public string Codpedido { get; set; } = null!;

    public string Etiqueta { get; set; } = null!;
}
