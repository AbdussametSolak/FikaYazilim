using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int productId);
        List<Product> GetListByCategory(int id);
    }
}
