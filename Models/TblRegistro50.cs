using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblRegistro50
{
    public int Codigo { get; set; }

    public string? Cnpj { get; set; }

    public string? Inscestadual { get; set; }

    public DateOnly? Dataemissao { get; set; }

    public string? Uf { get; set; }

    public int? Modelo { get; set; }

    public string? Serie { get; set; }

    public int? Numero { get; set; }

    public int? Cfop { get; set; }

    public char? Emitente { get; set; }

    public int? Valortotal { get; set; }

    public int? Basecalculoicms { get; set; }

    public int? Valoricms { get; set; }

    public int? Isentatributada { get; set; }

    public int? Outras { get; set; }

    public int? Aliquota { get; set; }

    public char? Situacao { get; set; }

    public int? Codloja { get; set; }

    public char? Cancelada { get; set; }

    public DateTime? Datacancelada { get; set; }

    public int? Usercancelou { get; set; }

    public char? Excluir { get; set; }

    public int? Novo { get; set; }
}
