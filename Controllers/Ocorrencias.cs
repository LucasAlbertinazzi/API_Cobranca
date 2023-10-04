﻿using API_AppCobranca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Npgsql;
using System.Data;

namespace API_AppCobranca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ocorrencias : ControllerBase
    {
        private readonly DbmarciusbrtsSemanalContext _dbContext;

        public Ocorrencias(DbmarciusbrtsSemanalContext dbContext)
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

    }
}
