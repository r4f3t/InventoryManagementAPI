using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace IM.DataAccessLayer.Abstract
{
    public interface IMongoBaseRepository<Tmodel>
    {
        Tmodel Get(Expression<Func<Tmodel, bool>> filter);
        IEnumerable<Tmodel> SearchAsync(Expression<Func<Tmodel, bool>> filter = null);
        void Create(Tmodel o);
        bool Update(Expression<Func<Tmodel, bool>> filter, Tmodel o);
        bool Remove(Expression<Func<Tmodel, bool>> filter);
    }
}
