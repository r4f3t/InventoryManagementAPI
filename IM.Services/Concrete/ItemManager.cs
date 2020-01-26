using IM.Core.Domains;
using IM.DAL.Concrete;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace IM.Services.Concrete
{
    public class ItemManager : MongoBaseRepository<Item>, IItemService
    {
        public ItemManager(IMongoClient client) : base(client)
        {
        }
        public string CreateItem(Item item)
        {
            Create(item);
            return "Ok";
        }

        public string DeleteItem(string itemId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetItems(Expression<Func<Item, bool>> filter = null)
        {
            return SearchAsync(filter);
        }

     
        public string UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }

       
    }
}
