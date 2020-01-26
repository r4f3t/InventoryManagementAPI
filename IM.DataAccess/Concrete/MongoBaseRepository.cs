using IM.DataAccessLayer.Abstract;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace IM.DAL.Concrete
{
    public class MongoBaseRepository<Tmodel> : IMongoBaseRepository<Tmodel>
    {
        private IMongoCollection<Tmodel> todo;
        //business katmanları için encapsule edilmiş todo dışarıya açıldı
        public IMongoCollection<Tmodel> worker
        {
            get { return todo; }
            set
            {
                todo = value;
            }
        }
        public MongoBaseRepository(IMongoClient client)
        {
            var database = client.GetDatabase("InventoryManagement");
            todo = database.GetCollection<Tmodel>(typeof(Tmodel).Name);
        }



        public void Create(Tmodel o)
        {
            var document = new BsonDocument();

            todo.InsertOne(o);
        }

        public Tmodel Get(Expression<Func<Tmodel, bool>> filter)
        {
            return todo.Find(filter).FirstOrDefault();
        }


        public IEnumerable<Tmodel> SearchAsync(Expression<Func<Tmodel, bool>> filter = null)
        {
            var todos = ((filter == null) ? todo.Find(x => true).ToList() : todo.Find(filter).ToList());
            return todos;
        }

        public bool Remove(Expression<Func<Tmodel, bool>> filter)
        {
            var actionResult = todo.DeleteOne(filter);
            return actionResult.IsAcknowledged && actionResult.DeletedCount > 0;
        }

        public bool Update(Expression<Func<Tmodel, bool>> filter, Tmodel o)
        {
            ReplaceOneResult actionResult = todo.ReplaceOne(filter, o);
            return actionResult.IsAcknowledged && actionResult.ModifiedCount > 0;
        }
    }
}
