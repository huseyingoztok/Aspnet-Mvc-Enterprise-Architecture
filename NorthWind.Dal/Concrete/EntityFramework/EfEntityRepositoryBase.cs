using NorthWind.Dal.Abstract;
using NorthWind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Dal.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public int Add(TEntity TEntity)
        {
            using (var context=new TContext())
            {
                var entity = context.Entry(TEntity);
                entity.State = EntityState.Added;
                return context.SaveChanges();
            }
        }

        public int Delete(TEntity TEntity)
        {
            //Kayıtlar veritabanından direkt olarak silinmeyecek...
            using (var context=new TContext())
            {
                var entity = context.Entry(TEntity);
                entity.State = EntityState.Deleted;
                return context.SaveChanges();
            }
        }

        public TEntity Get(int Id)
        {
            using (var context=new TContext())
            {
                return context.Set<TEntity>().Find(Id);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> expression = null)
        {
            using (var context=new TContext())
            {
                return expression==null? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(expression).ToList();
            }

        }

        public int Update(TEntity TEntity)
        {
            using (var context =new TContext())
            {
                var entity = context.Entry(TEntity);
                entity.State = EntityState.Modified;
                return context.SaveChanges();
            }
        }
    }
}
