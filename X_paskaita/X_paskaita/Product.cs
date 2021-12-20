using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_paskaita
{
    public class Product
    {
        public int ProductId { get; set; }  
        public string ProductName { get; set; }

        public string Description { get; set; } 

        public double CurrentPrice { get; set; }


        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(Description))
            {
                isValid = false;
            }
            return isValid;
        }



        public bool Save()
        {
            //CustomerRepository.Save(Customer customer)  //kita klase su save metodu
            return true;
        }

        public Product Retrieve()
        {
            //CustomerRepository.GetById(customerId)
            return new Product();
        }

    }
}
