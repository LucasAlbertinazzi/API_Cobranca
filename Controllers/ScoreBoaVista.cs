using API_AppCobranca.Models;
using API_AppCobranca.Suporte;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static API_AppCobranca.Suporte.ScoreSup;

namespace API_AppCobranca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreBoaVista : ControllerBase
    {
        private readonly DbmarciusbrtsSemanalContext _dbContext;
        private readonly ScoreSup _scoreSup;

        public ScoreBoaVista(DbmarciusbrtsSemanalContext dbContext)
        {
            _dbContext = dbContext;
            _scoreSup = new ScoreSup(_dbContext);
        }

        [HttpGet]
        [Route("last-score")]
        public async Task<IActionResult> LastScore(int codcliente, string tipo)
        {
            try
            {
                var consulta = await (from spc in _dbContext.TblSpcSerasas
                                      join usuario in _dbContext.TblUsuarios on spc.Codusuario equals usuario.Codusuario
                                      where spc.Codcliente == codcliente &&
                                            spc.Tipo == tipo &&
                                            spc.Excluido != 'S' &&
                                            spc.Situacao != null
                                      orderby spc.Codigo descending
                                      select new
                                      {
                                          spc.Codigo,
                                          spc.Informante,
                                          spc.Situacao,
                                          Usuario = usuario.Usuario,
                                          spc.Dataconsulta,
                                          Pdflast = spc.Informacao
                                      }).Take(1).FirstOrDefaultAsync();

                if (consulta != null)
                {
                    return Ok(consulta);
                }
                else
                {
                    return NotFound("Nenhum resultado encontrado.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("consulta-score")]
        public async Task<IActionResult> ConsultaScore([FromQuery] InfoScore infoScore)
        {
            infoScore.codigo = "21119";
            infoScore.senha = "87043";
            infoScore.codconsulta = "310";

            var result = await _scoreSup.Consultar(_scoreSup.Monta_String_Envio(infoScore), infoScore);

            if (string.IsNullOrEmpty(result))
            {
                return NotFound($"Não foi possível obter o score para o código do cliente {infoScore.codcliente}.");
            }

            return Ok(result);
        }

        [HttpPost]
        [Route("gravar-score")]
        public async Task<IActionResult> Gravar(InfoScore infoGravaSpc)
        {
            try
            {
                var itens = new TblSpcSerasa
                {
                    Codcliente = infoGravaSpc.codcliente,
                    Informante = infoGravaSpc.informante,
                    Dataconsulta = DateTime.Now,
                    Tipo = infoGravaSpc.tipos,
                    Codusuario = infoGravaSpc.codusuario,
                    Situacao = infoGravaSpc.situacao,
                    Informacao = infoGravaSpc.informacao
                };

                _dbContext.TblSpcSerasas.Add(itens);
                await _dbContext.SaveChangesAsync();

                return Ok(itens);
            }
            catch (Exception ex)
            {
                var innerExceptionMessage = ex.InnerException?.Message ?? ex.Message;
                return BadRequest($"Erro ao salvar as alterações: {innerExceptionMessage}");
            }
        }

        [HttpPost]
        [Route("update-score-titular")]
        public async Task<IActionResult> UpdateTitular(InfoScore infoGravaSpc)
        {
            try
            {
                if (Convert.ToInt64(infoGravaSpc.codcliente) == 0)
                {
                    return BadRequest("O ID do item é necessário para atualização.");
                }

                var itemToUpdate = await _dbContext.TblClientes.FindAsync(Convert.ToInt32(infoGravaSpc.codcliente));  // Obter o item existente pelo ID

                if (itemToUpdate == null)
                {
                    return NotFound($"O item com ID {infoGravaSpc.codcliente} não foi encontrado.");
                }

                // Atualizando propriedades
                itemToUpdate.Consspc = DateTime.UtcNow;
                itemToUpdate.Negativado = Convert.ToChar(infoGravaSpc.negativado);

                _dbContext.Entry(itemToUpdate).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();


                return Ok(itemToUpdate);
            }
            catch (Exception ex)
            {
                var innerExceptionMessage = ex.InnerException?.Message ?? ex.Message;
                return BadRequest($"Erro ao salvar as alterações: {innerExceptionMessage}");
            }
        }

        [HttpPost]
        [Route("update-score-conjuge")]
        public async Task<IActionResult> UpdateConjuge(InfoScore infoGravaSpc)
        {
            try
            {
                if (Convert.ToInt64(infoGravaSpc.codcliente) == 0)
                {
                    return BadRequest("O ID do item é necessário para atualização.");
                }

                var itemToUpdate = await _dbContext.TblClientes.FindAsync(infoGravaSpc.codcliente);  // Obter o item existente pelo ID

                if (itemToUpdate == null)
                {
                    return NotFound($"O item com ID {infoGravaSpc.codcliente} não foi encontrado.");
                }

                // Atualizando propriedades
                itemToUpdate.ConjConsspc = DateTime.Now;
                itemToUpdate.Negativado = Convert.ToChar(infoGravaSpc.negativado);

                await _dbContext.SaveChangesAsync();

                return Ok(itemToUpdate);
            }
            catch (Exception ex)
            {
                var innerExceptionMessage = ex.InnerException?.Message ?? ex.Message;
                return BadRequest($"Erro ao salvar as alterações: {innerExceptionMessage}");
            }
        }

        [HttpPost]
        [Route("carrega-pdf-score")]
        public async Task<IActionResult> CarregaPDF([FromBody] ResultadoRequest request)
        {
            if (string.IsNullOrEmpty(request.Resultado))
            {
                return BadRequest("A string de resultado não pode estar vazia.");
            }

            byte[] pdfBytes = await _scoreSup.GerarPdfBytes(request.Resultado);

            return File(pdfBytes, "application/pdf", "resultado.pdf");
        }

    }
}
