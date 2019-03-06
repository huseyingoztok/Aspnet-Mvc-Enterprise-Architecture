using NorthWind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Dal.Abstract
{
    public interface IEntityRepository<T>
        where T:class,IEntity, new ()
    {
        List<T> GetAll(Expression<Func<T,bool>> expression=null); //Optional filter
        T Get(int Id);
        int Add(T TEntity);
        int Update(T TEntity);
        int Delete(T TEntity);
    }
}
