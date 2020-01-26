using IM.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace IM.Services.Abstract
{
    public interface IUserService
    {
        ICollection<User> GetUsers(Expression<Func<User,bool>> filter=null);
        string CreateUser(User user);
        string UpdateUser(User user);
        string DeleteUser(string userId);
    }
}
