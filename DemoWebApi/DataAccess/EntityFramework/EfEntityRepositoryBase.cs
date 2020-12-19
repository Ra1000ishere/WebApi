using DemoWebApi.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DemoWebApi.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public TEntity Add(TEntity entity)
        {
            using (var db = new TContext())
            {
                var addedEntity = db.Entry(entity);
                addedEntity.State = EntityState.Added;
                db.SaveChanges();
                return entity;

            }
        }

        public void Delete(TEntity entity)
        {
            using (var db = new TContext())
            {
                var deletedentity = db.Entry(entity);
                deletedentity.State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var db = new TContext())
            {
                return db.Set<TEntity>().SingleOrDefault(filter);
            }
           
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var db = new TContext())
            {
                return filter == null ? db.Set<TEntity>().ToList() 
                    : db.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (var db = new TContext())
            {

                var updadedEntity = db.Entry(entity);
                updadedEntity.State = EntityState.Modified;
                db.SaveChanges();
            }
            
        }
    }
}
