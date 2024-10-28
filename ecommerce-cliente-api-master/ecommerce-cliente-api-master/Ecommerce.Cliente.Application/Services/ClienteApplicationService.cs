using Ecommerce.Cliente.Application.Dtos;
using Ecommerce.Cliente.Domain.Entities;
using Ecommerce.Cliente.Domain.Interfaces;
using Ecommerce.Cliente.Domain.Interfaces.Dtos;
using MongoDB.Bson;

namespace Ecommerce.Cliente.Application.Services
{
    public class ClienteApplicationService : IClienteApplicationService
    {
        private readonly IClienteRepository _repository;

        public ClienteApplicationService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public IClienteRequestDto AdicionarCliente(IClienteDto entity)
        {
            var cliente = _repository.Adicionar(new ClienteEntity
            {
                Nome = entity.Nome,
                SobreNome = entity.SobreNome,
                Email = entity.Email,
                Idade = entity.Idade,
            });

            return new ClienteRequestDto
            {
                Id = cliente.Id.ToString(),
                Nome = cliente.Nome,
                SobreNome = cliente.SobreNome,
                Email = cliente.Email,
                Idade = cliente.Idade,
            };
        }

        public IClienteRequestDto EditarCliente(string id, IClienteDto entity)
        {
            var cliente = _repository.Editar(new ClienteEntity
            {
                Id = ObjectId.Parse(id),
                Nome = entity.Nome,
                SobreNome = entity.SobreNome,
                Email = entity.Email,
                Idade = entity.Idade,
            });

            return new ClienteRequestDto
            {
                Id = cliente.Id.ToString(),
                Nome = cliente.Nome,
                SobreNome = cliente.SobreNome,
                Email = cliente.Email,
                Idade = cliente.Idade,
            };
        }

        public IClienteRequestDto ObterClientePorId(string id)
        {
            var cliente = _repository.ObterPorId(id);

            return new ClienteRequestDto
            {
                Id = cliente.Id.ToString(),
                Nome = cliente.Nome,
                SobreNome = cliente.SobreNome,
                Email = cliente.Email,
                Idade = cliente.Idade,
            };
        }

        public IEnumerable<IClienteRequestDto> ObterTodosClientes()
        {
            return _repository.ObterTodos().Select(cliente => new ClienteRequestDto
            {
                Id = cliente.Id.ToString(),
                Nome = cliente.Nome,
                SobreNome = cliente.SobreNome,
                Email = cliente.Email,
                Idade = cliente.Idade,
            });
        }

        public IClienteRequestDto RemoverCliente(string id)
        {
            var cliente = _repository.Remover(id);

            return new ClienteRequestDto
            {
                Id = cliente.Id.ToString(),
                Nome = cliente.Nome,
                SobreNome = cliente.SobreNome,
                Email = cliente.Email,
                Idade = cliente.Idade,
            };
        }
    }
}
