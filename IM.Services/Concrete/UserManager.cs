using IM.Core.Domains;
using IM.DAL.Concrete;
using IM.Services.Abstract;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace IM.Services.Concrete
{
    public class UserManager : MongoBaseRepository<User>, IUserService
    {
        public UserManager(IMongoClient client) : base(client)
        {
        }

        public string CreateUser(User user)
        {
            Create(user);
            return "Ok";
        }

        public string DeleteUser(string userId)
        {
            throw new NotImplementedException();
        }

        public ICollection<User> GetUsers(Expression<Func<User, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public string UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
