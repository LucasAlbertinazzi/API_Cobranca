using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

/// <summary>
/// SETOR: Inclusão
/// Esta tabela é gerenciada pela tela FrmCriaGrupoProd, acessada através do ContextMenuStrip da FrmListaProduto, no item &quot;Criar Novo Grupo&quot;. Basicamente os produtos são agrupados para compartilhares características em comum, como o preço de venda e determinada descrição.
/// </summary>
public partial class TblProdutoGrupo
{
    public int Codigo { get; set; }

    public string? Descricao { get; set; }
}
