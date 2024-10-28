using Ecommerce.Cliente.Domain.Interfaces.Dtos;

namespace Ecommerce.Cliente.Application.Dtos
{
    public class ClienteDto : IClienteDto
    {
        public string Nome { get; set; } = string.Empty;
        public string SobreNome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Idade { get; set; }
    }
}
