using DemoWebApi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DemoWebApi.DataAccess
{
   public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
