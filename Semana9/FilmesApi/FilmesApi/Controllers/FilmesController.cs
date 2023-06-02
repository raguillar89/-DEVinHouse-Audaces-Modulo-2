using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [Route("api/v{version:apiVersion}/filmes")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        /// <summary>
        /// Retorma uma Lista de Filmes
        /// </summary>
        /// <returns>Sucesso o retorno de uma Lista de Filmes</returns>
        /// <response code="200">Sucesso no retorno da Lista de Filmes</response>
        [HttpGet]
        public IEnumerable<Filme> Get()
        {
            return MockFilmes.Filmes;
        }

        /// <summary>
        /// Requisição de um Filme
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Sucesso no retorno de um Filme</returns>
        /// <response code="204">Sucesso no retorno de um Filme</response>
        /// <response code="404">Não foi encontrado o Filme na Lista com o Id informado</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Filme filme = MockFilmes.Filmes.FirstOrDefault(x => x.FilmeId == id);

            if (filme is null)
            {
                return NotFound();
            }
            return Ok(filme);
        }

        /// <summary>
        /// Criação de um Filme
        /// </summary>
        /// <param name="filme"></param>
        /// <returns>Sucesso a criação de um Filme</returns>
        /// <response code="201">Sucesso na criação do Filme</response>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [HttpPost]
        public IActionResult Post([FromBody] Filme filme)
        {
            MockFilmes.Filmes.Add(filme);
            return CreatedAtAction(nameof(Get), new { id = filme.FilmeId }, filme);
        }

        /// <summary>
        /// Atualização de um Filme
        /// </summary>
        /// <param name="id"></param>
        /// <param name="filme"></param>
        /// <returns>Sucesso a atualização do Filme</returns>
        /// <response code="204">Sucesso na atualização do Filme</response>
        /// <response code="404">Não foi encontrado o Filme na Lista com o Id informado</response>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Filme filme)
        {
            Filme filmeUpdate = MockFilmes.Filmes.FirstOrDefault(x => x.FilmeId == id);
            if (filmeUpdate is null)
            {
                return NotFound();
            }

            var index = MockFilmes.Filmes.IndexOf(filmeUpdate);
            if (index != -1)
            {
                MockFilmes.Filmes[index] = filme;                
            }
            return NoContent();
        }

        /// <summary>
        /// Exclusão do Filme
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Sucesso na exclusão do Filme</returns>
        /// <response code="204">Sucesso a exclusão do Filme</response>
        /// <response code="404">Não foi encontrado o Filme na Lista com o Id informado</response>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Filme filmeDelete = MockFilmes.Filmes.FirstOrDefault(x => x.FilmeId == id);

            if (filmeDelete is null)
            {
                return NotFound();
            }            
            MockFilmes.Filmes.Remove(filmeDelete);
            return NoContent();
        }
    }
}
