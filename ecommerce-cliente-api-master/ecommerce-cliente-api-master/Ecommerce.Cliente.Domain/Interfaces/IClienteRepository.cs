﻿using Ecommerce.Cliente.Domain.Entities;

namespace Ecommerce.Cliente.Domain.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<ClienteEntity> ObterTodos();
        ClienteEntity ObterPorId(string id);
        ClienteEntity Adicionar(ClienteEntity cliente);
        ClienteEntity Editar(ClienteEntity cliente);
        ClienteEntity Remover(string id);
    }
}
