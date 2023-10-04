using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// Contém informações de Acesso para Consumir o WebService dos Corrêios
/// </summary>
public partial class EcTblCorreio
{
    public string Cnpj { get; set; } = null!;

    public char? TipoDestinatario { get; set; }

    public string? Identificador { get; set; }

    public string? Usuario { get; set; }

    public string? Senha { get; set; }

    public string? IdCartaoPostagem { get; set; }

    public string? NumeroDiretoria { get; set; }

    public string? CodigoAdministrativo { get; set; }

    public string? NomeRemetente { get; set; }

    public string? LogradouroRemetente { get; set; }

    public string? NumeroRemetente { get; set; }

    public string? BairroRemetente { get; set; }

    public string? CepRemetente { get; set; }

    public string? CidadeRemetente { get; set; }

    public string? UfRemetente { get; set; }

    public string? FoneRemetente { get; set; }

    public string? EmailRemetente { get; set; }

    public string? ComplementoRemetente { get; set; }

    public string? IdContrato { get; set; }
}
