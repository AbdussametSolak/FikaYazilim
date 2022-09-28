using Business;
using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new ProductDal());
        
        // GET: Product
        public ActionResult Index()
        {
            var list = productManager.GetAll();
            return View(list);
        }
        [HttpPost]
        public PartialViewResult Liste()
        {
            var list = productManager.GetAll();
            return PartialView(list);

        }
        

        [HttpPost]
        public PartialViewResult GetDetails(int id)
        
        {
            var product = productManager.GetById(id);
            return PartialView(product);

        }

        [HttpPost]
        public PartialViewResult FilterByCategory(int id)
        {
            var list= productManager.GetListByCategory(id);  
            return PartialView(list);
        }
    }
}