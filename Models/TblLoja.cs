using System;
using System.Collections.Generic;

namespace API_AppCobranca.Models;

public partial class TblLoja
{
    public int Codloja { get; set; }

    public string? Loja { get; set; }

    public string? Endereco { get; set; }

    public string? Bairro { get; set; }

    public string? Cidade { get; set; }

    public string? Cep { get; set; }

    public string? Uf { get; set; }

    public string? Fone { get; set; }

    public string? Tipoloja { get; set; }

    public string? Rsocial { get; set; }

    public string? Fantasia { get; set; }

    public string? Cnpj { get; set; }

    public string? Insc { get; set; }

    public string? Numero { get; set; }

    public string? Cnae { get; set; }

    public int? Codcidade { get; set; }

    public string? Im { get; set; }

    public int? Coduf { get; set; }

    public string? Email { get; set; }

    public short? Codrota { get; set; }

    public string? Complemento { get; set; }

    public string? TituloEtiqueta { get; set; }

    public virtual TblUf? CodufNavigation { get; set; }

    public virtual ICollection<TblAtivo> TblAtivos { get; set; } = new List<TblAtivo>();

    public virtual ICollection<TblCaixa> TblCaixas { get; set; } = new List<TblCaixa>();

    public virtual ICollection<TblEtiquetaIdent> TblEtiquetaIdents { get; set; } = new List<TblEtiquetaIdent>();

    public virtual ICollection<TblEtiquetaPreco> TblEtiquetaPrecos { get; set; } = new List<TblEtiquetaPreco>();

    public virtual ICollection<TblNfe> TblNves { get; set; } = new List<TblNfe>();

    public virtual ICollection<TblPrePedido> TblPrePedidos { get; set; } = new List<TblPrePedido>();

    public virtual ICollection<TblProdutoQuant> TblProdutoQuants { get; set; } = new List<TblProdutoQuant>();

    public virtual ICollection<TblUsuario> TblUsuarios { get; set; } = new List<TblUsuario>();
}
