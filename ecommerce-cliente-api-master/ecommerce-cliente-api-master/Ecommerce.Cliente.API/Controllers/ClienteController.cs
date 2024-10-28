using Ecommerce.Cliente.Application.Dtos;
using Ecommerce.Cliente.Domain.Entities;
using Ecommerce.Cliente.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Ecommerce.Cliente.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteApplicationService _applicationService;

        public ClienteController(IClienteApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpGet]
        [Produces<IEnumerable<ClienteEntity>>]
        public IActionResult Get()
        {
            var categorias = _applicationService.ObterTodosClientes();

            if (categorias is not null)
                return Ok(categorias);

            return BadRequest("Não foi possivel obter os dados");
        }


        [HttpGet("{id}")]
        [Produces<ClienteEntity>]
        public IActionResult GetPorId(string id)
        {
            var categorias = _applicationService.ObterClientePorId(id);

            if (categorias is not null)
                return Ok(categorias);

            return BadRequest("Não foi possivel obter os dados");
        }

        [HttpPost]
        [Produces<ClienteEntity>]
        public IActionResult Post(ClienteDto entity)
        {
            try
            {
                var categorias = _applicationService.AdicionarCliente(entity);

                if (categorias is not null)
                    return Ok(categorias);

                return BadRequest("Não foi possivel salvar os dados");
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Error = ex.Message,
                    Status = HttpStatusCode.BadRequest,
                });
            }
        }

        [HttpPut("{id}")]
        [Produces<ClienteEntity>]
        public IActionResult Put(string id, ClienteDto entity)
        {
            try
            {
                var categorias = _applicationService.EditarCliente(id, entity);

                if (categorias is not null)
                    return Ok(categorias);

                return BadRequest("Não foi possivel editar os dados");
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Error = ex.Message,
                    Status = HttpStatusCode.BadRequest,
                });
            }
        }

        [HttpDelete("{id}")]
        [Produces<ClienteEntity>]
        public IActionResult Delete(string id)
        {
            var categorias = _applicationService.RemoverCliente(id);

            if (categorias is not null)
                return Ok(categorias);

            return BadRequest("Não foi possivel deletar os dados");
        }
    }
}
