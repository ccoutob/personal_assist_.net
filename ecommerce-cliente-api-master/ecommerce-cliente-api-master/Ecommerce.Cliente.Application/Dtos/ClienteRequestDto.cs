using Ecommerce.Cliente.Domain.Interfaces.Dtos;

namespace Ecommerce.Cliente.Application.Dtos
{
    public class ClienteRequestDto : ClienteDto, IClienteRequestDto
    {
        public string Id { get; set; }
    }
}
