using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interface;
using senai.inlock.webApi.Repositores;

namespace senai.inlock.webApi.Controller
{
    [Route("api/[controller]")]

    [ApiController]

    [Produces("application/json")]

    [Authorize]
    public class EstudioController : ControllerBase
    {

        private IEstudioRepository _estudioRepository { get; set; }

        public EstudioController()
        {
            _estudioRepository = new EstudioRepository();
        }


        [HttpGet]
        [Authorize(Roles = "Administrador, Comum")]
        public IActionResult Get()
        {
            try
            {
                List<EstudioDomain> ListaEstudio = _estudioRepository.ListarTodos();

                return Ok(ListaEstudio);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        [HttpPost]
        [Authorize(Roles = "Administrador")]
        public IActionResult Post(EstudioDomain novoEstudio)
        {
            try
            {
                _estudioRepository.Cadastrar(novoEstudio);

                return StatusCode(201);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            try
            {
                _estudioRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                EstudioDomain estudioBuscado = _estudioRepository.BuscarPorId(id);

                if (estudioBuscado == null)
                {
                    return NotFound("Nenhum Estúdio foi encontrado");
                }

                return Ok(estudioBuscado);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }

        }

        [HttpPut("{id}")]
        public IActionResult PutId(int id, EstudioDomain estudio)
        {
            try
            {
                EstudioDomain estudioAtualizado = _estudioRepository.BuscarPorId(id);

                if (estudioAtualizado == null)
                {
                    return NotFound("Invàlido");
                }

                estudio.IdEstudio = id;

                _estudioRepository.AtualizarIdUrl(id, estudio);

                return Ok(estudioAtualizado);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }
    }
}

