using NorthWind.Dal.Abstract;
using NorthWind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Dal.Concrete.EntityFramework
{
    class NhEntityRepositoryBas<TContext, TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
       // where TContext : DbContext, new()
    {
        public int Add(TEntity TEntity)
        {
            throw new NotImplementedException();
        }

        public int Delete(TEntity TEntity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public int Update(TEntity TEntity)
        {
            throw new NotImplementedException();
        }
    }
}
