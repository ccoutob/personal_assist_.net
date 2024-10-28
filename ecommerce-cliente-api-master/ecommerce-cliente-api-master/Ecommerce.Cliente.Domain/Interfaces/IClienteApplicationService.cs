using Ecommerce.Cliente.Domain.Interfaces.Dtos;

namespace Ecommerce.Cliente.Domain.Interfaces
{
    public interface IClienteApplicationService
    {
        IEnumerable<IClienteRequestDto> ObterTodosClientes();
        IClienteRequestDto ObterClientePorId(string id);
        IClienteRequestDto AdicionarCliente(IClienteDto entity);
        IClienteRequestDto EditarCliente(string id, IClienteDto entity);
        IClienteRequestDto RemoverCliente(string id);
    }
}
