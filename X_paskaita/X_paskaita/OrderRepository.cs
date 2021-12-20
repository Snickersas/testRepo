using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_paskaita
{
    public class OrderRepository
    {
      
        private List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

     

        public bool SaveOrderItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
            return true;
        }

        public List<OrderItem> GetOrderItems()
        {
            return OrderItems;
        }






    }
}
