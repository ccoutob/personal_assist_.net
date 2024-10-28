using MongoDB.Driver;

namespace Ecommerce.Cliente.Data.Factory
{
    public class DataFactory
    {
        public static IMongoDatabase CreateInstance(string connectionString)
        {
            var _databaseName = MongoUrl.Create(connectionString).DatabaseName;
            return new MongoClient(connectionString).GetDatabase(_databaseName);
        }
    }
}
