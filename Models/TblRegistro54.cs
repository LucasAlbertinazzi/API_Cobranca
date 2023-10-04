using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblRegistro54
{
    public int Codigo { get; set; }

    public string? Cnpj { get; set; }

    public int? Modelo { get; set; }

    public string? Serie { get; set; }

    public int? Numero { get; set; }

    public int? Cfop { get; set; }

    public int? Cst { get; set; }

    public string? Codproduto { get; set; }

    public int? Quantidade { get; set; }

    public int? Valor { get; set; }

    public int? Valordesconto { get; set; }

    public int? Basecalculoicms { get; set; }

    public int? Basecalculoicmsst { get; set; }

    public int? Valoripi { get; set; }

    public int? Aliquotaicms { get; set; }

    public int? Codloja { get; set; }

    public int? Numeroitem { get; set; }

    public DateOnly? Dataemissao { get; set; }

    public char? Cancelada { get; set; }

    public DateTime? Datacancelada { get; set; }

    public int? Usercancelou { get; set; }
}
