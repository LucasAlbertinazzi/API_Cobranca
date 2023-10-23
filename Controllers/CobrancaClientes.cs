using API_AppCobranca.Models;
using API_AppCobranca.Suporte.Classes;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace API_AppCobranca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CobrancaClientes : ControllerBase
    {
        private readonly DbContextApp _dbContext;

        public CobrancaClientes(DbContextApp dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("cobranca-atraso")]
        public async Task<IActionResult> BuscaAtraso([FromQuery] CobrancaClientesClass item)
        {
            try
            {
                var query = _dbContext.TblParcelasPrazos.Where(
                    x => x.Codcliente == item.Codcliente &&
                         x.Vencimento < item.Vencimento &&
                         x.Pago == item.Pago &&
                         x.Tipovenda == item.Tipovenda &&
                         x.Cancelado == item.Cancelado).OrderBy(z => z.Vencimento).ToList();

                return Ok(query);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpGet]
        [Route("cobranca-vencer")]
        public async Task<IActionResult> BuscaVencer([FromQuery] CobrancaClientesClass item)
        {
            try
            {
                var query = _dbContext.TblParcelasPrazos.Where(
                                         x => x.Codcliente == item.Codcliente &&
                                         x.Vencimento >= item.Vencimento &&
                                         x.Tipovenda == item.Tipovenda &&
                                         x.Cancelado == item.Cancelado).OrderBy(z => z.Vencimento).ToList();

                return Ok(query);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("cobranca-historico")]
        public async Task<IActionResult> BuscaHistoricoCobranca([FromQuery] CobrancaClientesClass item)
        {
            try
            {
                var query = from cc in _dbContext.TblCobrancaConts
                                   join u in _dbContext.TblUsuarios on cc.Codusuario equals u.Codusuario
                                   where cc.Codcliente == item.Codcliente
                                   orderby cc.Datacontato descending
                                   select new
                                   {
                                       cc.Datacontato,
                                       cc.Descricao,
                                       cc.ClienteProcessado,
                                       u.Usuario
                                   };

                return Ok(query);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("cobranca-new")]
        public async Task<IActionResult> NovaCobranca(CobrancaClientesClass item)
        {
            try
            {
                var newcobranca = new TblCobrancaCont
                {
                    Codcliente = item.Codcliente,
                    Codusuario = item.Codusuario,
                    Datacontato = item.Datacontato,
                    Descricao = item.Descricao,
                    ClienteProcessado = item.ClienteProcessado
                };

                await _dbContext.TblCobrancaConts.AddAsync(newcobranca);
                await _dbContext.SaveChangesAsync();

                var cliente = _dbContext.TblClientes
                   .FirstOrDefault(x => x.Codcliente == item.Codcliente);

                if (cliente != null)
                {
                    cliente.Segcontato = 'S';
                    await _dbContext.SaveChangesAsync();
                }

                return Ok(true);
            }
            catch (Exception)
            {
                return BadRequest(false);
            }
        }

        [HttpPost]
        [Route("cobranca-agendamento")]
        public async Task<IActionResult> AgendamentoCobranca([FromBody] CobrancaClientesClass item)
        {
            try
            {
                var cliente = _dbContext.TblClientes
                    .FirstOrDefault(x => x.Codcliente == item.Codcliente);

                if (cliente != null)
                {
                    cliente.Pgtopara = item.Pgtopara;
                    cliente.Agendacobranca = item.Agendacobranca;
                    await _dbContext.SaveChangesAsync();
                    return Ok(true);
                }
                else
                {
                    return NotFound(false);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(false);
            }
        }

    }
}
