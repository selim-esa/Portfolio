using Data.Abstract;
using Data.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new DbAccess();
            c.Remove(t);
            c.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var c = new DbAccess();
            return c.Set<T>().ToList();
        }

        public T GetById(int id)
        {
           using var c = new DbAccess();
            return c.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            using var c = new DbAccess();
            c.Add(t);
            c.SaveChanges();

        }

        public void Update(T t)
        {
            using var c = new DbAccess();
            c.Update(t);
            c.SaveChanges();
                
        }
    }
}
