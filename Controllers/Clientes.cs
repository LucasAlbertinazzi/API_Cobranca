using API_AppCobranca.Models;
using API_AppCobranca.Suporte;
using LinqKit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SixLabors.ImageSharp.Formats.Png;
using System.Linq;

namespace API_AppCobranca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Clientes : ControllerBase
    {
        private string path = "\\\\192.168.10.14\\fileserver\\MATRIZ\\SISTEMA_LOJAS\\Imagens\\Fotosclientes\\";

        private readonly DbmarciusbrtsSemanalContext _dbContext;

        public Clientes(DbmarciusbrtsSemanalContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("busca-cliente-tipo")]
        public async Task<IActionResult> BuscaClienteTipo(string texto, string tipo, string tipoCliente)
        {
            try
            {
                var query = from usuario in _dbContext.TblUsuarios
                            join cliente in _dbContext.TblClientes on usuario.Codusuario equals cliente.Codusuario
                            select new
                            {
                                Cliente = cliente,
                                Usuario = usuario.Usuario,
                                BairroCliente = cliente.Codbairro.HasValue ? _dbContext.GetBairro(cliente.Codbairro.Value) : null,
                                CidadeCliente = cliente.Codcidade.HasValue ? _dbContext.GetCidade(cliente.Codcidade.Value) : null,
                                BairroEmpresa = cliente.EmpreCodbairro.HasValue ? _dbContext.GetBairro(cliente.EmpreCodbairro.Value) : null,
                                CidadeEmpresa = cliente.EmpreCodcidade.HasValue ? _dbContext.GetCidade(cliente.EmpreCodcidade.Value) : null,
                                BairroConjuje = cliente.CodbairroEmpConj.HasValue ? _dbContext.GetBairro(cliente.CodbairroEmpConj.Value) : null,
                                CidadeConjuje = cliente.CodcidadeEmpConj.HasValue ? _dbContext.GetCidade(cliente.CodcidadeEmpConj.Value) : null,
                                BairroCorrespondencia = cliente.CodbairroC.HasValue ? _dbContext.GetBairro(cliente.CodbairroC.Value) : null,
                                CidadeCorrespondencia = cliente.CodcidadeC.HasValue ? _dbContext.GetCidade(cliente.CodcidadeC.Value) : null
                            };

                if(tipoCliente == "TITULAR")
                {
                    switch (tipo)
                    {
                        case "cpf":
                            query = query.Where(q => q.Cliente.Cpf == texto);
                            break;
                        case "cnpj":
                            query = query.Where(q => q.Cliente.Cnpj == texto);
                            break;
                        case "cliente":
                            query = query.Where(q => q.Cliente.Nome == texto);
                            break;
                        case "codcliente":
                            query = query.Where(q => q.Cliente.Codcliente == Convert.ToInt32(texto));
                            break;
                        default:
                            // Tipo inválido, faça o tratamento apropriado aqui.
                            break;
                    }
                }
                else
                {
                    switch (tipo)
                    {
                        case "cpf":
                            query = query.Where(q => q.Cliente.ConjCpf == texto);
                            break;
                        case "cnpj":
                            query = query.Where(q => q.Cliente.Cnpj == texto);
                            break;
                        case "cliente":
                            query = query.Where(q => q.Cliente.Conjuge == texto);
                            break;
                        case "codcliente":
                            query = query.Where(q => q.Cliente.Codcliente == Convert.ToInt32(texto));
                            break;
                        default:
                            // Tipo inválido, faça o tratamento apropriado aqui.
                            break;
                    }
                }

                var result = query.FirstOrDefault();
                return Ok(result);
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("busca-cliente")]
        public async Task<IActionResult> BuscaCliente(int codcliente)
        {
            try
            {
                var query = from usuario in _dbContext.TblUsuarios
                            join cliente in _dbContext.TblClientes on usuario.Codusuario equals cliente.Codusuario
                            where cliente.Codcliente == codcliente
                            select new
                            {
                                Cliente = cliente,
                                Usuario = usuario.Usuario,
                                BairroCliente = cliente.Codbairro.HasValue ? _dbContext.GetBairro(cliente.Codbairro.Value) : null,
                                CidadeCliente = cliente.Codcidade.HasValue ? _dbContext.GetCidade(cliente.Codcidade.Value) : null,
                                BairroEmpresa = cliente.EmpreCodbairro.HasValue ? _dbContext.GetBairro(cliente.EmpreCodbairro.Value) : null,
                                CidadeEmpresa = cliente.EmpreCodcidade.HasValue ? _dbContext.GetCidade(cliente.EmpreCodcidade.Value) : null,
                                BairroConjuje = cliente.CodbairroEmpConj.HasValue ? _dbContext.GetBairro(cliente.CodbairroEmpConj.Value) : null,
                                CidadeConjuje = cliente.CodcidadeEmpConj.HasValue ? _dbContext.GetCidade(cliente.CodcidadeEmpConj.Value) : null,
                                BairroCorrespondencia = cliente.CodbairroC.HasValue ? _dbContext.GetBairro(cliente.CodbairroC.Value) : null,
                                CidadeCorrespondencia = cliente.CodcidadeC.HasValue ? _dbContext.GetCidade(cliente.CodcidadeC.Value) : null
                            };

                var result = query.FirstOrDefault();

                return Ok(result);

            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("busca-cliente-prcessado")]
        public async Task<IActionResult> ClienteProcessado(int codcliente)
        {
            try
            {
                var query = _dbContext.TblCobrancaConts.Where(x => x.ClienteProcessado == true && x.Codcliente == codcliente).ToList();

                if(query != null)
                {
                    return Ok(true);
                }

                return Ok(false);

            }
            catch (Exception)
            {
                return Ok(false);
            }
        }

        [HttpGet]
        [Route("busca-cidade")]
        public async Task<IActionResult> BuscaCidade(int codcidade)
        {
            try
            {
                var query = _dbContext.TblCidades.Where(x => x.Codcidade == codcidade).ToList();
                return Ok(query[0].Cidade);

            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("foto-cliente")]
        public async Task<ActionResult> FotosClientes(string arquivo)
        {
            try
            {
                string filePath = Path.Combine(path, arquivo);

                if (System.IO.File.Exists(filePath))
                {
                    TratamentoImg tratamentoImg = new TratamentoImg();

                    MemoryStream decryptedImageStream = tratamentoImg.DecryptFile(filePath);

                    // Converter para PNG e salvar em um novo MemoryStream
                    MemoryStream pngStream = new MemoryStream();
                    using (var image = Image.Load(decryptedImageStream))
                    {
                        image.Save(pngStream, new PngEncoder());
                    }

                    // Retornar os bytes PNG para o cliente
                    return File(pngStream.ToArray(), "image/png");
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno: {ex.Message}"); // Retorna erro interno do servidor
            }
        }

        [HttpPost]
        [Route("solicita-contrato")]
        public async Task<int> SolicitaContrato(int codprepedido)
        {
            try
            {
                var prepedido = await _dbContext.TblPrePedidos.FirstOrDefaultAsync(p => p.Codprepedido == codprepedido && p.Impresso == 'N');

                if (prepedido != null)
                {
                    prepedido.SolContrato = 'S';

                    return await _dbContext.SaveChangesAsync();
                }

                return 0;

            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
