using ECommerceProject.Data.Models.ORM.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Business
{
   public class GenericRepository<T> where T:class
    {
        IObjectContextAdapter _context;
        IObjectSet<T> _objectSet;

        public GenericRepository()
        {

            _context = new ECommerceContext();
            _objectSet = _context.ObjectContext.CreateObjectSet<T>();
        }

        public List<T> List()
        {
            List<T> liste = _objectSet.ToList();
            return liste;
        }

        public List<T> GetListWithQuery(Expression<Func<T, bool>> lambda)
        {
            return _objectSet.Where(lambda).ToList();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> lambda)
        {
           return _objectSet.FirstOrDefault(lambda);
        }

        public void Delete(T entity)
        {
            _objectSet.DeleteObject(entity);
            _context.ObjectContext.SaveChanges();
            

        }


        public void Add(T entity)
        {
            _objectSet.AddObject(entity);
            _context.ObjectContext.SaveChanges();
         
        }





    }
}
