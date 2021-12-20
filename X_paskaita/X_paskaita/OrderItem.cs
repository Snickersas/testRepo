using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_paskaita
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }    
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public double? PurchasePrice { get; set; }


        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
            }

         
            return isValid;
        }



        public bool Save()
        {
            //CustomerRepository.Save(OrderItem orderitem)  //kita klase su save metodu
            return true;
        }

        public OrderItem Retrieve()
        {
            //CustomerRepository.GetById(customerId)
            return new OrderItem();
        }

    }
}
