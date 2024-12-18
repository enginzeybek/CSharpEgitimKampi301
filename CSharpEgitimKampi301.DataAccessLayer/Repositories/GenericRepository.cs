using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        CampContext context = new CampContext();

        private readonly DbSet<T> _object;

        public GenericRepository()
        {
            _object = context.Set<T>();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public List<T> GetListAll()
        {
            return _object.ToList();
        }

        public void Insert(T entity)
        {
            var value = context.Entry(entity);

            value.State = EntityState.Added;

            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var value = context.Entry(entity);

            value.State = EntityState.Modified;

            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            var value = context.Entry(entity);

            value.State = EntityState.Deleted;

            context.SaveChanges();
        }
    }
}
