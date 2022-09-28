using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDal : IProductDal
    {

        Context _context = new Context();

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return filter==null
                ?_context.Set<Product>().ToList()
                :_context.Set<Product>().Where(filter).ToList();
        }

        //public List<Product> GetAll(List<string> include, Expression<Func<Product, bool>> filter = null)
        //{
        //    var model = _context.Set<Product>();

        //    foreach (var item in include)
        //    {
        //        model.Include(item);
        //    }
        //    return filter == null
        //            ? model.ToList()
        //            : model.Where(filter).ToList();
        //}
        public Product GetById(Expression<Func<Product, bool>> filter)
        {
            return _context.Set<Product>().SingleOrDefault(filter);
        }
    }
}
