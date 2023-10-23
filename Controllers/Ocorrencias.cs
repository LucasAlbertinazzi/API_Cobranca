using API_AppCobranca.Models;
using API_AppCobranca.Suporte.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Npgsql;
using System.Data;
using System.Net.Http;

namespace API_AppCobranca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ocorrencias : ControllerBase
    {
        private readonly DbContextApp _dbContext;

        public Ocorrencias(DbContextApp dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("busca-ocorrencias")]
        public async Task<IActionResult> BuscaOcorrencias()
        {
            var today = DateTime.Today;

            var result = from a in _dbContext.TblAnaliseCreditos
                         where !(a.Cancelado ?? false) && !(a.Finalizado ?? false) && a.Datasolicitacao > today
                         orderby a.Datasolicitacao ascending

                         join c in _dbContext.TblClientes on a.Codcliente equals c.Codcliente into ac
                         from c in ac.DefaultIfEmpty()

                         join l in _dbContext.TblLojas on a.Codloja equals l.Codloja into al
                         from l in al.DefaultIfEmpty()

                         join t in _dbContext.TblAnaliseCreditoTipos on (int?)a.Tiposenha equals t.Codsenha into at
                         from t in at.DefaultIfEmpty()

                         join u in _dbContext.TblUsuarios on a.Solicitante equals u.Codusuario into au
                         from u in au.DefaultIfEmpty()

                         select new
                         {
                             a.Codsolicitacao,
                             Loja = l.Loja,
                             NomeCliente = c.Nome,
                             Tipo = t.Tipo,
                             a.Codigo,
                             DataSolicitacao = a.Datasolicitacao,
                             a.Datasenha,
                             a.Analista,
                             Usuario = u.Usuario,
                             a.Obs,
                             a.Codcliente,
                             a.Codloja,
                             Tiposenha = a.Tiposenha,
                             a.Finalizado,
                             a.Solicitante,
                             a.Cancelado
                         };


            return Ok(result);
        }

        [HttpGet]
        [Route("verifica-ocorrencia")]
        public async Task<IActionResult> VerificaOcorrencia(int codocorrencia)
        {
            try
            {
                bool result = await _dbContext.TblAnaliseCreditos.AnyAsync(x => x.Codsolicitacao == codocorrencia && x.Finalizado == true && x.Datasenha != null);

                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest(false);
            }
        }

        [HttpGet]
        [Route("busca-ocorrencias-auto")]
        public async Task<IActionResult> BuscaOcorrenciasAuto(CancellationToken cancellationToken)
        {
            var response = Response;
            response.Headers.Add("Cache-Control", "no-cache");
            response.Headers.Add("Connection", "keep-alive");
            response.Headers.Add("Content-Type", "text/event-stream");

            var connectionString = _dbContext.Database.GetConnectionString();

            await using (var conn = new NpgsqlConnection(connectionString))
            {
                await conn.OpenAsync(cancellationToken);

                await using (var cmd = new NpgsqlCommand("LISTEN att_auto_ocorrencia_app_marcius_channel;", conn))
                {
                    await cmd.ExecuteNonQueryAsync(cancellationToken);

                    conn.Notification += async (o, e) =>
                    {
                        var eventType = e.Payload.Contains("Update") ? "Update" : "Insert";
                        List<dynamic> recentChanges;
                        if (eventType == "Update")
                            recentChanges = await GetRecentChangesUpdate();
                        else
                            recentChanges = await GetRecentChangesFromTable();

                        var data = new
                        {
                            eventType = eventType,
                            changes = recentChanges
                        };
                        await response.WriteAsync($"data: {JsonConvert.SerializeObject(data)}\n\n", cancellationToken);
                        await response.Body.FlushAsync(cancellationToken);
                    };

                    while (!cancellationToken.IsCancellationRequested)
                    {
                        await conn.WaitAsync(cancellationToken);
                    }
                }
            }

            return Ok();
        }

        private async Task<List<dynamic>> GetRecentChangesFromTable()
        {
            var today = DateTime.Today;

            var result = from a in _dbContext.TblAnaliseCreditos
                         where !(a.Cancelado ?? false) && !(a.Finalizado ?? false) && a.Datasolicitacao > today
                         orderby a.Datasolicitacao ascending

                         join c in _dbContext.TblClientes on a.Codcliente equals c.Codcliente into ac
                         from c in ac.DefaultIfEmpty()

                         join l in _dbContext.TblLojas on a.Codloja equals l.Codloja into al
                         from l in al.DefaultIfEmpty()

                         join t in _dbContext.TblAnaliseCreditoTipos on (int?)a.Tiposenha equals t.Codsenha into at
                         from t in at.DefaultIfEmpty()

                         join u in _dbContext.TblUsuarios on a.Solicitante equals u.Codusuario into au
                         from u in au.DefaultIfEmpty()

                         select new
                         {
                             a.Codsolicitacao,
                             Loja = l.Loja,
                             NomeCliente = c.Nome,
                             Tipo = t.Tipo,
                             a.Codigo,
                             DataSolicitacao = a.Datasolicitacao,
                             a.Datasenha,
                             a.Analista,
                             Usuario = u.Usuario,
                             a.Obs,
                             a.Codcliente,
                             a.Codloja,
                             Tiposenha = a.Tiposenha,
                             a.Finalizado,
                             a.Solicitante,
                             a.Cancelado
                         };


            return (await result.ToListAsync()).Cast<dynamic>().ToList();

        }

        private async Task<List<dynamic>> GetRecentChangesUpdate()
        {
            bool canceled = false;
            bool finalizado = true; // Você quer que finalizado seja true

            var query = from a in _dbContext.TblAnaliseCreditos
                        where (a.Cancelado ?? canceled) == false
                              && (a.Finalizado ?? !finalizado) // Modificado para buscar os que são finalizados
                              && a.Datasenha != null // Adicionado para buscar somente os que têm Datasenha
                              && a.Analista != null // Adicionado para buscar somente os que têm Analista
                        orderby a.Codsolicitacao descending // Modificado para ordenar pelo Codsolicitacao em ordem decrescente
                        join c in _dbContext.TblClientes on a.Codcliente equals c.Codcliente
                        select new
                        {
                            a.Codsolicitacao,
                            NomeCliente = c.Nome,
                            a.Codigo,
                            DataSolicitacao = a.Datasolicitacao,
                            a.Datasenha,
                            a.Analista,
                            a.Obs,
                            a.Codcliente,
                            a.Codloja,
                            Tiposenha = a.Tiposenha,
                            a.Finalizado,
                            a.Solicitante,
                            a.Cancelado
                        };

            return (await query.Take(20).ToListAsync()).Cast<dynamic>().ToList();
        }

        [HttpGet]
        [Route("busca-restricoes-ocorrencias")]
        public async Task<IActionResult> BuscaRestricoesOcorrencia(string codPrepedido)
        {
            try
            {
                int? codpre = Convert.ToInt32(codPrepedido);

                var query = from ocorrencia in _dbContext.TblOcorrencia
                            join motivo in _dbContext.TblOcorreMotivos on ocorrencia.Codocorrencia equals motivo.Codocorrencia
                            where ocorrencia.Codprepedido == codpre
                            orderby ocorrencia.Codigo
                            select new
                            {
                                Motivo = motivo.Motivo.TrimStart().ToUpper(),
                                Detalhe = ocorrencia.Detalhe.TrimStart().ToUpper(),
                                CodOcorrencia = ocorrencia.Codocorrencia,
                                CodPrePedido = ocorrencia.Codprepedido
                            };

                var results = query.ToList();
                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("busca-vendedor")]
        public async Task<ActionResult<int>> BuscaVendedor(string codigo)
        {
            try
            {
                int cod = Convert.ToInt32(codigo);
                var prePedido = await _dbContext.TblPrePedidos
                                .Where(x => x.Codprepedido == cod)
                                .Select(x => x.Codusuario)
                                .FirstOrDefaultAsync();

                if (prePedido == null)
                    return NotFound("Pedido não encontrado!");

                return Ok(prePedido);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        [Route("busca-senha-negada")]
        public async Task<IActionResult> BuscaSenhaNegada(string codcliente)
        {
            try
            {
                if (!int.TryParse(codcliente, out int _codcliente))
                    return BadRequest("Invalid client code");

                var query = from negada in _dbContext.TblSenhaNegada
                            where negada.Codcliente == _codcliente
                            orderby negada.Data descending
                            select new
                            {
                                Usuario = negada.Usuario.ToUpper(),
                                Motivo = negada.Motivo,
                                Data = negada.Data,
                                Senha = negada.Senha
                            };

                var result = query.Take(1).FirstOrDefault();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet]
        [Route("busca-score-historico")]
        public async Task<IActionResult> BuscaScoreHist(string codprepedido)
        {
            try
            {
                if (!int.TryParse(codprepedido, out int _codprepedido))
                    return BadRequest("Invalid client code");

                var query = from score in _dbContext.TblScoreLojaHists
                            join pre in _dbContext.TblPrePedidos on score.Codprepedido equals pre.Codprepedido
                            where pre.Codprepedido == _codprepedido
                            orderby score.Data descending
                            select new
                            {
                                Atenuentes = score.Atenuantes.ToUpper() ?? string.Empty,
                                Agravantes = score.Agravantes.ToUpper() ?? string.Empty,
                            };


                var result = query.Take(1).FirstOrDefault();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        [Route("aprova-pedido")]
        public async Task<IActionResult> AprovaPedido(TblPrePedido senhaPedido)
        {
            try
            {
                var _usuario = _dbContext.TblUsuarios.Where(x => x.Codusuario == senhaPedido.Codusuario).ToList();

                // Atualiza tbl_pre_pedido
                var prePedido = await _dbContext.TblPrePedidos
                    .Where(p => p.Codprepedido == senhaPedido.Codprepedido)
                    .FirstOrDefaultAsync();

                if (prePedido != null)
                {
                    prePedido.OcorrDesc = 0;
                    prePedido.Senha2 = _usuario[0].Usuario;
                    prePedido.Horasenha2 = senhaPedido.Horasenha2;
                    prePedido.Senha2obs = senhaPedido.Senha2obs;

                    await _dbContext.SaveChangesAsync();
                }

                // Atualiza tbl_analise_credito
                var analiseCredito = await _dbContext.TblAnaliseCreditos
                    .Where(ac => Convert.ToInt32(ac.Codigo) == senhaPedido.Codprepedido &&
                                 ac.Tiposenha == 1 &&
                                 ac.Codcliente == senhaPedido.Codcliente)
                    .FirstOrDefaultAsync();

                if (analiseCredito != null)
                {
                    analiseCredito.Datasenha = DateTime.Now;
                    analiseCredito.Analista = senhaPedido.Codusuario;
                    analiseCredito.Finalizado = true;

                    await _dbContext.SaveChangesAsync();
                }

                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("negar-pedido")]
        public async Task<IActionResult> NegarPedido(TblPrePedido senhaPedido)
        {
            try
            {
                var _usuario = _dbContext.TblUsuarios.Where(x => x.Codusuario == senhaPedido.Codusuario).ToList();

                var senhaNegada = new TblSenhaNegadum
                {
                    Codcliente = senhaPedido.Codcliente,
                    Usuario = _usuario[0].Usuario,
                    Motivo = senhaPedido.Senha2obs,
                    Data = DateTime.Now,
                    Senha = '2'
                };

                await _dbContext.TblSenhaNegada.AddAsync(senhaNegada);

                // Atualiza tbl_analise_credito
                var analiseCredito = await _dbContext.TblAnaliseCreditos
                    .Where(ac => Convert.ToInt32(ac.Codigo) == senhaPedido.Codprepedido &&
                                 ac.Tiposenha == 1 &&
                                 ac.Codcliente == senhaPedido.Codcliente)
                    .FirstOrDefaultAsync();

                if (analiseCredito != null)
                {
                    analiseCredito.Datasenha = DateTime.Now;
                    analiseCredito.Analista = senhaPedido.Codusuario;
                    analiseCredito.Finalizado = true;

                    await _dbContext.SaveChangesAsync();
                }

                await _dbContext.SaveChangesAsync();

                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
