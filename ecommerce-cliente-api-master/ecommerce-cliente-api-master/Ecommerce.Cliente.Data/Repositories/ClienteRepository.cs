using Ecommerce.Cliente.Domain.Entities;
using Ecommerce.Cliente.Domain.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Ecommerce.Cliente.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IMongoDatabase _database;

        public ClienteRepository(IMongoDatabase database)
        {
            _database = database;
        }

        public ClienteEntity Adicionar(ClienteEntity cliente)
        {
            var collection = _database.GetCollection<ClienteEntity>(nameof(ClienteEntity));
            collection.InsertOne(cliente);

            return cliente;
        }

        public IEnumerable<ClienteEntity> Adicionar(IEnumerable<ClienteEntity> cliente)
        {
            var collection = _database.GetCollection<ClienteEntity>(nameof(ClienteEntity));
            collection.InsertMany(cliente);

            return cliente;
        }

        public ClienteEntity Editar(ClienteEntity cliente)
        {
            var collection = _database.GetCollection<ClienteEntity>(nameof(ClienteEntity));

            var resultado = collection.FindOneAndReplace(x => x.Id == cliente.Id, cliente);

            return resultado;
        }

        public ClienteEntity ObterPorId(string id)
        {
            var collection = _database.GetCollection<ClienteEntity>(nameof(ClienteEntity));

            return collection.Find(x => x.Id == ObjectId.Parse(id)).FirstOrDefault();
        }

        public IEnumerable<ClienteEntity> ObterTodos()
        {
            var collection = _database.GetCollection<ClienteEntity>(nameof(ClienteEntity));

            return collection.Find(_ => true).ToEnumerable();
        }

        public ClienteEntity Remover(string id)
        {
            var collection = _database.GetCollection<ClienteEntity>(nameof(ClienteEntity));
            var resultado = collection.FindOneAndDelete(x => x.Id == ObjectId.Parse(id));

            return resultado;
        }
    }
}
