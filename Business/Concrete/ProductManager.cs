using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();    
        }

        public Product GetById(int productId)
        {
            return _productDal.GetById(p=>p.productId==productId);
        }

        public List<Product> GetListByCategory(int id)
        {
            return _productDal.GetAll(p => p.categoryId == id);
        }
    }
}
