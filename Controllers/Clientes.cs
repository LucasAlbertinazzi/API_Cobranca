﻿using API_AppCobranca.Models;
using API_AppCobranca.Suporte;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp.Formats.Png;

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
    }
}
