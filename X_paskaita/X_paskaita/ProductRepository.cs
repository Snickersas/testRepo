using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_paskaita
{
   


    public class ProductRepository
    {
      
        private List<Product> Products { get; set; } = new List<Product>();
       

        public bool SaveProduct(Product product)
        {
            Products.Add(product);
            return true;
        }

        public List<Product> GetProducts()
        {
            return Products;
        }

    }
}
