using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<TEntity,TContext> : IGenericDal<TEntity>
        where TEntity : class, new()
        where TContext : DbContext, new()
    {

        public void Add(TEntity entity)//ekleme işlemi için
        {
            using var c = new TContext();
            c.Add(entity);
            c.SaveChanges();
        }

        public void Delete(TEntity entity)//silme işlemi için
        {
            using var c = new TContext();
            c.Remove(entity);
            c.SaveChanges();
        }

        public List<TEntity> GetAll()//listeleme için
        {
            using var c = new TContext();
            return c.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)//Güncelleme işlemleri için id ye ihtiyaç var
        {
            using var c = new TContext();
            return c.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetListAll(Expression<Func<TEntity, bool>> filter)
        {
            using var c = new TContext();
            return c.Set<TEntity>().Where(filter).ToList();
        }

        public void Update(TEntity entity)//güncelleme işlemi
        {
            using var c = new TContext();
            c.Update(entity);
            c.SaveChanges();
        }
    }
}
