using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: COBRANÇA
/// Esta tabela é gerenciada através da tela FrmCriarAgCobranca, onde são inseridos uma cidade para determinada data. Os últimos registros desta tabela são de 2016, era utilizado pela Silmara. Agenda de cobrança específica para uma cidade.
/// 
/// </summary>
public partial class TblAgendaEspecf
{
    public int Codigo { get; set; }

    public DateOnly? Data { get; set; }

    public string? Cidade1 { get; set; }

    public string? Cidade2 { get; set; }

    public DateTime? Datacriacao { get; set; }

    public int? Codusuario { get; set; }

    public virtual TblUsuario? CodusuarioNavigation { get; set; }
}
