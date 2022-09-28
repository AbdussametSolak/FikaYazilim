using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }

        public int categoryId { get; set; }
        public virtual Category category { get; set; }

    }
}
