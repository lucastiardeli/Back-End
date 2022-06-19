using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontosTuristicosApi.Models;
using PontosTuristicosApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PontosTuristicosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PontosController : ControllerBase
    {
        private IPontoService _pontoService;
        public PontosController(IPontoService pontoService)
        {
            _pontoService = pontoService;
        }

        [HttpGet]
        public async Task<ActionResult<IAsyncEnumerable<Ponto>>>GetPontos()

        {
            try
            {
                var pontos = await _pontoService.GetPontos();
                return Ok(pontos);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao encontrar Pontos Turisticos");
            }
        }

        [HttpGet("Search By Name")]
        public async Task<ActionResult<IAsyncEnumerable<Ponto>>> GetPontosByNome([FromQuery] string nome)

        {
            try
            {
                var pontos = await _pontoService.GetPontosByNome(nome);
                if (pontos.Count() == 0)
                    return NotFound($"Não foram encontrados Pontos Turisticos{nome}");

                return Ok(pontos);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao encontrar Pontos Turisticos");
            }
        }
           
        [HttpGet("{id:int}", Name = "GetPonto")]
        
        public async Task <ActionResult<Ponto>> GetPonto (int id)
        {
            try
            {
                var ponto = await _pontoService.GetPonto(id);
                if (ponto == null)
                    return NotFound($"Não foram encontrados Pontos Turisticos com id={id}");

                return Ok(ponto);
            }
            catch
            {
                return BadRequest("Request Invalido");
            }

        }

        [HttpPost]
        public async Task<ActionResult> Create(Ponto ponto)
        {
            try
            {
                await _pontoService.CreatePonto(ponto);
                    return CreatedAtRoute(nameof(GetPonto), new {id = ponto.Id }, ponto);
            }
            catch
            {
                return BadRequest("Resquest Invalido");
            }

        }

        [HttpPut("{id:int}")]

        public async Task<ActionResult> Edit (int id, [FromBody] Ponto ponto)
            {
                try
                {
                    if (ponto.Id == id)
                    {
                        await _pontoService.UpdatePonto(ponto);
                        return Ok($"Ponto com id={id} foi atualizado com sucesso");
                    }
                    else
                    {
                        return BadRequest("Dados Invalidos.");
                    }
                }
                catch
                {
                    return BadRequest("Request Invalido");
                }
            }    
     
        [HttpDelete]

        public async Task<ActionResult> Delete (int id)
        {
            try
            {
                var aluno = await _pontoService.GetPonto(id);
                if (aluno != null)
                {
                    await _pontoService.DeletePonto(aluno);
                    return Ok($"Ponto com id={id} foi excluido com sucesso");
                }
                else
                {
                    return NotFound($"Ponto com id={id} não econtrado");
                }
            }
            catch
            {
                return BadRequest("Request Invalido");
            }
        }
    
    
    }
}
