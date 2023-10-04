using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblBaseicmsTransferencium
{
    public int Id { get; set; }

    public string Codproduto { get; set; } = null!;

    public decimal? ValordaBcIcmsStRetido { get; set; }

    public decimal? AliquotaSuportadaPeloConsumidorFinal { get; set; }

    public decimal? ValorDoIcmsProprioDoSubstituto { get; set; }

    public decimal? ValorDoIcmsStRetido { get; set; }

    public decimal? Codusuario { get; set; }

    public DateOnly? Data { get; set; }

    public string? NumeroNfeEntrada { get; set; }

    public decimal? QuantidadeAtual { get; set; }

    public decimal? QuantidadeEntrada { get; set; }
}
