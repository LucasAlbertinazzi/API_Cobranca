using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblVeiculo
{
    public int Codigo { get; set; }

    public string? Veiculo { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? Obs { get; set; }

    public char? Ativo { get; set; }

    public char? Montador { get; set; }

    public string? Placa { get; set; }

    public int? Ano { get; set; }

    public string? Codloja { get; set; }

    public decimal? CapacidadeM3 { get; set; }

    public decimal? CapacidadePeso { get; set; }

    public string? Tipo { get; set; }

    public virtual ICollection<TblVeiculoAbastecimento> TblVeiculoAbastecimentos { get; set; } = new List<TblVeiculoAbastecimento>();

    public virtual ICollection<TblVeiculoHistCarregamento> TblVeiculoHistCarregamentos { get; set; } = new List<TblVeiculoHistCarregamento>();

    public virtual ICollection<TblVeiculoHistManutencao> TblVeiculoHistManutencaos { get; set; } = new List<TblVeiculoHistManutencao>();
}
