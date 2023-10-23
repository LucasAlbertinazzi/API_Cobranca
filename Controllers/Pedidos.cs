using API_AppCobranca.Models;
using API_AppCobranca.Suporte.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_AppCobranca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Pedidos : ControllerBase
    {
        private readonly DbContextApp _dbContext;

        public Pedidos(DbContextApp dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("busca-codigo-pedido")]
        public async Task<ActionResult<string?>> BuscaCodigoPedido(string codprepedido)
        {
            try
            {
                int cod = Convert.ToInt32(codprepedido);
                var pedido = await _dbContext.TblPedidos
                                .Where(x => x.Codprepedido == cod)
                                .Select(x => x.Codpedido)
                                .FirstOrDefaultAsync();

                if (pedido == null)
                    return NotFound("Pedido não encontrado!");

                return Ok(pedido);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("busca-info-pedido")]
        public async Task<IActionResult> BuscaInfoPedido(string codigo)
        {
            try
            {
                var codPrePedido = Convert.ToInt32(codigo);

                // Primeiro passo: Obter prePedido
                var prePedidoQuery = _dbContext.TblPrePedidos
                    .Where(x => x.Codprepedido == codPrePedido);

                // Segundo passo: Construir a query passo a passo
                var query = from prePedido in prePedidoQuery
                            join loja in _dbContext.TblLojas on prePedido.Codloja equals loja.Codloja
                            join cliente in _dbContext.TblClientes on prePedido.Codcliente equals cliente.Codcliente
                            join usuario in _dbContext.TblUsuarios on prePedido.Codusuario equals usuario.Codusuario
                            join tipoVenda in _dbContext.TblTipoVenda on prePedido.Tipovenda equals tipoVenda.Codigo
                            from bairro in _dbContext.TblBairros.Where(b => b.Codbairro == prePedido.Codbairro).DefaultIfEmpty()
                            from cidade in _dbContext.TblCidades.Where(c => c.Codcidade == prePedido.Codcidade).DefaultIfEmpty()
                            select new
                            {
                                Nome = cliente.Nome,
                                CodCliente = cliente.Codcliente,
                                DataVenda = prePedido.Datavenda,
                                Fone = cliente.Fone,
                                Cpf = cliente.Cpf,
                                Rg = cliente.Rg,
                                TipoCadastro = cliente.Tipocadastro.ToString(),
                                Endereco = cliente.Endereco,
                                Numero = cliente.EnderecoNum,
                                Bairro = bairro.Bairro,
                                Cidade = cidade.Cidade,
                                Cep = cliente.Cep,
                                Uf = cliente.Uf,
                                Comprador = prePedido.Comprador,
                                CodUsuario = usuario.Codusuario,
                                AcrescimoPMedio = prePedido.Acrescimopmedio,
                                CodLoja = loja.Codloja,
                                TotalProduto = prePedido.Totalproduto,
                                Desconto = prePedido.Desconto,
                                Acrescimo = prePedido.Acrescimo,
                                TotalVenda = prePedido.Totalvenda,
                                TotalPagar = prePedido.Totalpagar,
                                ValorFrete = prePedido.ValorFrete,
                                Email = cliente.Email,
                                DataVenda1 = prePedido.Datavenda,
                                Hora = prePedido.Hora,
                                DataAbertura = prePedido.Dataabertura,
                                TipoVenda = tipoVenda.Tipovenda,
                                Usuario = usuario.Usuario,
                                Loja = loja.Loja,
                                Taxa = Convert.ToDecimal(prePedido.Taxa),
                                Parcelas = Convert.ToInt32(prePedido.Parcelas),
                                InfAddNFe = prePedido.InfAddNfe,
                                VendaEcManual = prePedido.VendaEcManual
                            };

                var result = await query.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("historico-pedidos")]
        public async Task<ActionResult<List<HistoricoClienteClass>>> BuscaHistoricoCliente(long codcliente)
        {
            try
            {
                var doisAnosAtras = DateOnly.FromDateTime(DateTime.Today.AddYears(-2));
                TimeOnly tempo = new TimeOnly(0, 0, 0);

                var historico = await (
                    from pz in _dbContext.TblParcelasPrazos
                    where pz.Codcliente == codcliente
                          && (pz.Forma == "DP" || pz.Forma == "CH")
                          && pz.Codpedido != null
                          && pz.Cancelado == 'N'
                          && pz.Vencimento >= doisAnosAtras
                    join c in _dbContext.TblClientes on pz.Codcliente equals c.Codcliente
                    join p in _dbContext.TblPedidos on pz.Codpedido equals p.Codpedido into pGroup
                    from p in pGroup.DefaultIfEmpty()
                    join sv in _dbContext.TblSitefVenda on pz.CupomTef equals sv.CupomFiscal into svGroup
                    from sv in svGroup.DefaultIfEmpty()
                    join pp in _dbContext.TblPrePedidos on pz.Codprepedido equals pp.Codprepedido into ppGroup
                    from pp in ppGroup.DefaultIfEmpty()

                    let atraso = pz.Pago == 'N' && pz.Vencimento.ToDateTime(tempo) > DateTime.Today ? 0 :
                        pz.Pago == 'N' && pz.Datapgto == null && pz.Vencimento.ToDateTime(tempo) < DateTime.Today ?
                        (int)(DateTime.Today - pz.Vencimento.ToDateTime(tempo)).TotalDays :
                        pz.Pago == 'S' && pz.Datapgto != null ?
                        (int)((pz.Datapgto.Value - pz.Vencimento.ToDateTime(tempo)).TotalDays) : 0
                    let qtdpedido = (
                        from pz2 in _dbContext.TblParcelasPrazos
                        join p2 in _dbContext.TblPedidos on pz2.Codpedido equals p2.Codpedido
                        where pz2.Codcliente == codcliente
                            && p2.Codpedido != null
                            && p2.Cancelado == 'N'
                        select p2.Codpedido
                    ).Distinct().Count()
                    let valorgasto = (
                        from pz3 in _dbContext.TblParcelasPrazos
                        where pz3.Codcliente == codcliente
                            && pz3.Codpedido != null
                            && pz3.Cancelado == 'N'
                        select pz3.Valorpago
                    ).Sum()
                    select new HistoricoClienteClass
                    {
                        codpedido = pz.Codpedido,
                        valorpago = pz.Valorpago,
                        vencimento = pz.Vencimento,
                        valor = pz.Valor,
                        pago = pz.Pago,
                        atraso = atraso,
                        qtdpedido = qtdpedido,
                        valorgasto = valorgasto ?? 0,
                        nomecliente = pp.Cliente
                    }
                ).OrderByDescending(h => h.vencimento).ToListAsync();

                return Ok(historico);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        [HttpGet]
        [Route("historico-pedidos-periodo")]
        public async Task<ActionResult<List<HistoricoClienteClass>>> BuscaHistoricoClientePeriodo(long codcliente, string periodo)
        {
            try
            {
                string newPeriodo = string.Empty;
                if (periodo.Contains("ANOS"))
                {
                    newPeriodo = periodo.Replace("ANOS", "");
                    newPeriodo = newPeriodo.Replace(" ", "");
                }
                else
                {
                    newPeriodo = periodo.Replace("ANO", "");
                    newPeriodo = newPeriodo.Replace(" ", "");
                }

                // Converter em int
                int periodoInt = int.Parse(newPeriodo);

                var doisAnosAtras = DateOnly.FromDateTime(DateTime.Today.AddYears(-periodoInt));
                TimeOnly tempo = new TimeOnly(0, 0, 0);

                var historico = await (
                    from pz in _dbContext.TblParcelasPrazos
                    where pz.Codcliente == codcliente
                          && (pz.Forma == "DP" || pz.Forma == "CH")
                          && pz.Codpedido != null
                          && pz.Cancelado == 'N'
                          && pz.Vencimento >= doisAnosAtras
                    join c in _dbContext.TblClientes on pz.Codcliente equals c.Codcliente
                    join p in _dbContext.TblPedidos on pz.Codpedido equals p.Codpedido into pGroup
                    from p in pGroup.DefaultIfEmpty()
                    join sv in _dbContext.TblSitefVenda on pz.CupomTef equals sv.CupomFiscal into svGroup
                    from sv in svGroup.DefaultIfEmpty()
                    join pp in _dbContext.TblPrePedidos on pz.Codprepedido equals pp.Codprepedido into ppGroup
                    from pp in ppGroup.DefaultIfEmpty()

                    let atraso = pz.Pago == 'N' && pz.Vencimento.ToDateTime(tempo) > DateTime.Today ? 0 :
                        pz.Pago == 'N' && pz.Datapgto == null && pz.Vencimento.ToDateTime(tempo) < DateTime.Today ?
                        (int)(DateTime.Today - pz.Vencimento.ToDateTime(tempo)).TotalDays :
                        pz.Pago == 'S' && pz.Datapgto != null ?
                        (int)((pz.Datapgto.Value - pz.Vencimento.ToDateTime(tempo)).TotalDays) : 0
                    let qtdpedido = (
                        from pz2 in _dbContext.TblParcelasPrazos
                        join p2 in _dbContext.TblPedidos on pz2.Codpedido equals p2.Codpedido
                        where pz2.Codcliente == codcliente
                            && p2.Codpedido != null
                            && p2.Cancelado == 'N'
                        select p2.Codpedido
                    ).Distinct().Count()
                    let valorgasto = (
                        from pz3 in _dbContext.TblParcelasPrazos
                        where pz3.Codcliente == codcliente
                            && pz3.Codpedido != null
                            && pz3.Cancelado == 'N'
                        select pz3.Valorpago
                    ).Sum()
                    select new HistoricoClienteClass
                    {
                        prepedido = pz.Codprepedido,
                        codpedido = pz.Codpedido,
                        valorpago = pz.Valorpago,
                        vencimento = pz.Vencimento,
                        valor = pz.Valor,
                        pago = pz.Pago,
                        atraso = atraso,
                        qtdpedido = qtdpedido,
                        valorgasto = valorgasto ?? 0,
                        nomecliente = pp.Cliente
                    }
                ).OrderByDescending(h => h.vencimento).ToListAsync();

                return Ok(historico);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        [HttpGet]
        [Route("busca-info-produtos-pedido")]
        public async Task<IActionResult> BuscaInfoProdutosPedido(string codigo)
        {
            try
            {
                var codPrePedido = Convert.ToInt32(codigo);

                var query = from loja in _dbContext.TblLojas
                            join subPedido in _dbContext.TblSubPedidos on loja.Codloja equals subPedido.Coddeposito
                            join produto in _dbContext.TblProdutos on subPedido.Codproduto equals produto.Codproduto
                            from tipoEntrega in _dbContext.TblTipoEntregas.Where(t => t.Codigo == subPedido.TipoEntrega).DefaultIfEmpty()
                            from ecf in _dbContext.TblEcfs.Where(e => e.SerieMfd == subPedido.SerieEcf).DefaultIfEmpty()
                            from bilhete in _dbContext.TblBilheteGarantia.Where(b => b.Codsubpedido == subPedido.Codigo).DefaultIfEmpty()
                            where subPedido.Codprepedido == codPrePedido
                            select new
                            {
                                Codigo = subPedido.Codigo,
                                CodProdutoIndex = subPedido.Codprodutoindex,
                                Descricao = produto.Descricao,
                                QuantVendido = Convert.ToInt32(subPedido.Quantvendido),
                                ValorVenda = subPedido.Valorvenda,
                                ValorTotal = subPedido.Valortotal,
                                CodDeposito = subPedido.Coddeposito,
                                TipoEntrega = tipoEntrega.Tipo,
                                Nfe = subPedido.Nfe,
                                Nfce = subPedido.Nfce,
                                CodProduto = subPedido.Codproduto,
                                JuroEspec = subPedido.Juroespec.ToString(),
                                Promocao = subPedido.Promocao.ToString(),
                                BotaFora = subPedido.Botafora.ToString(),
                                Restou = Convert.ToInt32(subPedido.Restou),
                                Loja = loja.Loja,
                                CodFabrica = subPedido.Codfabrica,
                                EstoqueAnterior = Convert.ToInt32(subPedido.Estoqueanterior),
                                TempoMontagem = subPedido.Tempomontagem,
                                Montar = subPedido.Montar.ToString(),
                                Aliquota = produto.Aliquota,
                                Exclusivo22 = produto.Exclusivo22,
                                UserF = subPedido.UserF,
                                NF = subPedido.NF,
                                NumF = subPedido.NumF,
                                UserCF = subPedido.UserCf,
                                CF = subPedido.Cf,
                                NumCF = subPedido.NumCf,
                                Romaneio = subPedido.Romaneio,
                                LiberaCupom = subPedido.Liberacupom.ToString(),
                                PrecoVendaT1 = subPedido.PrecovendaT1,
                                Tipo_Entrega = Convert.ToInt32(subPedido.TipoEntrega),
                                TaxaProduto = subPedido.Taxa,
                                Imei = subPedido.Imei,
                                Ecf = ecf.Ecf,
                                Bilhete = bilhete.Bilhete,
                                IdSeguroSabemi = subPedido.IdSeguroSabemi
                            };

                var result = await query.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("busca-info-parcelas-pedido")]
        public async Task<IActionResult> BuscaInfoParcelasPedido(int codigoPrePedido)
        {
            try
            {
                string filtroPedido = codigoPrePedido == 0 ? $" codpedido = '{codigoPrePedido}'" : $" codprepedido = '{codigoPrePedido}'";
                string filtro = true ? "" : " AND tipoparcela = 'I' ";

                var query = from parcela in _dbContext.TblParcelasPrazos
                            from usuario in _dbContext.TblUsuarios.Where(u => u.Codusuario == parcela.Codusuario).DefaultIfEmpty()
                            where (codigoPrePedido == 0 ? parcela.Codpedido == codigoPrePedido.ToString() : parcela.Codprepedido == codigoPrePedido) && EF.Functions.ILike(filtro, "")
                            orderby parcela.Vencimento, parcela.Codigo
                            select new
                            {
                                Parc = parcela.Parcela + "/" + parcela.Quantparcela,
                                Vencimento = parcela.Vencimento,
                                CupomTef = parcela.CupomTef,
                                Valor = parcela.Valor,
                                Forma = parcela.Forma,
                                FormaRecebido = parcela.FormaRecebido,
                                Documento = parcela.Documento,
                                Pago = parcela.Pago.ToString(),
                                ValorPago = parcela.Valorpago,
                                DataPgto = parcela.Datapgto,
                                Usuario = usuario.Usuario,
                                Estornada = parcela.Estornada + " - Motivo: " + parcela.Motivoestorno,
                                NumParcela = 0,
                                Codigo = parcela.Codigo
                            };

                var result = await query.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
