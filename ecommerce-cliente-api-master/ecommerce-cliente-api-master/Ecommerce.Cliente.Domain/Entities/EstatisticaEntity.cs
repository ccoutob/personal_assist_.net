using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Ecommerce.Estatistica.Domain.Entities
{
	[BsonIgnoreExtraElements]
	public class EstatisticaEntity
	{
		//[Key] - Utilizado no Entity para indicar o campo chave (Identificador) da base de dados (Tabela)
		[BsonId]
		public ObjectId Id { get; set; }
		public int MediaCrescimento { get; set; } = int.Empty;
		public int CrescimentoMensal { get; set; } = int.Empty;
		public int Receita { get; set; } = int.Empty;
	}
}