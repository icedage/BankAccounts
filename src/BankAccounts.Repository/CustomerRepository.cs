using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository;
using BankAccounts.Repository.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace BankAccounts.Repository
{
    public class CustomerRepository : IMongoDBRepository<Customer>
    {
        private IMongoClient _client;
        private IMongoDatabase _mongoDatabase;
        private IMongoCollection<Customer> _mongoCollection;

        public CustomerRepository(string table)
        {
            _client = new MongoClient(string.Empty);
            _mongoDatabase = _client.GetDatabase(table);
            _mongoCollection = _mongoDatabase.GetCollection<Customer>("");
        }

        public IEnumerable<Customer> GetAll()
        {
            return null;
        }

        public Customer Get(string id)
        {
            var query = Query.EQ("_id", id);
            return null;
        }

        public void Add(Customer item)
        {
            item.Id = ObjectId.GenerateNewId().ToString();
            Task.Factory.StartNew(async () => await _mongoCollection.InsertOneAsync(item));
        }

        public void Remove(string id)
        {
            IMongoQuery query = Query.EQ("_id", id);
            Task.Factory.StartNew(async () => await _mongoCollection.DeleteOneAsync(id));
        }

        public void Update(Customer item)
        {
            var query = Query.EQ("_id", item.Id);

        }
    }
}
