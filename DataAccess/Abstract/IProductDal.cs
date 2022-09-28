using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IProductDal
    {
        List<Product> GetAll(Expression<Func<Product, bool>> filter = null);
        Product GetById(Expression<Func<Product, bool>> filter);
    }
}
