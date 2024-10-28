using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Ecommerce.Cliente.Domain.Entities
{
    [BsonIgnoreExtraElements]
    public class ClienteEntity
    {
        //[Key] - Utilizado no Entity para indicar o campo chave (Identificador) da base de dados (Tabela)
        [BsonId]
        public ObjectId Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string SobreNome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Idade { get; set; }
    }
}
